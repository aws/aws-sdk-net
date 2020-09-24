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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCluster operation.
    /// Creates an Amazon EKS control plane. 
    /// 
    ///  
    /// <para>
    /// The Amazon EKS control plane consists of control plane instances that run the Kubernetes
    /// software, such as <code>etcd</code> and the API server. The control plane runs in
    /// an account managed by AWS, and the Kubernetes API is exposed via the Amazon EKS API
    /// server endpoint. Each Amazon EKS cluster control plane is single-tenant and unique
    /// and runs on its own set of Amazon EC2 instances.
    /// </para>
    ///  
    /// <para>
    /// The cluster control plane is provisioned across multiple Availability Zones and fronted
    /// by an Elastic Load Balancing Network Load Balancer. Amazon EKS also provisions elastic
    /// network interfaces in your VPC subnets to provide connectivity from the control plane
    /// instances to the worker nodes (for example, to support <code>kubectl exec</code>,
    /// <code>logs</code>, and <code>proxy</code> data flows).
    /// </para>
    ///  
    /// <para>
    /// Amazon EKS worker nodes run in your AWS account and connect to your cluster's control
    /// plane via the Kubernetes API server endpoint and a certificate file that is created
    /// for your cluster.
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>endpointPublicAccess</code> and <code>endpointPrivateAccess</code>
    /// parameters to enable or disable public and private access to your cluster's Kubernetes
    /// API server endpoint. By default, public access is enabled, and private access is disabled.
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
    /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>logging</code> parameter to enable or disable exporting the
    /// Kubernetes control plane logs for your cluster to CloudWatch Logs. By default, cluster
    /// control plane logs aren't exported to CloudWatch Logs. For more information, see <a
    /// href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
    /// EKS Cluster Control Plane Logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
    /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">Amazon
    /// CloudWatch Pricing</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Cluster creation typically takes between 10 and 15 minutes. After you create an Amazon
    /// EKS cluster, you must configure your Kubernetes tooling to communicate with the API
    /// server and launch worker nodes into your cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/managing-auth.html">Managing
    /// Cluster Authentication</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
    /// Amazon EKS Worker Nodes</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private List<EncryptionConfig> _encryptionConfig = new List<EncryptionConfig>();
        private KubernetesNetworkConfigRequest _kubernetesNetworkConfig;
        private Logging _logging;
        private string _name;
        private VpcConfigRequest _resourcesVpcConfig;
        private string _roleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _version;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
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
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The encryption configuration for the cluster.
        /// </para>
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
            return this._encryptionConfig != null && this._encryptionConfig.Count > 0; 
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
        /// CloudWatch Logs. By default, cluster control plane logs aren't exported to CloudWatch
        /// Logs. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html">Amazon
        /// EKS Cluster Control Plane Logs</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// CloudWatch Logs ingestion, archive storage, and data scanning rates apply to exported
        /// control plane logs. For more information, see <a href="http://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
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
        /// The unique name to give to your cluster.
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
        /// Gets and sets the property ResourcesVpcConfig. 
        /// <para>
        /// The VPC configuration used by the cluster control plane. Amazon EKS VPC resources
        /// have specific requirements to work properly with Kubernetes. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">Cluster
        /// VPC Considerations</a> and <a href="https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html">Cluster
        /// Security Group Considerations</a> in the <i>Amazon EKS User Guide</i>. You must specify
        /// at least two subnets. You can specify up to five security groups, but we recommend
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
        /// control plane to make calls to AWS API operations on your behalf. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/service_IAM_role.html">Amazon
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata to apply to the cluster to assist with categorization and organization.
        /// Each tag consists of a key and an optional value, both of which you define.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The desired Kubernetes version for your cluster. If you don't specify a value here,
        /// the latest version available in Amazon EKS is used.
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

    }
}