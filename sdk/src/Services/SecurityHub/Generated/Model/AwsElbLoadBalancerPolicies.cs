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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the policies for a load balancer.
    /// </summary>
    public partial class AwsElbLoadBalancerPolicies
    {
        private List<AwsElbAppCookieStickinessPolicy> _appCookieStickinessPolicies = new List<AwsElbAppCookieStickinessPolicy>();
        private List<AwsElbLbCookieStickinessPolicy> _lbCookieStickinessPolicies = new List<AwsElbLbCookieStickinessPolicy>();
        private List<string> _otherPolicies = new List<string>();

        /// <summary>
        /// Gets and sets the property AppCookieStickinessPolicies. 
        /// <para>
        /// The stickiness policies that are created using <code>CreateAppCookieStickinessPolicy</code>.
        /// </para>
        /// </summary>
        public List<AwsElbAppCookieStickinessPolicy> AppCookieStickinessPolicies
        {
            get { return this._appCookieStickinessPolicies; }
            set { this._appCookieStickinessPolicies = value; }
        }

        // Check to see if AppCookieStickinessPolicies property is set
        internal bool IsSetAppCookieStickinessPolicies()
        {
            return this._appCookieStickinessPolicies != null && this._appCookieStickinessPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LbCookieStickinessPolicies. 
        /// <para>
        /// The stickiness policies that are created using <code>CreateLBCookieStickinessPolicy</code>.
        /// </para>
        /// </summary>
        public List<AwsElbLbCookieStickinessPolicy> LbCookieStickinessPolicies
        {
            get { return this._lbCookieStickinessPolicies; }
            set { this._lbCookieStickinessPolicies = value; }
        }

        // Check to see if LbCookieStickinessPolicies property is set
        internal bool IsSetLbCookieStickinessPolicies()
        {
            return this._lbCookieStickinessPolicies != null && this._lbCookieStickinessPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OtherPolicies. 
        /// <para>
        /// The policies other than the stickiness policies.
        /// </para>
        /// </summary>
        public List<string> OtherPolicies
        {
            get { return this._otherPolicies; }
            set { this._otherPolicies = value; }
        }

        // Check to see if OtherPolicies property is set
        internal bool IsSetOtherPolicies()
        {
            return this._otherPolicies != null && this._otherPolicies.Count > 0; 
        }

    }
}