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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// The provider sends the secret as the value of an HTTP header.
    /// </summary>
    public partial class WebhookStaticTokenAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property SecretValue. 
        /// <para>
        /// The token the provider sends in the header. If you omit it, EventBridge generates
        /// one. EventBridge stores the token only in AWS Secrets Manager and never returns it,
        /// including from DescribeEventSource. EventBridge compares it against the entire header
        /// value, so a provider that sends Authorization: Bearer &lt;token&gt; needs SecretValue
        /// to include the "Bearer " prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string SecretValue { get; set; }

        /// <summary>
        /// Checks to see if the SecretValue property is set.
        /// </summary>
        internal bool IsSetSecretValue() => this.SecretValue != null;

        /// <summary>
        /// Gets and sets the property TokenHttpHeader. 
        /// <para>
        /// The name of the header that carries the secret, for example X-Webhook-Secret. Reserved
        /// names are rejected: the names EventBridge's edge writes, such as Host and the X-Forwarded-*
        /// family, and the hop-by-hop and framing names an HTTP intermediary may rewrite, such
        /// as Connection and Content-Length. Authorization is allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string TokenHttpHeader { get; set; }

        /// <summary>
        /// Checks to see if the TokenHttpHeader property is set.
        /// </summary>
        internal bool IsSetTokenHttpHeader() => this.TokenHttpHeader != null;
    }
}
