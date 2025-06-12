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
    /// Specify the list of gateways to which you want to send downlink data traffic when
    /// the wireless device is running in class B or class C mode.
    /// </summary>
    public partial class ParticipatingGateways
    {
        private DownlinkMode _downlinkMode;
        private List<GatewayListItem> _gatewayList = AWSConfigs.InitializeCollections ? new List<GatewayListItem>() : null;
        private int? _transmissionInterval;

        /// <summary>
        /// Gets and sets the property DownlinkMode. 
        /// <para>
        /// Indicates whether to send the downlink message in sequential mode or concurrent mode,
        /// or to use only the chosen gateways from the previous uplink message transmission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DownlinkMode DownlinkMode
        {
            get { return this._downlinkMode; }
            set { this._downlinkMode = value; }
        }

        // Check to see if DownlinkMode property is set
        internal bool IsSetDownlinkMode()
        {
            return this._downlinkMode != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayList. 
        /// <para>
        /// The list of gateways that you want to use for sending the downlink data traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GatewayListItem> GatewayList
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
        /// the payload to the next gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=604800)]
        public int? TransmissionInterval
        {
            get { return this._transmissionInterval; }
            set { this._transmissionInterval = value; }
        }

        // Check to see if TransmissionInterval property is set
        internal bool IsSetTransmissionInterval()
        {
            return this._transmissionInterval.HasValue; 
        }

    }
}