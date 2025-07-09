# Breaking Changes Reference

## Collection Properties

### Change
Collections are null by default instead of empty collections.

### V3 Behavior
```csharp
var response = await s3Client.ListObjectsV2Async(request);
// response.S3Objects is never null, always initialized as empty list
foreach (var obj in response.S3Objects) { } // Safe
```

### V4 Behavior
```csharp
var response = await s3Client.ListObjectsV2Async(request);
// response.S3Objects can be null
if (response.S3Objects != null) // Required null check
{
    foreach (var obj in response.S3Objects) { }
}
```

### Migration
Add null checks before accessing collection properties or use `InitializeCollections = true` temporarily.

**Important:** NEVER use this approach automatically. Always ask the developer before suggesting this temporary solution.

## Nullable Value Types

### Change
Value types in request/response classes are now nullable.

### V3 Behavior
```csharp
public class GetObjectResponse
{
    public long ContentLength { get; set; } // Always has value (0 or actual)
}

// Usage
if (response.ContentLength > 0) { }
```

### V4 Behavior
```csharp
public class GetObjectResponse
{
    public long? ContentLength { get; set; } // Can be null
}

// Usage
if (response.ContentLength.HasValue && response.ContentLength.Value > 0) { }
```

### Migration
Check `HasValue` property before accessing nullable value types.

## DynamoDB Streams Package

### Change
DynamoDB Streams moved to separate package.

### V3 Behavior
```csharp
// Included in AWSSDK.DynamoDBv2
using Amazon.DynamoDBv2.Model;
var streamRecord = new StreamRecord();
```

### V4 Behavior
```csharp
// Requires separate package: AWSSDK.DynamoDBStreams
using Amazon.DynamoDBStreams.Model;
var streamRecord = new StreamRecord();
```

### Migration
Add `AWSSDK.DynamoDBStreams` package reference and update using statements.

## DynamoDBContext Constructor

### Change
DynamoDBContext constructors obsoleted in favor of builder pattern.

### V3 Behavior
```csharp
var context = new DynamoDBContext(dynamoClient);
var context = new DynamoDBContext(dynamoClient, config);
```

### V4 Behavior
```csharp
var context = new DynamoDBContextBuilder()
    .WithDynamoDBClient(dynamoClient)
    .Build();

var context = new DynamoDBContextBuilder()
    .WithDynamoDBClient(dynamoClient)
    .WithConfig(config)
    .Build();
```

### Migration
Replace constructor calls with builder pattern.

## DynamoDB Operation Configuration

### Change
Generic `DynamoDBOperationConfig` replaced with operation-specific config objects.

### V3 Behavior
```csharp
var config = new DynamoDBOperationConfig
{
    OverrideTableName = "MyTable"
};
await context.LoadAsync<MyClass>(key, config);
```

### V4 Behavior
```csharp
var config = new LoadConfig
{
    OverrideTableName = "MyTable"
};
await context.LoadAsync<MyClass>(key, config);
```

### Migration
Use operation-specific configuration classes.

## S3 us-east-1 Endpoint

### Change
S3 us-east-1 treated as regional-only endpoint.

### V3 Behavior
```csharp
// Could use global endpoint s3.amazonaws.com
var client = new AmazonS3Client(RegionEndpoint.USEast1);
```

### V4 Behavior
```csharp
// Always uses regional endpoint s3.us-east-1.amazonaws.com
var client = new AmazonS3Client(RegionEndpoint.USEast1);
```

### Migration
No code changes required, but network behavior changes.

## S3 Encryption Client

### Change
S3 encryption client removed from AWSSDK.S3.

### V3 Behavior
```csharp
using Amazon.S3.Encryption;
var encryptionClient = new AmazonS3EncryptionClient(encryptionMaterials);
```

### V4 Behavior
```csharp
// Requires separate package: Amazon.Extensions.S3.Encryption
using Amazon.Extensions.S3.Encryption;
var encryptionClient = new AmazonS3EncryptionClientV2(encryptionMaterials);
```

### Migration
Add `Amazon.Extensions.S3.Encryption` package and update using statements.

## DateTime Handling

### Change
Consistent UTC handling for all DateTime properties.

### V3 Behavior
```csharp
// Mixed local/UTC handling
var lastModified = s3Object.LastModified; // Could be local or UTC
```

### V4 Behavior
```csharp
// Always UTC
var lastModified = s3Object.LastModified; // Always UTC
```

### Migration
Ensure all DateTime handling expects UTC values.

## CloudFront Signers

### Change
CloudFront signers moved to separate package.

### V3 Behavior
```csharp
using Amazon.CloudFront;
var signer = new CloudFrontUrlSigner();
```

### V4 Behavior
```csharp
// Requires separate package: AWSSDK.Extensions.CloudFront.Signers
using Amazon.Extensions.CloudFront.Signers;
var signer = new CloudFrontUrlSigner();
```

### Migration
Add `AWSSDK.Extensions.CloudFront.Signers` package reference.

## EC2 Password Decryption

### Change
EC2 password decryption moved to separate package.

### V3 Behavior
```csharp
using Amazon.EC2.Util;
var password = EC2PasswordUtility.DecryptPassword(privateKey, encryptedPassword);
```

### V4 Behavior
```csharp
// Requires separate package: AWSSDK.Extensions.EC2.DecryptPassword
using Amazon.Extensions.EC2.DecryptPassword;
var password = EC2PasswordUtility.DecryptPassword(privateKey, encryptedPassword);
```

### Migration
Add `AWSSDK.Extensions.EC2.DecryptPassword` package reference.

## RetryMode and DefaultConfigurationMode

### Change
Default values changed to `Standard`.

### V3 Behavior
```csharp
// RetryMode defaulted to Legacy
// DefaultConfigurationMode defaulted to Legacy
```

### V4 Behavior
```csharp
// RetryMode defaults to Standard
// DefaultConfigurationMode defaults to Standard
```

### Migration
Explicitly set to `Legacy` if V3 behavior is required.

## IAM Action Identifiers

### Change
Removed from `Amazon.Auth.AccessControlPolicy.ActionIdentifiers`.

### V3 Behavior
```csharp
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
var action = S3ActionIdentifiers.GetObject;
```

### V4 Behavior
```csharp
// No longer available - use string literals
var action = "s3:GetObject";
```

### Migration
Replace with string literals for IAM actions.

## EC2 IMDS Protocol

### Change
Always uses IMDS v2 protocol.

### V3 Behavior
```csharp
// Could use IMDS v1 or v2
```

### V4 Behavior
```csharp
// Always uses IMDS v2 for better security
```

### Migration
No code changes required, but network behavior changes.

## Interface-Based Returns

### Change
DynamoDB libraries return interfaces instead of concrete classes.

### V3 Behavior
```csharp
Table table = Table.LoadTable(dynamoClient, "MyTable");
BatchWrite batchWrite = table.CreateBatchWrite();
```

### V4 Behavior
```csharp
ITable table = Table.LoadTable(dynamoClient, "MyTable");
IDocumentBatchWrite batchWrite = table.CreateBatchWrite();
```

### Migration
Use interface types instead of concrete types for better testability.