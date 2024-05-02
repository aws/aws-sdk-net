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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoute operation.
    /// Updates an Amazon Web Services Migration Hub Refactor Spaces route.
    /// </summary>
    public partial class UpdateRouteRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        private RouteActivationState _activationState;
        private string _applicationIdentifier;
        private string _environmentIdentifier;
        private string _routeIdentifier;

        /// <summary>
        /// Gets and sets the property ActivationState. 
        /// <para>
        ///  If set to <c>ACTIVE</c>, traffic is forwarded to this route’s service after the route
        /// is updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteActivationState ActivationState
        {
            get { return this._activationState; }
            set { this._activationState = value; }
        }

        // Check to see if ActivationState property is set
        internal bool IsSetActivationState()
        {
            return this._activationState != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        ///  The ID of the application within which the route is being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        ///  The ID of the environment in which the route is being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RouteIdentifier. 
        /// <para>
        ///  The unique identifier of the route to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=14)]
        public string RouteIdentifier
        {
            get { return this._routeIdentifier; }
            set { this._routeIdentifier = value; }
        }

        // Check to see if RouteIdentifier property is set
        internal bool IsSetRouteIdentifier()
        {
            return this._routeIdentifier != null;
        }

    }
}