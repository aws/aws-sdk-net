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
    /// An object representing the VPC configuration to use for an Amazon EKS cluster.
    /// </summary>
    public partial class VpcConfigRequest
    {
        private bool? _endpointPrivateAccess;
        private bool? _endpointPublicAccess;
        private List<string> _publicAccessCidrs = new List<string>();
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property EndpointPrivateAccess. 
        /// <para>
        /// Set this value to <code>true</code> to enable private access for your cluster's Kubernetes
        /// API server endpoint. If you enable private access, Kubernetes API requests from within
        /// your cluster's VPC use the private VPC endpoint. The default value for this parameter
        /// is <code>false</code>, which disables private access for your Kubernetes API server.
        /// If you disable private access and you have worker nodes or AWS Fargate pods in the
        /// cluster, then ensure that <code>publicAccessCidrs</code> includes the necessary CIDR
        /// blocks for communication with the worker nodes or Fargate pods. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public bool EndpointPrivateAccess
        {
            get { return this._endpointPrivateAccess.GetValueOrDefault(); }
            set { this._endpointPrivateAccess = value; }
        }

        // Check to see if EndpointPrivateAccess property is set
        internal bool IsSetEndpointPrivateAccess()
        {
            return this._endpointPrivateAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointPublicAccess. 
        /// <para>
        /// Set this value to <code>false</code> to disable public access to your cluster's Kubernetes
        /// API server endpoint. If you disable public access, your cluster's Kubernetes API server
        /// can only receive requests from within the cluster VPC. The default value for this
        /// parameter is <code>true</code>, which enables public access for your Kubernetes API
        /// server. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public bool EndpointPublicAccess
        {
            get { return this._endpointPublicAccess.GetValueOrDefault(); }
            set { this._endpointPublicAccess = value; }
        }

        // Check to see if EndpointPublicAccess property is set
        internal bool IsSetEndpointPublicAccess()
        {
            return this._endpointPublicAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicAccessCidrs. 
        /// <para>
        /// The CIDR blocks that are allowed access to your cluster's public Kubernetes API server
        /// endpoint. Communication to the endpoint from addresses outside of the CIDR blocks
        /// that you specify is denied. The default value is <code>0.0.0.0/0</code>. If you've
        /// disabled private endpoint access and you have worker nodes or AWS Fargate pods in
        /// the cluster, then ensure that you specify the necessary CIDR blocks. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS Cluster Endpoint Access Control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public List<string> PublicAccessCidrs
        {
            get { return this._publicAccessCidrs; }
            set { this._publicAccessCidrs = value; }
        }

        // Check to see if PublicAccessCidrs property is set
        internal bool IsSetPublicAccessCidrs()
        {
            return this._publicAccessCidrs != null && this._publicAccessCidrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Specify one or more security groups for the cross-account elastic network interfaces
        /// that Amazon EKS creates to use to allow communication between your worker nodes and
        /// the Kubernetes control plane. If you don't specify any security groups, then familiarize
        /// yourself with the difference between Amazon EKS defaults for clusters deployed with
        /// Kubernetes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1.14 Amazon EKS platform version <code>eks.2</code> and earlier
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1.14 Amazon EKS platform version <code>eks.3</code> and later 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html">Amazon
        /// EKS security group considerations</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Specify subnets for your Amazon EKS worker nodes. Amazon EKS creates cross-account
        /// elastic network interfaces in these subnets to allow communication between your worker
        /// nodes and the Kubernetes control plane.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}