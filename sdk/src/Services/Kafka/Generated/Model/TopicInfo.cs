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
    /// Includes identification info about the topic.
    /// </summary>
    public partial class TopicInfo
    {
        private int? _outOfSyncReplicaCount;
        private int? _partitionCount;
        private int? _replicationFactor;
        private string _topicArn;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property OutOfSyncReplicaCount.             
        /// <para>
        /// Number of out-of-sync replicas for a topic.
        /// </para>
        /// </summary>
        public int OutOfSyncReplicaCount
        {
            get { return this._outOfSyncReplicaCount.GetValueOrDefault(); }
            set { this._outOfSyncReplicaCount = value; }
        }

        // Check to see if OutOfSyncReplicaCount property is set
        internal bool IsSetOutOfSyncReplicaCount()
        {
            return this._outOfSyncReplicaCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartitionCount.             
        /// <para>
        /// Partition count for a topic.
        /// </para>
        /// </summary>
        public int PartitionCount
        {
            get { return this._partitionCount.GetValueOrDefault(); }
            set { this._partitionCount = value; }
        }

        // Check to see if PartitionCount property is set
        internal bool IsSetPartitionCount()
        {
            return this._partitionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationFactor.             
        /// <para>
        /// Replication factor for a topic.
        /// </para>
        /// </summary>
        public int ReplicationFactor
        {
            get { return this._replicationFactor.GetValueOrDefault(); }
            set { this._replicationFactor = value; }
        }

        // Check to see if ReplicationFactor property is set
        internal bool IsSetReplicationFactor()
        {
            return this._replicationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the topic.
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName.             
        /// <para>
        /// Name for a topic.
        /// </para>
        /// </summary>
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}