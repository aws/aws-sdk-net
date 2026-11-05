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
    /// Information about the type of deployment, either in-place or blue/green, you want
    /// to run and whether to route deployment traffic behind a load balancer.
    /// </summary>
    public partial class DeploymentStyle
    {
        /// <summary>
        /// Gets and sets the property DeploymentOption. 
        /// <para>
        /// Indicates whether to route deployment traffic behind a load balancer.
        /// </para>
        /// </summary>
        public DeploymentOption DeploymentOption { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentOption property is set.
        /// </summary>
        internal bool IsSetDeploymentOption() => this.DeploymentOption != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Indicates whether to run an in-place deployment or a blue/green deployment.
        /// </para>
        /// </summary>
        public DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;
    }
}
