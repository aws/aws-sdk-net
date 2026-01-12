using ConsoleTables;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Analyzes simulation results and generates reports with recommendations.
/// </summary>
public class ResultsAnalyzer
{
    private readonly List<SimulationMetrics> _results = new();

    public void AddResult(SimulationMetrics result) => _results.Add(result);
    public void AddResults(IEnumerable<SimulationMetrics> results) => _results.AddRange(results);
    public void Clear() => _results.Clear();

    /// <summary>
    /// Prints a summary table of all results.
    /// </summary>
    public void PrintSummaryTable()
    {
        if (!_results.Any())
        {
            Console.WriteLine("No results to display.");
            return;
        }

        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("TEST RESULTS SUMMARY");
        Console.WriteLine(new string('═', 140));

        var table = new ConsoleTable(
            "Name", 
            "Part Size", 
            "Chunk Size", 
            "MaxInMem", 
            "Peak VMA",
            "Peak Alloc",
            "Duration",
            "Parts/s",
            "MB/s",
            "Status");

        foreach (var result in _results.OrderBy(r => r.Config.ChunkSizeBytes))
        {
            var config = result.Config;
            table.AddRow(
                TruncateName(config.Name, 25),
                FormatBytes(config.PartSizeBytes),
                FormatBytes(config.ChunkSizeBytes),
                config.MaxInMemoryParts,
                result.PeakVmaCount.ToString("N0"),
                FormatBytes(result.PeakAllocatedBytes),
                $"{result.DurationMs:N0}ms",
                $"{result.PartsPerSecond:F1}",
                $"{result.MemoryThroughputMBps:F1}",
                result.Status
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Prints detailed timing analysis comparing different configurations.
    /// </summary>
    public void PrintTimingAnalysis()
    {
        if (!_results.Any())
        {
            Console.WriteLine("No results to display.");
            return;
        }

        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("TIMING ANALYSIS");
        Console.WriteLine(new string('═', 140));

        var table = new ConsoleTable(
            "Name", 
            "Total", 
            "RampUp", 
            "Steady",
            "Parts/s",
            "Alloc/s",
            "MB/s",
            "Peak Buffer");

        foreach (var result in _results.OrderBy(r => r.DurationMs))
        {
            var config = result.Config;
            table.AddRow(
                TruncateName(config.Name, 30),
                $"{result.DurationMs:N0}ms",
                $"{result.RampUpTimeMs:N0}ms",
                $"{result.SteadyStateTimeMs:N0}ms",
                $"{result.PartsPerSecond:F1}",
                $"{result.AllocationsPerSecond:F0}",
                $"{result.MemoryThroughputMBps:F1}",
                result.PeakBufferParts
            );
        }

        table.Write(Format.MarkDown);

        // Summary
        Console.WriteLine("\n--- Timing Summary ---\n");
        Console.WriteLine($"  Fastest: {_results.MinBy(r => r.DurationMs)?.Config.Name} ({_results.Min(r => r.DurationMs):N0}ms)");
        Console.WriteLine($"  Slowest: {_results.MaxBy(r => r.DurationMs)?.Config.Name} ({_results.Max(r => r.DurationMs):N0}ms)");
        Console.WriteLine($"  Best Throughput: {_results.MaxBy(r => r.MemoryThroughputMBps)?.Config.Name} ({_results.Max(r => r.MemoryThroughputMBps):F1} MB/s)");
        
        var speedup = _results.Max(r => r.DurationMs) / (double)Math.Max(1, _results.Min(r => r.DurationMs));
        Console.WriteLine($"  Speedup factor: {speedup:F1}x");
    }

    /// <summary>
    /// Prints a detailed report for a single result.
    /// </summary>
    public void PrintDetailedResult(SimulationMetrics result)
    {
        var config = result.Config;
        
        Console.WriteLine($"\n{'─',50}");
        Console.WriteLine($"Test: {config.Name}");
        Console.WriteLine($"{'─',50}");
        
        Console.WriteLine("\nConfiguration:");
        Console.WriteLine($"  Part Size:                  {FormatBytes(config.PartSizeBytes)}");
        Console.WriteLine($"  Chunk Size:                 {FormatBytes(config.ChunkSizeBytes)}");
        Console.WriteLine($"  Total Parts:                {config.TotalParts}");
        Console.WriteLine($"  MaxInMemoryParts:           {config.MaxInMemoryParts}");
        Console.WriteLine($"  ConcurrentServiceRequests:  {config.ConcurrentServiceRequests}");
        Console.WriteLine($"  Chunks per Part:            {config.ChunksPerPart}");
        Console.WriteLine($"  Max Concurrent Chunks:      {config.MaxConcurrentChunks}");
        
        Console.WriteLine("\nVMA Metrics:");
        Console.WriteLine($"  Estimated Peak VMA:         {config.EstimatedPeakVmaCount:N0}");
        Console.WriteLine($"  Actual Peak VMA:            {result.PeakVmaCount:N0}");
        Console.WriteLine($"  Peak Active Chunks:         {result.PeakActiveChunks:N0}");
        Console.WriteLine($"  Peak Buffer Parts:          {result.PeakBufferParts}");
        Console.WriteLine($"  Safety Margin:              {result.SafetyMarginPercent:F1}%");
        Console.WriteLine($"  Status:                     {result.Status}");
        
        Console.WriteLine("\nMemory Metrics:");
        Console.WriteLine($"  Expected Memory:            {result.ExpectedMemoryFormatted} (MaxInMemoryParts × PartSize)");
        Console.WriteLine($"  Peak Allocated:             {result.PeakAllocatedFormatted}");
        Console.WriteLine($"  Baseline Working Set:       {FormatBytes(result.BaselineWorkingSetBytes)}");
        Console.WriteLine($"  Peak Working Set:           {result.PeakWorkingSetFormatted}");
        Console.WriteLine($"  Working Set Delta:          {result.WorkingSetDeltaFormatted}");
        Console.WriteLine($"  Peak GC Memory:             {FormatBytes(result.PeakGcMemoryBytes)}");
        Console.WriteLine($"  GC Memory Delta:            {FormatBytes(result.GcMemoryDeltaBytes)}");
        Console.WriteLine($"  WS Efficiency Ratio:        {result.WorkingSetEfficiencyRatio:F2}x");
        Console.WriteLine($"  Alloc Efficiency Ratio:     {result.AllocatedEfficiencyRatio:F2}x (should be ~1.0)");
        
        Console.WriteLine("\nTiming:");
        Console.WriteLine($"  Total Duration:             {result.DurationMs:N0} ms");
        Console.WriteLine($"  Ramp-Up Time:               {result.RampUpTimeMs:N0} ms");
        Console.WriteLine($"  Steady-State Time:          {result.SteadyStateTimeMs:N0} ms");
        
        Console.WriteLine("\nThroughput:");
        Console.WriteLine($"  Parts/second:               {result.PartsPerSecond:F1}");
        Console.WriteLine($"  Allocations/second:         {result.AllocationsPerSecond:F0}");
        Console.WriteLine($"  Memory Throughput:          {result.MemoryThroughputMBps:F1} MB/s");
        Console.WriteLine($"  Total Allocations:          {result.TotalAllocations:N0}");
        Console.WriteLine($"  Total Deallocations:        {result.TotalDeallocations:N0}");
    }

    /// <summary>
    /// Prints analysis comparing different chunk sizes.
    /// </summary>
    public void PrintChunkSizeAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("CHUNK SIZE IMPACT ANALYSIS");
        Console.WriteLine(new string('═', 140));

        var groupedByChunk = _results
            .GroupBy(r => r.Config.ChunkSizeBytes)
            .OrderBy(g => g.Key);

        var table = new ConsoleTable(
            "Chunk Size",
            "Avg Peak VMA",
            "Max Peak VMA",
            "Avg Duration",
            "Avg Parts/s",
            "Avg MB/s",
            "Safe",
            "Recommendation");

        foreach (var group in groupedByChunk)
        {
            var results = group.ToList();
            var safeCount = results.Count(r => r.VmaSafe);
            var recommendation = safeCount == results.Count ? "✓ Safe" 
                : safeCount == 0 ? "✗ Avoid" 
                : "⚠ Conditional";

            table.AddRow(
                FormatBytes(group.Key),
                results.Average(r => r.PeakVmaCount).ToString("N0"),
                results.Max(r => r.PeakVmaCount).ToString("N0"),
                $"{results.Average(r => r.DurationMs):N0}ms",
                $"{results.Average(r => r.PartsPerSecond):F1}",
                $"{results.Average(r => r.MemoryThroughputMBps):F1}",
                $"{safeCount}/{results.Count}",
                recommendation
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Prints memory usage analysis showing actual vs expected memory.
    /// </summary>
    public void PrintMemoryAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("MEMORY USAGE ANALYSIS");
        Console.WriteLine(new string('═', 140));
        Console.WriteLine("\nFormula: Expected Memory = MaxInMemoryParts × PartSize");
        Console.WriteLine("         (Chunk size affects VMA count but NOT total memory usage)\n");

        var table = new ConsoleTable(
            "Name",
            "Part Size",
            "MaxInMem",
            "Expected",
            "Peak Alloc",
            "WS Delta",
            "Alloc Eff",
            "WS Eff",
            "Validation");

        foreach (var result in _results.OrderBy(r => r.Config.PartSizeBytes).ThenBy(r => r.Config.MaxInMemoryParts))
        {
            var config = result.Config;
            
            // Validation: allocated efficiency ratio should be close to 1.0
            var validation = result.AllocatedEfficiencyRatio switch
            {
                <= 0 => "⚠ No data",
                < 0.8 => "⚠ Under",
                > 1.2 => "⚠ Over",
                _ => "✓ OK"
            };

            table.AddRow(
                TruncateName(config.Name, 25),
                FormatBytes(config.PartSizeBytes),
                config.MaxInMemoryParts,
                FormatBytes(result.ExpectedMemoryUsageBytes),
                FormatBytes(result.PeakAllocatedBytes),
                FormatBytes(result.WorkingSetDeltaBytes),
                $"{result.AllocatedEfficiencyRatio:F2}x",
                $"{result.WorkingSetEfficiencyRatio:F2}x",
                validation
            );
        }

        table.Write(Format.MarkDown);

        // Summary statistics
        var validResults = _results.Where(r => r.AllocatedEfficiencyRatio > 0).ToList();
        if (validResults.Any())
        {
            Console.WriteLine("\n--- Memory Formula Validation Summary ---\n");
            Console.WriteLine("  Allocated Efficiency (PeakAllocated / Expected):");
            Console.WriteLine($"    Average: {validResults.Average(r => r.AllocatedEfficiencyRatio):F2}x");
            Console.WriteLine($"    Min:     {validResults.Min(r => r.AllocatedEfficiencyRatio):F2}x");
            Console.WriteLine($"    Max:     {validResults.Max(r => r.AllocatedEfficiencyRatio):F2}x");
            
            var closeToExpected = validResults.Count(r => r.AllocatedEfficiencyRatio >= 0.8 && r.AllocatedEfficiencyRatio <= 1.2);
            Console.WriteLine($"\n  Tests within expected range (0.8x - 1.2x): {closeToExpected}/{validResults.Count} ({100.0 * closeToExpected / validResults.Count:F0}%)");
            
            if (validResults.Average(r => r.AllocatedEfficiencyRatio) is >= 0.9 and <= 1.1)
            {
                Console.WriteLine("\n  ✓ Formula Validated: Memory ≈ MaxInMemoryParts × PartSize");
            }
            else
            {
                Console.WriteLine("\n  ⚠ Results deviate from expected formula.");
            }
        }
    }

    /// <summary>
    /// Exports results to CSV for further analysis.
    /// </summary>
    public void ExportToCsv(string filePath)
    {
        using var writer = new StreamWriter(filePath);
        
        // Header with timing and memory columns
        writer.WriteLine("Name,PartSizeBytes,ChunkSizeBytes,TotalParts,MaxInMemoryParts,ConcurrentServiceRequests," +
                        "ChunksPerPart,MaxConcurrentChunks,EstimatedPeakVma,PeakVmaCount,PeakActiveChunks,PeakBufferParts," +
                        "DurationMs,RampUpTimeMs,SteadyStateTimeMs,PartsPerSecond,AllocationsPerSecond,MemoryThroughputMBps," +
                        "TotalAllocations,TotalDeallocations,IsSafe,SafetyMarginPercent," +
                        "ExpectedMemoryBytes,PeakAllocatedBytes,BaselineWorkingSetBytes,PeakWorkingSetBytes,WorkingSetDeltaBytes," +
                        "BaselineGcMemoryBytes,PeakGcMemoryBytes,GcMemoryDeltaBytes,AllocatedEfficiencyRatio,WorkingSetEfficiencyRatio,WasAborted");

        foreach (var result in _results)
        {
            var config = result.Config;
            writer.WriteLine($"{EscapeCsv(config.Name)},{config.PartSizeBytes},{config.ChunkSizeBytes}," +
                           $"{config.TotalParts},{config.MaxInMemoryParts},{config.ConcurrentServiceRequests}," +
                           $"{config.ChunksPerPart},{config.MaxConcurrentChunks},{config.EstimatedPeakVmaCount}," +
                           $"{result.PeakVmaCount},{result.PeakActiveChunks},{result.PeakBufferParts}," +
                           $"{result.DurationMs},{result.RampUpTimeMs},{result.SteadyStateTimeMs}," +
                           $"{result.PartsPerSecond:F2},{result.AllocationsPerSecond:F2},{result.MemoryThroughputMBps:F2}," +
                           $"{result.TotalAllocations},{result.TotalDeallocations},{result.VmaSafe},{result.SafetyMarginPercent:F2}," +
                           $"{result.ExpectedMemoryUsageBytes},{result.PeakAllocatedBytes},{result.BaselineWorkingSetBytes}," +
                           $"{result.PeakWorkingSetBytes},{result.WorkingSetDeltaBytes}," +
                           $"{result.BaselineGcMemoryBytes},{result.PeakGcMemoryBytes},{result.GcMemoryDeltaBytes}," +
                           $"{result.AllocatedEfficiencyRatio:F4},{result.WorkingSetEfficiencyRatio:F4},{result.WasAborted}");
        }

        Console.WriteLine($"\n✓ Results exported to: {filePath}");
    }

    /// <summary>
    /// Generates recommendations based on analysis.
    /// </summary>
    public void PrintRecommendations()
    {
        Console.WriteLine("\n" + new string('═', 100));
        Console.WriteLine("RECOMMENDATIONS");
        Console.WriteLine(new string('═', 100));

        var safeConfigs = _results.Where(r => r.VmaSafe).ToList();
        var unsafeConfigs = _results.Where(r => !r.VmaSafe).ToList();

        Console.WriteLine($"\nTotal Tests: {_results.Count}");
        Console.WriteLine($"  Safe:   {safeConfigs.Count} ({100.0 * safeConfigs.Count / _results.Count:F1}%)");
        Console.WriteLine($"  Unsafe: {unsafeConfigs.Count} ({100.0 * unsafeConfigs.Count / _results.Count:F1}%)");

        // Find optimal configurations
        if (safeConfigs.Any())
        {
            var fastest = safeConfigs.MinBy(r => r.DurationMs);
            var bestThroughput = safeConfigs.MaxBy(r => r.MemoryThroughputMBps);
            
            Console.WriteLine("\n--- Best Safe Configurations ---\n");
            Console.WriteLine($"  Fastest (safe):         {fastest?.Config.Name}");
            Console.WriteLine($"    Chunk Size: {FormatBytes(fastest?.Config.ChunkSizeBytes ?? 0)}, Duration: {fastest?.DurationMs:N0}ms");
            
            Console.WriteLine($"\n  Best Throughput (safe): {bestThroughput?.Config.Name}");
            Console.WriteLine($"    Chunk Size: {FormatBytes(bestThroughput?.Config.ChunkSizeBytes ?? 0)}, Throughput: {bestThroughput?.MemoryThroughputMBps:F1} MB/s");
        }

        // Find recommended chunk sizes per scenario
        Console.WriteLine("\n--- Recommended Chunk Sizes by Scenario ---\n");

        var scenarios = _results
            .GroupBy(r => (r.Config.PartSizeBytes, r.Config.MaxInMemoryParts, r.Config.ConcurrentServiceRequests))
            .OrderBy(g => g.Key.PartSizeBytes);

        foreach (var scenario in scenarios)
        {
            var (partSize, maxInMem, concurrent) = scenario.Key;
            var configs = scenario.ToList();
            
            var safeConfigs2 = configs.Where(c => c.VmaSafe).OrderBy(c => c.Config.ChunkSizeBytes).ToList();
            var fastestSafe = safeConfigs2.MinBy(r => r.DurationMs);

            if (safeConfigs2.Any())
            {
                var minSafeChunk = safeConfigs2.First().Config.ChunkSizeBytes;
                Console.WriteLine($"  Part: {FormatBytes(partSize)}, MaxInMem: {maxInMem}, Concurrent: {concurrent}");
                Console.WriteLine($"    Min Safe Chunk: {FormatBytes(minSafeChunk)}, Fastest Safe: {FormatBytes(fastestSafe?.Config.ChunkSizeBytes ?? 0)}");
            }
        }
    }

    public void PrintFormulaAnalysis()
    {
        var safetyFactors = new[] { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0 };
        
        Console.WriteLine("\n--- Formula Safety Factor Analysis ---\n");

        foreach (var factor in safetyFactors)
        {
            var correct = 0;
            foreach (var result in _results)
            {
                var config = result.Config;
                var recommendedChunk = TestMatrix.CalculateRecommendedChunkSize(
                    config.PartSizeBytes, config.MaxInMemoryParts, config.ConcurrentServiceRequests, safetyFactor: factor);

                if (result.VmaSafe && config.ChunkSizeBytes >= recommendedChunk)
                    correct++;
                else if (!result.VmaSafe && config.ChunkSizeBytes < recommendedChunk)
                    correct++;
            }

            var accuracy = 100.0 * correct / _results.Count;
            Console.WriteLine($"  Safety Factor {factor:F1}: Accuracy {accuracy:F1}%");
        }
    }

    /// <summary>
    /// Prints analysis comparing different concurrency levels.
    /// </summary>
    public void PrintConcurrencyAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("CONCURRENCY IMPACT ANALYSIS");
        Console.WriteLine(new string('═', 140));

        var groupedByConcurrency = _results
            .GroupBy(r => r.Config.ConcurrentServiceRequests)
            .OrderBy(g => g.Key);

        var table = new ConsoleTable(
            "Concurrent",
            "Avg Peak VMA",
            "Max Peak VMA",
            "Avg Duration",
            "Avg Parts/s",
            "Safe",
            "Recommendation");

        foreach (var group in groupedByConcurrency)
        {
            var results = group.ToList();
            var safeCount = results.Count(r => r.VmaSafe);
            var recommendation = safeCount == results.Count ? "✓ Safe" 
                : safeCount == 0 ? "✗ Avoid" 
                : "⚠ Conditional";

            table.AddRow(
                group.Key,
                results.Average(r => r.PeakVmaCount).ToString("N0"),
                results.Max(r => r.PeakVmaCount).ToString("N0"),
                $"{results.Average(r => r.DurationMs):N0}ms",
                $"{results.Average(r => r.PartsPerSecond):F1}",
                $"{safeCount}/{results.Count}",
                recommendation
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Prints analysis comparing different MaxInMemoryParts settings.
    /// </summary>
    public void PrintMaxInMemoryAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("MAX IN-MEMORY PARTS IMPACT ANALYSIS");
        Console.WriteLine(new string('═', 140));

        var groupedByMaxInMem = _results
            .GroupBy(r => r.Config.MaxInMemoryParts)
            .OrderBy(g => g.Key);

        var table = new ConsoleTable(
            "MaxInMem",
            "Avg Peak VMA",
            "Max Peak VMA",
            "Avg Memory",
            "Avg Duration",
            "Safe",
            "Recommendation");

        foreach (var group in groupedByMaxInMem)
        {
            var results = group.ToList();
            var safeCount = results.Count(r => r.VmaSafe);
            var recommendation = safeCount == results.Count ? "✓ Safe" 
                : safeCount == 0 ? "✗ Avoid" 
                : "⚠ Conditional";

            table.AddRow(
                group.Key,
                results.Average(r => r.PeakVmaCount).ToString("N0"),
                results.Max(r => r.PeakVmaCount).ToString("N0"),
                FormatBytes((long)results.Average(r => r.PeakAllocatedBytes)),
                $"{results.Average(r => r.DurationMs):N0}ms",
                $"{safeCount}/{results.Count}",
                recommendation
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Prints comparison between dynamic and fixed chunk size approaches.
    /// </summary>
    public void PrintDynamicVsFixedComparison()
    {
        Console.WriteLine("\n" + new string('═', 140));
        Console.WriteLine("DYNAMIC VS FIXED CHUNK SIZE COMPARISON");
        Console.WriteLine(new string('═', 140));

        // Group by scenario (part size + max in memory)
        var scenarios = _results
            .GroupBy(r => (r.Config.PartSizeBytes, r.Config.MaxInMemoryParts))
            .OrderBy(g => g.Key.PartSizeBytes)
            .ThenBy(g => g.Key.MaxInMemoryParts);

        var table = new ConsoleTable(
            "Part Size",
            "MaxInMem",
            "Fixed 64KB",
            "Fixed 256KB",
            "Fixed 1MB",
            "Dynamic");

        foreach (var scenario in scenarios)
        {
            var (partSize, maxInMem) = scenario.Key;
            var configs = scenario.ToList();

            // Find results for specific chunk sizes
            var chunk64k = configs.FirstOrDefault(c => c.Config.ChunkSizeBytes == 64 * 1024);
            var chunk256k = configs.FirstOrDefault(c => c.Config.ChunkSizeBytes == 256 * 1024);
            var chunk1m = configs.FirstOrDefault(c => c.Config.ChunkSizeBytes == 1024 * 1024);

            // Calculate dynamic recommendation
            var dynamicChunk = TestMatrix.CalculateRecommendedChunkSize(
                partSize, maxInMem, configs.First().Config.ConcurrentServiceRequests, safetyFactor: 2.0);
            var dynamicResult = configs.FirstOrDefault(c => c.Config.ChunkSizeBytes >= dynamicChunk);

            string StatusStr(SimulationMetrics? r) => r == null ? "-" 
                : r.VmaSafe ? $"✓ {r.PeakVmaCount:N0}" 
                : $"✗ {r.PeakVmaCount:N0}";

            table.AddRow(
                FormatBytes(partSize),
                maxInMem,
                StatusStr(chunk64k),
                StatusStr(chunk256k),
                StatusStr(chunk1m),
                dynamicResult != null ? $"✓ {FormatBytes(dynamicChunk)}" : $"? {FormatBytes(dynamicChunk)}"
            );
        }

        table.Write(Format.MarkDown);

        Console.WriteLine("\n✓ = VMA safe, ✗ = VMA exceeded threshold, - = not tested");
    }

    private static string EscapeCsv(string value)
    {
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
            return $"\"{value.Replace("\"", "\"\"")}\"";
        return value;
    }

    private static string FormatBytes(long bytes)
    {
        if (bytes >= 1024 * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0:F1}GB";
        if (bytes >= 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F1}MB";
        if (bytes >= 1024) return $"{bytes / 1024.0:F0}KB";
        return $"{bytes}B";
    }

    private static string TruncateName(string name, int maxLength)
    {
        if (name.Length <= maxLength) return name;
        return name.Substring(0, maxLength - 3) + "...";
    }
}
