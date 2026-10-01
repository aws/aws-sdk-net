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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters required to set up a source for your pipe.
    /// </summary>
    public partial class PipeSourceParameters
    {
        /// <summary>
        /// Gets and sets the property ActiveMQBrokerParameters. 
        /// <para>
        /// The parameters for using an Active MQ broker as a source.
        /// </para>
        /// </summary>
        public PipeSourceActiveMQBrokerParameters ActiveMQBrokerParameters { get; set; }

        /// <summary>
        /// Checks to see if the ActiveMQBrokerParameters property is set.
        /// </summary>
        internal bool IsSetActiveMQBrokerParameters() => this.ActiveMQBrokerParameters != null;

        /// <summary>
        /// Gets and sets the property DynamoDBStreamParameters. 
        /// <para>
        /// The parameters for using a DynamoDB stream as a source.
        /// </para>
        /// </summary>
        public PipeSourceDynamoDBStreamParameters DynamoDBStreamParameters { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDBStreamParameters property is set.
        /// </summary>
        internal bool IsSetDynamoDBStreamParameters() => this.DynamoDBStreamParameters != null;

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// The collection of event patterns used to filter events.
        /// </para>
        ///  
        /// <para>
        /// To remove a filter, specify a <c>FilterCriteria</c> object with an empty array of
        /// <c>Filter</c> objects.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html">Events
        /// and Event Patterns</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public FilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteria property is set.
        /// </summary>
        internal bool IsSetFilterCriteria() => this.FilterCriteria != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamParameters. 
        /// <para>
        /// The parameters for using a Kinesis stream as a source.
        /// </para>
        /// </summary>
        public PipeSourceKinesisStreamParameters KinesisStreamParameters { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamParameters property is set.
        /// </summary>
        internal bool IsSetKinesisStreamParameters() => this.KinesisStreamParameters != null;

        /// <summary>
        /// Gets and sets the property ManagedStreamingKafkaParameters. 
        /// <para>
        /// The parameters for using an MSK stream as a source.
        /// </para>
        /// </summary>
        public PipeSourceManagedStreamingKafkaParameters ManagedStreamingKafkaParameters { get; set; }

        /// <summary>
        /// Checks to see if the ManagedStreamingKafkaParameters property is set.
        /// </summary>
        internal bool IsSetManagedStreamingKafkaParameters() => this.ManagedStreamingKafkaParameters != null;

        /// <summary>
        /// Gets and sets the property RabbitMQBrokerParameters. 
        /// <para>
        /// The parameters for using a Rabbit MQ broker as a source.
        /// </para>
        /// </summary>
        public PipeSourceRabbitMQBrokerParameters RabbitMQBrokerParameters { get; set; }

        /// <summary>
        /// Checks to see if the RabbitMQBrokerParameters property is set.
        /// </summary>
        internal bool IsSetRabbitMQBrokerParameters() => this.RabbitMQBrokerParameters != null;

        /// <summary>
        /// Gets and sets the property SelfManagedKafkaParameters. 
        /// <para>
        /// The parameters for using a self-managed Apache Kafka stream as a source.
        /// </para>
        ///  
        /// <para>
        /// A <i>self managed</i> cluster refers to any Apache Kafka cluster not hosted by Amazon
        /// Web Services. This includes both clusters you manage yourself, as well as those hosted
        /// by a third-party provider, such as <a href="https://www.confluent.io/">Confluent Cloud</a>,
        /// <a href="https://www.cloudkarafka.com/">CloudKarafka</a>, or <a href="https://redpanda.com/">Redpanda</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-kafka.html">Apache
        /// Kafka streams as a source</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public PipeSourceSelfManagedKafkaParameters SelfManagedKafkaParameters { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedKafkaParameters property is set.
        /// </summary>
        internal bool IsSetSelfManagedKafkaParameters() => this.SelfManagedKafkaParameters != null;

        /// <summary>
        /// Gets and sets the property SqsQueueParameters. 
        /// <para>
        /// The parameters for using a Amazon SQS stream as a source.
        /// </para>
        /// </summary>
        public PipeSourceSqsQueueParameters SqsQueueParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqsQueueParameters property is set.
        /// </summary>
        internal bool IsSetSqsQueueParameters() => this.SqsQueueParameters != null;
    }
}
