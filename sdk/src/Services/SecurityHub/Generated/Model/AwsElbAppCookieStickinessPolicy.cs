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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about a stickiness policy that was created using <c>CreateAppCookieStickinessPolicy</c>.
    /// </summary>
    public partial class AwsElbAppCookieStickinessPolicy
    {
        private string _cookieName;
        private string _policyName;

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
        /// The mnemonic name for the policy being created. The name must be unique within the
        /// set of policies for the load balancer.
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