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
    /// Container for the parameters to the CreateTopic operation.
    /// Creates a topic in the specified MSK cluster.
    /// </summary>
    public partial class CreateTopicRequest : AmazonKafkaRequest
    {
        private string _clusterArn;
        private string _configs;
        private int? _partitionCount;
        private int? _replicationFactor;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property ClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property Configs.             
        /// <para>
        /// Topic configurations encoded as a Base64 string.
        /// </para>
        /// </summary>
        public string Configs
        {
            get { return this._configs; }
            set { this._configs = value; }
        }

        // Check to see if Configs property is set
        internal bool IsSetConfigs()
        {
            return this._configs != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionCount.             
        /// <para>
        /// The number of partitions for the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? PartitionCount
        {
            get { return this._partitionCount; }
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
        /// The replication factor for the topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? ReplicationFactor
        {
            get { return this._replicationFactor; }
            set { this._replicationFactor = value; }
        }

        // Check to see if ReplicationFactor property is set
        internal bool IsSetReplicationFactor()
        {
            return this._replicationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicName.             
        /// <para>
        /// The name of the topic to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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