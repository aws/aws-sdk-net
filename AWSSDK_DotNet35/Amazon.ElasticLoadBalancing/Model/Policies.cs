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
        /// properties to initialize this object after creating it.
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

        // Check to see if OtherPolicies property is set
        internal bool IsSetOtherPolicies()
        {
            return this.otherPolicies.Count > 0;
        }
    }
}
