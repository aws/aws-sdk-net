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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the StartRouteAnalysis operation. Starts analyzing
    /// the routing path between the specified source and destination. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/route-analyzer.html">Route
    /// Analyzer</a>.
    /// </summary>
    public partial class StartRouteAnalysisRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteAnalysisEndpointOptionsSpecification Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;

        /// <summary>
        /// Gets and sets the property IncludeReturnPath. 
        /// <para>
        /// Indicates whether to analyze the return path. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeReturnPath { get; set; }

        /// <summary>
        /// Checks to see if the IncludeReturnPath property is set.
        /// </summary>
        internal bool IsSetIncludeReturnPath() => this.IncludeReturnPath.HasValue;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source from which traffic originates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteAnalysisEndpointOptionsSpecification Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property UseMiddleboxes. 
        /// <para>
        /// Indicates whether to include the location of middlebox appliances in the route analysis.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseMiddleboxes { get; set; }

        /// <summary>
        /// Checks to see if the UseMiddleboxes property is set.
        /// </summary>
        internal bool IsSetUseMiddleboxes() => this.UseMiddleboxes.HasValue;
    }
}
