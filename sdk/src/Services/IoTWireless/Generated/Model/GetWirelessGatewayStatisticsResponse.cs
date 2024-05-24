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
    /// This is the response object from the GetWirelessGatewayStatistics operation.
    /// </summary>
    public partial class GetWirelessGatewayStatisticsResponse : AmazonWebServiceResponse
    {
        private ConnectionStatus _connectionStatus;
        private string _lastUplinkReceivedAt;
        private string _wirelessGatewayId;

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// The connection status of the wireless gateway.
        /// </para>
        /// </summary>
        public ConnectionStatus ConnectionStatus
        {
            get { return this._connectionStatus; }
            set { this._connectionStatus = value; }
        }

        // Check to see if ConnectionStatus property is set
        internal bool IsSetConnectionStatus()
        {
            return this._connectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUplinkReceivedAt. 
        /// <para>
        /// The date and time when the most recent uplink was received.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is only valid for 3 months.
        /// </para>
        ///  </note>
        /// </summary>
        public string LastUplinkReceivedAt
        {
            get { return this._lastUplinkReceivedAt; }
            set { this._lastUplinkReceivedAt = value; }
        }

        // Check to see if LastUplinkReceivedAt property is set
        internal bool IsSetLastUplinkReceivedAt()
        {
            return this._lastUplinkReceivedAt != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewayId. 
        /// <para>
        /// The ID of the wireless gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string WirelessGatewayId
        {
            get { return this._wirelessGatewayId; }
            set { this._wirelessGatewayId = value; }
        }

        // Check to see if WirelessGatewayId property is set
        internal bool IsSetWirelessGatewayId()
        {
            return this._wirelessGatewayId != null;
        }

    }
}