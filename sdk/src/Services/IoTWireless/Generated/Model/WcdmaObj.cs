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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// WCDMA.
    /// </summary>
    public partial class WcdmaObj
    {
        private int? _lac;
        private int? _mcc;
        private int? _mnc;
        private int? _pathLoss;
        private int? _rscp;
        private int? _utranCid;
        private WcdmaLocalId _wcdmaLocalId;
        private List<WcdmaNmrObj> _wcdmaNmr = AWSConfigs.InitializeCollections ? new List<WcdmaNmrObj>() : null;

        /// <summary>
        /// Gets and sets the property Lac. 
        /// <para>
        /// Location Area Code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? Lac
        {
            get { return this._lac; }
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
        /// Mobile Network Code.
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
        /// Gets and sets the property PathLoss. 
        /// <para>
        /// Path loss, or path attenuation, is the reduction in power density of an electromagnetic
        /// wave as it propagates through space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=46, Max=158)]
        public int? PathLoss
        {
            get { return this._pathLoss; }
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
        /// Received Signal Code Power (signal power) (dBm).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-120, Max=-25)]
        public int? Rscp
        {
            get { return this._rscp; }
            set { this._rscp = value; }
        }

        // Check to see if Rscp property is set
        internal bool IsSetRscp()
        {
            return this._rscp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtranCid. 
        /// <para>
        /// UTRAN (UMTS Terrestrial Radio Access Network) Cell Global Identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=268435455)]
        public int? UtranCid
        {
            get { return this._utranCid; }
            set { this._utranCid = value; }
        }

        // Check to see if UtranCid property is set
        internal bool IsSetUtranCid()
        {
            return this._utranCid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WcdmaLocalId. 
        /// <para>
        /// WCDMA local ID information.
        /// </para>
        /// </summary>
        public WcdmaLocalId WcdmaLocalId
        {
            get { return this._wcdmaLocalId; }
            set { this._wcdmaLocalId = value; }
        }

        // Check to see if WcdmaLocalId property is set
        internal bool IsSetWcdmaLocalId()
        {
            return this._wcdmaLocalId != null;
        }

        /// <summary>
        /// Gets and sets the property WcdmaNmr. 
        /// <para>
        /// WCDMA object for network measurement reports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<WcdmaNmrObj> WcdmaNmr
        {
            get { return this._wcdmaNmr; }
            set { this._wcdmaNmr = value; }
        }

        // Check to see if WcdmaNmr property is set
        internal bool IsSetWcdmaNmr()
        {
            return this._wcdmaNmr != null && (this._wcdmaNmr.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}