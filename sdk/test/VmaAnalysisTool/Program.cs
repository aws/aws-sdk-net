using System.CommandLine;
using Amazon.S3.VmaAnalysis;

// Root command
var rootCommand = new RootCommand("VMA Analysis Tool - Analyze ArrayPool VMA impact for multipart downloads");

// Global options
var verboseOption = new Option<bool>("--verbose", "Enable verbose output");
var exportCsvOption = new Option<string?>("--export-csv", "Export results to CSV file");

rootCommand.AddGlobalOption(verboseOption);
rootCommand.AddGlobalOption(exportCsvOption);

// Quick test command
var quickCommand = new Command("quick", "Run a quick test to verify the tool works");
quickCommand.SetHandler(async (bool verbose, string? csvPath) =>
{
    await RunTestsAsync(TestMatrix.GenerateQuickTest(), verbose, csvPath, "Quick Test");
}, verboseOption, exportCsvOption);

// Chunk size sweep command
var chunkSweepCommand = new Command("chunk-sweep", "Test impact of different chunk sizes");
var partSizeOption = new Option<int>("--part-size", () => 10, "Part size in MB");
var maxInMemOption = new Option<int>("--max-in-memory", () => 100, "MaxInMemoryParts");
var concurrentOption = new Option<int>("--concurrent", () => 10, "ConcurrentServiceRequests");
var totalPartsOption = new Option<int>("--total-parts", () => 500, "Total parts");

chunkSweepCommand.AddOption(partSizeOption);
chunkSweepCommand.AddOption(maxInMemOption);
chunkSweepCommand.AddOption(concurrentOption);
chunkSweepCommand.AddOption(totalPartsOption);

chunkSweepCommand.SetHandler(async (bool verbose, string? csvPath, int partSize, int maxInMem, int concurrent, int totalParts) =>
{
    var configs = TestMatrix.GenerateChunkSizeSweep(
        partSize * 1024 * 1024,
        maxInMem,
        concurrent,
        totalParts);
    await RunTestsAsync(configs, verbose, csvPath, "Chunk Size Sweep");
}, verboseOption, exportCsvOption, partSizeOption, maxInMemOption, concurrentOption, totalPartsOption);

// Concurrency sweep command
var concurrencySweepCommand = new Command("concurrency-sweep", "Test impact of different concurrency levels");
concurrencySweepCommand.AddOption(partSizeOption);
concurrencySweepCommand.AddOption(maxInMemOption);
concurrencySweepCommand.AddOption(totalPartsOption);

var chunkSizeOption = new Option<int>("--chunk-size", () => 64, "Chunk size in KB");
concurrencySweepCommand.AddOption(chunkSizeOption);

concurrencySweepCommand.SetHandler(async (bool verbose, string? csvPath, int partSize, int maxInMem, int totalParts, int chunkSize) =>
{
    var configs = TestMatrix.GenerateConcurrencySweep(
        partSize * 1024 * 1024,
        chunkSize * 1024,
        maxInMem,
        totalParts);
    await RunTestsAsync(configs, verbose, csvPath, "Concurrency Sweep");
}, verboseOption, exportCsvOption, partSizeOption, maxInMemOption, totalPartsOption, chunkSizeOption);

// Max in-memory sweep command
var maxInMemSweepCommand = new Command("maxinmem-sweep", "Test impact of different MaxInMemoryParts values");
maxInMemSweepCommand.AddOption(partSizeOption);
maxInMemSweepCommand.AddOption(concurrentOption);
maxInMemSweepCommand.AddOption(totalPartsOption);
maxInMemSweepCommand.AddOption(chunkSizeOption);

maxInMemSweepCommand.SetHandler(async (bool verbose, string? csvPath, int partSize, int concurrent, int totalParts, int chunkSize) =>
{
    var configs = TestMatrix.GenerateMaxInMemorySweep(
        partSize * 1024 * 1024,
        chunkSize * 1024,
        concurrent,
        totalParts);
    await RunTestsAsync(configs, verbose, csvPath, "MaxInMemoryParts Sweep");
}, verboseOption, exportCsvOption, partSizeOption, concurrentOption, totalPartsOption, chunkSizeOption);

// VMA limit tests command
var vmaLimitCommand = new Command("vma-limit", "Test configurations near VMA limits");
vmaLimitCommand.SetHandler(async (bool verbose, string? csvPath) =>
{
    await RunTestsAsync(TestMatrix.GenerateVmaLimitTests(), verbose, csvPath, "VMA Limit Tests");
}, verboseOption, exportCsvOption);

// Dynamic vs Fixed comparison command
var compareCommand = new Command("compare", "Compare dynamic vs fixed chunk sizing");
compareCommand.SetHandler(async (bool verbose, string? csvPath) =>
{
    await RunTestsAsync(TestMatrix.GenerateDynamicVsFixedComparison(), verbose, csvPath, "Dynamic vs Fixed Comparison", showDynamicComparison: true);
}, verboseOption, exportCsvOption);

// Optimal analysis command
var optimalCommand = new Command("optimal", "Find optimal chunk sizes for various scenarios");
optimalCommand.SetHandler(async (bool verbose, string? csvPath) =>
{
    await RunTestsAsync(TestMatrix.GenerateOptimalChunkAnalysis(), verbose, csvPath, "Optimal Chunk Analysis", showRecommendations: true);
}, verboseOption, exportCsvOption);

// Full matrix command (warning: can take a long time)
var fullMatrixCommand = new Command("full-matrix", "Run complete test matrix (warning: slow!)");
var confirmOption = new Option<bool>("--confirm", "Confirm running full matrix");
fullMatrixCommand.AddOption(confirmOption);

fullMatrixCommand.SetHandler(async (bool verbose, string? csvPath, bool confirm) =>
{
    var configs = TestMatrix.GenerateFullMatrix();
    Console.WriteLine($"Full matrix contains {configs.Count} configurations.");
    
    if (!confirm)
    {
        Console.WriteLine("This will take a long time. Use --confirm to proceed.");
        return;
    }
    
    await RunTestsAsync(configs, verbose, csvPath, "Full Test Matrix", showRecommendations: true);
}, verboseOption, exportCsvOption, confirmOption);

// Single test command
var singleCommand = new Command("single", "Run a single test with specific parameters");
singleCommand.AddOption(partSizeOption);
singleCommand.AddOption(chunkSizeOption);
singleCommand.AddOption(maxInMemOption);
singleCommand.AddOption(concurrentOption);
singleCommand.AddOption(totalPartsOption);

singleCommand.SetHandler(async (bool verbose, string? csvPath, int partSize, int chunkSize, int maxInMem, int concurrent, int totalParts) =>
{
    var config = new SimulationConfig
    {
        Name = $"Single_PS{partSize}MB_CS{chunkSize}KB_MIM{maxInMem}_CR{concurrent}_TP{totalParts}",
        PartSizeBytes = partSize * 1024 * 1024L,
        ChunkSizeBytes = chunkSize * 1024,
        MaxInMemoryParts = maxInMem,
        ConcurrentServiceRequests = concurrent,
        TotalParts = totalParts
    };
    await RunTestsAsync(new List<SimulationConfig> { config }, verbose, csvPath, "Single Test", showDetailed: true);
}, verboseOption, exportCsvOption, partSizeOption, chunkSizeOption, maxInMemOption, concurrentOption, totalPartsOption);

// Calculate chunk size command
var calculateCommand = new Command("calculate", "Calculate recommended chunk size for given parameters");
calculateCommand.AddOption(partSizeOption);
calculateCommand.AddOption(maxInMemOption);
calculateCommand.AddOption(concurrentOption);

var targetVmaOption = new Option<int>("--target-vma", () => 50000, "Target maximum VMAs");
var safetyFactorOption = new Option<double>("--safety-factor", () => 2.5, "Safety factor");
calculateCommand.AddOption(targetVmaOption);
calculateCommand.AddOption(safetyFactorOption);

calculateCommand.SetHandler((int partSize, int maxInMem, int concurrent, int targetVma, double safetyFactor) =>
{
    Console.WriteLine("\n=== CHUNK SIZE CALCULATION ===\n");
    Console.WriteLine("Input Parameters:");
    Console.WriteLine($"  Part Size:                  {partSize} MB");
    Console.WriteLine($"  MaxInMemoryParts:           {maxInMem}");
    Console.WriteLine($"  ConcurrentServiceRequests:  {concurrent}");
    Console.WriteLine($"  Target Max VMAs:            {targetVma:N0}");
    Console.WriteLine($"  Safety Factor:              {safetyFactor}");
    
    var partSizeBytes = partSize * 1024L * 1024L;
    var recommendedChunk = TestMatrix.CalculateRecommendedChunkSize(
        partSizeBytes, maxInMem, concurrent, targetVma, safetyFactor);
    
    var chunksPerPart = (int)Math.Ceiling((double)partSizeBytes / recommendedChunk);
    var maxConcurrentChunks = chunksPerPart * maxInMem;
    var estimatedVma = maxConcurrentChunks;
    
    Console.WriteLine("\nCalculated Values:");
    Console.WriteLine($"  Recommended Chunk Size:     {FormatBytes(recommendedChunk)}");
    Console.WriteLine($"  Chunks per Part:            {chunksPerPart}");
    Console.WriteLine($"  Max Concurrent Chunks:      {maxConcurrentChunks:N0}");
    Console.WriteLine($"  Estimated Peak VMAs:        {estimatedVma:N0}");
    Console.WriteLine($"  Safety Margin:              {((double)(targetVma - estimatedVma) / targetVma * 100):F1}%");
    
    Console.WriteLine("\nFormula:");
    Console.WriteLine($"  TargetChunksPerPart = {targetVma} / ({maxInMem} × {concurrent} × {safetyFactor}) = {targetVma / (maxInMem * concurrent * safetyFactor):F0}");
    Console.WriteLine($"  ChunkSize = {partSize}MB / TargetChunksPerPart = {FormatBytes(recommendedChunk)}");
    
}, partSizeOption, maxInMemOption, concurrentOption, targetVmaOption, safetyFactorOption);

// Info command
var infoCommand = new Command("info", "Show system VMA information");
infoCommand.SetHandler(() =>
{
    Console.WriteLine("\n=== SYSTEM VMA INFORMATION ===\n");
    
    using var vmaMonitor = new VmaMonitor();
    var snapshot = vmaMonitor.TakeSnapshot();
    
    Console.WriteLine($"Platform:                 {(vmaMonitor.IsRealVmaTrackingAvailable ? "Linux (real VMA tracking)" : "Non-Linux (estimation mode)")}");
    Console.WriteLine($"Current VMA Count:        {snapshot.CurrentVmaCount:N0}");
    Console.WriteLine($"Linux Default VMA Limit:  {VmaMonitor.DefaultLinuxVmaLimit:N0}");
    Console.WriteLine($"Actual VMA Limit:         {VmaMonitor.GetLinuxVmaLimit():N0}");
    Console.WriteLine($"Safe Threshold:           {VmaMonitor.SafeVmaThreshold:N0}");
    Console.WriteLine($"Current Usage:            {snapshot.VmaUsagePercent:F1}%");
    Console.WriteLine($"Safety Margin:            {snapshot.SafetyMargin:N0}");
    
    if (vmaMonitor.IsRealVmaTrackingAvailable)
    {
        Console.WriteLine("\nVMA Breakdown:");
        foreach (var (type, count) in snapshot.Breakdown)
        {
            Console.WriteLine($"  {type,-10}: {count:N0}");
        }
    }
    else
    {
        Console.WriteLine("\nNote: Run on Linux for accurate VMA tracking.");
        Console.WriteLine("On non-Linux systems, VMA counts are estimated based on ArrayPool allocations.");
    }
});

// Add all commands
rootCommand.AddCommand(quickCommand);
rootCommand.AddCommand(chunkSweepCommand);
rootCommand.AddCommand(concurrencySweepCommand);
rootCommand.AddCommand(maxInMemSweepCommand);
rootCommand.AddCommand(vmaLimitCommand);
rootCommand.AddCommand(compareCommand);
rootCommand.AddCommand(optimalCommand);
rootCommand.AddCommand(fullMatrixCommand);
rootCommand.AddCommand(singleCommand);
rootCommand.AddCommand(calculateCommand);
rootCommand.AddCommand(infoCommand);

// Run the command
return await rootCommand.InvokeAsync(args);

// Helper methods
static async Task RunTestsAsync(
    List<SimulationConfig> configs, 
    bool verbose, 
    string? csvPath, 
    string testName,
    bool showDetailed = false,
    bool showRecommendations = false,
    bool showDynamicComparison = false)
{
    Console.WriteLine($"\n{'═',80}");
    Console.WriteLine($"  {testName}");
    Console.WriteLine($"{'═',80}");
    Console.WriteLine($"\nRunning {configs.Count} test configuration(s)...\n");

    using var vmaMonitor = new VmaMonitor();
    using var simulator = new DownloadSimulator(vmaMonitor);
    var analyzer = new ResultsAnalyzer();

    var progress = 0;
    foreach (var config in configs)
    {
        progress++;
        Console.Write($"\r[{progress}/{configs.Count}] Testing: {TruncateName(config.Name, 50)}...");
        
        try
        {
            var result = await simulator.SimulateDownloadAsync(config);
            analyzer.AddResult(result);
            
            if (verbose)
            {
                Console.WriteLine($" Peak VMA: {result.PeakVmaCount:N0} {result.Status}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($" ERROR: {ex.Message}");
        }
    }

    Console.WriteLine("\n\nTests complete. Generating report...");

    // Print results
    if (showDetailed && configs.Count == 1)
    {
        var result = analyzer.GetType()
            .GetField("_results", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?
            .GetValue(analyzer) as List<SimulationMetrics>;
        if (result?.Any() == true)
        {
            analyzer.PrintDetailedResult(result.First());
        }
    }
    
    analyzer.PrintSummaryTable();
    
    if (configs.Count > 3)
    {
        analyzer.PrintChunkSizeAnalysis();
        analyzer.PrintConcurrencyAnalysis();
        analyzer.PrintMaxInMemoryAnalysis();
    }
    
    if (showRecommendations)
    {
        analyzer.PrintRecommendations();
    }
    
    if (showDynamicComparison)
    {
        analyzer.PrintDynamicVsFixedComparison();
    }

    // Export to CSV if requested
    if (!string.IsNullOrEmpty(csvPath))
    {
        analyzer.ExportToCsv(csvPath);
    }
}

static string FormatBytes(long bytes)
{
    if (bytes >= 1024 * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0:F1}GB";
    if (bytes >= 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F1}MB";
    if (bytes >= 1024) return $"{bytes / 1024.0:F0}KB";
    return $"{bytes}B";
}

static string TruncateName(string name, int maxLength)
{
    if (name.Length <= maxLength) return name.PadRight(maxLength);
    return name.Substring(0, maxLength - 3) + "...";
}
