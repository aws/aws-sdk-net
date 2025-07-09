# V3 to V4 Upgrade Guide

## Prerequisites
- Cannot mix V3 and V4 packages within an application
- All AWSSDK.* packages must be updated to 4.0.0 or greater
- Recompile application code after updating packages

## Step-by-Step Migration Process

### 1. Update Package References
```xml
<!-- Before (V3) -->
<PackageReference Include="AWSSDK.S3" Version="3.7.400.0" />
<PackageReference Include="AWSSDK.DynamoDBv2" Version="3.7.400.0" />

<!-- After (V4) -->
<PackageReference Include="AWSSDK.S3" Version="4.0.0" />
<PackageReference Include="AWSSDK.DynamoDBv2" Version="4.0.0" />
<PackageReference Include="AWSSDK.DynamoDBStreams" Version="4.0.0" />
```

### 2. Handle Collection Null Checks
**V3 Behavior:** Collections initialized as empty
**V4 Behavior:** Collections are null by default

```csharp
// V3 - Collections always initialized
var response = await s3Client.ListObjectsV2Async(request);
foreach (var obj in response.S3Objects) // Safe in V3
{
    // Process objects
}

// V4 - Add null checks
var response = await s3Client.ListObjectsV2Async(request);
if (response.S3Objects != null) // Required null check in V4
{
    foreach (var obj in response.S3Objects)
    {
        // Process objects
    }
}
```

### 3. Handle Nullable Value Types
```csharp
// V3 - Value types had default values
if (response.ContentLength > 0) // Could be 0 or actual value

// V4 - Value types are nullable
if (response.ContentLength.HasValue && response.ContentLength.Value > 0)
{
    // Process content length
}
```

### 4. Update DynamoDB Usage
```csharp
// V3 - Direct constructor
var context = new DynamoDBContext(dynamoClient);

// V4 - Use builder pattern
var context = new DynamoDBContextBuilder()
    .WithDynamoDBClient(dynamoClient)
    .Build();
```

### 5. Handle DynamoDB Streams
```csharp
// V3 - Included in AWSSDK.DynamoDBv2
using Amazon.DynamoDBv2.Model;

// V4 - Separate package required
// Add: <PackageReference Include="AWSSDK.DynamoDBStreams" Version="4.0.0" />
using Amazon.DynamoDBStreams.Model;
```

### 6. Update S3 Encryption (if used)
```csharp
// If still using obsoleted Amazon.S3.Encryption (removed in V4)
using Amazon.S3.Encryption;

// Upgrade to Amazon.Extensions.S3.Encryption package
// V3: <PackageReference Include="Amazon.Extensions.S3.Encryption" Version="2.2.1" />
// V4: <PackageReference Include="Amazon.Extensions.S3.Encryption" Version="3.0.0" />
using Amazon.Extensions.S3.Encryption;
```

**Note:** Amazon.S3.Encryption was obsoleted in V3 and removed in V4. Amazon.Extensions.S3.Encryption is the recommended approach for both V3 (versions 1.0.0-2.x.x) and V4 (versions 3.0.0+).

### 7. Handle DateTime Properties
```csharp
// V3 - Mixed local/UTC handling
var lastModified = s3Object.LastModified; // Could be local or UTC

// V4 - Consistent UTC handling
var lastModified = s3Object.LastModified; // Always UTC
```

## Migration Strategies

### Strategy 1: Gradual Migration (Recommended)
1. Update packages one service at a time
2. Add null checks incrementally
3. Test thoroughly after each service update
4. Use compiler warnings to identify issues

### Strategy 2: Complete Migration
1. Update all packages simultaneously
2. Fix all compilation errors
3. Add comprehensive null checks
4. Full regression testing

### Strategy 3: Compatibility Mode (Temporary)
```csharp
// Use only during transition period
Amazon.AWSConfigs.InitializeCollections = true;
```
**Warning:** This is a temporary workaround. Add proper null checks instead.
**Important:** NEVER use this approach automatically. Always ask the developer before suggesting this temporary solution.

## Testing Your Migration

### 1. Compilation Check
- Ensure all code compiles without errors
- Address nullable reference type warnings
- Verify all package references are V4

### 2. Runtime Validation
- Test all AWS service interactions
- Verify collection handling works correctly
- Check DateTime handling for timezone issues
- Validate error handling still works

### 3. Performance Testing
- V4 should show improved performance
- Monitor memory usage (should be lower)
- Check startup times (should be faster)

## Common Migration Patterns

### Null-Safe Collection Iteration
```csharp
// Pattern for safe collection access
public static void ProcessItems<T>(IList<T> items, Action<T> processor)
{
    if (items != null)
    {
        foreach (var item in items)
        {
            processor(item);
        }
    }
}
```

### Nullable Value Type Handling
```csharp
// Extension method for cleaner code
public static class NullableExtensions
{
    public static T GetValueOrDefault<T>(this T? nullable, T defaultValue) 
        where T : struct
    {
        return nullable ?? defaultValue;
    }
}
```

### DynamoDB Context Migration
```csharp
// Helper method for DynamoDB context creation
public static DynamoDBContext CreateDynamoDBContext(IAmazonDynamoDB client)
{
    return new DynamoDBContextBuilder()
        .WithDynamoDBClient(client)
        .Build();
}
```

## Troubleshooting

### NullReferenceException on Collections
**Cause:** Accessing null collections without null checks
**Solution:** Add null checks before accessing collections

### Missing DynamoDB Streams Types
**Cause:** DynamoDB Streams moved to separate package
**Solution:** Add AWSSDK.DynamoDBStreams package reference

### S3 Encryption Classes Not Found
**Cause:** S3 encryption moved to separate package
**Solution:** Add Amazon.Extensions.S3.Encryption package reference

### DateTime Timezone Issues
**Cause:** V4 consistently uses UTC
**Solution:** Ensure all DateTime handling expects UTC

### Performance Regression
**Cause:** Using InitializeCollections = true
**Solution:** Remove flag and add proper null checks