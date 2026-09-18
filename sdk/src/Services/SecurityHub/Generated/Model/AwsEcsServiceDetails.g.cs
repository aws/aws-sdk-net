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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a service within an ECS cluster.
    /// </summary>
    public partial class AwsEcsServiceDetails
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy that the service uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServiceCapacityProviderStrategyDetails> CapacityProviderStrategy { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsServiceCapacityProviderStrategyDetails>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviderStrategy property is set.
        /// </summary>
        internal bool IsSetCapacityProviderStrategy() => this.CapacityProviderStrategy != null && (this.CapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The ARN of the cluster that hosts the service.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Deployment parameters for the service. Includes the number of tasks that run and the
        /// order in which to start and stop tasks.
        /// </para>
        /// </summary>
        public AwsEcsServiceDeploymentConfigurationDetails DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeploymentController. 
        /// <para>
        /// Contains the deployment controller type that the service uses.
        /// </para>
        /// </summary>
        public AwsEcsServiceDeploymentControllerDetails DeploymentController { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentController property is set.
        /// </summary>
        internal bool IsSetDeploymentController() => this.DeploymentController != null;

        /// <summary>
        /// Gets and sets the property DesiredCount. 
        /// <para>
        /// The number of instantiations of the task definition to run on the service.
        /// </para>
        /// </summary>
        public int? DesiredCount { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCount property is set.
        /// </summary>
        internal bool IsSetDesiredCount() => this.DesiredCount.HasValue;

        /// <summary>
        /// Gets and sets the property EnableEcsManagedTags. 
        /// <para>
        /// Whether to enable Amazon ECS managed tags for the tasks in the service.
        /// </para>
        /// </summary>
        public bool? EnableEcsManagedTags { get; set; }

        /// <summary>
        /// Checks to see if the EnableEcsManagedTags property is set.
        /// </summary>
        internal bool IsSetEnableEcsManagedTags() => this.EnableEcsManagedTags.HasValue;

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Whether the execute command functionality is enabled for the service.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand { get; set; }

        /// <summary>
        /// Checks to see if the EnableExecuteCommand property is set.
        /// </summary>
        internal bool IsSetEnableExecuteCommand() => this.EnableExecuteCommand.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// After a task starts, the amount of time in seconds that the Amazon ECS service scheduler
        /// ignores unhealthy Elastic Load Balancing target health checks.
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
        /// The launch type that the service uses.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>EC2</c> | <c>FARGATE</c> | <c>EXTERNAL</c> 
        /// </para>
        /// </summary>
        public string LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property LoadBalancers. 
        /// <para>
        /// Information about the load balancers that the service uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServiceLoadBalancersDetails> LoadBalancers { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsServiceLoadBalancersDetails>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancers property is set.
        /// </summary>
        internal bool IsSetLoadBalancers() => this.LoadBalancers != null && (this.LoadBalancers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// For tasks that use the <c>awsvpc</c> networking mode, the VPC subnet and security
        /// group configuration.
        /// </para>
        /// </summary>
        public AwsEcsServiceNetworkConfigurationDetails NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

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
        public List<AwsEcsServicePlacementConstraintsDetails> PlacementConstraints { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsServicePlacementConstraintsDetails>() : null;

        /// <summary>
        /// Checks to see if the PlacementConstraints property is set.
        /// </summary>
        internal bool IsSetPlacementConstraints() => this.PlacementConstraints != null && (this.PlacementConstraints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlacementStrategies. 
        /// <para>
        /// Information about how tasks for the service are placed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServicePlacementStrategiesDetails> PlacementStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsServicePlacementStrategiesDetails>() : null;

        /// <summary>
        /// Checks to see if the PlacementStrategies property is set.
        /// </summary>
        internal bool IsSetPlacementStrategies() => this.PlacementStrategies != null && (this.PlacementStrategies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version on which to run the service. Only specified for tasks that are
        /// hosted on Fargate. If a platform version is not specified, the <c>LATEST</c> platform
        /// version is used by default.
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
        /// Indicates whether to propagate the tags from the task definition to the task or from
        /// the service to the task. If no value is provided, then tags are not propagated.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>TASK_DEFINITION</c> | <c>SERVICE</c> 
        /// </para>
        /// </summary>
        public string PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the IAM role that is associated with the service. The role allows the Amazon
        /// ECS container agent to register container instances with an Elastic Load Balancing
        /// load balancer.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SchedulingStrategy. 
        /// <para>
        /// The scheduling strategy to use for the service.
        /// </para>
        ///  
        /// <para>
        /// The <c>REPLICA</c> scheduling strategy places and maintains the desired number of
        /// tasks across the cluster. By default, the service scheduler spreads tasks across Availability
        /// Zones. Task placement strategies and constraints are used to customize task placement
        /// decisions.
        /// </para>
        ///  
        /// <para>
        /// The <c>DAEMON</c> scheduling strategy deploys exactly one task on each active container
        /// instance that meets all of the task placement constraints that are specified in the
        /// cluster. The service scheduler also evaluates the task placement constraints for running
        /// tasks and stops tasks that don't meet the placement constraints.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>REPLICA</c> | <c>DAEMON</c> 
        /// </para>
        /// </summary>
        public string SchedulingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingStrategy property is set.
        /// </summary>
        internal bool IsSetSchedulingStrategy() => this.SchedulingStrategy != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service.
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
        /// The name of the service.
        /// </para>
        ///  
        /// <para>
        /// The name can contain up to 255 characters. It can use letters, numbers, underscores,
        /// and hyphens.
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
        /// Information about the service discovery registries to assign to the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServiceServiceRegistriesDetails> ServiceRegistries { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsServiceServiceRegistriesDetails>() : null;

        /// <summary>
        /// Checks to see if the ServiceRegistries property is set.
        /// </summary>
        internal bool IsSetServiceRegistries() => this.ServiceRegistries != null && (this.ServiceRegistries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition to use for tasks in the service.
        /// </para>
        /// </summary>
        public string TaskDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinition property is set.
        /// </summary>
        internal bool IsSetTaskDefinition() => this.TaskDefinition != null;
    }
}
