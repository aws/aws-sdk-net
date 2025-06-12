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
    /// An object representing the VPC configuration to use for an Amazon EKS cluster.
    /// </summary>
    public partial class VpcConfigRequest
    {
        private bool? _endpointPrivateAccess;
        private bool? _endpointPublicAccess;
        private List<string> _publicAccessCidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndpointPrivateAccess. 
        /// <para>
        /// Set this value to <c>true</c> to enable private access for your cluster's Kubernetes
        /// API server endpoint. If you enable private access, Kubernetes API requests from within
        /// your cluster's VPC use the private VPC endpoint. The default value for this parameter
        /// is <c>false</c>, which disables private access for your Kubernetes API server. If
        /// you disable private access and you have nodes or Fargate pods in the cluster, then
        /// ensure that <c>publicAccessCidrs</c> includes the necessary CIDR blocks for communication
        /// with the nodes or Fargate pods. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Cluster
        /// API server endpoint</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public bool? EndpointPrivateAccess
        {
            get { return this._endpointPrivateAccess; }
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
        /// Set this value to <c>false</c> to disable public access to your cluster's Kubernetes
        /// API server endpoint. If you disable public access, your cluster's Kubernetes API server
        /// can only receive requests from within the cluster VPC. The default value for this
        /// parameter is <c>true</c>, which enables public access for your Kubernetes API server.
        /// The endpoint domain name and IP address family depends on the value of the <c>ipFamily</c>
        /// for the cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Cluster
        /// API server endpoint</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// </summary>
        public bool? EndpointPublicAccess
        {
            get { return this._endpointPublicAccess; }
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
        /// that you specify is denied. The default value is <c>0.0.0.0/0</c> and additionally
        /// <c>::/0</c> for dual-stack `IPv6` clusters. If you've disabled private endpoint access,
        /// make sure that you specify the necessary CIDR blocks for every node and Fargate <c>Pod</c>
        /// in the cluster. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/cluster-endpoint.html">Cluster
        /// API server endpoint</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// Note that the public endpoints are dual-stack for only <c>IPv6</c> clusters that are
        /// made after October 2024. You can't add <c>IPv6</c> CIDR blocks to <c>IPv4</c> clusters
        /// or <c>IPv6</c> clusters that were made before October 2024.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Specify one or more security groups for the cross-account elastic network interfaces
        /// that Amazon EKS creates to use that allow communication between your nodes and the
        /// Kubernetes control plane. If you don't specify any security groups, then familiarize
        /// yourself with the difference between Amazon EKS defaults for clusters deployed with
        /// Kubernetes. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html">Amazon
        /// EKS security group considerations</a> in the <i> <i>Amazon EKS User Guide</i> </i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Specify subnets for your Amazon EKS nodes. Amazon EKS creates cross-account elastic
        /// network interfaces in these subnets to allow communication between your nodes and
        /// the Kubernetes control plane.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

    }
}