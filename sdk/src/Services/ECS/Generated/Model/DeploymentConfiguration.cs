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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Optional deployment parameters that control how many tasks run during a deployment
    /// and the ordering of stopping and starting tasks.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private DeploymentAlarms _alarms;
        private DeploymentCircuitBreaker _deploymentCircuitBreaker;
        private int? _maximumPercent;
        private int? _minimumHealthyPercent;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// Information about the CloudWatch alarms.
        /// </para>
        /// </summary>
        public DeploymentAlarms Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentCircuitBreaker. <note> 
        /// <para>
        /// The deployment circuit breaker can only be used for services using the rolling update
        /// (<code>ECS</code>) deployment type.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <b>deployment circuit breaker</b> determines whether a service deployment will
        /// fail if the service can't reach a steady state. If deployment circuit breaker is enabled,
        /// a service deployment will transition to a failed state and stop launching new tasks.
        /// If rollback is enabled, when a service deployment fails, the service is rolled back
        /// to the last deployment that completed successfully.
        /// </para>
        /// </summary>
        public DeploymentCircuitBreaker DeploymentCircuitBreaker
        {
            get { return this._deploymentCircuitBreaker; }
            set { this._deploymentCircuitBreaker = value; }
        }

        // Check to see if DeploymentCircuitBreaker property is set
        internal bool IsSetDeploymentCircuitBreaker()
        {
            return this._deploymentCircuitBreaker != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPercent. 
        /// <para>
        /// If a service is using the rolling update (<code>ECS</code>) deployment type, the <code>maximumPercent</code>
        /// parameter represents an upper limit on the number of your service's tasks that are
        /// allowed in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment,
        /// as a percentage of the <code>desiredCount</code> (rounded down to the nearest integer).
        /// This parameter enables you to define the deployment batch size. For example, if your
        /// service is using the <code>REPLICA</code> service scheduler and has a <code>desiredCount</code>
        /// of four tasks and a <code>maximumPercent</code> value of 200%, the scheduler may start
        /// four new tasks before stopping the four older tasks (provided that the cluster resources
        /// required to do this are available). The default <code>maximumPercent</code> value
        /// for a service using the <code>REPLICA</code> service scheduler is 200%.
        /// </para>
        ///  
        /// <para>
        /// If a service is using either the blue/green (<code>CODE_DEPLOY</code>) or <code>EXTERNAL</code>
        /// deployment types and tasks that use the EC2 launch type, the <b>maximum percent</b>
        /// value is set to the default value and is used to define the upper limit on the number
        /// of the tasks in the service that remain in the <code>RUNNING</code> state while the
        /// container instances are in the <code>DRAINING</code> state. If the tasks in the service
        /// use the Fargate launch type, the maximum percent value is not used, although it is
        /// returned when describing your service.
        /// </para>
        /// </summary>
        public int MaximumPercent
        {
            get { return this._maximumPercent.GetValueOrDefault(); }
            set { this._maximumPercent = value; }
        }

        // Check to see if MaximumPercent property is set
        internal bool IsSetMaximumPercent()
        {
            return this._maximumPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumHealthyPercent. 
        /// <para>
        /// If a service is using the rolling update (<code>ECS</code>) deployment type, the <code>minimumHealthyPercent</code>
        /// represents a lower limit on the number of your service's tasks that must remain in
        /// the <code>RUNNING</code> state during a deployment, as a percentage of the <code>desiredCount</code>
        /// (rounded up to the nearest integer). This parameter enables you to deploy without
        /// using additional cluster capacity. For example, if your service has a <code>desiredCount</code>
        /// of four tasks and a <code>minimumHealthyPercent</code> of 50%, the service scheduler
        /// may stop two existing tasks to free up cluster capacity before starting two new tasks.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For services that <i>do not</i> use a load balancer, the following should be noted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A service is considered healthy if all essential containers within the tasks in the
        /// service pass their health checks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a task has no essential containers with a health check defined, the service scheduler
        /// will wait for 40 seconds after a task reaches a <code>RUNNING</code> state before
        /// the task is counted towards the minimum healthy percent total.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a task has one or more essential containers with a health check defined, the service
        /// scheduler will wait for the task to reach a healthy status before counting it towards
        /// the minimum healthy percent total. A task is considered healthy when all essential
        /// containers within the task have passed their health checks. The amount of time the
        /// service scheduler can wait for is determined by the container health check settings.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For services are that <i>do</i> use a load balancer, the following should be noted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a task has no essential containers with a health check defined, the service scheduler
        /// will wait for the load balancer target group health check to return a healthy status
        /// before counting the task towards the minimum healthy percent total.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a task has an essential container with a health check defined, the service scheduler
        /// will wait for both the task to reach a healthy status and the load balancer target
        /// group health check to return a healthy status before counting the task towards the
        /// minimum healthy percent total.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a service is using either the blue/green (<code>CODE_DEPLOY</code>) or <code>EXTERNAL</code>
        /// deployment types and is running tasks that use the EC2 launch type, the <b>minimum
        /// healthy percent</b> value is set to the default value and is used to define the lower
        /// limit on the number of the tasks in the service that remain in the <code>RUNNING</code>
        /// state while the container instances are in the <code>DRAINING</code> state. If a service
        /// is using either the blue/green (<code>CODE_DEPLOY</code>) or <code>EXTERNAL</code>
        /// deployment types and is running tasks that use the Fargate launch type, the minimum
        /// healthy percent value is not used, although it is returned when describing your service.
        /// </para>
        /// </summary>
        public int MinimumHealthyPercent
        {
            get { return this._minimumHealthyPercent.GetValueOrDefault(); }
            set { this._minimumHealthyPercent = value; }
        }

        // Check to see if MinimumHealthyPercent property is set
        internal bool IsSetMinimumHealthyPercent()
        {
            return this._minimumHealthyPercent.HasValue; 
        }

    }
}