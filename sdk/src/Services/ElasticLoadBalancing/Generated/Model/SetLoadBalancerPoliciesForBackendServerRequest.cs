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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the SetLoadBalancerPoliciesForBackendServer operation.
    /// Replaces the set of policies associated with the specified port on which the EC2 instance
    /// is listening with a new set of policies. At this time, only the back-end server authentication
    /// policy type can be applied to the instance ports; this policy type is composed of
    /// multiple public key policies.
    /// 
    ///  
    /// <para>
    /// Each time you use <c>SetLoadBalancerPoliciesForBackendServer</c> to enable the policies,
    /// use the <c>PolicyNames</c> parameter to list the policies that you want to enable.
    /// </para>
    ///  
    /// <para>
    /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> to
    /// verify that the policy is associated with the EC2 instance.
    /// </para>
    ///  
    /// <para>
    /// For more information about enabling back-end instance authentication, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-create-https-ssl-load-balancer.html#configure_backendauth_clt">Configure
    /// Back-end Instance Authentication</a> in the <i>Classic Load Balancers Guide</i>. For
    /// more information about Proxy Protocol, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-proxy-protocol.html">Configure
    /// Proxy Protocol Support</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetLoadBalancerPoliciesForBackendServerRequest : AmazonElasticLoadBalancingRequest
    {
        private int? _instancePort;
        private string _loadBalancerName;
        private List<string> _policyNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The port number associated with the EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InstancePort
        {
            get { return this._instancePort; }
            set { this._instancePort = value; }
        }

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this._instancePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// The names of the policies. If the list is empty, then all current polices are removed
        /// from the EC2 instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PolicyNames
        {
            get { return this._policyNames; }
            set { this._policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this._policyNames != null && (this._policyNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}