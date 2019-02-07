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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeploymentJob operation.
    /// Deploys a specific version of a robot application to robots in a fleet.
    /// 
    ///  
    /// <para>
    /// The robot application must have a numbered <code>applicationVersion</code> for consistency
    /// reasons. To create a new version, use <code>CreateRobotApplicationVersion</code> or
    /// see <a href="https://docs.aws.amazon.com/robomaker/latest/dg/create-robot-application-version.html">Creating
    /// a Robot Application Version</a>. 
    /// </para>
    /// </summary>
    public partial class CreateDeploymentJobRequest : AmazonRoboMakerRequest
    {
        private string _clientRequestToken;
        private List<DeploymentApplicationConfig> _deploymentApplicationConfigs = new List<DeploymentApplicationConfig>();
        private DeploymentConfig _deploymentConfig;
        private string _fleet;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentApplicationConfigs. 
        /// <para>
        /// The deployment application configuration.
        /// </para>
        /// </summary>
        public List<DeploymentApplicationConfig> DeploymentApplicationConfigs
        {
            get { return this._deploymentApplicationConfigs; }
            set { this._deploymentApplicationConfigs = value; }
        }

        // Check to see if DeploymentApplicationConfigs property is set
        internal bool IsSetDeploymentApplicationConfigs()
        {
            return this._deploymentApplicationConfigs != null && this._deploymentApplicationConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The requested deployment configuration.
        /// </para>
        /// </summary>
        public DeploymentConfig DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Fleet. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet to deploy.
        /// </para>
        /// </summary>
        public string Fleet
        {
            get { return this._fleet; }
            set { this._fleet = value; }
        }

        // Check to see if Fleet property is set
        internal bool IsSetFleet()
        {
            return this._fleet != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the deployment job.
        /// </para>
        /// </summary>
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