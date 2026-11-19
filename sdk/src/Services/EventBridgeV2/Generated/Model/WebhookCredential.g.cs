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
    /// A new webhook credential. Exactly one variant must be set.
    /// </summary>
    public partial class WebhookCredential
    {
        /// <summary>
        /// Gets and sets the property BasicHttpPassword. 
        /// <para>
        /// The new password for HTTP Basic authentication. The username does not change.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string BasicHttpPassword { get; set; }

        /// <summary>
        /// Checks to see if the BasicHttpPassword property is set.
        /// </summary>
        internal bool IsSetBasicHttpPassword() => this.BasicHttpPassword != null;

        /// <summary>
        /// Gets and sets the property HmacSecretValue. 
        /// <para>
        /// The new HMAC secret, in the SecretEncoding of the EventSource. With BASE64, EventBridge
        /// removes a leading "whsec_". The key must be 16 to 512 bytes; with BASE64 SecretEncoding,
        /// this is measured after decoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string HmacSecretValue { get; set; }

        /// <summary>
        /// Checks to see if the HmacSecretValue property is set.
        /// </summary>
        internal bool IsSetHmacSecretValue() => this.HmacSecretValue != null;

        /// <summary>
        /// Gets and sets the property StaticTokenSecretValue. 
        /// <para>
        /// The new token for static token authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string StaticTokenSecretValue { get; set; }

        /// <summary>
        /// Checks to see if the StaticTokenSecretValue property is set.
        /// </summary>
        internal bool IsSetStaticTokenSecretValue() => this.StaticTokenSecretValue != null;
    }
}
