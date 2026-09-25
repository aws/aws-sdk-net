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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Details about the Long-Term Evolution (LTE) network.
    /// </summary>
    public partial class LteCellDetails
    {
        /// <summary>
        /// Gets and sets the property CellId. 
        /// <para>
        /// The E-UTRAN Cell Identifier (ECI).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 268435455)]
        public int? CellId { get; set; }

        /// <summary>
        /// Checks to see if the CellId property is set.
        /// </summary>
        internal bool IsSetCellId() => this.CellId.HasValue;

        /// <summary>
        /// Gets and sets the property LocalId. 
        /// <para>
        /// The LTE local identification information (local ID).
        /// </para>
        /// </summary>
        public LteLocalId LocalId { get; set; }

        /// <summary>
        /// Checks to see if the LocalId property is set.
        /// </summary>
        internal bool IsSetLocalId() => this.LocalId != null;

        /// <summary>
        /// Gets and sets the property Mcc. 
        /// <para>
        /// The Mobile Country Code (MCC).
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
        /// The Mobile Network Code (MNC)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 999)]
        public int? Mnc { get; set; }

        /// <summary>
        /// Checks to see if the Mnc property is set.
        /// </summary>
        internal bool IsSetMnc() => this.Mnc.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkMeasurements. 
        /// <para>
        /// The network measurements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<LteNetworkMeasurements> NetworkMeasurements { get; set; } = AWSConfigs.InitializeCollections ? new List<LteNetworkMeasurements>() : null;

        /// <summary>
        /// Checks to see if the NetworkMeasurements property is set.
        /// </summary>
        internal bool IsSetNetworkMeasurements() => this.NetworkMeasurements != null && (this.NetworkMeasurements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NrCapable. 
        /// <para>
        /// Indicates whether the LTE object is capable of supporting NR (new radio).
        /// </para>
        /// </summary>
        public bool? NrCapable { get; set; }

        /// <summary>
        /// Checks to see if the NrCapable property is set.
        /// </summary>
        internal bool IsSetNrCapable() => this.NrCapable.HasValue;

        /// <summary>
        /// Gets and sets the property Rsrp. 
        /// <para>
        /// Signal power of the reference signal received, measured in decibel-milliwatts (dBm).
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

        /// <summary>
        /// Gets and sets the property Tac. 
        /// <para>
        /// LTE Tracking Area Code (TAC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? Tac { get; set; }

        /// <summary>
        /// Checks to see if the Tac property is set.
        /// </summary>
        internal bool IsSetTac() => this.Tac.HasValue;

        /// <summary>
        /// Gets and sets the property TimingAdvance. 
        /// <para>
        /// Timing Advance (TA).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1282)]
        public int? TimingAdvance { get; set; }

        /// <summary>
        /// Checks to see if the TimingAdvance property is set.
        /// </summary>
        internal bool IsSetTimingAdvance() => this.TimingAdvance.HasValue;
    }
}
