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
    /// Contains information about the policies for a load balancer.
    /// </summary>
    public partial class AwsElbLoadBalancerPolicies
    {
        /// <summary>
        /// Gets and sets the property AppCookieStickinessPolicies. 
        /// <para>
        /// The stickiness policies that are created using <c>CreateAppCookieStickinessPolicy</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbAppCookieStickinessPolicy> AppCookieStickinessPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElbAppCookieStickinessPolicy>() : null;

        /// <summary>
        /// Checks to see if the AppCookieStickinessPolicies property is set.
        /// </summary>
        internal bool IsSetAppCookieStickinessPolicies() => this.AppCookieStickinessPolicies != null && (this.AppCookieStickinessPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LbCookieStickinessPolicies. 
        /// <para>
        /// The stickiness policies that are created using <c>CreateLBCookieStickinessPolicy</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElbLbCookieStickinessPolicy> LbCookieStickinessPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElbLbCookieStickinessPolicy>() : null;

        /// <summary>
        /// Checks to see if the LbCookieStickinessPolicies property is set.
        /// </summary>
        internal bool IsSetLbCookieStickinessPolicies() => this.LbCookieStickinessPolicies != null && (this.LbCookieStickinessPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OtherPolicies. 
        /// <para>
        /// The policies other than the stickiness policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OtherPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OtherPolicies property is set.
        /// </summary>
        internal bool IsSetOtherPolicies() => this.OtherPolicies != null && (this.OtherPolicies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
