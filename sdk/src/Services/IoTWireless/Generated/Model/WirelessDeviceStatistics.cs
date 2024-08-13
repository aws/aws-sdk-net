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
    /// Information about a wireless device's operation.
    /// </summary>
    public partial class WirelessDeviceStatistics
    {
        private string _arn;
        private string _destinationName;
        private FuotaDeviceStatus _fuotaDeviceStatus;
        private string _id;
        private string _lastUplinkReceivedAt;
        private LoRaWANListDevice _loRaWAN;
        private int? _mcGroupId;
        private string _multicastDeviceStatus;
        private string _name;
        private SidewalkListDevice _sidewalk;
        private WirelessDeviceType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name of the resource.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the destination to which the device is assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property FuotaDeviceStatus.
        /// </summary>
        public FuotaDeviceStatus FuotaDeviceStatus
        {
            get { return this._fuotaDeviceStatus; }
            set { this._fuotaDeviceStatus = value; }
        }

        // Check to see if FuotaDeviceStatus property is set
        internal bool IsSetFuotaDeviceStatus()
        {
            return this._fuotaDeviceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the wireless device reporting the data.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUplinkReceivedAt. 
        /// <para>
        /// The date and time when the most recent uplink was received.
        /// </para>
        ///  <note> 
        /// <para>
        /// Theis value is only valid for 3 months.
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
        /// LoRaWAN device info.
        /// </para>
        /// </summary>
        public LoRaWANListDevice LoRaWAN
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
        /// Gets and sets the property McGroupId.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public int? McGroupId
        {
            get { return this._mcGroupId; }
            set { this._mcGroupId = value; }
        }

        // Check to see if McGroupId property is set
        internal bool IsSetMcGroupId()
        {
            return this._mcGroupId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MulticastDeviceStatus. 
        /// <para>
        /// The status of the wireless device in the multicast group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MulticastDeviceStatus
        {
            get { return this._multicastDeviceStatus; }
            set { this._multicastDeviceStatus = value; }
        }

        // Check to see if MulticastDeviceStatus property is set
        internal bool IsSetMulticastDeviceStatus()
        {
            return this._multicastDeviceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk account credentials.
        /// </para>
        /// </summary>
        public SidewalkListDevice Sidewalk
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The wireless device type.
        /// </para>
        /// </summary>
        public WirelessDeviceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}