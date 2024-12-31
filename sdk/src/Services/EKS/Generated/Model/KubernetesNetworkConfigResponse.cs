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
    /// The Kubernetes network configuration for the cluster. The response contains a value
    /// for <b>serviceIpv6Cidr</b> or <b>serviceIpv4Cidr</b>, but not both.
    /// </summary>
    public partial class KubernetesNetworkConfigResponse
    {
        private ElasticLoadBalancing _elasticLoadBalancing;
        private IpFamily _ipFamily;
        private string _serviceIpv4Cidr;
        private string _serviceIpv6Cidr;

        /// <summary>
        /// Gets and sets the property ElasticLoadBalancing. 
        /// <para>
        /// Indicates the current configuration of the load balancing capability on your EKS Auto
        /// Mode cluster. For example, if the capability is enabled or disabled.
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
        /// The IP family used to assign Kubernetes <c>Pod</c> and <c>Service</c> objects IP addresses.
        /// The IP family is always <c>ipv4</c>, unless you have a <c>1.21</c> or later cluster
        /// running version <c>1.10.1</c> or later of the Amazon VPC CNI plugin for Kubernetes
        /// and specified <c>ipv6</c> when you created the cluster. 
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
        /// The CIDR block that Kubernetes <c>Pod</c> and <c>Service</c> object IP addresses are
        /// assigned from. Kubernetes assigns addresses from an <c>IPv4</c> CIDR block assigned
        /// to a subnet that the node is in. If you didn't specify a CIDR block when you created
        /// the cluster, then Kubernetes assigns addresses from either the <c>10.100.0.0/16</c>
        /// or <c>172.20.0.0/16</c> CIDR blocks. If this was specified, then it was specified
        /// when the cluster was created and it can't be changed.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property ServiceIpv6Cidr. 
        /// <para>
        /// The CIDR block that Kubernetes pod and service IP addresses are assigned from if you
        /// created a 1.21 or later cluster with version 1.10.1 or later of the Amazon VPC CNI
        /// add-on and specified <c>ipv6</c> for <b>ipFamily</b> when you created the cluster.
        /// Kubernetes assigns service addresses from the unique local address range (<c>fc00::/7</c>)
        /// because you can't specify a custom IPv6 CIDR block when you create the cluster.
        /// </para>
        /// </summary>
        public string ServiceIpv6Cidr
        {
            get { return this._serviceIpv6Cidr; }
            set { this._serviceIpv6Cidr = value; }
        }

        // Check to see if ServiceIpv6Cidr property is set
        internal bool IsSetServiceIpv6Cidr()
        {
            return this._serviceIpv6Cidr != null;
        }

    }
}