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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The identity provider.
    /// </summary>
    public partial class IdentityProvider
    {
        private string _identityProviderArn;
        private Dictionary<string, string> _identityProviderDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _identityProviderName;
        private IdentityProviderType _identityProviderType;

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The ARN of the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string IdentityProviderArn
        {
            get { return this._identityProviderArn; }
            set { this._identityProviderArn = value; }
        }

        // Check to see if IdentityProviderArn property is set
        internal bool IsSetIdentityProviderArn()
        {
            return this._identityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// The identity provider details. The following list describes the provider detail keys
        /// for each identity provider type. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Google and Login with Amazon:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>client_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client_secret</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>authorize_scopes</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For Facebook:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>client_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client_secret</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>authorize_scopes</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>api_version</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For Sign in with Apple:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>client_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>team_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>key_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private_key</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>authorize_scopes</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For OIDC providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>client_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client_secret</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attributes_request_method</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oidc_issuer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>authorize_scopes</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>authorize_url</c> <i>if not available from discovery URL specified by oidc_issuer
        /// key</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>token_url</c> <i>if not available from discovery URL specified by oidc_issuer
        /// key</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attributes_url</c> <i>if not available from discovery URL specified by oidc_issuer
        /// key</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>jwks_uri</c> <i>if not available from discovery URL specified by oidc_issuer key</i>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For SAML providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MetadataFile</c> OR <c>MetadataURL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IDPSignout</c> (boolean) <i>optional</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IDPInit</c> (boolean) <i>optional</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RequestSigningAlgorithm</c> (string) <i>optional</i> - Only accepts <c>rsa-sha256</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EncryptedResponses</c> (boolean) <i>optional</i> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null && (this._identityProviderDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderName. 
        /// <para>
        /// The identity provider name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32)]
        public string IdentityProviderName
        {
            get { return this._identityProviderName; }
            set { this._identityProviderName = value; }
        }

        // Check to see if IdentityProviderName property is set
        internal bool IsSetIdentityProviderName()
        {
            return this._identityProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// The identity provider type.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

    }
}