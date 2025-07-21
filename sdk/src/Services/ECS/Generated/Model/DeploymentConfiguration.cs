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
    /// Optional deployment parameters that control how many tasks run during a deployment
    /// and the ordering of stopping and starting tasks.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private DeploymentAlarms _alarms;
        private int? _bakeTimeInMinutes;
        private DeploymentCircuitBreaker _deploymentCircuitBreaker;
        private List<DeploymentLifecycleHook> _lifecycleHooks = AWSConfigs.InitializeCollections ? new List<DeploymentLifecycleHook>() : null;
        private int? _maximumPercent;
        private int? _minimumHealthyPercent;
        private DeploymentStrategy _strategy;

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
        /// Gets and sets the property BakeTimeInMinutes. 
        /// <para>
        /// The time period when both blue and green service revisions are running simultaneously
        /// after the production traffic has shifted.
        /// </para>
        ///  
        /// <para>
        /// You must provide this parameter when you use the <c>BLUE_GREEN</c> deployment strategy.
        /// </para>
        /// </summary>
        public int? BakeTimeInMinutes
        {
            get { return this._bakeTimeInMinutes; }
            set { this._bakeTimeInMinutes = value; }
        }

        // Check to see if BakeTimeInMinutes property is set
        internal bool IsSetBakeTimeInMinutes()
        {
            return this._bakeTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentCircuitBreaker. <note> 
        /// <para>
        /// The deployment circuit breaker can only be used for services using the rolling update
        /// (<c>ECS</c>) deployment type.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <b>deployment circuit breaker</b> determines whether a service deployment will
        /// fail if the service can't reach a steady state. If you use the deployment circuit
        /// breaker, a service deployment will transition to a failed state and stop launching
        /// new tasks. If you use the rollback option, when a service deployment fails, the service
        /// is rolled back to the last deployment that completed successfully. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html">Rolling
        /// update</a> in the <i>Amazon Elastic Container Service Developer Guide</i> 
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
        /// Gets and sets the property LifecycleHooks. 
        /// <para>
        /// An array of deployment lifecycle hook objects to run custom logic at specific stages
        /// of the deployment lifecycle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeploymentLifecycleHook> LifecycleHooks
        {
            get { return this._lifecycleHooks; }
            set { this._lifecycleHooks = value; }
        }

        // Check to see if LifecycleHooks property is set
        internal bool IsSetLifecycleHooks()
        {
            return this._lifecycleHooks != null && (this._lifecycleHooks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaximumPercent. 
        /// <para>
        /// If a service is using the rolling update (<c>ECS</c>) deployment type, the <c>maximumPercent</c>
        /// parameter represents an upper limit on the number of your service's tasks that are
        /// allowed in the <c>RUNNING</c> or <c>PENDING</c> state during a deployment, as a percentage
        /// of the <c>desiredCount</c> (rounded down to the nearest integer). This parameter enables
        /// you to define the deployment batch size. For example, if your service is using the
        /// <c>REPLICA</c> service scheduler and has a <c>desiredCount</c> of four tasks and a
        /// <c>maximumPercent</c> value of 200%, the scheduler may start four new tasks before
        /// stopping the four older tasks (provided that the cluster resources required to do
        /// this are available). The default <c>maximumPercent</c> value for a service using the
        /// <c>REPLICA</c> service scheduler is 200%.
        /// </para>
        ///  
        /// <para>
        /// The Amazon ECS scheduler uses this parameter to replace unhealthy tasks by starting
        /// replacement tasks first and then stopping the unhealthy tasks, as long as cluster
        /// resources for starting replacement tasks are available. For more information about
        /// how the scheduler replaces unhealthy tasks, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Amazon
        /// ECS services</a>.
        /// </para>
        ///  
        /// <para>
        /// If a service is using either the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c>
        /// deployment types, and tasks in the service use the EC2 launch type, the <b>maximum
        /// percent</b> value is set to the default value. The <b>maximum percent</b> value is
        /// used to define the upper limit on the number of the tasks in the service that remain
        /// in the <c>RUNNING</c> state while the container instances are in the <c>DRAINING</c>
        /// state.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify a custom <c>maximumPercent</c> value for a service that uses either
        /// the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c> deployment types and has tasks
        /// that use the EC2 launch type.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the service uses either the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c>
        /// deployment types, and the tasks in the service use the Fargate launch type, the maximum
        /// percent value is not used. The value is still returned when describing your service.
        /// </para>
        /// </summary>
        public int? MaximumPercent
        {
            get { return this._maximumPercent; }
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
        /// If a service is using the rolling update (<c>ECS</c>) deployment type, the <c>minimumHealthyPercent</c>
        /// represents a lower limit on the number of your service's tasks that must remain in
        /// the <c>RUNNING</c> state during a deployment, as a percentage of the <c>desiredCount</c>
        /// (rounded up to the nearest integer). This parameter enables you to deploy without
        /// using additional cluster capacity. For example, if your service has a <c>desiredCount</c>
        /// of four tasks and a <c>minimumHealthyPercent</c> of 50%, the service scheduler may
        /// stop two existing tasks to free up cluster capacity before starting two new tasks.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If any tasks are unhealthy and if <c>maximumPercent</c> doesn't allow the Amazon
        /// ECS scheduler to start replacement tasks, the scheduler stops the unhealthy tasks
        /// one-by-one — using the <c>minimumHealthyPercent</c> as a constraint — to clear up
        /// capacity to launch replacement tasks. For more information about how the scheduler
        /// replaces unhealthy tasks, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Amazon
        /// ECS services</a> . 
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
        /// will wait for 40 seconds after a task reaches a <c>RUNNING</c> state before the task
        /// is counted towards the minimum healthy percent total.
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
        /// For services that <i>do</i> use a load balancer, the following should be noted:
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
        /// The default value for a replica service for <c>minimumHealthyPercent</c> is 100%.
        /// The default <c>minimumHealthyPercent</c> value for a service using the <c>DAEMON</c>
        /// service schedule is 0% for the CLI, the Amazon Web Services SDKs, and the APIs and
        /// 50% for the Amazon Web Services Management Console.
        /// </para>
        ///  
        /// <para>
        /// The minimum number of healthy tasks during a deployment is the <c>desiredCount</c>
        /// multiplied by the <c>minimumHealthyPercent</c>/100, rounded up to the nearest integer
        /// value.
        /// </para>
        ///  
        /// <para>
        /// If a service is using either the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c>
        /// deployment types and is running tasks that use the EC2 launch type, the <b>minimum
        /// healthy percent</b> value is set to the default value. The <b>minimum healthy percent</b>
        /// value is used to define the lower limit on the number of the tasks in the service
        /// that remain in the <c>RUNNING</c> state while the container instances are in the <c>DRAINING</c>
        /// state.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't specify a custom <c>minimumHealthyPercent</c> value for a service that uses
        /// either the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c> deployment types and
        /// has tasks that use the EC2 launch type.
        /// </para>
        ///  </note> 
        /// <para>
        /// If a service is using either the blue/green (<c>CODE_DEPLOY</c>) or <c>EXTERNAL</c>
        /// deployment types and is running tasks that use the Fargate launch type, the minimum
        /// healthy percent value is not used, although it is returned when describing your service.
        /// </para>
        /// </summary>
        public int? MinimumHealthyPercent
        {
            get { return this._minimumHealthyPercent; }
            set { this._minimumHealthyPercent = value; }
        }

        // Check to see if MinimumHealthyPercent property is set
        internal bool IsSetMinimumHealthyPercent()
        {
            return this._minimumHealthyPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The deployment strategy for the service. Choose from these valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ROLLING</c> - When you create a service which uses the rolling update (<c>ROLLING</c>)
        /// deployment strategy, the Amazon ECS service scheduler replaces the currently running
        /// tasks with new tasks. The number of tasks that Amazon ECS adds or removes from the
        /// service during a rolling update is controlled by the service deployment configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BLUE_GREEN</c> - A blue/green deployment strategy (<c>BLUE_GREEN</c>) is a release
        /// methodology that reduces downtime and risk by running two identical production environments
        /// called blue and green. With Amazon ECS blue/green deployments, you can validate new
        /// service revisions before directing production traffic to them. This approach provides
        /// a safer way to deploy changes with the ability to quickly roll back if needed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

    }
}