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
    /// Network Measurement Reports.
    /// </summary>
    public partial class WcdmaNmrObj
    {
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
        /// Gets and sets the property Psc. 
        /// <para>
        /// Primary Scrambling Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 511)]
        public int? Psc { get; set; }

        /// <summary>
        /// Checks to see if the Psc property is set.
        /// </summary>
        internal bool IsSetPsc() => this.Psc.HasValue;

        /// <summary>
        /// Gets and sets the property Rscp. 
        /// <para>
        /// Received Signal Code Power (signal power) (dBm)
        /// </para>
        /// </summary>
        [AWSProperty(Min = -120, Max = -25)]
        public int? Rscp { get; set; }

        /// <summary>
        /// Checks to see if the Rscp property is set.
        /// </summary>
        internal bool IsSetRscp() => this.Rscp.HasValue;

        /// <summary>
        /// Gets and sets the property Uarfcndl. 
        /// <para>
        /// WCDMA UTRA Absolute RF Channel Number downlink.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 16383)]
        public int? Uarfcndl { get; set; }

        /// <summary>
        /// Checks to see if the Uarfcndl property is set.
        /// </summary>
        internal bool IsSetUarfcndl() => this.Uarfcndl.HasValue;

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
