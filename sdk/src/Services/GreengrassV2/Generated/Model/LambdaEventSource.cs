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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about an event source for an Lambda function. The event source
    /// defines the topics on which this Lambda function subscribes to receive messages that
    /// run the function.
    /// </summary>
    public partial class LambdaEventSource
    {
        private string _topic;
        private LambdaEventSourceType _type;

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The topic to which to subscribe to receive event messages.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of event source. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PUB_SUB</c> – Subscribe to local publish/subscribe messages. This event source
        /// type doesn't support MQTT wildcards (<c>+</c> and <c>#</c>) in the event source topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IOT_CORE</c> – Subscribe to Amazon Web Services IoT Core MQTT messages. This event
        /// source type supports MQTT wildcards (<c>+</c> and <c>#</c>) in the event source topic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public LambdaEventSourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}