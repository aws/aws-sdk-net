/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-25
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Generates a stickiness policy with sticky session lifetimes that follow
    /// that of an application-generated cookie. This policy can only be associated
    /// with HTTP listeners.
    ///
    /// This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
    /// except that the lifetime of the special Elastic Load Balancing cookie follows the
    /// lifetime of the application-generated cookie specified in the policy configuration.
    /// The load balancer only inserts a new stickiness cookie when the application response
    /// includes a new application cookie.
    ///
    /// If the application cookie is explicitly removed or expires, the session stops being
    /// sticky until a new application cookie is issued.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class CreateAppCookieStickinessPolicyRequest
    {
        private string loadBalancerNameField;
        private string policyNameField;
        private string cookieNameField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The name associated with the LoadBalancer.
        /// The name must be unique within the client AWS account.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerName")]
        public string LoadBalancerName
        {
            get { return this.loadBalancerNameField; }
            set { this.loadBalancerNameField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The name associated with the LoadBalancer.
        /// The name must be unique within the client AWS account.</param>
        /// <returns>this instance</returns>
        public CreateAppCookieStickinessPolicyRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerNameField = loadBalancerName;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerName property is set
        /// </summary>
        /// <returns>true if LoadBalancerName property is set</returns>
        public bool IsSetLoadBalancerName()
        {
            return this.loadBalancerNameField != null;
        }

        /// <summary>
        /// Gets and sets the PolicyName property.
        /// The name of the policy being created.
        /// The name must be unique within the set of policies for this Load Balancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "PolicyName")]
        public string PolicyName
        {
            get { return this.policyNameField; }
            set { this.policyNameField = value; }
        }

        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The name of the policy being created.
        /// The name must be unique within the set of policies for this Load Balancer.</param>
        /// <returns>this instance</returns>
        public CreateAppCookieStickinessPolicyRequest WithPolicyName(string policyName)
        {
            this.policyNameField = policyName;
            return this;
        }

        /// <summary>
        /// Checks if PolicyName property is set
        /// </summary>
        /// <returns>true if PolicyName property is set</returns>
        public bool IsSetPolicyName()
        {
            return this.policyNameField != null;
        }

        /// <summary>
        /// Gets and sets the CookieName property.
        /// Name of the application cookie used for stickiness.
        /// </summary>
        [XmlElementAttribute(ElementName = "CookieName")]
        public string CookieName
        {
            get { return this.cookieNameField; }
            set { this.cookieNameField = value; }
        }

        /// <summary>
        /// Sets the CookieName property
        /// </summary>
        /// <param name="cookieName">Name of the application cookie used for stickiness.</param>
        /// <returns>this instance</returns>
        public CreateAppCookieStickinessPolicyRequest WithCookieName(string cookieName)
        {
            this.cookieNameField = cookieName;
            return this;
        }

        /// <summary>
        /// Checks if CookieName property is set
        /// </summary>
        /// <returns>true if CookieName property is set</returns>
        public bool IsSetCookieName()
        {
            return this.cookieNameField != null;
        }

    }
}
