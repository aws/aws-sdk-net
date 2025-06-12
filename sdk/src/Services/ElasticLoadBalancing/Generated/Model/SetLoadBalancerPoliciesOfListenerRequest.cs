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
    /// Container for the parameters to the SetLoadBalancerPoliciesOfListener operation.
    /// Replaces the current set of policies for the specified load balancer port with the
    /// specified set of policies.
    /// 
    ///  
    /// <para>
    /// To enable back-end server authentication, use <a>SetLoadBalancerPoliciesForBackendServer</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about setting policies, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/ssl-config-update.html">Update
    /// the SSL Negotiation Configuration</a>, <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-duration">Duration-Based
    /// Session Stickiness</a>, and <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-application">Application-Controlled
    /// Session Stickiness</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class SetLoadBalancerPoliciesOfListenerRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private int? _loadBalancerPort;
        private List<string> _policyNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetLoadBalancerPoliciesOfListenerRequest() { }

        /// <summary>
        /// Instantiates SetLoadBalancerPoliciesOfListenerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="loadBalancerPort">The external port of the load balancer.</param>
        /// <param name="policyNames">The names of the policies. This list must include all policies to be enabled. If you omit a policy that is currently enabled, it is disabled. If the list is empty, all current policies are disabled.</param>
        public SetLoadBalancerPoliciesOfListenerRequest(string loadBalancerName, int? loadBalancerPort, List<string> policyNames)
        {
            _loadBalancerName = loadBalancerName;
            _loadBalancerPort = loadBalancerPort;
            _policyNames = policyNames;
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
        /// Gets and sets the property LoadBalancerPort. 
        /// <para>
        /// The external port of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? LoadBalancerPort
        {
            get { return this._loadBalancerPort; }
            set { this._loadBalancerPort = value; }
        }

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this._loadBalancerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// The names of the policies. This list must include all policies to be enabled. If you
        /// omit a policy that is currently enabled, it is disabled. If the list is empty, all
        /// current policies are disabled.
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