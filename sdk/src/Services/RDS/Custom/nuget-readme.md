## IAM database authentication

Besides the client shown above, the package includes `RDSAuthTokenGenerator`. It creates the authentication token that you use instead of a password to connect to a database that has IAM database authentication enabled.

```csharp
using Amazon.RDS.Util;

var token = await RDSAuthTokenGenerator.GenerateAuthTokenAsync("mydb.123456789012.us-east-1.rds.amazonaws.com", 5432, "db_user");
```

When you don't pass credentials or a Region, the SDK uses its standard search, which includes the default profile and the compute environment settings. A token is valid for 15 minutes; a connection request with an expired token is denied.

## Resources

- [IAM database authentication](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html)
- [Connecting using IAM authentication and the AWS SDK for .NET](https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.Connecting.NET.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
