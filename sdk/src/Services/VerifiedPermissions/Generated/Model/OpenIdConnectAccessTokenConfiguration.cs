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
    /// The configuration of an OpenID Connect (OIDC) identity source for handling access
    /// token claims. Contains the claim that you want to identify as the principal in an
    /// authorization request, and the values of the <c>aud</c> claim, or audiences, that
    /// you want to accept.
    /// 
    ///  
    /// <para>
    /// This data type is part of a <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_OpenIdConnectTokenSelection.html">OpenIdConnectTokenSelection</a>
    /// structure, which is a parameter of <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_CreateIdentitySource.html">CreateIdentitySource</a>.
    /// </para>
    /// </summary>
    public partial class OpenIdConnectAccessTokenConfiguration
    {
        private List<string> _audiences = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _principalIdClaim;

        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The access token <c>aud</c> claim values that you want to accept in your policy store.
        /// For example, <c>https://myapp.example.com, https://myapp2.example.com</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public List<string> Audiences
        {
            get { return this._audiences; }
            set { this._audiences = value; }
        }

        // Check to see if Audiences property is set
        internal bool IsSetAudiences()
        {
            return this._audiences != null && (this._audiences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrincipalIdClaim. 
        /// <para>
        /// The claim that determines the principal in OIDC access tokens. For example, <c>sub</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string PrincipalIdClaim
        {
            get { return this._principalIdClaim; }
            set { this._principalIdClaim = value; }
        }

        // Check to see if PrincipalIdClaim property is set
        internal bool IsSetPrincipalIdClaim()
        {
            return this._principalIdClaim != null;
        }

    }
}