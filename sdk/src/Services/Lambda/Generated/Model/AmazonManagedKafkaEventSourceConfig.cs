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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
    /// Specific configuration settings for an Amazon Managed Streaming for Apache Kafka (Amazon
    /// MSK) event source.
    /// </summary>
    public partial class AmazonManagedKafkaEventSourceConfig
    {
        private string _consumerGroupId;
        private KafkaSchemaRegistryConfig _schemaRegistryConfig;

        /// <summary>
        /// Gets and sets the property ConsumerGroupId. 
        /// <para>
        /// The identifier for the Kafka consumer group to join. The consumer group ID must be
        /// unique among all your Kafka event sources. After creating a Kafka event source mapping
        /// with the consumer group ID specified, you cannot update this value. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-consumer-group-id">Customizable
        /// consumer group ID</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ConsumerGroupId
        {
            get { return this._consumerGroupId; }
            set { this._consumerGroupId = value; }
        }

        // Check to see if ConsumerGroupId property is set
        internal bool IsSetConsumerGroupId()
        {
            return this._consumerGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaRegistryConfig. 
        /// <para>
        /// Specific configuration settings for a Kafka schema registry.
        /// </para>
        /// </summary>
        public KafkaSchemaRegistryConfig SchemaRegistryConfig
        {
            get { return this._schemaRegistryConfig; }
            set { this._schemaRegistryConfig = value; }
        }

        // Check to see if SchemaRegistryConfig property is set
        internal bool IsSetSchemaRegistryConfig()
        {
            return this._schemaRegistryConfig != null;
        }

    }
}