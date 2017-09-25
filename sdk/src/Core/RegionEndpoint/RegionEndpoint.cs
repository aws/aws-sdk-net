/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
using Amazon.Internal;
using Amazon.Runtime.Internal.Auth;
using System;
using System.Collections.Generic;
using System.Globalization;

#if UNITY
using UnityEngine;
using Amazon.Runtime.Internal;
#endif

namespace Amazon
{
    /// <summary>
    /// This class contains region information used to lazily compute the service endpoints. The static constants representing the 
    /// regions can be used while constructing the AWS client instead of looking up the exact endpoint URL.
    /// </summary>
    public partial class RegionEndpoint
    {
        #region Statics
        private static Dictionary<string, RegionEndpoint> _hashBySystemName = new Dictionary<string, RegionEndpoint>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// The US East (Virginia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast1 = NewEndpoint("us-east-1", "US East (Virginia)");

        /// <summary>
        /// The US East (Ohio) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast2 = NewEndpoint("us-east-2", "US East (Ohio)");

        /// <summary>
        /// The US West (N. California) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest1 = NewEndpoint("us-west-1", "US West (N. California)");

        /// <summary>
        /// The US West (Oregon) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest2 = NewEndpoint("us-west-2", "US West (Oregon)");

        /// <summary>
        /// The EU West (Ireland) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest1 = NewEndpoint("eu-west-1", "EU West (Ireland)");

        /// <summary>
        /// The EU West (London) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest2 = NewEndpoint("eu-west-2", "EU West (London)");

        /// <summary>
        /// The EU Central (Frankfurt) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUCentral1 = NewEndpoint("eu-central-1", "EU Central (Frankfurt)");

        /// <summary>
        /// The Asia Pacific (Tokyo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast1 = NewEndpoint("ap-northeast-1", "Asia Pacific (Tokyo)");

        /// <summary>
        /// The Asia Pacific (Seoul) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast2 = NewEndpoint("ap-northeast-2", "Asia Pacific (Seoul)");

        /// <summary>
        /// The Asia Pacific (Mumbai) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSouth1 = NewEndpoint("ap-south-1", "Asia Pacific (Mumbai)");

        /// <summary>
        /// The Asia Pacific (Singapore) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast1 = NewEndpoint("ap-southeast-1", "Asia Pacific (Singapore)");

        /// <summary>
        /// The Asia Pacific (Sydney) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast2 = NewEndpoint("ap-southeast-2", "Asia Pacific (Sydney)");

        /// <summary>
        /// The South America (Sao Paulo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint SAEast1 = NewEndpoint("sa-east-1", "South America (Sao Paulo)");

        /// <summary>
        /// The US GovCloud West (Oregon) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudWest1 = NewEndpoint("us-gov-west-1", "US GovCloud West (Oregon)");

        /// <summary>
        /// The China (Beijing) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CNNorth1 = NewEndpoint("cn-north-1", "China (Beijing)");

        /// <summary>
        /// The Canada (Central) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CACentral1 = NewEndpoint("ca-central-1", "Canada (Central)");

        /// <summary>
        /// Enumerate through all the regions.
        /// </summary>
        public static IEnumerable<RegionEndpoint> EnumerableAllRegions
        {
            get
            {
                List<RegionEndpoint> list = new List<RegionEndpoint>();
                foreach (IRegionEndpoint endpoint in RegionEndpointProvider.AllRegionEndpoints)
                {
                    RegionEndpoint val;
                    if (!_hashBySystemName.TryGetValue(endpoint.RegionName, out val))
                    {
                        val = NewEndpoint(endpoint.RegionName, endpoint.DisplayName);
                    }
                    list.Add(val);
                }
                return list;
            }
        }

        /// <summary>
        /// Gets the region based on its system name like "us-west-1"
        /// </summary>
        /// <param name="systemName">The system name of the service like "us-west-1"</param>
        /// <returns></returns>
        public static RegionEndpoint GetBySystemName(string systemName)
        {
            RegionEndpoint region = null;
            if (_hashBySystemName.TryGetValue(systemName, out region))
                return region;

            IRegionEndpoint regionEndpointFromProvider = RegionEndpointProvider.GetRegionEndpoint(systemName);

            // We received an instance of IRegionEndpoint from a provider,
            // now we should wrap it in RegionEndpoint before returning the data back to the client code.
            // GetRegionEndpoint will always return a non-null value. If the the region(systemName) is unknown,
            // the providers will create a fallback instance that will generate an endpoint to the best
            // of its knowledge.
            return NewEndpoint(systemName, regionEndpointFromProvider.DisplayName);
        }

        private static RegionEndpoint NewEndpoint(string systemName, string displayName)
        {
            var regionEndpoint = new RegionEndpoint(systemName, displayName);
            _hashBySystemName.Add(regionEndpoint.SystemName, regionEndpoint);
            return regionEndpoint;
        }

        private static IRegionEndpointProvider _regionEndpointProvider;
        private static IRegionEndpointProvider RegionEndpointProvider
        {
            get
            {
                if (_regionEndpointProvider == null)
                {
                    // If the existing customer provided the endpoints.json file via
                    // <aws endpointDefinition=""/>, it's in v2 format.  We we will create
                    // a v2 provider which does a fall through during LoadEndpointDefinitions()
                    // and loads from the override file provided by the user.
                    //
                    // Else, we are loading from the assembly resource.  In which case we use the 
                    // latest provider.
                    //
                    // It's actually a bug that _regionEndpointProvider is a static member variable
                    // since the IEndpointProvider should respect the AWSConfigs.EndpointDefinition
                    // _at_ the time of the service client instantiation.  However, since this is
                    // the existing behavior with v2 endpoint file format, we will preserve this behavior as is.
                    if (!string.IsNullOrEmpty(AWSConfigs.EndpointDefinition))
                    {
                        _regionEndpointProvider = new RegionEndpointProviderV2();
                    }
                    else
                    {
                        _regionEndpointProvider = new RegionEndpointProviderV3();
                    }
                }
                return _regionEndpointProvider;
            }
        }
        #endregion

        private RegionEndpoint(string systemName, string displayName)
        {
            this.SystemName = systemName;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets the system name of a region.
        /// </summary>
        public string SystemName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the display name of a region.
        /// </summary>
        public string DisplayName
        {
            get;
            private set;
        }

        private IRegionEndpoint InternedRegionEndpoint
        {
            get
            {
                return RegionEndpointProvider.GetRegionEndpoint(SystemName);
            }
        }

        /// <summary>
        /// Gets the endpoint for a service in a region.
        /// </summary>
        /// <param name="serviceName">
        /// The services system name. Service system names can be obtained from the
        /// RegionEndpointServiceName member of the ClientConfig-derived class for the service.
        /// </param>
        /// <exception cref="System.ArgumentException">Thrown when the request service does not have a valid endpoint in the region.</exception>
        /// <returns></returns>
        public Endpoint GetEndpointForService(string serviceName)
        {
            return GetEndpointForService(serviceName, false);
        }

        /// <summary>
        /// Gets the endpoint for a service in a region, optionally selecting a dualstack compatible endpoint.
        /// </summary>
        /// <param name="serviceName">
        /// The services system name. Service system names can be obtained from the
        /// RegionEndpointServiceName member of the ClientConfig-derived class for the service.
        /// </param>
        /// <param name="dualStack">
        /// If true a dualstack endpoint is returned. It is the user's responsibility to verify that the given service
        /// supports a dualstack endpoint for the region.
        /// </param>
        /// <exception cref="System.ArgumentException">Thrown when the request service does not have a valid endpoint in the region.</exception>
        /// <returns></returns>
        public Endpoint GetEndpointForService(string serviceName, bool dualStack)
        {
            return InternedRegionEndpoint.GetEndpointForService(serviceName, dualStack);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", this.DisplayName, this.SystemName);
        }

        /// <summary>
        /// This class defines an endpoints hostname and which protocols it supports.
        /// </summary>
        public class Endpoint
        {
            internal Endpoint(string hostname, string authregion, string signatureVersionOverride)
            {
                this.Hostname = hostname;
                this.AuthRegion = authregion;
                this.SignatureVersionOverride = signatureVersionOverride;
            }

            /// <summary>
            /// Gets the hostname for the service.
            /// </summary>
            public string Hostname
            {
                get;
                private set;
            }

            /// <summary>
            /// The authentication region to be used in request signing.
            /// </summary>
            public string AuthRegion
            {
                get;
                private set;
            }

            public override string ToString()
            {
                return this.Hostname;
            }

            /// <summary>
            /// This property is only set for S3 endpoints.  For all other services this property returns null.
            /// For S3 endpoints, if the endpoint supports signature version 2 this property will be "2", otherwise it will be "4".
            /// </summary>
            public string SignatureVersionOverride
            {
                get;
                private set;
            }
        }
    }
}
