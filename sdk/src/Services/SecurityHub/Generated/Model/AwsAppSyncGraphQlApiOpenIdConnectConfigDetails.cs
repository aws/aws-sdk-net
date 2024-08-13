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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the authorization configuration for using an OpenID Connect compliant service
    /// with your AppSync GraphQL API endpoint.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiOpenIdConnectConfigDetails
    {
        private long? _authTtL;
        private string _clientId;
        private long? _iatTtL;
        private string _issuer;

        /// <summary>
        /// Gets and sets the property AuthTtL. 
        /// <para>
        ///  The number of milliseconds that a token is valid after being authenticated. 
        /// </para>
        /// </summary>
        public long? AuthTtL
        {
            get { return this._authTtL; }
            set { this._authTtL = value; }
        }

        // Check to see if AuthTtL property is set
        internal bool IsSetAuthTtL()
        {
            return this._authTtL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        ///  The client identifier of the relying party at the OpenID identity provider. This
        /// identifier is typically obtained when the relying party is registered with the OpenID
        /// identity provider. You can specify a regular expression so that AppSync can validate
        /// against multiple client identifiers at a time. 
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
        /// Gets and sets the property IatTtL. 
        /// <para>
        ///  The number of milliseconds that a token is valid after it's issued to a user. 
        /// </para>
        /// </summary>
        public long? IatTtL
        {
            get { return this._iatTtL; }
            set { this._iatTtL = value; }
        }

        // Check to see if IatTtL property is set
        internal bool IsSetIatTtL()
        {
            return this._iatTtL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        ///  The issuer for the OIDC configuration. The issuer returned by discovery must exactly
        /// match the value of <c>iss</c> in the ID token. 
        /// </para>
        /// </summary>
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