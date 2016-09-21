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
    /// Container for the parameters to the CreateDeploymentConfig operation.
    /// Creates a deployment configuration.
    /// </summary>
    public partial class CreateDeploymentConfigRequest : AmazonCodeDeployRequest
    {
        private string _deploymentConfigName;
        private MinimumHealthyHosts _minimumHealthyHosts;

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The name of the deployment configuration to create.
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
        /// The minimum number of healthy instances that should be available at any time during
        /// the deployment. There are two parameters expected in the input: type and value.
        /// </para>
        ///  
        /// <para>
        /// The type parameter takes either of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HOST_COUNT: The value parameter represents the minimum number of healthy instances
        /// as an absolute value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_PERCENT: The value parameter represents the minimum number of healthy instances
        /// as a percentage of the total number of instances in the deployment. If you specify
        /// FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage
        /// to the equivalent number of instance and rounds up fractional instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The value parameter takes an integer.
        /// </para>
        ///  
        /// <para>
        /// For example, to set a minimum of 95% healthy instance, specify a type of FLEET_PERCENT
        /// and a value of 95.
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