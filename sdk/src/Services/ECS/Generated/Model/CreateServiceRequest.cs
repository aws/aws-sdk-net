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
    /// Container for the parameters to the CreateService operation.
    /// Runs and maintains your desired number of tasks from a specified task definition.
    /// If the number of tasks running in a service drops below the <code>desiredCount</code>,
    /// Amazon ECS runs another copy of the task in the specified cluster. To update an existing
    /// service, see the <a>UpdateService</a> action.
    /// 
    ///  <note> 
    /// <para>
    /// Starting April 15, 2023, Amazon Web Services will not onboard new customers to Amazon
    /// Elastic Inference (EI), and will help current customers migrate their workloads to
    /// options that offer better price and performance. After April 15, 2023, new customers
    /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
    /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
    /// during the past 30-day period are considered current customers and will be able to
    /// continue using the service. 
    /// </para>
    ///  </note> 
    /// <para>
    /// In addition to maintaining the desired count of tasks in your service, you can optionally
    /// run your service behind one or more load balancers. The load balancers distribute
    /// traffic across the tasks that are associated with the service. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
    /// load balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Tasks for services that don't use a load balancer are considered healthy if they're
    /// in the <code>RUNNING</code> state. Tasks for services that use a load balancer are
    /// considered healthy if they're in the <code>RUNNING</code> state and are reported as
    /// healthy by the load balancer.
    /// </para>
    ///  
    /// <para>
    /// There are two service scheduler strategies available:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>REPLICA</code> - The replica scheduling strategy places and maintains your
    /// desired number of tasks across your cluster. By default, the service scheduler spreads
    /// tasks across Availability Zones. You can use task placement strategies and constraints
    /// to customize task placement decisions. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
    /// scheduler concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DAEMON</code> - The daemon scheduling strategy deploys exactly one task on
    /// each active container instance that meets all of the task placement constraints that
    /// you specify in your cluster. The service scheduler also evaluates the task placement
    /// constraints for running tasks. It also stops tasks that don't meet the placement constraints.
    /// When using this strategy, you don't need to specify a desired number of tasks, a task
    /// placement strategy, or use Service Auto Scaling policies. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Service
    /// scheduler concepts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can optionally specify a deployment configuration for your service. The deployment
    /// is initiated by changing properties. For example, the deployment might be initiated
    /// by the task definition or by your desired count of a service. This is done with an
    /// <a>UpdateService</a> operation. The default value for a replica service for <code>minimumHealthyPercent</code>
    /// is 100%. The default value for a daemon service for <code>minimumHealthyPercent</code>
    /// is 0%.
    /// </para>
    ///  
    /// <para>
    /// If a service uses the <code>ECS</code> deployment controller, the minimum healthy
    /// percent represents a lower limit on the number of tasks in a service that must remain
    /// in the <code>RUNNING</code> state during a deployment. Specifically, it represents
    /// it as a percentage of your desired number of tasks (rounded up to the nearest integer).
    /// This happens when any of your container instances are in the <code>DRAINING</code>
    /// state if the service contains tasks using the EC2 launch type. Using this parameter,
    /// you can deploy without using additional cluster capacity. For example, if you set
    /// your service to have desired number of four tasks and a minimum healthy percent of
    /// 50%, the scheduler might stop two existing tasks to free up cluster capacity before
    /// starting two new tasks. If they're in the <code>RUNNING</code> state, tasks for services
    /// that don't use a load balancer are considered healthy . If they're in the <code>RUNNING</code>
    /// state and reported as healthy by the load balancer, tasks for services that <i>do</i>
    /// use a load balancer are considered healthy . The default value for minimum healthy
    /// percent is 100%.
    /// </para>
    ///  
    /// <para>
    /// If a service uses the <code>ECS</code> deployment controller, the <b>maximum percent</b>
    /// parameter represents an upper limit on the number of tasks in a service that are allowed
    /// in the <code>RUNNING</code> or <code>PENDING</code> state during a deployment. Specifically,
    /// it represents it as a percentage of the desired number of tasks (rounded down to the
    /// nearest integer). This happens when any of your container instances are in the <code>DRAINING</code>
    /// state if the service contains tasks using the EC2 launch type. Using this parameter,
    /// you can define the deployment batch size. For example, if your service has a desired
    /// number of four tasks and a maximum percent value of 200%, the scheduler may start
    /// four new tasks before stopping the four older tasks (provided that the cluster resources
    /// required to do this are available). The default value for maximum percent is 200%.
    /// </para>
    ///  
    /// <para>
    /// If a service uses either the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code> deployment
    /// controller types and tasks that use the EC2 launch type, the <b>minimum healthy percent</b>
    /// and <b>maximum percent</b> values are used only to define the lower and upper limit
    /// on the number of the tasks in the service that remain in the <code>RUNNING</code>
    /// state. This is while the container instances are in the <code>DRAINING</code> state.
    /// If the tasks in the service use the Fargate launch type, the minimum healthy percent
    /// and maximum percent values aren't used. This is the case even if they're currently
    /// visible when describing your service.
    /// </para>
    ///  
    /// <para>
    /// When creating a service that uses the <code>EXTERNAL</code> deployment controller,
    /// you can specify only parameters that aren't controlled at the task set level. The
    /// only required parameter is the service name. You control your services using the <a>CreateTaskSet</a>
    /// operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
    /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When the service scheduler launches new tasks, it determines task placement. For information
    /// about task placement and task placement strategies, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement.html">Amazon
    /// ECS task placement</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonECSRequest
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private string _clientToken;
        private string _cluster;
        private DeploymentConfiguration _deploymentConfiguration;
        private DeploymentController _deploymentController;
        private int? _desiredCount;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
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
        private ServiceConnectConfiguration _serviceConnectConfiguration;
        private string _serviceName;
        private List<ServiceRegistry> _serviceRegistries = new List<ServiceRegistry>();
        private List<Tag> _tags = new List<Tag>();
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy to use for the service.
        /// </para>
        ///  
        /// <para>
        /// If a <code>capacityProviderStrategy</code> is specified, the <code>launchType</code>
        /// parameter must be omitted. If no <code>capacityProviderStrategy</code> or <code>launchType</code>
        /// is specified, the <code>defaultCapacityProviderStrategy</code> for the cluster is
        /// used.
        /// </para>
        ///  
        /// <para>
        /// A capacity provider strategy may contain a maximum of 6 capacity providers.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An identifier that you provide to ensure the idempotency of the request. It must be
        /// unique and is case sensitive. Up to 32 ASCII characters are allowed.
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
        /// The short name or full Amazon Resource Name (ARN) of the cluster that you run your
        /// service on. If you do not specify a cluster, the default cluster is assumed.
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
        /// The deployment controller to use for the service. If no deployment controller is specified,
        /// the default value of <code>ECS</code> is used.
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
        ///  
        /// <para>
        /// This is required if <code>schedulingStrategy</code> is <code>REPLICA</code> or isn't
        /// specified. If <code>schedulingStrategy</code> is <code>DAEMON</code> then this isn't
        /// required.
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
        /// Specifies whether to turn on Amazon ECS managed tags for the tasks within the service.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// your Amazon ECS resources</a> in the <i>Amazon Elastic Container Service Developer
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
        /// <code>true</code>, this enables execute command functionality on all containers in
        /// the service tasks.
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
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// The period of time, in seconds, that the Amazon ECS service scheduler ignores unhealthy
        /// Elastic Load Balancing target health checks after a task has first started. This is
        /// only used when your service is configured to use a load balancer. If your service
        /// has a load balancer defined and you don't specify a health check grace period value,
        /// the default value of <code>0</code> is used.
        /// </para>
        ///  
        /// <para>
        /// If you do not use an Elastic Load Balancing, we recommend that you use the <code>startPeriod</code>
        /// in the task definition health check parameters. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_HealthCheck.html">Health
        /// check</a>.
        /// </para>
        ///  
        /// <para>
        /// If your service's tasks take a while to start and respond to Elastic Load Balancing
        /// health checks, you can specify a health check grace period of up to 2,147,483,647
        /// seconds (about 69 years). During that time, the Amazon ECS service scheduler ignores
        /// health check status. This grace period can prevent the service scheduler from marking
        /// tasks as unhealthy and stopping them before they have time to come up.
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
        /// The infrastructure that you run your service on. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <code>FARGATE</code> launch type runs your tasks on Fargate On-Demand infrastructure.
        /// </para>
        ///  <note> 
        /// <para>
        /// Fargate Spot infrastructure is available for use but a capacity provider strategy
        /// must be used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/userguide/fargate-capacity-providers.html">Fargate
        /// capacity providers</a> in the <i>Amazon ECS User Guide for Fargate</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>EC2</code> launch type runs your tasks on Amazon EC2 instances registered
        /// to your cluster.
        /// </para>
        ///  
        /// <para>
        /// The <code>EXTERNAL</code> launch type runs your tasks on your on-premises server or
        /// virtual machine (VM) capacity registered to your cluster.
        /// </para>
        ///  
        /// <para>
        /// A service can use either a launch type or a capacity provider strategy. If a <code>launchType</code>
        /// is specified, the <code>capacityProviderStrategy</code> parameter must be omitted.
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
        /// A load balancer object representing the load balancers to use with your service. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-load-balancing.html">Service
        /// load balancing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the service uses the rolling update (<code>ECS</code>) deployment controller and
        /// using either an Application Load Balancer or Network Load Balancer, you must specify
        /// one or more target group ARNs to attach to the service. The service-linked role is
        /// required for services that use multiple target groups. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// service-linked roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the service uses the <code>CODE_DEPLOY</code> deployment controller, the service
        /// is required to use either an Application Load Balancer or Network Load Balancer. When
        /// creating an CodeDeploy deployment group, you specify two target groups (referred to
        /// as a <code>targetGroupPair</code>). During a deployment, CodeDeploy determines which
        /// task set in your service has the status <code>PRIMARY</code>, and it associates one
        /// target group with it. Then, it also associates the other target group with the replacement
        /// task set. The load balancer can also have up to two listeners: a required listener
        /// for production traffic and an optional listener that you can use to perform validation
        /// tests with Lambda functions before routing production traffic to it.
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>CODE_DEPLOY</code> deployment controller, these values can be
        /// changed when updating the service.
        /// </para>
        ///  
        /// <para>
        /// For Application Load Balancers and Network Load Balancers, this object must contain
        /// the load balancer target group ARN, the container name, and the container port to
        /// access from the load balancer. The container name must be as it appears in a container
        /// definition. The load balancer name parameter must be omitted. When a task from this
        /// service is placed on a container instance, the container instance and port combination
        /// is registered as a target in the target group that's specified here.
        /// </para>
        ///  
        /// <para>
        /// For Classic Load Balancers, this object must contain the load balancer name, the container
        /// name , and the container port to access from the load balancer. The container name
        /// must be as it appears in a container definition. The target group ARN parameter must
        /// be omitted. When a task from this service is placed on a container instance, the container
        /// instance is registered with the load balancer that's specified here.
        /// </para>
        ///  
        /// <para>
        /// Services with tasks that use the <code>awsvpc</code> network mode (for example, those
        /// with the Fargate launch type) only support Application Load Balancers and Network
        /// Load Balancers. Classic Load Balancers aren't supported. Also, when you create any
        /// target groups for these services, you must choose <code>ip</code> as the target type,
        /// not <code>instance</code>. This is because tasks that use the <code>awsvpc</code>
        /// network mode are associated with an elastic network interface, not an Amazon EC2 instance.
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
        /// interface, and it isn't supported for other network modes. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// specify a maximum of 10 constraints for each task. This limit includes constraints
        /// in the task definition and those specified at runtime.
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
        /// maximum of 5 strategy rules for each service.
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
        /// The platform version that your tasks in the service are running on. A platform version
        /// is specified only for tasks using the Fargate launch type. If one isn't specified,
        /// the <code>LATEST</code> platform version is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
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
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the task definition to the task. If no
        /// value is specified, the tags aren't propagated. Tags can only be propagated to the
        /// task during task creation. To add tags to a task after task creation, use the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TagResource.html">TagResource</a>
        /// API action.
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
        /// if you are using a load balancer with your service and your task definition doesn't
        /// use the <code>awsvpc</code> network mode. If you specify the <code>role</code> parameter,
        /// you must also specify a load balancer object with the <code>loadBalancers</code> parameter.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your account has already created the Amazon ECS service-linked role, that role
        /// is used for your service unless you specify a role here. The service-linked role is
        /// required if your task definition uses the <code>awsvpc</code> network mode or if the
        /// service is configured to use service discovery, an external deployment controller,
        /// multiple target groups, or Elastic Inference accelerators in which case you don't
        /// specify a role here. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using-service-linked-roles.html">Using
        /// service-linked roles for Amazon ECS</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If your specified role has a path other than <code>/</code>, then you must either
        /// specify the full role ARN (this is recommended) or prefix the role name with the path.
        /// For example, if a role with the name <code>bar</code> has a path of <code>/foo/</code>
        /// then you would specify <code>/foo/bar</code> as the role name. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-friendly-names">Friendly
        /// names and paths</a> in the <i>IAM User Guide</i>.
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
        /// The scheduling strategy to use for the service. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs_services.html">Services</a>.
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
        /// customize task placement decisions. This scheduler strategy is required if the service
        /// uses the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code> deployment controller types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DAEMON</code>-The daemon scheduling strategy deploys exactly one task on each
        /// active container instance that meets all of the task placement constraints that you
        /// specify in your cluster. The service scheduler also evaluates the task placement constraints
        /// for running tasks and will stop tasks that don't meet the placement constraints. When
        /// you're using this strategy, you don't need to specify a desired number of tasks, a
        /// task placement strategy, or use Service Auto Scaling policies.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tasks using the Fargate launch type or the <code>CODE_DEPLOY</code> or <code>EXTERNAL</code>
        /// deployment controller types don't support the <code>DAEMON</code> scheduling strategy.
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
        /// Gets and sets the property ServiceConnectConfiguration. 
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed. Service names must be unique within a cluster, but you can
        /// have similarly named services in multiple clusters within a Region or across multiple
        /// Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The details of the service discovery registry to associate with this service. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// discovery</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each service may be associated with one service registry. Multiple service registries
        /// for each service isn't supported.
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
        /// service is deleted, the tags are deleted as well.
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
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full ARN of the task definition to run in your service. If a <code>revision</code>
        /// isn't specified, the latest <code>ACTIVE</code> revision is used.
        /// </para>
        ///  
        /// <para>
        /// A task definition must be specified if the service uses either the <code>ECS</code>
        /// or <code>CODE_DEPLOY</code> deployment controllers.
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