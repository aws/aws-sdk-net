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
    /// Information about a set of Amazon ECS tasks in either an CodeDeploy or an <code>EXTERNAL</code>
    /// deployment. An Amazon ECS task set includes details such as the desired number of
    /// tasks, how many tasks are running, and whether the task set serves production traffic.
    /// </summary>
    public partial class TaskSet
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private string _clusterArn;
        private int? _computedDesiredCount;
        private DateTime? _createdAt;
        private string _externalId;
        private string _id;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private NetworkConfiguration _networkConfiguration;
        private int? _pendingCount;
        private string _platformFamily;
        private string _platformVersion;
        private int? _runningCount;
        private Scale _scale;
        private string _serviceArn;
        private List<ServiceRegistry> _serviceRegistries = new List<ServiceRegistry>();
        private StabilityStatus _stabilityStatus;
        private DateTime? _stabilityStatusAt;
        private string _startedBy;
        private string _status;
        private List<Tag> _tags = new List<Tag>();
        private string _taskDefinition;
        private string _taskSetArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy that are associated with the task set.
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
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that the service that hosts the task
        /// set exists in.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputedDesiredCount. 
        /// <para>
        /// The computed desired count for the task set. This is calculated by multiplying the
        /// service's <code>desiredCount</code> by the task set's <code>scale</code> percentage.
        /// The result is always rounded up. For example, if the computed desired count is 1.2,
        /// it rounds up to 2 tasks.
        /// </para>
        /// </summary>
        public int ComputedDesiredCount
        {
            get { return this._computedDesiredCount.GetValueOrDefault(); }
            set { this._computedDesiredCount = value; }
        }

        // Check to see if ComputedDesiredCount property is set
        internal bool IsSetComputedDesiredCount()
        {
            return this._computedDesiredCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task set was created.
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
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID associated with the task set.
        /// </para>
        ///  
        /// <para>
        /// If an CodeDeploy deployment created a task set, the <code>externalId</code> parameter
        /// contains the CodeDeploy deployment ID.
        /// </para>
        ///  
        /// <para>
        /// If a task set is created for an external deployment and is associated with a service
        /// discovery registry, the <code>externalId</code> parameter contains the <code>ECS_TASK_SET_EXTERNAL_ID</code>
        /// Cloud Map attribute.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the task set.
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
        /// The launch type the tasks in the task set are using. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// Details on a load balancer that are used with a task set.
        /// </para>
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && this._loadBalancers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the task set.
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
        /// The number of tasks in the task set that are in the <code>PENDING</code> status during
        /// a deployment. A task in the <code>PENDING</code> state is preparing to enter the <code>RUNNING</code>
        /// state. A task set enters the <code>PENDING</code> status when it launches for the
        /// first time or when it's restarted after being in the <code>STOPPED</code> state.
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
        /// The operating system that your tasks in the set are running on. A platform family
        /// is specified only for tasks that use the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks in the set must have the same value.
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
        /// The Fargate platform version where the tasks in the task set are running. A platform
        /// version is only specified for tasks run on Fargate. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// platform versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the task set that are in the <code>RUNNING</code> status during
        /// a deployment. A task in the <code>RUNNING</code> state is running and ready for use.
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
        /// Gets and sets the property Scale. 
        /// <para>
        /// A floating-point percentage of your desired number of tasks to place and keep running
        /// in the task set.
        /// </para>
        /// </summary>
        public Scale Scale
        {
            get { return this._scale; }
            set { this._scale = value; }
        }

        // Check to see if Scale property is set
        internal bool IsSetScale()
        {
            return this._scale != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service the task set exists in.
        /// </para>
        /// </summary>
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The details for the service discovery registries to assign to this task set. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// discovery</a>.
        /// </para>
        /// </summary>
        public List<ServiceRegistry> ServiceRegistries
        {
            get { return this._serviceRegistries; }
            set { this._serviceRegistries = value; }
        }

        // Check to see if ServiceRegistries property is set
        internal bool IsSetServiceRegistries()
        {
            return this._serviceRegistries != null && this._serviceRegistries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StabilityStatus. 
        /// <para>
        /// The stability status. This indicates whether the task set has reached a steady state.
        /// If the following conditions are met, the task set are in <code>STEADY_STATE</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The task <code>runningCount</code> is equal to the <code>computedDesiredCount</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>pendingCount</code> is <code>0</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are no tasks that are running on container instances in the <code>DRAINING</code>
        /// status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All tasks are reporting a healthy status from the load balancers, service discovery,
        /// and container health checks.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If any of those conditions aren't met, the stability status returns <code>STABILIZING</code>.
        /// </para>
        /// </summary>
        public StabilityStatus StabilityStatus
        {
            get { return this._stabilityStatus; }
            set { this._stabilityStatus = value; }
        }

        // Check to see if StabilityStatus property is set
        internal bool IsSetStabilityStatus()
        {
            return this._stabilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StabilityStatusAt. 
        /// <para>
        /// The Unix timestamp for the time when the task set stability status was retrieved.
        /// </para>
        /// </summary>
        public DateTime StabilityStatusAt
        {
            get { return this._stabilityStatusAt.GetValueOrDefault(); }
            set { this._stabilityStatusAt = value; }
        }

        // Check to see if StabilityStatusAt property is set
        internal bool IsSetStabilityStatusAt()
        {
            return this._stabilityStatusAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The tag specified when a task set is started. If an CodeDeploy deployment created
        /// the task set, the <code>startedBy</code> parameter is <code>CODE_DEPLOY</code>. If
        /// an external deployment created the task set, the <code>startedBy</code> field isn't
        /// used.
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task set. The following describes each state.
        /// </para>
        ///  <dl> <dt>PRIMARY</dt> <dd> 
        /// <para>
        /// The task set is serving production traffic.
        /// </para>
        ///  </dd> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The task set isn't serving production traffic.
        /// </para>
        ///  </dd> <dt>DRAINING</dt> <dd> 
        /// <para>
        /// The tasks in the task set are being stopped, and their corresponding targets are being
        /// deregistered from their target group.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task set to help you categorize and organize them.
        /// Each tag consists of a key and an optional value. You define both.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for either keys or values as it is reserved for Amazon Web Services
        /// use. You cannot edit or delete tag keys or values with this prefix. Tags with this
        /// prefix do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition that the task set is using.
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
        /// Gets and sets the property TaskSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task set.
        /// </para>
        /// </summary>
        public string TaskSetArn
        {
            get { return this._taskSetArn; }
            set { this._taskSetArn = value; }
        }

        // Check to see if TaskSetArn property is set
        internal bool IsSetTaskSetArn()
        {
            return this._taskSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task set was last updated.
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