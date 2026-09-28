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
    /// TD-SCDMA object.
    /// </summary>
    public partial class TdscdmaObj
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
        /// Signal power of the received signal (Received Signal Code Power), measured in decibel-milliwatts
        /// (dBm).
        /// </para>
        /// </summary>
        [AWSProperty(Min = -120, Max = -25)]
        public int? Rscp { get; set; }

        /// <summary>
        /// Checks to see if the Rscp property is set.
        /// </summary>
        internal bool IsSetRscp() => this.Rscp.HasValue;

        /// <summary>
        /// Gets and sets the property TdscdmaLocalId. 
        /// <para>
        /// TD-SCDMA local identification (local ID) information.
        /// </para>
        /// </summary>
        public TdscdmaLocalId TdscdmaLocalId { get; set; }

        /// <summary>
        /// Checks to see if the TdscdmaLocalId property is set.
        /// </summary>
        internal bool IsSetTdscdmaLocalId() => this.TdscdmaLocalId != null;

        /// <summary>
        /// Gets and sets the property TdscdmaNmr. 
        /// <para>
        /// TD-SCDMA object for network measurement reports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<TdscdmaNmrObj> TdscdmaNmr { get; set; } = AWSConfigs.InitializeCollections ? new List<TdscdmaNmrObj>() : null;

        /// <summary>
        /// Checks to see if the TdscdmaNmr property is set.
        /// </summary>
        internal bool IsSetTdscdmaNmr() => this.TdscdmaNmr != null && (this.TdscdmaNmr.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TdscdmaTimingAdvance. 
        /// <para>
        /// TD-SCDMA Timing advance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1530)]
        public int? TdscdmaTimingAdvance { get; set; }

        /// <summary>
        /// Checks to see if the TdscdmaTimingAdvance property is set.
        /// </summary>
        internal bool IsSetTdscdmaTimingAdvance() => this.TdscdmaTimingAdvance.HasValue;

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
    }
}
