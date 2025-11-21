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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
        private AccessConfigResponse _accessConfig;
        private string _arn;
        private Certificate _certificateAuthority;
        private string _clientRequestToken;
        private ComputeConfigResponse _computeConfig;
        private ConnectorConfigResponse _connectorConfig;
        private DateTime? _createdAt;
        private bool? _deletionProtection;
        private List<EncryptionConfig> _encryptionConfig = AWSConfigs.InitializeCollections ? new List<EncryptionConfig>() : null;
        private string _endpoint;
        private ClusterHealth _health;
        private string _id;
        private Identity _identity;
        private KubernetesNetworkConfigResponse _kubernetesNetworkConfig;
        private Logging _logging;
        private string _name;
        private OutpostConfigResponse _outpostConfig;
        private string _platformVersion;
        private RemoteNetworkConfigResponse _remoteNetworkConfig;
        private VpcConfigResponse _resourcesVpcConfig;
        private string _roleArn;
        private ClusterStatus _status;
        private StorageConfigResponse _storageConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private UpgradePolicyResponse _upgradePolicy;
        private string _version;
        private ZonalShiftConfigResponse _zonalShiftConfig;

        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// The access configuration for the cluster.
        /// </para>
        /// </summary>
        public AccessConfigResponse AccessConfig
        {
            get { return this._accessConfig; }
            set { this._accessConfig = value; }
        }

        // Check to see if AccessConfig property is set
        internal bool IsSetAccessConfig()
        {
            return this._accessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// The <c>certificate-authority-data</c> for your cluster.
        /// </para>
        /// </summary>
        public Certificate CertificateAuthority
        {
            get { return this._certificateAuthority; }
            set { this._certificateAuthority = value; }
        }

        // Check to see if CertificateAuthority property is set
        internal bool IsSetCertificateAuthority()
        {
            return this._certificateAuthority != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

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
        public ComputeConfigResponse ComputeConfig
        {
            get { return this._computeConfig; }
            set { this._computeConfig = value; }
        }

        // Check to see if ComputeConfig property is set
        internal bool IsSetComputeConfig()
        {
            return this._computeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorConfig. 
        /// <para>
        /// The configuration used to connect to a cluster for registration.
        /// </para>
        /// </summary>
        public ConnectorConfigResponse ConnectorConfig
        {
            get { return this._connectorConfig; }
            set { this._connectorConfig = value; }
        }

        // Check to see if ConnectorConfig property is set
        internal bool IsSetConnectorConfig()
        {
            return this._connectorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp at object creation.
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// The current deletion protection setting for the cluster. When <c>true</c>, deletion
        /// protection is enabled and the cluster cannot be deleted until protection is disabled.
        /// When <c>false</c>, the cluster can be deleted normally. This setting only applies
        /// to clusters in an active state.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The encryption configuration for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<EncryptionConfig> EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null && (this._encryptionConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for your Kubernetes API server.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// An object representing the health of your Amazon EKS cluster.
        /// </para>
        /// </summary>
        public ClusterHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of your local Amazon EKS cluster on an Amazon Web Services Outpost. This property
        /// isn't available for an Amazon EKS cluster on the Amazon Web Services cloud.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity provider information for the cluster.
        /// </para>
        /// </summary>
        public Identity Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesNetworkConfig. 
        /// <para>
        /// The Kubernetes network configuration for the cluster.
        /// </para>
        /// </summary>
        public KubernetesNetworkConfigResponse KubernetesNetworkConfig
        {
            get { return this._kubernetesNetworkConfig; }
            set { this._kubernetesNetworkConfig = value; }
        }

        // Check to see if KubernetesNetworkConfig property is set
        internal bool IsSetKubernetesNetworkConfig()
        {
            return this._kubernetesNetworkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for your cluster.
        /// </para>
        /// </summary>
        public Logging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your cluster.
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
        /// Gets and sets the property OutpostConfig. 
        /// <para>
        /// An object representing the configuration of your local Amazon EKS cluster on an Amazon
        /// Web Services Outpost. This object isn't available for clusters on the Amazon Web Services
        /// cloud.
        /// </para>
        /// </summary>
        public OutpostConfigResponse OutpostConfig
        {
            get { return this._outpostConfig; }
            set { this._outpostConfig = value; }
        }

        // Check to see if OutpostConfig property is set
        internal bool IsSetOutpostConfig()
        {
            return this._outpostConfig != null;
        }

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
        /// Gets and sets the property RemoteNetworkConfig. 
        /// <para>
        /// The configuration in the cluster for EKS Hybrid Nodes. You can add, change, or remove
        /// this configuration after the cluster is created.
        /// </para>
        /// </summary>
        public RemoteNetworkConfigResponse RemoteNetworkConfig
        {
            get { return this._remoteNetworkConfig; }
            set { this._remoteNetworkConfig = value; }
        }

        // Check to see if RemoteNetworkConfig property is set
        internal bool IsSetRemoteNetworkConfig()
        {
            return this._remoteNetworkConfig != null;
        }

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
        public VpcConfigResponse ResourcesVpcConfig
        {
            get { return this._resourcesVpcConfig; }
            set { this._resourcesVpcConfig = value; }
        }

        // Check to see if ResourcesVpcConfig property is set
        internal bool IsSetResourcesVpcConfig()
        {
            return this._resourcesVpcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes
        /// control plane to make calls to Amazon Web Services API operations on your behalf.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        public StorageConfigResponse StorageConfig
        {
            get { return this._storageConfig; }
            set { this._storageConfig = value; }
        }

        // Check to see if StorageConfig property is set
        internal bool IsSetStorageConfig()
        {
            return this._storageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        public UpgradePolicyResponse UpgradePolicy
        {
            get { return this._upgradePolicy; }
            set { this._upgradePolicy = value; }
        }

        // Check to see if UpgradePolicy property is set
        internal bool IsSetUpgradePolicy()
        {
            return this._upgradePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Kubernetes server version for the cluster.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalShiftConfig. 
        /// <para>
        /// The configuration for zonal shift for the cluster.
        /// </para>
        /// </summary>
        public ZonalShiftConfigResponse ZonalShiftConfig
        {
            get { return this._zonalShiftConfig; }
            set { this._zonalShiftConfig = value; }
        }

        // Check to see if ZonalShiftConfig property is set
        internal bool IsSetZonalShiftConfig()
        {
            return this._zonalShiftConfig != null;
        }

    }
}