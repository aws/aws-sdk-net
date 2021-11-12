using Amazon.Runtime;

namespace Amazon.Internal
{
    /// <summary>
    /// Customizations for <see cref="IRegionEndpoint.GetEndpointForService(string,GetEndpointForServiceOptions)"/>
    /// </summary>
    public class GetEndpointForServiceOptions
    {
        /// <summary>
        /// If true a dualstack endpoint is returned. It is the user's responsibility to verify that the given service
        /// supports a dualstack endpoint for the region.
        /// </summary>
        public bool DualStack { get; set; }
        /// <summary>
        /// If true an endpoint that supports FIPS is returned.  It is the user's responsibility to verify that the given service
        /// supports a FIPS endpoint for the region.  For background, see https://aws.amazon.com/compliance/fips/
        /// </summary>
        public bool FIPS { get; set; }
    }

    public static class GetEndpointForServiceOptionsExtensions
    {
        public static GetEndpointForServiceOptions ToGetEndpointForServiceOptions(this IClientConfig config)
        {
            return new GetEndpointForServiceOptions
            {
                DualStack = config.UseDualstackEndpoint,
                FIPS = config.UseFIPSEndpoint
            };
        }

        public static RegionEndpoint.Endpoint GetEndpointForService(this RegionEndpoint endpoint, IClientConfig config)
        {
            return endpoint.GetEndpointForService(config.RegionEndpointServiceName, config.ToGetEndpointForServiceOptions());
        }
    }
}