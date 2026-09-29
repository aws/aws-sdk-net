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
    /// The definition properties for a geospatial layer.
    /// </summary>
    public partial class GeospatialLayerDefinition
    {
        /// <summary>
        /// Gets and sets the property LineLayer. 
        /// <para>
        /// The definition for a line layer.
        /// </para>
        /// </summary>
        public GeospatialLineLayer LineLayer { get; set; }

        /// <summary>
        /// Checks to see if the LineLayer property is set.
        /// </summary>
        internal bool IsSetLineLayer() => this.LineLayer != null;

        /// <summary>
        /// Gets and sets the property PointLayer. 
        /// <para>
        /// The definition for a point layer.
        /// </para>
        /// </summary>
        public GeospatialPointLayer PointLayer { get; set; }

        /// <summary>
        /// Checks to see if the PointLayer property is set.
        /// </summary>
        internal bool IsSetPointLayer() => this.PointLayer != null;

        /// <summary>
        /// Gets and sets the property PolygonLayer. 
        /// <para>
        /// The definition for a polygon layer.
        /// </para>
        /// </summary>
        public GeospatialPolygonLayer PolygonLayer { get; set; }

        /// <summary>
        /// Checks to see if the PolygonLayer property is set.
        /// </summary>
        internal bool IsSetPolygonLayer() => this.PolygonLayer != null;
    }
}
