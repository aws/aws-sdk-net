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
    /// LoRaWAN public gateway metadata.
    /// </summary>
    public partial class LoRaWANPublicGatewayMetadata
    {
        private bool? _dlAllowed;
        private string _id;
        private string _providerNetId;
        private string _rfRegion;
        private double? _rssi;
        private double? _snr;

        /// <summary>
        /// Gets and sets the property DlAllowed. 
        /// <para>
        /// Boolean that indicates whether downlink is allowed using the network.
        /// </para>
        /// </summary>
        public bool? DlAllowed
        {
            get { return this._dlAllowed; }
            set { this._dlAllowed = value; }
        }

        // Check to see if DlAllowed property is set
        internal bool IsSetDlAllowed()
        {
            return this._dlAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the gateways that are operated by the network provider.
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
        /// Gets and sets the property ProviderNetId. 
        /// <para>
        /// The ID of the LoRaWAN public network provider.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ProviderNetId
        {
            get { return this._providerNetId; }
            set { this._providerNetId = value; }
        }

        // Check to see if ProviderNetId property is set
        internal bool IsSetProviderNetId()
        {
            return this._providerNetId != null;
        }

        /// <summary>
        /// Gets and sets the property RfRegion.
        /// </summary>
        [AWSProperty(Max=64)]
        public string RfRegion
        {
            get { return this._rfRegion; }
            set { this._rfRegion = value; }
        }

        // Check to see if RfRegion property is set
        internal bool IsSetRfRegion()
        {
            return this._rfRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Rssi. 
        /// <para>
        /// The RSSI (received signal strength indicator) value.
        /// </para>
        /// </summary>
        public double? Rssi
        {
            get { return this._rssi; }
            set { this._rssi = value; }
        }

        // Check to see if Rssi property is set
        internal bool IsSetRssi()
        {
            return this._rssi.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Snr. 
        /// <para>
        /// The SNR (signal to noise ratio) value.
        /// </para>
        /// </summary>
        public double? Snr
        {
            get { return this._snr; }
            set { this._snr = value; }
        }

        // Check to see if Snr property is set
        internal bool IsSetSnr()
        {
            return this._snr.HasValue; 
        }

    }
}