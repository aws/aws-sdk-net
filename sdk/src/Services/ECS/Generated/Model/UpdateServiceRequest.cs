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
    /// Container for the parameters to the UpdateService operation.
    /// Modifies the parameters of a service.
    /// 
    ///  <note> 
    /// <para>
    /// On March 21, 2024, a change was made to resolve the task definition revision before
    /// authorization. When a task definition revision is not specified, authorization will
    /// occur using the latest revision of a task definition.
    /// </para>
    ///  </note> 
    /// <para>
    /// For services using the rolling update (<c>ECS</c>) you can update the desired count,
    /// deployment configuration, network configuration, load balancers, service registries,
    /// enable ECS managed tags option, propagate tags option, task placement constraints
    /// and strategies, and task definition. When you update any of these parameters, Amazon
    /// ECS starts new tasks with the new configuration. 
    /// </para>
    ///  
    /// <para>
    /// You can attach Amazon EBS volumes to Amazon ECS tasks by configuring the volume when
    /// starting or running a task, or when creating or updating a service. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volume-types">Amazon
    /// EBS volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>. You
    /// can update your volume configurations and trigger a new deployment. <c>volumeConfigurations</c>
    /// is only supported for REPLICA service and not DAEMON service. If you leave <c>volumeConfigurations</c>
    /// <c>null</c>, it doesn't trigger a new deployment. For more information on volumes,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volume-types">Amazon
    /// EBS volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For services using the blue/green (<c>CODE_DEPLOY</c>) deployment controller, only
    /// the desired count, deployment configuration, health check grace period, task placement
    /// constraints and strategies, enable ECS managed tags option, and propagate tags can
    /// be updated using this API. If the network configuration, platform version, task definition,
    /// or load balancer need to be updated, create a new CodeDeploy deployment. For more
    /// information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
    /// in the <i>CodeDeploy API Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// For services using an external deployment controller, you can update only the desired
    /// count, task placement constraints and strategies, health check grace period, enable
    /// ECS managed tags option, and propagate tags option, using this API. If the launch
    /// type, load balancer, network configuration, platform version, or task definition need
    /// to be updated, create a new task set For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateTaskSet.html">CreateTaskSet</a>.
    /// </para>
    ///  
    /// <para>
    /// You can add to or subtract from the number of instantiations of a task definition
    /// in a service by specifying the cluster that the service is running in and a new <c>desiredCount</c>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// You can attach Amazon EBS volumes to Amazon ECS tasks by configuring the volume when
    /// starting or running a task, or when creating or updating a service. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volume-types">Amazon
    /// EBS volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you have updated the container image of your application, you can create a new
    /// task definition with that image and deploy it to your service. The service scheduler
    /// uses the minimum healthy percent and maximum percent parameters (in the service's
    /// deployment configuration) to determine the deployment strategy.
    /// </para>
    ///  <note> 
    /// <para>
    /// If your updated Docker image uses the same tag as what is in the existing task definition
    /// for your service (for example, <c>my_image:latest</c>), you don't need to create a
    /// new revision of your task definition. You can update the service using the <c>forceNewDeployment</c>
    /// option. The new tasks launched by the deployment pull the current image/tag combination
    /// from your repository when they start.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can also update the deployment configuration of a service. When a deployment is
    /// triggered by updating the task definition of a service, the service scheduler uses
    /// the deployment configuration parameters, <c>minimumHealthyPercent</c> and <c>maximumPercent</c>,
    /// to determine the deployment strategy.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If <c>minimumHealthyPercent</c> is below 100%, the scheduler can ignore <c>desiredCount</c>
    /// temporarily during a deployment. For example, if <c>desiredCount</c> is four tasks,
    /// a minimum of 50% allows the scheduler to stop two existing tasks before starting two
    /// new tasks. Tasks for services that don't use a load balancer are considered healthy
    /// if they're in the <c>RUNNING</c> state. Tasks for services that use a load balancer
    /// are considered healthy if they're in the <c>RUNNING</c> state and are reported as
    /// healthy by the load balancer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>maximumPercent</c> parameter represents an upper limit on the number of running
    /// tasks during a deployment. You can use it to define the deployment batch size. For
    /// example, if <c>desiredCount</c> is four tasks, a maximum of 200% starts four new tasks
    /// before stopping the four older tasks (provided that the cluster resources required
    /// to do this are available).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateService.html">UpdateService</a>
    /// stops a task during a deployment, the equivalent of <c>docker stop</c> is issued to
    /// the containers running in the task. This results in a <c>SIGTERM</c> and a 30-second
    /// timeout. After this, <c>SIGKILL</c> is sent and the containers are forcibly stopped.
    /// If the container handles the <c>SIGTERM</c> gracefully and exits within 30 seconds
    /// from receiving it, no <c>SIGKILL</c> is sent.
    /// </para>
    ///  
    /// <para>
    /// When the service scheduler launches new tasks, it determines task placement in your
    /// cluster with the following logic.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Determine which of the container instances in your cluster can support your service's
    /// task definition. For example, they have the required CPU, memory, ports, and container
    /// instance attributes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// By default, the service scheduler attempts to balance tasks across Availability Zones
    /// in this manner even though you can choose a different placement strategy.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Sort the valid container instances by the fewest number of running tasks for this
    /// service in the same Availability Zone as the instance. For example, if zone A has
    /// one running service task and zones B and C each have zero, valid container instances
    /// in either zone B or C are considered optimal for placement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Place the new service task on a valid container instance in an optimal Availability
    /// Zone (based on the previous steps), favoring container instances with the fewest number
    /// of running tasks for this service.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// When the service scheduler stops running tasks, it attempts to maintain balance across
    /// the Availability Zones in your cluster using the following logic: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Sort the container instances by the largest number of running tasks for this service
    /// in the same Availability Zone as the instance. For example, if zone A has one running
    /// service task and zones B and C each have two, container instances in either zone B
    /// or C are considered optimal for termination.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stop the task on a container instance in an optimal Availability Zone (based on the
    /// previous steps), favoring container instances with the largest number of running tasks
    /// for this service.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateServiceRequest : AmazonECSRequest
    {
        private AvailabilityZoneRebalancing _availabilityZoneRebalancing;
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;
        private string _cluster;
        private DeploymentConfiguration _deploymentConfiguration;
        private DeploymentController _deploymentController;
        private int? _desiredCount;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private bool? _forceNewDeployment;
        private int? _healthCheckGracePeriodSeconds;
        private List<LoadBalancer> _loadBalancers = AWSConfigs.InitializeCollections ? new List<LoadBalancer>() : null;
        private NetworkConfiguration _networkConfiguration;
        private List<PlacementConstraint> _placementConstraints = AWSConfigs.InitializeCollections ? new List<PlacementConstraint>() : null;
        private List<PlacementStrategy> _placementStrategy = AWSConfigs.InitializeCollections ? new List<PlacementStrategy>() : null;
        private string _platformVersion;
        private PropagateTags _propagateTags;
        private string _service;
        private ServiceConnectConfiguration _serviceConnectConfiguration;
        private List<ServiceRegistry> _serviceRegistries = AWSConfigs.InitializeCollections ? new List<ServiceRegistry>() : null;
        private string _taskDefinition;
        private List<ServiceVolumeConfiguration> _volumeConfigurations = AWSConfigs.InitializeCollections ? new List<ServiceVolumeConfiguration>() : null;
        private List<VpcLatticeConfiguration> _vpcLatticeConfigurations = AWSConfigs.InitializeCollections ? new List<VpcLatticeConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneRebalancing. 
        /// <para>
        /// Indicates whether to use Availability Zone rebalancing for the service.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-rebalancing.html">Balancing
        /// an Amazon ECS service across Availability Zones</a> in the <i> <i>Amazon Elastic Container
        /// Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// </summary>
        public AvailabilityZoneRebalancing AvailabilityZoneRebalancing
        {
            get { return this._availabilityZoneRebalancing; }
            set { this._availabilityZoneRebalancing = value; }
        }

        // Check to see if AvailabilityZoneRebalancing property is set
        internal bool IsSetAvailabilityZoneRebalancing()
        {
            return this._availabilityZoneRebalancing != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The details of a capacity provider strategy. You can set a capacity provider when
        /// you create a cluster, run a task, or update a service.
        /// </para>
        ///  
        /// <para>
        /// When you use Fargate, the capacity providers are <c>FARGATE</c> or <c>FARGATE_SPOT</c>.
        /// </para>
        ///  
        /// <para>
        /// When you use Amazon EC2, the capacity providers are Auto Scaling groups.
        /// </para>
        ///  
        /// <para>
        /// You can change capacity providers for rolling deployments and blue/green deployments.
        /// </para>
        ///  
        /// <para>
        /// The following list provides the valid transitions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Update the Fargate launch type to an Auto Scaling group capacity provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the Amazon EC2 launch type to a Fargate capacity provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the Fargate capacity provider to an Auto Scaling group capacity provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the Amazon EC2 capacity provider to a Fargate capacity provider. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Update the Auto Scaling group or Fargate capacity provider back to the launch type.
        /// </para>
        ///  
        /// <para>
        /// Pass an empty list in the <c>capacityProviderStrategy</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about Amazon Web Services CDK considerations, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/update-service-parameters.html">Amazon
        /// Web Services CDK considerations</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityProviderStrategyItem> CapacityProviderStrategy
        {
            get { return this._capacityProviderStrategy; }
            set { this._capacityProviderStrategy = value; }
        }

        // Check to see if CapacityProviderStrategy property is set
        internal bool IsSetCapacityProviderStrategy()
        {
            return this._capacityProviderStrategy != null && (this._capacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that your service
        /// runs on. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        ///  
        /// <para>
        /// You can't change the cluster name.
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
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
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
        /// The number of instantiations of the task to place and keep running in your service.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// </summary>
        public int? DesiredCount
        {
            get { return this._desiredCount; }
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
        /// Determines whether to turn on Amazon ECS managed tags for the tasks in the service.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only tasks launched after the update will reflect the update. To update the tags on
        /// all tasks, set <c>forceNewDeployment</c> to <c>true</c>, so that Amazon ECS starts
        /// new tasks with the updated tags.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// </summary>
        public bool? EnableECSManagedTags
        {
            get { return this._enableecsManagedTags; }
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
        /// If <c>true</c>, this enables execute command functionality on all task containers.
        /// </para>
        ///  
        /// <para>
        /// If you do not want to override the value that was set when the service was created,
        /// you can set this to <c>null</c> when performing this action.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand
        {
            get { return this._enableExecuteCommand; }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceNewDeployment. 
        /// <para>
        /// Determines whether to force a new deployment of the service. By default, deployments
        /// aren't forced. You can use this option to start a new deployment with no service definition
        /// changes. For example, you can update a service's tasks to use a newer Docker image
        /// with the same image/tag combination (<c>my_image:latest</c>) or to roll Fargate tasks
        /// onto a newer platform version.
        /// </para>
        /// </summary>
        public bool? ForceNewDeployment
        {
            get { return this._forceNewDeployment; }
            set { this._forceNewDeployment = value; }
        }

        // Check to see if ForceNewDeployment property is set
        internal bool IsSetForceNewDeployment()
        {
            return this._forceNewDeployment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// The period of time, in seconds, that the Amazon ECS service scheduler ignores unhealthy
        /// Elastic Load Balancing, VPC Lattice, and container health checks after a task has
        /// first started. If you don't specify a health check grace period value, the default
        /// value of <c>0</c> is used. If you don't use any of the health checks, then <c>healthCheckGracePeriodSeconds</c>
        /// is unused.
        /// </para>
        ///  
        /// <para>
        /// If your service's tasks take a while to start and respond to health checks, you can
        /// specify a health check grace period of up to 2,147,483,647 seconds (about 69 years).
        /// During that time, the Amazon ECS service scheduler ignores health check status. This
        /// grace period can prevent the service scheduler from marking tasks as unhealthy and
        /// stopping them before they have time to come up.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// </summary>
        public int? HealthCheckGracePeriodSeconds
        {
            get { return this._healthCheckGracePeriodSeconds; }
            set { this._healthCheckGracePeriodSeconds = value; }
        }

        // Check to see if HealthCheckGracePeriodSeconds property is set
        internal bool IsSetHealthCheckGracePeriodSeconds()
        {
            return this._healthCheckGracePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancers. <note> 
        /// <para>
        /// You must have a service-linked role when you update this property
        /// </para>
        ///  </note> 
        /// <para>
        /// A list of Elastic Load Balancing load balancer objects. It contains the load balancer
        /// name, the container name, and the container port to access from the load balancer.
        /// The container name is as it appears in a container definition.
        /// </para>
        ///  
        /// <para>
        /// When you add, update, or remove a load balancer configuration, Amazon ECS starts new
        /// tasks with the updated Elastic Load Balancing configuration, and then stops the old
        /// tasks when the new tasks are running.
        /// </para>
        ///  
        /// <para>
        /// For services that use rolling updates, you can add, update, or remove Elastic Load
        /// Balancing target groups. You can update from a single target group to multiple target
        /// groups and from multiple target groups to a single target group.
        /// </para>
        ///  
        /// <para>
        /// For services that use blue/green deployments, you can update Elastic Load Balancing
        /// target groups by using <c> <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
        /// </c> through CodeDeploy. Note that multiple target groups are not supported for blue/green
        /// deployments. For more information see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/register-multiple-targetgroups.html">Register
        /// multiple target groups with a service</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For services that use the external deployment controller, you can add, update, or
        /// remove load balancers by using <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateTaskSet.html">CreateTaskSet</a>.
        /// Note that multiple target groups are not supported for external deployments. For more
        /// information see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/register-multiple-targetgroups.html">Register
        /// multiple target groups with a service</a> in the <i>Amazon Elastic Container Service
        /// Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can remove existing <c>loadBalancers</c> by passing an empty list.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancer> LoadBalancers
        {
            get { return this._loadBalancers; }
            set { this._loadBalancers = value; }
        }

        // Check to see if LoadBalancers property is set
        internal bool IsSetLoadBalancers()
        {
            return this._loadBalancers != null && (this._loadBalancers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// An object representing the network configuration for the service.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
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
        /// An array of task placement constraint objects to update the service to use. If no
        /// value is specified, the existing placement constraints for the service will remain
        /// unchanged. If this value is specified, it will override any existing placement constraints
        /// defined for the service. To remove all existing placement constraints, specify an
        /// empty array.
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of 10 constraints for each task. This limit includes constraints
        /// in the task definition and those specified at runtime.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementConstraint> PlacementConstraints
        {
            get { return this._placementConstraints; }
            set { this._placementConstraints = value; }
        }

        // Check to see if PlacementConstraints property is set
        internal bool IsSetPlacementConstraints()
        {
            return this._placementConstraints != null && (this._placementConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// The task placement strategy objects to update the service to use. If no value is specified,
        /// the existing placement strategy for the service will remain unchanged. If this value
        /// is specified, it will override the existing placement strategy defined for the service.
        /// To remove an existing placement strategy, specify an empty object.
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of five strategy rules for each service.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementStrategy> PlacementStrategy
        {
            get { return this._placementStrategy; }
            set { this._placementStrategy = value; }
        }

        // Check to see if PlacementStrategy property is set
        internal bool IsSetPlacementStrategy()
        {
            return this._placementStrategy != null && (this._placementStrategy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version that your tasks in the service run on. A platform version is
        /// only specified for tasks using the Fargate launch type. If a platform version is not
        /// specified, the <c>LATEST</c> platform version is used. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// Platform Versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
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
        ///  
        /// <para>
        /// Only tasks launched after the update will reflect the update. To update the tags on
        /// all tasks, set <c>forceNewDeployment</c> to <c>true</c>, so that Amazon ECS starts
        /// new tasks with the updated tags.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't trigger a new service deployment.
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
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
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
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
        /// Gets and sets the property ServiceRegistries. <note> 
        /// <para>
        /// You must have a service-linked role when you update this property.
        /// </para>
        ///  
        /// <para>
        /// For more information about the role see the <c>CreateService</c> request parameter
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateService.html#ECS-CreateService-request-role">
        /// <c>role</c> </a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The details for the service discovery registries to assign to this service. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// Discovery</a>.
        /// </para>
        ///  
        /// <para>
        /// When you add, update, or remove the service registries configuration, Amazon ECS starts
        /// new tasks with the updated service registries configuration, and then stops the old
        /// tasks when the new tasks are running.
        /// </para>
        ///  
        /// <para>
        /// You can remove existing <c>serviceRegistries</c> by passing an empty list.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceRegistry> ServiceRegistries
        {
            get { return this._serviceRegistries; }
            set { this._serviceRegistries = value; }
        }

        // Check to see if ServiceRegistries property is set
        internal bool IsSetServiceRegistries()
        {
            return this._serviceRegistries != null && (this._serviceRegistries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <c>family</c> and <c>revision</c> (<c>family:revision</c>) or full ARN of the
        /// task definition to run in your service. If a <c>revision</c> is not specified, the
        /// latest <c>ACTIVE</c> revision is used. If you modify the task definition with <c>UpdateService</c>,
        /// Amazon ECS spawns a task with the new version of the task definition and then stops
        /// an old task after the new version is running.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
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
        /// Gets and sets the property VolumeConfigurations. 
        /// <para>
        /// The details of the volume that was <c>configuredAtLaunch</c>. You can configure the
        /// size, volumeType, IOPS, throughput, snapshot and encryption in <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ServiceManagedEBSVolumeConfiguration.html">ServiceManagedEBSVolumeConfiguration</a>.
        /// The <c>name</c> of the volume must match the <c>name</c> from the task definition.
        /// If set to null, no new deployment is triggered. Otherwise, if this configuration differs
        /// from the existing one, it triggers a new deployment.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceVolumeConfiguration> VolumeConfigurations
        {
            get { return this._volumeConfigurations; }
            set { this._volumeConfigurations = value; }
        }

        // Check to see if VolumeConfigurations property is set
        internal bool IsSetVolumeConfigurations()
        {
            return this._volumeConfigurations != null && (this._volumeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcLatticeConfigurations. 
        /// <para>
        /// An object representing the VPC Lattice configuration for the service being updated.
        /// </para>
        ///  
        /// <para>
        /// This parameter triggers a new service deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcLatticeConfiguration> VpcLatticeConfigurations
        {
            get { return this._vpcLatticeConfigurations; }
            set { this._vpcLatticeConfigurations = value; }
        }

        // Check to see if VpcLatticeConfigurations property is set
        internal bool IsSetVpcLatticeConfigurations()
        {
            return this._vpcLatticeConfigurations != null && (this._vpcLatticeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}