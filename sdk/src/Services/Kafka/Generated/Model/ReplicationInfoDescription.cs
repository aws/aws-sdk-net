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
    /// Specifies configuration for replication between a source and target Kafka cluster
    /// (sourceKafkaClusterAlias -> targetKafkaClusterAlias)
    /// </summary>
    public partial class ReplicationInfoDescription
    {
        private ConsumerGroupReplication _consumerGroupReplication;
        private string _sourceKafkaClusterAlias;
        private TargetCompressionType _targetCompressionType;
        private string _targetKafkaClusterAlias;
        private TopicReplication _topicReplication;

        /// <summary>
        /// Gets and sets the property ConsumerGroupReplication. 
        /// <para>
        /// Configuration relating to consumer group replication.
        /// </para>
        /// </summary>
        public ConsumerGroupReplication ConsumerGroupReplication
        {
            get { return this._consumerGroupReplication; }
            set { this._consumerGroupReplication = value; }
        }

        // Check to see if ConsumerGroupReplication property is set
        internal bool IsSetConsumerGroupReplication()
        {
            return this._consumerGroupReplication != null;
        }

        /// <summary>
        /// Gets and sets the property SourceKafkaClusterAlias. 
        /// <para>
        /// The alias of the source Kafka cluster.
        /// </para>
        /// </summary>
        public string SourceKafkaClusterAlias
        {
            get { return this._sourceKafkaClusterAlias; }
            set { this._sourceKafkaClusterAlias = value; }
        }

        // Check to see if SourceKafkaClusterAlias property is set
        internal bool IsSetSourceKafkaClusterAlias()
        {
            return this._sourceKafkaClusterAlias != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCompressionType. 
        /// <para>
        /// The compression type to use when producing records to target cluster.
        /// </para>
        /// </summary>
        public TargetCompressionType TargetCompressionType
        {
            get { return this._targetCompressionType; }
            set { this._targetCompressionType = value; }
        }

        // Check to see if TargetCompressionType property is set
        internal bool IsSetTargetCompressionType()
        {
            return this._targetCompressionType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKafkaClusterAlias. 
        /// <para>
        /// The alias of the target Kafka cluster.
        /// </para>
        /// </summary>
        public string TargetKafkaClusterAlias
        {
            get { return this._targetKafkaClusterAlias; }
            set { this._targetKafkaClusterAlias = value; }
        }

        // Check to see if TargetKafkaClusterAlias property is set
        internal bool IsSetTargetKafkaClusterAlias()
        {
            return this._targetKafkaClusterAlias != null;
        }

        /// <summary>
        /// Gets and sets the property TopicReplication. 
        /// <para>
        /// Configuration relating to topic replication.
        /// </para>
        /// </summary>
        public TopicReplication TopicReplication
        {
            get { return this._topicReplication; }
            set { this._topicReplication = value; }
        }

        // Check to see if TopicReplication property is set
        internal bool IsSetTopicReplication()
        {
            return this._topicReplication != null;
        }

    }
}