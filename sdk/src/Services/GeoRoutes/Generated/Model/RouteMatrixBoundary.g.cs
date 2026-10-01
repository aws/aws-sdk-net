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
    /// Boundary within which the matrix is to be calculated. All data, origins and destinations
    /// outside the boundary are considered invalid.
    /// </summary>
    public partial class RouteMatrixBoundary
    {
        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Geometry of the area to be avoided.
        /// </para>
        /// </summary>
        public RouteMatrixBoundaryGeometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Unbounded. 
        /// <para>
        /// No restrictions in terms of a routing boundary, and is typically used for longer routes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Unbounded { get; set; }

        /// <summary>
        /// Checks to see if the Unbounded property is set.
        /// </summary>
        internal bool IsSetUnbounded() => this.Unbounded.HasValue;
    }
}
