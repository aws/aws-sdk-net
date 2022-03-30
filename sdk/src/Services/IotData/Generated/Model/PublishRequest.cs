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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the Publish operation.
    /// Publishes an MQTT message.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">Publish</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// For more information about MQTT messages, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">MQTT
    /// Protocol</a> in the IoT Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// For more information about messaging costs, see <a href="http://aws.amazon.com/iot-core/pricing/#Messaging">Amazon
    /// Web Services IoT Core pricing - Messaging</a>.
    /// </para>
    /// </summary>
    public partial class PublishRequest : AmazonIotDataRequest
    {
        private MemoryStream _payload;
        private int? _qos;
        private bool? _retain;
        private string _topic;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The message body. MQTT accepts text, binary, and empty (null) message payloads.
        /// </para>
        ///  
        /// <para>
        /// Publishing an empty (null) payload with <b>retain</b> = <code>true</code> deletes
        /// the retained message identified by <b>topic</b> from Amazon Web Services IoT Core.
        /// </para>
        /// </summary>
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The Quality of Service (QoS) level.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int Qos
        {
            get { return this._qos.GetValueOrDefault(); }
            set { this._qos = value; }
        }

        // Check to see if Qos property is set
        internal bool IsSetQos()
        {
            return this._qos.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Retain. 
        /// <para>
        /// A Boolean value that determines whether to set the RETAIN flag when the message is
        /// published.
        /// </para>
        ///  
        /// <para>
        /// Setting the RETAIN flag causes the message to be retained and sent to new subscribers
        /// to the topic.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>true</code> | <code>false</code> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>false</code> 
        /// </para>
        /// </summary>
        public bool Retain
        {
            get { return this._retain.GetValueOrDefault(); }
            set { this._retain = value; }
        }

        // Check to see if Retain property is set
        internal bool IsSetRetain()
        {
            return this._retain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Topic. 
        /// <para>
        /// The name of the MQTT topic.
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