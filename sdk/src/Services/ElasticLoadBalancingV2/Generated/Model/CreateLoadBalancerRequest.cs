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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLoadBalancer operation.
    /// Creates an Application load balancer.
    /// 
    ///  
    /// <para>
    /// To create listeners for your load balancer, use <a>CreateListener</a>. You can add
    /// security groups, subnets, and tags when you create your load balancer, or you can
    /// add them later using <a>SetSecurityGroups</a>, <a>SetSubnets</a>, and <a>AddTags</a>.
    /// </para>
    ///  
    /// <para>
    /// To describe your current load balancers, see <a>DescribeLoadBalancers</a>. When you
    /// are finished with a load balancer, you can delete it using <a>DeleteLoadBalancer</a>.
    /// </para>
    ///  
    /// <para>
    /// You can create up to 20 load balancers per region per account. You can request an
    /// increase for the number of load balancers for your account. For more information,
    /// see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Limits
    /// for Your Application Load Balancer</a> in the <i>Application Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _name;
        private LoadBalancerSchemeEnum _scheme;
        private List<string> _securityGroups = new List<string>();
        private List<string> _subnets = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        ///  
        /// <para>
        /// This name must be unique within your AWS account, can have a maximum of 32 characters,
        /// must contain only alphanumeric characters or hyphens, and must not begin or end with
        /// a hyphen.
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
        /// Gets and sets the property Scheme. 
        /// <para>
        /// The nodes of an Internet-facing load balancer have public IP addresses. The DNS name
        /// of an Internet-facing load balancer is publicly resolvable to the public IP addresses
        /// of the nodes. Therefore, Internet-facing load balancers can route requests from clients
        /// over the Internet.
        /// </para>
        ///  
        /// <para>
        /// The nodes of an internal load balancer have only private IP addresses. The DNS name
        /// of an internal load balancer is publicly resolvable to the private IP addresses of
        /// the nodes. Therefore, internal load balancers can only route requests from clients
        /// with access to the VPC for the load balancer.
        /// </para>
        ///  
        /// <para>
        /// The default is an Internet-facing load balancer.
        /// </para>
        /// </summary>
        public LoadBalancerSchemeEnum Scheme
        {
            get { return this._scheme; }
            set { this._scheme = value; }
        }

        // Check to see if Scheme property is set
        internal bool IsSetScheme()
        {
            return this._scheme != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the security groups to assign to the load balancer.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of the subnets to attach to the load balancer. You can specify only one subnet
        /// per Availability Zone. You must specify subnets from at least two Availability Zones.
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to assign to the load balancer.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}