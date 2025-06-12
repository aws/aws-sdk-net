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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private List<AwsEcsServiceCapacityProviderStrategyDetails> _capacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<AwsEcsServiceCapacityProviderStrategyDetails>() : null;
        private string _cluster;
        private AwsEcsServiceDeploymentConfigurationDetails _deploymentConfiguration;
        private AwsEcsServiceDeploymentControllerDetails _deploymentController;
        private int? _desiredCount;
        private bool? _enableEcsManagedTags;
        private bool? _enableExecuteCommand;
        private int? _healthCheckGracePeriodSeconds;
        private string _launchType;
        private List<AwsEcsServiceLoadBalancersDetails> _loadBalancers = AWSConfigs.InitializeCollections ? new List<AwsEcsServiceLoadBalancersDetails>() : null;
        private string _name;
        private AwsEcsServiceNetworkConfigurationDetails _networkConfiguration;
        private List<AwsEcsServicePlacementConstraintsDetails> _placementConstraints = AWSConfigs.InitializeCollections ? new List<AwsEcsServicePlacementConstraintsDetails>() : null;
        private List<AwsEcsServicePlacementStrategiesDetails> _placementStrategies = AWSConfigs.InitializeCollections ? new List<AwsEcsServicePlacementStrategiesDetails>() : null;
        private string _platformVersion;
        private string _propagateTags;
        private string _role;
        private string _schedulingStrategy;
        private string _serviceArn;
        private string _serviceName;
        private List<AwsEcsServiceServiceRegistriesDetails> _serviceRegistries = AWSConfigs.InitializeCollections ? new List<AwsEcsServiceServiceRegistriesDetails>() : null;
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy that the service uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServiceCapacityProviderStrategyDetails> CapacityProviderStrategy
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
        /// The ARN of the cluster that hosts the service.
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
        /// Deployment parameters for the service. Includes the number of tasks that run and the
        /// order in which to start and stop tasks.
        /// </para>
        /// </summary>
        public AwsEcsServiceDeploymentConfigurationDetails DeploymentConfiguration
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
        /// Contains the deployment controller type that the service uses.
        /// </para>
        /// </summary>
        public AwsEcsServiceDeploymentControllerDetails DeploymentController
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
        /// The number of instantiations of the task definition to run on the service.
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
        /// Gets and sets the property EnableEcsManagedTags. 
        /// <para>
        /// Whether to enable Amazon ECS managed tags for the tasks in the service.
        /// </para>
        /// </summary>
        public bool? EnableEcsManagedTags
        {
            get { return this._enableEcsManagedTags; }
            set { this._enableEcsManagedTags = value; }
        }

        // Check to see if EnableEcsManagedTags property is set
        internal bool IsSetEnableEcsManagedTags()
        {
            return this._enableEcsManagedTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Whether the execute command functionality is enabled for the service.
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
        /// Gets and sets the property HealthCheckGracePeriodSeconds. 
        /// <para>
        /// After a task starts, the amount of time in seconds that the Amazon ECS service scheduler
        /// ignores unhealthy Elastic Load Balancing target health checks.
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
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type that the service uses.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>EC2</c> | <c>FARGATE</c> | <c>EXTERNAL</c> 
        /// </para>
        /// </summary>
        public string LaunchType
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
        /// Information about the load balancers that the service uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServiceLoadBalancersDetails> LoadBalancers
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// For tasks that use the <c>awsvpc</c> networking mode, the VPC subnet and security
        /// group configuration.
        /// </para>
        /// </summary>
        public AwsEcsServiceNetworkConfigurationDetails NetworkConfiguration
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
        /// The placement constraints for the tasks in the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServicePlacementConstraintsDetails> PlacementConstraints
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
        /// Gets and sets the property PlacementStrategies. 
        /// <para>
        /// Information about how tasks for the service are placed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServicePlacementStrategiesDetails> PlacementStrategies
        {
            get { return this._placementStrategies; }
            set { this._placementStrategies = value; }
        }

        // Check to see if PlacementStrategies property is set
        internal bool IsSetPlacementStrategies()
        {
            return this._placementStrategies != null && (this._placementStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version on which to run the service. Only specified for tasks that are
        /// hosted on Fargate. If a platform version is not specified, the <c>LATEST</c> platform
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
        public string PropagateTags
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
        /// The ARN of the IAM role that is associated with the service. The role allows the Amazon
        /// ECS container agent to register container instances with an Elastic Load Balancing
        /// load balancer.
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
        public string SchedulingStrategy
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
        /// The ARN of the service.
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
        /// The name of the service.
        /// </para>
        ///  
        /// <para>
        /// The name can contain up to 255 characters. It can use letters, numbers, underscores,
        /// and hyphens.
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
        /// Information about the service discovery registries to assign to the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsServiceServiceRegistriesDetails> ServiceRegistries
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
        /// The task definition to use for tasks in the service.
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