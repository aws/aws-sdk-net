# SDK Usage Patterns

## Async/Await Patterns

### Basic Async Operations
```csharp
public async Task<string> GetObjectContentAsync(string bucketName, string key)
{
    using var s3Client = new AmazonS3Client();
    
    var request = new GetObjectRequest
    {
        BucketName = bucketName,
        Key = key
    };
    
    using var response = await s3Client.GetObjectAsync(request);
    using var reader = new StreamReader(response.ResponseStream);
    return await reader.ReadToEndAsync();
}
```

### Batch Operations
```csharp
public async Task ProcessMultipleObjectsAsync(IEnumerable<string> keys)
{
    using var s3Client = new AmazonS3Client();
    
    var tasks = keys.Select(async key =>
    {
        var request = new GetObjectRequest { BucketName = "mybucket", Key = key };
        return await s3Client.GetObjectAsync(request);
    });
    
    var responses = await Task.WhenAll(tasks);
    
    foreach (var response in responses)
    {
        // Process response
        response.Dispose();
    }
}
```

## Error Handling

### Service-Specific Exceptions
```csharp
try
{
    var response = await s3Client.GetObjectAsync(request);
    // Process response
}
catch (AmazonS3Exception ex) when (ex.ErrorCode == "NoSuchKey")
{
    // Handle missing object
    Console.WriteLine($"Object not found: {ex.Message}");
}
catch (AmazonS3Exception ex)
{
    // Handle other S3 errors
    Console.WriteLine($"S3 Error: {ex.ErrorCode} - {ex.Message}");
}
catch (AmazonServiceException ex)
{
    // Handle general AWS service errors
    Console.WriteLine($"AWS Error: {ex.ErrorCode} - {ex.Message}");
}
```

### Retry Logic
```csharp
public async Task<T> ExecuteWithRetryAsync<T>(Func<Task<T>> operation, int maxRetries = 3)
{
    for (int attempt = 0; attempt <= maxRetries; attempt++)
    {
        try
        {
            return await operation();
        }
        catch (Exception ex) when (attempt < maxRetries && IsRetryableException(ex))
        {
            var delay = TimeSpan.FromSeconds(Math.Pow(2, attempt)); // Exponential backoff
            await Task.Delay(delay);
        }
    }
    
    throw new InvalidOperationException("Max retries exceeded");
}

private static bool IsRetryableException(Exception ex)
{
    return ex is AmazonServiceException serviceEx && 
           (serviceEx.StatusCode == HttpStatusCode.InternalServerError ||
            serviceEx.StatusCode == HttpStatusCode.BadGateway ||
            serviceEx.StatusCode == HttpStatusCode.ServiceUnavailable);
}
```

## Response Processing

### Handling Collections (V4)
```csharp
var response = await s3Client.ListObjectsV2Async(request);

// V4 - Collections can be null
if (response.S3Objects != null)
{
    foreach (var obj in response.S3Objects)
    {
        Console.WriteLine($"Key: {obj.Key}, Size: {obj.Size}");
    }
}

// Alternative pattern
var objects = response.S3Objects ?? new List<S3Object>();
foreach (var obj in objects)
{
    // Process objects
}
```

### Nullable Value Types (V4)
```csharp
var response = await s3Client.GetObjectAsync(request);

// V4 - Check HasValue for nullable types
if (response.ContentLength.HasValue)
{
    Console.WriteLine($"Content Length: {response.ContentLength.Value}");
}

// Use GetValueOrDefault for defaults
var contentLength = response.ContentLength.GetValueOrDefault(0);
```

## Performance Optimization

### Client Reuse
```csharp
// Good - Reuse client
public class S3Service
{
    private readonly IAmazonS3 _s3Client;
    
    public S3Service()
    {
        _s3Client = new AmazonS3Client();
    }
    
    public async Task<string> GetObjectAsync(string key)
    {
        // Use _s3Client for operations
    }
    
    public void Dispose() => _s3Client?.Dispose();
}
```

### Streaming Large Objects
```csharp
public async Task DownloadLargeObjectAsync(string bucketName, string key, string filePath)
{
    using var s3Client = new AmazonS3Client();
    using var response = await s3Client.GetObjectAsync(bucketName, key);
    using var fileStream = File.Create(filePath);
    
    await response.ResponseStream.CopyToAsync(fileStream);
}
```

## Testing and Mocking

### Interface-Based Testing
```csharp
public class S3Service
{
    private readonly IAmazonS3 _s3Client;
    
    public S3Service(IAmazonS3 s3Client)
    {
        _s3Client = s3Client;
    }
    
    public async Task<bool> ObjectExistsAsync(string bucketName, string key)
    {
        try
        {
            await _s3Client.GetObjectMetadataAsync(bucketName, key);
            return true;
        }
        catch (AmazonS3Exception ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            return false;
        }
    }
}

// Unit test
[Test]
public async Task ObjectExistsAsync_ReturnsTrue_WhenObjectExists()
{
    var mockS3 = new Mock<IAmazonS3>();
    mockS3.Setup(x => x.GetObjectMetadataAsync("bucket", "key", default))
          .ReturnsAsync(new GetObjectMetadataResponse());
    
    var service = new S3Service(mockS3.Object);
    var result = await service.ObjectExistsAsync("bucket", "key");
    
    Assert.IsTrue(result);
}