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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ContinueDeployment operation.
    /// For a blue/green deployment, starts the process of rerouting traffic from instances
    /// in the original environment to instances in the replacement environment without waiting
    /// for a specified wait time to elapse. (Traffic rerouting, which is achieved by registering
    /// instances in the replacement environment with the load balancer, can start as soon
    /// as all instances have a status of Ready.)
    /// </summary>
    public partial class ContinueDeploymentRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private DeploymentWaitType _deploymentWaitType;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a blue/green deployment for which you want to start rerouting traffic
        /// to the replacement environment. 
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentWaitType. 
        /// <para>
        ///  The status of the deployment's waiting period. <code>READY_WAIT</code> indicates
        /// that the deployment is ready to start shifting traffic. <code>TERMINATION_WAIT</code>
        /// indicates that the traffic is shifted, but the original target is not terminated.
        /// 
        /// </para>
        /// </summary>
        public DeploymentWaitType DeploymentWaitType
        {
            get { return this._deploymentWaitType; }
            set { this._deploymentWaitType = value; }
        }

        // Check to see if DeploymentWaitType property is set
        internal bool IsSetDeploymentWaitType()
        {
            return this._deploymentWaitType != null;
        }

    }
}