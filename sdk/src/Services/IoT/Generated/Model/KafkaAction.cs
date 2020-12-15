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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Send messages to an Amazon Managed Streaming for Apache Kafka (Amazon MSK) or self-managed
    /// Apache Kafka cluster.
    /// </summary>
    public partial class KafkaAction
    {
        private Dictionary<string, string> _clientProperties = new Dictionary<string, string>();
        private string _destinationArn;
        private string _key;
        private string _partition;
        private string _topic;

        /// <summary>
        /// Gets and sets the property ClientProperties. 
        /// <para>
        /// Properties of the Apache Kafka producer client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ClientProperties
        {
            get { return this._clientProperties; }
            set { this._clientProperties = value; }
        }

        // Check to see if ClientProperties property is set
        internal bool IsSetClientProperties()
        {
            return this._clientProperties != null && this._clientProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of Kafka action's VPC <code>TopicRuleDestination</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The Kafka message key.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The Kafka message partition.
        /// </para>
        /// </summary>
        public string Partition
        {
            get { return this._partition; }
            set { this._partition = value; }
        }

        // Check to see if Partition property is set
        internal bool IsSetPartition()
        {
            return this._partition != null;
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The Kafka topic for messages to be sent to the Kafka broker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Topic
        {
            get { return this._topic; }
            set { this._topic = value; }
        }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this._topic != null;
        }

    }
}