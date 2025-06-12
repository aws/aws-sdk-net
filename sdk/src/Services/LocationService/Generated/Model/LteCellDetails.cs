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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
        private int? _cellId;
        private LteLocalId _localId;
        private int? _mcc;
        private int? _mnc;
        private List<LteNetworkMeasurements> _networkMeasurements = AWSConfigs.InitializeCollections ? new List<LteNetworkMeasurements>() : null;
        private bool? _nrCapable;
        private int? _rsrp;
        private float? _rsrq;
        private int? _tac;
        private int? _timingAdvance;

        /// <summary>
        /// Gets and sets the property CellId. 
        /// <para>
        /// The E-UTRAN Cell Identifier (ECI).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=268435455)]
        public int? CellId
        {
            get { return this._cellId; }
            set { this._cellId = value; }
        }

        // Check to see if CellId property is set
        internal bool IsSetCellId()
        {
            return this._cellId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalId. 
        /// <para>
        /// The LTE local identification information (local ID).
        /// </para>
        /// </summary>
        public LteLocalId LocalId
        {
            get { return this._localId; }
            set { this._localId = value; }
        }

        // Check to see if LocalId property is set
        internal bool IsSetLocalId()
        {
            return this._localId != null;
        }

        /// <summary>
        /// Gets and sets the property Mcc. 
        /// <para>
        /// The Mobile Country Code (MCC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=200, Max=999)]
        public int? Mcc
        {
            get { return this._mcc; }
            set { this._mcc = value; }
        }

        // Check to see if Mcc property is set
        internal bool IsSetMcc()
        {
            return this._mcc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mnc. 
        /// <para>
        /// The Mobile Network Code (MNC)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=999)]
        public int? Mnc
        {
            get { return this._mnc; }
            set { this._mnc = value; }
        }

        // Check to see if Mnc property is set
        internal bool IsSetMnc()
        {
            return this._mnc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkMeasurements. 
        /// <para>
        /// The network measurements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<LteNetworkMeasurements> NetworkMeasurements
        {
            get { return this._networkMeasurements; }
            set { this._networkMeasurements = value; }
        }

        // Check to see if NetworkMeasurements property is set
        internal bool IsSetNetworkMeasurements()
        {
            return this._networkMeasurements != null && (this._networkMeasurements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NrCapable. 
        /// <para>
        /// Indicates whether the LTE object is capable of supporting NR (new radio).
        /// </para>
        /// </summary>
        public bool? NrCapable
        {
            get { return this._nrCapable; }
            set { this._nrCapable = value; }
        }

        // Check to see if NrCapable property is set
        internal bool IsSetNrCapable()
        {
            return this._nrCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rsrp. 
        /// <para>
        /// Signal power of the reference signal received, measured in decibel-milliwatts (dBm).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-140, Max=-44)]
        public int? Rsrp
        {
            get { return this._rsrp; }
            set { this._rsrp = value; }
        }

        // Check to see if Rsrp property is set
        internal bool IsSetRsrp()
        {
            return this._rsrp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rsrq. 
        /// <para>
        /// Signal quality of the reference Signal received, measured in decibels (dB).
        /// </para>
        /// </summary>
        [AWSProperty(Max=-3)]
        public float? Rsrq
        {
            get { return this._rsrq; }
            set { this._rsrq = value; }
        }

        // Check to see if Rsrq property is set
        internal bool IsSetRsrq()
        {
            return this._rsrq.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tac. 
        /// <para>
        /// LTE Tracking Area Code (TAC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? Tac
        {
            get { return this._tac; }
            set { this._tac = value; }
        }

        // Check to see if Tac property is set
        internal bool IsSetTac()
        {
            return this._tac.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimingAdvance. 
        /// <para>
        /// Timing Advance (TA).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1282)]
        public int? TimingAdvance
        {
            get { return this._timingAdvance; }
            set { this._timingAdvance = value; }
        }

        // Check to see if TimingAdvance property is set
        internal bool IsSetTimingAdvance()
        {
            return this._timingAdvance.HasValue; 
        }

    }
}