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
    /// An object representing an Amazon EKS cluster VPC configuration response.
    /// </summary>
    public partial class VpcConfigResponse
    {
        private string _clusterSecurityGroupId;
        private bool? _endpointPrivateAccess;
        private bool? _endpointPublicAccess;
        private List<string> _publicAccessCidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroupId. 
        /// <para>
        /// The cluster security group that was created by Amazon EKS for the cluster. Managed
        /// node groups use this security group for control-plane-to-data-plane communication.
        /// </para>
        /// </summary>
        public string ClusterSecurityGroupId
        {
            get { return this._clusterSecurityGroupId; }
            set { this._clusterSecurityGroupId = value; }
        }

        // Check to see if ClusterSecurityGroupId property is set
        internal bool IsSetClusterSecurityGroupId()
        {
            return this._clusterSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointPrivateAccess. 
        /// <para>
        /// This parameter indicates whether the Amazon EKS private API server endpoint is enabled.
        /// If the Amazon EKS private API server endpoint is enabled, Kubernetes API requests
        /// that originate from within your cluster's VPC use the private VPC endpoint instead
        /// of traversing the internet. If this value is disabled and you have nodes or Fargate
        /// pods in the cluster, then ensure that <c>publicAccessCidrs</c> includes the necessary
        /// CIDR blocks for communication with the nodes or Fargate pods. For more information,
        /// see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Amazon
        /// EKS cluster endpoint access control</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
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
        /// Whether the public API server endpoint is enabled.
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
        /// endpoint.
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
            return this._publicAccessCidrs != null && (this._publicAccessCidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups associated with the cross-account elastic network interfaces that
        /// are used to allow communication between your nodes and the Kubernetes control plane.
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
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The subnets associated with your cluster.
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
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC associated with your cluster.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}