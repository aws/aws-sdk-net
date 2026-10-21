/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Endpoints;
using Amazon.Util.Internal;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Amazon.Runtime.Internal.Endpoints.StandardLibrary
{
    /// <summary>
    /// Internal implementation of partition related data.
    /// Used by standard library functions to access partition related data.
    /// </summary>
    public partial class Partition : PropertyBag
    {
        public override object this[string propertyName]
        {
            get => propertyName switch
            {
                "name" => name,
                "dnsSuffix" => dnsSuffix,
                "dualStackDnsSuffix" => dualStackDnsSuffix,
                "supportsFIPS" => supportsFIPS,
                "supportsDualStack" => supportsDualStack,
                "implicitGlobalRegion" => implicitGlobalRegion,
                _ => base[propertyName],
            };
            set
            {
                switch (propertyName)
                {
                    case "name": name = (string)value; break;
                    case "dnsSuffix": dnsSuffix = (string)value; break;
                    case "dualStackDnsSuffix": dualStackDnsSuffix = (string)value; break;
                    case "supportsFIPS": supportsFIPS = (bool)value; break;
                    case "supportsDualStack": supportsDualStack = (bool)value; break;
                    case "implicitGlobalRegion": implicitGlobalRegion = (string)value; break;
                    default: base[propertyName] = value; break;
                }
            }
        }

        /// <summary>
        /// Partition Name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Partition DNS suffix
        /// </summary>
        public string dnsSuffix { get; set; }

        /// <summary>
        /// Partition IPv6 DNS suffix
        /// </summary>
        public string dualStackDnsSuffix { get; set; }

        /// <summary>
        /// Partition supports FIPS
        /// </summary>
        public bool supportsFIPS { get; set; }

        /// <summary>
        /// Partition supports IPv6
        /// </summary>
        public bool supportsDualStack { get; set; }

        /// <summary>
        /// The region used by partitional (non-regionalized/global) services for signing.
        /// </summary>
        public string implicitGlobalRegion { get; set; }

        /// <summary>
        /// Builds Partition from PartitionAttributesShape
        /// </summary>
        internal static Partition FromPartitionData(PartitionAttributesShape data)
        {
            return new Partition
            {
                name = data.name,
                dnsSuffix = data.dnsSuffix,
                dualStackDnsSuffix = data.dualStackDnsSuffix,
                supportsFIPS = data.supportsFIPS,
                supportsDualStack = data.supportsDualStack,
                implicitGlobalRegion = data.implicitGlobalRegion,
            };
        }

        private static readonly ReaderWriterLockSlim _locker = new ReaderWriterLockSlim();
        private static Dictionary<string, PartitionAttributesShape> _partitionsByRegionName = new Dictionary<string, PartitionAttributesShape>();
        private static List<(Regex Regex, PartitionAttributesShape Partition)> _partitionsByRegex = new List<(Regex, PartitionAttributesShape)>();
        private static PartitionAttributesShape _defaultPartition;

        /// <summary>
        /// Override partitions data from json file
        /// </summary>
        public static void LoadPartitions(string partitionsFile)
        {
            if (!File.Exists(partitionsFile))
            {
                throw new AmazonClientException($"Can't find partitions file: {partitionsFile}");
            }
            _locker.EnterWriteLock();
            try
            {
                var json = File.ReadAllText(partitionsFile);
                var partitions = JsonSerializerHelper.Deserialize<PartitionFunctionShape>(json, PartitionFunctionShapeJsonSerializerContexts.Default);
                _partitionsByRegionName.Clear();
                _partitionsByRegex.Clear();
                _defaultPartition = null;
                foreach (var partition in partitions.partitions)
                {
                    if (partition.id == "aws")
                    {
                        _defaultPartition = partition.outputs;
                    }
                    _partitionsByRegex.Add((new Regex(partition.regionRegex, RegexOptions.Compiled), partition.outputs));
                    foreach (var region in partition.regions.Keys)
                    {
                        _partitionsByRegionName.Add(region, partition.outputs);
                    }
                }
            }
            finally
            {
                _locker.ExitWriteLock();
            }
        }

        internal static Partition GetPartitionByRegion(string region)
        {
            _locker.EnterReadLock();
            try
            {
                PartitionAttributesShape partition;
                // direct match
                if (_partitionsByRegionName.TryGetValue(region, out partition))
                {
                    return FromPartitionData(partition);
                }
                // regex match using cached compiled Regex instances
                foreach (var entry in _partitionsByRegex)
                {
                    if (entry.Regex.IsMatch(region))
                    {
                        return FromPartitionData(entry.Partition);
                    }
                }
                return FromPartitionData(_defaultPartition);
            }
            finally
            {
                _locker.ExitReadLock();
            }
        }
    }
}
