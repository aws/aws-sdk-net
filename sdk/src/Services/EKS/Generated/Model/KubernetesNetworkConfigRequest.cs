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
    /// The Kubernetes network configuration for the cluster.
    /// </summary>
    public partial class KubernetesNetworkConfigRequest
    {
        private IpFamily _ipFamily;
        private string _serviceIpv4Cidr;

        /// <summary>
        /// Gets and sets the property IpFamily. 
        /// <para>
        /// Specify which IP version is used to assign Kubernetes Pod and Service IP addresses.
        /// If you don't specify a value, <code>ipv4</code> is used by default. You can only specify
        /// an IP family when you create a cluster and can't change this value once the cluster
        /// is created. If you specify <code>ipv6</code>, the VPC and subnets that you specify
        /// for cluster creation must have both IPv4 and IPv6 CIDR blocks assigned to them. 
        /// </para>
        ///  
        /// <para>
        /// You can only specify <code>ipv6</code> for 1.21 and later clusters that use version
        /// 1.10.0 or later of the Amazon VPC CNI add-on. If you specify <code>ipv6</code>, then
        /// ensure that your VPC meets the requirements and that you're familiar with the considerations
        /// listed in <a href="https://docs.aws.amazon.com/eks/latest/userguide/cni-ipv6.html">Assigning
        /// IPv6 addresses to Pods and Services</a> in the Amazon EKS User Guide. If you specify
        /// <code>ipv6</code>, Kubernetes assigns Service and Pod addresses from the unique local
        /// address range (fc00::/7). You can't specify a custom IPv6 CIDR block.
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
        /// Don't specify a value if you select <code>ipv6</code> for <b>ipFamily</b>. The CIDR
        /// block to assign Kubernetes service IP addresses from. If you don't specify a block,
        /// Kubernetes assigns addresses from either the 10.100.0.0/16 or 172.20.0.0/16 CIDR blocks.
        /// We recommend that you specify a block that does not overlap with resources in other
        /// networks that are peered or connected to your VPC. The block must meet the following
        /// requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Within one of the following private IP address blocks: 10.0.0.0/8, 172.16.0.0/12,
        /// or 192.168.0.0/16.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Doesn't overlap with any CIDR block assigned to the VPC that you selected for VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between /24 and /12.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// You can only specify a custom CIDR block when you create a cluster and can't change
        /// this value once the cluster is created.
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