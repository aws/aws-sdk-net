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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
    public partial class ConsumerGroupReplicationUpdate
    {
        private List<string> _consumerGroupsToExclude = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _consumerGroupsToReplicate = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _detectAndCopyNewConsumerGroups;
        private bool? _synchroniseConsumerGroupOffsets;

        /// <summary>
        /// Gets and sets the property ConsumerGroupsToExclude. 
        /// <para>
        /// List of regular expression patterns indicating the consumer groups that should not
        /// be replicated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ConsumerGroupsToExclude
        {
            get { return this._consumerGroupsToExclude; }
            set { this._consumerGroupsToExclude = value; }
        }

        // Check to see if ConsumerGroupsToExclude property is set
        internal bool IsSetConsumerGroupsToExclude()
        {
            return this._consumerGroupsToExclude != null && (this._consumerGroupsToExclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConsumerGroupsToReplicate. 
        /// <para>
        /// List of regular expression patterns indicating the consumer groups to copy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ConsumerGroupsToReplicate
        {
            get { return this._consumerGroupsToReplicate; }
            set { this._consumerGroupsToReplicate = value; }
        }

        // Check to see if ConsumerGroupsToReplicate property is set
        internal bool IsSetConsumerGroupsToReplicate()
        {
            return this._consumerGroupsToReplicate != null && (this._consumerGroupsToReplicate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DetectAndCopyNewConsumerGroups. 
        /// <para>
        /// Enables synchronization of consumer groups to target cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DetectAndCopyNewConsumerGroups
        {
            get { return this._detectAndCopyNewConsumerGroups; }
            set { this._detectAndCopyNewConsumerGroups = value; }
        }

        // Check to see if DetectAndCopyNewConsumerGroups property is set
        internal bool IsSetDetectAndCopyNewConsumerGroups()
        {
            return this._detectAndCopyNewConsumerGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SynchroniseConsumerGroupOffsets. 
        /// <para>
        /// Enables synchronization of consumer group offsets to target cluster. The translated
        /// offsets will be written to topic __consumer_offsets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SynchroniseConsumerGroupOffsets
        {
            get { return this._synchroniseConsumerGroupOffsets; }
            set { this._synchroniseConsumerGroupOffsets = value; }
        }

        // Check to see if SynchroniseConsumerGroupOffsets property is set
        internal bool IsSetSynchroniseConsumerGroupOffsets()
        {
            return this._synchroniseConsumerGroupOffsets.HasValue; 
        }

    }
}