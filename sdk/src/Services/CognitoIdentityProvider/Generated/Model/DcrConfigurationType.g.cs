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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The dynamic client registration configuration for a user pool. Dynamic client registration
    /// lets applications register their own app clients at runtime through the registration
    /// endpoint of your user pool domain. To activate this setting, your user pool must be
    /// in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
    /// Essentials tier</a> or higher.
    /// 
    ///  
    /// <para>
    /// Applications register app clients at the <c>/oauth2/register</c> endpoint of your
    /// user pool domain. In authenticated registration, the application sends an access token
    /// from your user pool that has the <c>aws.cognito/dcr/register</c> scope. In open registration,
    /// the application doesn't send a token.
    /// </para>
    ///  
    /// <para>
    /// When you include this configuration in an <c>UpdateUserPool</c> request, Amazon Cognito
    /// replaces the existing configuration with the one that you provide.
    /// </para>
    /// </summary>
    public partial class DcrConfigurationType
    {
        /// <summary>
        /// Gets and sets the property AllowedScopes. 
        /// <para>
        /// The scopes that an app client created through dynamic client registration can request,
        /// in addition to the standard OpenID Connect (OIDC) scopes. You can include custom scopes
        /// from your resource servers and <c>aws.cognito.signin.user.admin</c>. Registered app
        /// clients can request the OIDC scopes <c>openid</c>, <c>email</c>, <c>phone</c>, and
        /// <c>profile</c> without listing them here. If you don't set this value, registered
        /// app clients can request only the OIDC scopes. A registered app client can't request
        /// the <c>aws.cognito/dcr/register</c> scope, even if you include it in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> AllowedScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedScopes property is set.
        /// </summary>
        internal bool IsSetAllowedScopes() => this.AllowedScopes != null && (this.AllowedScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthenticatedGrantTypes. 
        /// <para>
        /// The OAuth grant types that an app client created through authenticated registration
        /// can request. If you don't set this value, authenticated registration permits the <c>code</c>
        /// and <c>client_credentials</c> grant types. If you set an empty list, Amazon Cognito
        /// rejects authenticated registration requests. Dynamic client registration supports
        /// the following values. Amazon Cognito accepts <c>implicit</c> in this list but ignores
        /// it.
        /// </para>
        ///  <dl> <dt>code</dt> <dd> 
        /// <para>
        /// Use a code grant flow, which provides an authorization code as the response. This
        /// code can be exchanged for access tokens with the <c>/oauth2/token</c> endpoint.
        /// </para>
        ///  </dd> <dt>client_credentials</dt> <dd> 
        /// <para>
        /// Issue the access token from the <c>/oauth2/token</c> endpoint directly to a non-person
        /// user using a combination of the client ID and client secret.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> AuthenticatedGrantTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticatedGrantTypes property is set.
        /// </summary>
        internal bool IsSetAuthenticatedGrantTypes() => this.AuthenticatedGrantTypes != null && (this.AuthenticatedGrantTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableStatus. 
        /// <para>
        /// Specifies whether dynamic client registration is turned on for the user pool. If you
        /// provide a dynamic client registration configuration without this value, Amazon Cognito
        /// turns dynamic client registration on.
        /// </para>
        /// </summary>
        public StatusType EnableStatus { get; set; }

        /// <summary>
        /// Checks to see if the EnableStatus property is set.
        /// </summary>
        internal bool IsSetEnableStatus() => this.EnableStatus != null;

        /// <summary>
        /// Gets and sets the property OpenDcrEnabled. 
        /// <para>
        /// Specifies whether open registration is turned on. When open registration is on, applications
        /// can register app clients without an initial access token. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? OpenDcrEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OpenDcrEnabled property is set.
        /// </summary>
        internal bool IsSetOpenDcrEnabled() => this.OpenDcrEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OpenDcrGrantTypes. 
        /// <para>
        /// The OAuth grant types that an app client created through open registration can request.
        /// If you don't set this value, open registration permits only the <c>code</c> grant
        /// type. If you set an empty list, Amazon Cognito rejects open registration requests.
        /// If you add <c>client_credentials</c>, anyone can register an app client that requests
        /// machine-to-machine (M2M) access tokens, and you pay for the M2M token requests that
        /// those app clients make. Dynamic client registration supports the following values.
        /// Amazon Cognito accepts <c>implicit</c> in this list but ignores it.
        /// </para>
        ///  <dl> <dt>code</dt> <dd> 
        /// <para>
        /// Use a code grant flow, which provides an authorization code as the response. This
        /// code can be exchanged for access tokens with the <c>/oauth2/token</c> endpoint.
        /// </para>
        ///  </dd> <dt>client_credentials</dt> <dd> 
        /// <para>
        /// Issue the access token from the <c>/oauth2/token</c> endpoint directly to a non-person
        /// user using a combination of the client ID and client secret.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> OpenDcrGrantTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OpenDcrGrantTypes property is set.
        /// </summary>
        internal bool IsSetOpenDcrGrantTypes() => this.OpenDcrGrantTypes != null && (this.OpenDcrGrantTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
