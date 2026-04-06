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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
    /// Bearer token configuration for MCP server (RFC 6750).
    /// </summary>
    public partial class MCPServerBearerTokenConfig
    {
        private string _authorizationHeader;
        private string _tokenName;
        private string _tokenValue;

        /// <summary>
        /// Gets and sets the property AuthorizationHeader. 
        /// <para>
        /// HTTP header name to send the bearer token in requests to the service. Defaults to
        /// 'Authorization' per RFC 6750.
        /// </para>
        /// </summary>
        public string AuthorizationHeader
        {
            get { return this._authorizationHeader; }
            set { this._authorizationHeader = value; }
        }

        // Check to see if AuthorizationHeader property is set
        internal bool IsSetAuthorizationHeader()
        {
            return this._authorizationHeader != null;
        }

        /// <summary>
        /// Gets and sets the property TokenName. 
        /// <para>
        /// User friendly bearer token name specified by end user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TokenName
        {
            get { return this._tokenName; }
            set { this._tokenName = value; }
        }

        // Check to see if TokenName property is set
        internal bool IsSetTokenName()
        {
            return this._tokenName != null;
        }

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// Bearer token value in alphanumeric for authenticating with the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string TokenValue
        {
            get { return this._tokenValue; }
            set { this._tokenValue = value; }
        }

        // Check to see if TokenValue property is set
        internal bool IsSetTokenValue()
        {
            return this._tokenValue != null;
        }

    }
}