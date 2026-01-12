namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Factory for creating download executors based on execution mode.
/// </summary>
public static class DownloadExecutorFactory
{
    /// <summary>
    /// Creates a download executor for the specified mode.
    /// </summary>
    /// <param name="mode">The execution mode (Simulated or Real).</param>
    /// <param name="vmaMonitor">The VMA monitor instance.</param>
    /// <param name="s3Config">S3 configuration (required for Real mode).</param>
    /// <returns>An IDownloadExecutor instance.</returns>
    public static IDownloadExecutor Create(
        ExecutorMode mode, 
        VmaMonitor vmaMonitor,
        RealS3Config? s3Config = null)
    {
        return mode switch
        {
            ExecutorMode.Simulated => new DownloadSimulator(vmaMonitor),
            ExecutorMode.Real => CreateRealExecutor(vmaMonitor, s3Config),
            _ => throw new ArgumentException($"Unknown executor mode: {mode}")
        };
    }

    private static IDownloadExecutor CreateRealExecutor(VmaMonitor vmaMonitor, RealS3Config? s3Config)
    {
        if (s3Config == null)
        {
            throw new ArgumentException(
                "S3 configuration is required for Real mode. " +
                "Use --s3-bucket and --s3-key options.");
        }

        if (!s3Config.Validate(out var errorMessage))
        {
            throw new ArgumentException($"Invalid S3 configuration: {errorMessage}");
        }

        return new RealS3DownloadExecutor(vmaMonitor, s3Config);
    }

    /// <summary>
    /// Gets a description of the specified execution mode.
    /// </summary>
    public static string GetModeDescription(ExecutorMode mode)
    {
        return mode switch
        {
            ExecutorMode.Simulated => 
                "Simulated mode uses ArrayPool allocations to mimic S3 download behavior " +
                "without actual network I/O. Fast and deterministic, no AWS credentials needed.",
            ExecutorMode.Real => 
                "Real mode performs actual S3 downloads using Transfer Utility. " +
                "Requires AWS credentials and an S3 bucket with test objects.",
            _ => "Unknown mode"
        };
    }

    /// <summary>
    /// Lists required options for a given mode.
    /// </summary>
    public static string[] GetRequiredOptions(ExecutorMode mode)
    {
        return mode switch
        {
            ExecutorMode.Simulated => Array.Empty<string>(),
            ExecutorMode.Real => new[] { "--s3-bucket", "--s3-key" },
            _ => Array.Empty<string>()
        };
    }
}
