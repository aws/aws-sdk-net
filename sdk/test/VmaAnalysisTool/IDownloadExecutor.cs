namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Defines a download executor that can run VMA analysis tests.
/// Implementations can either simulate downloads or perform real S3 downloads.
/// </summary>
public interface IDownloadExecutor : IDisposable
{
    /// <summary>
    /// Gets the name of this executor (e.g., "Simulated", "Real S3").
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// Gets a description of what this executor does.
    /// </summary>
    string Description { get; }
    
    /// <summary>
    /// Indicates whether this executor requires S3 access (credentials, bucket, etc.).
    /// </summary>
    bool RequiresS3Access { get; }
    
    /// <summary>
    /// VMA threshold at which to abort test (0 = disabled).
    /// </summary>
    int VmaAbortThreshold { get; set; }
    
    /// <summary>
    /// Gets the current metrics from the most recent execution.
    /// </summary>
    SimulationMetrics Metrics { get; }
    
    /// <summary>
    /// Executes a download with the specified configuration and collects metrics.
    /// </summary>
    /// <param name="config">The download configuration to test.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Metrics collected during the download.</returns>
    Task<SimulationMetrics> ExecuteDownloadAsync(
        SimulationConfig config, 
        CancellationToken cancellationToken = default);
        
    /// <summary>
    /// Validates that this executor can run with the given configuration.
    /// </summary>
    /// <param name="config">The configuration to validate.</param>
    /// <returns>True if valid, false otherwise.</returns>
    bool ValidateConfig(SimulationConfig config, out string? errorMessage);
}

/// <summary>
/// Execution mode for the VMA analysis tool.
/// </summary>
public enum ExecutorMode
{
    /// <summary>
    /// Simulated mode - uses ArrayPool allocations to mimic S3 downloads without network.
    /// Fast, deterministic, no AWS credentials needed.
    /// </summary>
    Simulated,
    
    /// <summary>
    /// Real mode - performs actual S3 downloads using Transfer Utility.
    /// Requires AWS credentials and S3 bucket/object.
    /// </summary>
    Real
}

/// <summary>
/// Configuration for real S3 downloads.
/// </summary>
public class RealS3Config
{
    /// <summary>
    /// S3 bucket name containing test objects.
    /// </summary>
    public string BucketName { get; set; } = string.Empty;
    
    /// <summary>
    /// S3 object key to download. If empty, will look for objects based on part size.
    /// </summary>
    public string ObjectKey { get; set; } = string.Empty;
    
    /// <summary>
    /// AWS region for S3 operations.
    /// </summary>
    public string Region { get; set; } = "us-east-1";
    
    /// <summary>
    /// AWS profile name to use for credentials. If empty, uses default credential chain.
    /// </summary>
    public string? ProfileName { get; set; }
    
    /// <summary>
    /// Local directory to download files to. If empty, uses temp directory.
    /// </summary>
    public string? DownloadDirectory { get; set; }
    
    /// <summary>
    /// If true, delete downloaded files after each test.
    /// </summary>
    public bool CleanupDownloads { get; set; } = true;
    
    /// <summary>
    /// If true, verify downloaded file checksums.
    /// </summary>
    public bool VerifyChecksums { get; set; } = false;
    
    /// <summary>
    /// Validates the configuration.
    /// </summary>
    public bool Validate(out string? errorMessage)
    {
        if (string.IsNullOrWhiteSpace(BucketName))
        {
            errorMessage = "S3 bucket name is required for real downloads";
            return false;
        }
        
        if (string.IsNullOrWhiteSpace(Region))
        {
            errorMessage = "AWS region is required";
            return false;
        }
        
        errorMessage = null;
        return true;
    }
}
