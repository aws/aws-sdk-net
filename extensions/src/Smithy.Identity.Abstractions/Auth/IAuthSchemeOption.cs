namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// The output from the authentication scheme resolver. The resolver returns a list of auth scheme options, 
    /// in the order that they should be used.
    /// </summary>
    public interface IAuthSchemeOption
    {
        /// <summary>
        /// The ID of the scheme to use. This value matches the one returned by <see cref="IAuthScheme{T}.SchemeId"/>.
        /// </summary>
        string SchemeId { get; set; }
    }
}
