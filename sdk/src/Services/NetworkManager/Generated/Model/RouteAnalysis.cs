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
    /// Describes a route analysis.
    /// </summary>
    public partial class RouteAnalysis
    {
        private RouteAnalysisEndpointOptions _destination;
        private RouteAnalysisPath _forwardPath;
        private string _globalNetworkId;
        private bool? _includeReturnPath;
        private string _ownerAccountId;
        private RouteAnalysisPath _returnPath;
        private string _routeAnalysisId;
        private RouteAnalysisEndpointOptions _source;
        private DateTime? _startTimestamp;
        private RouteAnalysisStatus _status;
        private bool? _useMiddleboxes;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination.
        /// </para>
        /// </summary>
        public RouteAnalysisEndpointOptions Destination
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
        /// Gets and sets the property ForwardPath. 
        /// <para>
        /// The forward path.
        /// </para>
        /// </summary>
        public RouteAnalysisPath ForwardPath
        {
            get { return this._forwardPath; }
            set { this._forwardPath = value; }
        }

        // Check to see if ForwardPath property is set
        internal bool IsSetForwardPath()
        {
            return this._forwardPath != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Indicates whether to analyze the return path. The return path is not analyzed if the
        /// forward path analysis does not succeed.
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
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The ID of the AWS account that created the route analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnPath. 
        /// <para>
        /// The return path.
        /// </para>
        /// </summary>
        public RouteAnalysisPath ReturnPath
        {
            get { return this._returnPath; }
            set { this._returnPath = value; }
        }

        // Check to see if ReturnPath property is set
        internal bool IsSetReturnPath()
        {
            return this._returnPath != null;
        }

        /// <summary>
        /// Gets and sets the property RouteAnalysisId. 
        /// <para>
        /// The ID of the route analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string RouteAnalysisId
        {
            get { return this._routeAnalysisId; }
            set { this._routeAnalysisId = value; }
        }

        // Check to see if RouteAnalysisId property is set
        internal bool IsSetRouteAnalysisId()
        {
            return this._routeAnalysisId != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source.
        /// </para>
        /// </summary>
        public RouteAnalysisEndpointOptions Source
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
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The time that the analysis started.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the route analysis.
        /// </para>
        /// </summary>
        public RouteAnalysisStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UseMiddleboxes. 
        /// <para>
        /// Indicates whether to include the location of middlebox appliances in the route analysis.
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