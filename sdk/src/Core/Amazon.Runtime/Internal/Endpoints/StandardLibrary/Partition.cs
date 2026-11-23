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
            // Endpoint rules call Partition(region) on every request. Build the bag once per
            // partition shape and  hand out exact-size copies, which avoids the repeated dictionary
            // growth and boolean boxing while still giving each caller its own (mutable) instance.
            var prototype = _prototypes.GetValue(data, static shape => new Partition
            {
                name = shape.name,
                dnsSuffix = shape.dnsSuffix,
                dualStackDnsSuffix = shape.dualStackDnsSuffix,
                supportsFIPS = shape.supportsFIPS,
                supportsDualStack = shape.supportsDualStack,
                implicitGlobalRegion = shape.implicitGlobalRegion,
            });

            return new Partition(prototype);
        }

        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<PartitionAttributesShape, Partition> _prototypes =
            new System.Runtime.CompilerServices.ConditionalWeakTable<PartitionAttributesShape, Partition>();

        public Partition()
        {
        }

        private Partition(Partition source) : base(source)
        {
            name = source.name;
            dnsSuffix = source.dnsSuffix;
            dualStackDnsSuffix = source.dualStackDnsSuffix;
            supportsFIPS = source.supportsFIPS;
            supportsDualStack = source.supportsDualStack;
            implicitGlobalRegion = source.implicitGlobalRegion;
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
