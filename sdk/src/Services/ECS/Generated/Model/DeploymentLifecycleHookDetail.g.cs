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
        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The time when the lifecycle hook times out. If the hook has not been completed by
        /// this time, Amazon ECS takes the timeout action.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property HookId. 
        /// <para>
        /// The ID of the lifecycle hook. Use this value when calling <c>ContinueServiceDeployment</c>
        /// to continue or roll back a paused deployment.
        /// </para>
        /// </summary>
        public string HookId { get; set; }

        /// <summary>
        /// Checks to see if the HookId property is set.
        /// </summary>
        internal bool IsSetHookId() => this.HookId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the lifecycle hook. Valid values include <c>AWAITING_ACTION</c>, <c>IN_PROGRESS</c>,
        /// <c>SUCCEEDED</c>, <c>FAILED</c>, and <c>TIMED_OUT</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hook target. For <c>AWS_LAMBDA</c> hooks, this
        /// is the Lambda function ARN. For <c>PAUSE</c> hooks, this field is not set.
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of action the lifecycle hook performs, such as <c>AWS_LAMBDA</c> or <c>PAUSE</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The action Amazon ECS takes when the lifecycle hook times out. Valid values are <c>CONTINUE</c>
        /// and <c>ROLLBACK</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookAction TimeoutAction { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutAction property is set.
        /// </summary>
        internal bool IsSetTimeoutAction() => this.TimeoutAction != null;
    }
}
