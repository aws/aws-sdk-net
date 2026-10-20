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
        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy the service revision uses.
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
        /// The ARN of the cluster that hosts the service.
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ContainerImages. 
        /// <para>
        /// The container images the service revision uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerImage> ContainerImages { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerImage>() : null;

        /// <summary>
        /// Checks to see if the ContainerImages property is set.
        /// </summary>
        internal bool IsSetContainerImages() => this.ContainerImages != null && (this.ContainerImages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the service revision was created. The format is yyyy-mm-dd HH:mm:ss.SSSSS.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EcsManagedResources. 
        /// <para>
        /// The resources created and managed by Amazon ECS when you create an Express service
        /// for Amazon ECS.
        /// </para>
        /// </summary>
        public ECSManagedResources EcsManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the EcsManagedResources property is set.
        /// </summary>
        internal bool IsSetEcsManagedResources() => this.EcsManagedResources != null;

        /// <summary>
        /// Gets and sets the property FargateEphemeralStorage.
        /// </summary>
        public DeploymentEphemeralStorage FargateEphemeralStorage { get; set; }

        /// <summary>
        /// Checks to see if the FargateEphemeralStorage property is set.
        /// </summary>
        internal bool IsSetFargateEphemeralStorage() => this.FargateEphemeralStorage != null;

        /// <summary>
        /// Gets and sets the property GatewayConnectors. 
        /// <para>
        /// The gateway connectors that are associated with the service revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<GatewayConnector> GatewayConnectors { get; set; } = AWSConfigs.InitializeCollections ? new List<GatewayConnector>() : null;

        /// <summary>
        /// Checks to see if the GatewayConnectors property is set.
        /// </summary>
        internal bool IsSetGatewayConnectors() => this.GatewayConnectors != null && (this.GatewayConnectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GuardDutyEnabled. 
        /// <para>
        /// Indicates whether Runtime Monitoring is turned on.
        /// </para>
        /// </summary>
        public bool? GuardDutyEnabled { get; set; }

        /// <summary>
        /// Checks to see if the GuardDutyEnabled property is set.
        /// </summary>
        internal bool IsSetGuardDutyEnabled() => this.GuardDutyEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type the service revision uses.
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
        /// The load balancers the service revision uses.
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
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The optional monitoring configuration for the service, which defines the resolution
        /// for the service-level <c>CPUUtilization</c> and <c>MemoryUtilization</c> Amazon CloudWatch
        /// metrics. When not specified, Amazon ECS uses the default resolution of <c>60</c> seconds.
        /// </para>
        /// </summary>
        public MonitoringConfiguration Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration.
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// The effective runtime overrides that Amazon ECS applies to this service revision.
        /// This value is present only when Amazon ECS detects a difference between the task definition
        /// and the actual runtime configuration.
        /// </para>
        /// </summary>
        public ServiceRevisionOverrides Overrides { get; set; }

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null;

        /// <summary>
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The platform family the service revision uses.
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
        /// For the Fargate launch type, the platform version the service revision uses.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property ResolvedConfiguration. 
        /// <para>
        /// The resolved configuration for the service revision which contains the actual resources
        /// your service revision uses, such as which target groups serve traffic.
        /// </para>
        /// </summary>
        public ResolvedConfiguration ResolvedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedConfiguration property is set.
        /// </summary>
        internal bool IsSetResolvedConfiguration() => this.ResolvedConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service for the service revision.
        /// </para>
        /// </summary>
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceConnectConfiguration.
        /// </summary>
        public ServiceConnectConfiguration ServiceConnectConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServiceConnectConfiguration property is set.
        /// </summary>
        internal bool IsSetServiceConnectConfiguration() => this.ServiceConnectConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceRegistries. 
        /// <para>
        /// The service registries (for Service Discovery) the service revision uses.
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
        /// Gets and sets the property ServiceRevisionArn. 
        /// <para>
        /// The ARN of the service revision.
        /// </para>
        /// </summary>
        public string ServiceRevisionArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRevisionArn property is set.
        /// </summary>
        internal bool IsSetServiceRevisionArn() => this.ServiceRevisionArn != null;

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The task definition the service revision uses.
        /// </para>
        /// </summary>
        public string TaskDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinition property is set.
        /// </summary>
        internal bool IsSetTaskDefinition() => this.TaskDefinition != null;

        /// <summary>
        /// Gets and sets the property VolumeConfigurations. 
        /// <para>
        /// The volumes that are configured at deployment that the service revision uses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceVolumeConfiguration> VolumeConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceVolumeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the VolumeConfigurations property is set.
        /// </summary>
        internal bool IsSetVolumeConfigurations() => this.VolumeConfigurations != null && (this.VolumeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcLatticeConfigurations. 
        /// <para>
        /// The VPC Lattice configuration for the service revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcLatticeConfiguration> VpcLatticeConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcLatticeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the VpcLatticeConfigurations property is set.
        /// </summary>
        internal bool IsSetVpcLatticeConfigurations() => this.VpcLatticeConfigurations != null && (this.VpcLatticeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
