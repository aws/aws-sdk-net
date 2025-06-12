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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
        private List<string> _authCodeUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<OAuth2CustomParameter> _oauth2CustomProperties = AWSConfigs.InitializeCollections ? new List<OAuth2CustomParameter>() : null;
        private List<string> _oauth2GrantTypesSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _oauthScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tokenUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AuthCodeUrls. 
        /// <para>
        /// Auth code URLs that can be used for OAuth 2.0 authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthCodeUrls
        {
            get { return this._authCodeUrls; }
            set { this._authCodeUrls = value; }
        }

        // Check to see if AuthCodeUrls property is set
        internal bool IsSetAuthCodeUrls()
        {
            return this._authCodeUrls != null && (this._authCodeUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Oauth2CustomProperties. 
        /// <para>
        /// List of custom parameters required for OAuth 2.0 authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OAuth2CustomParameter> Oauth2CustomProperties
        {
            get { return this._oauth2CustomProperties; }
            set { this._oauth2CustomProperties = value; }
        }

        // Check to see if Oauth2CustomProperties property is set
        internal bool IsSetOauth2CustomProperties()
        {
            return this._oauth2CustomProperties != null && (this._oauth2CustomProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Oauth2GrantTypesSupported. 
        /// <para>
        /// OAuth 2.0 grant types supported by the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Oauth2GrantTypesSupported
        {
            get { return this._oauth2GrantTypesSupported; }
            set { this._oauth2GrantTypesSupported = value; }
        }

        // Check to see if Oauth2GrantTypesSupported property is set
        internal bool IsSetOauth2GrantTypesSupported()
        {
            return this._oauth2GrantTypesSupported != null && (this._oauth2GrantTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OauthScopes. 
        /// <para>
        /// OAuth 2.0 scopes that the connector supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OauthScopes
        {
            get { return this._oauthScopes; }
            set { this._oauthScopes = value; }
        }

        // Check to see if OauthScopes property is set
        internal bool IsSetOauthScopes()
        {
            return this._oauthScopes != null && (this._oauthScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TokenUrls. 
        /// <para>
        /// Token URLs that can be used for OAuth 2.0 authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TokenUrls
        {
            get { return this._tokenUrls; }
            set { this._tokenUrls = value; }
        }

        // Check to see if TokenUrls property is set
        internal bool IsSetTokenUrls()
        {
            return this._tokenUrls != null && (this._tokenUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}