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
    /// Contains information about the authentication config that the connector supports.
    /// </summary>
    public partial class AuthenticationConfig
    {
        private List<CustomAuthConfig> _customAuthConfigs = AWSConfigs.InitializeCollections ? new List<CustomAuthConfig>() : null;
        private bool? _isApiKeyAuthSupported;
        private bool? _isBasicAuthSupported;
        private bool? _isCustomAuthSupported;
        private bool? _isoAuth2Supported;
        private OAuth2Defaults _oAuth2Defaults;

        /// <summary>
        /// Gets and sets the property CustomAuthConfigs. 
        /// <para>
        /// Contains information required for custom authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAuthConfig> CustomAuthConfigs
        {
            get { return this._customAuthConfigs; }
            set { this._customAuthConfigs = value; }
        }

        // Check to see if CustomAuthConfigs property is set
        internal bool IsSetCustomAuthConfigs()
        {
            return this._customAuthConfigs != null && (this._customAuthConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsApiKeyAuthSupported. 
        /// <para>
        /// Indicates whether API key authentication is supported by the connector
        /// </para>
        /// </summary>
        public bool? IsApiKeyAuthSupported
        {
            get { return this._isApiKeyAuthSupported; }
            set { this._isApiKeyAuthSupported = value; }
        }

        // Check to see if IsApiKeyAuthSupported property is set
        internal bool IsSetIsApiKeyAuthSupported()
        {
            return this._isApiKeyAuthSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsBasicAuthSupported. 
        /// <para>
        /// Indicates whether basic authentication is supported by the connector.
        /// </para>
        /// </summary>
        public bool? IsBasicAuthSupported
        {
            get { return this._isBasicAuthSupported; }
            set { this._isBasicAuthSupported = value; }
        }

        // Check to see if IsBasicAuthSupported property is set
        internal bool IsSetIsBasicAuthSupported()
        {
            return this._isBasicAuthSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsCustomAuthSupported. 
        /// <para>
        /// Indicates whether custom authentication is supported by the connector
        /// </para>
        /// </summary>
        public bool? IsCustomAuthSupported
        {
            get { return this._isCustomAuthSupported; }
            set { this._isCustomAuthSupported = value; }
        }

        // Check to see if IsCustomAuthSupported property is set
        internal bool IsSetIsCustomAuthSupported()
        {
            return this._isCustomAuthSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsOAuth2Supported. 
        /// <para>
        /// Indicates whether OAuth 2.0 authentication is supported by the connector.
        /// </para>
        /// </summary>
        public bool? IsOAuth2Supported
        {
            get { return this._isoAuth2Supported; }
            set { this._isoAuth2Supported = value; }
        }

        // Check to see if IsOAuth2Supported property is set
        internal bool IsSetIsOAuth2Supported()
        {
            return this._isoAuth2Supported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OAuth2Defaults. 
        /// <para>
        /// Contains the default values required for OAuth 2.0 authentication.
        /// </para>
        /// </summary>
        public OAuth2Defaults OAuth2Defaults
        {
            get { return this._oAuth2Defaults; }
            set { this._oAuth2Defaults = value; }
        }

        // Check to see if OAuth2Defaults property is set
        internal bool IsSetOAuth2Defaults()
        {
            return this._oAuth2Defaults != null;
        }

    }
}