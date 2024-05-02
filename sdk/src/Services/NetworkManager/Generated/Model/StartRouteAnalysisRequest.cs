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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
    /// Container for the parameters to the StartRouteAnalysis operation.
    /// Starts analyzing the routing path between the specified source and destination. For
    /// more information, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/route-analyzer.html">Route
    /// Analyzer</a>.
    /// </summary>
    public partial class StartRouteAnalysisRequest : AmazonNetworkManagerRequest
    {
        private RouteAnalysisEndpointOptionsSpecification _destination;
        private string _globalNetworkId;
        private bool? _includeReturnPath;
        private RouteAnalysisEndpointOptionsSpecification _source;
        private bool? _useMiddleboxes;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteAnalysisEndpointOptionsSpecification Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string GlobalNetworkId
        {
            get { return this._globalNetworkId; }
            set { this._globalNetworkId = value; }
        }

        // Check to see if GlobalNetworkId property is set
        internal bool IsSetGlobalNetworkId()
        {
            return this._globalNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeReturnPath. 
        /// <para>
        /// Indicates whether to analyze the return path. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeReturnPath
        {
            get { return this._includeReturnPath; }
            set { this._includeReturnPath = value; }
        }

        // Check to see if IncludeReturnPath property is set
        internal bool IsSetIncludeReturnPath()
        {
            return this._includeReturnPath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source from which traffic originates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteAnalysisEndpointOptionsSpecification Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property UseMiddleboxes. 
        /// <para>
        /// Indicates whether to include the location of middlebox appliances in the route analysis.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? UseMiddleboxes
        {
            get { return this._useMiddleboxes; }
            set { this._useMiddleboxes = value; }
        }

        // Check to see if UseMiddleboxes property is set
        internal bool IsSetUseMiddleboxes()
        {
            return this._useMiddleboxes.HasValue; 
        }

    }
}