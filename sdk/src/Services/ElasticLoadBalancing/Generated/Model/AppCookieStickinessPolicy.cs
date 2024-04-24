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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
    /// Information about a policy for application-controlled session stickiness.
    /// </summary>
    public partial class AppCookieStickinessPolicy
    {
        private string _cookieName;
        private string _policyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AppCookieStickinessPolicy() { }

        /// <summary>
        /// Instantiates AppCookieStickinessPolicy with the parameterized properties
        /// </summary>
        /// <param name="policyName">The mnemonic name for the policy being created. The name must be unique within a set of policies for this load balancer.</param>
        /// <param name="cookieName">The name of the application cookie used for stickiness.</param>
        public AppCookieStickinessPolicy(string policyName, string cookieName)
        {
            _policyName = policyName;
            _cookieName = cookieName;
        }

        /// <summary>
        /// Gets and sets the property CookieName. 
        /// <para>
        /// The name of the application cookie used for stickiness.
        /// </para>
        /// </summary>
        public string CookieName
        {
            get { return this._cookieName; }
            set { this._cookieName = value; }
        }

        // Check to see if CookieName property is set
        internal bool IsSetCookieName()
        {
            return this._cookieName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The mnemonic name for the policy being created. The name must be unique within a set
        /// of policies for this load balancer.
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