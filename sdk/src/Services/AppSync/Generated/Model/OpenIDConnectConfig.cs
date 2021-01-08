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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an OpenID Connect configuration.
    /// </summary>
    public partial class OpenIDConnectConfig
    {
        private long? _authttl;
        private string _clientId;
        private long? _iatttl;
        private string _issuer;

        /// <summary>
        /// Gets and sets the property AuthTTL. 
        /// <para>
        /// The number of milliseconds a token is valid after being authenticated.
        /// </para>
        /// </summary>
        public long AuthTTL
        {
            get { return this._authttl.GetValueOrDefault(); }
            set { this._authttl = value; }
        }

        // Check to see if AuthTTL property is set
        internal bool IsSetAuthTTL()
        {
            return this._authttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client identifier of the Relying party at the OpenID identity provider. This identifier
        /// is typically obtained when the Relying party is registered with the OpenID identity
        /// provider. You can specify a regular expression so the AWS AppSync can validate against
        /// multiple client identifiers at a time.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property IatTTL. 
        /// <para>
        /// The number of milliseconds a token is valid after being issued to a user.
        /// </para>
        /// </summary>
        public long IatTTL
        {
            get { return this._iatttl.GetValueOrDefault(); }
            set { this._iatttl = value; }
        }

        // Check to see if IatTTL property is set
        internal bool IsSetIatTTL()
        {
            return this._iatttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer for the OpenID Connect configuration. The issuer returned by discovery
        /// must exactly match the value of <code>iss</code> in the ID token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

    }
}