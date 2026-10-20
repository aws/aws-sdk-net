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
    /// A deployment lifecycle hook runs custom logic or pauses the deployment at specific
    /// stages of the deployment process. You can use Lambda functions or pause hooks as hook
    /// targets.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-lifecycle-hooks.html">Lifecycle
    /// hooks for Amazon ECS service deployments</a> in the <i> Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeploymentLifecycleHook
    {
        /// <summary>
        /// Gets and sets the property HookDetails. 
        /// <para>
        /// Use this field to specify custom parameters that Amazon ECS passes to your Lambda
        /// function on each invocation. This field is not used for <c>PAUSE</c> hooks.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document HookDetails { get; set; }

        /// <summary>
        /// Checks to see if the HookDetails property is set.
        /// </summary>
        internal bool IsSetHookDetails() => !this.HookDetails.IsNull();

        /// <summary>
        /// Gets and sets the property HookTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hook target. For <c>AWS_LAMBDA</c> hooks, this
        /// is the Lambda function ARN. This field is not applicable for <c>PAUSE</c> hooks.
        /// </para>
        ///  
        /// <para>
        /// You must provide this parameter when configuring an <c>AWS_LAMBDA</c> lifecycle hook.
        /// </para>
        /// </summary>
        public string HookTargetArn { get; set; }

        /// <summary>
        /// Checks to see if the HookTargetArn property is set.
        /// </summary>
        internal bool IsSetHookTargetArn() => this.HookTargetArn != null;

        /// <summary>
        /// Gets and sets the property LifecycleStages. 
        /// <para>
        /// The lifecycle stages at which to run the hook. Choose from these valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RECONCILE_SERVICE
        /// </para>
        ///  
        /// <para>
        /// The reconciliation stage that only happens when you start a new service deployment
        /// with more than 1 service revision in an ACTIVE state.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRE_SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The green service revision has not started. The blue service revision is handling
        /// 100% of the production traffic. There is no test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The green service revision has started. The blue service revision is handling 100%
        /// of the production traffic. There is no test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TEST_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The blue and green service revisions are running. The blue service revision handles
        /// 100% of the production traffic. The green service revision is migrating from 0% to
        /// 100% of test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_TEST_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The test traffic shift is complete. The green service revision handles 100% of the
        /// test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRE_PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// Occurs before production traffic shift. For linear and canary deployments, this stage
        /// is invoked before every traffic shift step.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// Production traffic is shifting to the green service revision. The green service revision
        /// is migrating from 0% to 100% of production traffic. For linear and canary deployments,
        /// this stage is invoked at every traffic shift step.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The production traffic shift is complete.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>PAUSE</c> hooks cannot be configured at <c>TEST_TRAFFIC_SHIFT</c> or <c>PRODUCTION_TRAFFIC_SHIFT</c>
        /// stages. These stages are only valid for <c>AWS_LAMBDA</c> hooks.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must provide this parameter when configuring a deployment lifecycle hook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LifecycleStages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LifecycleStages property is set.
        /// </summary>
        internal bool IsSetLifecycleStages() => this.LifecycleStages != null && (this.LifecycleStages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon ECS permission to
        /// call Lambda functions on your behalf.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/blue-green-permissions.html">Permissions
        /// required for Lambda functions in Amazon ECS blue/green deployments</a> in the <i>
        /// Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of action the lifecycle hook performs. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_LAMBDA</c> - Invokes a Lambda function at the specified lifecycle stage. This
        /// is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAUSE</c> - Pauses the deployment at the specified lifecycle stage until you call
        /// <c>ContinueServiceDeployment</c> to continue or roll back.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This field is optional. If not specified, the default value is <c>AWS_LAMBDA</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property TimeoutConfiguration. 
        /// <para>
        /// The timeout configuration for the lifecycle hook. This specifies how long Amazon ECS
        /// waits before taking the timeout action if the hook is not resolved.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookTimeoutConfiguration TimeoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfiguration property is set.
        /// </summary>
        internal bool IsSetTimeoutConfiguration() => this.TimeoutConfiguration != null;
    }
}
