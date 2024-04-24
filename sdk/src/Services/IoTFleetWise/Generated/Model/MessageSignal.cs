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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
        private StructuredMessage _structuredMessage;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property StructuredMessage. 
        /// <para>
        /// The structured message for the message signal. It can be defined with either a <c>primitiveMessageDefinition</c>,
        /// <c>structuredMessageListDefinition</c>, or <c>structuredMessageDefinition</c> recursively.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StructuredMessage StructuredMessage
        {
            get { return this._structuredMessage; }
            set { this._structuredMessage = value; }
        }

        // Check to see if StructuredMessage property is set
        internal bool IsSetStructuredMessage()
        {
            return this._structuredMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The topic name for the message signal. It corresponds to topics in ROS 2. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
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