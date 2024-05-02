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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
        private long? _deploymentId;
        private DateTime? _deploymentTime;
        private string _status;
        private string _versionLabel;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment. This number increases by one each time that you deploy source
        /// code or change instance configuration settings.
        /// </para>
        /// </summary>
        public long? DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId.HasValue; 
        }

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
        public DateTime? DeploymentTime
        {
            get { return this._deploymentTime; }
            set { this._deploymentTime = value; }
        }

        // Check to see if DeploymentTime property is set
        internal bool IsSetDeploymentTime()
        {
            return this._deploymentTime.HasValue; 
        }

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
        public string Status
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
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The version label of the application version in the deployment.
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}