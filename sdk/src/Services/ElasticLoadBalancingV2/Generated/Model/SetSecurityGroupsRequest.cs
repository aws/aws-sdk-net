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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the SetSecurityGroups operation.
    /// Associates the specified security groups with the specified Application Load Balancer
    /// or Network Load Balancer. The specified security groups override the previously associated
    /// security groups.
    /// 
    ///  
    /// <para>
    /// You can't perform this operation on a Network Load Balancer unless you specified a
    /// security group for the load balancer when you created it.
    /// </para>
    ///  
    /// <para>
    /// You can't associate a security group with a Gateway Load Balancer.
    /// </para>
    /// </summary>
    public partial class SetSecurityGroupsRequest : AmazonElasticLoadBalancingV2Request
    {
        private EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum _enforceSecurityGroupInboundRulesOnPrivateLinkTraffic;
        private string _loadBalancerArn;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic. 
        /// <para>
        /// Indicates whether to evaluate inbound security group rules for traffic sent to a Network
        /// Load Balancer through Amazon Web Services PrivateLink. The default is <c>on</c>.
        /// </para>
        /// </summary>
        public EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
        {
            get { return this._enforceSecurityGroupInboundRulesOnPrivateLinkTraffic; }
            set { this._enforceSecurityGroupInboundRulesOnPrivateLinkTraffic = value; }
        }

        // Check to see if EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic property is set
        internal bool IsSetEnforceSecurityGroupInboundRulesOnPrivateLinkTraffic()
        {
            return this._enforceSecurityGroupInboundRulesOnPrivateLinkTraffic != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The IDs of the security groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}