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
    /// You can optionally specify a deployment configuration for your service. During a deployment,
    /// the service scheduler uses the <code>minimumHealthyPercent</code> and <code>maximumPercent</code>
    /// parameters to determine the deployment strategy. The deployment is triggered by changing
    /// the task definition or the desired count of a service with an <a>UpdateService</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// The <code>minimumHealthyPercent</code> represents a lower limit on the number of your
    /// service's tasks that must remain in the <code>RUNNING</code> state during a deployment,
    /// as a percentage of the <code>desiredCount</code> (rounded up to the nearest integer).
    /// This parameter enables you to deploy without using additional cluster capacity. For
    /// example, if your service has a <code>desiredCount</code> of four tasks and a <code>minimumHealthyPercent</code>
    /// of 50%, the scheduler can stop two existing tasks to free up cluster capacity before
    /// starting two new tasks. Tasks for services that <i>do not</i> use a load balancer
    /// are considered healthy if they are in the <code>RUNNING</code> state. Tasks for services
    /// that <i>do</i> use a load balancer are considered healthy if they are in the <code>RUNNING</code>
    /// state and the container instance they are hosted on is reported as healthy by the
    /// load balancer. The default value for <code>minimumHealthyPercent</code> is 50% in
    /// the console and 100% for the AWS CLI, the AWS SDKs, and the APIs.
    /// </para>
    ///  
    /// <para>
    /// The <code>maximumPercent</code> parameter represents an upper limit on the number
    /// of your service's tasks that are allowed in the <code>RUNNING</code> or <code>PENDING</code>
    /// state during a deployment, as a percentage of the <code>desiredCount</code> (rounded
    /// down to the nearest integer). This parameter enables you to define the deployment
    /// batch size. For example, if your service has a <code>desiredCount</code> of four tasks
    /// and a <code>maximumPercent</code> value of 200%, the scheduler can start four new
    /// tasks before stopping the four older tasks (provided that the cluster resources required
    /// to do this are available). The default value for <code>maximumPercent</code> is 200%.
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
        private int? _desiredCount;
        private int? _healthCheckGracePeriodSeconds;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = new List<LoadBalancer>();
        private NetworkConfiguration _networkConfiguration;
        private List<PlacementConstraint> _placementConstraints = new List<PlacementConstraint>();
        private List<PlacementStrategy> _placementStrategy = new List<PlacementStrategy>();
        private string _platformVersion;
        private string _role;
        private string _serviceName;
        private List<ServiceRegistry> _serviceRegistries = new List<ServiceRegistry>();
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
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// The period of time, in seconds, that the Amazon ECS service scheduler should ignore
        /// unhealthy Elastic Load Balancing target health checks after a task has first started.
        /// This is only valid if your service is configured to use a load balancer. If your service's
        /// tasks take a while to start and respond to Elastic Load Balancing health checks, you
        /// can specify a health check grace period of up to 1,800 seconds during which the ECS
        /// service scheduler ignores health check status. This grace period can prevent the ECS
        /// service scheduler from marking tasks as unhealthy and stopping them before they have
        /// time to come up.
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
        /// The launch type on which to run your service.
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
        /// A load balancer object representing the load balancer to use with your service. Currently,
        /// you are limited to one load balancer or target group per service. After you create
        /// a service, the load balancer name or target group ARN, container name, and container
        /// port specified in the service definition are immutable.
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
        /// Load Balancers; Classic Load Balancers are not supported. Also, when you create any
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
        /// that use the <code>awsvpc</code> network mode to receive their own Elastic Network
        /// Interface, and it is not supported for other network modes. For more information,
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
        /// task definition and those specified at run time). 
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
        /// The platform version on which to run your service. If one is not specified, the latest
        /// version is used by default.
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, hyphens,
        /// and underscores are allowed. Service names must be unique within a cluster, but you
        /// can have similarly named services in multiple clusters within a region or across multiple
        /// regions.
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
        /// The details of the service discovery registries you want to assign to this service.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// Discovery</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Service discovery is supported for Fargate tasks if using platform version v1.1.0
        /// or later. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
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