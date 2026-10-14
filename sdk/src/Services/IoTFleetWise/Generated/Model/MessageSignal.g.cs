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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The decoding information for a specific message which support higher order data types.
    /// </summary>
    public partial class MessageSignal
    {
        /// <summary>
        /// Gets and sets the property StructuredMessage. 
        /// <para>
        /// The structured message for the message signal. It can be defined with either a <c>primitiveMessageDefinition</c>,
        /// <c>structuredMessageListDefinition</c>, or <c>structuredMessageDefinition</c> recursively.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StructuredMessage StructuredMessage { get; set; }

        /// <summary>
        /// Checks to see if the StructuredMessage property is set.
        /// </summary>
        internal bool IsSetStructuredMessage() => this.StructuredMessage != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The topic name for the message signal. It corresponds to topics in ROS 2. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
