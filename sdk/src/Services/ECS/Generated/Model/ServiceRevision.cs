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
    /// Information about the service revision.
    /// 
    ///  
    /// <para>
    /// A service revision contains a record of the workload configuration Amazon ECS is attempting
    /// to deploy. Whenever you create or deploy a service, Amazon ECS automatically creates
    /// and captures the configuration that you're trying to deploy in the service revision.
    /// For information about service revisions, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-revision.html">Amazon
    /// ECS service revisions</a> in the <i> <i>Amazon Elastic Container Service Developer
    /// Guide</i> </i>.
    /// </para>
    /// </summary>
    public partial class ServiceRevision
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;
        private string _clusterArn;
        private List<ContainerImage> _containerImages = AWSConfigs.InitializeCollections ? new List<ContainerImage>() : null;
        private DateTime? _createdAt;
        private DeploymentEphemeralStorage _fargateEphemeralStorage;
        private bool? _guardDutyEnabled;
        private LaunchType _launchType;
        private List<LoadBalancer> _loadBalancers = AWSConfigs.InitializeCollections ? new List<LoadBalancer>() : null;
        private NetworkConfiguration _networkConfiguration;
        private string _platformFamily;
        private string _platformVersion;
        private ResolvedConfiguration _resolvedConfiguration;
        private string _serviceArn;
        private ServiceConnectConfiguration _serviceConnectConfiguration;
        private List<ServiceRegistry> _serviceRegistries = AWSConfigs.InitializeCollections ? new List<ServiceRegistry>() : null;
        private string _serviceRevisionArn;
        private string _taskDefinition;
        private List<ServiceVolumeConfiguration> _volumeConfigurations = AWSConfigs.InitializeCollections ? new List<ServiceVolumeConfiguration>() : null;
        private List<VpcLatticeConfiguration> _vpcLatticeConfigurations = AWSConfigs.InitializeCollections ? new List<VpcLatticeConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy the service revision uses.
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
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN of the cluster that hosts the service.
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
        /// Gets and sets the property ContainerImages. 
        /// <para>
        /// The container images the service revision uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerImage> ContainerImages
        {
            get { return this._containerImages; }
            set { this._containerImages = value; }
        }

        // Check to see if ContainerImages property is set
        internal bool IsSetContainerImages()
        {
            return this._containerImages != null && (this._containerImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the service revision was created. The format is yyyy-mm-dd HH:mm:ss.SSSSS.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FargateEphemeralStorage.
        /// </summary>
        public DeploymentEphemeralStorage FargateEphemeralStorage
        {
            get { return this._fargateEphemeralStorage; }
            set { this._fargateEphemeralStorage = value; }
        }

        // Check to see if FargateEphemeralStorage property is set
        internal bool IsSetFargateEphemeralStorage()
        {
            return this._fargateEphemeralStorage != null;
        }

        /// <summary>
        /// Gets and sets the property GuardDutyEnabled. 
        /// <para>
        /// Indicates whether Runtime Monitoring is turned on.
        /// </para>
        /// </summary>
        public bool? GuardDutyEnabled
        {
            get { return this._guardDutyEnabled; }
            set { this._guardDutyEnabled = value; }
        }

        // Check to see if GuardDutyEnabled property is set
        internal bool IsSetGuardDutyEnabled()
        {
            return this._guardDutyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the service revision uses.
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
        /// The load balancers the service revision uses.
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
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The platform family the service revision uses.
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
        /// For the Fargate launch type, the platform version the service revision uses.
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
        /// Gets and sets the property ResolvedConfiguration. 
        /// <para>
        /// The resolved configuration for the service revision which contains the actual resources
        /// your service revision uses, such as which target groups serve traffic.
        /// </para>
        /// </summary>
        public ResolvedConfiguration ResolvedConfiguration
        {
            get { return this._resolvedConfiguration; }
            set { this._resolvedConfiguration = value; }
        }

        // Check to see if ResolvedConfiguration property is set
        internal bool IsSetResolvedConfiguration()
        {
            return this._resolvedConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service for the service revision.
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
        /// Gets and sets the property ServiceConnectConfiguration.
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
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The service registries (for Service Discovery) the service revision uses.
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
        /// Gets and sets the property ServiceRevisionArn. 
        /// <para>
        /// The ARN of the service revision.
        /// </para>
        /// </summary>
        public string ServiceRevisionArn
        {
            get { return this._serviceRevisionArn; }
            set { this._serviceRevisionArn = value; }
        }

        // Check to see if ServiceRevisionArn property is set
        internal bool IsSetServiceRevisionArn()
        {
            return this._serviceRevisionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition the service revision uses.
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
        /// The volumes that are configured at deployment that the service revision uses.
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
        /// The VPC Lattice configuration for the service revision.
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