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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing an Amazon EKS cluster.
    /// </summary>
    public partial class Cluster
    {
        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// The access configuration for the cluster.
        /// </para>
        /// </summary>
        public AccessConfigResponse AccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the AccessConfig property is set.
        /// </summary>
        internal bool IsSetAccessConfig() => this.AccessConfig != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// The <c>certificate-authority-data</c> for your cluster.
        /// </para>
        /// </summary>
        public Certificate CertificateAuthority { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthority property is set.
        /// </summary>
        internal bool IsSetCertificateAuthority() => this.CertificateAuthority != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ComputeConfig. 
        /// <para>
        /// Indicates the current configuration of the compute capability on your EKS Auto Mode
        /// cluster. For example, if the capability is enabled or disabled. If the compute capability
        /// is enabled, EKS Auto Mode will create and delete EC2 Managed Instances in your Amazon
        /// Web Services account. For more information, see EKS Auto Mode compute capability in
        /// the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public ComputeConfigResponse ComputeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfig property is set.
        /// </summary>
        internal bool IsSetComputeConfig() => this.ComputeConfig != null;

        /// <summary>
        /// Gets and sets the property ConnectorConfig. 
        /// <para>
        /// The configuration used to connect to a cluster for registration.
        /// </para>
        /// </summary>
        public ConnectorConfigResponse ConnectorConfig { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorConfig property is set.
        /// </summary>
        internal bool IsSetConnectorConfig() => this.ConnectorConfig != null;

        /// <summary>
        /// Gets and sets the property ControlPlaneScalingConfig. 
        /// <para>
        /// The control plane scaling tier configuration. For more information, see EKS Provisioned
        /// Control Plane in the Amazon EKS User Guide.
        /// </para>
        /// </summary>
        public ControlPlaneScalingConfig ControlPlaneScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ControlPlaneScalingConfig property is set.
        /// </summary>
        internal bool IsSetControlPlaneScalingConfig() => this.ControlPlaneScalingConfig != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp at object creation.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// The current deletion protection setting for the cluster. When <c>true</c>, deletion
        /// protection is enabled and the cluster cannot be deleted until protection is disabled.
        /// When <c>false</c>, the cluster can be deleted normally. This setting only applies
        /// to clusters in an active state.
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The encryption configuration for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<EncryptionConfig> EncryptionConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<EncryptionConfig>() : null;

        /// <summary>
        /// Checks to see if the EncryptionConfig property is set.
        /// </summary>
        internal bool IsSetEncryptionConfig() => this.EncryptionConfig != null && (this.EncryptionConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for your Kubernetes API server.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// An object representing the health of your Amazon EKS cluster.
        /// </para>
        /// </summary>
        public ClusterHealth Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of your local Amazon EKS cluster on an Amazon Web Services Outpost. This property
        /// isn't available for an Amazon EKS cluster on the Amazon Web Services cloud.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity provider information for the cluster.
        /// </para>
        /// </summary>
        public Identity Identity { get; set; }

        /// <summary>
        /// Checks to see if the Identity property is set.
        /// </summary>
        internal bool IsSetIdentity() => this.Identity != null;

        /// <summary>
        /// Gets and sets the property KubeApiServerConfig. 
        /// <para>
        /// The Kubernetes API server configuration for the cluster.
        /// </para>
        /// </summary>
        public KubeApiServerConfigResponse KubeApiServerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeApiServerConfig property is set.
        /// </summary>
        internal bool IsSetKubeApiServerConfig() => this.KubeApiServerConfig != null;

        /// <summary>
        /// Gets and sets the property KubeControllerManagerConfig. 
        /// <para>
        /// The Kubernetes controller manager configuration for the cluster.
        /// </para>
        /// </summary>
        public KubeControllerManagerConfigResponse KubeControllerManagerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeControllerManagerConfig property is set.
        /// </summary>
        internal bool IsSetKubeControllerManagerConfig() => this.KubeControllerManagerConfig != null;

        /// <summary>
        /// Gets and sets the property KubeSchedulerConfig. 
        /// <para>
        /// The Kubernetes scheduler configuration for the cluster.
        /// </para>
        /// </summary>
        public KubeSchedulerConfigResponse KubeSchedulerConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubeSchedulerConfig property is set.
        /// </summary>
        internal bool IsSetKubeSchedulerConfig() => this.KubeSchedulerConfig != null;

        /// <summary>
        /// Gets and sets the property KubernetesNetworkConfig. 
        /// <para>
        /// The Kubernetes network configuration for the cluster.
        /// </para>
        /// </summary>
        public KubernetesNetworkConfigResponse KubernetesNetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesNetworkConfig property is set.
        /// </summary>
        internal bool IsSetKubernetesNetworkConfig() => this.KubernetesNetworkConfig != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for your cluster.
        /// </para>
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutpostConfig. 
        /// <para>
        /// An object representing the configuration of your local Amazon EKS cluster on an Amazon
        /// Web Services Outpost. This object isn't available for clusters on the Amazon Web Services
        /// cloud.
        /// </para>
        /// </summary>
        public OutpostConfigResponse OutpostConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutpostConfig property is set.
        /// </summary>
        internal bool IsSetOutpostConfig() => this.OutpostConfig != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version of your Amazon EKS cluster. For more information about clusters
        /// deployed on the Amazon Web Services Cloud, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/platform-versions.html">Platform
        /// versions</a> in the <i> <i>Amazon EKS User Guide</i> </i>. For more information about
        /// local clusters deployed on an Outpost, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-platform-versions.html">Amazon
        /// EKS local cluster platform versions</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property RemoteNetworkConfig. 
        /// <para>
        /// The configuration in the cluster for EKS Hybrid Nodes. You can add, change, or remove
        /// this configuration after the cluster is created.
        /// </para>
        /// </summary>
        public RemoteNetworkConfigResponse RemoteNetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the RemoteNetworkConfig property is set.
        /// </summary>
        internal bool IsSetRemoteNetworkConfig() => this.RemoteNetworkConfig != null;

        /// <summary>
        /// Gets and sets the property ResourcesVpcConfig. 
        /// <para>
        /// The VPC configuration used by the cluster control plane. Amazon EKS VPC resources
        /// have specific requirements to work properly with Kubernetes. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">Cluster
        /// VPC considerations</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html">Cluster
        /// security group considerations</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public VpcConfigResponse ResourcesVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesVpcConfig property is set.
        /// </summary>
        internal bool IsSetResourcesVpcConfig() => this.ResourcesVpcConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes
        /// control plane to make calls to Amazon Web Services API operations on your behalf.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageConfig. 
        /// <para>
        /// Indicates the current configuration of the block storage capability on your EKS Auto
        /// Mode cluster. For example, if the capability is enabled or disabled. If the block
        /// storage capability is enabled, EKS Auto Mode will create and delete EBS volumes in
        /// your Amazon Web Services account. For more information, see EKS Auto Mode block storage
        /// capability in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public StorageConfigResponse StorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfig property is set.
        /// </summary>
        internal bool IsSetStorageConfig() => this.StorageConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpgradePolicy. 
        /// <para>
        /// This value indicates if extended support is enabled or disabled for the cluster.
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/eks/latest/userguide/extended-support-control.html">Learn
        /// more about EKS Extended Support in the <i>Amazon EKS User Guide</i>.</a> 
        /// </para>
        /// </summary>
        public UpgradePolicyResponse UpgradePolicy { get; set; }

        /// <summary>
        /// Checks to see if the UpgradePolicy property is set.
        /// </summary>
        internal bool IsSetUpgradePolicy() => this.UpgradePolicy != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Kubernetes server version for the cluster.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property ZonalShiftConfig. 
        /// <para>
        /// The configuration for zonal shift for the cluster.
        /// </para>
        /// </summary>
        public ZonalShiftConfigResponse ZonalShiftConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZonalShiftConfig property is set.
        /// </summary>
        internal bool IsSetZonalShiftConfig() => this.ZonalShiftConfig != null;
    }
}
