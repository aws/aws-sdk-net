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
    /// LoRaWANGateway object.
    /// </summary>
    public partial class LoRaWANGateway
    {
        /// <summary>
        /// Gets and sets the property Beaconing. 
        /// <para>
        /// Beaconing object information, which consists of the data rate and frequency parameters.
        /// </para>
        /// </summary>
        public Beaconing Beaconing { get; set; }

        /// <summary>
        /// Checks to see if the Beaconing property is set.
        /// </summary>
        internal bool IsSetBeaconing() => this.Beaconing != null;

        /// <summary>
        /// Gets and sets the property GatewayEui. 
        /// <para>
        /// The gateway's EUI value.
        /// </para>
        /// </summary>
        public string GatewayEui { get; set; }

        /// <summary>
        /// Checks to see if the GatewayEui property is set.
        /// </summary>
        internal bool IsSetGatewayEui() => this.GatewayEui != null;

        /// <summary>
        /// Gets and sets the property JoinEuiFilters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<List<string>> JoinEuiFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the JoinEuiFilters property is set.
        /// </summary>
        internal bool IsSetJoinEuiFilters() => this.JoinEuiFilters != null && (this.JoinEuiFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxEirp. 
        /// <para>
        /// The MaxEIRP value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public float? MaxEirp { get; set; }

        /// <summary>
        /// Checks to see if the MaxEirp property is set.
        /// </summary>
        internal bool IsSetMaxEirp() => this.MaxEirp.HasValue;

        /// <summary>
        /// Gets and sets the property NetIdFilters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> NetIdFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetIdFilters property is set.
        /// </summary>
        internal bool IsSetNetIdFilters() => this.NetIdFilters != null && (this.NetIdFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RfRegion. 
        /// <para>
        /// The frequency band (RFRegion) value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RfRegion { get; set; }

        /// <summary>
        /// Checks to see if the RfRegion property is set.
        /// </summary>
        internal bool IsSetRfRegion() => this.RfRegion != null;

        /// <summary>
        /// Gets and sets the property SubBands.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public List<int> SubBands { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the SubBands property is set.
        /// </summary>
        internal bool IsSetSubBands() => this.SubBands != null && (this.SubBands.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
