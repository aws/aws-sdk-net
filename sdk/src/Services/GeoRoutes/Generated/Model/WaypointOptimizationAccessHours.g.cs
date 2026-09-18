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
    /// Access hours corresponding to when a destination can be visited.
    /// </summary>
    public partial class WaypointOptimizationAccessHours
    {
        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// Contains the ID of the starting waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WaypointOptimizationAccessHoursEntry From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// Contains the ID of the ending waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WaypointOptimizationAccessHoursEntry To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;
    }
}
