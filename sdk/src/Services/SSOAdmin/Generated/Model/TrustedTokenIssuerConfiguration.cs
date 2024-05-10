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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes the configuration of a trusted token issuer. The structure
    /// and available settings are determined by the type of the trusted token issuer.
    /// </summary>
    public partial class TrustedTokenIssuerConfiguration
    {
        private OidcJwtConfiguration _oidcJwtConfiguration;

        /// <summary>
        /// Gets and sets the property OidcJwtConfiguration. 
        /// <para>
        /// A structure that describes the settings for a trusted token issuer that works with
        /// OpenID Connect (OIDC) by using JSON Web Tokens (JWT).
        /// </para>
        /// </summary>
        public OidcJwtConfiguration OidcJwtConfiguration
        {
            get { return this._oidcJwtConfiguration; }
            set { this._oidcJwtConfiguration = value; }
        }

        // Check to see if OidcJwtConfiguration property is set
        internal bool IsSetOidcJwtConfiguration()
        {
            return this._oidcJwtConfiguration != null;
        }

    }
}