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
                // Check if running as child process
                if (args.Length >= 2 && args[0] == "--scenario")
                {
                    await RunSingleScenarioAsync(int.Parse(args[1]));
                    return;
                }
                
                // Parent mode: spawn child processes for each scenario
                await RunAllScenariosAsProcessesAsync();
            }

            static async Task RunAllScenariosAsProcessesAsync()
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
     
                // Run simulations for various configurations
                var scenarios = GetScenarios();
     
                for (int i = 0; i < scenarios.Length; i++)
                {
                    var (name, partSize, chunkSize, concurrent, maxInMemory, totalParts) = scenarios[i];
                    
                    output.WriteLine($"Running scenario {i + 1}/{scenarios.Length} in separate process...");
                    output.WriteLine($"Scenario: {name}");
                    output.WriteLine("────────────────────────────────────────────────────────────────────────");
                    
                    // Spawn child process for this scenario
                    var result = await RunScenarioInProcessAsync(i, output);
                    
                    if (result != null)
                    {
                        results.Add(result);
                        output.WriteLine($"✓ Scenario {i + 1} complete: RealOSVMAsCreated = {result.RealOSVMAsCreated:N0}");
                    }
                    else
                    {
                        output.WriteLine($"✗ Scenario {i + 1} failed");
                    }
                    
                    output.WriteLine();
                }
     
                output.WriteLine("════════════════════════════════════════════════════════════════════════");
                output.WriteLine("All simulations complete!");
                output.WriteLine("════════════════════════════════════════════════════════════════════════");
                output.WriteLine();
                
                // Export JSON for analysis
                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(results, jsonOptions);
                File.WriteAllText(jsonFile, json);
                
                // Export Markdown table
                var markdownFile = "arraypool_simulation_results.md";
                ExportMarkdownTable(results, markdownFile);
                
                output.WriteLine($"Results saved to:");
                output.WriteLine($"  - {outputFile} (human-readable)");
                output.WriteLine($"  - {jsonFile} (machine-readable JSON)");
                output.WriteLine($"  - {markdownFile} (markdown table)");
                
                Console.WriteLine("\nSimulation complete! Check output files for results.");
            }

            static (string, long, int, int, int, int)[] GetScenarios()
            {
                return new[]
                {
                    // (Name, PartSize, ChunkSize, ConcurrentRequests, MaxInMemoryParts, TotalParts)
                    // NOTE: Only including scenarios where C <= M (since M throttles C)
                    
                    // === PART 1: Different M values (64MB parts, 64KB chunks, C=2) ===
                    // Goal: Understand M's impact on VMA creation
                    ("64MB parts, 64KB chunks, C=2, M=4", 64L * 1024 * 1024, 64 * 1024, 2, 4, 100),
                    ("64MB parts, 64KB chunks, C=2, M=8", 64L * 1024 * 1024, 64 * 1024, 2, 8, 100),
                    ("64MB parts, 64KB chunks, C=2, M=12", 64L * 1024 * 1024, 64 * 1024, 2, 12, 100),
                    ("64MB parts, 64KB chunks, C=2, M=16", 64L * 1024 * 1024, 64 * 1024, 2, 16, 100),
                    ("64MB parts, 64KB chunks, C=2, M=24", 64L * 1024 * 1024, 64 * 1024, 2, 24, 100),
                    ("64MB parts, 64KB chunks, C=2, M=32", 64L * 1024 * 1024, 64 * 1024, 2, 32, 100),
                    ("64MB parts, 64KB chunks, C=2, M=48", 64L * 1024 * 1024, 64 * 1024, 2, 48, 100),
                    ("64MB parts, 64KB chunks, C=2, M=64", 64L * 1024 * 1024, 64 * 1024, 2, 64, 100),
                    
                    // === PART 2: C scaling with M (64MB parts, 64KB chunks) ===
                    // M=8: C at different fractions
                    ("64MB parts, 64KB chunks, C=2, M=8", 64L * 1024 * 1024, 64 * 1024, 2, 8, 100),
                    ("64MB parts, 64KB chunks, C=4, M=8", 64L * 1024 * 1024, 64 * 1024, 4, 8, 100),
                    ("64MB parts, 64KB chunks, C=8, M=8", 64L * 1024 * 1024, 64 * 1024, 8, 8, 100),
                    
                    // M=16: C at different fractions
                    ("64MB parts, 64KB chunks, C=4, M=16", 64L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    ("64MB parts, 64KB chunks, C=8, M=16", 64L * 1024 * 1024, 64 * 1024, 8, 16, 100),
                    ("64MB parts, 64KB chunks, C=16, M=16", 64L * 1024 * 1024, 64 * 1024, 16, 16, 100),
                    
                    // M=32: C at different fractions
                    ("64MB parts, 64KB chunks, C=8, M=32", 64L * 1024 * 1024, 64 * 1024, 8, 32, 100),
                    ("64MB parts, 64KB chunks, C=16, M=32", 64L * 1024 * 1024, 64 * 1024, 16, 32, 100),
                    ("64MB parts, 64KB chunks, C=32, M=32", 64L * 1024 * 1024, 64 * 1024, 32, 32, 100),
                    
                    // M=64: C at different fractions
                    ("64MB parts, 64KB chunks, C=16, M=64", 64L * 1024 * 1024, 64 * 1024, 16, 64, 100),
                    ("64MB parts, 64KB chunks, C=32, M=64", 64L * 1024 * 1024, 64 * 1024, 32, 64, 100),
                    ("64MB parts, 64KB chunks, C=64, M=64", 64L * 1024 * 1024, 64 * 1024, 64, 64, 100),
                    
                    // === PART 3: Different Chunk Sizes (64MB parts, C=10, M=16) ===
                    ("64MB parts, 32KB chunks, C=10, M=16", 64L * 1024 * 1024, 32 * 1024, 10, 16, 100),
                    ("64MB parts, 64KB chunks, C=10, M=16", 64L * 1024 * 1024, 64 * 1024, 10, 16, 100),
                    ("64MB parts, 128KB chunks, C=10, M=16", 64L * 1024 * 1024, 128 * 1024, 10, 16, 100),
                    ("64MB parts, 256KB chunks, C=10, M=16", 64L * 1024 * 1024, 256 * 1024, 10, 16, 100),
                    
                    // === PART 4: Part Size progression (64KB chunks, C=4, M=16) ===
                    ("8MB parts, 64KB chunks, C=4, M=16", 8L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    ("16MB parts, 64KB chunks, C=4, M=16", 16L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    ("32MB parts, 64KB chunks, C=4, M=16", 32L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    ("64MB parts, 64KB chunks, C=4, M=16", 64L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    ("128MB parts, 64KB chunks, C=4, M=16", 128L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    ("256MB parts, 64KB chunks, C=4, M=16", 256L * 1024 * 1024, 64 * 1024, 4, 16, 100),
                    
                    // === PART 5: Full Matrix for key configurations ===
                    // 8MB parts - various C×M combinations
                    ("8MB parts, 64KB chunks, C=2, M=8", 8L * 1024 * 1024, 64 * 1024, 2, 8, 100),
                    ("8MB parts, 64KB chunks, C=4, M=8", 8L * 1024 * 1024, 64 * 1024, 4, 8, 100),
                    ("8MB parts, 64KB chunks, C=8, M=8", 8L * 1024 * 1024, 64 * 1024, 8, 8, 100),
                    ("8MB parts, 64KB chunks, C=2, M=16", 8L * 1024 * 1024, 64 * 1024, 2, 16, 100),
                    ("8MB parts, 64KB chunks, C=8, M=16", 8L * 1024 * 1024, 64 * 1024, 8, 16, 100),
                    ("8MB parts, 64KB chunks, C=16, M=16", 8L * 1024 * 1024, 64 * 1024, 16, 16, 100),
                    ("8MB parts, 64KB chunks, C=4, M=32", 8L * 1024 * 1024, 64 * 1024, 4, 32, 100),
                    ("8MB parts, 64KB chunks, C=16, M=32", 8L * 1024 * 1024, 64 * 1024, 16, 32, 100),
                    ("8MB parts, 64KB chunks, C=32, M=32", 8L * 1024 * 1024, 64 * 1024, 32, 32, 100),
                    
                    // 32MB parts - various C×M combinations
                    ("32MB parts, 64KB chunks, C=2, M=8", 32L * 1024 * 1024, 64 * 1024, 2, 8, 100),
                    ("32MB parts, 64KB chunks, C=4, M=8", 32L * 1024 * 1024, 64 * 1024, 4, 8, 100),
                    ("32MB parts, 64KB chunks, C=8, M=8", 32L * 1024 * 1024, 64 * 1024, 8, 8, 100),
                    ("32MB parts, 64KB chunks, C=2, M=16", 32L * 1024 * 1024, 64 * 1024, 2, 16, 100),
                    ("32MB parts, 64KB chunks, C=8, M=16", 32L * 1024 * 1024, 64 * 1024, 8, 16, 100),
                    ("32MB parts, 64KB chunks, C=16, M=16", 32L * 1024 * 1024, 64 * 1024, 16, 16, 100),
                    ("32MB parts, 64KB chunks, C=4, M=32", 32L * 1024 * 1024, 64 * 1024, 4, 32, 100),
                    ("32MB parts, 64KB chunks, C=16, M=32", 32L * 1024 * 1024, 64 * 1024, 16, 32, 100),
                    ("32MB parts, 64KB chunks, C=32, M=32", 32L * 1024 * 1024, 64 * 1024, 32, 32, 100),
                    
                    // 128MB parts - various C×M combinations
                    ("128MB parts, 64KB chunks, C=2, M=8", 128L * 1024 * 1024, 64 * 1024, 2, 8, 100),
                    ("128MB parts, 64KB chunks, C=4, M=8", 128L * 1024 * 1024, 64 * 1024, 4, 8, 100),
                    ("128MB parts, 64KB chunks, C=8, M=8", 128L * 1024 * 1024, 64 * 1024, 8, 8, 100),
                    ("128MB parts, 64KB chunks, C=2, M=16", 128L * 1024 * 1024, 64 * 1024, 2, 16, 100),
                    ("128MB parts, 64KB chunks, C=8, M=16", 128L * 1024 * 1024, 64 * 1024, 8, 16, 100),
                    ("128MB parts, 64KB chunks, C=16, M=16", 128L * 1024 * 1024, 64 * 1024, 16, 16, 100),
                    ("128MB parts, 64KB chunks, C=4, M=32", 128L * 1024 * 1024, 64 * 1024, 4, 32, 100),
                    ("128MB parts, 64KB chunks, C=16, M=32", 128L * 1024 * 1024, 64 * 1024, 16, 32, 100),
                    ("128MB parts, 64KB chunks, C=32, M=32", 128L * 1024 * 1024, 64 * 1024, 32, 32, 100),
                };
            }

            static async Task<SimulationResult?> RunScenarioInProcessAsync(int scenarioIndex, DualWriter output)
            {
                try
                {
                    // Build the command to run this scenario in a child process
                    var processInfo = new ProcessStartInfo
                    {
                        FileName = "dotnet",
                        Arguments = $"run -- --scenario {scenarioIndex}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        WorkingDirectory = Directory.GetCurrentDirectory()
                    };

                    using var process = new Process { StartInfo = processInfo };
                    var outputBuilder = new StringBuilder();
                    var errorBuilder = new StringBuilder();

                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            outputBuilder.AppendLine(e.Data);
                        }
                    };

                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            errorBuilder.AppendLine(e.Data);
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await process.WaitForExitAsync();

                    if (process.ExitCode != 0)
                    {
                        output.WriteLine($"Process exited with code {process.ExitCode}");
                        output.WriteLine($"Error output: {errorBuilder}");
                        return null;
                    }

                    // Parse JSON result from stdout
                    var jsonOutput = outputBuilder.ToString();
                    var result = JsonSerializer.Deserialize<SimulationResult>(jsonOutput);
                    
                    return result;
                }
                catch (Exception ex)
                {
                    output.WriteLine($"Error running scenario {scenarioIndex}: {ex.Message}");
                    return null;
                }
            }

            static async Task RunSingleScenarioAsync(int scenarioIndex)
            {
                var scenarios = GetScenarios();
                
                if (scenarioIndex < 0 || scenarioIndex >= scenarios.Length)
                {
                    Console.Error.WriteLine($"Invalid scenario index: {scenarioIndex}");
                    Environment.Exit(1);
                    return;
                }

                var (name, partSize, chunkSize, concurrent, maxInMemory, totalParts) = scenarios[scenarioIndex];

                // Suppress all console output during simulation - redirect to null
                var originalOut = Console.Out;
                Console.SetOut(TextWriter.Null);

                try
                {
                    // Run simulation silently (no console output)
                    var tracker = new ArrayPoolTracker<byte>(chunkSize);
                    var simulator = new AccurateOpenStreamSimulator(tracker, partSize, chunkSize, concurrent, maxInMemory);

                    int initialVMAs = GetVMACount();
                    
                    var sw = Stopwatch.StartNew();
                    await simulator.SimulateDownloadAsync(totalParts);
                    sw.Stop();

                    int finalVMAs = GetVMACount();
                    int vmasDelta = finalVMAs - initialVMAs;

                    var stats = tracker.GetStatistics();
                    var simStats = simulator.GetStatistics();

                    var result = new SimulationResult
                    {
                        ScenarioName = name,
                        PartSize = partSize,
                        ChunkSize = chunkSize,
                        ConcurrentRequests = concurrent,
                        MaxInMemoryParts = maxInMemory,
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
                        SimulatedUniqueArrays = stats.UniqueArrays,
                        RealOSVMAsCreated = vmasDelta,
                        IsSafeTheoretical = stats.TotalRents < 65536,
                        IsSafeSimulated = stats.UniqueArrays < 65536,
                        SimulationTimeMs = sw.ElapsedMilliseconds
                    };

                    // Restore console output
                    Console.SetOut(originalOut);

                    // Output JSON to stdout (only output)
                    var jsonOptions = new JsonSerializerOptions { WriteIndented = false };
                    var json = JsonSerializer.Serialize(result, jsonOptions);
                    Console.WriteLine(json);
                }
                catch (Exception ex)
                {
                    // Restore console on error
                    Console.SetOut(originalOut);
                    Console.Error.WriteLine($"Error in scenario {scenarioIndex}: {ex.Message}");
                    Environment.Exit(1);
                }
            }
     
            static async Task<SimulationResult> RunSimulation(DualWriter output, string name, long partSize, int chunkSize, 
                int concurrentRequests, int maxInMemoryParts, int totalParts)
            {
                output.WriteLine($"Scenario: {name}");
                output.WriteLine("────────────────────────────────────────────────────────────────────────");
     
                var tracker = new ArrayPoolTracker<byte>(chunkSize);
                var simulator = new AccurateOpenStreamSimulator(tracker, partSize, chunkSize, concurrentRequests, maxInMemoryParts);
     
                // Monitor VMA count
                int initialVMAs = GetVMACount();
                
                var sw = Stopwatch.StartNew();
                await simulator.SimulateDownloadAsync(totalParts);
                sw.Stop();
     
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
                
                tracker.PrintReport(output, simulator.ChunksPerPart, simStats.PartsBuffered);
     
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
                    SimulatedUniqueArrays = stats.UniqueArrays,  // Our simulation-based estimate
                    RealOSVMAsCreated = vmasDelta,  // Actual OS-level VMAs from /proc/self/maps
                    IsSafeTheoretical = stats.TotalRents < 65536,
                    IsSafeSimulated = stats.UniqueArrays < 65536,
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

            static void ExportMarkdownTable(List<SimulationResult> results, string filename)
            {
                using var writer = new StreamWriter(filename);
                
                writer.WriteLine("# ArrayPool Simulation Results");
                writer.WriteLine();
                writer.WriteLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                writer.WriteLine();
                
                writer.WriteLine("## Summary Table");
                writer.WriteLine();
                
                // Write header
                writer.WriteLine("| Scenario | Part Size | Chunk Size | C | M | Chunks/Part | Parts Buffered | Peak Buffered | Unique Arrays | Pool Hit % | Safe? |");
                writer.WriteLine("|----------|-----------|------------|---|---|-------------|----------------|---------------|---------------|------------|-------|");
                
                // Write rows
                foreach (var result in results)
                {
                    var partSizeMB = result.PartSize / (1024.0 * 1024);
                    var chunkSizeKB = result.ChunkSize / 1024;
                    var safeStatus = result.IsSafeSimulated ? "✓" : "✗";
                    
                    writer.WriteLine($"| {result.ScenarioName} | {partSizeMB:F0} MB | {chunkSizeKB} KB | {result.ConcurrentRequests} | {result.MaxInMemoryParts} | {result.ChunksPerPart:N0} | {result.PartsBuffered} | {result.PeakBufferedParts} | {result.UniqueArrays:N0} | {result.PoolHitRate * 100:F1}% | {safeStatus} |");
                }
                
                writer.WriteLine();
                writer.WriteLine("## Detailed Metrics");
                writer.WriteLine();
                
                // Write detailed header
                writer.WriteLine("| Scenario | Total Rents | Total Returns | Peak Concurrent | Pool Miss % | Theoretical Max VMAs | Simulated VMAs | Real OS VMAs | Time (ms) |");
                writer.WriteLine("|----------|-------------|---------------|-----------------|-------------|----------------------|----------------|--------------|-----------|");
                
                // Write detailed rows
                foreach (var result in results)
                {
                    writer.WriteLine($"| {result.ScenarioName} | {result.TotalRents:N0} | {result.TotalReturns:N0} | {result.PeakConcurrentArrays} | {result.PoolMissRate * 100:F2}% | {result.TheoreticalMaxVMAs:N0} | {result.SimulatedUniqueArrays:N0} | {result.RealOSVMAsCreated:N0} | {result.SimulationTimeMs} |");
                }
                
                writer.WriteLine();
                writer.WriteLine("## Legend");
                writer.WriteLine();
                writer.WriteLine("- **C**: Concurrent Requests");
                writer.WriteLine("- **M**: MaxInMemoryParts");
                writer.WriteLine("- **Chunks/Part**: Number of chunks per part (PartSize / ChunkSize)");
                writer.WriteLine("- **Parts Buffered**: Number of parts that needed buffering (out-of-order)");
                writer.WriteLine("- **Peak Buffered**: Maximum number of parts buffered simultaneously");
                writer.WriteLine("- **Unique Arrays**: Number of unique arrays allocated (VMA estimate)");
                writer.WriteLine("- **Pool Hit %**: Percentage of Rent() calls served from pool");
                writer.WriteLine("- **Safe?**: ✓ if under 65,536 VMA limit, ✗ if exceeds");
                writer.WriteLine("- **Theoretical Max VMAs**: If every Rent() created a new VMA");
                writer.WriteLine("- **Simulated VMAs**: Estimated VMAs from unique array tracking");
                writer.WriteLine("- **Real OS VMAs**: Actual VMA delta from /proc/self/maps (Linux only)");
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
            public long SimulatedUniqueArrays { get; set; }  // Renamed from ActualVMAs - this is our estimate
            public int RealOSVMAsCreated { get; set; }  // Renamed from RealVMAsDelta - actual OS-level VMAs
            public bool IsSafeTheoretical { get; set; }
            public bool IsSafeSimulated { get; set; }  // Renamed from IsSafeActual
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
     
            public void PrintReport(DualWriter output, int chunksPerPart, int partsBuffered)
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
                    
                    // Formula Derivation - purely data-driven
                    output.WriteLine("Formula Derivation (from simulation data):");
                    output.WriteLine($"  ─────────────────────────────────────────────────");
                    
                    // Basic measurements
                    output.WriteLine($"  Measured Values:");
                    output.WriteLine($"    Unique Arrays (VMAs):     {stats.UniqueArrays:N0}");
                    output.WriteLine($"    Chunks Per Part:          {chunksPerPart:N0}");
                    output.WriteLine($"    Parts Buffered:           {partsBuffered:N0}");
                    output.WriteLine($"    Total Rent() calls:       {stats.TotalRents:N0}");
                    output.WriteLine();
                    
                    // Calculate all possible ratios
                    double vmaPerChunk = (double)stats.UniqueArrays / chunksPerPart;
                    double vmaPerPart = partsBuffered > 0 ? (double)stats.UniqueArrays / partsBuffered : 0;
                    double poolMissRate = stats.PoolMissRate;
                    
                    output.WriteLine($"  Calculated Ratios:");
                    output.WriteLine($"    VMAs / ChunksPerPart:     {stats.UniqueArrays:N0} / {chunksPerPart:N0} = {vmaPerChunk:F3}");
                    if (partsBuffered > 0)
                    {
                        output.WriteLine($"    VMAs / PartsBuffered:     {stats.UniqueArrays:N0} / {partsBuffered:N0} = {vmaPerPart:F3}");
                    }
                    output.WriteLine($"    Pool Miss Rate:           {stats.UniqueArrays:N0} / {stats.TotalRents:N0} = {poolMissRate:F3}");
                    output.WriteLine();
                    
                    // Derive the formula
                    if (partsBuffered > 0)
                    {
                        output.WriteLine($"  Formula Derivation:");
                        
                        // Method 1: Direct from parts and chunks
                        double factor1 = vmaPerChunk / partsBuffered;
                        output.WriteLine($"    Method 1 (VMAs per chunk per part):");
                        output.WriteLine($"      Factor = (VMAs / ChunksPerPart) / PartsBuffered");
                        output.WriteLine($"      Factor = {vmaPerChunk:F3} / {partsBuffered} = {factor1:F6}");
                        output.WriteLine($"      Formula: VMAs = {factor1:F6} × PartsBuffered × ChunksPerPart");
                        output.WriteLine();
                        
                        // Method 2: Pool miss rate approach
                        output.WriteLine($"    Method 2 (Pool efficiency):");
                        output.WriteLine($"      Pool Miss Rate = {poolMissRate:F6}");
                        output.WriteLine($"      Formula: VMAs = PoolMissRate × TotalRents");
                        output.WriteLine($"      Formula: VMAs = PoolMissRate × (PartsBuffered × ChunksPerPart)");
                        output.WriteLine();
                        
                        // Verify both methods
                        double predicted1 = factor1 * partsBuffered * chunksPerPart;
                        double predicted2 = poolMissRate * stats.TotalRents;
                        
                        output.WriteLine($"  Verification:");
                        output.WriteLine($"    Actual VMAs:              {stats.UniqueArrays:N0}");
                        output.WriteLine($"    Method 1 Prediction:      {predicted1:F0}");
                        output.WriteLine($"    Method 2 Prediction:      {predicted2:F0}");
                        
                        double error1 = Math.Abs(predicted1 - stats.UniqueArrays) / stats.UniqueArrays * 100;
                        double error2 = Math.Abs(predicted2 - stats.UniqueArrays) / stats.UniqueArrays * 100;
                        
                        output.WriteLine($"    Method 1 Error:           {error1:F3}%");
                        output.WriteLine($"    Method 2 Error:           {error2:F3}%");
                        output.WriteLine();
                        
                        // Summary formula
                        output.WriteLine($"  DERIVED FORMULA:");
                        output.WriteLine($"    VMAs = {poolMissRate:F6} × (PartSize / ChunkSize)");
                        output.WriteLine($"    where the factor {poolMissRate:F6} is the ArrayPool miss rate");
                        output.WriteLine($"    for this specific configuration (C={partsBuffered}, buffered parts)");
                    }
                    output.WriteLine($"  ─────────────────────────────────────────────────");
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
                    
                    // Small delay between starting downloads
                    await Task.Delay(5);
                }
     
                await Task.WhenAll(downloadTasks);
            }
     
            private async Task DownloadPartAsync(int partNumber)
            {
                // Wait for HTTP concurrency slot
                await _httpConcurrencySemaphore.WaitAsync();
     
                try
                {
                    // Simulate variable network latency (causes out-of-order arrival)
                    var delay = Random.Shared.Next(10, 100);
                    await Task.Delay(delay);
     
                    // Check if this part is the next expected (in order)
                    bool isNextExpected = partNumber == Interlocked.CompareExchange(ref _nextExpectedPartNumber, 0, 0);
     
                    if (isNextExpected && partNumber == 1)
                    {
                        // Part 1 in order - stream directly (NO BUFFERING)
                        Interlocked.Increment(ref _partsStreamed);
                        Interlocked.Increment(ref _nextExpectedPartNumber);
                        
                        // Simulate streaming (no ArrayPool allocation)
                        await Task.Delay(50); // Simulate read time
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
                // Consumer reads parts sequentially
                for (int partNum = 1; partNum <= totalParts; partNum++)
                {
                    // Debug logging every 10 parts
                    if (partNum % 10 == 0)
                    {
                        Console.WriteLine($"[CONSUMER] Processing part {partNum}/{totalParts}, buffered parts: {_bufferedParts.Count}");
                    }

                    // Special handling for part 1: it could be streamed OR buffered
                    if (partNum == 1)
                    {
                        // Wait for producer to make a decision about part 1
                        int waitCount = 0;
                        while (true)
                        {
                            bool wasStreamed = Volatile.Read(ref _partsStreamed) > 0;
                            bool isBuffered = _bufferedParts.ContainsKey(1);
                            
                            if (wasStreamed)
                            {
                                // Part 1 was streamed directly
                                Console.WriteLine($"[CONSUMER] Part 1 was streamed directly");
                                break; // Exit wait loop and continue to next part
                            }
                            else if (isBuffered)
                            {
                                // Part 1 is in buffer, fall through to consume it
                                Console.WriteLine($"[CONSUMER] Part 1 is buffered, consuming it");
                                break; // Exit wait loop to consume from buffer
                            }
                            
                            // Neither streamed nor buffered yet, keep waiting
                            await Task.Delay(10);
                            waitCount++;
                            
                            if (waitCount % 100 == 0)
                            {
                                Console.WriteLine($"[CONSUMER] Waiting for part 1 decision (waited {waitCount * 10}ms, streamed={wasStreamed}, buffered={isBuffered})");
                            }
                        }
                        
                        // If it was streamed, skip consuming from buffer
                        if (Volatile.Read(ref _partsStreamed) > 0)
                        {
                            continue;
                        }
                        // Otherwise fall through to consume from buffer
                    }
     
                    // Wait for this part to be buffered (for parts 2+, or part 1 if it was buffered)
                    int waitCount2 = 0;
                    while (!_bufferedParts.ContainsKey(partNum))
                    {
                        await Task.Delay(10);
                        waitCount2++;
                        
                        // Debug logging if waiting too long
                        if (waitCount2 % 100 == 0)
                        {
                            Console.WriteLine($"[CONSUMER] Still waiting for part {partNum} (waited {waitCount2 * 10}ms, buffered parts: {_bufferedParts.Count})");
                        }
                    }
     
                    // Consume the buffered part
                    if (_bufferedParts.TryRemove(partNum, out var bufferedPart))
                    {
                        // Simulate reading the part
                        await Task.Delay(20);
     
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
                
                Console.WriteLine($"[CONSUMER] Completed processing all {totalParts} parts");
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
