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
    /// <note> 
    /// <para>
    /// The deployment circuit breaker can only be used for services using the rolling update
    /// (<c>ECS</c>) deployment type.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <b>deployment circuit breaker</b> determines whether a service deployment will
    /// fail if the service can't reach a steady state. If it is turned on, a service deployment
    /// will transition to a failed state and stop launching new tasks. You can also configure
    /// Amazon ECS to roll back your service to the last completed deployment after a failure.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html">Rolling
    /// update</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about API failure reasons, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/api_failures_messages.html">API
    /// failure reasons</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeploymentCircuitBreaker
    {
        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Determines whether to use the deployment circuit breaker logic for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Checks to see if the Enable property is set.
        /// </summary>
        internal bool IsSetEnable() => this.Enable.HasValue;

        /// <summary>
        /// Gets and sets the property ResetOnHealthyTask. 
        /// <para>
        /// Specifies whether the deployment circuit breaker resets its failure count when a task
        /// reaches a healthy state. When set to <c>true</c>, a task that reaches a healthy state
        /// resets the failure count to <c>0</c>. When set to <c>false</c>, Amazon ECS does not
        /// reset the failure count. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ResetOnHealthyTask { get; set; }

        /// <summary>
        /// Checks to see if the ResetOnHealthyTask property is set.
        /// </summary>
        internal bool IsSetResetOnHealthyTask() => this.ResetOnHealthyTask.HasValue;

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// Determines whether to configure Amazon ECS to roll back the service if a service deployment
        /// fails. If rollback is on, when a service deployment fails, the service is rolled back
        /// to the last deployment that completed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Rollback { get; set; }

        /// <summary>
        /// Checks to see if the Rollback property is set.
        /// </summary>
        internal bool IsSetRollback() => this.Rollback.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdConfiguration. 
        /// <para>
        /// The threshold configuration that controls when the deployment circuit breaker triggers.
        /// The <c>type</c> and <c>value</c> together determine how many task failures are tolerated
        /// before the circuit breaker activates.
        /// </para>
        /// </summary>
        public ThresholdConfiguration ThresholdConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdConfiguration property is set.
        /// </summary>
        internal bool IsSetThresholdConfiguration() => this.ThresholdConfiguration != null;
    }
}
