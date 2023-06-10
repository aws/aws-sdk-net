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
    /// This is the response object from the CreateRoute operation.
    /// </summary>
    public partial class CreateRouteResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private string _arn;
        private string _createdByAccountId;
        private DateTime? _createdTime;
        private DateTime? _lastUpdatedTime;
        private string _ownerAccountId;
        private string _routeId;
        private RouteType _routeType;
        private string _serviceId;
        private RouteState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UriPathRouteInput _uriPathRoute;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application in which the route is created.
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
        /// The Amazon Resource Name (ARN) of the route. The format for this ARN is <code>arn:aws:refactor-spaces:<i>region</i>:<i>account-id</i>:<i>resource-type/resource-id</i>
        /// </code>. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// The ID of service in which the route is created. Traffic that matches this route is
        /// forwarded to this service.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the route. Activation state only allows <code>ACTIVE</code> or
        /// <code>INACTIVE</code> as user inputs. <code>FAILED</code> is a route state that is
        /// system generated.
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
        /// The tags assigned to the created route. A tag is a label that you assign to an Amazon
        /// Web Services resource. Each tag consists of a key-value pair. 
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

        /// <summary>
        /// Gets and sets the property UriPathRoute. 
        /// <para>
        /// Configuration for the URI path route type. 
        /// </para>
        /// </summary>
        public UriPathRouteInput UriPathRoute
        {
            get { return this._uriPathRoute; }
            set { this._uriPathRoute = value; }
        }

        // Check to see if UriPathRoute property is set
        internal bool IsSetUriPathRoute()
        {
            return this._uriPathRoute != null;
        }

    }
}