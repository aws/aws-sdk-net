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
    /// The window options of the geospatial map visual.
    /// </summary>
    public partial class GeospatialWindowOptions
    {
        private GeospatialCoordinateBounds _bounds;
        private MapZoomMode _mapZoomMode;

        /// <summary>
        /// Gets and sets the property Bounds. 
        /// <para>
        /// The bounds options (north, south, west, east) of the geospatial window options.
        /// </para>
        /// </summary>
        public GeospatialCoordinateBounds Bounds
        {
            get { return this._bounds; }
            set { this._bounds = value; }
        }

        // Check to see if Bounds property is set
        internal bool IsSetBounds()
        {
            return this._bounds != null;
        }

        /// <summary>
        /// Gets and sets the property MapZoomMode. 
        /// <para>
        /// The map zoom modes (manual, auto) of the geospatial window options.
        /// </para>
        /// </summary>
        public MapZoomMode MapZoomMode
        {
            get { return this._mapZoomMode; }
            set { this._mapZoomMode = value; }
        }

        // Check to see if MapZoomMode property is set
        internal bool IsSetMapZoomMode()
        {
            return this._mapZoomMode != null;
        }

    }
}