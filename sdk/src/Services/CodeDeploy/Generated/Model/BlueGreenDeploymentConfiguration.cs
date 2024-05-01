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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about blue/green deployment options for a deployment group.
    /// </summary>
    public partial class BlueGreenDeploymentConfiguration
    {
        private DeploymentReadyOption _deploymentReadyOption;
        private GreenFleetProvisioningOption _greenFleetProvisioningOption;
        private BlueInstanceTerminationOption _terminateBlueInstancesOnDeploymentSuccess;

        /// <summary>
        /// Gets and sets the property DeploymentReadyOption. 
        /// <para>
        /// Information about the action to take when newly provisioned instances are ready to
        /// receive traffic in a blue/green deployment.
        /// </para>
        /// </summary>
        public DeploymentReadyOption DeploymentReadyOption
        {
            get { return this._deploymentReadyOption; }
            set { this._deploymentReadyOption = value; }
        }

        // Check to see if DeploymentReadyOption property is set
        internal bool IsSetDeploymentReadyOption()
        {
            return this._deploymentReadyOption != null;
        }

        /// <summary>
        /// Gets and sets the property GreenFleetProvisioningOption. 
        /// <para>
        /// Information about how instances are provisioned for a replacement environment in a
        /// blue/green deployment.
        /// </para>
        /// </summary>
        public GreenFleetProvisioningOption GreenFleetProvisioningOption
        {
            get { return this._greenFleetProvisioningOption; }
            set { this._greenFleetProvisioningOption = value; }
        }

        // Check to see if GreenFleetProvisioningOption property is set
        internal bool IsSetGreenFleetProvisioningOption()
        {
            return this._greenFleetProvisioningOption != null;
        }

        /// <summary>
        /// Gets and sets the property TerminateBlueInstancesOnDeploymentSuccess. 
        /// <para>
        /// Information about whether to terminate instances in the original fleet during a blue/green
        /// deployment.
        /// </para>
        /// </summary>
        public BlueInstanceTerminationOption TerminateBlueInstancesOnDeploymentSuccess
        {
            get { return this._terminateBlueInstancesOnDeploymentSuccess; }
            set { this._terminateBlueInstancesOnDeploymentSuccess = value; }
        }

        // Check to see if TerminateBlueInstancesOnDeploymentSuccess property is set
        internal bool IsSetTerminateBlueInstancesOnDeploymentSuccess()
        {
            return this._terminateBlueInstancesOnDeploymentSuccess != null;
        }

    }
}