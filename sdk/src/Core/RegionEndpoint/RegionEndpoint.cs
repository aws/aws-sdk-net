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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
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

        private static Dictionary<string, RegionEndpoint> _hashBySystemName = new Dictionary<string, RegionEndpoint>(StringComparer.OrdinalIgnoreCase);
        private static ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim();

        private static HashSet<string> _allPartitionRegionRegex = new HashSet<string>();

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

        public static IEnumerable<string> AllPartitionRegionRegex
        {
            get
            {
                try
                {
                    _readerWriterLock.EnterReadLock();
                    return _allPartitionRegionRegex.ToList();
                }
                finally
                {
                    _readerWriterLock.ExitReadLock();
                }
            }
        }

        private static RegionEndpoint GetRegionEndpoint(string systemName, string displayName, string partitionName, string partitionDnsSuffix, string partitionRegionRegex, string hostnameTemplate)
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

                regionEndpoint = new RegionEndpoint(systemName, displayName, partitionName, partitionDnsSuffix, partitionRegionRegex, hostnameTemplate);
                _hashBySystemName.Add(systemName, regionEndpoint);
                _allPartitionRegionRegex.Add(partitionRegionRegex);

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
            string regionDescription = null;
            try
            {
                _readerWriterLock.EnterReadLock();

                if (_hashBySystemName.TryGetValue(systemName, out var regionEndpoint))
                    return regionEndpoint;

                similarRegionEndpoint = _hashBySystemName.Values
                    .FirstOrDefault(r => 
                                    IsRegionInPartition(systemName, r.PartitionName,
                                    r.PartitionRegionRegex,
                                    out regionDescription));

                if (similarRegionEndpoint == null)
                {
                    // If we couldn't find similar region we will assume it belongs to aws partition.
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
                    regionDescription ?? GetUnknownRegionDescription(systemName),
                    similarRegionEndpoint.PartitionName,
                    similarRegionEndpoint.PartitionDnsSuffix,
                    similarRegionEndpoint.PartitionRegionRegex,
                    similarRegionEndpoint.HostnameTemplate);
        }

        private static bool IsRegionInPartition(string regionName, string partitionName, string partitionRegionPattern, out string description)
        {
            // see if the region is global region by concatenating the partition and "-global" to construct the global name 
            // for the partition
            if (regionName.Equals(string.Concat((string)partitionName, "-global"), StringComparison.OrdinalIgnoreCase))
            {
                description = "Global";
                return true;
            }

            // no region key in the entry, but it matches the pattern in this partition.
            // we can try to construct an endpoint based on the heuristics.
            else if (new Regex(partitionRegionPattern).Match(regionName).Success)
            {
                description = GetUnknownRegionDescription(regionName);
                return true;
            }

            else
            {
                description = GetUnknownRegionDescription(regionName);
                return false;
            }
        }

        private static string GetUnknownRegionDescription(string regionName)
        {
            if (regionName.StartsWith("cn-", StringComparison.OrdinalIgnoreCase) ||
                regionName.EndsWith("cn-global", StringComparison.OrdinalIgnoreCase))
            {
                return "China (Unknown)";
            }
            else
            {
                return "Unknown";
            }
        }

        #endregion

        public string SystemName { get; private set; }
        public string DisplayName { get; private set; }
        public string PartitionName { get; private set; }
        public string PartitionDnsSuffix { get; private set; }
        public string PartitionRegionRegex { get; private set; }
        public string HostnameTemplate { get; private set; }

        private RegionEndpoint(string systemName, string displayName, string partitionName, string partitionDnsSuffix, string partitionRegionRegex, string hostnameTemplate)
        {
            SystemName = systemName;
            DisplayName = displayName;
            PartitionName = partitionName;
            PartitionDnsSuffix = partitionDnsSuffix;
            PartitionRegionRegex = partitionRegionRegex;
            HostnameTemplate = hostnameTemplate;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", this.DisplayName, this.SystemName);
        }
    }
}
