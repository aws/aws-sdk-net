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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The bound options (north, south, west, east) of the geospatial window options.
    /// </summary>
    public partial class GeospatialCoordinateBounds
    {
        /// <summary>
        /// Gets and sets the property East. 
        /// <para>
        /// The longitude of the east bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -1800, Max = 1800)]
        public double? East { get; set; }

        /// <summary>
        /// Checks to see if the East property is set.
        /// </summary>
        internal bool IsSetEast() => this.East.HasValue;

        /// <summary>
        /// Gets and sets the property North. 
        /// <para>
        /// The latitude of the north bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -90, Max = 90)]
        public double? North { get; set; }

        /// <summary>
        /// Checks to see if the North property is set.
        /// </summary>
        internal bool IsSetNorth() => this.North.HasValue;

        /// <summary>
        /// Gets and sets the property South. 
        /// <para>
        /// The latitude of the south bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -90, Max = 90)]
        public double? South { get; set; }

        /// <summary>
        /// Checks to see if the South property is set.
        /// </summary>
        internal bool IsSetSouth() => this.South.HasValue;

        /// <summary>
        /// Gets and sets the property West. 
        /// <para>
        /// The longitude of the west bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -1800, Max = 1800)]
        public double? West { get; set; }

        /// <summary>
        /// Checks to see if the West property is set.
        /// </summary>
        internal bool IsSetWest() => this.West.HasValue;
    }
}
