using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.S3.VmaAnalysis;

/// <summary>
/// Helper class to set up S3 test data (buckets and test objects).
/// </summary>
public class S3TestDataSetup : IDisposable
{
    private readonly string _region;
    private readonly string? _profileName;
    private IAmazonS3? _s3Client;
    private bool _disposed;

    public S3TestDataSetup(string region, string? profileName = null)
    {
        _region = region;
        _profileName = profileName;
    }

    /// <summary>
    /// Ensures the S3 client is created.
    /// </summary>
    private void EnsureS3Client()
    {
        if (_s3Client != null) return;

        AWSCredentials? credentials = null;
        
        if (!string.IsNullOrWhiteSpace(_profileName))
        {
            var credentialProfileStoreChain = new CredentialProfileStoreChain();
            if (credentialProfileStoreChain.TryGetAWSCredentials(_profileName, out var profileCredentials))
            {
                credentials = profileCredentials;
            }
            else
            {
                throw new InvalidOperationException($"Could not find AWS profile '{_profileName}'");
            }
        }

        var clientConfig = new AmazonS3Config
        {
            RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(_region)
        };

        _s3Client = credentials != null 
            ? new AmazonS3Client(credentials, clientConfig)
            : new AmazonS3Client(clientConfig);
    }

    /// <summary>
    /// Creates a bucket if it doesn't exist.
    /// </summary>
    public async Task<bool> EnsureBucketExistsAsync(string bucketName, CancellationToken cancellationToken = default)
    {
        EnsureS3Client();
        
        try
        {
            // Check if bucket exists
            await _s3Client!.GetBucketLocationAsync(new GetBucketLocationRequest
            {
                BucketName = bucketName
            }, cancellationToken);
            
            Console.WriteLine($"  ✓ Bucket '{bucketName}' already exists");
            return false; // Already existed
        }
        catch (AmazonS3Exception ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            // Bucket doesn't exist, create it
            Console.WriteLine($"  Creating bucket '{bucketName}'...");
            
            var request = new PutBucketRequest
            {
                BucketName = bucketName,
                UseClientRegion = true
            };
            
            await _s3Client.PutBucketAsync(request, cancellationToken);
            Console.WriteLine($"  ✓ Bucket '{bucketName}' created successfully");
            return true; // Newly created
        }
    }

    /// <summary>
    /// Creates a test object of the specified size.
    /// </summary>
    public async Task<bool> EnsureTestObjectExistsAsync(
        string bucketName, 
        string key, 
        long sizeBytes,
        bool forceRecreate = false,
        CancellationToken cancellationToken = default)
    {
        EnsureS3Client();
        
        // Check if object already exists with correct size
        if (!forceRecreate)
        {
            try
            {
                var metadata = await _s3Client!.GetObjectMetadataAsync(bucketName, key, cancellationToken);
                if (metadata.ContentLength == sizeBytes)
                {
                    Console.WriteLine($"  ✓ Object '{key}' already exists with correct size ({FormatBytes(sizeBytes)})");
                    return false; // Already existed
                }
                Console.WriteLine($"  Object '{key}' exists but size mismatch (expected: {FormatBytes(sizeBytes)}, actual: {FormatBytes(metadata.ContentLength)}). Recreating...");
            }
            catch (AmazonS3Exception ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Object doesn't exist, will create it
            }
        }
        
        Console.WriteLine($"  Creating test object '{key}' ({FormatBytes(sizeBytes)})...");
        
        // For large files, use multipart upload
        if (sizeBytes > 100 * 1024 * 1024) // > 100MB
        {
            await CreateLargeTestObjectAsync(bucketName, key, sizeBytes, cancellationToken);
        }
        else
        {
            await CreateSmallTestObjectAsync(bucketName, key, sizeBytes, cancellationToken);
        }
        
        Console.WriteLine($"  ✓ Object '{key}' created ({FormatBytes(sizeBytes)})");
        return true;
    }

    /// <summary>
    /// Creates a small test object using single PUT.
    /// </summary>
    private async Task CreateSmallTestObjectAsync(string bucketName, string key, long sizeBytes, CancellationToken cancellationToken)
    {
        // Generate random data
        var data = new byte[sizeBytes];
        Random.Shared.NextBytes(data);
        
        using var stream = new MemoryStream(data);
        
        var request = new PutObjectRequest
        {
            BucketName = bucketName,
            Key = key,
            InputStream = stream,
            ContentType = "application/octet-stream"
        };
        
        request.Metadata.Add("x-amz-meta-vma-test", "true");
        request.Metadata.Add("x-amz-meta-size", sizeBytes.ToString());
        
        await _s3Client!.PutObjectAsync(request, cancellationToken);
    }

    /// <summary>
    /// Creates a large test object using multipart upload.
    /// </summary>
    private async Task CreateLargeTestObjectAsync(string bucketName, string key, long sizeBytes, CancellationToken cancellationToken)
    {
        const long partSize = 50 * 1024 * 1024; // 50MB parts
        
        // Initiate multipart upload
        var initiateRequest = new InitiateMultipartUploadRequest
        {
            BucketName = bucketName,
            Key = key,
            ContentType = "application/octet-stream"
        };
        initiateRequest.Metadata.Add("x-amz-meta-vma-test", "true");
        initiateRequest.Metadata.Add("x-amz-meta-size", sizeBytes.ToString());
        
        var initResponse = await _s3Client!.InitiateMultipartUploadAsync(initiateRequest, cancellationToken);
        var uploadId = initResponse.UploadId;
        
        try
        {
            var partETags = new List<PartETag>();
            var partNumber = 1;
            var bytesRemaining = sizeBytes;
            
            while (bytesRemaining > 0)
            {
                var currentPartSize = (int)Math.Min(partSize, bytesRemaining);
                var data = new byte[currentPartSize];
                Random.Shared.NextBytes(data);
                
                using var stream = new MemoryStream(data);
                
                var uploadPartRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = uploadId,
                    PartNumber = partNumber,
                    InputStream = stream,
                    PartSize = currentPartSize
                };
                
                var uploadPartResponse = await _s3Client.UploadPartAsync(uploadPartRequest, cancellationToken);
                partETags.Add(new PartETag(partNumber, uploadPartResponse.ETag));
                
                bytesRemaining -= currentPartSize;
                partNumber++;
                
                var progress = (int)((1 - (double)bytesRemaining / sizeBytes) * 100);
                Console.Write($"\r    Progress: {progress}% ({FormatBytes(sizeBytes - bytesRemaining)} / {FormatBytes(sizeBytes)})");
            }
            
            Console.WriteLine();
            
            // Complete multipart upload
            var completeRequest = new CompleteMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                UploadId = uploadId,
                PartETags = partETags
            };
            
            await _s3Client.CompleteMultipartUploadAsync(completeRequest, cancellationToken);
        }
        catch
        {
            // Abort on failure
            await _s3Client.AbortMultipartUploadAsync(bucketName, key, uploadId, cancellationToken);
            throw;
        }
    }

    /// <summary>
    /// Sets up test data for VMA analysis with objects of various sizes.
    /// </summary>
    public async Task SetupTestDataAsync(
        string bucketName,
        long[] objectSizesBytes,
        string keyPrefix = "vma-test/",
        bool forceRecreate = false,
        CancellationToken cancellationToken = default)
    {
        Console.WriteLine($"\n=== Setting up S3 Test Data ===\n");
        Console.WriteLine($"Bucket: {bucketName}");
        Console.WriteLine($"Region: {_region}");
        Console.WriteLine($"Key Prefix: {keyPrefix}");
        Console.WriteLine($"Object Sizes: {string.Join(", ", objectSizesBytes.Select(FormatBytes))}");
        Console.WriteLine();
        
        // Create bucket
        await EnsureBucketExistsAsync(bucketName, cancellationToken);
        
        // Create test objects
        foreach (var size in objectSizesBytes)
        {
            var key = $"{keyPrefix}{FormatBytesForKey(size)}.bin";
            await EnsureTestObjectExistsAsync(bucketName, key, size, forceRecreate, cancellationToken);
        }
        
        Console.WriteLine("\n✓ Test data setup complete!");
        Console.WriteLine("\nGenerated test object keys:");
        foreach (var size in objectSizesBytes)
        {
            var key = $"{keyPrefix}{FormatBytesForKey(size)}.bin";
            Console.WriteLine($"  - {key}");
        }
    }

    /// <summary>
    /// Lists existing test objects in a bucket.
    /// </summary>
    public async Task<List<(string Key, long Size)>> ListTestObjectsAsync(
        string bucketName,
        string keyPrefix = "vma-test/",
        CancellationToken cancellationToken = default)
    {
        EnsureS3Client();
        
        var objects = new List<(string Key, long Size)>();
        
        var request = new ListObjectsV2Request
        {
            BucketName = bucketName,
            Prefix = keyPrefix
        };

        ListObjectsV2Response response;
        do
        {
            response = await _s3Client!.ListObjectsV2Async(request, cancellationToken);
            
            foreach (var obj in response.S3Objects)
            {
                var size = obj.Size ?? 0;
                if (size > 0)
                {
                    objects.Add((obj.Key, size));
                }
            }
            
            request.ContinuationToken = response.NextContinuationToken;
        }
        while (response.IsTruncated == true);

        return objects;
    }

    /// <summary>
    /// Deletes test objects in a bucket.
    /// </summary>
    public async Task CleanupTestDataAsync(
        string bucketName,
        string keyPrefix = "vma-test/",
        CancellationToken cancellationToken = default)
    {
        Console.WriteLine($"\n=== Cleaning up S3 Test Data ===\n");
        
        var objects = await ListTestObjectsAsync(bucketName, keyPrefix, cancellationToken);
        
        if (objects.Count == 0)
        {
            Console.WriteLine("No test objects found to delete.");
            return;
        }
        
        Console.WriteLine($"Deleting {objects.Count} test object(s)...");
        
        foreach (var (key, _) in objects)
        {
            await _s3Client!.DeleteObjectAsync(bucketName, key, cancellationToken);
            Console.WriteLine($"  Deleted: {key}");
        }
        
        Console.WriteLine("\n✓ Cleanup complete!");
    }

    private static string FormatBytes(long bytes)
    {
        if (bytes >= 1024L * 1024 * 1024) return $"{bytes / 1024.0 / 1024.0 / 1024.0:F1}GB";
        if (bytes >= 1024 * 1024) return $"{bytes / 1024.0 / 1024.0:F0}MB";
        if (bytes >= 1024) return $"{bytes / 1024.0:F0}KB";
        return $"{bytes}B";
    }

    private static string FormatBytesForKey(long bytes)
    {
        if (bytes >= 1024L * 1024 * 1024) return $"{bytes / 1024 / 1024 / 1024}gb";
        if (bytes >= 1024 * 1024) return $"{bytes / 1024 / 1024}mb";
        if (bytes >= 1024) return $"{bytes / 1024}kb";
        return $"{bytes}b";
    }

    public void Dispose()
    {
        if (_disposed) return;
        _s3Client?.Dispose();
        _s3Client = null;
        _disposed = true;
    }
}
