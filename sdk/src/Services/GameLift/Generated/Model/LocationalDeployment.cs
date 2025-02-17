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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
        private DeploymentStatus _deploymentStatus;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The status of fleet deployment activity in the location. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> -- The deployment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPAIRED</c> -- The deployment failed and the fleet has some impaired containers.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> -- The deployment has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK_IN_PROGRESS</c> -- The deployment failed and rollback has been initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK_IN_COMPLETE</c> -- The deployment failed and rollback has been completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> -- The deployment was cancelled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

    }
}