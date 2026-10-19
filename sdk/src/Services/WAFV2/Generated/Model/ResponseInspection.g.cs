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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The criteria for inspecting responses to login requests and account creation requests,
    /// used by the ATP and ACFP rule groups to track login and account creation success and
    /// failure rates. 
    /// 
    ///  <note> 
    /// <para>
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront distributions.
    /// </para>
    ///  </note> 
    /// <para>
    /// The rule groups evaluates the responses that your protected resources send back to
    /// client login and account creation attempts, keeping count of successful and failed
    /// attempts from each IP address and client session. Using this information, the rule
    /// group labels and mitigates requests from client sessions and IP addresses with too
    /// much suspicious activity in a short amount of time. 
    /// </para>
    ///  
    /// <para>
    /// This is part of the <c>AWSManagedRulesATPRuleSet</c> and <c>AWSManagedRulesACFPRuleSet</c>
    /// configurations in <c>ManagedRuleGroupConfig</c>.
    /// </para>
    ///  
    /// <para>
    /// Enable response inspection by configuring exactly one component of the response to
    /// inspect, for example, <c>Header</c> or <c>StatusCode</c>. You can't configure more
    /// than one component for inspection. If you don't configure any of the response inspection
    /// options, response inspection is disabled. 
    /// </para>
    /// </summary>
    public partial class ResponseInspection
    {
        /// <summary>
        /// Gets and sets the property BodyContains. 
        /// <para>
        /// Configures inspection of the response body for success and failure indicators. WAF
        /// can inspect the first 65,536 bytes (64 KB) of the response body. 
        /// </para>
        /// </summary>
        public ResponseInspectionBodyContains BodyContains { get; set; }

        /// <summary>
        /// Checks to see if the BodyContains property is set.
        /// </summary>
        internal bool IsSetBodyContains() => this.BodyContains != null;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Configures inspection of the response header for success and failure indicators. 
        /// </para>
        /// </summary>
        public ResponseInspectionHeader Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header != null;

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// Configures inspection of the response JSON for success and failure indicators. WAF
        /// can inspect the first 65,536 bytes (64 KB) of the response JSON. 
        /// </para>
        /// </summary>
        public ResponseInspectionJson Json { get; set; }

        /// <summary>
        /// Checks to see if the Json property is set.
        /// </summary>
        internal bool IsSetJson() => this.Json != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Configures inspection of the response status code for success and failure indicators.
        /// 
        /// </para>
        /// </summary>
        public ResponseInspectionStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;
    }
}
