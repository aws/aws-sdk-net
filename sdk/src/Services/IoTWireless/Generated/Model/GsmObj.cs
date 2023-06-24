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
    /// GSM object.
    /// </summary>
    public partial class GsmObj
    {
        private int? _geranCid;
        private GsmLocalId _gsmLocalId;
        private List<GsmNmrObj> _gsmNmr = new List<GsmNmrObj>();
        private int? _gsmTimingAdvance;
        private int? _lac;
        private int? _mcc;
        private int? _mnc;
        private int? _rxLevel;

        /// <summary>
        /// Gets and sets the property GeranCid. 
        /// <para>
        /// GERAN (GSM EDGE Radio Access Network) Cell Global Identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int GeranCid
        {
            get { return this._geranCid.GetValueOrDefault(); }
            set { this._geranCid = value; }
        }

        // Check to see if GeranCid property is set
        internal bool IsSetGeranCid()
        {
            return this._geranCid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GsmLocalId. 
        /// <para>
        /// GSM local identification (local ID) information.
        /// </para>
        /// </summary>
        public GsmLocalId GsmLocalId
        {
            get { return this._gsmLocalId; }
            set { this._gsmLocalId = value; }
        }

        // Check to see if GsmLocalId property is set
        internal bool IsSetGsmLocalId()
        {
            return this._gsmLocalId != null;
        }

        /// <summary>
        /// Gets and sets the property GsmNmr. 
        /// <para>
        /// GSM object for network measurement reports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<GsmNmrObj> GsmNmr
        {
            get { return this._gsmNmr; }
            set { this._gsmNmr = value; }
        }

        // Check to see if GsmNmr property is set
        internal bool IsSetGsmNmr()
        {
            return this._gsmNmr != null && this._gsmNmr.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GsmTimingAdvance. 
        /// <para>
        /// Timing advance value, which corresponds to the length of time a signal takes to reach
        /// the base station from a mobile phone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public int GsmTimingAdvance
        {
            get { return this._gsmTimingAdvance.GetValueOrDefault(); }
            set { this._gsmTimingAdvance = value; }
        }

        // Check to see if GsmTimingAdvance property is set
        internal bool IsSetGsmTimingAdvance()
        {
            return this._gsmTimingAdvance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lac. 
        /// <para>
        /// Location area code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int Lac
        {
            get { return this._lac.GetValueOrDefault(); }
            set { this._lac = value; }
        }

        // Check to see if Lac property is set
        internal bool IsSetLac()
        {
            return this._lac.HasValue; 
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
        /// Gets and sets the property RxLevel. 
        /// <para>
        /// Rx level, which is the received signal power, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-110, Max=-25)]
        public int RxLevel
        {
            get { return this._rxLevel.GetValueOrDefault(); }
            set { this._rxLevel = value; }
        }

        // Check to see if RxLevel property is set
        internal bool IsSetRxLevel()
        {
            return this._rxLevel.HasValue; 
        }

    }
}