/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The LBCookieStickinessPolicy data type.
    /// </summary>
    public partial class LBCookieStickinessPolicy
    {
        private long? _cookieExpirationPeriod;
        private string _policyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public LBCookieStickinessPolicy() { }

        /// <summary>
        /// Instantiates LBCookieStickinessPolicy with the parameterized properties
        /// </summary>
        /// <param name="policyName">The name for the policy being created. The name must be unique within the set of policies for this load balancer. </param>
        /// <param name="cookieExpirationPeriod">The time period in seconds after which the cookie should be considered stale. Not specifying this parameter indicates that the stickiness session will last for the duration of the browser session. </param>
        public LBCookieStickinessPolicy(string policyName, long cookieExpirationPeriod)
        {
            _policyName = policyName;
            _cookieExpirationPeriod = cookieExpirationPeriod;
        }

        /// <summary>
        /// Gets and sets the property CookieExpirationPeriod. 
        /// <para>
        /// The time period in seconds after which the cookie should be considered stale. Not
        /// specifying this parameter indicates that the stickiness session will last for the
        /// duration of the browser session. 
        /// </para>
        /// </summary>
        public long CookieExpirationPeriod
        {
            get { return this._cookieExpirationPeriod.GetValueOrDefault(); }
            set { this._cookieExpirationPeriod = value; }
        }

        // Check to see if CookieExpirationPeriod property is set
        internal bool IsSetCookieExpirationPeriod()
        {
            return this._cookieExpirationPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name for the policy being created. The name must be unique within the set of policies
        /// for this load balancer. 
        /// </para>
        /// </summary>
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