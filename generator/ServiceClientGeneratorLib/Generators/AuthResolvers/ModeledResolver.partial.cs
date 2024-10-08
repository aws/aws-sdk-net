using System.Collections.Generic;
using System.Linq;

namespace ServiceClientGenerator.Generators.AuthResolvers
{
    public partial class ModeledResolver
    {
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
    }
}
