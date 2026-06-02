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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The details of a deployment lifecycle hook that is active during a service deployment.
    /// 
    ///  
    /// <para>
    /// You can view lifecycle hook details by calling <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServiceDeployments.html">DescribeServiceDeployments</a>.
    /// </para>
    /// </summary>
    public partial class DeploymentLifecycleHookDetail
    {
        private DateTime? _expiresAt;
        private string _hookId;
        private DeploymentLifecycleHookStatus _status;
        private string _targetArn;
        private DeploymentLifecycleHookTargetType _targetType;
        private DeploymentLifecycleHookAction _timeoutAction;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The time when the lifecycle hook times out. If the hook has not been completed by
        /// this time, Amazon ECS takes the timeout action.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HookId. 
        /// <para>
        /// The ID of the lifecycle hook. Use this value when calling <c>ContinueServiceDeployment</c>
        /// to continue or roll back a paused deployment.
        /// </para>
        /// </summary>
        public string HookId
        {
            get { return this._hookId; }
            set { this._hookId = value; }
        }

        // Check to see if HookId property is set
        internal bool IsSetHookId()
        {
            return this._hookId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the lifecycle hook. Valid values depend on the hook type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>AWS_LAMBDA</c> hooks: <c>IN_PROGRESS</c>, <c>SUCCEEDED</c>, <c>FAILED</c>,
        /// and <c>TIMED_OUT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>PAUSE</c> hooks: <c>AWAITING_ACTION</c>, <c>SUCCEEDED</c>, <c>FAILED</c>, and
        /// <c>TIMED_OUT</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentLifecycleHookStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hook target. For <c>AWS_LAMBDA</c> hooks, this
        /// is the Lambda function ARN. For <c>PAUSE</c> hooks, this field is not set.
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of action the lifecycle hook performs, such as <c>AWS_LAMBDA</c> or <c>PAUSE</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The action Amazon ECS takes when the lifecycle hook times out. Valid values are <c>CONTINUE</c>
        /// and <c>ROLLBACK</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookAction TimeoutAction
        {
            get { return this._timeoutAction; }
            set { this._timeoutAction = value; }
        }

        // Check to see if TimeoutAction property is set
        internal bool IsSetTimeoutAction()
        {
            return this._timeoutAction != null;
        }

    }
}