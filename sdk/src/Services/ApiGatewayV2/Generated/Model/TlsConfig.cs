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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// The TLS configuration for a private integration. If you specify a TLS configuration,
    /// private integration traffic uses the HTTPS protocol. Supported only for HTTP APIs.
    /// </summary>
    public partial class TlsConfig
    {
        private string _serverNameToVerify;

        /// <summary>
        /// Gets and sets the property ServerNameToVerify. 
        /// <para>
        /// If you specify a server name, API Gateway uses it to verify the hostname on the integration's
        /// certificate. The server name is also included in the TLS handshake to support Server
        /// Name Indication (SNI) or virtual hosting.
        /// </para>
        /// </summary>
        public string ServerNameToVerify
        {
            get { return this._serverNameToVerify; }
            set { this._serverNameToVerify = value; }
        }

        // Check to see if ServerNameToVerify property is set
        internal bool IsSetServerNameToVerify()
        {
            return this._serverNameToVerify != null;
        }

    }
}