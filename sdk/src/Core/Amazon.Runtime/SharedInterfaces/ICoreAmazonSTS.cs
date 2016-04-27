using System;
using System.Net;

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// ICoreAmazonSTS is not meant to use directly. It defines Security Token
    /// service with basic .NET types and allows other services to be able to use the service as 
    /// a runtime dependency. This interface is implemented by the AmazonSecurityTokenServiceClient 
    /// defined in the AWSSDK.SecurityToken assembly.
    /// </summary>
    public interface ICoreAmazonSTS
    {
#if BCL
        /// <summary>
        /// Authenticates against a federated identity endpoint supporting SAML and returns 
        /// temporary AWS credentials for the supplied role. 
        /// </summary>
        /// <param name="endpoint">The endpoint for the federated identity provider</param>
        /// <param name="authenticationType">The authentication type to use (NTLM, Kerberos etc)</param>
        /// <param name="roleARN">The ARN of the role the user is to assume following authentication</param>
        /// <param name="credentialDuration">TTL duration for the generated credentials.</param>
        /// <param name="userCredential">
        /// Optional; alternate user credential for authentication. If null the identity of the
        /// current process is used.
        /// </param>
        /// <returns>Generated credential data, including SAML-related information such as subject.</returns>
        /// <remarks>
        /// Proxy settings that are required for the HTTPS and STS calls made during the authentication/credential
        /// generation process are supported and should have been configured on the STS ClientConfig instance 
        /// associated with the STS client instance exposing this interface.
        /// </remarks>
        SAMLImmutableCredentials CredentialsFromSAMLAuthentication(string endpoint,
                                                                   string authenticationType,
                                                                   string roleARN,
                                                                   TimeSpan credentialDuration,
                                                                   ICredentials userCredential);
#endif
    }
}
