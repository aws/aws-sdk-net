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
    /// This is the response object from the DeleteRoute operation.
    /// </summary>
    public partial class DeleteRouteResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private string _arn;
        private DateTime? _lastUpdatedTime;
        private string _routeId;
        private string _serviceId;
        private RouteState _state;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that the route belongs to.
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
        /// Gets and sets the property RouteId. 
        /// <para>
        /// The ID of the route to delete.
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
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service that the route belongs to.
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

    }
}