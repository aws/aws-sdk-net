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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
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
namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the GetOpenIdTokenForDeveloperIdentity operation.
    /// Registers (or retrieves) a Cognito <c>IdentityId</c> and an OpenID Connect token for
    /// a user authenticated by your backend authentication process. Supplying multiple logins
    /// will create an implicit linked account. You can only specify one developer provider
    /// as part of the <c>Logins</c> map, which is linked to the identity pool. The developer
    /// provider is the "domain" by which Cognito will refer to your users.
    /// 
    ///  
    /// <para>
    /// You can use <c>GetOpenIdTokenForDeveloperIdentity</c> to create a new identity and
    /// to link new logins (that is, user credentials issued by a public provider or developer
    /// provider) to an existing identity. When you want to create a new identity, the <c>IdentityId</c>
    /// should be null. When you want to associate a new login with an existing authenticated/unauthenticated
    /// identity, you can do so by providing the existing <c>IdentityId</c>. This API will
    /// create the identity in the specified <c>IdentityPoolId</c>.
    /// </para>
    ///  
    /// <para>
    /// You must use Amazon Web Services developer credentials to call this operation.
    /// </para>
    /// </summary>
    public partial class GetOpenIdTokenForDeveloperIdentityRequest : AmazonCognitoIdentityRequest
    {
        private string _identityId;
        private string _identityPoolId;
        private Dictionary<string, string> _logins = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _principalTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _tokenDuration;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// A unique identifier in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Logins. 
        /// <para>
        /// A set of optional name-value pairs that map provider names to provider tokens. Each
        /// name-value pair represents a user from a public provider or developer provider. If
        /// the user is from a developer provider, the name-value pair will follow the syntax
        /// <c>"developer_provider_name": "developer_user_identifier"</c>. The developer provider
        /// is the "domain" by which Cognito will refer to your users; you provided this domain
        /// while creating/updating the identity pool. The developer user identifier is an identifier
        /// from your backend that uniquely identifies a user. When you create an identity pool,
        /// you can specify the supported logins.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=10)]
        public Dictionary<string, string> Logins
        {
            get { return this._logins; }
            set { this._logins = value; }
        }

        // Check to see if Logins property is set
        internal bool IsSetLogins()
        {
            return this._logins != null && (this._logins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrincipalTags. 
        /// <para>
        /// Use this operation to configure attribute mappings for custom providers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public Dictionary<string, string> PrincipalTags
        {
            get { return this._principalTags; }
            set { this._principalTags = value; }
        }

        // Check to see if PrincipalTags property is set
        internal bool IsSetPrincipalTags()
        {
            return this._principalTags != null && (this._principalTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TokenDuration. 
        /// <para>
        /// The expiration time of the token, in seconds. You can specify a custom expiration
        /// time for the token so that you can cache it. If you don't provide an expiration time,
        /// the token is valid for 15 minutes. You can exchange the token with Amazon STS for
        /// temporary Amazon Web Services credentials, which are valid for a maximum of one hour.
        /// The maximum token duration you can set is 24 hours. You should take care in setting
        /// the expiration time for a token, as there are significant security implications: an
        /// attacker could use a leaked token to access your Amazon Web Services resources for
        /// the token's duration.
        /// </para>
        ///  <note> 
        /// <para>
        /// Please provide for a small grace period, usually no more than 5 minutes, to account
        /// for clock skew.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public long? TokenDuration
        {
            get { return this._tokenDuration; }
            set { this._tokenDuration = value; }
        }

        // Check to see if TokenDuration property is set
        internal bool IsSetTokenDuration()
        {
            return this._tokenDuration.HasValue; 
        }

    }
}