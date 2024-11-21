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
    /// The MQTT topic to which the Amazon Web Services IoT FleetWise campaign routes data.
    /// For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/protocols.html">Device
    /// communication protocols</a> in the <i>Amazon Web Services IoT Core Developer Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Access to certain Amazon Web Services IoT FleetWise features is currently gated. For
    /// more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleetwise-regions.html">Amazon
    /// Web Services Region and feature availability</a> in the <i>Amazon Web Services IoT
    /// FleetWise Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class MqttTopicConfig
    {
        private string _executionRoleArn;
        private string _mqttTopicArn;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the role that grants Amazon Web Services IoT FleetWise permission to access
        /// and act on messages sent to the MQTT topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property MqttTopicArn. 
        /// <para>
        /// The ARN of the MQTT topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string MqttTopicArn
        {
            get { return this._mqttTopicArn; }
            set { this._mqttTopicArn = value; }
        }

        // Check to see if MqttTopicArn property is set
        internal bool IsSetMqttTopicArn()
        {
            return this._mqttTopicArn != null;
        }

    }
}