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
    /// Includes identification info about the topic.
    /// </summary>
    public partial class TopicInfo
    {
        /// <summary>
        /// Gets and sets the property OutOfSyncReplicaCount. 
        /// <para>
        /// Number of out-of-sync replicas for a topic.
        /// </para>
        /// </summary>
        public int? OutOfSyncReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the OutOfSyncReplicaCount property is set.
        /// </summary>
        internal bool IsSetOutOfSyncReplicaCount() => this.OutOfSyncReplicaCount.HasValue;

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// Partition count for a topic.
        /// </para>
        /// </summary>
        public int? PartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the PartitionCount property is set.
        /// </summary>
        internal bool IsSetPartitionCount() => this.PartitionCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationFactor. 
        /// <para>
        /// Replication factor for a topic.
        /// </para>
        /// </summary>
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationFactor property is set.
        /// </summary>
        internal bool IsSetReplicationFactor() => this.ReplicationFactor.HasValue;

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the topic.
        /// </para>
        /// </summary>
        public string TopicArn { get; set; }

        /// <summary>
        /// Checks to see if the TopicArn property is set.
        /// </summary>
        internal bool IsSetTopicArn() => this.TopicArn != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// Name for a topic.
        /// </para>
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
