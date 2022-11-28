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
    /// The details of an Amazon ECS service deployment. This is used only when a service
    /// uses the <code>ECS</code> deployment controller type.
    /// </summary>
    public partial class Deployment
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private DateTime? _createdAt;
        private int? _desiredCount;
        private int? _failedTasks;
        private string _id;
        private LaunchType _launchType;
        private NetworkConfiguration _networkConfiguration;
        private int? _pendingCount;
        private string _platformFamily;
        private string _platformVersion;
        private DeploymentRolloutState _rolloutState;
        private string _rolloutStateReason;
        private int? _runningCount;
        private ServiceConnectConfiguration _serviceConnectConfiguration;
        private List<ServiceConnectServiceResource> _serviceConnectResources = new List<ServiceConnectServiceResource>();
        private string _status;
        private string _taskDefinition;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy that the deployment is using.
        /// </para>
        /// </summary>
        public List<CapacityProviderStrategyItem> CapacityProviderStrategy
        {
            get { return this._capacityProviderStrategy; }
            set { this._capacityProviderStrategy = value; }
        }

        // Check to see if CapacityProviderStrategy property is set
        internal bool IsSetCapacityProviderStrategy()
        {
            return this._capacityProviderStrategy != null && this._capacityProviderStrategy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the service deployment was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The most recent desired count of tasks that was specified for the service to deploy
        /// or maintain.
        /// </para>
        /// </summary>
        public int DesiredCount
        {
            get { return this._desiredCount.GetValueOrDefault(); }
            set { this._desiredCount = value; }
        }

        // Check to see if DesiredCount property is set
        internal bool IsSetDesiredCount()
        {
            return this._desiredCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedTasks. 
        /// <para>
        /// The number of consecutively failed tasks in the deployment. A task is considered a
        /// failure if the service scheduler can't launch the task, the task doesn't transition
        /// to a <code>RUNNING</code> state, or if it fails any of its defined health checks and
        /// is stopped.
        /// </para>
        ///  <note> 
        /// <para>
        /// Once a service deployment has one or more successfully running tasks, the failed task
        /// count resets to zero and stops being evaluated.
        /// </para>
        ///  </note>
        /// </summary>
        public int FailedTasks
        {
            get { return this._failedTasks.GetValueOrDefault(); }
            set { this._failedTasks = value; }
        }

        // Check to see if FailedTasks property is set
        internal bool IsSetFailedTasks()
        {
            return this._failedTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the tasks in the service are using. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS Launch Types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public LaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The VPC subnet and security group configuration for tasks that receive their own elastic
        /// network interface by using the <code>awsvpc</code> networking mode.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PendingCount. 
        /// <para>
        /// The number of tasks in the deployment that are in the <code>PENDING</code> status.
        /// </para>
        /// </summary>
        public int PendingCount
        {
            get { return this._pendingCount.GetValueOrDefault(); }
            set { this._pendingCount = value; }
        }

        // Check to see if PendingCount property is set
        internal bool IsSetPendingCount()
        {
            return this._pendingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The operating system that your tasks in the service, or tasks are running on. A platform
        /// family is specified only for tasks using the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks that run as part of this service must use the same <code>platformFamily</code>
        /// value as the service, for example, <code> LINUX.</code>.
        /// </para>
        /// </summary>
        public string PlatformFamily
        {
            get { return this._platformFamily; }
            set { this._platformFamily = value; }
        }

        // Check to see if PlatformFamily property is set
        internal bool IsSetPlatformFamily()
        {
            return this._platformFamily != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version that your tasks in the service run on. A platform version is
        /// only specified for tasks using the Fargate launch type. If one isn't specified, the
        /// <code>LATEST</code> platform version is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// Platform Versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RolloutState. <note> 
        /// <para>
        /// The <code>rolloutState</code> of a service is only returned for services that use
        /// the rolling update (<code>ECS</code>) deployment type that aren't behind a Classic
        /// Load Balancer.
        /// </para>
        ///  </note> 
        /// <para>
        /// The rollout state of the deployment. When a service deployment is started, it begins
        /// in an <code>IN_PROGRESS</code> state. When the service reaches a steady state, the
        /// deployment transitions to a <code>COMPLETED</code> state. If the service fails to
        /// reach a steady state and circuit breaker is enabled, the deployment transitions to
        /// a <code>FAILED</code> state. A deployment in <code>FAILED</code> state doesn't launch
        /// any new tasks. For more information, see <a>DeploymentCircuitBreaker</a>.
        /// </para>
        /// </summary>
        public DeploymentRolloutState RolloutState
        {
            get { return this._rolloutState; }
            set { this._rolloutState = value; }
        }

        // Check to see if RolloutState property is set
        internal bool IsSetRolloutState()
        {
            return this._rolloutState != null;
        }

        /// <summary>
        /// Gets and sets the property RolloutStateReason. 
        /// <para>
        /// A description of the rollout state of a deployment.
        /// </para>
        /// </summary>
        public string RolloutStateReason
        {
            get { return this._rolloutStateReason; }
            set { this._rolloutStateReason = value; }
        }

        // Check to see if RolloutStateReason property is set
        internal bool IsSetRolloutStateReason()
        {
            return this._rolloutStateReason != null;
        }

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the deployment that are in the <code>RUNNING</code> status.
        /// </para>
        /// </summary>
        public int RunningCount
        {
            get { return this._runningCount.GetValueOrDefault(); }
            set { this._runningCount = value; }
        }

        // Check to see if RunningCount property is set
        internal bool IsSetRunningCount()
        {
            return this._runningCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceConnectConfiguration. 
        /// <para>
        /// The details of the Service Connect configuration that's used by this deployment. Compare
        /// the configuration between multiple deployments when troubleshooting issues with new
        /// deployments.
        /// </para>
        ///  
        /// <para>
        /// The configuration for this service to discover and connect to services, and be discovered
        /// by, and connected from, other services within a namespace.
        /// </para>
        ///  
        /// <para>
        /// Tasks that run in a namespace can use short names to connect to services in the namespace.
        /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
        /// through a managed proxy container that collects logs and metrics for increased visibility.
        /// Only the tasks that Amazon ECS services create are supported with Service Connect.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ServiceConnectConfiguration ServiceConnectConfiguration
        {
            get { return this._serviceConnectConfiguration; }
            set { this._serviceConnectConfiguration = value; }
        }

        // Check to see if ServiceConnectConfiguration property is set
        internal bool IsSetServiceConnectConfiguration()
        {
            return this._serviceConnectConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceConnectResources. 
        /// <para>
        /// The list of Service Connect resources that are associated with this deployment. Each
        /// list entry maps a discovery name to a Cloud Map service name.
        /// </para>
        /// </summary>
        public List<ServiceConnectServiceResource> ServiceConnectResources
        {
            get { return this._serviceConnectResources; }
            set { this._serviceConnectResources = value; }
        }

        // Check to see if ServiceConnectResources property is set
        internal bool IsSetServiceConnectResources()
        {
            return this._serviceConnectResources != null && this._serviceConnectResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment. The following describes each state.
        /// </para>
        ///  <dl> <dt>PRIMARY</dt> <dd> 
        /// <para>
        /// The most recent deployment of a service.
        /// </para>
        ///  </dd> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// A service deployment that still has running tasks, but are in the process of being
        /// replaced with a new <code>PRIMARY</code> deployment.
        /// </para>
        ///  </dd> <dt>INACTIVE</dt> <dd> 
        /// <para>
        /// A deployment that has been completely replaced.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The most recent task definition that was specified for the tasks in the service to
        /// use.
        /// </para>
        /// </summary>
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the service deployment was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}