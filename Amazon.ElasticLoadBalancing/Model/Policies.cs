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
    ///Specifies the list of Application and Load Balancer Cookie
    ///Stickiness policies for the Load Balancer.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class Policies
    {
        private List<AppCookieStickinessPolicy> appCookieStickinessPoliciesField;
        private List<LBCookieStickinessPolicy> LBCookieStickinessPoliciesField;

        /// <summary>
        /// Gets and sets the AppCookieStickinessPolicies property.
        /// A list of the Application Cookie Stickiness Policies associated with a Load Balancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "AppCookieStickinessPolicies")]
        public List<AppCookieStickinessPolicy> AppCookieStickinessPolicies
        {
            get
            {
                if (this.appCookieStickinessPoliciesField == null)
                {
                    this.appCookieStickinessPoliciesField = new List<AppCookieStickinessPolicy>();
                }
                return this.appCookieStickinessPoliciesField;
            }
            set { this.appCookieStickinessPoliciesField = value; }
        }

        /// <summary>
        /// Sets the AppCookieStickinessPolicies property
        /// </summary>
        /// <param name="list">A list of the Application Cookie Stickiness Policies associated with a Load Balancer.</param>
        /// <returns>this instance</returns>
        public Policies WithAppCookieStickinessPolicies(params AppCookieStickinessPolicy[] list)
        {
            foreach (AppCookieStickinessPolicy item in list)
            {
                AppCookieStickinessPolicies.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AppCookieStickinessPolicies property is set
        /// </summary>
        /// <returns>true if AppCookieStickinessPolicies property is set</returns>
        public bool IsSetAppCookieStickinessPolicies()
        {
            return (AppCookieStickinessPolicies.Count > 0);
        }

        /// <summary>
        /// Gets and sets the LBCookieStickinessPolicies property.
        /// A list of the Load Balancer Cookie Stickiness Policies associated with a Load Balancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "LBCookieStickinessPolicies")]
        public List<LBCookieStickinessPolicy> LBCookieStickinessPolicies
        {
            get
            {
                if (this.LBCookieStickinessPoliciesField == null)
                {
                    this.LBCookieStickinessPoliciesField = new List<LBCookieStickinessPolicy>();
                }
                return this.LBCookieStickinessPoliciesField;
            }
            set { this.LBCookieStickinessPoliciesField = value; }
        }

        /// <summary>
        /// Sets the LBCookieStickinessPolicies property
        /// </summary>
        /// <param name="list">A list of the Load Balancer Cookie Stickiness Policies associated with a Load Balancer.</param>
        /// <returns>this instance</returns>
        public Policies WithLBCookieStickinessPolicies(params LBCookieStickinessPolicy[] list)
        {
            foreach (LBCookieStickinessPolicy item in list)
            {
                LBCookieStickinessPolicies.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LBCookieStickinessPolicies property is set
        /// </summary>
        /// <returns>true if LBCookieStickinessPolicies property is set</returns>
        public bool IsSetLBCookieStickinessPolicies()
        {
            return (LBCookieStickinessPolicies.Count > 0);
        }

    }
}
