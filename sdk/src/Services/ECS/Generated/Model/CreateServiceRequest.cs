/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateService operation.
    /// Runs and maintains a desired number of tasks from a specified task definition. If
    /// the number of tasks running in a service drops below <code>desiredCount</code>, Amazon
    /// ECS spawns another copy of the task in the specified cluster. To update an existing
    /// service, see <a>UpdateService</a>.
    /// 
    ///  
    /// <para>
    /// In addition to maintaining the desired count of tasks in your service, you can optionally
    /// run your service behind a load balancer. The load balancer distributes traffic across
    /// the tasks that are associated with the service. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
    /// Load Balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can optionally specify a deployment configuration for your service. The deployment
    /// is triggered by changing properties, such as the task definition or the desired count
    /// of a service, with an <a>UpdateService</a> operation.
    /// </para>
    ///  
    /// <para>
    /// If a service is using the <code>ECS</code> deployment controller, the <b>minimum healthy
    /// percent</b> represents a lower limit on the number of tasks in a service that must
    /// remain in the <code>RUNNING</code> state during a deployment, as a percentage of the
    /// desired number of tasks (rounded up to the nearest integer), and while any container
    /// instances are in the <code>DRAINING</code> state if the service contains tasks using
    /// the EC2 launch type. This parameter enables you to deploy without using additional
    /// cluster capacity. For example, if your service has a desired number of four tasks
    /// and a minimum healthy percent of 50%, the scheduler may stop two existing tasks to
    /// free up cluster capacity before starting two new tasks. Tasks for services that <i>do
    /// not</i> use a load balancer are considered healthy if they are in the <code>RUNNING</code>
    /// state; tasks for services that <i>do</i> use a load balancer are considered healthy
    /// if they are in the <code>RUNNING</code> state and they are reported as healthy by
    /// the load balancer. The default value for minimum healthy percent is 100%.
    /// </para>
    ///  
    /// <para>
    /// If a service is using the <code>ECS</code> deployment controller, the <b>maximum percent</b>
    /// parameter represents an upper limit on the number of tasks in a service that are allowed
    /// in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment, as
    /// a percentage of the desired number of tasks (rounded down to the nearest integer),
    /// and while any container instances are in the <code>DRAINING</code> state if the service
    /// contains tasks using the EC2 launch type. This parameter enables you to define the
    /// deployment batch size. For example, if your service has a desired number of four tasks
    /// and a maximum percent value of 200%, the scheduler may start four new tasks before
    /// stopping the four older tasks (provided that the cluster resources required to do
    /// this are available). The default value for maximum percent is 200%.
    /// </para>
    ///  
    /// <para>
    /// If a service is using the <code>CODE_DEPLOY</code> deployment controller and tasks
    /// that use the EC2 launch type, the <b>minimum healthy percent</b> and <b>maximum percent</b>
    /// values are only used to define the lower and upper limit on the number of the tasks
    /// in the service that remain in the <code>RUNNING</code> state while the container instances
    /// are in the <code>DRAINING</code> state. If the tasks in the service use the Fargate
    /// launch type, the minimum healthy percent and maximum percent values are not used,
    /// although they are currently visible when describing your service.
    /// </para>
    ///  
    /// <para>
    /// Tasks for services that <i>do not</i> use a load balancer are considered healthy if
    /// they are in the <code>RUNNING</code> state. Tasks for services that <i>do</i> use
    /// a load balancer are considered healthy if they are in the <code>RUNNING</code> state
    /// and the container instance they are hosted on is reported as healthy by the load balancer.
    /// The default value for a replica service for <code>minimumHealthyPercent</code> is
    /// 100%. The default value for a daemon service for <code>minimumHealthyPercent</code>
    /// is 0%.
    /// </para>
    ///  
    /// <para>
    /// When the service scheduler launches new tasks, it determines task placement in your
    /// cluster using the following logic:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Determine which of the container instances in your cluster can support your service's
    /// task definition (for example, they have the required CPU, memory, ports, and container
    /// instance attributes).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// By default, the service scheduler attempts to balance tasks across Availability Zones
    /// in this manner (although you can choose a different placement strategy) with the <code>placementStrategy</code>
    /// parameter):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Sort the valid container instances, giving priority to instances that have the fewest
    /// number of running tasks for this service in their respective Availability Zone. For
    /// example, if zone A has one running service task and zones B and C each have zero,
    /// valid container instances in either zone B or C are considered optimal for placement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Place the new service task on a valid container instance in an optimal Availability
    /// Zone (based on the previous steps), favoring container instances with the fewest number
    /// of running tasks for this service.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class CreateServiceRequest : AmazonECSRequest
    {
        private string _clientToken;
        private string _cluster;
        private DeploymentConfiguration _deploymentConfiguration;
        private DeploymentController _deploymentController;
        private int? _desiredCount;
        private bool? _enableecsManagedTags;
        private int? _healthCheckGracePeriodSeconds;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private NetworkConfiguration _networkConfiguration;
        private List<PlacementConstraint> _placementConstraints = new List<PlacementConstraint>();
        private List<PlacementStrategy> _placementStrategy = new List<PlacementStrategy>();
        private string _platformVersion;
        private PropagateTags _propagateTags;
        private string _role;
        private SchedulingStrategy _schedulingStrategy;
        private string _serviceName;
        private List<ServiceRegistry> _serviceRegistries = new List<ServiceRegistry>();
        private List<Tag> _tags = new List<Tag>();
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. Up to 32 ASCII characters are allowed.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster on which to run your
        /// service. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
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
        /// The deployment controller to use for the service.
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
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The number of instantiations of the specified task definition to place and keep running
        /// on your cluster.
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
        /// Specifies whether to enable Amazon ECS managed tags for the tasks within the service.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
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
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// The period of time, in seconds, that the Amazon ECS service scheduler should ignore
        /// unhealthy Elastic Load Balancing target health checks after a task has first started.
        /// This is only valid if your service is configured to use a load balancer. If your service's
        /// tasks take a while to start and respond to Elastic Load Balancing health checks, you
        /// can specify a health check grace period of up to 7,200 seconds. During that time,
        /// the ECS service scheduler ignores health check status. This grace period can prevent
        /// the ECS service scheduler from marking tasks as unhealthy and stopping them before
        /// they have time to come up.
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
        /// The launch type on which to run your service. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
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
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// A load balancer object representing the load balancer to use with your service.
        /// </para>
        ///  
        /// <para>
        /// If the service is using the <code>ECS</code> deployment controller, you are limited
        /// to one load balancer or target group.
        /// </para>
        ///  
        /// <para>
        /// If the service is using the <code>CODE_DEPLOY</code> deployment controller, the service
        /// is required to use either an Application Load Balancer or Network Load Balancer. When
        /// creating an AWS CodeDeploy deployment group, you specify two target groups (referred
        /// to as a <code>targetGroupPair</code>). During a deployment, AWS CodeDeploy determines
        /// which task set in your service has the status <code>PRIMARY</code> and associates
        /// one target group with it, and then associates the other target group with the replacement
        /// task set. The load balancer can also have up to two listeners: a required listener
        /// for production traffic and an optional listener that allows you perform validation
        /// tests with Lambda functions before routing production traffic to it.
        /// </para>
        ///  
        /// <para>
        /// After you create a service using the <code>ECS</code> deployment controller, the load
        /// balancer name or target group ARN, container name, and container port specified in
        /// the service definition are immutable. If you are using the <code>CODE_DEPLOY</code>
        /// deployment controller, these values can be changed when updating the service.
        /// </para>
        ///  
        /// <para>
        /// For Classic Load Balancers, this object must contain the load balancer name, the container
        /// name (as it appears in a container definition), and the container port to access from
        /// the load balancer. When a task from this service is placed on a container instance,
        /// the container instance is registered with the load balancer specified here.
        /// </para>
        ///  
        /// <para>
        /// For Application Load Balancers and Network Load Balancers, this object must contain
        /// the load balancer target group ARN, the container name (as it appears in a container
        /// definition), and the container port to access from the load balancer. When a task
        /// from this service is placed on a container instance, the container instance and port
        /// combination is registered as a target in the target group specified here.
        /// </para>
        ///  
        /// <para>
        /// Services with tasks that use the <code>awsvpc</code> network mode (for example, those
        /// with the Fargate launch type) only support Application Load Balancers and Network
        /// Load Balancers. Classic Load Balancers are not supported. Also, when you create any
        /// target groups for these services, you must choose <code>ip</code> as the target type,
        /// not <code>instance</code>, because tasks that use the <code>awsvpc</code> network
        /// mode are associated with an elastic network interface, not an Amazon EC2 instance.
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
        /// The network configuration for the service. This parameter is required for task definitions
        /// that use the <code>awsvpc</code> network mode to receive their own elastic network
        /// interface, and it is not supported for other network modes. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// Networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// An array of placement constraint objects to use for tasks in your service. You can
        /// specify a maximum of 10 constraints per task (this limit includes constraints in the
        /// task definition and those specified at runtime). 
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
        /// The placement strategy objects to use for tasks in your service. You can specify a
        /// maximum of five strategy rules per service.
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
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version on which your tasks in the service are running. A platform version
        /// is only specified for tasks using the Fargate launch type. If one is not specified,
        /// the <code>LATEST</code> platform version is used by default. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
        /// Fargate Platform Versions</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
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
        /// Specifies whether to propagate the tags from the task definition or the service to
        /// the tasks in the service. If no value is specified, the tags are not propagated. Tags
        /// can only be propagated to the tasks within the service during service creation. To
        /// add tags to a task after service creation, use the <a>TagResource</a> API action.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The name or full Amazon Resource Name (ARN) of the IAM role that allows Amazon ECS
        /// to make calls to your load balancer on your behalf. This parameter is only permitted
        /// if you are using a load balancer with your service and your task definition does not
        /// use the <code>awsvpc</code> network mode. If you specify the <code>role</code> parameter,
        /// you must also specify a load balancer object with the <code>loadBalancers</code> parameter.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your account has already created the Amazon ECS service-linked role, that role
        /// is used by default for your service unless you specify a role here. The service-linked
        /// role is required if your task definition uses the <code>awsvpc</code> network mode,
        /// in which case you should not specify a role here. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If your specified role has a path other than <code>/</code>, then you must either
        /// specify the full role ARN (this is recommended) or prefix the role name with the path.
        /// For example, if a role with the name <code>bar</code> has a path of <code>/foo/</code>
        /// then you would specify <code>/foo/bar</code> as the role name. For more information,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-friendly-names">Friendly
        /// Names and Paths</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulingStrategy. 
        /// <para>
        /// The scheduling strategy to use for the service. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Services</a>.
        /// </para>
        ///  
        /// <para>
        /// There are two service scheduler strategies available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>REPLICA</code>-The replica scheduling strategy places and maintains the desired
        /// number of tasks across your cluster. By default, the service scheduler spreads tasks
        /// across Availability Zones. You can use task placement strategies and constraints to
        /// customize task placement decisions. This scheduler strategy is required if using the
        /// <code>CODE_DEPLOY</code> deployment controller.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code>-The daemon scheduling strategy deploys exactly one task on each
        /// active container instance that meets all of the task placement constraints that you
        /// specify in your cluster. When you are using this strategy, there is no need to specify
        /// a desired number of tasks, a task placement strategy, or use Service Auto Scaling
        /// policies.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tasks using the Fargate launch type or the <code>CODE_DEPLOY</code> deploymenet controller
        /// do not support the <code>DAEMON</code> scheduling strategy.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, hyphens,
        /// and underscores are allowed. Service names must be unique within a cluster, but you
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
        /// The details of the service discovery registries to assign to this service. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// Discovery</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Service discovery is supported for Fargate tasks if you are using platform version
        /// v1.1.0 or later. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
        /// Fargate Platform Versions</a>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the service to help you categorize and organize them.
        /// Each tag consists of a key and an optional value, both of which you define. When a
        /// service is deleted, the tags are deleted as well. Tag keys can have a maximum character
        /// length of 128 characters, and tag values can have a maximum length of 256 characters.
        /// </para>
        /// </summary>
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
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full ARN of the task definition to run in your service. If a <code>revision</code>
        /// is not specified, the latest <code>ACTIVE</code> revision is used.
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

    }
}