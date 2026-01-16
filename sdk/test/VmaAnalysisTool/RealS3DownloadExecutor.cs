using System.Diagnostics;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Executes real S3 downloads using Transfer Utility to measure actual VMA behavior.
/// </summary>
public class RealS3DownloadExecutor : IDownloadExecutor
{
    private readonly VmaMonitor _vmaMonitor;
    private readonly RealS3Config _s3Config;
    private IAmazonS3? _s3Client;
    private bool _disposed;
    private readonly object _lock = new();

    /// <inheritdoc />
    public string Name => "Real S3";
    
    /// <inheritdoc />
    public string Description => $"Downloads from S3 bucket '{_s3Config.BucketName}' using Transfer Utility";
    
    /// <inheritdoc />
    public bool RequiresS3Access => true;

    /// <inheritdoc />
    public SimulationMetrics Metrics { get; private set; } = new();

    /// <inheritdoc />
    public int VmaAbortThreshold { get; set; } = VmaMonitor.DefaultAbortVmaThreshold;

    public RealS3DownloadExecutor(VmaMonitor vmaMonitor, RealS3Config s3Config)
    {
        _vmaMonitor = vmaMonitor;
        _s3Config = s3Config;
    }
    
    /// <inheritdoc />
    public bool ValidateConfig(SimulationConfig config, out string? errorMessage)
    {
        if (!_s3Config.Validate(out errorMessage))
        {
            return false;
        }
        
        if (string.IsNullOrWhiteSpace(_s3Config.ObjectKey))
        {
            errorMessage = "S3 object key is required for real downloads";
            return false;
        }
        
        if (config.ConcurrentServiceRequests <= 0)
        {
            errorMessage = "ConcurrentServiceRequests must be greater than 0";
            return false;
        }
        
        errorMessage = null;
        return true;
    }

    /// <inheritdoc />
    public async Task<SimulationMetrics> ExecuteDownloadAsync(
        SimulationConfig config, 
        IProgress<DownloadProgress>? progress = null,
        CancellationToken cancellationToken = default)
    {
        _vmaMonitor.Reset();
        
        // Capture baseline memory
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        
        var process = Process.GetCurrentProcess();
        process.Refresh();
        var baselineWorkingSet = process.WorkingSet64;
        var baselineGcMemory = GC.GetTotalMemory(true);
        
        Metrics = new SimulationMetrics
        {
            Config = config,
            StartTime = DateTime.UtcNow,
            BaselineWorkingSetBytes = baselineWorkingSet,
            BaselineGcMemoryBytes = baselineGcMemory
        };

        var totalStopwatch = Stopwatch.StartNew();
        
        // Create a linked cancellation token that we can cancel if VMA limit is exceeded
        using var vmaAbortCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        var linkedToken = vmaAbortCts.Token;

        // Ensure S3 client is created
        EnsureS3Client();

        // Start VMA and memory monitoring task
        var vmaMonitorTask = StartVmaAndMemoryMonitoringAsync(vmaAbortCts, VmaAbortThreshold);

        // Prepare download directory
        var downloadDir = _s3Config.DownloadDirectory ?? Path.GetTempPath();
        var localFilePath = Path.Combine(downloadDir, $"vma-test-{Guid.NewGuid()}.bin");

        try
        {
            // Create TransferUtility with config matching our test parameters
            var transferConfig = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = config.ConcurrentServiceRequests,
                // Note: In real SDK, MinPartSize and other params control chunk sizing
                // But we need to match the SDK's actual behavior
            };

            using var transferUtility = new TransferUtility(_s3Client, transferConfig);
            
            // Create download request
            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = _s3Config.BucketName,
                Key = _s3Config.ObjectKey,
                FilePath = localFilePath
            };

            // Get object size first for progress reporting
            var objectSize = await GetObjectSizeAsync(linkedToken);
            var expectedParts = (int)Math.Ceiling((double)objectSize / config.PartSizeBytes);
            
            // Track progress
            long totalBytesDownloaded = 0;
            downloadRequest.WriteObjectProgressEvent += (sender, e) =>
            {
                int completedParts;
                lock (_lock)
                {
                    totalBytesDownloaded = e.TransferredBytes;
                    Metrics.TotalBytesProcessed = totalBytesDownloaded;
                    completedParts = config.PartSizeBytes > 0 
                        ? (int)(totalBytesDownloaded / config.PartSizeBytes)
                        : 0;
                }
                _vmaMonitor.UpdatePeak();
                UpdateMemoryMetrics();
                
                // Report progress
                progress?.Report(new DownloadProgress
                {
                    CompletedParts = completedParts,
                    TotalParts = expectedParts,
                    Phase = "Downloading",
                    CurrentVmaCount = _vmaMonitor.CurrentVmaCount,
                    BytesProcessed = totalBytesDownloaded,
                    TotalBytes = objectSize
                });
            };

            Console.WriteLine($"  Starting download: s3://{_s3Config.BucketName}/{_s3Config.ObjectKey}");
            Console.WriteLine($"  Local path: {localFilePath}");
            Console.WriteLine($"  ConcurrentServiceRequests: {config.ConcurrentServiceRequests}");

            // Execute the download using the newer multipart-enabled API
            // DownloadWithResponseAsync uses parallel downloads for improved performance
            var downloadResponse = await transferUtility.DownloadWithResponseAsync(downloadRequest, linkedToken);
            
            // Get response metadata
            var contentLength = downloadResponse.Headers.ContentLength;
            Metrics.TotalBytesProcessed = contentLength;
            
            // Calculate parts based on actual file size and part size
            Metrics.CompletedParts = (int)Math.Ceiling((double)contentLength / config.PartSizeBytes);
            
            Console.WriteLine($"  Download complete: {contentLength:N0} bytes");
            Console.WriteLine($"  Content-Type: {downloadResponse.Headers.ContentType}");
            if (!string.IsNullOrEmpty(downloadResponse.VersionId))
            {
                Console.WriteLine($"  Version ID: {downloadResponse.VersionId}");
            }
        }
        catch (OperationCanceledException) when (vmaAbortCts.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
        {
            Metrics.WasAborted = true;
            Metrics.AbortReason = $"VMA count exceeded abort threshold ({VmaAbortThreshold:N0})";
        }
        catch (VmaLimitExceededException ex)
        {
            Metrics.WasAborted = true;
            Metrics.AbortReason = ex.Message;
        }
        catch (AmazonS3Exception ex)
        {
            Metrics.WasAborted = true;
            Metrics.AbortReason = $"S3 Error: {ex.Message}";
            throw;
        }
        finally
        {
            // Cancel the VMA monitoring task
            if (!vmaAbortCts.IsCancellationRequested)
            {
                vmaAbortCts.Cancel();
            }
            
            totalStopwatch.Stop();

            // Clean up downloaded file if requested
            if (_s3Config.CleanupDownloads && File.Exists(localFilePath))
            {
                try
                {
                    File.Delete(localFilePath);
                }
                catch
                {
                    // Ignore cleanup errors
                }
            }

            // Final metrics
            Metrics.EndTime = DateTime.UtcNow;
            Metrics.DurationMs = totalStopwatch.ElapsedMilliseconds;
            Metrics.FinalVmaSnapshot = _vmaMonitor.TakeSnapshot();
            Metrics.PeakVmaCount = _vmaMonitor.PeakVmaCount;
            
            // Calculate throughput metrics
            if (Metrics.DurationMs > 0)
            {
                var durationSec = Metrics.DurationMs / 1000.0;
                Metrics.PartsPerSecond = Metrics.CompletedParts / durationSec;
                Metrics.MemoryThroughputMBps = (Metrics.TotalBytesProcessed / 1024.0 / 1024.0) / durationSec;
            }
            
            // Wait for VMA monitor task to complete
            try { await vmaMonitorTask; } catch { /* ignore */ }
        }

        return Metrics;
    }

    /// <summary>
    /// Creates the S3 client if not already created.
    /// </summary>
    private void EnsureS3Client()
    {
        if (_s3Client != null) return;

        AWSCredentials? credentials = null;
        
        // Try to load credentials from profile if specified
        if (!string.IsNullOrWhiteSpace(_s3Config.ProfileName))
        {
            var credentialProfileStoreChain = new CredentialProfileStoreChain();
            if (credentialProfileStoreChain.TryGetAWSCredentials(_s3Config.ProfileName, out var profileCredentials))
            {
                credentials = profileCredentials;
            }
            else
            {
                throw new InvalidOperationException($"Could not find AWS profile '{_s3Config.ProfileName}'");
            }
        }

        var clientConfig = new AmazonS3Config
        {
            RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(_s3Config.Region)
        };

        _s3Client = credentials != null 
            ? new AmazonS3Client(credentials, clientConfig)
            : new AmazonS3Client(clientConfig);
    }

    /// <summary>
    /// Background task that monitors VMA count and memory.
    /// </summary>
    private async Task StartVmaAndMemoryMonitoringAsync(CancellationTokenSource abortCts, int threshold)
    {
        try
        {
            while (!abortCts.Token.IsCancellationRequested)
            {
                await Task.Delay(50, abortCts.Token); // Check every 50ms
                
                UpdateMemoryMetrics();
                
                if (threshold > 0)
                {
                    var currentVma = _vmaMonitor.CurrentVmaCount;
                    if (currentVma >= threshold)
                    {
                        Console.Error.WriteLine($"\n⚠ VMA ABORT: Count {currentVma:N0} exceeded threshold {threshold:N0}. Aborting test...");
                        abortCts.Cancel();
                        return;
                    }
                }
            }
        }
        catch (OperationCanceledException)
        {
            // Expected when test completes or is cancelled
        }
    }
    
    /// <summary>
    /// Updates peak memory metrics from current process state.
    /// </summary>
    private void UpdateMemoryMetrics()
    {
        try
        {
            var process = Process.GetCurrentProcess();
            process.Refresh();
            
            lock (_lock)
            {
                var workingSet = process.WorkingSet64;
                var privateMemory = process.PrivateMemorySize64;
                var gcMemory = GC.GetTotalMemory(false);
                
                if (workingSet > Metrics.PeakWorkingSetBytes)
                    Metrics.PeakWorkingSetBytes = workingSet;
                    
                if (privateMemory > Metrics.PeakPrivateMemoryBytes)
                    Metrics.PeakPrivateMemoryBytes = privateMemory;
                    
                if (gcMemory > Metrics.PeakGcMemoryBytes)
                    Metrics.PeakGcMemoryBytes = gcMemory;
            }
        }
        catch
        {
            // Ignore errors in monitoring
        }
    }

    /// <summary>
    /// Gets the size of the S3 object.
    /// </summary>
    public async Task<long> GetObjectSizeAsync(CancellationToken cancellationToken = default)
    {
        EnsureS3Client();
        
        var response = await _s3Client!.GetObjectMetadataAsync(
            _s3Config.BucketName, 
            _s3Config.ObjectKey, 
            cancellationToken);
            
        return response.ContentLength;
    }

    /// <summary>
    /// Lists available test objects in the bucket.
    /// </summary>
    public async Task<List<(string Key, long Size)>> ListTestObjectsAsync(string prefix = "vma-test/", CancellationToken cancellationToken = default)
    {
        EnsureS3Client();
        
        var objects = new List<(string Key, long Size)>();
        
        var request = new ListObjectsV2Request
        {
            BucketName = _s3Config.BucketName,
            Prefix = prefix
        };

        ListObjectsV2Response response;
        do
        {
            response = await _s3Client!.ListObjectsV2Async(request, cancellationToken);
            
            foreach (var obj in response.S3Objects)
            {
                var size = obj.Size ?? 0;
                if (size > 0) // Skip directory markers
                {
                    objects.Add((obj.Key, size));
                }
            }
            
            request.ContinuationToken = response.NextContinuationToken;
        }
        while (response.IsTruncated == true);

        return objects;
    }

    public void Dispose()
    {
        if (_disposed) return;
        
        _s3Client?.Dispose();
        _s3Client = null;
        
        _disposed = true;
    }
}
