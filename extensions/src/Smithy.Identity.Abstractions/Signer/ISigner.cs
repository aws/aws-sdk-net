namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// <para>
    /// A signer is an entity within the SDK representing a way to generate a signature for a request.
    /// </para>
    /// <para>
    /// A signature is metadata attached to a request that will be sent to the service in order to allow
    /// the service to authenticate the SDK customer's identity.
    /// </para>
    /// </summary>
    public interface ISigner
    {
        // TODO: This is a marker interface at the moment since the signers defined in the SDK
        // currently reference internal types that need to be extracted / refactored (e.g. IRequest).
    }
}
