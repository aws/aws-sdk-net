namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// <para>
    /// The input to the authentication scheme resolver. A code-generated interface for passing 
    /// in the data required for determining the authentication scheme.
    /// </para>
    /// </summary>
    /// <remarks>
    /// Service specific implementations may include additional properties, for example "region" if the
    /// service is configured to use SigV4.
    /// </remarks>
    public interface IAuthSchemeParameters
    {
        /// <summary>
        /// The service operation being invoked by the SDK.
        /// </summary>
        /// <remarks>
        /// This is included by default for all generated authentication scheme parameters.
        /// </remarks>
        string Operation { get; set; }
    }
}
