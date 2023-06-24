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
    /// TD-SCDMA object for network measurement reports.
    /// </summary>
    public partial class TdscdmaNmrObj
    {
        private int? _cellParams;
        private int? _pathLoss;
        private int? _rscp;
        private int? _uarfcn;
        private int? _utranCid;

        /// <summary>
        /// Gets and sets the property CellParams. 
        /// <para>
        /// Cell parameters for TD-SCDMA network measurement reports object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=127)]
        public int CellParams
        {
            get { return this._cellParams.GetValueOrDefault(); }
            set { this._cellParams = value; }
        }

        // Check to see if CellParams property is set
        internal bool IsSetCellParams()
        {
            return this._cellParams.HasValue; 
        }

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
        /// Gets and sets the property Rscp. 
        /// <para>
        /// Code power of the received signal, measured in decibel-milliwatts (dBm).
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
        /// Gets and sets the property Uarfcn. 
        /// <para>
        /// TD-SCDMA UTRA (Universal Terrestrial Radio Access Network) absolute RF channel number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=16383)]
        public int Uarfcn
        {
            get { return this._uarfcn.GetValueOrDefault(); }
            set { this._uarfcn = value; }
        }

        // Check to see if Uarfcn property is set
        internal bool IsSetUarfcn()
        {
            return this._uarfcn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtranCid. 
        /// <para>
        /// UTRAN (UMTS Terrestrial Radio Access Network) cell global identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=268435455)]
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