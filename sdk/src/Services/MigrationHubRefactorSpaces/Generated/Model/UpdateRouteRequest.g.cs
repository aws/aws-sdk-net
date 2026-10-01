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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoute operation. Updates an Amazon Web Services
    /// Migration Hub Refactor Spaces route.
    /// </summary>
    public partial class UpdateRouteRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ActivationState. 
        /// <para>
        ///  If set to <c>ACTIVE</c>, traffic is forwarded to this route’s service after the route
        /// is updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteActivationState ActivationState { get; set; }

        /// <summary>
        /// Checks to see if the ActivationState property is set.
        /// </summary>
        internal bool IsSetActivationState() => this.ActivationState != null;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        ///  The ID of the application within which the route is being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetApplicationIdentifier() => this.ApplicationIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        ///  The ID of the environment in which the route is being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property RouteIdentifier. 
        /// <para>
        ///  The unique identifier of the route to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string RouteIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RouteIdentifier property is set.
        /// </summary>
        internal bool IsSetRouteIdentifier() => this.RouteIdentifier != null;
    }
}
