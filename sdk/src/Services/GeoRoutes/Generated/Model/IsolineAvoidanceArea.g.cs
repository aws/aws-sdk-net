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
    /// Defines an area to avoid when calculating routes. Consists of a primary geometry to
    /// avoid, with the ability to specify exception areas within that geometry where travel
    /// is permitted.
    /// </summary>
    public partial class IsolineAvoidanceArea
    {
        /// <summary>
        /// Gets and sets the property Except. 
        /// <para>
        /// Areas within the primary avoidance geometry where travel is allowed. For example,
        /// you might want to avoid a neighborhood but allow travel on a major road that passes
        /// through it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IsolineAvoidanceAreaGeometry> Except { get; set; } = AWSConfigs.InitializeCollections ? new List<IsolineAvoidanceAreaGeometry>() : null;

        /// <summary>
        /// Checks to see if the Except property is set.
        /// </summary>
        internal bool IsSetExcept() => this.Except != null && (this.Except.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// The primary area to avoid, specified using a bounding box, corridor, polygon, or polyline
        /// corridor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IsolineAvoidanceAreaGeometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;
    }
}
