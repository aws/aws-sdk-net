/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLBCookieStickinessPolicy operation.
    /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
    /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a load balancer implements this policy,
    /// the load balancer uses a special cookie to track the backend server instance for each request. When the load balancer receives a request, it
    /// first checks to see if this cookie is present in the request. If so, the load balancer sends the request to the application server specified
    /// in the cookie. If not, the load balancer sends the request to a server that is chosen based on the existing load balancing algorithm.
    /// </para> <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the
    /// cookie is based on the cookie expiration time, which is specified in the policy configuration. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsLBCookies"
    /// >Enabling Duration-Based Session Stickiness</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class CreateLBCookieStickinessPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private string policyName;
        private long? cookieExpirationPeriod;

        /// <summary>
        /// Default constructor for a new CreateLBCookieStickinessPolicyRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateLBCookieStickinessPolicyRequest() {}
    
        /// <summary>
        /// Constructs a new CreateLBCookieStickinessPolicyRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="policyName"> The name of the policy being created. The name must be unique within the set of policies for this load balancer.
        /// </param>
        public CreateLBCookieStickinessPolicyRequest(string loadBalancerName, string policyName)
        {
            this.loadBalancerName = loadBalancerName;
            this.policyName = policyName;
        }
    

        /// <summary>
        /// The name associated with the load balancer.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;
        }

        /// <summary>
        /// The name of the policy being created. The name must be unique within the set of policies for this load balancer.
        ///  
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;
        }

        /// <summary>
        /// The time period in seconds after which the cookie should be considered stale. Not specifying this parameter indicates that the sticky
        /// session will last for the duration of the browser session.
        ///  
        /// </summary>
        public long CookieExpirationPeriod
        {
            get { return this.cookieExpirationPeriod ?? default(long); }
            set { this.cookieExpirationPeriod = value; }
        }

        // Check to see if CookieExpirationPeriod property is set
        internal bool IsSetCookieExpirationPeriod()
        {
            return this.cookieExpirationPeriod.HasValue;
        }

    }
}
    
