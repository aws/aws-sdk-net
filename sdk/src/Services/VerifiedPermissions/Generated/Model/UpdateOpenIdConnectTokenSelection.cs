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
    /// The token type that you want to process from your OIDC identity provider. Your policy
    /// store can process either identity (ID) or access tokens from a given OIDC identity
    /// source.
    /// 
    ///  
    /// <para>
    /// This data type is part of a <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdateOpenIdConnectConfiguration.html">UpdateOpenIdConnectConfiguration</a>
    /// structure, which is a parameter to <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdateIdentitySource.html">UpdateIdentitySource</a>.
    /// </para>
    /// </summary>
    public partial class UpdateOpenIdConnectTokenSelection
    {
        private UpdateOpenIdConnectAccessTokenConfiguration _accessTokenOnly;
        private UpdateOpenIdConnectIdentityTokenConfiguration _identityTokenOnly;

        /// <summary>
        /// Gets and sets the property AccessTokenOnly. 
        /// <para>
        /// The OIDC configuration for processing access tokens. Contains allowed audience claims,
        /// for example <c>https://auth.example.com</c>, and the claim that you want to map to
        /// the principal, for example <c>sub</c>.
        /// </para>
        /// </summary>
        public UpdateOpenIdConnectAccessTokenConfiguration AccessTokenOnly
        {
            get { return this._accessTokenOnly; }
            set { this._accessTokenOnly = value; }
        }

        // Check to see if AccessTokenOnly property is set
        internal bool IsSetAccessTokenOnly()
        {
            return this._accessTokenOnly != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityTokenOnly. 
        /// <para>
        /// The OIDC configuration for processing identity (ID) tokens. Contains allowed client
        /// ID claims, for example <c>1example23456789</c>, and the claim that you want to map
        /// to the principal, for example <c>sub</c>.
        /// </para>
        /// </summary>
        public UpdateOpenIdConnectIdentityTokenConfiguration IdentityTokenOnly
        {
            get { return this._identityTokenOnly; }
            set { this._identityTokenOnly = value; }
        }

        // Check to see if IdentityTokenOnly property is set
        internal bool IsSetIdentityTokenOnly()
        {
            return this._identityTokenOnly != null;
        }

    }
}