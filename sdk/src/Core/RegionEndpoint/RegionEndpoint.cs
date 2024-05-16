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
using System.Linq;
using System.Threading;

namespace Amazon
{
    /// <summary>
    /// This class contains region information used to lazily compute the service endpoints. The static constants representing the 
    /// regions can be used while constructing the AWS client instead of looking up the exact endpoint URL.
    /// </summary>
    public partial class RegionEndpoint
    {
        #region Statics

        /// <summary>
        /// A hardcoded list for regions that support SigV2 for S3 endpoints to preserve legacy behavior. 
        /// New regions shouldn't support SigV2 as it is a deprecated signature version.
        /// </summary>
        private static readonly HashSet<string> _sigV2SupportedRegions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "ap-northeast-1",
            "ap-southeast-1",
            "ap-southeast-2",
            "eu-west-1",
            "sa-east-1",
            "us-east-1",
            "us-west-1",
            "us-west-2",
        };

        private static Dictionary<string, RegionEndpoint> _hashBySystemName = new Dictionary<string, RegionEndpoint>(StringComparer.OrdinalIgnoreCase);
        private static ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim();

        private static HashSet<string> _allRegionRegex = new HashSet<string>();

        public static IEnumerable<RegionEndpoint> EnumerableAllRegions
        {
            get
            {
                try
                {
                    _readerWriterLock.EnterReadLock();
                    return _hashBySystemName.Values.ToList();
                }
                finally
                {
                    _readerWriterLock.ExitReadLock();
                }
            }
        }

        public static IEnumerable<string> AllRegionRegex
        {
            get
            {
                try
                {
                    _readerWriterLock.EnterReadLock();
                    return _allRegionRegex.ToList();
                }
                finally
                {
                    _readerWriterLock.ExitReadLock();
                }
            }
        }

        private static RegionEndpoint GetRegionEndpoint(string systemName, string displayName, string partitionName, string partitionDnsSuffix, string regionRegex, string hostnameTemplate)
        {
            try
            {
                _readerWriterLock.EnterReadLock();
                if (_hashBySystemName.TryGetValue(systemName, out var regionEndpoint))
                    return regionEndpoint;
            }
            finally
            {
                _readerWriterLock.ExitReadLock();
            }

            try
            {
                _readerWriterLock.EnterWriteLock();
                if (_hashBySystemName.TryGetValue(systemName, out var regionEndpoint))
                    return regionEndpoint;

                regionEndpoint = new RegionEndpoint(systemName, displayName, partitionName, partitionDnsSuffix, regionRegex, hostnameTemplate);
                _hashBySystemName.Add(systemName, regionEndpoint);
                _allRegionRegex.Add(regionRegex);

                return regionEndpoint;
            }
            finally
            {
                _readerWriterLock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Gets the region based on its system name like "us-west-1"
        /// </summary>
        /// <param name="systemName">The system name of the service like "us-west-1"</param>
        /// <returns></returns>
        public static RegionEndpoint GetBySystemName(string systemName)
        {
            RegionEndpoint similarRegionEndpoint = null;
            try
            {
                _readerWriterLock.EnterReadLock();

                if (_hashBySystemName.TryGetValue(systemName, out var regionEndpoint))
                    return regionEndpoint;

                similarRegionEndpoint = _hashBySystemName.Values.FirstOrDefault(r => systemName.Contains(r.SystemName));
                if (similarRegionEndpoint == null)
                {
                    // If we couldn't find similar region we wil assume it belongs to aws partition.
                    similarRegionEndpoint = _hashBySystemName.Values.First(r => r.PartitionName == "aws");
                }
            }
            finally
            {
                _readerWriterLock.ExitReadLock();
            }
            // Assume the queried region is probably a variant of the similar region and belongs to the same
            // partition of the similar region, we can use the similar region values to add it to the endpoints.
            return GetRegionEndpoint(
                    systemName,
                    "Unknown",
                    similarRegionEndpoint.PartitionName,
                    similarRegionEndpoint.PartitionDnsSuffix,
                    similarRegionEndpoint.SystemName,
                    similarRegionEndpoint.HostnameTemplate);
        }

        /// <summary>
        /// Gets the region endpoint override if exists
        /// </summary>
        /// <param name="regionEndpoint">The region endpoint to find the possible override for</param>
        /// <returns></returns>
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint, use the service-specific client.DetermineServiceOperationEndPoint method instead.")]
        public static RegionEndpoint GetRegionEndpointOverride(RegionEndpoint regionEndpoint)
        {
            // We only override the .NET/S3-specific legacy USEast1Regional region
            if (regionEndpoint.SystemName == USEast1Regional.SystemName)
                return GetBySystemName(USEast1.SystemName);

            return null;
        }

        #endregion

        public string SystemName { get; private set; }
        public string DisplayName { get; private set; }
        public string PartitionName { get; private set; }
        public string PartitionDnsSuffix { get; private set; }
        public string RegionRegex { get; private set; }
        public string HostnameTemplate { get; private set; }

        private RegionEndpoint(string systemName, string displayName, string partitionName, string partitionDnsSuffix, string regionRegex, string hostnameTemplate)
        {
            SystemName = systemName;
            DisplayName = displayName;
            PartitionName = partitionName;
            PartitionDnsSuffix = partitionDnsSuffix;
            RegionRegex = regionRegex;
            HostnameTemplate = hostnameTemplate;
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
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint, use the service-specific client.DetermineServiceOperationEndPoint method instead.")]
        public Endpoint GetEndpointForService(string serviceName)
        {
            return GetEndpointForService(serviceName, new GetEndpointForServiceOptions());
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
        [Obsolete("This operation is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint, use the service-specific client.DetermineServiceOperationEndPoint method instead.")]
        public Endpoint GetEndpointForService(string serviceName, GetEndpointForServiceOptions options)
        {
            // Do a fallback of creating an unknown endpoint based on the
            // current region's hostname template.

            string hostname = HostnameTemplate.Replace("{service}", serviceName)
                                 .Replace("{region}", SystemName)
                                 .Replace("{dnsSuffix}", PartitionDnsSuffix);

            var signatureVersionOverride = 
                (serviceName == "s3" && _sigV2SupportedRegions.Contains(SystemName)) ? "2" : null;

            return new RegionEndpoint.Endpoint(hostname, null, signatureVersionOverride, PartitionDnsSuffix, deprecated: false);
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", this.DisplayName, this.SystemName);
        }

        /// <summary>
        /// This class defines an endpoints hostname and which protocols it supports.
        /// </summary>
        [Obsolete("This class is obsoleted because as of version 3.7.100 endpoint is resolved using a newer system that uses request level parameters to resolve the endpoint, use the service-specific client.DetermineServiceOperationEndPoint method instead.")]
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
