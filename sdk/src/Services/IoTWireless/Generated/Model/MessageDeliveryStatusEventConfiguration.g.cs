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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Message delivery status event configuration object for enabling and disabling relevant
    /// topics.
    /// </summary>
    public partial class MessageDeliveryStatusEventConfiguration
    {
        /// <summary>
        /// Gets and sets the property Sidewalk.
        /// </summary>
        public SidewalkEventNotificationConfigurations Sidewalk { get; set; }

        /// <summary>
        /// Checks to see if the Sidewalk property is set.
        /// </summary>
        internal bool IsSetSidewalk() => this.Sidewalk != null;

        /// <summary>
        /// Gets and sets the property WirelessDeviceIdEventTopic. 
        /// <para>
        /// Denotes whether the wireless device ID message delivery status event topic is enabled
        /// or disabled.
        /// </para>
        /// </summary>
        public EventNotificationTopicStatus WirelessDeviceIdEventTopic { get; set; }

        /// <summary>
        /// Checks to see if the WirelessDeviceIdEventTopic property is set.
        /// </summary>
        internal bool IsSetWirelessDeviceIdEventTopic() => this.WirelessDeviceIdEventTopic != null;
    }
}
