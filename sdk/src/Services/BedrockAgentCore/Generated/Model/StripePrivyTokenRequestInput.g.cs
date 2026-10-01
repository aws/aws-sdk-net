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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Stripe Privy token request parameters.
    /// </summary>
    public partial class StripePrivyTokenRequestInput
    {
        /// <summary>
        /// Gets and sets the property IncludeAuthorizationSignature. 
        /// <para>
        /// Set to true to generate privy-authorization-signature.
        /// </para>
        /// </summary>
        public bool? IncludeAuthorizationSignature { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAuthorizationSignature property is set.
        /// </summary>
        internal bool IsSetIncludeAuthorizationSignature() => this.IncludeAuthorizationSignature.HasValue;

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// Request body JSON for the Privy API call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 16384)]
        public string RequestBody { get; set; }

        /// <summary>
        /// Checks to see if the RequestBody property is set.
        /// </summary>
        internal bool IsSetRequestBody() => this.RequestBody != null;

        /// <summary>
        /// Gets and sets the property RequestHost. 
        /// <para>
        /// The host for the Privy API request. Defaults to "api.privy.io".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RequestHost { get; set; }

        /// <summary>
        /// Checks to see if the RequestHost property is set.
        /// </summary>
        internal bool IsSetRequestHost() => this.RequestHost != null;

        /// <summary>
        /// Gets and sets the property RequestPath. 
        /// <para>
        /// The path of the Stripe Privy API request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RequestPath { get; set; }

        /// <summary>
        /// Checks to see if the RequestPath property is set.
        /// </summary>
        internal bool IsSetRequestPath() => this.RequestPath != null;
    }
}
