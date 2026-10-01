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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains the default values required for OAuth 2.0 authentication.
    /// </summary>
    public partial class OAuth2Defaults
    {
        /// <summary>
        /// Gets and sets the property AuthCodeUrls. 
        /// <para>
        /// Auth code URLs that can be used for OAuth 2.0 authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthCodeUrls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthCodeUrls property is set.
        /// </summary>
        internal bool IsSetAuthCodeUrls() => this.AuthCodeUrls != null && (this.AuthCodeUrls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Oauth2CustomProperties. 
        /// <para>
        /// List of custom parameters required for OAuth 2.0 authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OAuth2CustomParameter> Oauth2CustomProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<OAuth2CustomParameter>() : null;

        /// <summary>
        /// Checks to see if the Oauth2CustomProperties property is set.
        /// </summary>
        internal bool IsSetOauth2CustomProperties() => this.Oauth2CustomProperties != null && (this.Oauth2CustomProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Oauth2GrantTypesSupported. 
        /// <para>
        /// OAuth 2.0 grant types supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Oauth2GrantTypesSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Oauth2GrantTypesSupported property is set.
        /// </summary>
        internal bool IsSetOauth2GrantTypesSupported() => this.Oauth2GrantTypesSupported != null && (this.Oauth2GrantTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OauthScopes. 
        /// <para>
        /// OAuth 2.0 scopes that the connector supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OauthScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OauthScopes property is set.
        /// </summary>
        internal bool IsSetOauthScopes() => this.OauthScopes != null && (this.OauthScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenUrls. 
        /// <para>
        /// Token URLs that can be used for OAuth 2.0 authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TokenUrls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenUrls property is set.
        /// </summary>
        internal bool IsSetTokenUrls() => this.TokenUrls != null && (this.TokenUrls.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
