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
    /// This is the response object from the GetWirelessGatewayStatistics operation.
    /// </summary>
    public partial class GetWirelessGatewayStatisticsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// The connection status of the wireless gateway.
        /// </para>
        /// </summary>
        public ConnectionStatus ConnectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionStatus property is set.
        /// </summary>
        internal bool IsSetConnectionStatus() => this.ConnectionStatus != null;

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
        public string LastUplinkReceivedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUplinkReceivedAt property is set.
        /// </summary>
        internal bool IsSetLastUplinkReceivedAt() => this.LastUplinkReceivedAt != null;

        /// <summary>
        /// Gets and sets the property WirelessGatewayId. 
        /// <para>
        /// The ID of the wireless gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string WirelessGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the WirelessGatewayId property is set.
        /// </summary>
        internal bool IsSetWirelessGatewayId() => this.WirelessGatewayId != null;
    }
}
