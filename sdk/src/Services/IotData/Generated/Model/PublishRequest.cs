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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the Publish operation.
    /// Publishes state information.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/protocols.html#http">HTTP
    /// Protocol</a> in the <i>AWS IoT Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PublishRequest : AmazonIotDataRequest
    {
        private MemoryStream _payload;
        private int? _qos;
        private string _topic;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The state information, in JSON format.
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
        /// Gets and sets the property Topic. 
        /// <para>
        /// The name of the MQTT topic.
        /// </para>
        /// </summary>
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