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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// The summary information for the routes as a response to <code>ListRoutes</code>.
    /// </summary>
    public partial class RouteSummary
    {
        private string _applicationId;
        private string _arn;
        private string _createdByAccountId;
        private DateTime? _createdTime;
        private string _environmentId;
        private ErrorResponse _error;
        private bool? _includeChildPaths;
        private DateTime? _lastUpdatedTime;
        private List<string> _methods = new List<string>();
        private string _ownerAccountId;
        private Dictionary<string, string> _pathResourceToId = new Dictionary<string, string>();
        private string _routeId;
        private RouteType _routeType;
        private string _serviceId;
        private string _sourcePath;
        private RouteState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=14)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the route. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedByAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the route creator. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string CreatedByAccountId
        {
            get { return this._createdByAccountId; }
            set { this._createdByAccountId = value; }
        }

        // Check to see if CreatedByAccountId property is set
        internal bool IsSetCreatedByAccountId()
        {
            return this._createdByAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that indicates when the route is created. 
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique identifier of the environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=14)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Any error associated with the route resource. 
        /// </para>
        /// </summary>
        public ErrorResponse Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeChildPaths. 
        /// <para>
        /// Indicates whether to match all subpaths of the given source path. If this value is
        /// <code>false</code>, requests must match the source path exactly before they are forwarded
        /// to this route's service.
        /// </para>
        /// </summary>
        public bool IncludeChildPaths
        {
            get { return this._includeChildPaths.GetValueOrDefault(); }
            set { this._includeChildPaths = value; }
        }

        // Check to see if IncludeChildPaths property is set
        internal bool IsSetIncludeChildPaths()
        {
            return this._includeChildPaths.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// A timestamp that indicates when the route was last updated. 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Methods. 
        /// <para>
        /// A list of HTTP methods to match. An empty list matches all values. If a method is
        /// present, only HTTP requests using that method are forwarded to this route’s service.
        /// 
        /// </para>
        /// </summary>
        public List<string> Methods
        {
            get { return this._methods; }
            set { this._methods = value; }
        }

        // Check to see if Methods property is set
        internal bool IsSetMethods()
        {
            return this._methods != null && this._methods.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the route owner.
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
        /// Gets and sets the property PathResourceToId. 
        /// <para>
        /// A mapping of Amazon API Gateway path resources to resource IDs. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> PathResourceToId
        {
            get { return this._pathResourceToId; }
            set { this._pathResourceToId = value; }
        }

        // Check to see if PathResourceToId property is set
        internal bool IsSetPathResourceToId()
        {
            return this._pathResourceToId != null && this._pathResourceToId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RouteId. 
        /// <para>
        /// The unique identifier of the route. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=14)]
        public string RouteId
        {
            get { return this._routeId; }
            set { this._routeId = value; }
        }

        // Check to see if RouteId property is set
        internal bool IsSetRouteId()
        {
            return this._routeId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteType. 
        /// <para>
        /// The route type of the route. 
        /// </para>
        /// </summary>
        public RouteType RouteType
        {
            get { return this._routeType; }
            set { this._routeType = value; }
        }

        // Check to see if RouteType property is set
        internal bool IsSetRouteType()
        {
            return this._routeType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The unique identifier of the service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=14)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// The path to use to match traffic. Paths must start with <code>/</code> and are relative
        /// to the base of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourcePath
        {
            get { return this._sourcePath; }
            set { this._sourcePath = value; }
        }

        // Check to see if SourcePath property is set
        internal bool IsSetSourcePath()
        {
            return this._sourcePath != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route. 
        /// </para>
        /// </summary>
        public RouteState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the route. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}