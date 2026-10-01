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
    /// Controls how origin and destination points are matched to the road network when they
    /// don't fall exactly on a road. Matching options help ensure realistic routing by connecting
    /// points to appropriate roads.
    /// </summary>
    public partial class IsolineMatchingOptions
    {
        /// <summary>
        /// Gets and sets the property NameHint. 
        /// <para>
        /// The expected street name near the point. Helps disambiguate matching when multiple
        /// roads are within range.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string NameHint { get; set; }

        /// <summary>
        /// Checks to see if the NameHint property is set.
        /// </summary>
        internal bool IsSetNameHint() => this.NameHint != null;

        /// <summary>
        /// Gets and sets the property OnRoadThreshold. 
        /// <para>
        /// The maximum distance in meters that a point can be from a road while still being considered
        /// "on" that road. Points further than this distance require explicit matching.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? OnRoadThreshold { get; set; }

        /// <summary>
        /// Checks to see if the OnRoadThreshold property is set.
        /// </summary>
        internal bool IsSetOnRoadThreshold() => this.OnRoadThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Radius. 
        /// <para>
        /// The maximum distance in meters to search for roads to match to. Points with no roads
        /// within this radius will fail to match. The roads that are considered within this radius
        /// are determined by the specified <c>Strategy</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Radius { get; set; }

        /// <summary>
        /// Checks to see if the Radius property is set.
        /// </summary>
        internal bool IsSetRadius() => this.Radius.HasValue;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// Determines how points are matched to the road network. <c>MatchAny</c> finds the nearest
        /// viable road segment, while <c>MatchMostSignificantRoad</c> prioritizes major roads.
        /// </para>
        /// </summary>
        public MatchingStrategy Strategy { get; set; }

        /// <summary>
        /// Checks to see if the Strategy property is set.
        /// </summary>
        internal bool IsSetStrategy() => this.Strategy != null;
    }
}
