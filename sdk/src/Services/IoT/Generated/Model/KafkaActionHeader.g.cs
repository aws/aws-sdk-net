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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Specifies a Kafka header using key-value pairs when you create a Rule’s Kafka Action.
    /// You can use these headers to route data from IoT clients to downstream Kafka clusters
    /// without modifying your message payload.
    /// 
    ///  
    /// <para>
    /// For more information about Rule's Kafka action, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/apache-kafka-rule-action.html">Apache
    /// Kafka</a>. 
    /// </para>
    /// </summary>
    public partial class KafkaActionHeader
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the Kafka header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 16384)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the Kafka header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 16384)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
