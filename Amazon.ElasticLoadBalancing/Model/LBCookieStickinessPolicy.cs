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
    ///<summary>
    ///Defines a stickiness policy with sticky session lifetimes controlled by the
    ///lifetime of the browser (user-agent) or a specified expiration period. This
    ///policy can only be associated only with HTTP listeners.
    ///
    ///When a load balancer implements this policy, the load balancer uses a special
    ///cookie to track the backend server instance for each request. When the load balancer
    ///receives a request, it first checks to see if this cookie is present in the request.
    ///If so, the load balancer sends the request to the application server specified in the
    ///cookie. If not, the load balancer sends the request to a server that is chosen based on
    ///the existing load balancing algorithm.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class LBCookieStickinessPolicy
    {
        private string policyNameField;
        private Decimal? cookieExpirationPeriodField;

        /// <summary>
        /// Gets and sets the PolicyName property.
        /// The mnemonic name for the policy being created. The name must be unique within the
        /// set of policies for this Load Balancer.
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
        /// <param name="policyName">The mnemonic name for the policy being created. The name must be unique within the
        /// set of policies for this Load Balancer.</param>
        /// <returns>this instance</returns>
        public LBCookieStickinessPolicy WithPolicyName(string policyName)
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
        /// Gets and sets the CookieExpirationPeriod property.
        /// The time period in seconds after which the cookie should be considered stale.
        /// Not specifying this parameter indicates that the sticky session will last for the duration of the browser session.
        /// </summary>
        [XmlElementAttribute(ElementName = "CookieExpirationPeriod")]
        public Decimal CookieExpirationPeriod
        {
            get { return this.cookieExpirationPeriodField.GetValueOrDefault(); }
            set { this.cookieExpirationPeriodField = value; }
        }

        /// <summary>
        /// Sets the CookieExpirationPeriod property
        /// </summary>
        /// <param name="cookieExpirationPeriod">The time period in seconds after which the cookie should be considered stale.
        /// Not specifying this parameter indicates that the sticky session will last for the duration of the browser session.</param>
        /// <returns>this instance</returns>
        public LBCookieStickinessPolicy WithCookieExpirationPeriod(Decimal cookieExpirationPeriod)
        {
            this.cookieExpirationPeriodField = cookieExpirationPeriod;
            return this;
        }

        /// <summary>
        /// Checks if CookieExpirationPeriod property is set
        /// </summary>
        /// <returns>true if CookieExpirationPeriod property is set</returns>
        public bool IsSetCookieExpirationPeriod()
        {
            return this.cookieExpirationPeriodField.HasValue;
        }

    }
}
