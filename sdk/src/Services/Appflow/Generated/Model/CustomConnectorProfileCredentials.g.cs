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
    /// The connector-specific profile credentials that are required when using the custom
    /// connector.
    /// </summary>
    public partial class CustomConnectorProfileCredentials
    {
        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API keys required for the authentication of the user.
        /// </para>
        /// </summary>
        public ApiKeyCredentials ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type that the custom connector uses for authenticating while creating
        /// a connector profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property Basic. 
        /// <para>
        /// The basic credentials that are required for the authentication of the user.
        /// </para>
        /// </summary>
        public BasicAuthCredentials Basic { get; set; }

        /// <summary>
        /// Checks to see if the Basic property is set.
        /// </summary>
        internal bool IsSetBasic() => this.Basic != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// If the connector uses the custom authentication mechanism, this holds the required
        /// credentials.
        /// </para>
        /// </summary>
        public CustomAuthCredentials Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property Oauth2. 
        /// <para>
        /// The OAuth 2.0 credentials required for the authentication of the user.
        /// </para>
        /// </summary>
        public OAuth2Credentials Oauth2 { get; set; }

        /// <summary>
        /// Checks to see if the Oauth2 property is set.
        /// </summary>
        internal bool IsSetOauth2() => this.Oauth2 != null;
    }
}
