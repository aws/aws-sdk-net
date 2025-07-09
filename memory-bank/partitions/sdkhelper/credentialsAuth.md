# Credentials and Authentication

## Credential Provider Chain
The SDK uses a credential provider chain to automatically discover credentials:

1. **Environment Variables** - `AWS_ACCESS_KEY_ID`, `AWS_SECRET_ACCESS_KEY`
2. **Shared Credentials File** - `~/.aws/credentials`
3. **AWS Profiles** - Named profiles in credentials file
4. **IAM Roles** - EC2 instance profiles, ECS task roles
5. **SSO Credentials** - AWS SSO login sessions

## Configuration Patterns

### Basic Client Setup
```csharp
// Automatic credential discovery
var s3Client = new AmazonS3Client(RegionEndpoint.USEast1);

// Explicit credentials
var credentials = new BasicAWSCredentials("accessKey", "secretKey");
var s3Client = new AmazonS3Client(credentials, RegionEndpoint.USEast1);
```

### Profile-Based Configuration
```csharp
// Use specific profile
var chain = new CredentialProfileStoreChain();
if (chain.TryGetAWSCredentials("myprofile", out var credentials))
{
    var s3Client = new AmazonS3Client(credentials, RegionEndpoint.USEast1);
}
```

### Role-Based Authentication
```csharp
// Assume role credentials
var stsClient = new AmazonSecurityTokenServiceClient();
var assumeRoleRequest = new AssumeRoleRequest
{
    RoleArn = "arn:aws:iam::123456789012:role/MyRole",
    RoleSessionName = "MySession"
};

var assumeRoleResponse = await stsClient.AssumeRoleAsync(assumeRoleRequest);
var sessionCredentials = new SessionAWSCredentials(
    assumeRoleResponse.Credentials.AccessKeyId,
    assumeRoleResponse.Credentials.SecretAccessKey,
    assumeRoleResponse.Credentials.SessionToken);

var s3Client = new AmazonS3Client(sessionCredentials, RegionEndpoint.USEast1);
```

## Configuration Options

### Client Configuration
```csharp
var config = new AmazonS3Config
{
    RegionEndpoint = RegionEndpoint.USWest2,
    Timeout = TimeSpan.FromSeconds(30),
    MaxErrorRetry = 3,
    RetryMode = RequestRetryMode.Standard
};

var s3Client = new AmazonS3Client(config);
```

### Global Configuration
```csharp
// Set global defaults
AWSConfigs.AWSRegion = "us-west-2";
AWSConfigs.LoggingConfig.LogTo = LoggingOptions.Console;
AWSConfigs.LoggingConfig.LogMetrics = true;
```

## Security Best Practices

### Credential Management
- Never hardcode credentials in source code
- Use IAM roles when running on AWS infrastructure
- Rotate credentials regularly
- Use least privilege principle for IAM policies
- Store credentials securely (AWS Secrets Manager, Parameter Store)

### Client Lifecycle
```csharp
// Proper disposal pattern
using var s3Client = new AmazonS3Client();
// Client operations
```

### Thread Safety
- Service clients are thread-safe
- Reuse clients across requests
- Avoid creating new clients for each operation