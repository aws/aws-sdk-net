## When the SDK needs this package

The SDK uses this package to resolve credentials for profiles that sign in through IAM Identity Center (for example, profiles created with `aws configure sso`). Your project must reference both `AWSSDK.SSO` and `AWSSDK.SSOOIDC` for those profiles to work, even if your code never uses the client.

## Resources

- [Single sign-on with the AWS SDK for .NET](https://docs.aws.amazon.com/sdk-for-net/v4/developer-guide/sso.html)
