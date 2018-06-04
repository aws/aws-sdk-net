/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// software, like <code>etcd</code> and the API server. The control plane runs in an
    /// account managed by AWS, and the Kubernetes API is exposed via the Amazon EKS API server
    /// endpoint.
    /// </para>
    ///  
    /// <para>
    /// Amazon EKS worker nodes run in your AWS account and connect to your cluster's control
    /// plane via the Kubernetes API server endpoint and a certificate file that is created
    /// for your cluster.
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
    /// After you create an Amazon EKS cluster, you must configure your Kubernetes tooling
    /// to communicate with the API server and launch worker nodes into your cluster. For
    /// more information, see <a href="http://docs.aws.amazon.com/eks/latest/userguide/managing-auth.html">Managing
    /// Cluster Authentication</a> and <a href="http://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
    /// Amazon EKS Worker Nodes</a>in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateClusterRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _name;
        private VpcConfigRequest _resourcesVpcConfig;
        private string _roleArn;
        private string _version;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name to give to your cluster.
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
        /// Gets and sets the property ResourcesVpcConfig. 
        /// <para>
        /// The VPC subnets and security groups used by the cluster control plane. Amazon EKS
        /// VPC resources have specific requirements to work properly with Kubernetes. For more
        /// information, see <a href="http://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html">Cluster
        /// VPC Considerations</a> and <a href="http://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html">Cluster
        /// Security Group Considerations</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of the IAM role that provides permissions for Amazon
        /// EKS to make calls to other AWS API operations on your behalf. For more information,
        /// see <a href="http://docs.aws.amazon.com/eks/latest/userguide/service_IAM_role.html">Amazon
        /// EKS Service IAM Role</a> in the <i> <i>Amazon EKS User Guide</i> </i> 
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The desired Kubernetes version for your cluster. If you do not specify a value here,
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