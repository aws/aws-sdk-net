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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterClient operation.
    /// Registers a client with IAM Identity Center. This allows clients to initiate device
    /// authorization. The output should be persisted for reuse through many authentication
    /// requests.
    /// </summary>
    public partial class RegisterClientRequest : AmazonSSOOIDCRequest
    {
        private string _clientName;
        private string _clientType;
        private List<string> _scopes = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The friendly name of the client.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientName
        {
            get { return this._clientName; }
            set { this._clientName = value; }
        }

        // Check to see if ClientName property is set
        internal bool IsSetClientName()
        {
            return this._clientName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientType. 
        /// <para>
        /// The type of client. The service supports only <code>public</code> as a client type.
        /// Anything other than public will be rejected by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientType
        {
            get { return this._clientType; }
            set { this._clientType = value; }
        }

        // Check to see if ClientType property is set
        internal bool IsSetClientType()
        {
            return this._clientType != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The list of scopes that are defined by the client. Upon authorization, this list is
        /// used to restrict permissions when granting an access token.
        /// </para>
        /// </summary>
        public List<string> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && this._scopes.Count > 0; 
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}