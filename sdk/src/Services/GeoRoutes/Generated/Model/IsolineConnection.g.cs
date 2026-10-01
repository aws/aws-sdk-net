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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Represents a segment of the transportation network that connects separate parts of
    /// a reachable area. These connections show how discontinuous areas are linked, such
    /// as by ferry routes or bridges crossing unroutable terrain.
    /// </summary>
    public partial class IsolineConnection
    {
        /// <summary>
        /// Gets and sets the property FromPolygonIndex. 
        /// <para>
        /// The index of the starting polygon in the isoline's <c>Geometries</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? FromPolygonIndex { get; set; }

        /// <summary>
        /// Checks to see if the FromPolygonIndex property is set.
        /// </summary>
        internal bool IsSetFromPolygonIndex() => this.FromPolygonIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The shape of the connection, representing the actual path through the transportation
        /// network that links the polygons.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IsolineConnectionGeometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property ToPolygonIndex. 
        /// <para>
        /// The index of the ending polygon in the isoline's <c>Geometries</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ToPolygonIndex { get; set; }

        /// <summary>
        /// Checks to see if the ToPolygonIndex property is set.
        /// </summary>
        internal bool IsSetToPolygonIndex() => this.ToPolygonIndex.HasValue;
    }
}
