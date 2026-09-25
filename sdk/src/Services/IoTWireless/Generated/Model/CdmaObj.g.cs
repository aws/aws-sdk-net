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
    /// CDMA (Code-division multiple access) object.
    /// </summary>
    public partial class CdmaObj
    {
        /// <summary>
        /// Gets and sets the property BaseLat. 
        /// <para>
        /// CDMA base station latitude in degrees.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -90, Max = 90)]
        public float? BaseLat { get; set; }

        /// <summary>
        /// Checks to see if the BaseLat property is set.
        /// </summary>
        internal bool IsSetBaseLat() => this.BaseLat.HasValue;

        /// <summary>
        /// Gets and sets the property BaseLng. 
        /// <para>
        /// CDMA base station longitude in degrees.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -180, Max = 180)]
        public float? BaseLng { get; set; }

        /// <summary>
        /// Checks to see if the BaseLng property is set.
        /// </summary>
        internal bool IsSetBaseLng() => this.BaseLng.HasValue;

        /// <summary>
        /// Gets and sets the property BaseStationId. 
        /// <para>
        /// CDMA base station ID (BSID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 65535)]
        public int? BaseStationId { get; set; }

        /// <summary>
        /// Checks to see if the BaseStationId property is set.
        /// </summary>
        internal bool IsSetBaseStationId() => this.BaseStationId.HasValue;

        /// <summary>
        /// Gets and sets the property CdmaLocalId. 
        /// <para>
        /// CDMA local identification (local ID) parameters.
        /// </para>
        /// </summary>
        public CdmaLocalId CdmaLocalId { get; set; }

        /// <summary>
        /// Checks to see if the CdmaLocalId property is set.
        /// </summary>
        internal bool IsSetCdmaLocalId() => this.CdmaLocalId != null;

        /// <summary>
        /// Gets and sets the property CdmaNmr. 
        /// <para>
        /// CDMA network measurement reports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<CdmaNmrObj> CdmaNmr { get; set; } = AWSConfigs.InitializeCollections ? new List<CdmaNmrObj>() : null;

        /// <summary>
        /// Checks to see if the CdmaNmr property is set.
        /// </summary>
        internal bool IsSetCdmaNmr() => this.CdmaNmr != null && (this.CdmaNmr.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// CDMA network ID (NID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 65535)]
        public int? NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId.HasValue;

        /// <summary>
        /// Gets and sets the property PilotPower. 
        /// <para>
        /// Transmit power level of the pilot signal, measured in dBm (decibel-milliwatts).
        /// </para>
        /// </summary>
        [AWSProperty(Min = -142, Max = -49)]
        public int? PilotPower { get; set; }

        /// <summary>
        /// Checks to see if the PilotPower property is set.
        /// </summary>
        internal bool IsSetPilotPower() => this.PilotPower.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrationZone. 
        /// <para>
        /// CDMA registration zone (RZ).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4095)]
        public int? RegistrationZone { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationZone property is set.
        /// </summary>
        internal bool IsSetRegistrationZone() => this.RegistrationZone.HasValue;

        /// <summary>
        /// Gets and sets the property SystemId. 
        /// <para>
        /// CDMA system ID (SID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32767)]
        public int? SystemId { get; set; }

        /// <summary>
        /// Checks to see if the SystemId property is set.
        /// </summary>
        internal bool IsSetSystemId() => this.SystemId.HasValue;
    }
}
