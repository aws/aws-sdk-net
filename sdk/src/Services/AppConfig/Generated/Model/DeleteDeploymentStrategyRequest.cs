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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDeploymentStrategy operation.
    /// Delete a deployment strategy. Deleting a deployment strategy does not delete a configuration
    /// from a host.
    /// </summary>
    public partial class DeleteDeploymentStrategyRequest : AmazonAppConfigRequest
    {
        private string _deploymentStrategyId;

        /// <summary>
        /// Gets and sets the property DeploymentStrategyId. 
        /// <para>
        /// The ID of the deployment strategy you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentStrategyId
        {
            get { return this._deploymentStrategyId; }
            set { this._deploymentStrategyId = value; }
        }

        // Check to see if DeploymentStrategyId property is set
        internal bool IsSetDeploymentStrategyId()
        {
            return this._deploymentStrategyId != null;
        }

    }
}