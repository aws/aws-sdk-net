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
    /// Container for the parameters to the CreateCluster operation.
    /// Creates an Amazon EKS control plane.
    /// 
    ///  
    /// <para>
    /// The Amazon EKS control plane consists of control plane instances that run the Kubernetes
    /// software, such as <c>etcd</c> and the API server. The control plane runs in an account
    /// managed by Amazon Web Services, and the Kubernetes API is exposed by the Amazon EKS
    /// API server endpoint. Each Amazon EKS cluster control plane is single tenant and unique.
    /// It runs on its own set of Amazon EC2 instances.
    /// </para>
    ///  
    /// <para>
    /// The cluster control plane is provisioned across multiple Availability Zones and fronted
    /// by an Elastic Load Balancing Network Load Balancer. Amazon EKS also provisions elastic
    /// network interfaces in your VPC subnets to provide connectivity from the control plane
    /// instances to the nodes (for example, to support <c>kubectl exec</c>, <c>logs</c>,
    /// and <c>proxy</c> data flows).
    /// </para>
    ///  
    /// <para>
    /// Amazon EKS nodes run in your Amazon Web Services account and connect to your cluster's
    /// control plane over the Kubernetes API server endpoint and a certificate file that
    /// is created for your cluster.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>endpointPublicAccess</c> and <c>endpointPrivateAccess</c> parameters
    /// to enable or disable public and private access to your cluster's Kubernetes API server
    /// endpoint. By default, public access is enabled, and private access is disabled. The
    /// endpoint domain name and IP address family depends on the value of the <c>ipFamily</c>
    /// for the cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
    /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>logging</c> parameter to enable or disable exporting the Kubernetes
    /// control plane logs for your cluster to CloudWatch Logs. By default, cluster control
    /// plane logs aren't exported to CloudWatch Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
    /// EKS Cluster Control Plane Logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
    /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
    /// Pricing</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// In most cases, it takes several minutes to create a cluster. After you create an Amazon
    /// EKS cluster, you must configure your Kubernetes tooling to communicate with the API
    /// server and launch nodes into your cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-auth.html">Allowing
    /// users to access your cluster</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
    /// Amazon EKS nodes</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonEKSRequest
    {
        private CreateAccessConfigRequest _accessConfig;
        private bool? _bootstrapSelfManagedAddons;
        private string _clientRequestToken;
        private ComputeConfigRequest _computeConfig;
        private bool? _deletionProtection;
        private List<EncryptionConfig> _encryptionConfig = AWSConfigs.InitializeCollections ? new List<EncryptionConfig>() : null;
        private KubernetesNetworkConfigRequest _kubernetesNetworkConfig;
        private Logging _logging;
        private string _name;
        private OutpostConfigRequest _outpostConfig;
        private RemoteNetworkConfigRequest _remoteNetworkConfig;
        private VpcConfigRequest _resourcesVpcConfig;
        private string _roleArn;
        private StorageConfigRequest _storageConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private UpgradePolicyRequest _upgradePolicy;
        private string _version;
        private ZonalShiftConfigRequest _zonalShiftConfig;

        /// <summary>
        /// Gets and sets the property AccessConfig. 
        /// <para>
        /// The access configuration for the cluster.
        /// </para>
        /// </summary>
        public CreateAccessConfigRequest AccessConfig
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
        /// Gets and sets the property BootstrapSelfManagedAddons. 
        /// <para>
        /// If you set this value to <c>False</c> when creating a cluster, the default networking
        /// add-ons will not be installed.
        /// </para>
        ///  
        /// <para>
        /// The default networking add-ons include <c>vpc-cni</c>, <c>coredns</c>, and <c>kube-proxy</c>.
        /// </para>
        ///  
        /// <para>
        /// Use this option when you plan to install third-party alternative add-ons or self-manage
        /// the default networking add-ons.
        /// </para>
        /// </summary>
        public bool? BootstrapSelfManagedAddons
        {
            get { return this._bootstrapSelfManagedAddons; }
            set { this._bootstrapSelfManagedAddons = value; }
        }

        // Check to see if BootstrapSelfManagedAddons property is set
        internal bool IsSetBootstrapSelfManagedAddons()
        {
            return this._bootstrapSelfManagedAddons.HasValue; 
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
        /// Enable or disable the compute capability of EKS Auto Mode when creating your EKS Auto
        /// Mode cluster. If the compute capability is enabled, EKS Auto Mode will create and
        /// delete EC2 Managed Instances in your Amazon Web Services account
        /// </para>
        /// </summary>
        public ComputeConfigRequest ComputeConfig
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether to enable deletion protection for the cluster. When enabled, the
        /// cluster cannot be deleted unless deletion protection is first disabled. This helps
        /// prevent accidental cluster deletion. Default value is <c>false</c>.
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
        /// Gets and sets the property KubernetesNetworkConfig. 
        /// <para>
        /// The Kubernetes network configuration for the cluster.
        /// </para>
        /// </summary>
        public KubernetesNetworkConfigRequest KubernetesNetworkConfig
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
        /// Enable or disable exporting the Kubernetes control plane logs for your cluster to
        /// CloudWatch Logs . By default, cluster control plane logs aren't exported to CloudWatch
        /// Logs . For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS Cluster control plane logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  </note>
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
        /// The unique name to give to your cluster. The name can contain only alphanumeric characters
        /// (case-sensitive), hyphens, and underscores. It must start with an alphanumeric character
        /// and can't be longer than 100 characters. The name must be unique within the Amazon
        /// Web Services Region and Amazon Web Services account that you're creating the cluster
        /// in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Web Services Outpost. Before creating a local cluster on an Outpost, review <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-outposts-local-cluster-overview.html">Local
        /// clusters for Amazon EKS on Amazon Web Services Outposts</a> in the <i>Amazon EKS User
        /// Guide</i>. This object isn't available for creating Amazon EKS clusters on the Amazon
        /// Web Services cloud.
        /// </para>
        /// </summary>
        public OutpostConfigRequest OutpostConfig
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
        /// Gets and sets the property RemoteNetworkConfig. 
        /// <para>
        /// The configuration in the cluster for EKS Hybrid Nodes. You can add, change, or remove
        /// this configuration after the cluster is created.
        /// </para>
        /// </summary>
        public RemoteNetworkConfigRequest RemoteNetworkConfig
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
        /// The VPC configuration that's used by the cluster control plane. Amazon EKS VPC resources
        /// have specific requirements to work properly with Kubernetes. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">Cluster
        /// VPC Considerations</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html">Cluster
        /// Security Group Considerations</a> in the <i>Amazon EKS User Guide</i>. You must specify
        /// at least two subnets. You can specify up to five security groups. However, we recommend
        /// that you use a dedicated security group for your cluster control plane.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VpcConfigRequest ResourcesVpcConfig
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
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/service_IAM_role.html">Amazon
        /// EKS Service IAM Role</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StorageConfig. 
        /// <para>
        /// Enable or disable the block storage capability of EKS Auto Mode when creating your
        /// EKS Auto Mode cluster. If the block storage capability is enabled, EKS Auto Mode will
        /// create and delete EBS volumes in your Amazon Web Services account.
        /// </para>
        /// </summary>
        public StorageConfigRequest StorageConfig
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
        /// New clusters, by default, have extended support enabled. You can disable extended
        /// support when creating a cluster by setting this value to <c>STANDARD</c>.
        /// </para>
        /// </summary>
        public UpgradePolicyRequest UpgradePolicy
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
        /// The desired Kubernetes version for your cluster. If you don't specify a value here,
        /// the default version available in Amazon EKS is used.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default version might not be the latest version available.
        /// </para>
        ///  </note>
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
        /// Enable or disable ARC zonal shift for the cluster. If zonal shift is enabled, Amazon
        /// Web Services configures zonal autoshift for the cluster.
        /// </para>
        ///  
        /// <para>
        /// Zonal shift is a feature of Amazon Application Recovery Controller (ARC). ARC zonal
        /// shift is designed to be a temporary measure that allows you to move traffic for a
        /// resource away from an impaired AZ until the zonal shift expires or you cancel it.
        /// You can extend the zonal shift if necessary.
        /// </para>
        ///  
        /// <para>
        /// You can start a zonal shift for an Amazon EKS cluster, or you can allow Amazon Web
        /// Services to do it for you by enabling <i>zonal autoshift</i>. This shift updates the
        /// flow of east-to-west network traffic in your cluster to only consider network endpoints
        /// for Pods running on worker nodes in healthy AZs. Additionally, any ALB or NLB handling
        /// ingress traffic for applications in your Amazon EKS cluster will automatically route
        /// traffic to targets in the healthy AZs. For more information about zonal shift in EKS,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/zone-shift.html">Learn
        /// about Amazon Application Recovery Controller (ARC) Zonal Shift in Amazon EKS</a> in
        /// the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public ZonalShiftConfigRequest ZonalShiftConfig
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