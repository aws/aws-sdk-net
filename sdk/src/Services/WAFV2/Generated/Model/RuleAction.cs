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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
        private AllowAction _allow;
        private BlockAction _block;
        private CaptchaAction _captcha;
        private ChallengeAction _challenge;
        private CountAction _count;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        /// Instructs WAF to allow the web request.
        /// </para>
        /// </summary>
        public AllowAction Allow
        {
            get { return this._allow; }
            set { this._allow = value; }
        }

        // Check to see if Allow property is set
        internal bool IsSetAllow()
        {
            return this._allow != null;
        }

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// Instructs WAF to block the web request.
        /// </para>
        /// </summary>
        public BlockAction Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null;
        }

        /// <summary>
        /// Gets and sets the property Captcha. 
        /// <para>
        /// Instructs WAF to run a <c>CAPTCHA</c> check against the web request.
        /// </para>
        /// </summary>
        public CaptchaAction Captcha
        {
            get { return this._captcha; }
            set { this._captcha = value; }
        }

        // Check to see if Captcha property is set
        internal bool IsSetCaptcha()
        {
            return this._captcha != null;
        }

        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// Instructs WAF to run a <c>Challenge</c> check against the web request.
        /// </para>
        /// </summary>
        public ChallengeAction Challenge
        {
            get { return this._challenge; }
            set { this._challenge = value; }
        }

        // Check to see if Challenge property is set
        internal bool IsSetChallenge()
        {
            return this._challenge != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// Instructs WAF to count the web request and then continue evaluating the request using
        /// the remaining rules in the web ACL.
        /// </para>
        /// </summary>
        public CountAction Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count != null;
        }

    }
}