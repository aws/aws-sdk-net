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
    /// LoRaWAN public gateway metadata.
    /// </summary>
    public partial class LoRaWANPublicGatewayMetadata
    {
        /// <summary>
        /// Gets and sets the property DlAllowed. 
        /// <para>
        /// Boolean that indicates whether downlink is allowed using the network.
        /// </para>
        /// </summary>
        public bool? DlAllowed { get; set; }

        /// <summary>
        /// Checks to see if the DlAllowed property is set.
        /// </summary>
        internal bool IsSetDlAllowed() => this.DlAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the gateways that are operated by the network provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ProviderNetId. 
        /// <para>
        /// The ID of the LoRaWAN public network provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ProviderNetId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderNetId property is set.
        /// </summary>
        internal bool IsSetProviderNetId() => this.ProviderNetId != null;

        /// <summary>
        /// Gets and sets the property RfRegion.
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RfRegion { get; set; }

        /// <summary>
        /// Checks to see if the RfRegion property is set.
        /// </summary>
        internal bool IsSetRfRegion() => this.RfRegion != null;

        /// <summary>
        /// Gets and sets the property Rssi. 
        /// <para>
        /// The RSSI (received signal strength indicator) value.
        /// </para>
        /// </summary>
        public double? Rssi { get; set; }

        /// <summary>
        /// Checks to see if the Rssi property is set.
        /// </summary>
        internal bool IsSetRssi() => this.Rssi.HasValue;

        /// <summary>
        /// Gets and sets the property Snr. 
        /// <para>
        /// The SNR (signal to noise ratio) value.
        /// </para>
        /// </summary>
        public double? Snr { get; set; }

        /// <summary>
        /// Checks to see if the Snr property is set.
        /// </summary>
        internal bool IsSetSnr() => this.Snr.HasValue;
    }
}
