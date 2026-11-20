## Authentication tokens

Besides the client shown above, the package includes `DSQLAuthTokenGenerator`. It creates the authentication token that you use as the password to connect to Aurora DSQL with a SQL client.

```csharp
using Amazon.DSQL.Util;

var token = await DSQLAuthTokenGenerator.GenerateDbConnectAdminAuthTokenAsync("<cluster-id>.dsql.us-east-1.on.aws");
```

`GenerateDbConnectAdminAuthToken` is for connecting with the `admin` role; use `GenerateDbConnectAuthToken` for a custom database role. When you don't pass credentials or a Region, the SDK uses its standard search, which includes the default profile and the compute environment settings. A token expires in 15 minutes unless you pass `expiresIn`.

## Resources

- [Generating an authentication token in Amazon Aurora DSQL](https://docs.aws.amazon.com/aurora-dsql/latest/userguide/SECTION_authentication-token.html)
- [API Reference](https://docs.aws.amazon.com/sdkfornet/v4/apidocs/)
