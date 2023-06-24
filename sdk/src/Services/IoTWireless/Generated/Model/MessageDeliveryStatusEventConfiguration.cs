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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Message delivery status event configuration object for enabling and disabling relevant
    /// topics.
    /// </summary>
    public partial class MessageDeliveryStatusEventConfiguration
    {
        private SidewalkEventNotificationConfigurations _sidewalk;
        private EventNotificationTopicStatus _wirelessDeviceIdEventTopic;

        /// <summary>
        /// Gets and sets the property Sidewalk.
        /// </summary>
        public SidewalkEventNotificationConfigurations Sidewalk
        {
            get { return this._sidewalk; }
            set { this._sidewalk = value; }
        }

        // Check to see if Sidewalk property is set
        internal bool IsSetSidewalk()
        {
            return this._sidewalk != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceIdEventTopic. 
        /// <para>
        /// Denotes whether the wireless device ID message delivery status event topic is enabled
        /// or disabled.
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