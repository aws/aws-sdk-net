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
    /// Information about the ground station data.
    /// </summary>
    public partial class GroundStationData
    {
        /// <summary>
        /// Gets and sets the property GroundStationId. 
        /// <para>
        /// ID of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 97)]
        public string GroundStationId { get; set; }

        /// <summary>
        /// Checks to see if the GroundStationId property is set.
        /// </summary>
        internal bool IsSetGroundStationId() => this.GroundStationId != null;

        /// <summary>
        /// Gets and sets the property GroundStationName. 
        /// <para>
        /// Name of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 97)]
        public string GroundStationName { get; set; }

        /// <summary>
        /// Checks to see if the GroundStationName property is set.
        /// </summary>
        internal bool IsSetGroundStationName() => this.GroundStationName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Ground station Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
