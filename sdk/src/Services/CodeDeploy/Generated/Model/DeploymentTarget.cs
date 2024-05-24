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
    /// Information about the deployment target.
    /// </summary>
    public partial class DeploymentTarget
    {
        private CloudFormationTarget _cloudFormationTarget;
        private DeploymentTargetType _deploymentTargetType;
        private ECSTarget _ecsTarget;
        private InstanceTarget _instanceTarget;
        private LambdaTarget _lambdaTarget;

        /// <summary>
        /// Gets and sets the property CloudFormationTarget.
        /// </summary>
        public CloudFormationTarget CloudFormationTarget
        {
            get { return this._cloudFormationTarget; }
            set { this._cloudFormationTarget = value; }
        }

        // Check to see if CloudFormationTarget property is set
        internal bool IsSetCloudFormationTarget()
        {
            return this._cloudFormationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentTargetType. 
        /// <para>
        /// The deployment type that is specific to the deployment's compute platform or deployments
        /// initiated by a CloudFormation stack update.
        /// </para>
        /// </summary>
        public DeploymentTargetType DeploymentTargetType
        {
            get { return this._deploymentTargetType; }
            set { this._deploymentTargetType = value; }
        }

        // Check to see if DeploymentTargetType property is set
        internal bool IsSetDeploymentTargetType()
        {
            return this._deploymentTargetType != null;
        }

        /// <summary>
        /// Gets and sets the property EcsTarget. 
        /// <para>
        ///  Information about the target for a deployment that uses the Amazon ECS compute platform.
        /// 
        /// </para>
        /// </summary>
        public ECSTarget EcsTarget
        {
            get { return this._ecsTarget; }
            set { this._ecsTarget = value; }
        }

        // Check to see if EcsTarget property is set
        internal bool IsSetEcsTarget()
        {
            return this._ecsTarget != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTarget. 
        /// <para>
        ///  Information about the target for a deployment that uses the EC2/On-premises compute
        /// platform. 
        /// </para>
        /// </summary>
        public InstanceTarget InstanceTarget
        {
            get { return this._instanceTarget; }
            set { this._instanceTarget = value; }
        }

        // Check to see if InstanceTarget property is set
        internal bool IsSetInstanceTarget()
        {
            return this._instanceTarget != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaTarget. 
        /// <para>
        ///  Information about the target for a deployment that uses the Lambda compute platform.
        /// 
        /// </para>
        /// </summary>
        public LambdaTarget LambdaTarget
        {
            get { return this._lambdaTarget; }
            set { this._lambdaTarget = value; }
        }

        // Check to see if LambdaTarget property is set
        internal bool IsSetLambdaTarget()
        {
            return this._lambdaTarget != null;
        }

    }
}