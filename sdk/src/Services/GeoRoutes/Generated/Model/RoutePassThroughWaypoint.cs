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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
    /// If the waypoint should be treated as a stop. If yes, the route is split up into different
    /// legs around the stop.
    /// </summary>
    public partial class RoutePassThroughWaypoint
    {
        private int? _geometryOffset;
        private RoutePassThroughPlace _place;

        /// <summary>
        /// Gets and sets the property GeometryOffset. 
        /// <para>
        /// Offset in the leg geometry corresponding to the start of this step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? GeometryOffset
        {
            get { return this._geometryOffset; }
            set { this._geometryOffset = value; }
        }

        // Check to see if GeometryOffset property is set
        internal bool IsSetGeometryOffset()
        {
            return this._geometryOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Place. 
        /// <para>
        /// The place details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutePassThroughPlace Place
        {
            get { return this._place; }
            set { this._place = value; }
        }

        // Check to see if Place property is set
        internal bool IsSetPlace()
        {
            return this._place != null;
        }

    }
}