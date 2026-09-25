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
    /// LTE object for network measurement reports.
    /// </summary>
    public partial class LteNmrObj
    {
        /// <summary>
        /// Gets and sets the property Earfcn. 
        /// <para>
        /// E-UTRA (Evolved universal terrestrial Radio Access) absolute radio frequency channel
        /// Number (EARFCN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 262143)]
        public int? Earfcn { get; set; }

        /// <summary>
        /// Checks to see if the Earfcn property is set.
        /// </summary>
        internal bool IsSetEarfcn() => this.Earfcn.HasValue;

        /// <summary>
        /// Gets and sets the property EutranCid. 
        /// <para>
        /// E-UTRAN (Evolved Universal Terrestrial Radio Access Network) cell global identifier
        /// (EUTRANCID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 268435455)]
        public int? EutranCid { get; set; }

        /// <summary>
        /// Checks to see if the EutranCid property is set.
        /// </summary>
        internal bool IsSetEutranCid() => this.EutranCid.HasValue;

        /// <summary>
        /// Gets and sets the property Pci. 
        /// <para>
        /// Physical cell ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 503)]
        public int? Pci { get; set; }

        /// <summary>
        /// Checks to see if the Pci property is set.
        /// </summary>
        internal bool IsSetPci() => this.Pci.HasValue;

        /// <summary>
        /// Gets and sets the property Rsrp. 
        /// <para>
        /// Signal power of the reference signal received, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min = -140, Max = -44)]
        public int? Rsrp { get; set; }

        /// <summary>
        /// Checks to see if the Rsrp property is set.
        /// </summary>
        internal bool IsSetRsrp() => this.Rsrp.HasValue;

        /// <summary>
        /// Gets and sets the property Rsrq. 
        /// <para>
        /// Signal quality of the reference Signal received, measured in decibels (dB).
        /// </para>
        /// </summary>
        [AWSProperty(Max = -3)]
        public float? Rsrq { get; set; }

        /// <summary>
        /// Checks to see if the Rsrq property is set.
        /// </summary>
        internal bool IsSetRsrq() => this.Rsrq.HasValue;
    }
}
