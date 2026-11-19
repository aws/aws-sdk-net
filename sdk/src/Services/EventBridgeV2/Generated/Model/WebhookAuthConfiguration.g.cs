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
    /// How the provider authenticates its webhook requests. Exactly one variant must be set.
    /// </summary>
    public partial class WebhookAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property BasicHttpAuthConfiguration. 
        /// <para>
        /// The provider uses HTTP Basic authentication.
        /// </para>
        /// </summary>
        public WebhookBasicHttpAuthConfiguration BasicHttpAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BasicHttpAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetBasicHttpAuthConfiguration() => this.BasicHttpAuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property HmacAuthConfiguration. 
        /// <para>
        /// The provider signs each request with an HMAC of the secret.
        /// </para>
        /// </summary>
        public WebhookHmacAuthConfiguration HmacAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HmacAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetHmacAuthConfiguration() => this.HmacAuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property StaticTokenAuthConfiguration. 
        /// <para>
        /// The provider sends a static token in an HTTP header.
        /// </para>
        /// </summary>
        public WebhookStaticTokenAuthConfiguration StaticTokenAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StaticTokenAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetStaticTokenAuthConfiguration() => this.StaticTokenAuthConfiguration != null;
    }
}
