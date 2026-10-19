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
    /// The action that WAF should take on a web request when it matches a rule's statement.
    /// Settings at the web ACL level can override the rule action setting.
    /// </summary>
    public partial class RuleAction
    {
        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Instructs WAF to allow the web request.
        /// </para>
        /// </summary>
        public AllowAction Allow { get; set; }

        /// <summary>
        /// Checks to see if the Allow property is set.
        /// </summary>
        internal bool IsSetAllow() => this.Allow != null;

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// Instructs WAF to block the web request.
        /// </para>
        /// </summary>
        public BlockAction Block { get; set; }

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block != null;

        /// <summary>
        /// Gets and sets the property Captcha. 
        /// <para>
        /// Instructs WAF to run a <c>CAPTCHA</c> check against the web request.
        /// </para>
        /// </summary>
        public CaptchaAction Captcha { get; set; }

        /// <summary>
        /// Checks to see if the Captcha property is set.
        /// </summary>
        internal bool IsSetCaptcha() => this.Captcha != null;

        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// Instructs WAF to run a <c>Challenge</c> check against the web request.
        /// </para>
        /// </summary>
        public ChallengeAction Challenge { get; set; }

        /// <summary>
        /// Checks to see if the Challenge property is set.
        /// </summary>
        internal bool IsSetChallenge() => this.Challenge != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// Instructs WAF to count the web request and then continue evaluating the request using
        /// the remaining rules in the web ACL.
        /// </para>
        /// </summary>
        public CountAction Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count != null;

        /// <summary>
        /// Gets and sets the property Monetize. 
        /// <para>
        /// Instructs WAF to return an HTTP 402 Payment Required response with a price manifest.
        /// The requesting client can complete payment and resubmit the request to gain access.
        /// This is a terminating action-requests that do not complete payment are blocked. This
        /// action is available only for web ACLs associated with Amazon CloudFront distributions
        /// and requires a <c>MonetizationConfig</c> on the web ACL.
        /// </para>
        /// </summary>
        public MonetizeAction Monetize { get; set; }

        /// <summary>
        /// Checks to see if the Monetize property is set.
        /// </summary>
        internal bool IsSetMonetize() => this.Monetize != null;
    }
}
