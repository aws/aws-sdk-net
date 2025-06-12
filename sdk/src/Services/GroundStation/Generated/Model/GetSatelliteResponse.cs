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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetSatelliteResponse : AmazonWebServiceResponse
    {
        private EphemerisMetaData _currentEphemeris;
        private List<string> _groundStations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _noradSatelliteID;
        private string _satelliteArn;
        private string _satelliteId;

        /// <summary>
        /// Gets and sets the property CurrentEphemeris. 
        /// <para>
        /// The current ephemeris being used to compute the trajectory of the satellite.
        /// </para>
        /// </summary>
        public EphemerisMetaData CurrentEphemeris
        {
            get { return this._currentEphemeris; }
            set { this._currentEphemeris = value; }
        }

        // Check to see if CurrentEphemeris property is set
        internal bool IsSetCurrentEphemeris()
        {
            return this._currentEphemeris != null;
        }

        /// <summary>
        /// Gets and sets the property GroundStations. 
        /// <para>
        /// A list of ground stations to which the satellite is on-boarded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<string> GroundStations
        {
            get { return this._groundStations; }
            set { this._groundStations = value; }
        }

        // Check to see if GroundStations property is set
        internal bool IsSetGroundStations()
        {
            return this._groundStations != null && (this._groundStations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NoradSatelliteID. 
        /// <para>
        /// NORAD satellite ID number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=99999)]
        public int? NoradSatelliteID
        {
            get { return this._noradSatelliteID; }
            set { this._noradSatelliteID = value; }
        }

        // Check to see if NoradSatelliteID property is set
        internal bool IsSetNoradSatelliteID()
        {
            return this._noradSatelliteID.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=82, Max=132)]
        public string SatelliteArn
        {
            get { return this._satelliteArn; }
            set { this._satelliteArn = value; }
        }

        // Check to see if SatelliteArn property is set
        internal bool IsSetSatelliteArn()
        {
            return this._satelliteArn != null;
        }

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// UUID of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SatelliteId
        {
            get { return this._satelliteId; }
            set { this._satelliteId = value; }
        }

        // Check to see if SatelliteId property is set
        internal bool IsSetSatelliteId()
        {
            return this._satelliteId != null;
        }

    }
}