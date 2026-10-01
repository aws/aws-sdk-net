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
    /// Specifies configuration for replication between a source and target Kafka cluster.
    /// </summary>
    public partial class ReplicationInfo
    {
        /// <summary>
        /// Gets and sets the property ConsumerGroupReplication. 
        /// <para>
        /// Configuration relating to consumer group replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConsumerGroupReplication ConsumerGroupReplication { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerGroupReplication property is set.
        /// </summary>
        internal bool IsSetConsumerGroupReplication() => this.ConsumerGroupReplication != null;

        /// <summary>
        /// Gets and sets the property SourceKafkaClusterArn. 
        /// <para>
        /// The ARN of the source Kafka cluster.
        /// </para>
        /// </summary>
        public string SourceKafkaClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceKafkaClusterArn property is set.
        /// </summary>
        internal bool IsSetSourceKafkaClusterArn() => this.SourceKafkaClusterArn != null;

        /// <summary>
        /// Gets and sets the property SourceKafkaClusterId. 
        /// <para>
        /// The ID of the source Kafka cluster.
        /// </para>
        /// </summary>
        public string SourceKafkaClusterId { get; set; }

        /// <summary>
        /// Checks to see if the SourceKafkaClusterId property is set.
        /// </summary>
        internal bool IsSetSourceKafkaClusterId() => this.SourceKafkaClusterId != null;

        /// <summary>
        /// Gets and sets the property TargetCompressionType. 
        /// <para>
        /// The compression type to use when producing records to target cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetCompressionType TargetCompressionType { get; set; }

        /// <summary>
        /// Checks to see if the TargetCompressionType property is set.
        /// </summary>
        internal bool IsSetTargetCompressionType() => this.TargetCompressionType != null;

        /// <summary>
        /// Gets and sets the property TargetKafkaClusterArn. 
        /// <para>
        /// The ARN of the target Kafka cluster.
        /// </para>
        /// </summary>
        public string TargetKafkaClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetKafkaClusterArn property is set.
        /// </summary>
        internal bool IsSetTargetKafkaClusterArn() => this.TargetKafkaClusterArn != null;

        /// <summary>
        /// Gets and sets the property TargetKafkaClusterId. 
        /// <para>
        /// The ID of the target Kafka cluster.
        /// </para>
        /// </summary>
        public string TargetKafkaClusterId { get; set; }

        /// <summary>
        /// Checks to see if the TargetKafkaClusterId property is set.
        /// </summary>
        internal bool IsSetTargetKafkaClusterId() => this.TargetKafkaClusterId != null;

        /// <summary>
        /// Gets and sets the property TopicReplication. 
        /// <para>
        /// Configuration relating to topic replication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TopicReplication TopicReplication { get; set; }

        /// <summary>
        /// Checks to see if the TopicReplication property is set.
        /// </summary>
        internal bool IsSetTopicReplication() => this.TopicReplication != null;
    }
}
