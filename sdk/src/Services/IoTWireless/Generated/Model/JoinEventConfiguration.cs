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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Join event configuration object for enabling or disabling topic.
    /// </summary>
    public partial class JoinEventConfiguration
    {
        private LoRaWANJoinEventNotificationConfigurations _loRaWAN;
        private EventNotificationTopicStatus _wirelessDeviceIdEventTopic;

        /// <summary>
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// Join event configuration object for enabling or disabling LoRaWAN related event topics.
        /// </para>
        /// </summary>
        public LoRaWANJoinEventNotificationConfigurations LoRaWAN
        {
            get { return this._loRaWAN; }
            set { this._loRaWAN = value; }
        }

        // Check to see if LoRaWAN property is set
        internal bool IsSetLoRaWAN()
        {
            return this._loRaWAN != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceIdEventTopic. 
        /// <para>
        /// Denotes whether the wireless device ID join event topic is enabled or disabled.
        /// </para>
        /// </summary>
        public EventNotificationTopicStatus WirelessDeviceIdEventTopic
        {
            get { return this._wirelessDeviceIdEventTopic; }
            set { this._wirelessDeviceIdEventTopic = value; }
        }

        // Check to see if WirelessDeviceIdEventTopic property is set
        internal bool IsSetWirelessDeviceIdEventTopic()
        {
            return this._wirelessDeviceIdEventTopic != null;
        }

    }
}