# AWSSDK.Core

The shared runtime of the AWS SDK for .NET. Every service package (`AWSSDK.S3`, `AWSSDK.DynamoDBv2`, `AWSSDK.SQS`, ...) depends on it, so you normally don't install it yourself: add the package for the service you want to call and NuGet brings in the matching Core.

Core provides what all service clients have in common:

- Credential and region resolution (environment variables, shared config and credentials files, IAM Identity Center, container and EC2 instance roles).
- Request signing, retries, timeouts and endpoint resolution.
- The HTTP pipeline, logging and telemetry hooks.

# Getting started

Install a service package and create its client. The client finds credentials and the region through Core's default resolution chain.

```csharp
using Amazon.S3;
using Amazon.S3.Model;

using var client = new AmazonS3Client();
var response = await client.ListObjectsV2Async(new ListObjectsV2Request
{
    BucketName = "amzn-s3-demo-bucket"
});
```

To set the region or other client settings explicitly, pass a config object:

```csharp
using Amazon;
using Amazon.S3;

using var client = new AmazonS3Client(new AmazonS3Config { RegionEndpoint = RegionEndpoint.USWest2 });
```

# Versions

All `AWSSDK.*` packages in an application must be on the same major version. Version 3 and version 4 packages can't be mixed.

# Resources

- [Developer Guide](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/welcome.html)
- [Credential and profile resolution](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/creds-assign.html)
- [Migrating to version 4](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/net-dg-v4.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
- [Source and issues](https://github.com/aws/aws-sdk-net)
