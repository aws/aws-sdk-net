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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about blue/green deployment options for a deployment group.
    /// </summary>
    public partial class BlueGreenDeploymentConfiguration
    {
        /// <summary>
        /// Gets and sets the property DeploymentReadyOption. 
        /// <para>
        /// Information about the action to take when newly provisioned instances are ready to
        /// receive traffic in a blue/green deployment.
        /// </para>
        /// </summary>
        public DeploymentReadyOption DeploymentReadyOption { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentReadyOption property is set.
        /// </summary>
        internal bool IsSetDeploymentReadyOption() => this.DeploymentReadyOption != null;

        /// <summary>
        /// Gets and sets the property GreenFleetProvisioningOption. 
        /// <para>
        /// Information about how instances are provisioned for a replacement environment in a
        /// blue/green deployment.
        /// </para>
        /// </summary>
        public GreenFleetProvisioningOption GreenFleetProvisioningOption { get; set; }

        /// <summary>
        /// Checks to see if the GreenFleetProvisioningOption property is set.
        /// </summary>
        internal bool IsSetGreenFleetProvisioningOption() => this.GreenFleetProvisioningOption != null;

        /// <summary>
        /// Gets and sets the property TerminateBlueInstancesOnDeploymentSuccess. 
        /// <para>
        /// Information about whether to terminate instances in the original fleet during a blue/green
        /// deployment.
        /// </para>
        /// </summary>
        public BlueInstanceTerminationOption TerminateBlueInstancesOnDeploymentSuccess { get; set; }

        /// <summary>
        /// Checks to see if the TerminateBlueInstancesOnDeploymentSuccess property is set.
        /// </summary>
        internal bool IsSetTerminateBlueInstancesOnDeploymentSuccess() => this.TerminateBlueInstancesOnDeploymentSuccess != null;
    }
}
