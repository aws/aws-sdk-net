namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Generates test matrices with all parameter combinations for systematic analysis.
/// </summary>
public class TestMatrix
{
    /// <summary>
    /// Default chunk sizes to test (in bytes).
    /// Extended to support up to 1GB chunks for testing VMA reduction with very large allocations.
    /// </summary>
    public static readonly int[] DefaultChunkSizes = 
    {
        64 * 1024,           // 64KB (default)
        128 * 1024,          // 128KB
        256 * 1024,          // 256KB
        512 * 1024,          // 512KB
        1 * 1024 * 1024,     // 1MB
        2 * 1024 * 1024,     // 2MB
        4 * 1024 * 1024,     // 4MB
        8 * 1024 * 1024,     // 8MB
        16 * 1024 * 1024,    // 16MB
        32 * 1024 * 1024,    // 32MB
        64 * 1024 * 1024,    // 64MB
        128 * 1024 * 1024,   // 128MB
        256 * 1024 * 1024,   // 256MB
        512 * 1024 * 1024,   // 512MB
        1024 * 1024 * 1024   // 1GB
    };

    /// <summary>
    /// Default part sizes to test (in bytes).
    /// Extended to support up to 5GB parts for S3's maximum part size.
    /// </summary>
    public static readonly long[] DefaultPartSizes =
    {
        5 * 1024 * 1024L,         // 5MB (minimum multipart size)
        10 * 1024 * 1024L,        // 10MB
        20 * 1024 * 1024L,        // 20MB
        50 * 1024 * 1024L,        // 50MB
        100 * 1024 * 1024L,       // 100MB
        500 * 1024 * 1024L,       // 500MB
        1024 * 1024 * 1024L,      // 1GB
        2 * 1024L * 1024 * 1024,  // 2GB
        5 * 1024L * 1024 * 1024   // 5GB (S3 maximum part size)
    };

    /// <summary>
    /// Default MaxInMemoryParts values to test.
    /// </summary>
    public static readonly int[] DefaultMaxInMemoryParts = { 10, 25, 50, 100, 500, 1024 };

    /// <summary>
    /// Default ConcurrentServiceRequests values to test.
    /// </summary>
    public static readonly int[] DefaultConcurrentServiceRequests = { 1, 5, 10, 20, 50 };

    /// <summary>
    /// Default total parts counts to test.
    /// </summary>
    public static readonly int[] DefaultTotalParts = { 50, 100, 500, 1000, 2000 };

    /// <summary>
    /// Generates a full test matrix from all default parameters.
    /// Warning: This can generate thousands of configurations!
    /// </summary>
    public static List<SimulationConfig> GenerateFullMatrix()
    {
        var configs = new List<SimulationConfig>();

        foreach (var partSize in DefaultPartSizes)
        foreach (var chunkSize in DefaultChunkSizes)
        foreach (var maxInMemory in DefaultMaxInMemoryParts)
        foreach (var concurrent in DefaultConcurrentServiceRequests)
        foreach (var totalParts in DefaultTotalParts)
        {
            // Skip invalid combinations (chunk size > part size)
            if (chunkSize > partSize) continue;

            configs.Add(new SimulationConfig
            {
                Name = $"PS{partSize/1024/1024}MB_CS{chunkSize/1024}KB_MIM{maxInMemory}_CR{concurrent}_TP{totalParts}",
                PartSizeBytes = partSize,
                ChunkSizeBytes = chunkSize,
                MaxInMemoryParts = maxInMemory,
                ConcurrentServiceRequests = concurrent,
                TotalParts = totalParts
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates a reduced test matrix for quick analysis.
    /// Tests chunk size impact with fixed other parameters.
    /// </summary>
    public static List<SimulationConfig> GenerateChunkSizeSweep(
        long partSizeBytes = 10 * 1024 * 1024,
        int maxInMemoryParts = 100,
        int concurrentServiceRequests = 10,
        int totalParts = 500)
    {
        var configs = new List<SimulationConfig>();

        foreach (var chunkSize in DefaultChunkSizes)
        {
            if (chunkSize > partSizeBytes) continue;

            configs.Add(new SimulationConfig
            {
                Name = $"ChunkSweep_{chunkSize/1024}KB",
                PartSizeBytes = partSizeBytes,
                ChunkSizeBytes = chunkSize,
                MaxInMemoryParts = maxInMemoryParts,
                ConcurrentServiceRequests = concurrentServiceRequests,
                TotalParts = totalParts
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates configs varying ConcurrentServiceRequests.
    /// </summary>
    public static List<SimulationConfig> GenerateConcurrencySweep(
        long partSizeBytes = 10 * 1024 * 1024,
        int chunkSizeBytes = 64 * 1024,
        int maxInMemoryParts = 100,
        int totalParts = 500)
    {
        var configs = new List<SimulationConfig>();

        foreach (var concurrent in DefaultConcurrentServiceRequests)
        {
            configs.Add(new SimulationConfig
            {
                Name = $"ConcurrencySweep_CR{concurrent}",
                PartSizeBytes = partSizeBytes,
                ChunkSizeBytes = chunkSizeBytes,
                MaxInMemoryParts = maxInMemoryParts,
                ConcurrentServiceRequests = concurrent,
                TotalParts = totalParts
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates configs varying MaxInMemoryParts.
    /// </summary>
    public static List<SimulationConfig> GenerateMaxInMemorySweep(
        long partSizeBytes = 10 * 1024 * 1024,
        int chunkSizeBytes = 64 * 1024,
        int concurrentServiceRequests = 10,
        int totalParts = 500)
    {
        var configs = new List<SimulationConfig>();

        foreach (var maxInMemory in DefaultMaxInMemoryParts)
        {
            configs.Add(new SimulationConfig
            {
                Name = $"MaxInMemSweep_MIM{maxInMemory}",
                PartSizeBytes = partSizeBytes,
                ChunkSizeBytes = chunkSizeBytes,
                MaxInMemoryParts = maxInMemory,
                ConcurrentServiceRequests = concurrentServiceRequests,
                TotalParts = totalParts
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates configs varying part size.
    /// </summary>
    public static List<SimulationConfig> GeneratePartSizeSweep(
        int chunkSizeBytes = 64 * 1024,
        int maxInMemoryParts = 100,
        int concurrentServiceRequests = 10,
        int totalParts = 500)
    {
        var configs = new List<SimulationConfig>();

        foreach (var partSize in DefaultPartSizes)
        {
            if (chunkSizeBytes > partSize) continue;

            configs.Add(new SimulationConfig
            {
                Name = $"PartSizeSweep_{partSize/1024/1024}MB",
                PartSizeBytes = partSize,
                ChunkSizeBytes = chunkSizeBytes,
                MaxInMemoryParts = maxInMemoryParts,
                ConcurrentServiceRequests = concurrentServiceRequests,
                TotalParts = totalParts
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates a focused matrix for finding optimal chunk sizes per scenario.
    /// </summary>
    public static List<SimulationConfig> GenerateOptimalChunkAnalysis()
    {
        var configs = new List<SimulationConfig>();

        // For each part size, test multiple chunk sizes with different concurrency levels
        var partSizes = new long[] { 5 * 1024 * 1024, 10 * 1024 * 1024, 50 * 1024 * 1024, 100 * 1024 * 1024 };
        var maxInMemoryValues = new[] { 50, 100, 500 };
        var concurrencyValues = new[] { 5, 10, 20 };

        foreach (var partSize in partSizes)
        foreach (var maxInMem in maxInMemoryValues)
        foreach (var concurrent in concurrencyValues)
        foreach (var chunkSize in DefaultChunkSizes)
        {
            if (chunkSize > partSize) continue;

            configs.Add(new SimulationConfig
            {
                Name = $"Opt_PS{partSize/1024/1024}MB_MIM{maxInMem}_CR{concurrent}_CS{chunkSize/1024}KB",
                PartSizeBytes = partSize,
                ChunkSizeBytes = chunkSize,
                MaxInMemoryParts = maxInMem,
                ConcurrentServiceRequests = concurrent,
                TotalParts = 200 // Fixed for comparison
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates configs that test the VMA limit boundary.
    /// </summary>
    public static List<SimulationConfig> GenerateVmaLimitTests()
    {
        var configs = new List<SimulationConfig>();

        // Tests designed to approach/exceed 65K VMA limit
        var scenarios = new[]
        {
            // Small chunks + high buffer = many VMAs
            (64 * 1024, 10 * 1024 * 1024, 500, 10, "Small_Chunk_High_Buffer"),
            (64 * 1024, 10 * 1024 * 1024, 1024, 10, "Small_Chunk_Max_Buffer"),
            
            // High concurrency scenarios
            (64 * 1024, 10 * 1024 * 1024, 100, 50, "Small_Chunk_High_Concurrency"),
            (64 * 1024, 5 * 1024 * 1024, 200, 50, "Very_High_Concurrency"),
            
            // Larger chunks should stay safe
            (512 * 1024, 10 * 1024 * 1024, 500, 20, "Medium_Chunk_High_Buffer"),
            (1024 * 1024, 10 * 1024 * 1024, 500, 20, "Large_Chunk_High_Buffer"),
            (2048 * 1024, 10 * 1024 * 1024, 500, 20, "XL_Chunk_High_Buffer"),
        };

        foreach (var (chunkSize, partSize, maxInMem, concurrent, name) in scenarios)
        {
            configs.Add(new SimulationConfig
            {
                Name = $"VmaLimit_{name}",
                PartSizeBytes = partSize,
                ChunkSizeBytes = chunkSize,
                MaxInMemoryParts = maxInMem,
                ConcurrentServiceRequests = concurrent,
                TotalParts = 1000
            });
        }

        return configs;
    }

    /// <summary>
    /// Generates directory download simulation configs.
    /// </summary>
    public static List<List<SimulationConfig>> GenerateDirectoryDownloadScenarios()
    {
        var scenarios = new List<List<SimulationConfig>>();

        // Scenario 1: 10 medium files
        var mediumFiles = Enumerable.Range(1, 10)
            .Select(i => new SimulationConfig
            {
                Name = $"DirDownload_MediumFile_{i}",
                PartSizeBytes = 10 * 1024 * 1024,
                ChunkSizeBytes = 64 * 1024,
                MaxInMemoryParts = 50,
                ConcurrentServiceRequests = 5,
                TotalParts = 50
            }).ToList();
        scenarios.Add(mediumFiles);

        // Scenario 2: 20 small files
        var smallFiles = Enumerable.Range(1, 20)
            .Select(i => new SimulationConfig
            {
                Name = $"DirDownload_SmallFile_{i}",
                PartSizeBytes = 5 * 1024 * 1024,
                ChunkSizeBytes = 64 * 1024,
                MaxInMemoryParts = 25,
                ConcurrentServiceRequests = 3,
                TotalParts = 20
            }).ToList();
        scenarios.Add(smallFiles);

        // Scenario 3: 5 large files
        var largeFiles = Enumerable.Range(1, 5)
            .Select(i => new SimulationConfig
            {
                Name = $"DirDownload_LargeFile_{i}",
                PartSizeBytes = 50 * 1024 * 1024,
                ChunkSizeBytes = 256 * 1024,
                MaxInMemoryParts = 100,
                ConcurrentServiceRequests = 10,
                TotalParts = 100
            }).ToList();
        scenarios.Add(largeFiles);

        return scenarios;
    }

    /// <summary>
    /// Generates a quick test matrix for development/testing.
    /// </summary>
    public static List<SimulationConfig> GenerateQuickTest()
    {
        return new List<SimulationConfig>
        {
            new()
            {
                Name = "QuickTest_Baseline",
                PartSizeBytes = 10 * 1024 * 1024,
                ChunkSizeBytes = 64 * 1024,
                MaxInMemoryParts = 50,
                ConcurrentServiceRequests = 5,
                TotalParts = 50
            },
            new()
            {
                Name = "QuickTest_LargerChunk",
                PartSizeBytes = 10 * 1024 * 1024,
                ChunkSizeBytes = 512 * 1024,
                MaxInMemoryParts = 50,
                ConcurrentServiceRequests = 5,
                TotalParts = 50
            }
        };
    }

    /// <summary>
    /// Gets the estimated VMA count for a configuration.
    /// </summary>
    public static int EstimateVmaCount(SimulationConfig config)
    {
        var chunksPerPart = (int)Math.Ceiling((double)config.PartSizeBytes / config.ChunkSizeBytes);
        
        // Worst case: MaxInMemoryParts all buffered at once, each with full chunks
        // Plus some overhead for concurrent requests in-flight
        return chunksPerPart * config.MaxInMemoryParts;
    }

    /// <summary>
    /// Calculates the recommended chunk size based on parameters.
    /// </summary>
    public static int CalculateRecommendedChunkSize(
        long partSizeBytes,
        int maxInMemoryParts,
        int concurrentServiceRequests,
        int targetMaxVmas = 50000,
        double safetyFactor = 2.5,
        int minChunkSize = 64 * 1024,
        int maxChunkSize = 16 * 1024 * 1024)
    {
        // Calculate target chunks per part to stay under VMA limit
        var targetChunksPerPart = (int)(targetMaxVmas / 
            (maxInMemoryParts * concurrentServiceRequests * safetyFactor));
        
        // Ensure at least 10 chunks per part for granularity
        targetChunksPerPart = Math.Max(targetChunksPerPart, 10);
        
        // Calculate chunk size
        var calculatedChunkSize = (int)(partSizeBytes / targetChunksPerPart);
        
        // Clamp to boundaries
        return Math.Clamp(calculatedChunkSize, minChunkSize, maxChunkSize);
    }

    /// <summary>
    /// Generates configs comparing calculated vs fixed chunk sizes.
    /// </summary>
    public static List<SimulationConfig> GenerateDynamicVsFixedComparison()
    {
        var configs = new List<SimulationConfig>();

        var scenarios = new[]
        {
            (partSize: 10 * 1024 * 1024L, maxInMem: 100, concurrent: 10),
            (partSize: 10 * 1024 * 1024L, maxInMem: 100, concurrent: 20),
            (partSize: 50 * 1024 * 1024L, maxInMem: 50, concurrent: 10),
            (partSize: 50 * 1024 * 1024L, maxInMem: 100, concurrent: 20),
        };

        foreach (var (partSize, maxInMem, concurrent) in scenarios)
        {
            // Fixed 64KB (current default)
            configs.Add(new SimulationConfig
            {
                Name = $"Fixed64KB_PS{partSize/1024/1024}MB_MIM{maxInMem}_CR{concurrent}",
                PartSizeBytes = partSize,
                ChunkSizeBytes = 64 * 1024,
                MaxInMemoryParts = maxInMem,
                ConcurrentServiceRequests = concurrent,
                TotalParts = 500
            });

            // Dynamically calculated
            var dynamicChunkSize = CalculateRecommendedChunkSize(partSize, maxInMem, concurrent);
            configs.Add(new SimulationConfig
            {
                Name = $"Dynamic{dynamicChunkSize/1024}KB_PS{partSize/1024/1024}MB_MIM{maxInMem}_CR{concurrent}",
                PartSizeBytes = partSize,
                ChunkSizeBytes = dynamicChunkSize,
                MaxInMemoryParts = maxInMem,
                ConcurrentServiceRequests = concurrent,
                TotalParts = 500
            });
        }

        return configs;
    }
}
