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
    /// The cell towers that were used to perform the measurements.
    /// </summary>
    public partial class CellTowers
    {
        private List<CdmaObj> _cdma = new List<CdmaObj>();
        private List<GsmObj> _gsm = new List<GsmObj>();
        private List<LteObj> _lte = new List<LteObj>();
        private List<TdscdmaObj> _tdscdma = new List<TdscdmaObj>();
        private List<WcdmaObj> _wcdma = new List<WcdmaObj>();

        /// <summary>
        /// Gets and sets the property Cdma. 
        /// <para>
        /// CDMA object information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<CdmaObj> Cdma
        {
            get { return this._cdma; }
            set { this._cdma = value; }
        }

        // Check to see if Cdma property is set
        internal bool IsSetCdma()
        {
            return this._cdma != null && this._cdma.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Gsm. 
        /// <para>
        /// GSM object information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<GsmObj> Gsm
        {
            get { return this._gsm; }
            set { this._gsm = value; }
        }

        // Check to see if Gsm property is set
        internal bool IsSetGsm()
        {
            return this._gsm != null && this._gsm.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Lte. 
        /// <para>
        /// LTE object information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<LteObj> Lte
        {
            get { return this._lte; }
            set { this._lte = value; }
        }

        // Check to see if Lte property is set
        internal bool IsSetLte()
        {
            return this._lte != null && this._lte.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tdscdma. 
        /// <para>
        /// TD-SCDMA object information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<TdscdmaObj> Tdscdma
        {
            get { return this._tdscdma; }
            set { this._tdscdma = value; }
        }

        // Check to see if Tdscdma property is set
        internal bool IsSetTdscdma()
        {
            return this._tdscdma != null && this._tdscdma.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Wcdma. 
        /// <para>
        /// WCDMA object information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<WcdmaObj> Wcdma
        {
            get { return this._wcdma; }
            set { this._wcdma = value; }
        }

        // Check to see if Wcdma property is set
        internal bool IsSetWcdma()
        {
            return this._wcdma != null && this._wcdma.Count > 0; 
        }

    }
}