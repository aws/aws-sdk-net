using System.Buffers;
using System.Diagnostics;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Simulates multipart downloads using real ArrayPool allocations.
/// Mimics the ChunkedBufferStream and PartBufferManager behavior from the SDK.
/// </summary>
public class DownloadSimulator : IDisposable
{
    private readonly VmaMonitor _vmaMonitor;
    private readonly List<SimulatedPart> _activeParts = new();
    private readonly object _lock = new();
    private bool _disposed;

    /// <summary>
    /// Metrics collected during simulation.
    /// </summary>
    public SimulationMetrics Metrics { get; private set; } = new();

    public DownloadSimulator(VmaMonitor vmaMonitor)
    {
        _vmaMonitor = vmaMonitor;
    }

    /// <summary>
    /// Simulates a multipart download with specified parameters.
    /// </summary>
    /// <param name="config">Configuration for the simulation.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Metrics from the simulation.</returns>
    public async Task<SimulationMetrics> SimulateDownloadAsync(SimulationConfig config, CancellationToken cancellationToken = default)
    {
        _vmaMonitor.Reset();
        Metrics = new SimulationMetrics
        {
            Config = config,
            StartTime = DateTime.UtcNow
        };

        var stopwatch = Stopwatch.StartNew();
        var completedParts = 0;
        var semaphore = new SemaphoreSlim(config.ConcurrentServiceRequests);
        var bufferCapacity = new SemaphoreSlim(config.MaxInMemoryParts);
        var random = new Random(42); // Fixed seed for reproducibility

        try
        {
            var downloadTasks = new List<Task>();

            // Simulate downloading all parts
            for (int partNum = 1; partNum <= config.TotalParts && !cancellationToken.IsCancellationRequested; partNum++)
            {
                var currentPart = partNum;
                
                // Wait for buffer capacity
                await bufferCapacity.WaitAsync(cancellationToken);
                
                // Wait for HTTP concurrency slot
                await semaphore.WaitAsync(cancellationToken);

                downloadTasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        // Simulate network download time
                        var downloadTimeMs = config.SimulateNetworkDelay 
                            ? random.Next(10, 100) 
                            : 0;
                        await Task.Delay(downloadTimeMs, cancellationToken);

                        // Allocate chunks for this part (mimics ChunkedBufferStream)
                        var part = AllocatePart(currentPart, config.PartSizeBytes, config.ChunkSizeBytes);
                        
                        // Update VMA tracking
                        _vmaMonitor.UpdatePeak();
                        
                        // Simulate processing time
                        if (config.SimulateProcessingDelay)
                        {
                            await Task.Delay(random.Next(5, 50), cancellationToken);
                        }

                        // Simulate consumer reading and releasing the part
                        // In real scenario, consumer reads sequentially
                        // Here we simulate with a delay before release
                        await Task.Delay(config.SimulateConsumerReadTimeMs, cancellationToken);
                        
                        ReleasePart(part);
                        
                        Interlocked.Increment(ref completedParts);
                        Metrics.TotalBytesProcessed += config.PartSizeBytes;
                    }
                    finally
                    {
                        semaphore.Release();
                        bufferCapacity.Release();
                    }
                }, cancellationToken));

                // Periodically update metrics
                if (partNum % 10 == 0)
                {
                    var snapshot = _vmaMonitor.TakeSnapshot();
                    Metrics.VmaSnapshots.Add(snapshot);
                }
            }

            // Wait for all downloads to complete
            await Task.WhenAll(downloadTasks);
        }
        finally
        {
            stopwatch.Stop();
            semaphore.Dispose();
            bufferCapacity.Dispose();

            // Final metrics
            Metrics.EndTime = DateTime.UtcNow;
            Metrics.DurationMs = stopwatch.ElapsedMilliseconds;
            Metrics.CompletedParts = completedParts;
            Metrics.FinalVmaSnapshot = _vmaMonitor.TakeSnapshot();
            Metrics.PeakVmaCount = _vmaMonitor.PeakVmaCount;
            Metrics.ThroughputMBps = Metrics.TotalBytesProcessed / 1024.0 / 1024.0 / (Metrics.DurationMs / 1000.0);
        }

        return Metrics;
    }

    /// <summary>
    /// Allocates ArrayPool chunks for a part, mimicking ChunkedBufferStream.
    /// </summary>
    private SimulatedPart AllocatePart(int partNumber, long partSizeBytes, int chunkSizeBytes)
    {
        var chunksNeeded = (int)Math.Ceiling((double)partSizeBytes / chunkSizeBytes);
        var chunks = new List<byte[]>(chunksNeeded);

        lock (_lock)
        {
            for (int i = 0; i < chunksNeeded; i++)
            {
                var chunk = ArrayPool<byte>.Shared.Rent(chunkSizeBytes);
                chunks.Add(chunk);
                _vmaMonitor.RecordAllocation();
                Metrics.TotalAllocations++;
            }

            var part = new SimulatedPart
            {
                PartNumber = partNumber,
                Chunks = chunks,
                ChunkSize = chunkSizeBytes
            };
            
            _activeParts.Add(part);
            Metrics.CurrentActiveChunks = _activeParts.Sum(p => p.Chunks.Count);
            Metrics.PeakActiveChunks = Math.Max(Metrics.PeakActiveChunks, Metrics.CurrentActiveChunks);
            
            return part;
        }
    }

    /// <summary>
    /// Releases all chunks for a part back to ArrayPool.
    /// </summary>
    private void ReleasePart(SimulatedPart part)
    {
        lock (_lock)
        {
            foreach (var chunk in part.Chunks)
            {
                ArrayPool<byte>.Shared.Return(chunk);
                _vmaMonitor.RecordDeallocation();
                Metrics.TotalDeallocations++;
            }
            
            _activeParts.Remove(part);
            Metrics.CurrentActiveChunks = _activeParts.Sum(p => p.Chunks.Count);
        }
    }

    /// <summary>
    /// Runs a simulation that mimics directory download with multiple concurrent files.
    /// </summary>
    public async Task<List<SimulationMetrics>> SimulateDirectoryDownloadAsync(
        List<SimulationConfig> fileConfigs,
        int maxConcurrentFiles,
        CancellationToken cancellationToken = default)
    {
        var results = new List<SimulationMetrics>();
        var fileSemaphore = new SemaphoreSlim(maxConcurrentFiles);
        var tasks = new List<Task<SimulationMetrics>>();

        _vmaMonitor.Reset();

        foreach (var config in fileConfigs)
        {
            await fileSemaphore.WaitAsync(cancellationToken);
            
            tasks.Add(Task.Run(async () =>
            {
                try
                {
                    return await SimulateDownloadAsync(config, cancellationToken);
                }
                finally
                {
                    fileSemaphore.Release();
                }
            }, cancellationToken));
        }

        var completedResults = await Task.WhenAll(tasks);
        results.AddRange(completedResults);
        
        fileSemaphore.Dispose();
        
        return results;
    }

    public void Dispose()
    {
        if (_disposed) return;
        
        // Release any remaining parts
        lock (_lock)
        {
            foreach (var part in _activeParts)
            {
                foreach (var chunk in part.Chunks)
                {
                    ArrayPool<byte>.Shared.Return(chunk);
                }
            }
            _activeParts.Clear();
        }
        
        _disposed = true;
    }
}

/// <summary>
/// Configuration for a download simulation.
/// </summary>
public class SimulationConfig
{
    /// <summary>
    /// Descriptive name for this test scenario.
    /// </summary>
    public string Name { get; set; } = "Unnamed";

    /// <summary>
    /// Size of each part in bytes.
    /// </summary>
    public long PartSizeBytes { get; set; } = 10 * 1024 * 1024; // 10MB default

    /// <summary>
    /// Size of each chunk in bytes (ArrayPool allocation unit).
    /// </summary>
    public int ChunkSizeBytes { get; set; } = 65536; // 64KB default

    /// <summary>
    /// Total number of parts to download.
    /// </summary>
    public int TotalParts { get; set; } = 100;

    /// <summary>
    /// Maximum concurrent HTTP requests.
    /// </summary>
    public int ConcurrentServiceRequests { get; set; } = 10;

    /// <summary>
    /// Maximum parts to buffer in memory.
    /// </summary>
    public int MaxInMemoryParts { get; set; } = 100;

    /// <summary>
    /// Whether to simulate network delay.
    /// </summary>
    public bool SimulateNetworkDelay { get; set; } = false;

    /// <summary>
    /// Whether to simulate processing delay.
    /// </summary>
    public bool SimulateProcessingDelay { get; set; } = false;

    /// <summary>
    /// Time in milliseconds to simulate consumer reading a part.
    /// </summary>
    public int SimulateConsumerReadTimeMs { get; set; } = 1;

    /// <summary>
    /// Total object size (PartSizeBytes * TotalParts).
    /// </summary>
    public long TotalObjectSize => PartSizeBytes * TotalParts;

    /// <summary>
    /// Chunks per part (PartSizeBytes / ChunkSizeBytes).
    /// </summary>
    public int ChunksPerPart => (int)Math.Ceiling((double)PartSizeBytes / ChunkSizeBytes);

    /// <summary>
    /// Maximum possible concurrent chunks (MaxInMemoryParts * ChunksPerPart).
    /// </summary>
    public int MaxConcurrentChunks => MaxInMemoryParts * ChunksPerPart;

    /// <summary>
    /// Estimated peak VMA count (MaxConcurrentChunks + baseline).
    /// </summary>
    public int EstimatedPeakVmaCount => MaxConcurrentChunks;

    /// <summary>
    /// Estimated peak memory usage in bytes.
    /// Memory = MaxInMemoryParts × PartSize (chunk size doesn't affect total memory!)
    /// </summary>
    public long EstimatedMemoryUsageBytes => (long)MaxInMemoryParts * PartSizeBytes;

    /// <summary>
    /// Estimated peak memory usage formatted as string.
    /// </summary>
    public string EstimatedMemoryUsageFormatted => FormatBytes(EstimatedMemoryUsageBytes);

    /// <summary>
    /// Creates a copy with a different chunk size.
    /// </summary>
    public SimulationConfig WithChunkSize(int chunkSizeBytes)
    {
        return new SimulationConfig
        {
            Name = Name,
            PartSizeBytes = PartSizeBytes,
            ChunkSizeBytes = chunkSizeBytes,
            TotalParts = TotalParts,
            ConcurrentServiceRequests = ConcurrentServiceRequests,
            MaxInMemoryParts = MaxInMemoryParts,
            SimulateNetworkDelay = SimulateNetworkDelay,
            SimulateProcessingDelay = SimulateProcessingDelay,
            SimulateConsumerReadTimeMs = SimulateConsumerReadTimeMs
        };
    }

    public override string ToString()
    {
        return $"{Name}: Part={FormatBytes(PartSizeBytes)}, Chunk={FormatBytes(ChunkSizeBytes)}, " +
               $"Parts={TotalParts}, Concurrent={ConcurrentServiceRequests}, MaxInMem={MaxInMemoryParts}";
    }

    private static string FormatBytes(long bytes)
    {
        if (bytes >= 1024 * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0:F1}GB";
        if (bytes >= 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F1}MB";
        if (bytes >= 1024) return $"{bytes / 1024.0:F0}KB";
        return $"{bytes}B";
    }
}

/// <summary>
/// Represents a simulated downloaded part with its ArrayPool chunks.
/// </summary>
public class SimulatedPart
{
    public int PartNumber { get; set; }
    public List<byte[]> Chunks { get; set; } = new();
    public int ChunkSize { get; set; }
}

/// <summary>
/// Metrics collected during a simulation run.
/// </summary>
public class SimulationMetrics
{
    public SimulationConfig Config { get; set; } = new();
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public long DurationMs { get; set; }
    public int CompletedParts { get; set; }
    public long TotalBytesProcessed { get; set; }
    public double ThroughputMBps { get; set; }
    
    // VMA metrics
    public int PeakVmaCount { get; set; }
    public VmaSnapshot FinalVmaSnapshot { get; set; } = new();
    public List<VmaSnapshot> VmaSnapshots { get; set; } = new();
    
    // Allocation metrics
    public int TotalAllocations { get; set; }
    public int TotalDeallocations { get; set; }
    public int CurrentActiveChunks { get; set; }
    public int PeakActiveChunks { get; set; }

    /// <summary>
    /// Whether the simulation stayed within safe VMA limits.
    /// </summary>
    public bool VmaSafe => PeakVmaCount < VmaMonitor.SafeVmaThreshold;

    /// <summary>
    /// Safety margin as percentage.
    /// </summary>
    public double SafetyMarginPercent => (1.0 - (double)PeakVmaCount / VmaMonitor.SafeVmaThreshold) * 100;

    /// <summary>
    /// Status indicator for display.
    /// </summary>
    public string Status
    {
        get
        {
            if (PeakVmaCount >= VmaMonitor.DefaultLinuxVmaLimit) return "✗ EXCEEDED LIMIT";
            if (PeakVmaCount >= VmaMonitor.SafeVmaThreshold) return "⚠ UNSAFE";
            if (PeakVmaCount >= VmaMonitor.SafeVmaThreshold * 0.8) return "⚠ WARNING";
            return "✓ SAFE";
        }
    }
}
