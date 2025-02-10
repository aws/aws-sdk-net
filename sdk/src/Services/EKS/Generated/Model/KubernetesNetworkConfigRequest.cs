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
    /// The Kubernetes network configuration for the cluster.
    /// </summary>
    public partial class KubernetesNetworkConfigRequest
    {
        private ElasticLoadBalancing _elasticLoadBalancing;
        private IpFamily _ipFamily;
        private string _serviceIpv4Cidr;

        /// <summary>
        /// Gets and sets the property ElasticLoadBalancing. 
        /// <para>
        /// Request to enable or disable the load balancing capability on your EKS Auto Mode cluster.
        /// For more information, see EKS Auto Mode load balancing capability in the <i>Amazon
        /// EKS User Guide</i>.
        /// </para>
        /// </summary>
        public ElasticLoadBalancing ElasticLoadBalancing
        {
            get { return this._elasticLoadBalancing; }
            set { this._elasticLoadBalancing = value; }
        }

        // Check to see if ElasticLoadBalancing property is set
        internal bool IsSetElasticLoadBalancing()
        {
            return this._elasticLoadBalancing != null;
        }

        /// <summary>
        /// Gets and sets the property IpFamily. 
        /// <para>
        /// Specify which IP family is used to assign Kubernetes pod and service IP addresses.
        /// If you don't specify a value, <c>ipv4</c> is used by default. You can only specify
        /// an IP family when you create a cluster and can't change this value once the cluster
        /// is created. If you specify <c>ipv6</c>, the VPC and subnets that you specify for cluster
        /// creation must have both <c>IPv4</c> and <c>IPv6</c> CIDR blocks assigned to them.
        /// You can't specify <c>ipv6</c> for clusters in China Regions.
        /// </para>
        ///  
        /// <para>
        /// You can only specify <c>ipv6</c> for <c>1.21</c> and later clusters that use version
        /// <c>1.10.1</c> or later of the Amazon VPC CNI add-on. If you specify <c>ipv6</c>, then
        /// ensure that your VPC meets the requirements listed in the considerations listed in
        /// <a href="https://docs.aws.amazon.com/eks/latest/userguide/cni-ipv6.html">Assigning
        /// IPv6 addresses to pods and services</a> in the <i>Amazon EKS User Guide</i>. Kubernetes
        /// assigns services <c>IPv6</c> addresses from the unique local address range <c>(fc00::/7)</c>.
        /// You can't specify a custom <c>IPv6</c> CIDR block. Pod addresses are assigned from
        /// the subnet's <c>IPv6</c> CIDR.
        /// </para>
        /// </summary>
        public IpFamily IpFamily
        {
            get { return this._ipFamily; }
            set { this._ipFamily = value; }
        }

        // Check to see if IpFamily property is set
        internal bool IsSetIpFamily()
        {
            return this._ipFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceIpv4Cidr. 
        /// <para>
        /// Don't specify a value if you select <c>ipv6</c> for <b>ipFamily</b>. The CIDR block
        /// to assign Kubernetes service IP addresses from. If you don't specify a block, Kubernetes
        /// assigns addresses from either the <c>10.100.0.0/16</c> or <c>172.20.0.0/16</c> CIDR
        /// blocks. We recommend that you specify a block that does not overlap with resources
        /// in other networks that are peered or connected to your VPC. The block must meet the
        /// following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Within one of the following private IP address blocks: <c>10.0.0.0/8</c>, <c>172.16.0.0/12</c>,
        /// or <c>192.168.0.0/16</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Doesn't overlap with any CIDR block assigned to the VPC that you selected for VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between <c>/24</c> and <c>/12</c>.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You can only specify a custom CIDR block when you create a cluster. You can't change
        /// this value after the cluster is created.
        /// </para>
        ///  </important>
        /// </summary>
        public string ServiceIpv4Cidr
        {
            get { return this._serviceIpv4Cidr; }
            set { this._serviceIpv4Cidr = value; }
        }

        // Check to see if ServiceIpv4Cidr property is set
        internal bool IsSetServiceIpv4Cidr()
        {
            return this._serviceIpv4Cidr != null;
        }

    }
}