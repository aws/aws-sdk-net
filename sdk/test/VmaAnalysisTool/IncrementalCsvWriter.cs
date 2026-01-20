namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Writes simulation results to CSV incrementally, supporting resume from previous runs.
/// </summary>
public class IncrementalCsvWriter : IDisposable
{
    private readonly string _filePath;
    private readonly StreamWriter? _writer;
    private readonly HashSet<string> _completedTests;
    private bool _disposed;

    /// <summary>
    /// Gets the set of test names that have already been completed (from existing CSV).
    /// </summary>
    public IReadOnlySet<string> CompletedTests => _completedTests;

    /// <summary>
    /// Gets the number of tests that were already completed from a previous run.
    /// </summary>
    public int PreviouslyCompletedCount => _completedTests.Count;

    /// <summary>
    /// Creates a new incremental CSV writer.
    /// If the file exists, reads completed test names and appends new results.
    /// If the file doesn't exist, creates a new file with headers.
    /// </summary>
    /// <param name="filePath">Path to the CSV file</param>
    public IncrementalCsvWriter(string filePath)
    {
        _filePath = filePath;
        _completedTests = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // Check if file exists and read completed tests
        if (File.Exists(filePath))
        {
            ReadExistingResults();
            // Open for append
            _writer = new StreamWriter(filePath, append: true);
        }
        else
        {
            // Create new file
            _writer = new StreamWriter(filePath, append: false);
            WriteHeader();
        }
    }

    /// <summary>
    /// Reads existing CSV file to determine which tests have already been completed.
    /// </summary>
    private void ReadExistingResults()
    {
        try
        {
            using var reader = new StreamReader(_filePath);
            
            // Skip header
            var headerLine = reader.ReadLine();
            if (headerLine == null) return;

            // Find the Name column index
            var headers = ParseCsvLine(headerLine);
            var nameIndex = Array.FindIndex(headers, h => h.Equals("Name", StringComparison.OrdinalIgnoreCase));
            
            if (nameIndex < 0)
            {
                Console.WriteLine($"Warning: CSV file {_filePath} doesn't have a 'Name' column. Cannot resume.");
                return;
            }

            // Read all test names
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                
                var values = ParseCsvLine(line);
                if (values.Length > nameIndex)
                {
                    var testName = values[nameIndex];
                    if (!string.IsNullOrWhiteSpace(testName))
                    {
                        _completedTests.Add(testName);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Warning: Error reading existing CSV: {ex.Message}. Starting fresh.");
            _completedTests.Clear();
        }
    }

    /// <summary>
    /// Parses a CSV line, handling quoted values.
    /// </summary>
    private static string[] ParseCsvLine(string line)
    {
        var values = new List<string>();
        var currentValue = new System.Text.StringBuilder();
        var inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            var c = line[i];

            if (c == '"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    // Escaped quote
                    currentValue.Append('"');
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                values.Add(currentValue.ToString());
                currentValue.Clear();
            }
            else
            {
                currentValue.Append(c);
            }
        }

        values.Add(currentValue.ToString());
        return values.ToArray();
    }

    /// <summary>
    /// Writes the CSV header row.
    /// </summary>
    private void WriteHeader()
    {
        if (_writer == null) return;

        _writer.WriteLine("Name,PartSizeBytes,ChunkSizeBytes,TotalParts,MaxInMemoryParts,ConcurrentServiceRequests," +
                         "ChunksPerPart,MaxConcurrentChunks,EstimatedPeakVma,PeakVmaCount,PeakActiveChunks,PeakBufferParts," +
                         "DurationMs,RampUpTimeMs,SteadyStateTimeMs,PartsPerSecond,AllocationsPerSecond,MemoryThroughputMBps," +
                         "TotalAllocations,TotalDeallocations,IsSafe,SafetyMarginPercent," +
                         "ExpectedMemoryBytes,PeakAllocatedBytes,BaselineWorkingSetBytes,PeakWorkingSetBytes,WorkingSetDeltaBytes," +
                         "BaselineGcMemoryBytes,PeakGcMemoryBytes,GcMemoryDeltaBytes,AllocatedEfficiencyRatio,WorkingSetEfficiencyRatio,WasAborted");
        _writer.Flush();
    }

    /// <summary>
    /// Checks if a test has already been completed.
    /// </summary>
    /// <param name="testName">The name of the test</param>
    /// <returns>True if the test has already been completed</returns>
    public bool IsTestCompleted(string testName)
    {
        return _completedTests.Contains(testName);
    }

    /// <summary>
    /// Writes a single result to the CSV file immediately.
    /// </summary>
    /// <param name="result">The simulation result to write</param>
    public void WriteResult(SimulationMetrics result)
    {
        if (_writer == null) return;

        var config = result.Config;
        _writer.WriteLine($"{EscapeCsv(config.Name)},{config.PartSizeBytes},{config.ChunkSizeBytes}," +
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
        
        // Flush immediately to ensure data is written
        _writer.Flush();
        
        // Track as completed
        _completedTests.Add(config.Name);
    }

    /// <summary>
    /// Escapes a value for CSV format.
    /// </summary>
    private static string EscapeCsv(string value)
    {
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
            return $"\"{value.Replace("\"", "\"\"")}\"";
        return value;
    }

    public void Dispose()
    {
        if (_disposed) return;
        _writer?.Dispose();
        _disposed = true;
    }
}
