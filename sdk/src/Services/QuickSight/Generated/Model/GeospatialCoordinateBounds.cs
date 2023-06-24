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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The bound options (north, south, west, east) of the geospatial window options.
    /// </summary>
    public partial class GeospatialCoordinateBounds
    {
        private double? _east;
        private double? _north;
        private double? _south;
        private double? _west;

        /// <summary>
        /// Gets and sets the property East. 
        /// <para>
        /// The longitude of the east bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-1800, Max=1800)]
        public double East
        {
            get { return this._east.GetValueOrDefault(); }
            set { this._east = value; }
        }

        // Check to see if East property is set
        internal bool IsSetEast()
        {
            return this._east.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property North. 
        /// <para>
        /// The latitude of the north bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-90, Max=90)]
        public double North
        {
            get { return this._north.GetValueOrDefault(); }
            set { this._north = value; }
        }

        // Check to see if North property is set
        internal bool IsSetNorth()
        {
            return this._north.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property South. 
        /// <para>
        /// The latitude of the south bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-90, Max=90)]
        public double South
        {
            get { return this._south.GetValueOrDefault(); }
            set { this._south = value; }
        }

        // Check to see if South property is set
        internal bool IsSetSouth()
        {
            return this._south.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property West. 
        /// <para>
        /// The longitude of the west bound of the geospatial coordinate bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-1800, Max=1800)]
        public double West
        {
            get { return this._west.GetValueOrDefault(); }
            set { this._west = value; }
        }

        // Check to see if West property is set
        internal bool IsSetWest()
        {
            return this._west.HasValue; 
        }

    }
}