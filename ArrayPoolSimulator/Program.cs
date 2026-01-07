using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayPoolSimulator
{
    /// <summary>
    /// Accurately simulates OpenStreamWithResponse ArrayPool usage patterns including:
    /// - MaxInMemoryParts flow control
    /// - Streaming for in-order parts (Part 1)
    /// - Buffering only for out-of-order parts
    /// - Sequential consumer with slot release
    /// - Real VMA monitoring on Linux
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            var outputFile = "arraypool_simulation_results.txt";
            var jsonFile = "arraypool_simulation_results.json";
            
            using var writer = new StreamWriter(outputFile) { AutoFlush = true };
            var results = new List<SimulationResult>();

            var output = new DualWriter(Console.Out, writer);
            
            output.WriteLine("════════════════════════════════════════════════════════════════════════");
            output.WriteLine("ArrayPool Behavior Simulator for OpenStreamWithResponse");
            output.WriteLine("(Accurate simulation with MaxInMemoryParts and streaming behavior)");
            output.WriteLine("════════════════════════════════════════════════════════════════════════");
            output.WriteLine();

            // Focused test matrix to investigate 0.86 factor
            // Testing 1GB parts with varying C and M to isolate what affects the ratio
            
            var scenarios = new List<(string Name, long PartSize, int ChunkSize, int ConcurrentRequests, int MaxInMemoryParts, int TotalParts)>();
            
            // Test with 10,000 parts for accurate steady-state VMA measurements
            // Test 1: Vary ConcurrentServiceRequests (C), keep M=50
            output.WriteLine("Test 1: Varying ConcurrentServiceRequests (C) with M=50, PartSize=64MB");
            output.WriteLine("─────────────────────────────────────────────────────────────");
            var concurrencyTests = new[] { 5, 10, 20, 50 };
            foreach (var c in concurrencyTests)
            {
                scenarios.Add(($"64MB, C={c}, M=50", 64L * 1024 * 1024, 64 * 1024, c, 50, 500));
                output.WriteLine($"  - C={c}, M=50");
            }
            output.WriteLine();

            // Test 2: Vary MaxInMemoryParts (M), keep C=10
            output.WriteLine("Test 2: Varying MaxInMemoryParts (M) with C=10, PartSize=64MB");
            output.WriteLine("─────────────────────────────────────────────────────────────");
            var maxInMemoryTests = new[] { 10, 25, 50, 100, 200 };
            foreach (var m in maxInMemoryTests)
            {
                scenarios.Add(($"64MB, C=10, M={m}", 64L * 1024 * 1024, 64 * 1024, 10, m, 500));
                output.WriteLine($"  - C=10, M={m}");
            }
            output.WriteLine();

            // Test 3: Different part sizes with baseline C=10, M=50
            output.WriteLine("Test 3: Different part sizes with C=10, M=50 (baseline)");
            output.WriteLine("─────────────────────────────────────────────────────────────");
            var partSizeTests = new[]
            {
                ("32MB", 32L * 1024 * 1024),
                ("128MB", 128L * 1024 * 1024),
                ("256MB", 256L * 1024 * 1024),
                ("512MB", 512L * 1024 * 1024),
                ("1GB", 1L * 1024 * 1024 * 1024),
                ("2GB", 2L * 1024 * 1024 * 1024),
                ("4GB", 4L * 1024 * 1024 * 1024),
            };
            foreach (var (name, size) in partSizeTests)
            {
                scenarios.Add(($"{name}, C=10, M=50", size, 64 * 1024, 10, 50, 500));
                output.WriteLine($"  - {name}");
            }
            output.WriteLine();

            output.WriteLine($"Total scenarios: {scenarios.Count}");
            output.WriteLine();

            foreach (var (name, partSize, chunkSize, concurrent, maxInMemory, totalParts) in scenarios)
            {
                var result = await RunSimulation(output, name, partSize, chunkSize, concurrent, maxInMemory, totalParts);
                results.Add(result);
                output.WriteLine();
            }

            output.WriteLine("════════════════════════════════════════════════════════════════════════");
            output.WriteLine("All simulations complete!");
            output.WriteLine("════════════════════════════════════════════════════════════════════════");
            output.WriteLine();
            output.WriteLine($"Results saved to:");
            output.WriteLine($"  - {outputFile} (human-readable)");
            output.WriteLine($"  - {jsonFile} (machine-readable)");
            
            // Export JSON for analysis
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(results, jsonOptions);
            File.WriteAllText(jsonFile, json);
            
            Console.WriteLine("\nSimulation complete! Check output files for results.");
        }

        static async Task<SimulationResult> RunSimulation(DualWriter output, string name, long partSize, int chunkSize, 
            int concurrentRequests, int maxInMemoryParts, int totalParts)
        {
            output.WriteLine($"Scenario: {name}");
            output.WriteLine("────────────────────────────────────────────────────────────────────────");
            output.WriteLine($"[DEBUG] Creating tracker and simulator...");

            var tracker = new ArrayPoolTracker<byte>(chunkSize);
            var simulator = new AccurateOpenStreamSimulator(tracker, partSize, chunkSize, concurrentRequests, maxInMemoryParts);

            // Monitor VMA count
            int initialVMAs = GetVMACount();
            output.WriteLine($"[DEBUG] Initial VMAs: {initialVMAs}");
            
            output.WriteLine($"[DEBUG] Starting simulation with {totalParts} parts...");
            var sw = Stopwatch.StartNew();
            await simulator.SimulateDownloadAsync(totalParts);
            sw.Stop();
            output.WriteLine($"[DEBUG] Simulation complete in {sw.ElapsedMilliseconds}ms");

            int finalVMAs = GetVMACount();
            int vmasDelta = finalVMAs - initialVMAs;

            output.WriteLine();
            output.WriteLine("Configuration:");
            output.WriteLine($"  Part Size:              {FormatBytes(partSize)}");
            output.WriteLine($"  Chunk Buffer Size:      {FormatBytes(chunkSize)}");
            output.WriteLine($"  Concurrent Requests:    {concurrentRequests}");
            output.WriteLine($"  MaxInMemoryParts:       {maxInMemoryParts}");
            output.WriteLine($"  Total Parts Downloaded: {totalParts}");
            output.WriteLine($"  Chunks Per Part:        {simulator.ChunksPerPart:N0}");
            output.WriteLine();

            var stats = tracker.GetStatistics();
            var simStats = simulator.GetStatistics();
            
            output.WriteLine("Simulation Behavior:");
            output.WriteLine($"  Parts streamed directly: {simStats.PartsStreamed}");
            output.WriteLine($"  Parts buffered:          {simStats.PartsBuffered}");
            output.WriteLine($"  Peak buffered parts:     {simStats.PeakBufferedParts}");
            output.WriteLine($"  Buffer full events:      {simStats.BufferFullCount}");
            output.WriteLine();
            
            tracker.PrintReport(output);

            if (initialVMAs > 0 && finalVMAs > 0)
            {
                output.WriteLine();
                output.WriteLine("Real VMA Monitoring:");
                output.WriteLine($"  Initial VMAs:           {initialVMAs:N0}");
                output.WriteLine($"  Final VMAs:             {finalVMAs:N0}");
                output.WriteLine($"  VMAs Created:           {vmasDelta:N0}");
            }

            output.WriteLine();
            output.WriteLine($"Simulation Time: {sw.ElapsedMilliseconds:N0} ms");
            output.WriteLine("────────────────────────────────────────────────────────────────────────");

            return new SimulationResult
            {
                ScenarioName = name,
                PartSize = partSize,
                ChunkSize = chunkSize,
                ConcurrentRequests = concurrentRequests,
                MaxInMemoryParts = maxInMemoryParts,
                PartsDownloaded = totalParts,
                ChunksPerPart = simulator.ChunksPerPart,
                PartsStreamed = simStats.PartsStreamed,
                PartsBuffered = simStats.PartsBuffered,
                PeakBufferedParts = simStats.PeakBufferedParts,
                BufferFullCount = simStats.BufferFullCount,
                TotalRents = stats.TotalRents,
                TotalReturns = stats.TotalReturns,
                UniqueArrays = stats.UniqueArrays,
                PeakConcurrentArrays = stats.PeakConcurrent,
                PoolHitRate = stats.PoolHitRate,
                PoolMissRate = stats.PoolMissRate,
                TheoreticalMaxVMAs = stats.TotalRents,
                ActualVMAs = stats.UniqueArrays,
                RealVMAsDelta = vmasDelta,
                IsSafeTheoretical = stats.TotalRents < 65536,
                IsSafeActual = stats.UniqueArrays < 65536,
                SimulationTimeMs = sw.ElapsedMilliseconds
            };
        }

        static int GetVMACount()
        {
            try
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    var maps = File.ReadAllLines("/proc/self/maps");
                    return maps.Length;
                }
            }
            catch
            {
                // Not on Linux or /proc not available
            }
            return -1; // Indicates VMA monitoring not available
        }

        static string FormatBytes(long bytes)
        {
            if (bytes >= 1024L * 1024 * 1024)
                return $"{bytes / (1024.0 * 1024 * 1024):F2} GB";
            if (bytes >= 1024L * 1024)
                return $"{bytes / (1024.0 * 1024):F2} MB";
            if (bytes >= 1024)
                return $"{bytes / 1024.0:F2} KB";
            return $"{bytes} bytes";
        }
    }

    class DualWriter : TextWriter
    {
        private readonly TextWriter _writer1;
        private readonly TextWriter _writer2;

        public DualWriter(TextWriter writer1, TextWriter writer2)
        {
            _writer1 = writer1;
            _writer2 = writer2;
        }

        public override Encoding Encoding => _writer1.Encoding;

        public override void Write(char value)
        {
            _writer1.Write(value);
            _writer2.Write(value);
        }

        public override void Write(string? value)
        {
            _writer1.Write(value);
            _writer2.Write(value);
        }

        public override void WriteLine()
        {
            _writer1.WriteLine();
            _writer2.WriteLine();
        }

        public override void WriteLine(string? value)
        {
            _writer1.WriteLine(value);
            _writer2.WriteLine(value);
        }

        public override void WriteLine(char value)
        {
            _writer1.WriteLine(value);
            _writer2.WriteLine(value);
        }

        public override void Flush()
        {
            _writer1.Flush();
            _writer2.Flush();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _writer1.Flush();
                _writer2.Flush();
            }
            base.Dispose(disposing);
        }
    }

    class SimulationResult
    {
        public string ScenarioName { get; set; } = "";
        public long PartSize { get; set; }
        public int ChunkSize { get; set; }
        public int ConcurrentRequests { get; set; }
        public int MaxInMemoryParts { get; set; }
        public int PartsDownloaded { get; set; }
        public int ChunksPerPart { get; set; }
        public int PartsStreamed { get; set; }
        public int PartsBuffered { get; set; }
        public int PeakBufferedParts { get; set; }
        public int BufferFullCount { get; set; }
        public long TotalRents { get; set; }
        public long TotalReturns { get; set; }
        public long UniqueArrays { get; set; }
        public long PeakConcurrentArrays { get; set; }
        public double PoolHitRate { get; set; }
        public double PoolMissRate { get; set; }
        public long TheoreticalMaxVMAs { get; set; }
        public long ActualVMAs { get; set; }
        public int RealVMAsDelta { get; set; }
        public bool IsSafeTheoretical { get; set; }
        public bool IsSafeActual { get; set; }
        public long SimulationTimeMs { get; set; }
    }

    class PoolStatistics
    {
        public long TotalRents { get; set; }
        public long TotalReturns { get; set; }
        public long UniqueArrays { get; set; }
        public long PeakConcurrent { get; set; }
        public double PoolHitRate { get; set; }
        public double PoolMissRate { get; set; }
    }

    class SimulatorStatistics
    {
        public int PartsStreamed { get; set; }
        public int PartsBuffered { get; set; }
        public int PeakBufferedParts { get; set; }
        public int BufferFullCount { get; set; }
    }

    /// <summary>
    /// Tracks ArrayPool Rent/Return operations to measure pool efficiency.
    /// </summary>
    class ArrayPoolTracker<T>
    {
        private readonly ArrayPool<T> _underlyingPool = ArrayPool<T>.Shared;
        private readonly int _expectedArraySize;

        // Thread-safe counters
        private long _totalRents = 0;
        private long _totalReturns = 0;
        private long _peakConcurrentArrays = 0;
        private long _currentConcurrentArrays = 0;

        // Track unique array instances to detect new allocations
        private readonly ConcurrentDictionary<int, bool> _trackedArrays = new();

        public ArrayPoolTracker(int expectedArraySize)
        {
            _expectedArraySize = expectedArraySize;
        }

        public T[] Rent(int minimumLength)
        {
            var array = _underlyingPool.Rent(minimumLength);
            
            // Track this rent
            Interlocked.Increment(ref _totalRents);
            var currentConcurrent = Interlocked.Increment(ref _currentConcurrentArrays);
            
            // Update peak
            long currentPeak;
            do
            {
                currentPeak = Interlocked.Read(ref _peakConcurrentArrays);
                if (currentConcurrent <= currentPeak)
                    break;
            } while (Interlocked.CompareExchange(ref _peakConcurrentArrays, currentConcurrent, currentPeak) != currentPeak);

            // Track unique array (approximation using hash code)
            _trackedArrays.TryAdd(array.GetHashCode(), true);

            return array;
        }

        public void Return(T[] array, bool clearArray = false)
        {
            _underlyingPool.Return(array, clearArray);
            
            Interlocked.Increment(ref _totalReturns);
            Interlocked.Decrement(ref _currentConcurrentArrays);
        }

        public PoolStatistics GetStatistics()
        {
            var totalRents = Interlocked.Read(ref _totalRents);
            var uniqueArrays = _trackedArrays.Count;
            
            double poolMissRate = totalRents > 0 ? uniqueArrays / (double)totalRents : 0;
            double poolHitRate = 1.0 - poolMissRate;

            return new PoolStatistics
            {
                TotalRents = totalRents,
                TotalReturns = Interlocked.Read(ref _totalReturns),
                UniqueArrays = uniqueArrays,
                PeakConcurrent = Interlocked.Read(ref _peakConcurrentArrays),
                PoolHitRate = poolHitRate,
                PoolMissRate = poolMissRate
            };
        }

        public void PrintReport(DualWriter output)
        {
            var stats = GetStatistics();

            output.WriteLine("ArrayPool Tracking Results:");
            output.WriteLine($"  Total Rent() calls:         {stats.TotalRents:N0}");
            output.WriteLine($"  Total Return() calls:       {stats.TotalReturns:N0}");
            output.WriteLine($"  Unique arrays seen:         {stats.UniqueArrays:N0}");
            output.WriteLine($"  Peak concurrent arrays:     {stats.PeakConcurrent:N0}");
            output.WriteLine();

            // Calculate pool efficiency
            if (stats.TotalRents > 0)
            {
                output.WriteLine("Estimated Pool Efficiency:");
                output.WriteLine($"  Pool Hit Rate:              {stats.PoolHitRate * 100:F1}% (reused from pool)");
                output.WriteLine($"  Pool Miss Rate:             {stats.PoolMissRate * 100:F1}% (new allocations)");
                output.WriteLine();

                output.WriteLine("VMA Impact Analysis:");
                output.WriteLine($"  Theoretical Max VMAs:       {stats.TotalRents:N0} (if every Rent = new alloc)");
                output.WriteLine($"  Actual Unique Arrays:       {stats.UniqueArrays:N0} (actual allocations)");
                output.WriteLine($"  Reduction from pooling:     {(1 - (stats.UniqueArrays / (double)stats.TotalRents)) * 100:F1}%");
                output.WriteLine();

                // Safety analysis
                const int LINUX_MAX_MAP_COUNT = 65536;
                var isSafeTheoretical = stats.TotalRents < LINUX_MAX_MAP_COUNT;
                var isSafeActual = stats.UniqueArrays < LINUX_MAX_MAP_COUNT;

                output.WriteLine($"  Safe vs 65K limit (theoretical): {(isSafeTheoretical ? "✓ YES" : "✗ NO")} ({stats.TotalRents:N0} VMAs)");
                output.WriteLine($"  Safe vs 65K limit (actual):      {(isSafeActual ? "✓ YES" : "✗ NO")} ({stats.UniqueArrays:N0} VMAs)");

                if (!isSafeActual)
                {
                    var excessVMAs = stats.UniqueArrays - LINUX_MAX_MAP_COUNT;
                    output.WriteLine($"  ⚠ EXCEEDS LIMIT BY:            {excessVMAs:N0} VMAs ({((double)stats.UniqueArrays / LINUX_MAX_MAP_COUNT):F2}x over)");
                }
            }
        }
    }

    /// <summary>
    /// Accurately simulates OpenStreamWithResponse download behavior:
    /// - Part 1 streams directly (no buffering)
    /// - Out-of-order parts are buffered
    /// - MaxInMemoryParts enforces backpressure
    /// - Consumer reads sequentially and releases buffer slots
    /// </summary>
    class AccurateOpenStreamSimulator
    {
        private readonly ArrayPoolTracker<byte> _arrayPool;
        private readonly long _partSize;
        private readonly int _chunkSize;
        private readonly int _concurrentRequests;
        private readonly int _maxInMemoryParts;
        private readonly SemaphoreSlim _httpConcurrencySemaphore;
        private readonly SemaphoreSlim _bufferSpaceSemaphore;
        private readonly ConcurrentDictionary<int, BufferedPart> _bufferedParts = new();
        
        private int _nextExpectedPartNumber = 1;
        private int _partsStreamed = 0;
        private int _partsBuffered = 0;
        private int _peakBufferedParts = 0;
        private int _bufferFullCount = 0;

        public int ChunksPerPart { get; }

        public AccurateOpenStreamSimulator(ArrayPoolTracker<byte> arrayPool, long partSize, int chunkSize, 
            int concurrentRequests, int maxInMemoryParts)
        {
            _arrayPool = arrayPool;
            _partSize = partSize;
            _chunkSize = chunkSize;
            _concurrentRequests = concurrentRequests;
            _maxInMemoryParts = maxInMemoryParts;
            
            _httpConcurrencySemaphore = new SemaphoreSlim(concurrentRequests, concurrentRequests);
            _bufferSpaceSemaphore = new SemaphoreSlim(maxInMemoryParts, maxInMemoryParts);

            ChunksPerPart = (int)Math.Ceiling((double)partSize / chunkSize);
        }

        public async Task SimulateDownloadAsync(int totalParts)
        {
            // Start producer and consumer tasks
            var producerTask = RunProducerAsync(totalParts);
            var consumerTask = RunConsumerAsync(totalParts);

            await Task.WhenAll(producerTask, consumerTask);
        }

        private async Task RunProducerAsync(int totalParts)
        {
            var downloadTasks = new List<Task>();

            // Start all part downloads with random delays to simulate out-of-order arrival
            for (int partNum = 1; partNum <= totalParts; partNum++)
            {
                var task = DownloadPartAsync(partNum);
                downloadTasks.Add(task);
                
                // Small delay between starting downloads (minimal for speed)
                await Task.Delay(1);
            }

            await Task.WhenAll(downloadTasks);
        }

        private async Task DownloadPartAsync(int partNumber)
        {
            // Wait for HTTP concurrency slot
            await _httpConcurrencySemaphore.WaitAsync();

            try
            {
                // Simulate variable network latency (causes out-of-order arrival) - minimal for speed
                var delay = Random.Shared.Next(1, 5);
                await Task.Delay(delay);

                // Check if this part is the next expected (in order)
                bool isNextExpected = partNumber == Interlocked.CompareExchange(ref _nextExpectedPartNumber, 0, 0);

                if (isNextExpected && partNumber == 1)
                {
                    // Part 1 in order - stream directly (NO BUFFERING)
                    Interlocked.Increment(ref _partsStreamed);
                    Interlocked.Increment(ref _nextExpectedPartNumber);
                    
                    // Simulate streaming (no ArrayPool allocation) - minimal for speed
                    await Task.Delay(1);
                }
                else
                {
                    // Out of order - need to buffer
                    await BufferPartAsync(partNumber);
                }
            }
            finally
            {
                _httpConcurrencySemaphore.Release();
            }
        }

        private async Task BufferPartAsync(int partNumber)
        {
            // Wait for buffer space (MaxInMemoryParts enforcement)
            var spaceAvailable = _bufferSpaceSemaphore.CurrentCount;
            if (spaceAvailable == 0)
            {
                Interlocked.Increment(ref _bufferFullCount);
            }
            
            await _bufferSpaceSemaphore.WaitAsync();

            try
            {
                // Allocate chunks for this buffered part
                var chunks = new List<byte[]>(ChunksPerPart);
                
                for (int i = 0; i < ChunksPerPart; i++)
                {
                    var chunk = _arrayPool.Rent(_chunkSize);
                    chunks.Add(chunk);
                }

                // Store buffered part
                var bufferedPart = new BufferedPart { PartNumber = partNumber, Chunks = chunks };
                _bufferedParts.TryAdd(partNumber, bufferedPart);
                
                Interlocked.Increment(ref _partsBuffered);
                
                // Update peak
                var currentBuffered = _bufferedParts.Count;
                int currentPeak;
                do
                {
                    currentPeak = Volatile.Read(ref _peakBufferedParts);
                    if (currentBuffered <= currentPeak)
                        break;
                } while (Interlocked.CompareExchange(ref _peakBufferedParts, currentBuffered, currentPeak) != currentPeak);
            }
            catch
            {
                _bufferSpaceSemaphore.Release();
                throw;
            }
        }

        private async Task RunConsumerAsync(int totalParts)
        {
            Console.WriteLine($"[DEBUG] Consumer started, will process {totalParts} parts");
            
            // Consumer reads parts sequentially
            for (int partNum = 1; partNum <= totalParts; partNum++)
            {
                // Log every 10 parts
                if (partNum % 10 == 0 || partNum == 1)
                {
                    Console.WriteLine($"[DEBUG] Consumer processing part {partNum}/{totalParts}");
                }
                
                // Part 1 special handling - it might stream or buffer
                if (partNum == 1)
                {
                    // Wait for part 1 to either stream or be buffered
                    int waitCount = 0;
                    while (Volatile.Read(ref _partsStreamed) == 0 && !_bufferedParts.ContainsKey(1))
                    {
                        await Task.Delay(1);
                        waitCount++;
                        if (waitCount % 1000 == 0)
                        {
                            Console.WriteLine($"[DEBUG] Still waiting for part 1 to arrive (waited {waitCount}ms, streamed={Volatile.Read(ref _partsStreamed)}, buffered parts: {_bufferedParts.Count})");
                        }
                    }
                    
                    // Check if it was streamed
                    if (Volatile.Read(ref _partsStreamed) > 0)
                    {
                        Console.WriteLine($"[DEBUG] Part 1 was streamed, skipping");
                        Interlocked.Increment(ref _nextExpectedPartNumber);
                        continue;
                    }
                }

                // Wait for this part to be buffered
                int waitCount2 = 0;
                while (!_bufferedParts.ContainsKey(partNum))
                {
                    await Task.Delay(1);
                    waitCount2++;
                    if (waitCount2 % 1000 == 0)
                    {
                        Console.WriteLine($"[DEBUG] Still waiting for part {partNum} (waited {waitCount2}ms, buffered parts: {_bufferedParts.Count})");
                    }
                }

                // Consume the buffered part
                if (_bufferedParts.TryRemove(partNum, out var bufferedPart))
                {
                    // Simulate reading the part - minimal for speed
                    await Task.Delay(1);

                    // Return chunks to pool
                    foreach (var chunk in bufferedPart.Chunks)
                    {
                        _arrayPool.Return(chunk);
                    }

                    // Release buffer slot for next part
                    _bufferSpaceSemaphore.Release();
                }

                // Advance expected part number
                Interlocked.Increment(ref _nextExpectedPartNumber);
            }
            
            Console.WriteLine($"[DEBUG] Consumer finished all {totalParts} parts");
        }

        public SimulatorStatistics GetStatistics()
        {
            return new SimulatorStatistics
            {
                PartsStreamed = Volatile.Read(ref _partsStreamed),
                PartsBuffered = Volatile.Read(ref _partsBuffered),
                PeakBufferedParts = Volatile.Read(ref _peakBufferedParts),
                BufferFullCount = Volatile.Read(ref _bufferFullCount)
            };
        }

        private class BufferedPart
        {
            public int PartNumber { get; set; }
            public List<byte[]> Chunks { get; set; } = new();
        }
    }
}
