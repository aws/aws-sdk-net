namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// An identity resolver is a component that is able to resolve a customer's <see cref="BaseIdentity"/>.
    /// It might load the identity from:
    /// <list type="bullet">
    /// <item>Remote service (e.g. AWS Security Token Service)</item>
    /// <item>Local service (e.g. Instance Metadata Service)</item>
    /// <item>Local disk (e.g. configuration file)</item>
    /// <item>Local memory (e.g. environment variables)</item>
    /// </list>
    /// </summary>
    public interface IIdentityResolver
    {
        /// <summary>
        /// Loads the customer's identity for this resolver. 
        /// If the identity cannot be resolved an exception will be thrown.
        /// </summary>
        BaseIdentity ResolveIdentity();
    }
}
