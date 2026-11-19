# AWSSDK.Extensions.NETCore.Setup

Integrates the AWS SDK for .NET with `Microsoft.Extensions.Configuration` and `Microsoft.Extensions.DependencyInjection`: read AWS settings from your application's configuration and register service clients in the dependency injection container.

# Getting started

Add an `AWS` section to `appsettings.json`:

```json
{
  "AWS": {
    "Profile": "my-profile",
    "Region": "us-west-2"
  }
}
```

Register the options and the service clients you need. Each service client comes from its own package (`AWSSDK.S3`, `AWSSDK.DynamoDBv2`, ...).

```csharp
using Amazon.DynamoDBv2;
using Amazon.S3;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions());
builder.Services.AddAWSService<IAmazonS3>();
builder.Services.AddAWSService<IAmazonDynamoDB>();
```

Then take the client as a constructor parameter:

```csharp
public class UploadService(IAmazonS3 s3) { }
```

Clients are registered as singletons by default, which is the recommended lifetime because service clients are thread-safe and relatively expensive to construct; pass a `ServiceLifetime` to change that. Without an `AWS` section, the clients use the SDK's default credential and region resolution.

# More options

- `GetAWSOptions().CreateServiceClient<T>()` creates a client from the configuration without dependency injection.
- `GetAWSOptions("SectionName")` reads the settings from a section other than `AWS`.
- `AddAWSService<T>(options)` gives one client its own `AWSOptions`, for example a different region.
- `AddKeyedAWSService<T>(key)` registers a client as a keyed service, so the same interface can be registered more than once (.NET 8 and later).
- `TryAddAWSService<T>()` registers the client only when the interface isn't registered already.

# Resources

- [Using AWSSDK.Extensions.NETCore.Setup and the IConfiguration interface](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-config-netcore.html)
- [Developer Guide](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/welcome.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
- [Source and issues](https://github.com/aws/aws-sdk-net)
