namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Represents progress during a download test execution.
/// </summary>
public class DownloadProgress
{
    /// <summary>
    /// Number of parts completed so far.
    /// </summary>
    public int CompletedParts { get; set; }
    
    /// <summary>
    /// Total number of parts to process.
    /// </summary>
    public int TotalParts { get; set; }
    
    /// <summary>
    /// Current phase of the download: "Ramp-up" or "Steady-state".
    /// </summary>
    public string Phase { get; set; } = "Initializing";
    
    /// <summary>
    /// Current VMA count.
    /// </summary>
    public int CurrentVmaCount { get; set; }
    
    /// <summary>
    /// Current number of parts in the buffer.
    /// </summary>
    public int BufferedParts { get; set; }
    
    /// <summary>
    /// Percentage complete (0-100).
    /// </summary>
    public double PercentComplete => TotalParts > 0 ? (double)CompletedParts / TotalParts * 100 : 0;
    
    /// <summary>
    /// Bytes processed so far.
    /// </summary>
    public long BytesProcessed { get; set; }
    
    /// <summary>
    /// Total bytes to process.
    /// </summary>
    public long TotalBytes { get; set; }
}

/// <summary>
/// Helper class to display progress bars in the console.
/// </summary>
public static class ProgressDisplay
{
    private static readonly object _lock = new();
    private static int _lastLineLength = 0;
    
    /// <summary>
    /// Renders a progress bar to the console, overwriting the current line.
    /// </summary>
    public static void RenderProgress(
        int testNumber, 
        int totalTests, 
        string testName, 
        DownloadProgress progress,
        bool showVma = true)
    {
        lock (_lock)
        {
            const int barWidth = 20;
            var filled = (int)(progress.PercentComplete / 100 * barWidth);
            var empty = barWidth - filled;
            
            var bar = new string('█', filled) + new string('░', empty);
            var pct = progress.PercentComplete.ToString("F0").PadLeft(3);
            
            var truncatedName = TruncateName(testName, 30);
            
            string line;
            if (showVma && progress.CurrentVmaCount > 0)
            {
                line = $"\r[{testNumber}/{totalTests}] {truncatedName} [{bar}] {pct}% ({progress.CompletedParts}/{progress.TotalParts}) VMA:{progress.CurrentVmaCount,7:N0}";
            }
            else
            {
                line = $"\r[{testNumber}/{totalTests}] {truncatedName} [{bar}] {pct}% ({progress.CompletedParts}/{progress.TotalParts})";
            }
            
            // Pad with spaces to clear any leftover characters from previous longer line
            if (line.Length < _lastLineLength)
            {
                line = line.PadRight(_lastLineLength);
            }
            _lastLineLength = line.Length;
            
            Console.Write(line);
        }
    }
    
    /// <summary>
    /// Clears the progress line and moves to a new line.
    /// </summary>
    public static void CompleteLine()
    {
        lock (_lock)
        {
            Console.WriteLine();
            _lastLineLength = 0;
        }
    }
    
    /// <summary>
    /// Resets the last line length tracker.
    /// </summary>
    public static void Reset()
    {
        lock (_lock)
        {
            _lastLineLength = 0;
        }
    }
    
    private static string TruncateName(string name, int maxLength)
    {
        if (name.Length <= maxLength) return name.PadRight(maxLength);
        return name.Substring(0, maxLength - 3) + "...";
    }
}
