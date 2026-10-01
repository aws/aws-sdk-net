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
    /// LoRaWAN device metatdata.
    /// </summary>
    public partial class LoRaWANDeviceMetadata
    {
        /// <summary>
        /// Gets and sets the property DataRate. 
        /// <para>
        /// The DataRate value.
        /// </para>
        /// </summary>
        public int? DataRate { get; set; }

        /// <summary>
        /// Checks to see if the DataRate property is set.
        /// </summary>
        internal bool IsSetDataRate() => this.DataRate.HasValue;

        /// <summary>
        /// Gets and sets the property DevEui. 
        /// <para>
        /// The DevEUI value.
        /// </para>
        /// </summary>
        public string DevEui { get; set; }

        /// <summary>
        /// Checks to see if the DevEui property is set.
        /// </summary>
        internal bool IsSetDevEui() => this.DevEui != null;

        /// <summary>
        /// Gets and sets the property FPort. 
        /// <para>
        /// The FPort value.
        /// </para>
        /// </summary>
        public int? FPort { get; set; }

        /// <summary>
        /// Checks to see if the FPort property is set.
        /// </summary>
        internal bool IsSetFPort() => this.FPort.HasValue;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The device's channel frequency in Hz.
        /// </para>
        /// </summary>
        public int? Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency.HasValue;

        /// <summary>
        /// Gets and sets the property Gateways. 
        /// <para>
        /// Information about the gateways accessed by the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoRaWANGatewayMetadata> Gateways { get; set; } = AWSConfigs.InitializeCollections ? new List<LoRaWANGatewayMetadata>() : null;

        /// <summary>
        /// Checks to see if the Gateways property is set.
        /// </summary>
        internal bool IsSetGateways() => this.Gateways != null && (this.Gateways.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PublicGateways. 
        /// <para>
        /// Information about the LoRaWAN public network accessed by the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoRaWANPublicGatewayMetadata> PublicGateways { get; set; } = AWSConfigs.InitializeCollections ? new List<LoRaWANPublicGatewayMetadata>() : null;

        /// <summary>
        /// Checks to see if the PublicGateways property is set.
        /// </summary>
        internal bool IsSetPublicGateways() => this.PublicGateways != null && (this.PublicGateways.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time of the metadata.
        /// </para>
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
