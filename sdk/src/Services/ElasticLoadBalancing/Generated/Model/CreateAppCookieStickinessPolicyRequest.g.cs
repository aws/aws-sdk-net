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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateAppCookieStickinessPolicy operation. Generates
    /// a stickiness policy with sticky session lifetimes that follow that of an application-generated
    /// cookie. This policy can be associated only with HTTP/HTTPS listeners. <para> This
    /// policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
    /// except that the lifetime of the special Elastic Load Balancing cookie, <c>AWSELB</c>,
    /// follows the lifetime of the application-generated cookie specified in the policy configuration.
    /// The load balancer only inserts a new stickiness cookie when the application response
    /// includes a new application cookie. </para> <para> If the application cookie is explicitly
    /// removed or expires, the session stops being sticky until a new application cookie
    /// is issued. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-application">Application-Controlled
    /// Session Stickiness</a> in the <i>Classic Load Balancers Guide</i>. </para>
    /// </summary>
    public partial class CreateAppCookieStickinessPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateAppCookieStickinessPolicyRequest() { }

        /// <summary>
        /// Instantiates CreateAppCookieStickinessPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="policyName">The name of the policy being created. Policy names must consist of alphanumeric characters and dashes (-). This name must be unique within the set of policies for this load balancer.</param>
        /// <param name="cookieName">The name of the application cookie used for stickiness.</param>
        public CreateAppCookieStickinessPolicyRequest(string loadBalancerName, string policyName, string cookieName)
        {
            this.LoadBalancerName = loadBalancerName;
            this.PolicyName = policyName;
            this.CookieName = cookieName;
        }

        /// <summary>
        /// Gets and sets the property CookieName. 
        /// <para>
        /// The name of the application cookie used for stickiness.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CookieName { get; set; }

        /// <summary>
        /// Checks to see if the CookieName property is set.
        /// </summary>
        internal bool IsSetCookieName() => this.CookieName != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy being created. Policy names must consist of alphanumeric characters
        /// and dashes (-). This name must be unique within the set of policies for this load
        /// balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
