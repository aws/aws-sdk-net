namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// <para>
    /// Authentication schemes represent a way that the service will authenticate the customer's
    /// identity. An authentication scheme consists of an ID (e.g. "aws.auth#sigv4"), logic to 
    /// determine the identity resolver, and a signer matching the authentication type.
    /// </para>
    /// 
    /// <para>
    /// For example, the "aws.auth#sigv4" authentication scheme selects the identity resolver for 
    /// AWS credentials and the AWS SigV4 signer.
    /// </para>
    /// </summary>
    public interface IAuthScheme<out T> where T : BaseIdentity
    {
        /// <summary>
        /// Unique identifier for the authentication scheme (e.g. "smithy.api#noAuth" or "aws.auth#sigv4").
        /// </summary>
        string SchemeId { get; }

        /// <summary>
        /// Retrieves the identity resolver associated with this authentication scheme.
        /// </summary>
        IIdentityResolver GetIdentityResolver(IIdentityResolverConfiguration configuration);

        // TODO: Include methods to retrieve signer for the current scheme.
    }
}
