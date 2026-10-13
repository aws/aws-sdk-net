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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure containing properties for OAuth2 in the CreateConnection request.
    /// </summary>
    public partial class OAuth2PropertiesInput
    {
        /// <summary>
        /// Gets and sets the property AuthorizationCodeProperties. 
        /// <para>
        /// The set of properties required for the the OAuth2 <c>AUTHORIZATION_CODE</c> grant
        /// type.
        /// </para>
        /// </summary>
        public AuthorizationCodeProperties AuthorizationCodeProperties { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationCodeProperties property is set.
        /// </summary>
        internal bool IsSetAuthorizationCodeProperties() => this.AuthorizationCodeProperties != null;

        /// <summary>
        /// Gets and sets the property OAuth2ClientApplication. 
        /// <para>
        /// The client application type in the CreateConnection request. For example, <c>AWS_MANAGED</c>
        /// or <c>USER_MANAGED</c>.
        /// </para>
        /// </summary>
        public OAuth2ClientApplication OAuth2ClientApplication { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2ClientApplication property is set.
        /// </summary>
        internal bool IsSetOAuth2ClientApplication() => this.OAuth2ClientApplication != null;

        /// <summary>
        /// Gets and sets the property OAuth2Credentials. 
        /// <para>
        /// The credentials used when the authentication type is OAuth2 authentication.
        /// </para>
        /// </summary>
        public OAuth2Credentials OAuth2Credentials { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2Credentials property is set.
        /// </summary>
        internal bool IsSetOAuth2Credentials() => this.OAuth2Credentials != null;

        /// <summary>
        /// Gets and sets the property OAuth2GrantType. 
        /// <para>
        /// The OAuth2 grant type in the CreateConnection request. For example, <c>AUTHORIZATION_CODE</c>,
        /// <c>JWT_BEARER</c>, <c>REFRESH_TOKEN</c>, or <c>CLIENT_CREDENTIALS</c>.
        /// </para>
        /// </summary>
        public OAuth2GrantType OAuth2GrantType { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2GrantType property is set.
        /// </summary>
        internal bool IsSetOAuth2GrantType() => this.OAuth2GrantType != null;

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The URL of the provider's authentication server, to exchange an authorization code
        /// for an access token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// Checks to see if the TokenUrl property is set.
        /// </summary>
        internal bool IsSetTokenUrl() => this.TokenUrl != null;

        /// <summary>
        /// Gets and sets the property TokenUrlParametersMap. 
        /// <para>
        /// A map of parameters that are added to the token <c>GET</c> request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TokenUrlParametersMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TokenUrlParametersMap property is set.
        /// </summary>
        internal bool IsSetTokenUrlParametersMap() => this.TokenUrlParametersMap != null && (this.TokenUrlParametersMap.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
