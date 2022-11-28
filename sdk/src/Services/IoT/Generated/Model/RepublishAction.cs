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
    /// Describes an action to republish to another topic.
    /// </summary>
    public partial class RepublishAction
    {
        private MqttHeaders _headers;
        private int? _qos;
        private string _roleArn;
        private string _topic;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// MQTT Version 5.0 headers information. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/mqtt.html">
        /// MQTT</a> from the Amazon Web Services IoT Core Developer Guide.
        /// </para>
        /// </summary>
        public MqttHeaders Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null;
        }

        /// <summary>
        /// Gets and sets the property Qos. 
        /// <para>
        /// The Quality of Service (QoS) level to use when republishing messages. The default
        /// value is 0.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
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