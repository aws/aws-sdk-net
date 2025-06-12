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
    /// LoRaWAN device metatdata.
    /// </summary>
    public partial class LoRaWANDeviceMetadata
    {
        private int? _dataRate;
        private string _devEui;
        private int? _fPort;
        private int? _frequency;
        private List<LoRaWANGatewayMetadata> _gateways = AWSConfigs.InitializeCollections ? new List<LoRaWANGatewayMetadata>() : null;
        private List<LoRaWANPublicGatewayMetadata> _publicGateways = AWSConfigs.InitializeCollections ? new List<LoRaWANPublicGatewayMetadata>() : null;
        private string _timestamp;

        /// <summary>
        /// Gets and sets the property DataRate. 
        /// <para>
        /// The DataRate value.
        /// </para>
        /// </summary>
        public int? DataRate
        {
            get { return this._dataRate; }
            set { this._dataRate = value; }
        }

        // Check to see if DataRate property is set
        internal bool IsSetDataRate()
        {
            return this._dataRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DevEui. 
        /// <para>
        /// The DevEUI value.
        /// </para>
        /// </summary>
        public string DevEui
        {
            get { return this._devEui; }
            set { this._devEui = value; }
        }

        // Check to see if DevEui property is set
        internal bool IsSetDevEui()
        {
            return this._devEui != null;
        }

        /// <summary>
        /// Gets and sets the property FPort. 
        /// <para>
        /// The FPort value.
        /// </para>
        /// </summary>
        public int? FPort
        {
            get { return this._fPort; }
            set { this._fPort = value; }
        }

        // Check to see if FPort property is set
        internal bool IsSetFPort()
        {
            return this._fPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The device's channel frequency in Hz.
        /// </para>
        /// </summary>
        public int? Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gateways. 
        /// <para>
        /// Information about the gateways accessed by the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoRaWANGatewayMetadata> Gateways
        {
            get { return this._gateways; }
            set { this._gateways = value; }
        }

        // Check to see if Gateways property is set
        internal bool IsSetGateways()
        {
            return this._gateways != null && (this._gateways.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PublicGateways. 
        /// <para>
        /// Information about the LoRaWAN public network accessed by the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoRaWANPublicGatewayMetadata> PublicGateways
        {
            get { return this._publicGateways; }
            set { this._publicGateways = value; }
        }

        // Check to see if PublicGateways property is set
        internal bool IsSetPublicGateways()
        {
            return this._publicGateways != null && (this._publicGateways.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time of the metadata.
        /// </para>
        /// </summary>
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}