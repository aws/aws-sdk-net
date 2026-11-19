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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// MSK (Apache Kafka) invocation parameters for subscribers targeting an Amazon MSK cluster.
    /// </summary>
    public partial class MskParameters
    {
        /// <summary>
        /// Gets and sets the property Acks. 
        /// <para>
        /// Producer acknowledgement mode. Defaults to ALL.
        /// </para>
        /// </summary>
        public MskAcks Acks { get; set; }

        /// <summary>
        /// Checks to see if the Acks property is set.
        /// </summary>
        internal bool IsSetAcks() => this.Acks != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Producer client.id passed to the Kafka broker. Identifies the producer in broker-side
        /// logs, metrics, and quota enforcement. A literal, not a JSONata expression: it is a
        /// connection-level setting resolved once when the producer is created, not per event.
        /// If you do not set it, EventBridge uses the subscriber ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// Producer compression codec applied to the record batch. Defaults to NONE.
        /// </para>
        /// </summary>
        public MskCompression Compression { get; set; }

        /// <summary>
        /// Checks to see if the Compression property is set.
        /// </summary>
        internal bool IsSetCompression() => this.Compression != null;

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        /// How the service connects to the cluster. A cluster can have public access and multi-VPC
        /// private connectivity turned on at the same time, so the subscriber names the one to
        /// use. That path must be turned on, with IAM access control, on the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MskConnectivity Connectivity { get; set; }

        /// <summary>
        /// Checks to see if the Connectivity property is set.
        /// </summary>
        internal bool IsSetConnectivity() => this.Connectivity != null;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// Kafka record headers attached to each produced record.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<MskHeader> Headers { get; set; } = AWSConfigs.InitializeCollections ? new List<MskHeader>() : null;

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null && (this.Headers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Kafka record key. Accepts a literal or a JSONata expression (e.g. "{% $events.data.customerId
        /// %}") resolved once per delivered event; the resolved value selects the destination
        /// partition. If you omit it, the producer selects the partition; on an ordered (FIFO)
        /// subscriber, EventBridge instead uses the event group ID as the record key to preserve
        /// ordering.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string PartitionKey { get; set; }

        /// <summary>
        /// Checks to see if the PartitionKey property is set.
        /// </summary>
        internal bool IsSetPartitionKey() => this.PartitionKey != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// Name of the Kafka topic events are produced to. Accepts a literal or a JSONata expression
        /// resolved once per delivered event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
