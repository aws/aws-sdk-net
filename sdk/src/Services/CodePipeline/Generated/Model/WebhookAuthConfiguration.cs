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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The authentication applied to incoming webhook trigger requests.
    /// </summary>
    public partial class WebhookAuthConfiguration
    {
        private string _allowedIPRange;
        private string _secretToken;

        /// <summary>
        /// Gets and sets the property AllowedIPRange. 
        /// <para>
        /// The property used to configure acceptance of webhooks in an IP address range. For
        /// IP, only the <c>AllowedIPRange</c> property must be set. This property must be set
        /// to a valid CIDR range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AllowedIPRange
        {
            get { return this._allowedIPRange; }
            set { this._allowedIPRange = value; }
        }

        // Check to see if AllowedIPRange property is set
        internal bool IsSetAllowedIPRange()
        {
            return this._allowedIPRange != null;
        }

        /// <summary>
        /// Gets and sets the property SecretToken. 
        /// <para>
        /// The property used to configure GitHub authentication. For GITHUB_HMAC, only the <c>SecretToken</c>
        /// property must be set.
        /// </para>
        ///  <important> 
        /// <para>
        /// When creating CodePipeline webhooks, do not use your own credentials or reuse the
        /// same secret token across multiple webhooks. For optimal security, generate a unique
        /// secret token for each webhook you create. The secret token is an arbitrary string
        /// that you provide, which GitHub uses to compute and sign the webhook payloads sent
        /// to CodePipeline, for protecting the integrity and authenticity of the webhook payloads.
        /// Using your own credentials or reusing the same token across multiple webhooks can
        /// lead to security vulnerabilities.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If a secret token was provided, it will be redacted in the response.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SecretToken
        {
            get { return this._secretToken; }
            set { this._secretToken = value; }
        }

        // Check to see if SecretToken property is set
        internal bool IsSetSecretToken()
        {
            return this._secretToken != null;
        }

    }
}