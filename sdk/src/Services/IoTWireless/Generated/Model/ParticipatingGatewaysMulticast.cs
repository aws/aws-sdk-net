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
    /// Specify the list of gateways to which you want to send the multicast downlink messages.
    /// The multicast message will be sent to each gateway in the sequence provided in the
    /// list.
    /// </summary>
    public partial class ParticipatingGatewaysMulticast
    {
        private List<string> _gatewayList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _transmissionInterval;

        /// <summary>
        /// Gets and sets the property GatewayList. 
        /// <para>
        /// The list of gateways that you want to use for sending the multicast downlink. Each
        /// downlink will be sent to all the gateways in the list with transmission interval between
        /// them. If list is empty the gateway list will be dynamically selected similar to the
        /// case of no ParticipatingGateways 
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> GatewayList
        {
            get { return this._gatewayList; }
            set { this._gatewayList = value; }
        }

        // Check to see if GatewayList property is set
        internal bool IsSetGatewayList()
        {
            return this._gatewayList != null && (this._gatewayList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransmissionInterval. 
        /// <para>
        /// The duration of time for which AWS IoT Core for LoRaWAN will wait before transmitting
        /// the multicast payload to the next gateway in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60000)]
        public int TransmissionInterval
        {
            get { return this._transmissionInterval.GetValueOrDefault(); }
            set { this._transmissionInterval = value; }
        }

        // Check to see if TransmissionInterval property is set
        internal bool IsSetTransmissionInterval()
        {
            return this._transmissionInterval.HasValue; 
        }

    }
}