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
    /// CDMA (Code-division multiple access) object.
    /// </summary>
    public partial class CdmaObj
    {
        private float? _baseLat;
        private float? _baseLng;
        private int? _baseStationId;
        private CdmaLocalId _cdmaLocalId;
        private List<CdmaNmrObj> _cdmaNmr = new List<CdmaNmrObj>();
        private int? _networkId;
        private int? _pilotPower;
        private int? _registrationZone;
        private int? _systemId;

        /// <summary>
        /// Gets and sets the property BaseLat. 
        /// <para>
        /// CDMA base station latitude in degrees.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-90, Max=90)]
        public float BaseLat
        {
            get { return this._baseLat.GetValueOrDefault(); }
            set { this._baseLat = value; }
        }

        // Check to see if BaseLat property is set
        internal bool IsSetBaseLat()
        {
            return this._baseLat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaseLng. 
        /// <para>
        /// CDMA base station longtitude in degrees.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-180, Max=180)]
        public float BaseLng
        {
            get { return this._baseLng.GetValueOrDefault(); }
            set { this._baseLng = value; }
        }

        // Check to see if BaseLng property is set
        internal bool IsSetBaseLng()
        {
            return this._baseLng.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaseStationId. 
        /// <para>
        /// CDMA base station ID (BSID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int BaseStationId
        {
            get { return this._baseStationId.GetValueOrDefault(); }
            set { this._baseStationId = value; }
        }

        // Check to see if BaseStationId property is set
        internal bool IsSetBaseStationId()
        {
            return this._baseStationId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CdmaLocalId. 
        /// <para>
        /// CDMA local identification (local ID) parameters.
        /// </para>
        /// </summary>
        public CdmaLocalId CdmaLocalId
        {
            get { return this._cdmaLocalId; }
            set { this._cdmaLocalId = value; }
        }

        // Check to see if CdmaLocalId property is set
        internal bool IsSetCdmaLocalId()
        {
            return this._cdmaLocalId != null;
        }

        /// <summary>
        /// Gets and sets the property CdmaNmr. 
        /// <para>
        /// CDMA network measurement reports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<CdmaNmrObj> CdmaNmr
        {
            get { return this._cdmaNmr; }
            set { this._cdmaNmr = value; }
        }

        // Check to see if CdmaNmr property is set
        internal bool IsSetCdmaNmr()
        {
            return this._cdmaNmr != null && this._cdmaNmr.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// CDMA network ID (NID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int NetworkId
        {
            get { return this._networkId.GetValueOrDefault(); }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PilotPower. 
        /// <para>
        /// Transmit power level of the pilot signal, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=-142, Max=-49)]
        public int PilotPower
        {
            get { return this._pilotPower.GetValueOrDefault(); }
            set { this._pilotPower = value; }
        }

        // Check to see if PilotPower property is set
        internal bool IsSetPilotPower()
        {
            return this._pilotPower.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistrationZone. 
        /// <para>
        /// CDMA registration zone (RZ).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4095)]
        public int RegistrationZone
        {
            get { return this._registrationZone.GetValueOrDefault(); }
            set { this._registrationZone = value; }
        }

        // Check to see if RegistrationZone property is set
        internal bool IsSetRegistrationZone()
        {
            return this._registrationZone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SystemId. 
        /// <para>
        /// CDMA system ID (SID).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32767)]
        public int SystemId
        {
            get { return this._systemId.GetValueOrDefault(); }
            set { this._systemId = value; }
        }

        // Check to see if SystemId property is set
        internal bool IsSetSystemId()
        {
            return this._systemId.HasValue; 
        }

    }
}