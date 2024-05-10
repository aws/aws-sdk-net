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
    /// This is the response object from the GetWirelessDeviceStatistics operation.
    /// </summary>
    public partial class GetWirelessDeviceStatisticsResponse : AmazonWebServiceResponse
    {
        private string _lastUplinkReceivedAt;
        private LoRaWANDeviceMetadata _loRaWAN;
        private SidewalkDeviceMetadata _sidewalk;
        private string _wirelessDeviceId;

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
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// Information about the wireless device's operations.
        /// </para>
        /// </summary>
        public LoRaWANDeviceMetadata LoRaWAN
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
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// MetaData for Sidewalk device.
        /// </para>
        /// </summary>
        public SidewalkDeviceMetadata Sidewalk
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
        /// Gets and sets the property WirelessDeviceId. 
        /// <para>
        /// The ID of the wireless device.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string WirelessDeviceId
        {
            get { return this._wirelessDeviceId; }
            set { this._wirelessDeviceId = value; }
        }

        // Check to see if WirelessDeviceId property is set
        internal bool IsSetWirelessDeviceId()
        {
            return this._wirelessDeviceId != null;
        }

    }
}