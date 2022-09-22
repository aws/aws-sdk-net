/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using ThirdParty.Json.LitJson;

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
        private static ReaderWriterLockSlim _regionEndpointOverrideLock = new ReaderWriterLockSlim(); // controls access to _hashRegionEndpointOverride

        /// <summary>
        /// Represents the endpoint overridding rules in the endpoints.json
        /// Is used to map private region (ie us-east-1-regional) to public regions (us-east-1)
        /// For signing purposes. Map is keyed by region SystemName.
        /// </summary>
        private static Dictionary<string, RegionEndpoint> _hashRegionEndpointOverride = new Dictionary<string, RegionEndpoint>();

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
                    list.Add(GetEndpoint(endpoint.RegionName, endpoint.DisplayName));
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
            return GetEndpoint(systemName, null);
        }

        /// <summary>
        /// Gets the region endpoint override if exists
        /// </summary>
        /// <param name="regionEndpoint">The region endpoint to find the possible override for</param>
        /// <returns></returns>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public static RegionEndpoint GetRegionEndpointOverride(RegionEndpoint regionEndpoint)
        {
            try
            {
                _regionEndpointOverrideLock.EnterReadLock();

                if (!_hashRegionEndpointOverride.TryGetValue(regionEndpoint.SystemName,
                    out var regionEndpointOverride))
                {
                    return null;
                }

                return regionEndpointOverride;
            }
            finally
            {
                _regionEndpointOverrideLock.ExitReadLock();
            }
        }

        /// <summary>
        /// Force the SDK to load and apply the given endpoints details
        /// (eg: an updated endpoints.json file).
        /// Service clients created after this call will be set up with
        /// endpoints based on this information.
        ///
        /// This function should only be used at application startup, before
        /// creating service clients.
        ///
        /// Known Caveats:
        /// * static readonly fields (eg: <see cref="RegionEndpoint.USEast1"/>) are not updated.
        ///   If you use this function, you should use <see cref="RegionEndpoint.GetEndpoint"/> with
        ///   explicit region system names to ensure you work with RegionEndpoint objects containing
        ///   the reloaded data. RegionEndpoint objects returned from GetEndpoint will generally 
        ///   fail Equality comparisons against the static fields.
        /// * Service clients created before calling Reload have no guarantee around
        ///   which endpoint data will be used.
        /// </summary>
        /// <param name="stream">Stream containing an Endpoints manifest to reload in the SDK.
        /// Pass null in to reset the SDK, so that it uses its built-in manifest instead.</param>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public static void Reload(Stream stream)
        {
            if (stream == null)
            {
                _regionEndpointProvider = null;
            }
            else
            {
                JsonData rootData = null;
                using (StreamReader reader = new StreamReader(stream))
                {
                    rootData = JsonMapper.ToObject(reader);
                }

                var manifestVersion = rootData?["version"]?.ToString();
                if (manifestVersion == "3")
                {
                    _regionEndpointProvider = new RegionEndpointProviderV3(rootData);
                }
                else
                {
                    throw new NotSupportedException("Endpoints data format is not supported by reload");
                }
            }

            // Reset static lookup maps that may contain objects relating to old endpoint data
            lock (_hashBySystemName)
            {
                _hashBySystemName.Clear();

                // Add the .NET/S3-specific legacy region back to the lookup map
                GetEndpoint("us-east-1-regional", "US East (Virginia) regional");
            }

            ResetRegionEndpointOverride();
        }

        /// <summary>
        /// Rebuilds the endpoint override map, referencing the SDK's current Region Endpoint data.
        /// </summary>
        private static void ResetRegionEndpointOverride()
        {
            try
            {
                _regionEndpointOverrideLock.EnterWriteLock();

                _hashRegionEndpointOverride.Clear();
                _hashRegionEndpointOverride.Add(USEast1Regional.SystemName, GetEndpoint(USEast1.SystemName, null));
            }
            finally
            {
                _regionEndpointOverrideLock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Returns the DNS suffix for the given partition, or
        /// an empty string if a matching partition was not found in endpoints.json
        /// </summary>
        /// <param name="partition">partition</param>
        /// <returns>DNS suffix for the given partition, empty string if a matching partition was not found</returns>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public static string GetDnsSuffixForPartition(string partition)
        {
            return RegionEndpointProvider.GetDnsSuffixForPartition(partition);
        }

        private static RegionEndpoint GetEndpoint(string systemName, string displayName)
        {
            RegionEndpoint regionEndpoint = null;
            if (displayName == null)
            {
                lock (_hashBySystemName)
                {
                    if (_hashBySystemName.TryGetValue(systemName, out regionEndpoint))
                        return regionEndpoint;
                }

                // GetRegionEndpoint will always return a non-null value. If the the region(systemName) is unknown,
                // the providers will create a fallback instance that will generate an endpoint to the best
                // of its knowledge.
                displayName = RegionEndpointProvider.GetRegionEndpoint(systemName).DisplayName;
            }
            
            lock (_hashBySystemName)
            {
                if (_hashBySystemName.TryGetValue(systemName, out regionEndpoint))
                    return regionEndpoint;

                regionEndpoint = new RegionEndpoint(systemName, displayName);
                _hashBySystemName.Add(regionEndpoint.SystemName, regionEndpoint);
            }

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
            this.OriginalSystemName = systemName;
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

        [Obsolete("It should not be necessary to use this property.  To support upgrading to Endpoint Variants, " +
                  "ClientConfig will manipulate the assigned RegionEndpoint.  To support the Polly PreSigner, it's still necessary" +
                  "to check the OriginalSystemName to determine if a PseudoRegion was assigned.",error: false)]
        public string OriginalSystemName
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the display name of a region.
        /// </summary>
        public string DisplayName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the partition name the region is in. For example for us-east-1 the partition name is aws. For cn-northwest-1 the partition name is aws-cn.
        /// </summary>
        public string PartitionName
        {
            get
            {
                var regionEndpointV3 = this.InternedRegionEndpoint as RegionEndpointV3;
                return regionEndpointV3?.PartitionName;
            }
        }

        /// <summary>
        /// Gets the dns suffix for the region endpoints in a partition. For example the aws partition's suffix is amazonaws.com. The aws-cn partition's suffix is amazonaws.com.cn.
        /// </summary>
        public string PartitionDnsSuffix
        {
            get
            {
                var regionEndpointV3 = this.InternedRegionEndpoint as RegionEndpointV3;
                return regionEndpointV3?.PartitionDnsSuffix;
            }
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
        /// <param>
        /// For forwards compatibility, if the service being requested for isn't known in the region, this method 
        /// will generate an endpoint using the AWS endpoint heuristics. In this case, it is not guaranteed the
        /// endpoint will point to a valid service endpoint.
        /// </param>
        /// <returns></returns>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public Endpoint GetEndpointForService(string serviceName)
        {
            return GetEndpointForService(serviceName, new GetEndpointForServiceOptions());
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
        /// <param>
        /// For forwards compatibility, if the service being requested for isn't known in the region, this method 
        /// will generate an endpoint using the AWS endpoint heuristics. In this case, it is not guaranteed the
        /// endpoint will point to a valid service endpoint.
        /// </param>
        [Obsolete("Use GetEndpointForService(string serviceName, GetEndpointForServiceOptions options) instead", error: false)]
        public Endpoint GetEndpointForService(string serviceName, bool dualStack)
        {
            return GetEndpointForService(serviceName, new GetEndpointForServiceOptions {DualStack = dualStack});
        }

        /// <summary>
        /// Gets the endpoint for a service in a region.
        /// <para />
        /// For forwards compatibility, if the service being requested for isn't known in the region, this method 
        /// will generate an endpoint using the AWS endpoint heuristics. In this case, it is not guaranteed the
        /// endpoint will point to a valid service endpoint.
        /// </summary>
        /// <param name="serviceName">
        /// The services system name. Service system names can be obtained from the
        /// RegionEndpointServiceName member of the ClientConfig-derived class for the service.
        /// </param>
        /// <param name="options">
        /// Specify additional requirements on the <see cref="Endpoint"/> to be returned.
        /// </param>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public Endpoint GetEndpointForService(string serviceName, GetEndpointForServiceOptions options)
        {
            return InternedRegionEndpoint.GetEndpointForService(serviceName, options);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", this.DisplayName, this.SystemName);
        }

        /// <summary>
        /// This class defines an endpoints hostname and which protocols it supports.
        /// </summary>
        [Obsolete("This class is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint.")]
        public class Endpoint
        {
            internal Endpoint(string hostname, string authregion, string signatureVersionOverride, string dnsSuffix, bool deprecated)
            {
                this.Hostname = hostname;
                this.AuthRegion = authregion;
                this.SignatureVersionOverride = signatureVersionOverride;
                this.Deprecated = deprecated;
                this.DnsSuffix = dnsSuffix;
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
            /// Gets the DNS suffix for the service.
            /// </summary>
            public string DnsSuffix
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

            /// <summary>
            /// Gets the hostname for the service.
            /// </summary>
            public bool Deprecated
            {
                get;
                private set;
            }
        }
    }
}
