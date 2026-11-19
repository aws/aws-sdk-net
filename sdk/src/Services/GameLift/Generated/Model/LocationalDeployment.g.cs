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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// For a multi-location container fleet, describes the progress of a deployment across
    /// all fleet locations.
    /// </summary>
    public partial class LocationalDeployment
    {
        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The status of fleet deployment activity in the location. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> -- The deployment is in progress in the location. This status
        /// covers validation as well as the replacement of the location's containers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPAIRED</c> -- The deployment failed validation in the location, and the location
        /// kept the containers that failed validation so that you can inspect them. A location
        /// reaches this status when the deployment's impairment strategy is <c>MAINTAIN</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> -- The deployment has completed successfully in the location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK_IN_PROGRESS</c> -- The deployment failed and rollback has been initiated
        /// in the location. A location reaches this status when the deployment's impairment strategy
        /// is <c>ROLLBACK</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK_COMPLETE</c> -- The deployment failed and rollback has been completed
        /// in the location. The location is running the configuration from the last successful
        /// deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> -- The deployment was cancelled because a new deployment started
        /// for the same fleet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentStatus DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;
    }
}
