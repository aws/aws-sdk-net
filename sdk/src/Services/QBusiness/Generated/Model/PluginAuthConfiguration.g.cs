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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Authentication configuration information for an Amazon Q Business plugin.
    /// </summary>
    public partial class PluginAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property BasicAuthConfiguration. 
        /// <para>
        /// Information about the basic authentication credentials used to configure a plugin.
        /// </para>
        /// </summary>
        public BasicAuthConfiguration BasicAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetBasicAuthConfiguration() => this.BasicAuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdcAuthConfiguration. 
        /// <para>
        /// Information about the IAM Identity Center Application used to configure authentication
        /// for a plugin.
        /// </para>
        /// </summary>
        public IdcAuthConfiguration IdcAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdcAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetIdcAuthConfiguration() => this.IdcAuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property NoAuthConfiguration. 
        /// <para>
        /// Information about invoking a custom plugin without any authentication.
        /// </para>
        /// </summary>
        public NoAuthConfiguration NoAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NoAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetNoAuthConfiguration() => this.NoAuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property OAuth2ClientCredentialConfiguration. 
        /// <para>
        /// Information about the OAuth 2.0 authentication credential/token used to configure
        /// a plugin.
        /// </para>
        /// </summary>
        public OAuth2ClientCredentialConfiguration OAuth2ClientCredentialConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OAuth2ClientCredentialConfiguration property is set.
        /// </summary>
        internal bool IsSetOAuth2ClientCredentialConfiguration() => this.OAuth2ClientCredentialConfiguration != null;
    }
}
