namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Common options for test commands.
/// </summary>
public record CommonOptions
{
    public bool Verbose { get; init; }
    public string? CsvPath { get; init; }
    public double? MaxMemoryGb { get; init; }
    public bool Isolated { get; init; }
    public ExecutorMode Mode { get; init; }
    public string? S3Bucket { get; init; }
    public string? S3Key { get; init; }
    public string S3Region { get; init; } = "us-east-1";
    public string? AwsProfile { get; init; }
    public string? DownloadDir { get; init; }
    public bool KeepDownloads { get; init; }
    
    public RealS3Config? CreateS3Config()
    {
        if (string.IsNullOrWhiteSpace(S3Bucket))
            return null;
            
        return new RealS3Config
        {
            BucketName = S3Bucket!,
            ObjectKey = S3Key ?? string.Empty,
            Region = S3Region,
            ProfileName = AwsProfile,
            DownloadDirectory = DownloadDir,
            CleanupDownloads = !KeepDownloads
        };
    }
}
