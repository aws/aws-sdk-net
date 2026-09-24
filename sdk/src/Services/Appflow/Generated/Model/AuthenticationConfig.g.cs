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
    /// Contains information about the authentication config that the connector supports.
    /// </summary>
    public partial class AuthenticationConfig
    {
        /// <summary>
        /// Gets and sets the property CustomAuthConfigs. 
        /// <para>
        /// Contains information required for custom authentication.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAuthConfig> CustomAuthConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomAuthConfig>() : null;

        /// <summary>
        /// Checks to see if the CustomAuthConfigs property is set.
        /// </summary>
        internal bool IsSetCustomAuthConfigs() => this.CustomAuthConfigs != null && (this.CustomAuthConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsApiKeyAuthSupported. 
        /// <para>
        /// Indicates whether API key authentication is supported by the connector
        /// </para>
        /// </summary>
        public bool? IsApiKeyAuthSupported { get; set; }

        /// <summary>
        /// Checks to see if the IsApiKeyAuthSupported property is set.
        /// </summary>
        internal bool IsSetIsApiKeyAuthSupported() => this.IsApiKeyAuthSupported.HasValue;

        /// <summary>
        /// Gets and sets the property IsBasicAuthSupported. 
        /// <para>
        /// Indicates whether basic authentication is supported by the connector.
        /// </para>
        /// </summary>
        public bool? IsBasicAuthSupported { get; set; }

        /// <summary>
        /// Checks to see if the IsBasicAuthSupported property is set.
        /// </summary>
        internal bool IsSetIsBasicAuthSupported() => this.IsBasicAuthSupported.HasValue;

        /// <summary>
        /// Gets and sets the property IsCustomAuthSupported. 
        /// <para>
        /// Indicates whether custom authentication is supported by the connector
        /// </para>
        /// </summary>
        public bool? IsCustomAuthSupported { get; set; }

        /// <summary>
        /// Checks to see if the IsCustomAuthSupported property is set.
        /// </summary>
        internal bool IsSetIsCustomAuthSupported() => this.IsCustomAuthSupported.HasValue;

        /// <summary>
        /// Gets and sets the property IsOAuth2Supported. 
        /// <para>
        /// Indicates whether OAuth 2.0 authentication is supported by the connector.
        /// </para>
        /// </summary>
        public bool? IsOAuth2Supported { get; set; }

        /// <summary>
        /// Checks to see if the IsOAuth2Supported property is set.
        /// </summary>
        internal bool IsSetIsOAuth2Supported() => this.IsOAuth2Supported.HasValue;

        /// <summary>
        /// Gets and sets the property OAuth2Defaults. 
        /// <para>
        /// Contains the default values required for OAuth 2.0 authentication.
        /// </para>
        /// </summary>
        public OAuth2Defaults OAuth2Defaults { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2Defaults property is set.
        /// </summary>
        internal bool IsSetOAuth2Defaults() => this.OAuth2Defaults != null;
    }
}
