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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition properties for a geospatial layer.
    /// </summary>
    public partial class GeospatialLayerDefinition
    {
        private GeospatialLineLayer _lineLayer;
        private GeospatialPointLayer _pointLayer;
        private GeospatialPolygonLayer _polygonLayer;

        /// <summary>
        /// Gets and sets the property LineLayer. 
        /// <para>
        /// The definition for a line layer.
        /// </para>
        /// </summary>
        public GeospatialLineLayer LineLayer
        {
            get { return this._lineLayer; }
            set { this._lineLayer = value; }
        }

        // Check to see if LineLayer property is set
        internal bool IsSetLineLayer()
        {
            return this._lineLayer != null;
        }

        /// <summary>
        /// Gets and sets the property PointLayer. 
        /// <para>
        /// The definition for a point layer.
        /// </para>
        /// </summary>
        public GeospatialPointLayer PointLayer
        {
            get { return this._pointLayer; }
            set { this._pointLayer = value; }
        }

        // Check to see if PointLayer property is set
        internal bool IsSetPointLayer()
        {
            return this._pointLayer != null;
        }

        /// <summary>
        /// Gets and sets the property PolygonLayer. 
        /// <para>
        /// The definition for a polygon layer.
        /// </para>
        /// </summary>
        public GeospatialPolygonLayer PolygonLayer
        {
            get { return this._polygonLayer; }
            set { this._polygonLayer = value; }
        }

        // Check to see if PolygonLayer property is set
        internal bool IsSetPolygonLayer()
        {
            return this._polygonLayer != null;
        }

    }
}