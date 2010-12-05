/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The LBCookieStickinessPolicy data type. </para>
    /// </summary>
    public class LBCookieStickinessPolicy  
    {
        
        private string policyName;
        private long? cookieExpirationPeriod;
        /// <summary>
        /// Default constructor for a new LBCookieStickinessPolicy object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public LBCookieStickinessPolicy() {}
    
        /// <summary>
        /// Constructs a new LBCookieStickinessPolicy object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="policyName"> The name name for the policy being created.
        /// The name must be unique within the set of policies for this
        /// LoadBalancer. </param>
        /// <param name="cookieExpirationPeriod"> The time period in seconds after
        /// which the cookie should be considered stale. Not specifying this
        /// parameter indicates that the sticky session will last for the duration
        /// of the browser session. </param>
        public LBCookieStickinessPolicy(string policyName, long cookieExpirationPeriod) 
        {
            this.policyName = policyName;
            this.cookieExpirationPeriod = cookieExpirationPeriod;
        }
    

        /// <summary>
        /// The name name for the policy being created. The name must be unique
        /// within the set of policies for this LoadBalancer.
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
        public LBCookieStickinessPolicy WithPolicyName(string policyName)
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
        /// The time period in seconds after which the cookie should be considered
        /// stale. Not specifying this parameter indicates that the sticky session
        /// will last for the duration of the browser session.
        ///  
        /// </summary>
        public long CookieExpirationPeriod
        {
            get { return this.cookieExpirationPeriod ?? default(long); }
            set { this.cookieExpirationPeriod = value; }
        }

        /// <summary>
        /// Sets the CookieExpirationPeriod property
        /// </summary>
        /// <param name="cookieExpirationPeriod">The value to set for the CookieExpirationPeriod property </param>
        /// <returns>this instance</returns>
        public LBCookieStickinessPolicy WithCookieExpirationPeriod(long cookieExpirationPeriod)
        {
            this.cookieExpirationPeriod = cookieExpirationPeriod;
            return this;
        }
            
        // Check to see if CookieExpirationPeriod property is set
        internal bool IsSetCookieExpirationPeriod()
        {
            return this.cookieExpirationPeriod.HasValue;        
        }
    }
}
