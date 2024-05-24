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
    /// Container for the parameters to the PutLifecycleEventHookExecutionStatus operation.
    /// Sets the result of a Lambda validation function. The function validates lifecycle
    /// hooks during a deployment that uses the Lambda or Amazon ECS compute platform. For
    /// Lambda deployments, the available lifecycle hooks are <c>BeforeAllowTraffic</c> and
    /// <c>AfterAllowTraffic</c>. For Amazon ECS deployments, the available lifecycle hooks
    /// are <c>BeforeInstall</c>, <c>AfterInstall</c>, <c>AfterAllowTestTraffic</c>, <c>BeforeAllowTraffic</c>,
    /// and <c>AfterAllowTraffic</c>. Lambda validation functions return <c>Succeeded</c>
    /// or <c>Failed</c>. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/reference-appspec-file-structure-hooks.html#appspec-hooks-lambda">AppSpec
    /// 'hooks' Section for an Lambda Deployment </a> and <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/reference-appspec-file-structure-hooks.html#appspec-hooks-ecs">AppSpec
    /// 'hooks' Section for an Amazon ECS Deployment</a>.
    /// </summary>
    public partial class PutLifecycleEventHookExecutionStatusRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private string _lifecycleEventHookExecutionId;
        private LifecycleEventStatus _status;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. Pass this ID to a Lambda function that validates a
        /// deployment lifecycle event. 
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
        /// Gets and sets the property LifecycleEventHookExecutionId. 
        /// <para>
        ///  The execution ID of a deployment's lifecycle hook. A deployment lifecycle hook is
        /// specified in the <c>hooks</c> section of the AppSpec file. 
        /// </para>
        /// </summary>
        public string LifecycleEventHookExecutionId
        {
            get { return this._lifecycleEventHookExecutionId; }
            set { this._lifecycleEventHookExecutionId = value; }
        }

        // Check to see if LifecycleEventHookExecutionId property is set
        internal bool IsSetLifecycleEventHookExecutionId()
        {
            return this._lifecycleEventHookExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result of a Lambda function that validates a deployment lifecycle event. The values
        /// listed in <b>Valid Values</b> are valid for lifecycle statuses in general; however,
        /// only <c>Succeeded</c> and <c>Failed</c> can be passed successfully in your API call.
        /// </para>
        /// </summary>
        public LifecycleEventStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}