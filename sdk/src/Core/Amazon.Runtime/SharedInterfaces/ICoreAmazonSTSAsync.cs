using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces
{
#if AWS_ASYNC_API
    /// <summary>
    /// ICoreAmazonSTSAsync is not meant to be used directly. It defines Security Token
    /// service with basic .NET types and allows other services to be able to use the service as
    /// a runtime dependency. This interface is implemented by the AmazonSecurityTokenServiceClient
    /// defined in the AWSSDK.SecurityToken assembly.
    /// </summary>
    public interface ICoreAmazonSTSAsync
    {
        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon Security Token
        /// service within other service assemblies.
        /// Please use AmazonSecurityTokenServiceClient to access the Amazon Security Token
        /// service instead.
        /// </para>
        /// Use Amazon Security Token Service to assume a role.
        /// <remarks>
        /// Proxy settings that are required for the HTTPS and STS calls made during the authentication/credential
        /// generation process are supported and should have been configured on the STS ClientConfig instance
        /// associated with the STS client instance exposing this interface.
        /// </remarks>
        /// </summary>
        /// <param name="roleArn">The Amazon Resource Name (ARN) of the role to assume.</param>
        /// <param name="roleSessionName"> An identifier for the assumed role session.</param>
        /// <param name="options">Options to be used in the call to AssumeRole.</param>
        /// <returns></returns>
        Task<AssumeRoleImmutableCredentials> CredentialsFromAssumeRoleAuthenticationAsync(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options);
    }
#endif
}
