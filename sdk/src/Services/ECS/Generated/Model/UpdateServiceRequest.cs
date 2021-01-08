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
    /// Container for the parameters to the UpdateService operation.
    /// <important> 
    /// <para>
    /// Updating the task placement strategies and constraints on an Amazon ECS service remains
    /// in preview and is a Beta Service as defined by and subject to the Beta Service Participation
    /// Service Terms located at <a href="https://aws.amazon.com/service-terms">https://aws.amazon.com/service-terms</a>
    /// ("Beta Terms"). These Beta Terms apply to your participation in this preview.
    /// </para>
    ///  </important> 
    /// <para>
    /// Modifies the parameters of a service.
    /// </para>
    ///  
    /// <para>
    /// For services using the rolling update (<code>ECS</code>) deployment controller, the
    /// desired count, deployment configuration, network configuration, task placement constraints
    /// and strategies, or task definition used can be updated.
    /// </para>
    ///  
    /// <para>
    /// For services using the blue/green (<code>CODE_DEPLOY</code>) deployment controller,
    /// only the desired count, deployment configuration, task placement constraints and strategies,
    /// and health check grace period can be updated using this API. If the network configuration,
    /// platform version, or task definition need to be updated, a new AWS CodeDeploy deployment
    /// should be created. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/APIReference/API_CreateDeployment.html">CreateDeployment</a>
    /// in the <i>AWS CodeDeploy API Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// For services using an external deployment controller, you can update only the desired
    /// count, task placement constraints and strategies, and health check grace period using
    /// this API. If the launch type, load balancer, network configuration, platform version,
    /// or task definition need to be updated, you should create a new task set. For more
    /// information, see <a>CreateTaskSet</a>.
    /// </para>
    ///  
    /// <para>
    /// You can add to or subtract from the number of instantiations of a task definition
    /// in a service by specifying the cluster that the service is running in and a new <code>desiredCount</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// If you have updated the Docker image of your application, you can create a new task
    /// definition with that image and deploy it to your service. The service scheduler uses
    /// the minimum healthy percent and maximum percent parameters (in the service's deployment
    /// configuration) to determine the deployment strategy.
    /// </para>
    ///  <note> 
    /// <para>
    /// If your updated Docker image uses the same tag as what is in the existing task definition
    /// for your service (for example, <code>my_image:latest</code>), you do not need to create
    /// a new revision of your task definition. You can update the service using the <code>forceNewDeployment</code>
    /// option. The new tasks launched by the deployment pull the current image/tag combination
    /// from your repository when they start.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can also update the deployment configuration of a service. When a deployment is
    /// triggered by updating the task definition of a service, the service scheduler uses
    /// the deployment configuration parameters, <code>minimumHealthyPercent</code> and <code>maximumPercent</code>,
    /// to determine the deployment strategy.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If <code>minimumHealthyPercent</code> is below 100%, the scheduler can ignore <code>desiredCount</code>
    /// temporarily during a deployment. For example, if <code>desiredCount</code> is four
    /// tasks, a minimum of 50% allows the scheduler to stop two existing tasks before starting
    /// two new tasks. Tasks for services that do not use a load balancer are considered healthy
    /// if they are in the <code>RUNNING</code> state. Tasks for services that use a load
    /// balancer are considered healthy if they are in the <code>RUNNING</code> state and
    /// the container instance they are hosted on is reported as healthy by the load balancer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>maximumPercent</code> parameter represents an upper limit on the number
    /// of running tasks during a deployment, which enables you to define the deployment batch
    /// size. For example, if <code>desiredCount</code> is four tasks, a maximum of 200% starts
    /// four new tasks before stopping the four older tasks (provided that the cluster resources
    /// required to do this are available).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When <a>UpdateService</a> stops a task during a deployment, the equivalent of <code>docker
    /// stop</code> is issued to the containers running in the task. This results in a <code>SIGTERM</code>
    /// and a 30-second timeout, after which <code>SIGKILL</code> is sent and the containers
    /// are forcibly stopped. If the container handles the <code>SIGTERM</code> gracefully
    /// and exits within 30 seconds from receiving it, no <code>SIGKILL</code> is sent.
    /// </para>
    ///  
    /// <para>
    /// When the service scheduler launches new tasks, it determines task placement in your
    /// cluster with the following logic:
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
    /// in this manner (although you can choose a different placement strategy):
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
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private string _cluster;
        private DeploymentConfiguration _deploymentConfiguration;
        private int? _desiredCount;
        private bool? _forceNewDeployment;
        private int? _healthCheckGracePeriodSeconds;
        private NetworkConfiguration _networkConfiguration;
        private List<PlacementConstraint> _placementConstraints = new List<PlacementConstraint>();
        private List<PlacementStrategy> _placementStrategy = new List<PlacementStrategy>();
        private string _platformVersion;
        private string _service;
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy to update the service to use.
        /// </para>
        ///  
        /// <para>
        /// If the service is using the default capacity provider strategy for the cluster, the
        /// service can be updated to use one or more capacity providers as opposed to the default
        /// capacity provider strategy. However, when a service is using a capacity provider strategy
        /// that is not the default capacity provider strategy, the service cannot be updated
        /// to use the cluster's default capacity provider strategy.
        /// </para>
        ///  
        /// <para>
        /// A capacity provider strategy consists of one or more capacity providers along with
        /// the <code>base</code> and <code>weight</code> to assign to them. A capacity provider
        /// must be associated with the cluster to be used in a capacity provider strategy. The
        /// <a>PutClusterCapacityProviders</a> API is used to associate a capacity provider with
        /// a cluster. Only capacity providers with an <code>ACTIVE</code> or <code>UPDATING</code>
        /// status can be used.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must already be created. New capacity providers can be created with the <a>CreateCapacityProvider</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// To use a AWS Fargate capacity provider, specify either the <code>FARGATE</code> or
        /// <code>FARGATE_SPOT</code> capacity providers. The AWS Fargate capacity providers are
        /// available to all accounts and only need to be associated with a cluster to be used.
        /// </para>
        ///  
        /// <para>
        /// The <a>PutClusterCapacityProviders</a> API operation is used to update the list of
        /// available capacity providers for a cluster after the cluster is created.
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
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that your service
        /// is running on. If you do not specify a cluster, the default cluster is assumed.
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
        /// The number of instantiations of the task to place and keep running in your service.
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
        /// Gets and sets the property ForceNewDeployment. 
        /// <para>
        /// Whether to force a new deployment of the service. Deployments are not forced by default.
        /// You can use this option to trigger a new deployment with no service definition changes.
        /// For example, you can update a service's tasks to use a newer Docker image with the
        /// same image/tag combination (<code>my_image:latest</code>) or to roll Fargate tasks
        /// onto a newer platform version.
        /// </para>
        /// </summary>
        public bool ForceNewDeployment
        {
            get { return this._forceNewDeployment.GetValueOrDefault(); }
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
        /// The period of time, in seconds, that the Amazon ECS service scheduler should ignore
        /// unhealthy Elastic Load Balancing target health checks after a task has first started.
        /// This is only valid if your service is configured to use a load balancer. If your service's
        /// tasks take a while to start and respond to Elastic Load Balancing health checks, you
        /// can specify a health check grace period of up to 2,147,483,647 seconds. During that
        /// time, the Amazon ECS service scheduler ignores the Elastic Load Balancing health check
        /// status. This grace period can prevent the ECS service scheduler from marking tasks
        /// as unhealthy and stopping them before they have time to come up.
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
        /// Gets and sets the property NetworkConfiguration.
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
        /// You can specify a maximum of 10 constraints per task (this limit includes constraints
        /// in the task definition and those specified at runtime).
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
        /// The task placement strategy objects to update the service to use. If no value is specified,
        /// the existing placement strategy for the service will remain unchanged. If this value
        /// is specified, it will override the existing placement strategy defined for the service.
        /// To remove an existing placement strategy, specify an empty object.
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of five strategy rules per service.
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
        /// is only specified for tasks using the Fargate launch type. If a platform version is
        /// not specified, the <code>LATEST</code> platform version is used by default. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full ARN of the task definition to run in your service. If a <code>revision</code>
        /// is not specified, the latest <code>ACTIVE</code> revision is used. If you modify the
        /// task definition with <code>UpdateService</code>, Amazon ECS spawns a task with the
        /// new version of the task definition and then stops an old task after the new version
        /// is running.
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