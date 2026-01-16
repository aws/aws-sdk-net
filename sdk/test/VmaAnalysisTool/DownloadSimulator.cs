using System.Buffers;
using System.Diagnostics;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Exception thrown when VMA limit is about to be exceeded.
/// </summary>
public class VmaLimitExceededException : Exception
{
    public int CurrentVmaCount { get; }
    public int AbortThreshold { get; }
    
    public VmaLimitExceededException(int currentVmaCount, int abortThreshold)
        : base($"VMA count ({currentVmaCount:N0}) exceeded abort threshold ({abortThreshold:N0}). Test aborted to prevent system instability.")
    {
        CurrentVmaCount = currentVmaCount;
        AbortThreshold = abortThreshold;
    }
}

/// <summary>
/// Simulates multipart downloads using real ArrayPool allocations.
/// Mimics the ChunkedBufferStream and PartBufferManager behavior from the SDK.
/// Uses realistic producer-consumer pattern to ensure MaxInMemoryParts is reached.
/// </summary>
public class DownloadSimulator : IDownloadExecutor
{
    private readonly VmaMonitor _vmaMonitor;
    private readonly List<SimulatedPart> _activeParts = new();
    private readonly Queue<SimulatedPart> _partBuffer = new();
    private readonly object _lock = new();
    private bool _disposed;

    /// <inheritdoc />
    public string Name => "Simulated";
    
    /// <inheritdoc />
    public string Description => "Simulates multipart downloads using ArrayPool allocations without network I/O";
    
    /// <inheritdoc />
    public bool RequiresS3Access => false;

    /// <inheritdoc />
    public SimulationMetrics Metrics { get; private set; } = new();

    /// <inheritdoc />
    public int VmaAbortThreshold { get; set; } = VmaMonitor.DefaultAbortVmaThreshold;

    public DownloadSimulator(VmaMonitor vmaMonitor)
    {
        _vmaMonitor = vmaMonitor;
    }
    
    /// <inheritdoc />
    public bool ValidateConfig(SimulationConfig config, out string? errorMessage)
    {
        if (config.PartSizeBytes <= 0)
        {
            errorMessage = "Part size must be greater than 0";
            return false;
        }
        
        if (config.ChunkSizeBytes <= 0)
        {
            errorMessage = "Chunk size must be greater than 0";
            return false;
        }
        
        if (config.TotalParts <= 0)
        {
            errorMessage = "Total parts must be greater than 0";
            return false;
        }
        
        if (config.MaxInMemoryParts <= 0)
        {
            errorMessage = "MaxInMemoryParts must be greater than 0";
            return false;
        }
        
        if (config.ConcurrentServiceRequests <= 0)
        {
            errorMessage = "ConcurrentServiceRequests must be greater than 0";
            return false;
        }
        
        errorMessage = null;
        return true;
    }

    /// <inheritdoc />
    /// <summary>
    /// Simulates a multipart download with specified parameters using realistic producer-consumer pattern.
    /// Ensures MaxInMemoryParts is reached and maintained throughout the download.
    /// </summary>
    public async Task<SimulationMetrics> ExecuteDownloadAsync(
        SimulationConfig config, 
        IProgress<DownloadProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        _vmaMonitor.Reset();
        
        // Capture baseline memory
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        
        var process = Process.GetCurrentProcess();
        process.Refresh();
        var baselineWorkingSet = process.WorkingSet64;
        var baselineGcMemory = GC.GetTotalMemory(true);
        
        Metrics = new SimulationMetrics
        {
            Config = config,
            StartTime = DateTime.UtcNow,
            BaselineWorkingSetBytes = baselineWorkingSet,
            BaselineGcMemoryBytes = baselineGcMemory
        };

        var totalStopwatch = Stopwatch.StartNew();
        var rampUpStopwatch = new Stopwatch();
        var steadyStateStopwatch = new Stopwatch();
        
        var completedParts = 0;
        var httpSemaphore = new SemaphoreSlim(config.ConcurrentServiceRequests);
        
        // Create a linked cancellation token that we can cancel if VMA limit is exceeded
        using var vmaAbortCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        var linkedToken = vmaAbortCts.Token;

        // Start VMA and memory monitoring task
        var vmaMonitorTask = StartVmaAndMemoryMonitoringAsync(vmaAbortCts, VmaAbortThreshold);

        try
        {
            // Phase 1: RAMP-UP - Fill buffer to MaxInMemoryParts
            rampUpStopwatch.Start();
            
            var partsToDownload = Math.Min(config.MaxInMemoryParts, config.TotalParts);
            var rampUpTasks = new List<Task>();
            
            for (int partNum = 1; partNum <= partsToDownload && !linkedToken.IsCancellationRequested; partNum++)
            {
                var currentPart = partNum;
                
                await httpSemaphore.WaitAsync(linkedToken);
                
                rampUpTasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        // Simulate network latency (optional)
                        if (config.SimulateNetworkDelay)
                        {
                            await Task.Delay(config.NetworkDelayMs, linkedToken);
                        }
                        
                        // Allocate and fill chunks for this part
                        var part = AllocatePart(currentPart, config.PartSizeBytes, config.ChunkSizeBytes);
                        
                        lock (_lock)
                        {
                            _partBuffer.Enqueue(part);
                        }
                        
                        _vmaMonitor.UpdatePeak();
                    }
                    finally
                    {
                        httpSemaphore.Release();
                    }
                }, linkedToken));
            }
            
            await Task.WhenAll(rampUpTasks);
            
            rampUpStopwatch.Stop();
            Metrics.RampUpTimeMs = rampUpStopwatch.ElapsedMilliseconds;
            
            // Take memory snapshot at peak (buffer full)
            UpdateMemoryMetrics();
            Metrics.PeakBufferParts = _partBuffer.Count;
            
            // Phase 2: STEADY-STATE - Producer-consumer equilibrium
            steadyStateStopwatch.Start();
            
            if (config.TotalParts > config.MaxInMemoryParts)
            {
                var remainingParts = config.TotalParts - config.MaxInMemoryParts;
                var producerTask = Task.Run(async () =>
                {
                    for (int i = 0; i < remainingParts && !linkedToken.IsCancellationRequested; i++)
                    {
                        var partNum = config.MaxInMemoryParts + 1 + i;
                        
                        // Wait for buffer space (consumer must release a part)
                        while (true)
                        {
                            linkedToken.ThrowIfCancellationRequested();
                            lock (_lock)
                            {
                                if (_partBuffer.Count < config.MaxInMemoryParts)
                                    break;
                            }
                            await Task.Delay(1, linkedToken);
                        }
                        
                        await httpSemaphore.WaitAsync(linkedToken);
                        
                        try
                        {
                            if (config.SimulateNetworkDelay)
                            {
                                await Task.Delay(config.NetworkDelayMs, linkedToken);
                            }
                            
                            var part = AllocatePart(partNum, config.PartSizeBytes, config.ChunkSizeBytes);
                            
                            lock (_lock)
                            {
                                _partBuffer.Enqueue(part);
                            }
                            
                            _vmaMonitor.UpdatePeak();
                        }
                        finally
                        {
                            httpSemaphore.Release();
                        }
                    }
                }, linkedToken);

                var consumerTask = Task.Run(async () =>
                {
                    for (int i = 0; i < config.TotalParts && !linkedToken.IsCancellationRequested; i++)
                    {
                        SimulatedPart? part = null;
                        
                        // Wait for a part to be available
                        while (true)
                        {
                            linkedToken.ThrowIfCancellationRequested();
                            lock (_lock)
                            {
                                if (_partBuffer.Count > 0)
                                {
                                    part = _partBuffer.Dequeue();
                                    break;
                                }
                            }
                            await Task.Delay(1, linkedToken);
                        }
                        
                        // Simulate processing/reading time
                        if (config.SimulateProcessingDelay)
                        {
                            await Task.Delay(config.ProcessingDelayMs, linkedToken);
                        }
                        
                        // Release the part
                        ReleasePart(part!);
                        var currentCompleted = Interlocked.Increment(ref completedParts);
                        lock (_lock)
                        {
                            Metrics.TotalBytesProcessed += config.PartSizeBytes;
                        }
                        
                        // Report progress
                        progress?.Report(new DownloadProgress
                        {
                            CompletedParts = currentCompleted,
                            TotalParts = config.TotalParts,
                            Phase = "Steady-state",
                            CurrentVmaCount = _vmaMonitor.CurrentVmaCount,
                            BufferedParts = _partBuffer.Count,
                            BytesProcessed = currentCompleted * config.PartSizeBytes,
                            TotalBytes = config.TotalObjectSize
                        });
                    }
                }, linkedToken);

                await Task.WhenAll(producerTask, consumerTask);
            }
            else
            {
                // All parts fit in buffer - just consume them
                while (true)
                {
                    SimulatedPart? part = null;
                    lock (_lock)
                    {
                        if (_partBuffer.Count == 0) break;
                        part = _partBuffer.Dequeue();
                    }
                    
                    if (config.SimulateProcessingDelay)
                    {
                        await Task.Delay(config.ProcessingDelayMs, linkedToken);
                    }
                    
                    ReleasePart(part!);
                    var currentCompleted = Interlocked.Increment(ref completedParts);
                    lock (_lock)
                    {
                        Metrics.TotalBytesProcessed += config.PartSizeBytes;
                    }
                    
                    // Report progress
                    progress?.Report(new DownloadProgress
                    {
                        CompletedParts = currentCompleted,
                        TotalParts = config.TotalParts,
                        Phase = "Consuming",
                        CurrentVmaCount = _vmaMonitor.CurrentVmaCount,
                        BufferedParts = _partBuffer.Count,
                        BytesProcessed = currentCompleted * config.PartSizeBytes,
                        TotalBytes = config.TotalObjectSize
                    });
                }
            }
            
            steadyStateStopwatch.Stop();
            Metrics.SteadyStateTimeMs = steadyStateStopwatch.ElapsedMilliseconds;
        }
        catch (OperationCanceledException) when (vmaAbortCts.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
        {
            Metrics.WasAborted = true;
            Metrics.AbortReason = $"VMA count exceeded abort threshold ({VmaAbortThreshold:N0})";
        }
        catch (VmaLimitExceededException ex)
        {
            Metrics.WasAborted = true;
            Metrics.AbortReason = ex.Message;
        }
        finally
        {
            // Cancel the VMA monitoring task
            if (!vmaAbortCts.IsCancellationRequested)
            {
                vmaAbortCts.Cancel();
            }
            
            totalStopwatch.Stop();
            httpSemaphore.Dispose();

            // Clean up any remaining parts
            lock (_lock)
            {
                while (_partBuffer.Count > 0)
                {
                    var part = _partBuffer.Dequeue();
                    ReleasePart(part);
                }
            }

            // Final metrics
            Metrics.EndTime = DateTime.UtcNow;
            Metrics.DurationMs = totalStopwatch.ElapsedMilliseconds;
            Metrics.CompletedParts = completedParts;
            Metrics.FinalVmaSnapshot = _vmaMonitor.TakeSnapshot();
            Metrics.PeakVmaCount = _vmaMonitor.PeakVmaCount;
            
            // Calculate throughput metrics
            if (Metrics.DurationMs > 0)
            {
                var durationSec = Metrics.DurationMs / 1000.0;
                Metrics.PartsPerSecond = Metrics.CompletedParts / durationSec;
                Metrics.AllocationsPerSecond = Metrics.TotalAllocations / durationSec;
                Metrics.MemoryThroughputMBps = (Metrics.TotalBytesProcessed / 1024.0 / 1024.0) / durationSec;
            }
            
            // Wait for VMA monitor task to complete
            try { await vmaMonitorTask; } catch { /* ignore */ }
        }

        return Metrics;
    }

    /// <summary>
    /// Background task that monitors VMA count and memory.
    /// </summary>
    private async Task StartVmaAndMemoryMonitoringAsync(CancellationTokenSource abortCts, int threshold)
    {
        try
        {
            while (!abortCts.Token.IsCancellationRequested)
            {
                await Task.Delay(50, abortCts.Token); // Check every 50ms
                
                UpdateMemoryMetrics();
                
                if (threshold > 0)
                {
                    var currentVma = _vmaMonitor.CurrentVmaCount;
                    if (currentVma >= threshold)
                    {
                        Console.Error.WriteLine($"\n⚠ VMA ABORT: Count {currentVma:N0} exceeded threshold {threshold:N0}. Aborting test...");
                        abortCts.Cancel();
                        return;
                    }
                }
            }
        }
        catch (OperationCanceledException)
        {
            // Expected when test completes or is cancelled
        }
    }
    
    /// <summary>
    /// Updates peak memory metrics from current process state.
    /// </summary>
    private void UpdateMemoryMetrics()
    {
        try
        {
            var process = Process.GetCurrentProcess();
            process.Refresh();
            
            lock (_lock)
            {
                var workingSet = process.WorkingSet64;
                var privateMemory = process.PrivateMemorySize64;
                var gcMemory = GC.GetTotalMemory(false);
                
                if (workingSet > Metrics.PeakWorkingSetBytes)
                    Metrics.PeakWorkingSetBytes = workingSet;
                    
                if (privateMemory > Metrics.PeakPrivateMemoryBytes)
                    Metrics.PeakPrivateMemoryBytes = privateMemory;
                    
                if (gcMemory > Metrics.PeakGcMemoryBytes)
                    Metrics.PeakGcMemoryBytes = gcMemory;
            }
        }
        catch
        {
            // Ignore errors in monitoring
        }
    }

    /// <summary>
    /// Allocates ArrayPool chunks for a part and fills them with data.
    /// This mimics ChunkedBufferStream and forces physical memory allocation.
    /// </summary>
    private SimulatedPart AllocatePart(int partNumber, long partSizeBytes, int chunkSizeBytes)
    {
        var chunksNeeded = (int)Math.Ceiling((double)partSizeBytes / chunkSizeBytes);
        var chunks = new List<byte[]>(chunksNeeded);
        long bytesAllocated = 0;

        lock (_lock)
        {
            for (int i = 0; i < chunksNeeded; i++)
            {
                var chunk = ArrayPool<byte>.Shared.Rent(chunkSizeBytes);
                
                // Fill chunk with data to force physical memory allocation (defeats copy-on-write)
                // Use a pattern that's easy to verify if needed
                var fillByte = (byte)((partNumber + i) % 256);
                Array.Fill(chunk, fillByte, 0, chunkSizeBytes);
                
                chunks.Add(chunk);
                bytesAllocated += chunkSizeBytes;
                
                _vmaMonitor.RecordAllocation();
                Metrics.TotalAllocations++;
            }

            Metrics.TotalAllocatedBytes += bytesAllocated;
            if (Metrics.TotalAllocatedBytes > Metrics.PeakAllocatedBytes)
                Metrics.PeakAllocatedBytes = Metrics.TotalAllocatedBytes;

            var part = new SimulatedPart
            {
                PartNumber = partNumber,
                Chunks = chunks,
                ChunkSize = chunkSizeBytes,
                TotalBytes = bytesAllocated
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
            
            Metrics.TotalAllocatedBytes -= part.TotalBytes;
            _activeParts.Remove(part);
            Metrics.CurrentActiveChunks = _activeParts.Sum(p => p.Chunks.Count);
        }
    }

    public void Dispose()
    {
        if (_disposed) return;
        
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
            
            while (_partBuffer.Count > 0)
            {
                var part = _partBuffer.Dequeue();
                foreach (var chunk in part.Chunks)
                {
                    ArrayPool<byte>.Shared.Return(chunk);
                }
            }
        }
        
        _disposed = true;
    }
}

/// <summary>
/// Configuration for a download simulation.
/// </summary>
public class SimulationConfig
{
    public string Name { get; set; } = "Unnamed";
    public long PartSizeBytes { get; set; } = 10 * 1024 * 1024; // 10MB default
    public int ChunkSizeBytes { get; set; } = 65536; // 64KB default
    public int TotalParts { get; set; } = 100;
    public int ConcurrentServiceRequests { get; set; } = 10;
    public int MaxInMemoryParts { get; set; } = 100;
    
    // Simulation timing options
    public bool SimulateNetworkDelay { get; set; } = false;
    public int NetworkDelayMs { get; set; } = 10;
    public bool SimulateProcessingDelay { get; set; } = false;
    public int ProcessingDelayMs { get; set; } = 5;

    // Calculated properties
    public long TotalObjectSize => PartSizeBytes * TotalParts;
    public int ChunksPerPart => (int)Math.Ceiling((double)PartSizeBytes / ChunkSizeBytes);
    public int MaxConcurrentChunks => MaxInMemoryParts * ChunksPerPart;
    public int EstimatedPeakVmaCount => MaxConcurrentChunks;
    public long EstimatedMemoryUsageBytes => (long)MaxInMemoryParts * PartSizeBytes;
    public string EstimatedMemoryUsageFormatted => FormatBytes(EstimatedMemoryUsageBytes);

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
            NetworkDelayMs = NetworkDelayMs,
            SimulateProcessingDelay = SimulateProcessingDelay,
            ProcessingDelayMs = ProcessingDelayMs
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
    public long TotalBytes { get; set; }
}

/// <summary>
/// Metrics collected during a simulation run.
/// </summary>
public class SimulationMetrics
{
    public SimulationConfig Config { get; set; } = new();
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int CompletedParts { get; set; }
    public long TotalBytesProcessed { get; set; }
    
    // Timing metrics
    public long DurationMs { get; set; }
    public long RampUpTimeMs { get; set; }
    public long SteadyStateTimeMs { get; set; }
    
    // Throughput metrics
    public double PartsPerSecond { get; set; }
    public double AllocationsPerSecond { get; set; }
    public double MemoryThroughputMBps { get; set; }
    
    // VMA metrics
    public int PeakVmaCount { get; set; }
    public VmaSnapshot FinalVmaSnapshot { get; set; } = new();
    public List<VmaSnapshot> VmaSnapshots { get; set; } = new();
    
    // Allocation metrics
    public int TotalAllocations { get; set; }
    public int TotalDeallocations { get; set; }
    public int CurrentActiveChunks { get; set; }
    public int PeakActiveChunks { get; set; }
    public int PeakBufferParts { get; set; }
    
    // Memory metrics (bytes actually allocated)
    public long TotalAllocatedBytes { get; set; }
    public long PeakAllocatedBytes { get; set; }
    
    // Process memory metrics
    public long PeakWorkingSetBytes { get; set; }
    public long PeakPrivateMemoryBytes { get; set; }
    public long PeakGcMemoryBytes { get; set; }
    public long BaselineWorkingSetBytes { get; set; }
    public long BaselineGcMemoryBytes { get; set; }
    
    // Calculated memory deltas
    public long WorkingSetDeltaBytes => PeakWorkingSetBytes - BaselineWorkingSetBytes;
    public long GcMemoryDeltaBytes => PeakGcMemoryBytes - BaselineGcMemoryBytes;
    public long ExpectedMemoryUsageBytes => (long)Config.MaxInMemoryParts * Config.PartSizeBytes;
    
    // Memory efficiency ratios
    public double WorkingSetEfficiencyRatio => ExpectedMemoryUsageBytes > 0 
        ? (double)WorkingSetDeltaBytes / ExpectedMemoryUsageBytes : 0;
    public double AllocatedEfficiencyRatio => ExpectedMemoryUsageBytes > 0 
        ? (double)PeakAllocatedBytes / ExpectedMemoryUsageBytes : 0;
    
    // Abort tracking
    public bool WasAborted { get; set; }
    public string? AbortReason { get; set; }
    public bool VmaSafe => !WasAborted && PeakVmaCount < VmaMonitor.SafeVmaThreshold;
    public double SafetyMarginPercent => (1.0 - (double)PeakVmaCount / VmaMonitor.SafeVmaThreshold) * 100;

    public string Status
    {
        get
        {
            if (WasAborted) return "⚠ ABORTED";
            if (PeakVmaCount >= VmaMonitor.DefaultLinuxVmaLimit) return "✗ EXCEEDED LIMIT";
            if (PeakVmaCount >= VmaMonitor.SafeVmaThreshold) return "⚠ UNSAFE";
            if (PeakVmaCount >= VmaMonitor.SafeVmaThreshold * 0.8) return "⚠ WARNING";
            return "✓ SAFE";
        }
    }
    
    // Formatted strings
    public string PeakWorkingSetFormatted => FormatBytes(PeakWorkingSetBytes);
    public string WorkingSetDeltaFormatted => FormatBytes(WorkingSetDeltaBytes);
    public string PeakAllocatedFormatted => FormatBytes(PeakAllocatedBytes);
    public string ExpectedMemoryFormatted => FormatBytes(ExpectedMemoryUsageBytes);
    
    private static string FormatBytes(long bytes)
    {
        if (bytes >= 1024L * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0:F2}GB";
        if (bytes >= 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F2}MB";
        if (bytes >= 1024) return $"{bytes / 1024.0:F0}KB";
        return $"{bytes}B";
    }
}
