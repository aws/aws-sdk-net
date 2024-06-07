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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains an update to replace the configuration in an existing identity source.
    /// </summary>
    public partial class UpdateConfiguration
    {
        private UpdateCognitoUserPoolConfiguration _cognitoUserPoolConfiguration;
        private UpdateOpenIdConnectConfiguration _openIdConnectConfiguration;

        /// <summary>
        /// Gets and sets the property CognitoUserPoolConfiguration. 
        /// <para>
        /// Contains configuration details of a Amazon Cognito user pool.
        /// </para>
        /// </summary>
        public UpdateCognitoUserPoolConfiguration CognitoUserPoolConfiguration
        {
            get { return this._cognitoUserPoolConfiguration; }
            set { this._cognitoUserPoolConfiguration = value; }
        }

        // Check to see if CognitoUserPoolConfiguration property is set
        internal bool IsSetCognitoUserPoolConfiguration()
        {
            return this._cognitoUserPoolConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIdConnectConfiguration. 
        /// <para>
        /// Contains configuration details of an OpenID Connect (OIDC) identity provider, or identity
        /// source, that Verified Permissions can use to generate entities from authenticated
        /// identities. It specifies the issuer URL, token type that you want to use, and policy
        /// store entity details.
        /// </para>
        /// </summary>
        public UpdateOpenIdConnectConfiguration OpenIdConnectConfiguration
        {
            get { return this._openIdConnectConfiguration; }
            set { this._openIdConnectConfiguration = value; }
        }

        // Check to see if OpenIdConnectConfiguration property is set
        internal bool IsSetOpenIdConnectConfiguration()
        {
            return this._openIdConnectConfiguration != null;
        }

    }
}