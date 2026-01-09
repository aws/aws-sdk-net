using ConsoleTables;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Analyzes simulation results and generates reports with recommendations.
/// </summary>
public class ResultsAnalyzer
{
    private readonly List<SimulationMetrics> _results = new();

    /// <summary>
    /// Adds simulation results for analysis.
    /// </summary>
    public void AddResult(SimulationMetrics result)
    {
        _results.Add(result);
    }

    /// <summary>
    /// Adds multiple simulation results.
    /// </summary>
    public void AddResults(IEnumerable<SimulationMetrics> results)
    {
        _results.AddRange(results);
    }

    /// <summary>
    /// Clears all results.
    /// </summary>
    public void Clear()
    {
        _results.Clear();
    }

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

        Console.WriteLine("\n" + new string('═', 120));
        Console.WriteLine("TEST RESULTS SUMMARY");
        Console.WriteLine(new string('═', 120));

        var table = new ConsoleTable(
            "Name", 
            "Part Size", 
            "Chunk Size", 
            "MaxInMem", 
            "Concurrent",
            "Est. VMA",
            "Peak VMA",
            "Peak Chunks",
            "Status");

        foreach (var result in _results.OrderBy(r => r.Config.ChunkSizeBytes))
        {
            var config = result.Config;
            table.AddRow(
                TruncateName(config.Name, 25),
                FormatBytes(config.PartSizeBytes),
                FormatBytes(config.ChunkSizeBytes),
                config.MaxInMemoryParts,
                config.ConcurrentServiceRequests,
                config.EstimatedPeakVmaCount.ToString("N0"),
                result.PeakVmaCount.ToString("N0"),
                result.PeakActiveChunks.ToString("N0"),
                result.Status
            );
        }

        table.Write(Format.MarkDown);
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
        Console.WriteLine($"  Safety Margin:              {result.SafetyMarginPercent:F1}%");
        Console.WriteLine($"  Status:                     {result.Status}");
        
        Console.WriteLine("\nMemory Metrics:");
        Console.WriteLine($"  Expected Memory:            {result.ExpectedMemoryFormatted} (MaxInMemoryParts × PartSize)");
        Console.WriteLine($"  Baseline Working Set:       {FormatBytes(result.BaselineWorkingSetBytes)}");
        Console.WriteLine($"  Peak Working Set:           {result.PeakWorkingSetFormatted}");
        Console.WriteLine($"  Working Set Delta:          {result.WorkingSetDeltaFormatted}");
        Console.WriteLine($"  Peak GC Memory:             {FormatBytes(result.PeakGcMemoryBytes)}");
        Console.WriteLine($"  Memory Efficiency Ratio:    {result.MemoryEfficiencyRatio:F2}x (actual/expected, ~1.0 is ideal)");
        
        Console.WriteLine("\nPerformance:");
        Console.WriteLine($"  Duration:                   {result.DurationMs:N0} ms");
        Console.WriteLine($"  Completed Parts:            {result.CompletedParts}");
        Console.WriteLine($"  Total Allocations:          {result.TotalAllocations:N0}");
        Console.WriteLine($"  Total Deallocations:        {result.TotalDeallocations:N0}");
    }

    /// <summary>
    /// Prints analysis comparing different chunk sizes.
    /// </summary>
    public void PrintChunkSizeAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 100));
        Console.WriteLine("CHUNK SIZE IMPACT ANALYSIS");
        Console.WriteLine(new string('═', 100));

        var groupedByChunk = _results
            .GroupBy(r => r.Config.ChunkSizeBytes)
            .OrderBy(g => g.Key);

        var table = new ConsoleTable(
            "Chunk Size",
            "Avg Peak VMA",
            "Max Peak VMA",
            "Avg Chunks/Part",
            "Safe Tests",
            "Unsafe Tests",
            "Recommendation");

        foreach (var group in groupedByChunk)
        {
            var results = group.ToList();
            var safeCount = results.Count(r => r.VmaSafe);
            var unsafeCount = results.Count - safeCount;
            var recommendation = safeCount == results.Count ? "✓ Safe" 
                : unsafeCount > safeCount ? "✗ Avoid" 
                : "⚠ Conditional";

            table.AddRow(
                FormatBytes(group.Key),
                results.Average(r => r.PeakVmaCount).ToString("N0"),
                results.Max(r => r.PeakVmaCount).ToString("N0"),
                results.Average(r => r.Config.ChunksPerPart).ToString("F1"),
                safeCount,
                unsafeCount,
                recommendation
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Prints analysis of concurrency impact.
    /// </summary>
    public void PrintConcurrencyAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 100));
        Console.WriteLine("CONCURRENCY IMPACT ANALYSIS");
        Console.WriteLine(new string('═', 100));

        var groupedByConcurrency = _results
            .GroupBy(r => r.Config.ConcurrentServiceRequests)
            .OrderBy(g => g.Key);

        var table = new ConsoleTable(
            "Concurrent Requests",
            "Avg Peak VMA",
            "Max Peak VMA",
            "Safe Tests",
            "Unsafe Tests",
            "Impact Factor");

        var baselineAvg = groupedByConcurrency.FirstOrDefault()?.Average(r => r.PeakVmaCount) ?? 1;

        foreach (var group in groupedByConcurrency)
        {
            var results = group.ToList();
            var avgVma = results.Average(r => r.PeakVmaCount);
            var safeCount = results.Count(r => r.VmaSafe);
            var unsafeCount = results.Count - safeCount;
            var impactFactor = avgVma / baselineAvg;

            table.AddRow(
                group.Key,
                avgVma.ToString("N0"),
                results.Max(r => r.PeakVmaCount).ToString("N0"),
                safeCount,
                unsafeCount,
                $"{impactFactor:F2}x"
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Prints analysis of MaxInMemoryParts impact.
    /// </summary>
    public void PrintMaxInMemoryAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 100));
        Console.WriteLine("MAX IN-MEMORY PARTS IMPACT ANALYSIS");
        Console.WriteLine(new string('═', 100));

        var groupedByMaxInMem = _results
            .GroupBy(r => r.Config.MaxInMemoryParts)
            .OrderBy(g => g.Key);

        var table = new ConsoleTable(
            "MaxInMemoryParts",
            "Avg Peak VMA",
            "Max Peak VMA",
            "Safe Tests",
            "Unsafe Tests",
            "Scaling Factor");

        var baselineAvg = groupedByMaxInMem.FirstOrDefault()?.Average(r => r.PeakVmaCount) ?? 1;

        foreach (var group in groupedByMaxInMem)
        {
            var results = group.ToList();
            var avgVma = results.Average(r => r.PeakVmaCount);
            var safeCount = results.Count(r => r.VmaSafe);
            var unsafeCount = results.Count - safeCount;
            var scalingFactor = avgVma / baselineAvg;

            table.AddRow(
                group.Key,
                avgVma.ToString("N0"),
                results.Max(r => r.PeakVmaCount).ToString("N0"),
                safeCount,
                unsafeCount,
                $"{scalingFactor:F2}x"
            );
        }

        table.Write(Format.MarkDown);
    }

    /// <summary>
    /// Generates recommendations based on analysis.
    /// </summary>
    public void PrintRecommendations()
    {
        Console.WriteLine("\n" + new string('═', 100));
        Console.WriteLine("RECOMMENDATIONS");
        Console.WriteLine(new string('═', 100));

        // Find safe configurations
        var safeConfigs = _results.Where(r => r.VmaSafe).ToList();
        var unsafeConfigs = _results.Where(r => !r.VmaSafe).ToList();

        Console.WriteLine($"\nTotal Tests: {_results.Count}");
        Console.WriteLine($"  Safe:   {safeConfigs.Count} ({100.0 * safeConfigs.Count / _results.Count:F1}%)");
        Console.WriteLine($"  Unsafe: {unsafeConfigs.Count} ({100.0 * unsafeConfigs.Count / _results.Count:F1}%)");

        // Find optimal chunk sizes per scenario
        Console.WriteLine("\n--- Recommended Chunk Sizes by Scenario ---\n");

        var scenarios = _results
            .GroupBy(r => (r.Config.PartSizeBytes, r.Config.MaxInMemoryParts, r.Config.ConcurrentServiceRequests))
            .OrderBy(g => g.Key.PartSizeBytes)
            .ThenBy(g => g.Key.ConcurrentServiceRequests);

        foreach (var scenario in scenarios)
        {
            var (partSize, maxInMem, concurrent) = scenario.Key;
            var configs = scenario.ToList();
            
            // Find minimum safe chunk size for this scenario
            var safeConfigs2 = configs
                .Where(c => c.VmaSafe)
                .OrderBy(c => c.Config.ChunkSizeBytes)
                .ToList();

            if (safeConfigs2.Any())
            {
                var minSafeChunk = safeConfigs2.First().Config.ChunkSizeBytes;
                var recommendedChunk = TestMatrix.CalculateRecommendedChunkSize(partSize, maxInMem, concurrent);
                
                Console.WriteLine($"  Part Size: {FormatBytes(partSize)}, MaxInMem: {maxInMem}, Concurrent: {concurrent}");
                Console.WriteLine($"    Min Safe Chunk:    {FormatBytes(minSafeChunk)}");
                Console.WriteLine($"    Formula Recommends: {FormatBytes(recommendedChunk)}");
                Console.WriteLine($"    Match: {(minSafeChunk <= recommendedChunk ? "✓" : "⚠ Formula too small")}");
                Console.WriteLine();
            }
        }

        // Print formula parameters
        Console.WriteLine("\n--- Suggested Formula Parameters ---\n");
        PrintFormulaAnalysis();
    }

    /// <summary>
    /// Analyzes results to determine optimal formula parameters.
    /// </summary>
    public void PrintFormulaAnalysis()
    {
        // Find the safety factor that works for all scenarios
        var safetyFactors = new[] { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0 };
        
        Console.WriteLine("Testing different safety factors:\n");

        foreach (var factor in safetyFactors)
        {
            var correct = 0;
            var incorrect = 0;

            foreach (var result in _results)
            {
                var config = result.Config;
                var recommendedChunk = TestMatrix.CalculateRecommendedChunkSize(
                    config.PartSizeBytes, 
                    config.MaxInMemoryParts, 
                    config.ConcurrentServiceRequests,
                    safetyFactor: factor);

                // If formula suggests this chunk size or larger, would it be safe?
                var wouldBeSafe = config.ChunkSizeBytes >= recommendedChunk && result.VmaSafe;
                var wouldBeUnsafe = config.ChunkSizeBytes >= recommendedChunk && !result.VmaSafe;
                
                if (result.VmaSafe && config.ChunkSizeBytes >= recommendedChunk)
                    correct++;
                else if (!result.VmaSafe && config.ChunkSizeBytes < recommendedChunk)
                    correct++;
                else
                    incorrect++;
            }

            var accuracy = 100.0 * correct / _results.Count;
            Console.WriteLine($"  Safety Factor {factor:F1}: Accuracy {accuracy:F1}% ({correct}/{_results.Count})");
        }

        Console.WriteLine("\n  Note: Higher safety factors are more conservative but may use larger chunks than necessary.");
        Console.WriteLine("  Recommendation: Use SafetyFactor = 2.5 for good balance of safety and efficiency.");
    }

    /// <summary>
    /// Exports results to CSV for further analysis.
    /// </summary>
    public void ExportToCsv(string filePath)
    {
        using var writer = new StreamWriter(filePath);
        
        // Header with memory columns
        writer.WriteLine("Name,PartSizeBytes,ChunkSizeBytes,TotalParts,MaxInMemoryParts,ConcurrentServiceRequests," +
                        "ChunksPerPart,MaxConcurrentChunks,EstimatedPeakVma,PeakVmaCount,PeakActiveChunks," +
                        "DurationMs,TotalAllocations,IsSafe,SafetyMarginPercent," +
                        "ExpectedMemoryBytes,BaselineWorkingSetBytes,PeakWorkingSetBytes,WorkingSetDeltaBytes," +
                        "PeakPrivateMemoryBytes,PeakGcMemoryBytes,MemoryEfficiencyRatio,WasAborted");

        foreach (var result in _results)
        {
            var config = result.Config;
            writer.WriteLine($"{EscapeCsv(config.Name)},{config.PartSizeBytes},{config.ChunkSizeBytes}," +
                           $"{config.TotalParts},{config.MaxInMemoryParts},{config.ConcurrentServiceRequests}," +
                           $"{config.ChunksPerPart},{config.MaxConcurrentChunks},{config.EstimatedPeakVmaCount}," +
                           $"{result.PeakVmaCount},{result.PeakActiveChunks},{result.DurationMs}," +
                           $"{result.TotalAllocations},{result.VmaSafe},{result.SafetyMarginPercent:F2}," +
                           $"{result.ExpectedMemoryUsageBytes},{result.BaselineWorkingSetBytes},{result.PeakWorkingSetBytes},{result.WorkingSetDeltaBytes}," +
                           $"{result.PeakPrivateMemoryBytes},{result.PeakGcMemoryBytes},{result.MemoryEfficiencyRatio:F4},{result.WasAborted}");
        }

        Console.WriteLine($"\nResults exported to: {filePath}");
    }

    /// <summary>
    /// Prints memory usage analysis showing actual vs expected memory.
    /// </summary>
    public void PrintMemoryAnalysis()
    {
        Console.WriteLine("\n" + new string('═', 120));
        Console.WriteLine("MEMORY USAGE ANALYSIS");
        Console.WriteLine(new string('═', 120));
        Console.WriteLine("\nFormula: Expected Memory = MaxInMemoryParts × PartSize");
        Console.WriteLine("         (Chunk size affects VMA count but NOT total memory usage)\n");

        var table = new ConsoleTable(
            "Name",
            "Part Size",
            "MaxInMem",
            "Expected Mem",
            "Actual Delta",
            "Efficiency",
            "Validation");

        foreach (var result in _results.OrderBy(r => r.Config.PartSizeBytes).ThenBy(r => r.Config.MaxInMemoryParts))
        {
            var config = result.Config;
            var efficiencyPct = result.MemoryEfficiencyRatio * 100;
            
            // Validation: ratio should be close to 1.0 (between 0.5 and 2.0 is reasonable)
            var validation = result.MemoryEfficiencyRatio switch
            {
                <= 0 => "⚠ No data",
                < 0.5 => "⚠ Under",
                > 2.0 => "⚠ Over",
                _ => "✓ OK"
            };

            table.AddRow(
                TruncateName(config.Name, 30),
                FormatBytes(config.PartSizeBytes),
                config.MaxInMemoryParts,
                FormatBytes(result.ExpectedMemoryUsageBytes),
                FormatBytes(result.WorkingSetDeltaBytes),
                $"{efficiencyPct:F0}%",
                validation
            );
        }

        table.Write(Format.MarkDown);

        // Summary statistics
        var validResults = _results.Where(r => r.MemoryEfficiencyRatio > 0).ToList();
        if (validResults.Any())
        {
            Console.WriteLine("\n--- Memory Formula Validation Summary ---\n");
            Console.WriteLine($"  Average Efficiency Ratio: {validResults.Average(r => r.MemoryEfficiencyRatio):F2}x");
            Console.WriteLine($"  Min Efficiency Ratio:     {validResults.Min(r => r.MemoryEfficiencyRatio):F2}x");
            Console.WriteLine($"  Max Efficiency Ratio:     {validResults.Max(r => r.MemoryEfficiencyRatio):F2}x");
            
            var closeToExpected = validResults.Count(r => r.MemoryEfficiencyRatio >= 0.5 && r.MemoryEfficiencyRatio <= 2.0);
            Console.WriteLine($"\n  Tests within expected range (0.5x - 2.0x): {closeToExpected}/{validResults.Count} ({100.0 * closeToExpected / validResults.Count:F0}%)");
            
            if (validResults.Average(r => r.MemoryEfficiencyRatio) is >= 0.7 and <= 1.5)
            {
                Console.WriteLine("\n  ✓ Formula Validated: Memory ≈ MaxInMemoryParts × PartSize");
            }
            else
            {
                Console.WriteLine("\n  ⚠ Results deviate significantly from expected formula.");
            }
        }
    }

    /// <summary>
    /// Escapes a string for CSV output.
    /// </summary>
    private static string EscapeCsv(string value)
    {
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }
        return value;
    }

    /// <summary>
    /// Prints a comparison of dynamic vs fixed chunk sizing.
    /// </summary>
    public void PrintDynamicVsFixedComparison()
    {
        Console.WriteLine("\n" + new string('═', 100));
        Console.WriteLine("DYNAMIC VS FIXED CHUNK SIZE COMPARISON");
        Console.WriteLine(new string('═', 100));

        var fixedResults = _results.Where(r => r.Config.Name.StartsWith("Fixed")).ToList();
        var dynamicResults = _results.Where(r => r.Config.Name.StartsWith("Dynamic")).ToList();

        if (!fixedResults.Any() || !dynamicResults.Any())
        {
            Console.WriteLine("\nNo comparison data available. Run GenerateDynamicVsFixedComparison tests first.");
            return;
        }

        var table = new ConsoleTable(
            "Scenario",
            "Approach",
            "Chunk Size",
            "Peak VMA",
            "Status",
            "VMA Reduction");

        // Match fixed with dynamic by scenario
        foreach (var fixedResult in fixedResults)
        {
            // Extract scenario identifier from name
            var scenarioId = fixedResult.Config.Name.Replace("Fixed64KB_", "");
            var matchingDynamic = dynamicResults.FirstOrDefault(d => d.Config.Name.Contains(scenarioId));

            table.AddRow(
                scenarioId,
                "Fixed 64KB",
                FormatBytes(fixedResult.Config.ChunkSizeBytes),
                fixedResult.PeakVmaCount.ToString("N0"),
                fixedResult.Status,
                "-"
            );

            if (matchingDynamic != null)
            {
                var reduction = (1.0 - (double)matchingDynamic.PeakVmaCount / fixedResult.PeakVmaCount) * 100;
                table.AddRow(
                    "",
                    "Dynamic",
                    FormatBytes(matchingDynamic.Config.ChunkSizeBytes),
                    matchingDynamic.PeakVmaCount.ToString("N0"),
                    matchingDynamic.Status,
                    $"{reduction:F1}%"
                );
            }
        }

        table.Write(Format.MarkDown);
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
