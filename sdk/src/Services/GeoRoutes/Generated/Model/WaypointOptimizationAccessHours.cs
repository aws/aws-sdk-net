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
    /// Access hours corresponding to when a destination can be visited.
    /// </summary>
    public partial class WaypointOptimizationAccessHours
    {
        private WaypointOptimizationAccessHoursEntry _from;
        private WaypointOptimizationAccessHoursEntry _to;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// Contains the ID of the starting waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WaypointOptimizationAccessHoursEntry From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// Contains the ID of the ending waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WaypointOptimizationAccessHoursEntry To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

    }
}