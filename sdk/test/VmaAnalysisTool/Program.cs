using System.CommandLine;
using System.CommandLine.Invocation;
using System.Text.Json;
using Amazon.S3.VmaAnalysis;

// Root command
var rootCommand = new RootCommand("VMA Analysis Tool - Analyze ArrayPool VMA impact for multipart downloads");

// Global options
var verboseOption = new Option<bool>("--verbose", "Enable verbose output");
var exportCsvOption = new Option<string?>("--export-csv", "Export results to CSV file");
var maxMemoryGbOption = new Option<double?>("--max-memory-gb", "Maximum memory to use in GB (default: 80% of available RAM)");
var isolatedOption = new Option<bool>("--isolated", "Run each test in a separate process for accurate VMA measurements");
var vmaAbortThresholdOption = new Option<int>("--vma-abort-threshold", () => VmaMonitor.DefaultAbortVmaThreshold, 
    $"Abort test if VMA count exceeds this value (default: {VmaMonitor.DefaultAbortVmaThreshold:N0}). Set to 0 to disable.");

// Mode selection options
var modeOption = new Option<ExecutorMode>("--mode", () => ExecutorMode.Simulated, 
    "Execution mode: 'Simulated' for ArrayPool-based simulation, 'Real' for actual S3 downloads");
var s3BucketOption = new Option<string?>("--s3-bucket", "S3 bucket name for real downloads");
var s3KeyOption = new Option<string?>("--s3-key", "S3 object key for real downloads");
var s3RegionOption = new Option<string>("--s3-region", () => "us-east-1", "AWS region for S3 operations");
var awsProfileOption = new Option<string?>("--aws-profile", "AWS profile name for credentials (optional)");
var downloadDirOption = new Option<string?>("--download-dir", "Local directory for downloaded files (default: temp dir)");
var keepDownloadsOption = new Option<bool>("--keep-downloads", "Keep downloaded files after tests (default: delete them)");

// Test parameter options
var partSizeOption = new Option<int>("--part-size", () => 10, "Part size in MB");
var maxInMemOption = new Option<int>("--max-in-memory", () => 100, "MaxInMemoryParts");
var concurrentOption = new Option<int>("--concurrent", () => 10, "ConcurrentServiceRequests");
var totalPartsOption = new Option<int>("--total-parts", () => 500, "Total parts");
var chunkSizeOption = new Option<int>("--chunk-size", () => 64, "Chunk size in KB");

rootCommand.AddGlobalOption(verboseOption);
rootCommand.AddGlobalOption(exportCsvOption);
rootCommand.AddGlobalOption(maxMemoryGbOption);
rootCommand.AddGlobalOption(isolatedOption);
rootCommand.AddGlobalOption(vmaAbortThresholdOption);
rootCommand.AddGlobalOption(modeOption);
rootCommand.AddGlobalOption(s3BucketOption);
rootCommand.AddGlobalOption(s3KeyOption);
rootCommand.AddGlobalOption(s3RegionOption);
rootCommand.AddGlobalOption(awsProfileOption);
rootCommand.AddGlobalOption(downloadDirOption);
rootCommand.AddGlobalOption(keepDownloadsOption);

// Helper to extract common options from InvocationContext
static CommonOptions GetCommonOptions(InvocationContext ctx, 
    Option<bool> verboseOpt, Option<string?> csvOpt, Option<double?> maxMemOpt, Option<bool> isolatedOpt,
    Option<ExecutorMode> modeOpt, Option<string?> bucketOpt, Option<string?> keyOpt, 
    Option<string> regionOpt, Option<string?> profileOpt, Option<string?> downloadDirOpt, Option<bool> keepOpt)
{
    return new CommonOptions
    {
        Verbose = ctx.ParseResult.GetValueForOption(verboseOpt),
        CsvPath = ctx.ParseResult.GetValueForOption(csvOpt),
        MaxMemoryGb = ctx.ParseResult.GetValueForOption(maxMemOpt),
        Isolated = ctx.ParseResult.GetValueForOption(isolatedOpt),
        Mode = ctx.ParseResult.GetValueForOption(modeOpt),
        S3Bucket = ctx.ParseResult.GetValueForOption(bucketOpt),
        S3Key = ctx.ParseResult.GetValueForOption(keyOpt),
        S3Region = ctx.ParseResult.GetValueForOption(regionOpt) ?? "us-east-1",
        AwsProfile = ctx.ParseResult.GetValueForOption(profileOpt),
        DownloadDir = ctx.ParseResult.GetValueForOption(downloadDirOpt),
        KeepDownloads = ctx.ParseResult.GetValueForOption(keepOpt)
    };
}

// Internal command for running isolated tests (used by parent process)
var isolatedTestCommand = new Command("_run-isolated-test", "Internal command - runs a single test from base64-encoded config");
isolatedTestCommand.IsHidden = true;
var configArg = new Argument<string>("config", "Base64-encoded JSON config");
isolatedTestCommand.AddArgument(configArg);
isolatedTestCommand.SetHandler(async (string configBase64) =>
{
    try
    {
        var configJson = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(configBase64));
        var config = JsonSerializer.Deserialize<SimulationConfig>(configJson, IsolatedJsonContext.Default.SimulationConfig);
        
        if (config == null)
        {
            Console.Error.WriteLine("Failed to deserialize config");
            Environment.Exit(1);
            return;
        }
        
        using var vmaMonitor = new VmaMonitor();
        using var simulator = new DownloadSimulator(vmaMonitor);
        
        var result = await simulator.ExecuteDownloadAsync(config);
        
        // Output result as JSON (prefix with JSON_RESULT: for easy parsing)
        var resultJson = JsonSerializer.Serialize(result, IsolatedJsonContext.Default.SimulationMetrics);
        Console.WriteLine($"JSON_RESULT:{resultJson}");
        
        Environment.Exit(0);
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"Error: {ex.Message}");
        Console.Error.WriteLine(ex.StackTrace);
        Environment.Exit(1);
    }
}, configArg);

// Quick test command
var quickCommand = new Command("quick", "Run a quick test to verify the tool works");
quickCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    await RunTestsAsync(TestMatrix.GenerateQuickTest(), opts, "Quick Test");
});

// Chunk size sweep command
var chunkSweepCommand = new Command("chunk-sweep", "Test impact of different chunk sizes");
chunkSweepCommand.AddOption(partSizeOption);
chunkSweepCommand.AddOption(maxInMemOption);
chunkSweepCommand.AddOption(concurrentOption);
chunkSweepCommand.AddOption(totalPartsOption);
chunkSweepCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    var partSize = ctx.ParseResult.GetValueForOption(partSizeOption);
    var maxInMem = ctx.ParseResult.GetValueForOption(maxInMemOption);
    var concurrent = ctx.ParseResult.GetValueForOption(concurrentOption);
    var totalParts = ctx.ParseResult.GetValueForOption(totalPartsOption);
    
    var configs = TestMatrix.GenerateChunkSizeSweep(
        partSize * 1024 * 1024,
        maxInMem,
        concurrent,
        totalParts);
    await RunTestsAsync(configs, opts, "Chunk Size Sweep");
});

// Concurrency sweep command
var concurrencySweepCommand = new Command("concurrency-sweep", "Test impact of different concurrency levels");
concurrencySweepCommand.AddOption(partSizeOption);
concurrencySweepCommand.AddOption(maxInMemOption);
concurrencySweepCommand.AddOption(totalPartsOption);
concurrencySweepCommand.AddOption(chunkSizeOption);
concurrencySweepCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    var partSize = ctx.ParseResult.GetValueForOption(partSizeOption);
    var maxInMem = ctx.ParseResult.GetValueForOption(maxInMemOption);
    var totalParts = ctx.ParseResult.GetValueForOption(totalPartsOption);
    var chunkSize = ctx.ParseResult.GetValueForOption(chunkSizeOption);
    
    var configs = TestMatrix.GenerateConcurrencySweep(
        partSize * 1024 * 1024,
        chunkSize * 1024,
        maxInMem,
        totalParts);
    await RunTestsAsync(configs, opts, "Concurrency Sweep");
});

// Max in-memory sweep command
var maxInMemSweepCommand = new Command("maxinmem-sweep", "Test impact of different MaxInMemoryParts values");
maxInMemSweepCommand.AddOption(partSizeOption);
maxInMemSweepCommand.AddOption(concurrentOption);
maxInMemSweepCommand.AddOption(totalPartsOption);
maxInMemSweepCommand.AddOption(chunkSizeOption);
maxInMemSweepCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    var partSize = ctx.ParseResult.GetValueForOption(partSizeOption);
    var concurrent = ctx.ParseResult.GetValueForOption(concurrentOption);
    var totalParts = ctx.ParseResult.GetValueForOption(totalPartsOption);
    var chunkSize = ctx.ParseResult.GetValueForOption(chunkSizeOption);
    
    var configs = TestMatrix.GenerateMaxInMemorySweep(
        partSize * 1024 * 1024,
        chunkSize * 1024,
        concurrent,
        totalParts);
    await RunTestsAsync(configs, opts, "MaxInMemoryParts Sweep");
});

// VMA limit tests command
var vmaLimitCommand = new Command("vma-limit", "Test configurations near VMA limits");
vmaLimitCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    await RunTestsAsync(TestMatrix.GenerateVmaLimitTests(), opts, "VMA Limit Tests");
});

// Dynamic vs Fixed comparison command
var compareCommand = new Command("compare", "Compare dynamic vs fixed chunk sizing");
compareCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    await RunTestsAsync(TestMatrix.GenerateDynamicVsFixedComparison(), opts, "Dynamic vs Fixed Comparison", showDynamicComparison: true);
});

// Optimal analysis command
var optimalCommand = new Command("optimal", "Find optimal chunk sizes for various scenarios");
optimalCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    await RunTestsAsync(TestMatrix.GenerateOptimalChunkAnalysis(), opts, "Optimal Chunk Analysis", showRecommendations: true);
});

// Full matrix command (warning: can take a long time)
var fullMatrixCommand = new Command("full-matrix", "Run complete test matrix (warning: slow!)");
var confirmOption = new Option<bool>("--confirm", "Confirm running full matrix");
fullMatrixCommand.AddOption(confirmOption);
fullMatrixCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    var confirm = ctx.ParseResult.GetValueForOption(confirmOption);
    
    var configs = TestMatrix.GenerateFullMatrix();
    Console.WriteLine($"Full matrix contains {configs.Count} configurations.");
    
    if (!confirm)
    {
        Console.WriteLine("This will take a long time. Use --confirm to proceed.");
        return;
    }
    
    await RunTestsAsync(configs, opts, "Full Test Matrix", showRecommendations: true);
});

// Single test command
var singleCommand = new Command("single", "Run a single test with specific parameters");
singleCommand.AddOption(partSizeOption);
singleCommand.AddOption(chunkSizeOption);
singleCommand.AddOption(maxInMemOption);
singleCommand.AddOption(concurrentOption);
singleCommand.AddOption(totalPartsOption);
singleCommand.SetHandler(async (InvocationContext ctx) =>
{
    var opts = GetCommonOptions(ctx, verboseOption, exportCsvOption, maxMemoryGbOption, isolatedOption,
        modeOption, s3BucketOption, s3KeyOption, s3RegionOption, awsProfileOption, downloadDirOption, keepDownloadsOption);
    var partSize = ctx.ParseResult.GetValueForOption(partSizeOption);
    var chunkSize = ctx.ParseResult.GetValueForOption(chunkSizeOption);
    var maxInMem = ctx.ParseResult.GetValueForOption(maxInMemOption);
    var concurrent = ctx.ParseResult.GetValueForOption(concurrentOption);
    var totalParts = ctx.ParseResult.GetValueForOption(totalPartsOption);
    
    var config = new SimulationConfig
    {
        Name = $"Single_PS{partSize}MB_CS{chunkSize}KB_MIM{maxInMem}_CR{concurrent}_TP{totalParts}",
        PartSizeBytes = partSize * 1024 * 1024L,
        ChunkSizeBytes = chunkSize * 1024,
        MaxInMemoryParts = maxInMem,
        ConcurrentServiceRequests = concurrent,
        TotalParts = totalParts
    };
    await RunTestsAsync(new List<SimulationConfig> { config }, opts, "Single Test", showDetailed: true);
});

// Calculate chunk size command
var calculateCommand = new Command("calculate", "Calculate recommended chunk size for given parameters");
calculateCommand.AddOption(partSizeOption);
calculateCommand.AddOption(maxInMemOption);
calculateCommand.AddOption(concurrentOption);
var targetVmaOption = new Option<int>("--target-vma", () => 50000, "Target maximum VMAs");
var safetyFactorOption = new Option<double>("--safety-factor", () => 2.5, "Safety factor");
calculateCommand.AddOption(targetVmaOption);
calculateCommand.AddOption(safetyFactorOption);
calculateCommand.SetHandler((InvocationContext ctx) =>
{
    var partSize = ctx.ParseResult.GetValueForOption(partSizeOption);
    var maxInMem = ctx.ParseResult.GetValueForOption(maxInMemOption);
    var concurrent = ctx.ParseResult.GetValueForOption(concurrentOption);
    var targetVma = ctx.ParseResult.GetValueForOption(targetVmaOption);
    var safetyFactor = ctx.ParseResult.GetValueForOption(safetyFactorOption);
    
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
});

// Info command
var infoCommand = new Command("info", "Show system VMA and memory information");
infoCommand.SetHandler(() =>
{
    Console.WriteLine("\n=== SYSTEM INFORMATION ===\n");
    
    // Memory info
    var totalMemory = SystemMemoryInfo.GetTotalPhysicalMemoryBytes();
    var availableMemory = SystemMemoryInfo.GetAvailableMemoryBytes();
    var defaultLimit = (long)(availableMemory * 0.8);
    
    Console.WriteLine("Memory:");
    Console.WriteLine($"  Total RAM:              {SystemMemoryInfo.GetTotalMemoryFormatted()}");
    Console.WriteLine($"  Available RAM:          {SystemMemoryInfo.GetAvailableMemoryFormatted()}");
    Console.WriteLine($"  Default test limit:     {defaultLimit / 1024.0 / 1024.0 / 1024.0:F1} GB (80% of available)");
    
    // VMA info
    Console.WriteLine("\nVMA (Virtual Memory Areas):");
    using var vmaMonitor = new VmaMonitor();
    var snapshot = vmaMonitor.TakeSnapshot();
    
    Console.WriteLine($"  Platform:               {(vmaMonitor.IsRealVmaTrackingAvailable ? "Linux (real VMA tracking)" : "Non-Linux (estimation mode)")}");
    Console.WriteLine($"  Current VMA Count:      {snapshot.CurrentVmaCount:N0}");
    Console.WriteLine($"  Linux Default Limit:    {VmaMonitor.DefaultLinuxVmaLimit:N0}");
    Console.WriteLine($"  Actual VMA Limit:       {VmaMonitor.GetLinuxVmaLimit():N0}");
    Console.WriteLine($"  Safe Threshold:         {VmaMonitor.SafeVmaThreshold:N0}");
    Console.WriteLine($"  Current Usage:          {snapshot.VmaUsagePercent:F1}%");
    Console.WriteLine($"  Safety Margin:          {snapshot.SafetyMargin:N0}");
    
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
    
    // Memory guidance
    Console.WriteLine("\nMemory vs VMA Trade-offs:");
    Console.WriteLine("  - Memory usage = MaxInMemoryParts × PartSize");
    Console.WriteLine("  - VMA count = MaxInMemoryParts × (PartSize / ChunkSize)");
    Console.WriteLine("  - Larger chunk sizes → fewer VMAs, same memory usage");
    Console.WriteLine("  - Use --max-memory-gb to override automatic memory limit");
});

// Setup S3 test data command
var setupS3Command = new Command("setup-s3", "Create S3 bucket and test objects for real download testing");
var setupBucketOption = new Option<string>("--bucket", "S3 bucket name to create/use") { IsRequired = true };
var setupRegionOpt = new Option<string>("--region", () => "us-east-1", "AWS region");
var setupProfileOpt = new Option<string?>("--profile", "AWS profile name");
var setupSizesOption = new Option<string>("--sizes", () => "100,500,1000", "Comma-separated list of object sizes in MB");
var setupPrefixOption = new Option<string>("--prefix", () => "vma-test/", "Key prefix for test objects");
var setupForceOption = new Option<bool>("--force", "Force recreate objects even if they exist");
setupS3Command.AddOption(setupBucketOption);
setupS3Command.AddOption(setupRegionOpt);
setupS3Command.AddOption(setupProfileOpt);
setupS3Command.AddOption(setupSizesOption);
setupS3Command.AddOption(setupPrefixOption);
setupS3Command.AddOption(setupForceOption);
setupS3Command.SetHandler(async (InvocationContext ctx) =>
{
    var bucket = ctx.ParseResult.GetValueForOption(setupBucketOption)!;
    var region = ctx.ParseResult.GetValueForOption(setupRegionOpt)!;
    var profile = ctx.ParseResult.GetValueForOption(setupProfileOpt);
    var sizesStr = ctx.ParseResult.GetValueForOption(setupSizesOption)!;
    var prefix = ctx.ParseResult.GetValueForOption(setupPrefixOption)!;
    var force = ctx.ParseResult.GetValueForOption(setupForceOption);
    
    // Parse sizes
    var sizes = sizesStr.Split(',')
        .Select(s => long.Parse(s.Trim()) * 1024 * 1024)
        .ToArray();
    
    using var setup = new S3TestDataSetup(region, profile);
    await setup.SetupTestDataAsync(bucket, sizes, prefix, force);
    
    Console.WriteLine("\n📋 Example usage:");
    foreach (var size in sizes)
    {
        var key = $"{prefix}{size / 1024 / 1024}mb.bin";
        Console.WriteLine($"  dotnet run -- quick --mode Real --s3-bucket {bucket} --s3-key {key} --s3-region {region}");
    }
});

// Cleanup S3 test data command
var cleanupS3Command = new Command("cleanup-s3", "Delete S3 test objects");
cleanupS3Command.AddOption(setupBucketOption);
cleanupS3Command.AddOption(setupRegionOpt);
cleanupS3Command.AddOption(setupProfileOpt);
cleanupS3Command.AddOption(setupPrefixOption);
cleanupS3Command.SetHandler(async (InvocationContext ctx) =>
{
    var bucket = ctx.ParseResult.GetValueForOption(setupBucketOption)!;
    var region = ctx.ParseResult.GetValueForOption(setupRegionOpt)!;
    var profile = ctx.ParseResult.GetValueForOption(setupProfileOpt);
    var prefix = ctx.ParseResult.GetValueForOption(setupPrefixOption)!;
    
    using var setup = new S3TestDataSetup(region, profile);
    await setup.CleanupTestDataAsync(bucket, prefix);
});

// List S3 test data command
var listS3Command = new Command("list-s3", "List existing S3 test objects");
listS3Command.AddOption(setupBucketOption);
listS3Command.AddOption(setupRegionOpt);
listS3Command.AddOption(setupProfileOpt);
listS3Command.AddOption(setupPrefixOption);
listS3Command.SetHandler(async (InvocationContext ctx) =>
{
    var bucket = ctx.ParseResult.GetValueForOption(setupBucketOption)!;
    var region = ctx.ParseResult.GetValueForOption(setupRegionOpt)!;
    var profile = ctx.ParseResult.GetValueForOption(setupProfileOpt);
    var prefix = ctx.ParseResult.GetValueForOption(setupPrefixOption)!;
    
    using var setup = new S3TestDataSetup(region, profile);
    var objects = await setup.ListTestObjectsAsync(bucket, prefix);
    
    Console.WriteLine($"\n=== S3 Test Objects in s3://{bucket}/{prefix} ===\n");
    
    if (objects.Count == 0)
    {
        Console.WriteLine("No test objects found.");
        Console.WriteLine($"\nUse 'setup-s3 --bucket {bucket}' to create test objects.");
        return;
    }
    
    Console.WriteLine($"Found {objects.Count} object(s):\n");
    foreach (var (key, size) in objects.OrderBy(o => o.Size))
    {
        var sizeStr = size >= 1024 * 1024 * 1024 
            ? $"{size / 1024.0 / 1024.0 / 1024.0:F1} GB"
            : size >= 1024 * 1024 
                ? $"{size / 1024.0 / 1024.0:F0} MB"
                : $"{size / 1024.0:F0} KB";
        Console.WriteLine($"  {key,-40} {sizeStr,10}");
    }
    
    Console.WriteLine("\n📋 Example usage:");
    var firstObj = objects.First();
    Console.WriteLine($"  dotnet run -- quick --mode Real --s3-bucket {bucket} --s3-key {firstObj.Key} --s3-region {region}");
});

// Add all commands
rootCommand.AddCommand(isolatedTestCommand);
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
rootCommand.AddCommand(setupS3Command);
rootCommand.AddCommand(cleanupS3Command);
rootCommand.AddCommand(listS3Command);

// Run the command
return await rootCommand.InvokeAsync(args);

// Helper methods
static async Task RunTestsAsync(
    List<SimulationConfig> configs, 
    CommonOptions opts,
    string testName,
    bool showDetailed = false,
    bool showRecommendations = false,
    bool showDynamicComparison = false)
{
    Console.WriteLine($"\n{'═',80}");
    Console.WriteLine($"  {testName}");
    Console.WriteLine($"{'═',80}");
    
    // Display execution mode
    Console.WriteLine($"\n📋 Mode: {opts.Mode}");
    Console.WriteLine($"   {DownloadExecutorFactory.GetModeDescription(opts.Mode)}");
    
    var s3Config = opts.CreateS3Config();
    if (opts.Mode == ExecutorMode.Real)
    {
        if (s3Config == null || string.IsNullOrWhiteSpace(s3Config.BucketName))
        {
            Console.WriteLine("\n❌ ERROR: Real mode requires --s3-bucket and --s3-key options.");
            Console.WriteLine("   Example: dotnet run -- quick --mode Real --s3-bucket my-bucket --s3-key test-file.bin");
            return;
        }
        Console.WriteLine($"\n   S3 Bucket: {s3Config.BucketName}");
        Console.WriteLine($"   S3 Key: {s3Config.ObjectKey}");
        Console.WriteLine($"   Region: {s3Config.Region}");
    }
    
    if (opts.Isolated)
    {
        Console.WriteLine("\n🔒 ISOLATED MODE: Each test runs in a separate process for accurate VMA measurements");
    }
    
    // Calculate memory limit
    var totalMemoryBytes = SystemMemoryInfo.GetTotalPhysicalMemoryBytes();
    var availableMemoryBytes = SystemMemoryInfo.GetAvailableMemoryBytes();
    long memoryLimitBytes;
    
    if (opts.MaxMemoryGb.HasValue)
    {
        memoryLimitBytes = (long)(opts.MaxMemoryGb.Value * 1024 * 1024 * 1024);
        Console.WriteLine($"\nMemory limit: {opts.MaxMemoryGb.Value:F1} GB (user-specified)");
    }
    else
    {
        // Default to 80% of available memory
        memoryLimitBytes = (long)(availableMemoryBytes * 0.8);
        Console.WriteLine($"\nMemory limit: {memoryLimitBytes / 1024.0 / 1024.0 / 1024.0:F1} GB (80% of {availableMemoryBytes / 1024.0 / 1024.0 / 1024.0:F1} GB available)");
    }
    Console.WriteLine($"Total system RAM: {totalMemoryBytes / 1024.0 / 1024.0 / 1024.0:F1} GB");
    
    // Filter configs by memory limit
    var originalCount = configs.Count;
    var skippedConfigs = new List<(SimulationConfig config, long estimatedMemory)>();
    var validConfigs = new List<SimulationConfig>();
    
    foreach (var config in configs)
    {
        if (config.EstimatedMemoryUsageBytes > memoryLimitBytes)
        {
            skippedConfigs.Add((config, config.EstimatedMemoryUsageBytes));
        }
        else
        {
            validConfigs.Add(config);
        }
    }
    
    if (skippedConfigs.Count > 0)
    {
        Console.WriteLine($"\n⚠ Skipping {skippedConfigs.Count} configuration(s) that would exceed memory limit:");
        foreach (var (config, estMem) in skippedConfigs.Take(5)) // Show first 5
        {
            Console.WriteLine($"   - {config.Name}: {estMem / 1024.0 / 1024.0 / 1024.0:F1} GB estimated");
        }
        if (skippedConfigs.Count > 5)
        {
            Console.WriteLine($"   ... and {skippedConfigs.Count - 5} more");
        }
    }
    
    if (validConfigs.Count == 0)
    {
        Console.WriteLine("\n✗ No configurations within memory limit. Try --max-memory-gb with a higher value.");
        return;
    }
    
    Console.WriteLine($"\nRunning {validConfigs.Count} test configuration(s)...\n");

    var analyzer = new ResultsAnalyzer();
    var failedTests = 0;

    if (opts.Isolated)
    {
        // Run each test in a separate process
        var runner = new IsolatedTestRunner(opts.Verbose, opts.MaxMemoryGb);
        var results = await runner.RunTestsAsync(
            validConfigs,
            (current, total, name) =>
            {
                Console.Write($"\r[{current}/{total}] Testing (isolated): {TruncateName(name, 40)}...");
            });
        
        foreach (var result in results)
        {
            if (result.Success && result.Metrics != null)
            {
                analyzer.AddResult(result.Metrics);
                if (opts.Verbose)
                {
                    Console.WriteLine($" Peak VMA: {result.Metrics.PeakVmaCount:N0} {result.Metrics.Status} ({result.ProcessDurationMs}ms)");
                }
            }
            else
            {
                failedTests++;
                Console.WriteLine($" ERROR: {result.Error}");
            }
        }
    }
    else
    {
        // Run all tests in the current process (faster but less accurate VMA measurements)
        using var vmaMonitor = new VmaMonitor();
        using var executor = DownloadExecutorFactory.Create(opts.Mode, vmaMonitor, s3Config);

        var progress = 0;
        foreach (var config in validConfigs)
        {
            progress++;
            var modeIndicator = opts.Mode == ExecutorMode.Real ? "(S3)" : "";
            Console.Write($"\r[{progress}/{validConfigs.Count}] Testing {modeIndicator}: {TruncateName(config.Name, 45)}...");
            
            try
            {
                // Validate config for this executor
                if (!executor.ValidateConfig(config, out var validationError))
                {
                    failedTests++;
                    Console.WriteLine($" VALIDATION ERROR: {validationError}");
                    continue;
                }
                
                var result = await executor.ExecuteDownloadAsync(config);
                analyzer.AddResult(result);
                
                if (opts.Verbose)
                {
                    Console.WriteLine($" Peak VMA: {result.PeakVmaCount:N0} {result.Status}");
                }
            }
            catch (Exception ex)
            {
                failedTests++;
                Console.WriteLine($" ERROR: {ex.Message}");
            }
        }
    }

    Console.WriteLine("\n\nTests complete. Generating report...");
    
    if (skippedConfigs.Count > 0)
    {
        Console.WriteLine($"Note: {skippedConfigs.Count} configuration(s) were skipped due to memory constraints.");
    }
    
    if (failedTests > 0)
    {
        Console.WriteLine($"Warning: {failedTests} test(s) failed.");
    }

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
    if (!string.IsNullOrEmpty(opts.CsvPath))
    {
        analyzer.ExportToCsv(opts.CsvPath);
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
