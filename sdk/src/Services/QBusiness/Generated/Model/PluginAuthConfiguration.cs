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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Authentication configuration information for an Amazon Q Business plugin.
    /// </summary>
    public partial class PluginAuthConfiguration
    {
        private BasicAuthConfiguration _basicAuthConfiguration;
        private OAuth2ClientCredentialConfiguration _oAuth2ClientCredentialConfiguration;

        /// <summary>
        /// Gets and sets the property BasicAuthConfiguration. 
        /// <para>
        /// Information about the basic authentication credentials used to configure a plugin.
        /// </para>
        /// </summary>
        public BasicAuthConfiguration BasicAuthConfiguration
        {
            get { return this._basicAuthConfiguration; }
            set { this._basicAuthConfiguration = value; }
        }

        // Check to see if BasicAuthConfiguration property is set
        internal bool IsSetBasicAuthConfiguration()
        {
            return this._basicAuthConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OAuth2ClientCredentialConfiguration. 
        /// <para>
        /// Information about the OAuth 2.0 authentication credential/token used to configure
        /// a plugin.
        /// </para>
        /// </summary>
        public OAuth2ClientCredentialConfiguration OAuth2ClientCredentialConfiguration
        {
            get { return this._oAuth2ClientCredentialConfiguration; }
            set { this._oAuth2ClientCredentialConfiguration = value; }
        }

        // Check to see if OAuth2ClientCredentialConfiguration property is set
        internal bool IsSetOAuth2ClientCredentialConfiguration()
        {
            return this._oAuth2ClientCredentialConfiguration != null;
        }

    }
}