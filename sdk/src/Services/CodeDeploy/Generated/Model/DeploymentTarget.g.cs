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
    /// Information about the deployment target.
    /// </summary>
    public partial class DeploymentTarget
    {
        /// <summary>
        /// Gets and sets the property CloudFormationTarget.
        /// </summary>
        public CloudFormationTarget CloudFormationTarget { get; set; }

        /// <summary>
        /// Checks to see if the CloudFormationTarget property is set.
        /// </summary>
        internal bool IsSetCloudFormationTarget() => this.CloudFormationTarget != null;

        /// <summary>
        /// Gets and sets the property DeploymentTargetType. 
        /// <para>
        /// The deployment type that is specific to the deployment's compute platform or deployments
        /// initiated by a CloudFormation stack update.
        /// </para>
        /// </summary>
        public DeploymentTargetType DeploymentTargetType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentTargetType property is set.
        /// </summary>
        internal bool IsSetDeploymentTargetType() => this.DeploymentTargetType != null;

        /// <summary>
        /// Gets and sets the property EcsTarget. 
        /// <para>
        ///  Information about the target for a deployment that uses the Amazon ECS compute platform.
        /// 
        /// </para>
        /// </summary>
        public ECSTarget EcsTarget { get; set; }

        /// <summary>
        /// Checks to see if the EcsTarget property is set.
        /// </summary>
        internal bool IsSetEcsTarget() => this.EcsTarget != null;

        /// <summary>
        /// Gets and sets the property InstanceTarget. 
        /// <para>
        ///  Information about the target for a deployment that uses the EC2/On-premises compute
        /// platform. 
        /// </para>
        /// </summary>
        public InstanceTarget InstanceTarget { get; set; }

        /// <summary>
        /// Checks to see if the InstanceTarget property is set.
        /// </summary>
        internal bool IsSetInstanceTarget() => this.InstanceTarget != null;

        /// <summary>
        /// Gets and sets the property LambdaTarget. 
        /// <para>
        ///  Information about the target for a deployment that uses the Lambda compute platform.
        /// 
        /// </para>
        /// </summary>
        public LambdaTarget LambdaTarget { get; set; }

        /// <summary>
        /// Checks to see if the LambdaTarget property is set.
        /// </summary>
        internal bool IsSetLambdaTarget() => this.LambdaTarget != null;
    }
}
