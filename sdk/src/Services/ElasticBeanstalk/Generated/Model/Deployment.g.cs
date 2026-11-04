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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Information about an application version deployment.
    /// </summary>
    public partial class Deployment
    {
        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment. This number increases by one each time that you deploy source
        /// code or change instance configuration settings.
        /// </para>
        /// </summary>
        public long? DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentTime. 
        /// <para>
        /// For in-progress deployments, the time that the deployment started.
        /// </para>
        ///  
        /// <para>
        /// For completed deployments, the time that the deployment ended.
        /// </para>
        /// </summary>
        public DateTime? DeploymentTime { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentTime property is set.
        /// </summary>
        internal bool IsSetDeploymentTime() => this.DeploymentTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>In Progress</c> : The deployment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deployed</c> : The deployment succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> : The deployment failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The version label of the application version in the deployment.
        /// </para>
        /// </summary>
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
