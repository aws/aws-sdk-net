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
    /// This is the response object from the SetSecurityGroups operation.
    /// </summary>
    public partial class SetSecurityGroupsResponse : AmazonWebServiceResponse
    {
        private EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum _enforceSecurityGroupInboundRulesOnPrivateLinkTraffic;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic. 
        /// <para>
        /// Indicates whether to evaluate inbound security group rules for traffic sent to a Network
        /// Load Balancer through Amazon Web Services PrivateLink.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the security groups associated with the load balancer.
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

    }
}