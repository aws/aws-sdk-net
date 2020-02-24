/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information required to publish the MQTT message through the AWS IoT message broker.
    /// </summary>
    public partial class IotTopicPublishAction
    {
        private string _mqttTopic;

        /// <summary>
        /// Gets and sets the property MqttTopic. 
        /// <para>
        /// The MQTT topic of the message. You can use a string expression that includes variables
        /// (<code>$variable.&lt;variable-name&gt;</code>) and input values (<code>$input.&lt;input-name&gt;.&lt;path-to-datum&gt;</code>)
        /// as the topic string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string MqttTopic
        {
            get { return this._mqttTopic; }
            set { this._mqttTopic = value; }
        }

        // Check to see if MqttTopic property is set
        internal bool IsSetMqttTopic()
        {
            return this._mqttTopic != null;
        }

    }
}