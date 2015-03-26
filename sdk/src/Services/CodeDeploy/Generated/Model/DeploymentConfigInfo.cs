/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a deployment configuration.
    /// </summary>
    public partial class DeploymentConfigInfo
    {
        private DateTime? _createTime;
        private string _deploymentConfigId;
        private string _deploymentConfigName;
        private MinimumHealthyHosts _minimumHealthyHosts;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the deployment configuration was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigId. 
        /// <para>
        /// The deployment configuration ID.
        /// </para>
        /// </summary>
        public string DeploymentConfigId
        {
            get { return this._deploymentConfigId; }
            set { this._deploymentConfigId = value; }
        }

        // Check to see if DeploymentConfigId property is set
        internal bool IsSetDeploymentConfigId()
        {
            return this._deploymentConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The deployment configuration name.
        /// </para>
        /// </summary>
        public string DeploymentConfigName
        {
            get { return this._deploymentConfigName; }
            set { this._deploymentConfigName = value; }
        }

        // Check to see if DeploymentConfigName property is set
        internal bool IsSetDeploymentConfigName()
        {
            return this._deploymentConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumHealthyHosts. 
        /// <para>
        /// Information about the number or percentage of minimum healthy instances.
        /// </para>
        /// </summary>
        public MinimumHealthyHosts MinimumHealthyHosts
        {
            get { return this._minimumHealthyHosts; }
            set { this._minimumHealthyHosts = value; }
        }

        // Check to see if MinimumHealthyHosts property is set
        internal bool IsSetMinimumHealthyHosts()
        {
            return this._minimumHealthyHosts != null;
        }

    }
}