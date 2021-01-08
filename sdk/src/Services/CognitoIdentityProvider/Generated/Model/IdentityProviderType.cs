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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A container for information about an identity provider.
    /// </summary>
    public partial class IdentityProviderType
    {
        private Dictionary<string, string> _attributeMapping = new Dictionary<string, string>();
        private DateTime? _creationDate;
        private List<string> _idpIdentifiers = new List<string>();
        private DateTime? _lastModifiedDate;
        private Dictionary<string, string> _providerDetails = new Dictionary<string, string>();
        private string _providerName;
        private IdentityProviderTypeType _providerType;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AttributeMapping. 
        /// <para>
        /// A mapping of identity provider attributes to standard and custom user pool attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AttributeMapping
        {
            get { return this._attributeMapping; }
            set { this._attributeMapping = value; }
        }

        // Check to see if AttributeMapping property is set
        internal bool IsSetAttributeMapping()
        {
            return this._attributeMapping != null && this._attributeMapping.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the identity provider was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdpIdentifiers. 
        /// <para>
        /// A list of identity provider identifiers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> IdpIdentifiers
        {
            get { return this._idpIdentifiers; }
            set { this._idpIdentifiers = value; }
        }

        // Check to see if IdpIdentifiers property is set
        internal bool IsSetIdpIdentifiers()
        {
            return this._idpIdentifiers != null && this._idpIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the identity provider was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProviderDetails. 
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
        /// client_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// client_secret
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authorize_scopes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For Facebook:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// client_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// client_secret
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authorize_scopes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// api_version
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For Sign in with Apple:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// client_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// team_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// key_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// private_key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authorize_scopes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For OIDC providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// client_id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// client_secret
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// attributes_request_method
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// oidc_issuer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authorize_scopes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authorize_url <i>if not available from discovery URL specified by oidc_issuer key</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// token_url <i>if not available from discovery URL specified by oidc_issuer key</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// attributes_url <i>if not available from discovery URL specified by oidc_issuer key</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// jwks_uri <i>if not available from discovery URL specified by oidc_issuer key</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authorize_scopes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For SAML providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// MetadataFile OR MetadataURL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IDPSignOut <i>optional</i> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public Dictionary<string, string> ProviderDetails
        {
            get { return this._providerDetails; }
            set { this._providerDetails = value; }
        }

        // Check to see if ProviderDetails property is set
        internal bool IsSetProviderDetails()
        {
            return this._providerDetails != null && this._providerDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The identity provider name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The identity provider type.
        /// </para>
        /// </summary>
        public IdentityProviderTypeType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}