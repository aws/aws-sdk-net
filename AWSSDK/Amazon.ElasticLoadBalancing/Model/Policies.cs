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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The policies data type. </para>
    /// </summary>
    public class Policies  
    {
        
        private List<AppCookieStickinessPolicy> appCookieStickinessPolicies = new List<AppCookieStickinessPolicy>();
        private List<LBCookieStickinessPolicy> lBCookieStickinessPolicies = new List<LBCookieStickinessPolicy>();
        private List<string> otherPolicies = new List<string>();
        /// <summary>
        /// Default constructor for a new Policies object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public Policies() {}
    

        /// <summary>
        /// A list of the <a>AppCookieStickinessPolicy</a> objects created with <a>CreateAppCookieStickinessPolicy</a>.
        ///  
        /// </summary>
        public List<AppCookieStickinessPolicy> AppCookieStickinessPolicies
        {
            get { return this.appCookieStickinessPolicies; }
            set { this.appCookieStickinessPolicies = value; }
        }
        /// <summary>
        /// Adds elements to the AppCookieStickinessPolicies collection
        /// </summary>
        /// <param name="appCookieStickinessPolicies">The values to add to the AppCookieStickinessPolicies collection </param>
        /// <returns>this instance</returns>
        public Policies WithAppCookieStickinessPolicies(params AppCookieStickinessPolicy[] appCookieStickinessPolicies)
        {
            foreach (AppCookieStickinessPolicy element in appCookieStickinessPolicies)
            {
                this.appCookieStickinessPolicies.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AppCookieStickinessPolicies collection
        /// </summary>
        /// <param name="appCookieStickinessPolicies">The values to add to the AppCookieStickinessPolicies collection </param>
        /// <returns>this instance</returns>
        public Policies WithAppCookieStickinessPolicies(IEnumerable<AppCookieStickinessPolicy> appCookieStickinessPolicies)
        {
            foreach (AppCookieStickinessPolicy element in appCookieStickinessPolicies)
            {
                this.appCookieStickinessPolicies.Add(element);
            }

            return this;
        }

        // Check to see if AppCookieStickinessPolicies property is set
        internal bool IsSetAppCookieStickinessPolicies()
        {
            return this.appCookieStickinessPolicies.Count > 0;       
        }

        /// <summary>
        /// A list of <a>LBCookieStickinessPolicy</a> objects created with <a>CreateAppCookieStickinessPolicy</a>.
        ///  
        /// </summary>
        public List<LBCookieStickinessPolicy> LBCookieStickinessPolicies
        {
            get { return this.lBCookieStickinessPolicies; }
            set { this.lBCookieStickinessPolicies = value; }
        }
        /// <summary>
        /// Adds elements to the LBCookieStickinessPolicies collection
        /// </summary>
        /// <param name="lBCookieStickinessPolicies">The values to add to the LBCookieStickinessPolicies collection </param>
        /// <returns>this instance</returns>
        public Policies WithLBCookieStickinessPolicies(params LBCookieStickinessPolicy[] lBCookieStickinessPolicies)
        {
            foreach (LBCookieStickinessPolicy element in lBCookieStickinessPolicies)
            {
                this.lBCookieStickinessPolicies.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the LBCookieStickinessPolicies collection
        /// </summary>
        /// <param name="lBCookieStickinessPolicies">The values to add to the LBCookieStickinessPolicies collection </param>
        /// <returns>this instance</returns>
        public Policies WithLBCookieStickinessPolicies(IEnumerable<LBCookieStickinessPolicy> lBCookieStickinessPolicies)
        {
            foreach (LBCookieStickinessPolicy element in lBCookieStickinessPolicies)
            {
                this.lBCookieStickinessPolicies.Add(element);
            }

            return this;
        }

        // Check to see if LBCookieStickinessPolicies property is set
        internal bool IsSetLBCookieStickinessPolicies()
        {
            return this.lBCookieStickinessPolicies.Count > 0;       
        }

        /// <summary>
        /// A list of policy names other than the stickiness policies.
        ///  
        /// </summary>
        public List<string> OtherPolicies
        {
            get { return this.otherPolicies; }
            set { this.otherPolicies = value; }
        }
        /// <summary>
        /// Adds elements to the OtherPolicies collection
        /// </summary>
        /// <param name="otherPolicies">The values to add to the OtherPolicies collection </param>
        /// <returns>this instance</returns>
        public Policies WithOtherPolicies(params string[] otherPolicies)
        {
            foreach (string element in otherPolicies)
            {
                this.otherPolicies.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the OtherPolicies collection
        /// </summary>
        /// <param name="otherPolicies">The values to add to the OtherPolicies collection </param>
        /// <returns>this instance</returns>
        public Policies WithOtherPolicies(IEnumerable<string> otherPolicies)
        {
            foreach (string element in otherPolicies)
            {
                this.otherPolicies.Add(element);
            }

            return this;
        }

        // Check to see if OtherPolicies property is set
        internal bool IsSetOtherPolicies()
        {
            return this.otherPolicies.Count > 0;       
        }
    }
}
