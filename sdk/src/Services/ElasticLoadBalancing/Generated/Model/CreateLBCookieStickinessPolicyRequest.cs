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
    /// Container for the parameters to the CreateLBCookieStickinessPolicy operation.
    /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime
    /// of the browser (user-agent) or a specified expiration period. This policy can be associated
    /// only with HTTP/HTTPS listeners.
    /// 
    ///  
    /// <para>
    /// When a load balancer implements this policy, the load balancer uses a special cookie
    /// to track the instance for each request. When the load balancer receives a request,
    /// it first checks to see if this cookie is present in the request. If so, the load balancer
    /// sends the request to the application server specified in the cookie. If not, the load
    /// balancer sends the request to a server that is chosen based on the existing load-balancing
    /// algorithm.
    /// </para>
    ///  
    /// <para>
    /// A cookie is inserted into the response for binding subsequent requests from the same
    /// user to that server. The validity of the cookie is based on the cookie expiration
    /// time, which is specified in the policy configuration.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-duration">Duration-Based
    /// Session Stickiness</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLBCookieStickinessPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        private long? _cookieExpirationPeriod;
        private string _loadBalancerName;
        private string _policyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLBCookieStickinessPolicyRequest() { }

        /// <summary>
        /// Instantiates CreateLBCookieStickinessPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="policyName">The name of the policy being created. Policy names must consist of alphanumeric characters and dashes (-). This name must be unique within the set of policies for this load balancer.</param>
        public CreateLBCookieStickinessPolicyRequest(string loadBalancerName, string policyName)
        {
            _loadBalancerName = loadBalancerName;
            _policyName = policyName;
        }

        /// <summary>
        /// Gets and sets the property CookieExpirationPeriod. 
        /// <para>
        /// The time period, in seconds, after which the cookie should be considered stale. If
        /// you do not specify this parameter, the default value is 0, which indicates that the
        /// sticky session should last for the duration of the browser session.
        /// </para>
        /// </summary>
        public long? CookieExpirationPeriod
        {
            get { return this._cookieExpirationPeriod; }
            set { this._cookieExpirationPeriod = value; }
        }

        // Check to see if CookieExpirationPeriod property is set
        internal bool IsSetCookieExpirationPeriod()
        {
            return this._cookieExpirationPeriod.HasValue; 
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
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy being created. Policy names must consist of alphanumeric characters
        /// and dashes (-). This name must be unique within the set of policies for this load
        /// balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}