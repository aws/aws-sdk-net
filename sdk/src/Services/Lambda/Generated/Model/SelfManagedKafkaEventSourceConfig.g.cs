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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specific configuration settings for a self-managed Apache Kafka event source.
    /// </summary>
    public partial class SelfManagedKafkaEventSourceConfig
    {
        /// <summary>
        /// Gets and sets the property ConsumerGroupId. 
        /// <para>
        ///  The identifier for the Kafka consumer group to join. The consumer group ID must be
        /// unique among all your Kafka event sources. After creating a Kafka event source mapping
        /// with the consumer group ID specified, you cannot update this value. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka-process.html#services-smaa-topic-add">Customizable
        /// consumer group ID</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerGroupId property is set.
        /// </summary>
        internal bool IsSetConsumerGroupId() => this.ConsumerGroupId != null;

        /// <summary>
        /// Gets and sets the property ConsumptionMode. 
        /// <para>
        /// The mode that Lambda uses to consume records from your self-managed Apache Kafka topic.
        /// The default is <c>Stream</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Stream</c> – Lambda consumes records using a Kafka consumer group and preserves
        /// the order of records within each partition. This is the default when you omit <c>ConsumptionMode</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Queue</c> – Lambda consumes records using a Kafka share group. Multiple consumers
        /// can process records from the same partitions concurrently. Queue mode does not preserve
        /// per-partition order. Queue mode requires an Apache Kafka cluster running version 4.2
        /// or later with share groups enabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You cannot change <c>ConsumptionMode</c> after you create the event source mapping.
        /// To use a different consumption mode, create a new event source mapping.
        /// </para>
        ///  
        /// <para>
        /// When <c>ConsumptionMode</c> is <c>Queue</c>, the <c>StartingPosition</c>, <c>StartingPositionTimestamp</c>,
        /// and <c>MaximumBatchingWindowInSeconds</c> parameters are not supported.
        /// </para>
        /// </summary>
        public KafkaEventSourceMappingConsumptionMode ConsumptionMode { get; set; }

        /// <summary>
        /// Checks to see if the ConsumptionMode property is set.
        /// </summary>
        internal bool IsSetConsumptionMode() => this.ConsumptionMode != null;

        /// <summary>
        /// Gets and sets the property SchemaRegistryConfig. 
        /// <para>
        /// Specific configuration settings for a Kafka schema registry.
        /// </para>
        /// </summary>
        public KafkaSchemaRegistryConfig SchemaRegistryConfig { get; set; }

        /// <summary>
        /// Checks to see if the SchemaRegistryConfig property is set.
        /// </summary>
        internal bool IsSetSchemaRegistryConfig() => this.SchemaRegistryConfig != null;
    }
}
