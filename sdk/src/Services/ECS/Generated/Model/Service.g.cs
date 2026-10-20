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
    /// Details on a service within a cluster.
    /// </summary>
    public partial class Service
    {
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
        /// The default behavior of <c>AvailabilityZoneRebalancing</c> differs between create
        /// and update requests:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For create service requests, when no value is specified for <c>AvailabilityZoneRebalancing</c>,
        /// Amazon ECS defaults the value to <c>ENABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For update service requests, when no value is specified for <c>AvailabilityZoneRebalancing</c>,
        /// Amazon ECS defaults to the existing service’s <c>AvailabilityZoneRebalancing</c> value.
        /// If the service never had an <c>AvailabilityZoneRebalancing</c> value set, Amazon ECS
        /// treats this as <c>DISABLED</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AvailabilityZoneRebalancing AvailabilityZoneRebalancing { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneRebalancing property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneRebalancing() => this.AvailabilityZoneRebalancing != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy the service uses. When using the DescribeServices API,
        /// this field is omitted if the service was created using a launch type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityProviderStrategyItem> CapacityProviderStrategy { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviderStrategy property is set.
        /// </summary>
        internal bool IsSetCapacityProviderStrategy() => this.CapacityProviderStrategy != null && (this.CapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster that hosts the service.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the service was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The principal that created the service.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CurrentServiceDeployment. 
        /// <para>
        /// The ARN of the current service deployment.
        /// </para>
        /// </summary>
        public string CurrentServiceDeployment { get; set; }

        /// <summary>
        /// Checks to see if the CurrentServiceDeployment property is set.
        /// </summary>
        internal bool IsSetCurrentServiceDeployment() => this.CurrentServiceDeployment != null;

        /// <summary>
        /// Gets and sets the property CurrentServiceRevisions. 
        /// <para>
        /// The list of the service revisions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceCurrentRevisionSummary> CurrentServiceRevisions { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceCurrentRevisionSummary>() : null;

        /// <summary>
        /// Checks to see if the CurrentServiceRevisions property is set.
        /// </summary>
        internal bool IsSetCurrentServiceRevisions() => this.CurrentServiceRevisions != null && (this.CurrentServiceRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Optional deployment parameters that control how many tasks run during the deployment
        /// and the ordering of stopping and starting tasks.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeploymentController. 
        /// <para>
        /// The deployment controller type the service is using. 
        /// </para>
        /// </summary>
        public DeploymentController DeploymentController { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentController property is set.
        /// </summary>
        internal bool IsSetDeploymentController() => this.DeploymentController != null;

        /// <summary>
        /// Gets and sets the property Deployments. 
        /// <para>
        /// The current state of deployments for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Deployment> Deployments { get; set; } = AWSConfigs.InitializeCollections ? new List<Deployment>() : null;

        /// <summary>
        /// Checks to see if the Deployments property is set.
        /// </summary>
        internal bool IsSetDeployments() => this.Deployments != null && (this.Deployments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The desired number of instantiations of the task definition to keep running on the
        /// service. This value is specified when the service is created with <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateService.html">CreateService</a>
        /// , and it can be modified with <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateService.html">UpdateService</a>.
        /// </para>
        /// </summary>
        public int? DesiredCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCount property is set.
        /// </summary>
        internal bool IsSetDesiredCount() => this.DesiredCount.HasValue;

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Determines whether to use Amazon ECS managed tags for the tasks in the service. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableECSManagedTags { get; set; }

        /// <summary>
        /// Checks to see if the EnableECSManagedTags property is set.
        /// </summary>
        internal bool IsSetEnableECSManagedTags() => this.EnableECSManagedTags.HasValue;

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether the execute command functionality is turned on for the service.
        /// If <c>true</c>, the execute command functionality is turned on for all containers
        /// in tasks as part of the service.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand { get; set; }

        /// <summary>
        /// Checks to see if the EnableExecuteCommand property is set.
        /// </summary>
        internal bool IsSetEnableExecuteCommand() => this.EnableExecuteCommand.HasValue;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The event stream for your service. A maximum of 100 of the latest events are displayed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceEvent> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceEvent>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// The period of time, in seconds, that the Amazon ECS service scheduler ignores unhealthy
        /// Elastic Load Balancing, VPC Lattice, and container health checks after a task has
        /// first started.
        /// </para>
        ///  
        /// <para>
        /// If your service has more running tasks than desired, unhealthy tasks in the grace
        /// period might be stopped to reach the desired count.
        /// </para>
        /// </summary>
        public int? HealthCheckGracePeriodSeconds { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckGracePeriodSeconds property is set.
        /// </summary>
        internal bool IsSetHealthCheckGracePeriodSeconds() => this.HealthCheckGracePeriodSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the service is using. When using the DescribeServices API, this field
        /// is omitted if the service was created using a capacity provider strategy.
        /// </para>
        /// </summary>
        public LaunchType LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// A list of Elastic Load Balancing load balancer objects. It contains the load balancer
        /// name, the container name, and the container port to access from the load balancer.
        /// The container name is as it appears in a container definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancer> LoadBalancers { get; set; } = AWSConfigs.InitializeCollections ? new List<LoadBalancer>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancers property is set.
        /// </summary>
        internal bool IsSetLoadBalancers() => this.LoadBalancers != null && (this.LoadBalancers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The VPC subnet and security group configuration for tasks that receive their own elastic
        /// network interface by using the <c>awsvpc</c> networking mode.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PendingCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <c>PENDING</c> state.
        /// </para>
        /// </summary>
        public int? PendingCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingCount property is set.
        /// </summary>
        internal bool IsSetPendingCount() => this.PendingCount.HasValue;

        /// <summary>
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// The placement constraints for the tasks in the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementConstraint> PlacementConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<PlacementConstraint>() : null;

        /// <summary>
        /// Checks to see if the PlacementConstraints property is set.
        /// </summary>
        internal bool IsSetPlacementConstraints() => this.PlacementConstraints != null && (this.PlacementConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// The placement strategy that determines how tasks for the service are placed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementStrategy> PlacementStrategy { get; set; } = AWSConfigs.InitializeCollections ? new List<PlacementStrategy>() : null;

        /// <summary>
        /// Checks to see if the PlacementStrategy property is set.
        /// </summary>
        internal bool IsSetPlacementStrategy() => this.PlacementStrategy != null && (this.PlacementStrategy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The operating system that your tasks in the service run on. A platform family is specified
        /// only for tasks using the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks that run as part of this service must use the same <c>platformFamily</c>
        /// value as the service (for example, <c>LINUX</c>).
        /// </para>
        /// </summary>
        public string PlatformFamily { get; set; }

        /// <summary>
        /// Checks to see if the PlatformFamily property is set.
        /// </summary>
        internal bool IsSetPlatformFamily() => this.PlatformFamily != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version to run your service on. A platform version is only specified
        /// for tasks that are hosted on Fargate. If one isn't specified, the <c>LATEST</c> platform
        /// version is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// Platform Versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Determines whether to propagate the tags from the task definition or the service to
        /// the task. If no value is specified, the tags aren't propagated.
        /// </para>
        /// </summary>
        public PropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property ResourceManagementType. 
        /// <para>
        /// Identifies whether an ECS Service is an Express Service managed by ECS, or managed
        /// by the customer. The valid values are <c>ECS</c> and <c>CUSTOMER</c> 
        /// </para>
        /// </summary>
        public ResourceManagementType ResourceManagementType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceManagementType property is set.
        /// </summary>
        internal bool IsSetResourceManagementType() => this.ResourceManagementType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that's associated with the service. It allows the Amazon ECS
        /// container agent to register container instances with an Elastic Load Balancing load
        /// balancer.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RunningCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <c>RUNNING</c> state.
        /// </para>
        /// </summary>
        public int? RunningCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningCount property is set.
        /// </summary>
        internal bool IsSetRunningCount() => this.RunningCount.HasValue;

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
        ///  <c>REPLICA</c>-The replica scheduling strategy places and maintains the desired number
        /// of tasks across your cluster. By default, the service scheduler spreads tasks across
        /// Availability Zones. You can use task placement strategies and constraints to customize
        /// task placement decisions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DAEMON</c>-The daemon scheduling strategy deploys exactly one task on each active
        /// container instance. This task meets all of the task placement constraints that you
        /// specify in your cluster. The service scheduler also evaluates the task placement constraints
        /// for running tasks. It stop tasks that don't meet the placement constraints.
        /// </para>
        ///  <note> 
        /// <para>
        /// Fargate tasks don't support the <c>DAEMON</c> scheduling strategy.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public SchedulingStrategy SchedulingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingStrategy property is set.
        /// </summary>
        internal bool IsSetSchedulingStrategy() => this.SchedulingStrategy != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN that identifies the service. For more information about the ARN format, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#ecs-resource-ids">Amazon
        /// Resource Name (ARN)</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of your service. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed. Service names must be unique within a cluster. However, you
        /// can have similarly named services in multiple clusters within a Region or across multiple
        /// Regions.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The details for the service discovery registries to assign to this service. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// Discovery</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceRegistry> ServiceRegistries { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceRegistry>() : null;

        /// <summary>
        /// Checks to see if the ServiceRegistries property is set.
        /// </summary>
        internal bool IsSetServiceRegistries() => this.ServiceRegistries != null && (this.ServiceRegistries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the service. The valid values are <c>ACTIVE</c>, <c>DRAINING</c>, or
        /// <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition to use for tasks in the service. This value is specified when
        /// the service is created with <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateService.html">CreateService</a>,
        /// and it can be modified with <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateService.html">UpdateService</a>.
        /// </para>
        /// </summary>
        public string TaskDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinition property is set.
        /// </summary>
        internal bool IsSetTaskDefinition() => this.TaskDefinition != null;

        /// <summary>
        /// Gets and sets the property TaskSets. 
        /// <para>
        /// Information about a set of Amazon ECS tasks in either an CodeDeploy or an <c>EXTERNAL</c>
        /// deployment. An Amazon ECS task set includes details such as the desired number of
        /// tasks, how many tasks are running, and whether the task set serves production traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskSet> TaskSets { get; set; } = AWSConfigs.InitializeCollections ? new List<TaskSet>() : null;

        /// <summary>
        /// Checks to see if the TaskSets property is set.
        /// </summary>
        internal bool IsSetTaskSets() => this.TaskSets != null && (this.TaskSets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
