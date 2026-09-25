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
    /// WCDMA.
    /// </summary>
    public partial class WcdmaObj
    {
        /// <summary>
        /// Gets and sets the property Lac. 
        /// <para>
        /// Location Area Code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Lac { get; set; }

        /// <summary>
        /// Checks to see if the Lac property is set.
        /// </summary>
        internal bool IsSetLac() => this.Lac.HasValue;

        /// <summary>
        /// Gets and sets the property Mcc. 
        /// <para>
        /// Mobile Country Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 200, Max = 999)]
        public int? Mcc { get; set; }

        /// <summary>
        /// Checks to see if the Mcc property is set.
        /// </summary>
        internal bool IsSetMcc() => this.Mcc.HasValue;

        /// <summary>
        /// Gets and sets the property Mnc. 
        /// <para>
        /// Mobile Network Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 999)]
        public int? Mnc { get; set; }

        /// <summary>
        /// Checks to see if the Mnc property is set.
        /// </summary>
        internal bool IsSetMnc() => this.Mnc.HasValue;

        /// <summary>
        /// Gets and sets the property PathLoss. 
        /// <para>
        /// Path loss, or path attenuation, is the reduction in power density of an electromagnetic
        /// wave as it propagates through space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 46, Max = 158)]
        public int? PathLoss { get; set; }

        /// <summary>
        /// Checks to see if the PathLoss property is set.
        /// </summary>
        internal bool IsSetPathLoss() => this.PathLoss.HasValue;

        /// <summary>
        /// Gets and sets the property Rscp. 
        /// <para>
        /// Received Signal Code Power (signal power) (dBm).
        /// </para>
        /// </summary>
        [AWSProperty(Min = -120, Max = -25)]
        public int? Rscp { get; set; }

        /// <summary>
        /// Checks to see if the Rscp property is set.
        /// </summary>
        internal bool IsSetRscp() => this.Rscp.HasValue;

        /// <summary>
        /// Gets and sets the property UtranCid. 
        /// <para>
        /// UTRAN (UMTS Terrestrial Radio Access Network) Cell Global Identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 268435455)]
        public int? UtranCid { get; set; }

        /// <summary>
        /// Checks to see if the UtranCid property is set.
        /// </summary>
        internal bool IsSetUtranCid() => this.UtranCid.HasValue;

        /// <summary>
        /// Gets and sets the property WcdmaLocalId. 
        /// <para>
        /// WCDMA local ID information.
        /// </para>
        /// </summary>
        public WcdmaLocalId WcdmaLocalId { get; set; }

        /// <summary>
        /// Checks to see if the WcdmaLocalId property is set.
        /// </summary>
        internal bool IsSetWcdmaLocalId() => this.WcdmaLocalId != null;

        /// <summary>
        /// Gets and sets the property WcdmaNmr. 
        /// <para>
        /// WCDMA object for network measurement reports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<WcdmaNmrObj> WcdmaNmr { get; set; } = AWSConfigs.InitializeCollections ? new List<WcdmaNmrObj>() : null;

        /// <summary>
        /// Checks to see if the WcdmaNmr property is set.
        /// </summary>
        internal bool IsSetWcdmaNmr() => this.WcdmaNmr != null && (this.WcdmaNmr.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
