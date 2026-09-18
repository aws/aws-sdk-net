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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains information about a stickiness policy that was created using <c>CreateLBCookieStickinessPolicy</c>.
    /// </summary>
    public partial class AwsElbLbCookieStickinessPolicy
    {
        /// <summary>
        /// Gets and sets the property CookieExpirationPeriod. 
        /// <para>
        /// The amount of time, in seconds, after which the cookie is considered stale. If an
        /// expiration period is not specified, the stickiness session lasts for the duration
        /// of the browser session.
        /// </para>
        /// </summary>
        public long? CookieExpirationPeriod { get; set; }

        /// <summary>
        /// Checks to see if the CookieExpirationPeriod property is set.
        /// </summary>
        internal bool IsSetCookieExpirationPeriod() => this.CookieExpirationPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy. The name must be unique within the set of policies for the
        /// load balancer.
        /// </para>
        /// </summary>
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
