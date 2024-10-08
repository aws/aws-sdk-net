using System.Collections.Generic;

namespace Smithy.Identity.Abstractions
{
    /// <summary>
    /// <para>
    /// An authentication scheme resolver is an entity within the SDK that determines which authentication scheme to use 
    /// for a service.
    /// </para>
    /// 
    /// <para>
    /// It accepts data from the request (e.g. request members) and client (e.g. AWS region) and returns a list of
    /// authentication scheme options that the SDK should use when authenticating that request.
    /// </para>
    /// </summary>
    public interface IAuthSchemeResolver<T> where T : IAuthSchemeParameters
    {
        /// <summary>
        /// Resolve the authentication scheme that should be used. This is invoked once per SDK request, <i>before</i> endpoint resolution.
        /// </summary>
        /// <returns>
        /// <para>
        /// A list of authentication schemes, in order of preference, that should be used for the request.
        /// </para>
        /// <para>
        /// The SDK will choose the first scheme it supports, or fail the request if no schemes are supported.
        /// </para>
        /// </returns>
        List<IAuthSchemeOption> ResolveAuthScheme(T authParameters);
    }
}
