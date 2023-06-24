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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LTE object.
    /// </summary>
    public partial class LteObj
    {
        private int? _eutranCid;
        private LteLocalId _lteLocalId;
        private List<LteNmrObj> _lteNmr = new List<LteNmrObj>();
        private int? _lteTimingAdvance;
        private int? _mcc;
        private int? _mnc;
        private bool? _nrCapable;
        private int? _rsrp;
        private float? _rsrq;
        private int? _tac;

        /// <summary>
        /// Gets and sets the property EutranCid. 
        /// <para>
        /// E-UTRAN (Evolved Universal Terrestrial Radio Access Network) Cell Global Identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=268435455)]
        public int EutranCid
        {
            get { return this._eutranCid.GetValueOrDefault(); }
            set { this._eutranCid = value; }
        }

        // Check to see if EutranCid property is set
        internal bool IsSetEutranCid()
        {
            return this._eutranCid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LteLocalId. 
        /// <para>
        /// LTE local identification (local ID) information.
        /// </para>
        /// </summary>
        public LteLocalId LteLocalId
        {
            get { return this._lteLocalId; }
            set { this._lteLocalId = value; }
        }

        // Check to see if LteLocalId property is set
        internal bool IsSetLteLocalId()
        {
            return this._lteLocalId != null;
        }

        /// <summary>
        /// Gets and sets the property LteNmr. 
        /// <para>
        /// LTE object for network measurement reports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<LteNmrObj> LteNmr
        {
            get { return this._lteNmr; }
            set { this._lteNmr = value; }
        }

        // Check to see if LteNmr property is set
        internal bool IsSetLteNmr()
        {
            return this._lteNmr != null && this._lteNmr.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LteTimingAdvance. 
        /// <para>
        /// LTE timing advance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1282)]
        public int LteTimingAdvance
        {
            get { return this._lteTimingAdvance.GetValueOrDefault(); }
            set { this._lteTimingAdvance = value; }
        }

        // Check to see if LteTimingAdvance property is set
        internal bool IsSetLteTimingAdvance()
        {
            return this._lteTimingAdvance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mcc. 
        /// <para>
        /// Mobile Country Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=200, Max=999)]
        public int Mcc
        {
            get { return this._mcc.GetValueOrDefault(); }
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
        /// Mobile Network Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=999)]
        public int Mnc
        {
            get { return this._mnc.GetValueOrDefault(); }
            set { this._mnc = value; }
        }

        // Check to see if Mnc property is set
        internal bool IsSetMnc()
        {
            return this._mnc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NrCapable. 
        /// <para>
        /// Parameter that determines whether the LTE object is capable of supporting NR (new
        /// radio).
        /// </para>
        /// </summary>
        public bool NrCapable
        {
            get { return this._nrCapable.GetValueOrDefault(); }
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
        /// Signal power of the reference signal received, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-140, Max=-44)]
        public int Rsrp
        {
            get { return this._rsrp.GetValueOrDefault(); }
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
        public float Rsrq
        {
            get { return this._rsrq.GetValueOrDefault(); }
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
        /// LTE tracking area code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int Tac
        {
            get { return this._tac.GetValueOrDefault(); }
            set { this._tac = value; }
        }

        // Check to see if Tac property is set
        internal bool IsSetTac()
        {
            return this._tac.HasValue; 
        }

    }
}