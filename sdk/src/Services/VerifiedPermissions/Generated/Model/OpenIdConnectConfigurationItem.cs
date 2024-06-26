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
    /// Contains configuration details of an OpenID Connect (OIDC) identity provider, or identity
    /// source, that Verified Permissions can use to generate entities from authenticated
    /// identities. It specifies the issuer URL, token type that you want to use, and policy
    /// store entity details.
    /// 
    ///  
    /// <para>
    /// This data type is part of a <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ConfigurationDetail.html">ConfigurationItem</a>
    /// structure, which is a parameter to <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListIdentitySources.html">ListIdentitySources</a>.
    /// </para>
    /// </summary>
    public partial class OpenIdConnectConfigurationItem
    {
        private string _entityIdPrefix;
        private OpenIdConnectGroupConfigurationItem _groupConfiguration;
        private string _issuer;
        private OpenIdConnectTokenSelectionItem _tokenSelection;

        /// <summary>
        /// Gets and sets the property EntityIdPrefix. 
        /// <para>
        /// A descriptive string that you want to prefix to user entities from your OIDC identity
        /// provider. For example, if you set an <c>entityIdPrefix</c> of <c>MyOIDCProvider</c>,
        /// you can reference principals in your policies in the format <c>MyCorp::User::MyOIDCProvider|Carlos</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string EntityIdPrefix
        {
            get { return this._entityIdPrefix; }
            set { this._entityIdPrefix = value; }
        }

        // Check to see if EntityIdPrefix property is set
        internal bool IsSetEntityIdPrefix()
        {
            return this._entityIdPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property GroupConfiguration. 
        /// <para>
        /// The claim in OIDC identity provider tokens that indicates a user's group membership,
        /// and the entity type that you want to map it to. For example, this object can map the
        /// contents of a <c>groups</c> claim to <c>MyCorp::UserGroup</c>.
        /// </para>
        /// </summary>
        public OpenIdConnectGroupConfigurationItem GroupConfiguration
        {
            get { return this._groupConfiguration; }
            set { this._groupConfiguration = value; }
        }

        // Check to see if GroupConfiguration property is set
        internal bool IsSetGroupConfiguration()
        {
            return this._groupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL of an OIDC identity provider. This URL must have an OIDC discovery
        /// endpoint at the path <c>.well-known/openid-configuration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property TokenSelection. 
        /// <para>
        /// The token type that you want to process from your OIDC identity provider. Your policy
        /// store can process either identity (ID) or access tokens from a given OIDC identity
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenIdConnectTokenSelectionItem TokenSelection
        {
            get { return this._tokenSelection; }
            set { this._tokenSelection = value; }
        }

        // Check to see if TokenSelection property is set
        internal bool IsSetTokenSelection()
        {
            return this._tokenSelection != null;
        }

    }
}