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
    /// Specify the list of gateways to which you want to send the multicast downlink messages.
    /// The multicast message will be sent to each gateway in the list, with the transmission
    /// interval as the time interval between each message.
    /// </summary>
    public partial class ParticipatingGatewaysMulticast
    {
        /// <summary>
        /// Gets and sets the property GatewayList. 
        /// <para>
        /// The list of gateways that you want to use for sending the multicast downlink message.
        /// Each downlink message will be sent to all the gateways in the list in the order that
        /// you provided. If the gateway list is empty, then AWS IoT Core for LoRaWAN chooses
        /// the gateways that were most recently used by the devices to send an uplink message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> GatewayList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GatewayList property is set.
        /// </summary>
        internal bool IsSetGatewayList() => this.GatewayList != null && (this.GatewayList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransmissionInterval. 
        /// <para>
        /// The duration of time in milliseconds for which AWS IoT Core for LoRaWAN will wait
        /// before transmitting the multicast payload to the next gateway in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 60000)]
        public int? TransmissionInterval { get; set; }

        /// <summary>
        /// Checks to see if the TransmissionInterval property is set.
        /// </summary>
        internal bool IsSetTransmissionInterval() => this.TransmissionInterval.HasValue;
    }
}
