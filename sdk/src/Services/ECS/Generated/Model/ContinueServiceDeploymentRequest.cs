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
    /// Container for the parameters to the ContinueServiceDeployment operation.
    /// Continues or rolls back an Amazon ECS service deployment that is paused at a lifecycle
    /// hook.
    /// 
    ///  
    /// <para>
    /// When a service deployment reaches a lifecycle stage that has a <c>PAUSE</c> hook configured,
    /// the deployment pauses and waits for an explicit action. Use this API to either continue
    /// the deployment to the next stage or roll back to the previous service revision.
    /// </para>
    ///  
    /// <para>
    /// To find the <c>hookId</c> of the paused hook, call <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServiceDeployments.html">DescribeServiceDeployments</a>
    /// and inspect the <c>lifecycleHookDetails</c> field.
    /// </para>
    /// </summary>
    public partial class ContinueServiceDeploymentRequest : AmazonECSRequest
    {
        private DeploymentLifecycleHookAction _action;
        private string _hookId;
        private string _serviceDeploymentArn;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on the paused lifecycle hook. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTINUE</c> - Proceeds the deployment to the next lifecycle stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK</c> - Rolls back the deployment to the previous service revision.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If no value is specified, the default action is <c>CONTINUE</c>.
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property HookId. 
        /// <para>
        /// The ID of the paused lifecycle hook to act on. You can find the <c>hookId</c> by calling
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServiceDeployments.html">DescribeServiceDeployments</a>
        /// and inspecting the <c>lifecycleHookDetails</c> field of the service deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ServiceDeploymentArn. 
        /// <para>
        /// The ARN of the service deployment to continue or roll back.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceDeploymentArn
        {
            get { return this._serviceDeploymentArn; }
            set { this._serviceDeploymentArn = value; }
        }

        // Check to see if ServiceDeploymentArn property is set
        internal bool IsSetServiceDeploymentArn()
        {
            return this._serviceDeploymentArn != null;
        }

    }
}