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
    /// Describes a route analysis.
    /// </summary>
    public partial class RouteAnalysis
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        public RouteAnalysisEndpointOptions Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property ForwardPath. 
        /// <para>
        /// The forward path.
        /// </para>
        /// </summary>
        public RouteAnalysisPath ForwardPath { get; set; }

        /// <summary>
        /// Checks to see if the ForwardPath property is set.
        /// </summary>
        internal bool IsSetForwardPath() => this.ForwardPath != null;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;

        /// <summary>
        /// Gets and sets the property IncludeReturnPath. 
        /// <para>
        /// Indicates whether to analyze the return path. The return path is not analyzed if the
        /// forward path analysis does not succeed.
        /// </para>
        /// </summary>
        public bool? IncludeReturnPath { get; set; }

        /// <summary>
        /// Checks to see if the IncludeReturnPath property is set.
        /// </summary>
        internal bool IsSetIncludeReturnPath() => this.IncludeReturnPath.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the AWS account that created the route analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ReturnPath. 
        /// <para>
        /// The return path.
        /// </para>
        /// </summary>
        public RouteAnalysisPath ReturnPath { get; set; }

        /// <summary>
        /// Checks to see if the ReturnPath property is set.
        /// </summary>
        internal bool IsSetReturnPath() => this.ReturnPath != null;

        /// <summary>
        /// Gets and sets the property RouteAnalysisId. 
        /// <para>
        /// The ID of the route analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RouteAnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the RouteAnalysisId property is set.
        /// </summary>
        internal bool IsSetRouteAnalysisId() => this.RouteAnalysisId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source.
        /// </para>
        /// </summary>
        public RouteAnalysisEndpointOptions Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The time that the analysis started.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the route analysis.
        /// </para>
        /// </summary>
        public RouteAnalysisStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UseMiddleboxes. 
        /// <para>
        /// Indicates whether to include the location of middlebox appliances in the route analysis.
        /// </para>
        /// </summary>
        public bool? UseMiddleboxes { get; set; }

        /// <summary>
        /// Checks to see if the UseMiddleboxes property is set.
        /// </summary>
        internal bool IsSetUseMiddleboxes() => this.UseMiddleboxes.HasValue;
    }
}
