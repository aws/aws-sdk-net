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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// An action that routes requests to a gateway target, either statically or with weighted
    /// traffic splitting.
    /// </summary>
    public partial class RouteToTargetAction
    {
        /// <summary>
        /// Gets and sets the property StaticRoute. 
        /// <para>
        /// A static route that sends all matching requests to a single target.
        /// </para>
        /// </summary>
        public StaticRoute StaticRoute { get; set; }

        /// <summary>
        /// Checks to see if the StaticRoute property is set.
        /// </summary>
        internal bool IsSetStaticRoute() => this.StaticRoute != null;

        /// <summary>
        /// Gets and sets the property WeightedRoute. 
        /// <para>
        /// A weighted route that splits traffic between multiple targets.
        /// </para>
        /// </summary>
        public WeightedRoute WeightedRoute { get; set; }

        /// <summary>
        /// Checks to see if the WeightedRoute property is set.
        /// </summary>
        internal bool IsSetWeightedRoute() => this.WeightedRoute != null;
    }
}
