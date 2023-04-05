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
    /// Details on a service within a cluster.
    /// </summary>
    public partial class Service
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private string _clusterArn;
        private DateTime? _createdAt;
        private string _createdBy;
        private DeploymentConfiguration _deploymentConfiguration;
        private DeploymentController _deploymentController;
        private List<Deployment> _deployments = new List<Deployment>();
        private int? _desiredCount;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private List<ServiceEvent> _events = new List<ServiceEvent>();
        private int? _healthCheckGracePeriodSeconds;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private NetworkConfiguration _networkConfiguration;
        private int? _pendingCount;
        private List<PlacementConstraint> _placementConstraints = new List<PlacementConstraint>();
        private List<PlacementStrategy> _placementStrategy = new List<PlacementStrategy>();
        private string _platformFamily;
        private string _platformVersion;
        private PropagateTags _propagateTags;
        private string _roleArn;
        private int? _runningCount;
        private SchedulingStrategy _schedulingStrategy;
        private string _serviceArn;
        private string _serviceName;
        private List<ServiceRegistry> _serviceRegistries = new List<ServiceRegistry>();
        private string _status;
        private List<Tag> _tags = new List<Tag>();
        private string _taskDefinition;
        private List<TaskSet> _taskSets = new List<TaskSet>();

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy the service uses. When using the DescribeServices API,
        /// this field is omitted if the service was created using a launch type.
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
        /// The Amazon Resource Name (ARN) of the cluster that hosts the service.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the service was created.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that created the service.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Optional deployment parameters that control how many tasks run during the deployment
        /// and the ordering of stopping and starting tasks.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentController. 
        /// <para>
        /// The deployment controller type the service is using. 
        /// </para>
        /// </summary>
        public DeploymentController DeploymentController
        {
            get { return this._deploymentController; }
            set { this._deploymentController = value; }
        }

        // Check to see if DeploymentController property is set
        internal bool IsSetDeploymentController()
        {
            return this._deploymentController != null;
        }

        /// <summary>
        /// Gets and sets the property Deployments. 
        /// <para>
        /// The current state of deployments for the service.
        /// </para>
        /// </summary>
        public List<Deployment> Deployments
        {
            get { return this._deployments; }
            set { this._deployments = value; }
        }

        // Check to see if Deployments property is set
        internal bool IsSetDeployments()
        {
            return this._deployments != null && this._deployments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The desired number of instantiations of the task definition to keep running on the
        /// service. This value is specified when the service is created with <a>CreateService</a>,
        /// and it can be modified with <a>UpdateService</a>.
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
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Determines whether to use Amazon ECS managed tags for the tasks in the service. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool EnableECSManagedTags
        {
            get { return this._enableecsManagedTags.GetValueOrDefault(); }
            set { this._enableecsManagedTags = value; }
        }

        // Check to see if EnableECSManagedTags property is set
        internal bool IsSetEnableECSManagedTags()
        {
            return this._enableecsManagedTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether the execute command functionality is enabled for the service. If
        /// <code>true</code>, the execute command functionality is enabled for all containers
        /// in tasks as part of the service.
        /// </para>
        /// </summary>
        public bool EnableExecuteCommand
        {
            get { return this._enableExecuteCommand.GetValueOrDefault(); }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The event stream for your service. A maximum of 100 of the latest events are displayed.
        /// </para>
        /// </summary>
        public List<ServiceEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// The period of time, in seconds, that the Amazon ECS service scheduler ignores unhealthy
        /// Elastic Load Balancing target health checks after a task has first started.
        /// </para>
        /// </summary>
        public int HealthCheckGracePeriodSeconds
        {
            get { return this._healthCheckGracePeriodSeconds.GetValueOrDefault(); }
            set { this._healthCheckGracePeriodSeconds = value; }
        }

        // Check to see if HealthCheckGracePeriodSeconds property is set
        internal bool IsSetHealthCheckGracePeriodSeconds()
        {
            return this._healthCheckGracePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the service is using. When using the DescribeServices API, this field
        /// is omitted if the service was created using a capacity provider strategy.
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
        /// A list of Elastic Load Balancing load balancer objects. It contains the load balancer
        /// name, the container name, and the container port to access from the load balancer.
        /// The container name is as it appears in a container definition.
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
        /// The number of tasks in the cluster that are in the <code>PENDING</code> state.
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
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// The placement constraints for the tasks in the service.
        /// </para>
        /// </summary>
        public List<PlacementConstraint> PlacementConstraints
        {
            get { return this._placementConstraints; }
            set { this._placementConstraints = value; }
        }

        // Check to see if PlacementConstraints property is set
        internal bool IsSetPlacementConstraints()
        {
            return this._placementConstraints != null && this._placementConstraints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// The placement strategy that determines how tasks for the service are placed.
        /// </para>
        /// </summary>
        public List<PlacementStrategy> PlacementStrategy
        {
            get { return this._placementStrategy; }
            set { this._placementStrategy = value; }
        }

        // Check to see if PlacementStrategy property is set
        internal bool IsSetPlacementStrategy()
        {
            return this._placementStrategy != null && this._placementStrategy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The operating system that your tasks in the service run on. A platform family is specified
        /// only for tasks using the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks that run as part of this service must use the same <code>platformFamily</code>
        /// value as the service (for example, <code>LINUX</code>).
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
        /// The platform version to run your service on. A platform version is only specified
        /// for tasks that are hosted on Fargate. If one isn't specified, the <code>LATEST</code>
        /// platform version is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
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
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Determines whether to propagate the tags from the task definition or the service to
        /// the task. If no value is specified, the tags aren't propagated.
        /// </para>
        /// </summary>
        public PropagateTags PropagateTags
        {
            get { return this._propagateTags; }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that's associated with the service. It allows the Amazon ECS
        /// container agent to register container instances with an Elastic Load Balancing load
        /// balancer.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <code>RUNNING</code> state.
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
        /// Gets and sets the property SchedulingStrategy. 
        /// <para>
        /// The scheduling strategy to use for the service. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Services</a>.
        /// </para>
        ///  
        /// <para>
        /// There are two service scheduler strategies available.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLICA</code>-The replica scheduling strategy places and maintains the desired
        /// number of tasks across your cluster. By default, the service scheduler spreads tasks
        /// across Availability Zones. You can use task placement strategies and constraints to
        /// customize task placement decisions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code>-The daemon scheduling strategy deploys exactly one task on each
        /// active container instance. This task meets all of the task placement constraints that
        /// you specify in your cluster. The service scheduler also evaluates the task placement
        /// constraints for running tasks. It stop tasks that don't meet the placement constraints.
        /// </para>
        ///  <note> 
        /// <para>
        /// Fargate tasks don't support the <code>DAEMON</code> scheduling strategy.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public SchedulingStrategy SchedulingStrategy
        {
            get { return this._schedulingStrategy; }
            set { this._schedulingStrategy = value; }
        }

        // Check to see if SchedulingStrategy property is set
        internal bool IsSetSchedulingStrategy()
        {
            return this._schedulingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN that identifies the service. For more information about the ARN format, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed. Service names must be unique within a cluster. However, you
        /// can have similarly named services in multiple clusters within a Region or across multiple
        /// Regions.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The details for the service discovery registries to assign to this service. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// Discovery</a>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service. The valid values are <code>ACTIVE</code>, <code>DRAINING</code>,
        /// or <code>INACTIVE</code>.
        /// </para>
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
        /// The metadata that you apply to the service to help you categorize and organize them.
        /// Each tag consists of a key and an optional value. You define bot the key and value.
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
        /// The task definition to use for tasks in the service. This value is specified when
        /// the service is created with <a>CreateService</a>, and it can be modified with <a>UpdateService</a>.
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
        /// Gets and sets the property TaskSets. 
        /// <para>
        /// Information about a set of Amazon ECS tasks in either an CodeDeploy or an <code>EXTERNAL</code>
        /// deployment. An Amazon ECS task set includes details such as the desired number of
        /// tasks, how many tasks are running, and whether the task set serves production traffic.
        /// </para>
        /// </summary>
        public List<TaskSet> TaskSets
        {
            get { return this._taskSets; }
            set { this._taskSets = value; }
        }

        // Check to see if TaskSets property is set
        internal bool IsSetTaskSets()
        {
            return this._taskSets != null && this._taskSets.Count > 0; 
        }

    }
}