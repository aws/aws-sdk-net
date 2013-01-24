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
    /// Container for the parameters to the CreateAppCookieStickinessPolicy operation.
    /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
    /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
    /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
    /// the policy configuration. The LoadBalancer only inserts a new stickiness cookie when the application response includes a new application
    /// cookie. </para> <para> If the application cookie is explicitly removed or expires, the session stops being sticky until a new application
    /// cookie is issued. </para> <para><b>NOTE:</b> An application client must receive and send two cookies: the application-generated cookie and
    /// the special Elastic Load Balancing cookie named AWSELB. This is the default behavior for many common web browsers. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.CreateAppCookieStickinessPolicy"/>
    public class CreateAppCookieStickinessPolicyRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private string policyName;
        private string cookieName;
        /// <summary>
        /// Default constructor for a new CreateAppCookieStickinessPolicyRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public CreateAppCookieStickinessPolicyRequest() {}
    
        /// <summary>
        /// Constructs a new CreateAppCookieStickinessPolicyRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the LoadBalancer. The name must be unique within the client AWS account. </param>
        /// <param name="policyName"> The name of the policy being created. The name must be unique within the set of policies for this LoadBalancer.
        /// </param>
        /// <param name="cookieName"> Name of the application cookie used for stickiness. </param>
        public CreateAppCookieStickinessPolicyRequest(string loadBalancerName, string policyName, string cookieName) 
        {
            this.loadBalancerName = loadBalancerName;
            this.policyName = policyName;
            this.cookieName = cookieName;
        }
    

        /// <summary>
        /// The name associated with the LoadBalancer. The name must be unique within the client AWS account.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        public CreateAppCookieStickinessPolicyRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// The name of the policy being created. The name must be unique within the set of policies for this LoadBalancer.
        ///  
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The value to set for the PolicyName property </param>
        /// <returns>this instance</returns>
        public CreateAppCookieStickinessPolicyRequest WithPolicyName(string policyName)
        {
            this.policyName = policyName;
            return this;
        }
            

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;       
        }

        /// <summary>
        /// Name of the application cookie used for stickiness.
        ///  
        /// </summary>
        public string CookieName
        {
            get { return this.cookieName; }
            set { this.cookieName = value; }
        }

        /// <summary>
        /// Sets the CookieName property
        /// </summary>
        /// <param name="cookieName">The value to set for the CookieName property </param>
        /// <returns>this instance</returns>
        public CreateAppCookieStickinessPolicyRequest WithCookieName(string cookieName)
        {
            this.cookieName = cookieName;
            return this;
        }
            

        // Check to see if CookieName property is set
        internal bool IsSetCookieName()
        {
            return this.cookieName != null;       
        }
    }
}
    
