using System.Collections.Generic;
using System.Linq;

namespace ServiceClientGenerator.Generators.AuthResolvers
{
    public partial class ModeledResolver
    {
        private readonly HashSet<string> _allowListedServices = new HashSet<string>
        {
            "S3",
            "EventBridge",
            "SimpleEmailServiceV2",
            "CloudFrontKeyValueStore",
        };

        /// <summary>
        /// Returns whether the generated resolver should delegate auth scheme resolution to the endpoints resolver.
        /// </summary>
        private bool IsServiceAllowListedForRulesBasedResolver() => 
            _allowListedServices.Contains(Config.ClassName);

        /// <summary>
        /// Returns whether this service supports SigV4 (and therefore should include region in its auth scheme parameters).
        /// </summary>
        private bool IsSigV4Supported() => 
            Config.ServiceModel.AuthSchemes != null && Config.ServiceModel.AuthSchemes.Contains(AuthenticationScheme.SigV4);

        /// <summary>
        /// Returns the list of auth schemes supported by the service.
        /// </summary>
        private IEnumerable<string> GetServiceAuthSchemes()
        {
            if (Config.ServiceModel.AuthSchemes == null || !Config.ServiceModel.AuthSchemes.Any())
            {
                return new List<string> { AuthenticationScheme.NoAuth };
            }

            return Config.ServiceModel.AuthSchemes.Select(s => s.ToString());
        }

        /// <summary>
        /// Returns the operations which have auth schemes defined (they'll override the service-level auth schemes if
        /// not null).
        /// </summary>
        private IEnumerable<Operation> GetOperationsWithAuthSchemes() => 
            Config.ServiceModel.Operations.Where(o => o.AuthSchemes != null);

        /// <summary>
        /// If the provided authentication schemes are known, we'll use one of the static lists defined in the Core project.
        /// </summary>
        private bool IsKnownSchemeList(IEnumerable<string> authSchemes, out string content)
        {
            content = string.Empty;

            if (Enumerable.SequenceEqual(authSchemes, AuthenticationScheme.SigV4Schemes))
            {
                content = "AuthSchemeOption.DEFAULT_SIGV4";
                return true;
            }

            if (Enumerable.SequenceEqual(authSchemes, AuthenticationScheme.SigV4ASchemes))
            {
                content = "AuthSchemeOption.DEFAULT_SIGV4A";
                return true;
            }

            if (Enumerable.SequenceEqual(authSchemes, AuthenticationScheme.SigV4AndSigV4ASchemes))
            {
                content = "AuthSchemeOption.DEFAULT_SIGV4_SIGV4A";
                return true;
            }

            if (Enumerable.SequenceEqual(authSchemes, AuthenticationScheme.BearerSchemes))
            {
                content = "AuthSchemeOption.DEFAULT_BEARER";
                return true;
            }

            if (Enumerable.SequenceEqual(authSchemes, AuthenticationScheme.NoAuthSchemes))
            {
                content = "AuthSchemeOption.DEFAULT_NOAUTH";
                return true;
            }

            return false;
        }
    }
}
