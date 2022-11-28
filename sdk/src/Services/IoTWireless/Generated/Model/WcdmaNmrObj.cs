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
    /// Network Measurement Reports.
    /// </summary>
    public partial class WcdmaNmrObj
    {
        private int? _pathLoss;
        private int? _psc;
        private int? _rscp;
        private int? _uarfcndl;
        private int? _utranCid;

        /// <summary>
        /// Gets and sets the property PathLoss. 
        /// <para>
        /// Path loss, or path attenuation, is the reduction in power density of an electromagnetic
        /// wave as it propagates through space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=46, Max=158)]
        public int PathLoss
        {
            get { return this._pathLoss.GetValueOrDefault(); }
            set { this._pathLoss = value; }
        }

        // Check to see if PathLoss property is set
        internal bool IsSetPathLoss()
        {
            return this._pathLoss.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Psc. 
        /// <para>
        /// Primary Scrambling Code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=511)]
        public int Psc
        {
            get { return this._psc.GetValueOrDefault(); }
            set { this._psc = value; }
        }

        // Check to see if Psc property is set
        internal bool IsSetPsc()
        {
            return this._psc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rscp. 
        /// <para>
        /// Received Signal Code Power (signal power) (dBm)
        /// </para>
        /// </summary>
        [AWSProperty(Min=-120, Max=-25)]
        public int Rscp
        {
            get { return this._rscp.GetValueOrDefault(); }
            set { this._rscp = value; }
        }

        // Check to see if Rscp property is set
        internal bool IsSetRscp()
        {
            return this._rscp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uarfcndl. 
        /// <para>
        /// WCDMA UTRA Absolute RF Channel Number downlink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=16383)]
        public int Uarfcndl
        {
            get { return this._uarfcndl.GetValueOrDefault(); }
            set { this._uarfcndl = value; }
        }

        // Check to see if Uarfcndl property is set
        internal bool IsSetUarfcndl()
        {
            return this._uarfcndl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtranCid. 
        /// <para>
        /// UTRAN (UMTS Terrestrial Radio Access Network) Cell Global Identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=268435455)]
        public int UtranCid
        {
            get { return this._utranCid.GetValueOrDefault(); }
            set { this._utranCid = value; }
        }

        // Check to see if UtranCid property is set
        internal bool IsSetUtranCid()
        {
            return this._utranCid.HasValue; 
        }

    }
}