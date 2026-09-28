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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Item in a list of satellites.
    /// </summary>
    public partial class SatelliteListItem
    {
        /// <summary>
        /// Gets and sets the property CurrentEphemeris. 
        /// <para>
        /// The current ephemeris being used to compute the trajectory of the satellite.
        /// </para>
        /// </summary>
        public EphemerisMetaData CurrentEphemeris { get; set; }

        /// <summary>
        /// Checks to see if the CurrentEphemeris property is set.
        /// </summary>
        internal bool IsSetCurrentEphemeris() => this.CurrentEphemeris != null;

        /// <summary>
        /// Gets and sets the property GroundStations. 
        /// <para>
        /// A list of ground stations to which the satellite is on-boarded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<string> GroundStations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GroundStations property is set.
        /// </summary>
        internal bool IsSetGroundStations() => this.GroundStations != null && (this.GroundStations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoradSatelliteID. 
        /// <para>
        /// NORAD satellite ID number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 339999)]
        public int? NoradSatelliteID { get; set; }

        /// <summary>
        /// Checks to see if the NoradSatelliteID property is set.
        /// </summary>
        internal bool IsSetNoradSatelliteID() => this.NoradSatelliteID.HasValue;

        /// <summary>
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 82, Max = 132)]
        public string SatelliteArn { get; set; }

        /// <summary>
        /// Checks to see if the SatelliteArn property is set.
        /// </summary>
        internal bool IsSetSatelliteArn() => this.SatelliteArn != null;

        /// <summary>
        /// Gets and sets the property SatelliteId. 
        /// <para>
        /// UUID of a satellite.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SatelliteId { get; set; }

        /// <summary>
        /// Checks to see if the SatelliteId property is set.
        /// </summary>
        internal bool IsSetSatelliteId() => this.SatelliteId != null;
    }
}
