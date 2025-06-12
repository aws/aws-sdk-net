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
    /// Container for the parameters to the CreateTaskSet operation.
    /// Create a task set in the specified cluster and service. This is used when a service
    /// uses the <c>EXTERNAL</c> deployment controller type. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-types.html">Amazon
    /// ECS deployment types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// On March 21, 2024, a change was made to resolve the task definition revision before
    /// authorization. When a task definition revision is not specified, authorization will
    /// occur using the latest revision of a task definition.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about the maximum number of task sets and other quotas, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-quotas.html">Amazon
    /// ECS service quotas</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateTaskSetRequest : AmazonECSRequest
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;
        private string _clientToken;
        private string _cluster;
        private string _externalId;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = AWSConfigs.InitializeCollections ? new List<LoadBalancer>() : null;
        private NetworkConfiguration _networkConfiguration;
        private string _platformVersion;
        private Scale _scale;
        private string _service;
        private List<ServiceRegistry> _serviceRegistries = AWSConfigs.InitializeCollections ? new List<ServiceRegistry>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy to use for the task set.
        /// </para>
        ///  
        /// <para>
        /// A capacity provider strategy consists of one or more capacity providers along with
        /// the <c>base</c> and <c>weight</c> to assign to them. A capacity provider must be associated
        /// with the cluster to be used in a capacity provider strategy. The <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
        /// API is used to associate a capacity provider with a cluster. Only capacity providers
        /// with an <c>ACTIVE</c> or <c>UPDATING</c> status can be used.
        /// </para>
        ///  
        /// <para>
        /// If a <c>capacityProviderStrategy</c> is specified, the <c>launchType</c> parameter
        /// must be omitted. If no <c>capacityProviderStrategy</c> or <c>launchType</c> is specified,
        /// the <c>defaultCapacityProviderStrategy</c> for the cluster is used.
        /// </para>
        ///  
        /// <para>
        /// If specifying a capacity provider that uses an Auto Scaling group, the capacity provider
        /// must already be created. New capacity providers can be created with the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_CreateCapacityProviderProvider.html">CreateCapacityProviderProvider</a>API
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To use a Fargate capacity provider, specify either the <c>FARGATE</c> or <c>FARGATE_SPOT</c>
        /// capacity providers. The Fargate capacity providers are available to all accounts and
        /// only need to be associated with a cluster to be used.
        /// </para>
        ///  
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutClusterCapacityProviders.html">PutClusterCapacityProviders</a>
        /// API operation is used to update the list of available capacity providers for a cluster
        /// after the cluster is created.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An identifier that you provide to ensure the idempotency of the request. It must be
        /// unique and is case sensitive. Up to 36 ASCII characters in the range of 33-126 (inclusive)
        /// are allowed.
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
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the service
        /// to create the task set in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// An optional non-unique tag that identifies this task set in external systems. If the
        /// task set is associated with a service discovery registry, the tasks in this task set
        /// will have the <c>ECS_TASK_SET_EXTERNAL_ID</c> Cloud Map attribute set to the provided
        /// value.
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
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type that new tasks in the task set uses. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If a <c>launchType</c> is specified, the <c>capacityProviderStrategy</c> parameter
        /// must be omitted.
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
        /// A load balancer object representing the load balancer to use with the task set. The
        /// supported load balancer types are either an Application Load Balancer or a Network
        /// Load Balancer.
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
        /// An object representing the network configuration for a task set.
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
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version that the tasks in the task set uses. A platform version is specified
        /// only for tasks using the Fargate launch type. If one isn't specified, the <c>LATEST</c>
        /// platform version is used.
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
        /// Gets and sets the property Scale. 
        /// <para>
        /// A floating-point percentage of the desired number of tasks to place and keep running
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the service to create the task
        /// set in.
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
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The details of the service discovery registries to assign to this task set. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-discovery.html">Service
        /// discovery</a>.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task set to help you categorize and organize them.
        /// Each tag consists of a key and an optional value. You define both. When a service
        /// is deleted, the tags are deleted.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition for the tasks in the task set to use. If a revision isn't specified,
        /// the latest <c>ACTIVE</c> revision is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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