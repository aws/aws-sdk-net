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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details about consumer group replication.
    /// </summary>
    public partial class ConsumerGroupReplication
    {
        /// <summary>
        /// Gets and sets the property ConsumerGroupOffsetSyncMode. 
        /// <para>
        /// The consumer group offset synchronization mode. With LEGACY, offsets are synchronized
        /// when producers write to the source cluster. With ENHANCED, consumer offsets are synchronized
        /// regardless of producer location. ENHANCED requires a corresponding replicator that
        /// replicates data from the target cluster to the source cluster.
        /// </para>
        /// </summary>
        public ConsumerGroupOffsetSyncMode ConsumerGroupOffsetSyncMode { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerGroupOffsetSyncMode property is set.
        /// </summary>
        internal bool IsSetConsumerGroupOffsetSyncMode() => this.ConsumerGroupOffsetSyncMode != null;

        /// <summary>
        /// Gets and sets the property ConsumerGroupsToExclude. 
        /// <para>
        /// List of regular expression patterns indicating the consumer groups that should not
        /// be replicated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConsumerGroupsToExclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConsumerGroupsToExclude property is set.
        /// </summary>
        internal bool IsSetConsumerGroupsToExclude() => this.ConsumerGroupsToExclude != null && (this.ConsumerGroupsToExclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConsumerGroupsToReplicate. 
        /// <para>
        /// List of regular expression patterns indicating the consumer groups to copy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ConsumerGroupsToReplicate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConsumerGroupsToReplicate property is set.
        /// </summary>
        internal bool IsSetConsumerGroupsToReplicate() => this.ConsumerGroupsToReplicate != null && (this.ConsumerGroupsToReplicate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DetectAndCopyNewConsumerGroups. 
        /// <para>
        /// Enables synchronization of consumer groups to target cluster.
        /// </para>
        /// </summary>
        public bool? DetectAndCopyNewConsumerGroups { get; set; }

        /// <summary>
        /// Checks to see if the DetectAndCopyNewConsumerGroups property is set.
        /// </summary>
        internal bool IsSetDetectAndCopyNewConsumerGroups() => this.DetectAndCopyNewConsumerGroups.HasValue;

        /// <summary>
        /// Gets and sets the property SynchroniseConsumerGroupOffsets. 
        /// <para>
        /// Enables synchronization of consumer group offsets to target cluster. The translated
        /// offsets will be written to topic __consumer_offsets.
        /// </para>
        /// </summary>
        public bool? SynchroniseConsumerGroupOffsets { get; set; }

        /// <summary>
        /// Checks to see if the SynchroniseConsumerGroupOffsets property is set.
        /// </summary>
        internal bool IsSetSynchroniseConsumerGroupOffsets() => this.SynchroniseConsumerGroupOffsets.HasValue;
    }
}
