## Using temporary credentials

The `Credentials` returned by operations such as `AssumeRole` can be passed directly to any other service client.

```csharp
using Amazon.S3;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

var sts = new AmazonSecurityTokenServiceClient();
var response = await sts.AssumeRoleAsync(new AssumeRoleRequest
{
    RoleArn = "arn:aws:iam::123456789012:role/my-role",
    RoleSessionName = "my-session"
});

var s3 = new AmazonS3Client(response.Credentials);
```

These credentials expire and are not refreshed. For credentials that refresh themselves, use `AssumeRoleAWSCredentials` instead, which assumes the role for you.

```csharp
using Amazon.Runtime;
using Amazon.Runtime.Credentials;
using Amazon.S3;

var source = DefaultAWSCredentialsIdentityResolver.GetCredentials();
var credentials = new AssumeRoleAWSCredentials(source, "arn:aws:iam::123456789012:role/my-role", "my-session");
var s3 = new AmazonS3Client(credentials);
```

## When the SDK needs this package

The SDK calls STS for you when a profile sets `role_arn`, when credentials come from a web identity token file, or when you use SAML federation through AD FS. Your project must reference `AWSSDK.SecurityToken` for those to work, even if your code never uses the client.

## Resources

- [Temporary security credentials](https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html)
- [Credential and profile resolution](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/creds-assign.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
