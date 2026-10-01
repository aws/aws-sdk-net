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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Bearer token configuration for remote A2A agent (RFC 6750).
    /// </summary>
    public partial class RemoteAgentBearerTokenConfig
    {
        /// <summary>
        /// Gets and sets the property AuthorizationHeader. 
        /// <para>
        /// HTTP header name to send the bearer token in requests to the service. Defaults to
        /// 'Authorization' per RFC 6750.
        /// </para>
        /// </summary>
        public string AuthorizationHeader { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationHeader property is set.
        /// </summary>
        internal bool IsSetAuthorizationHeader() => this.AuthorizationHeader != null;

        /// <summary>
        /// Gets and sets the property TokenName. 
        /// <para>
        /// User friendly bearer token name specified by end user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TokenName { get; set; }

        /// <summary>
        /// Checks to see if the TokenName property is set.
        /// </summary>
        internal bool IsSetTokenName() => this.TokenName != null;

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// Bearer token value in alphanumeric for authenticating with the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string TokenValue { get; set; }

        /// <summary>
        /// Checks to see if the TokenValue property is set.
        /// </summary>
        internal bool IsSetTokenValue() => this.TokenValue != null;
    }
}
