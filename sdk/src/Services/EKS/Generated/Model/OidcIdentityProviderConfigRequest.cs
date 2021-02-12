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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing an OpenID Connect (OIDC) configuration. Before associating
    /// an OIDC identity provider to your cluster, review the considerations in <a href="https://docs.aws.amazon.com/eks/latest/userguide/authenticate-oidc-identity-provider.html">Authenticating
    /// users for your cluster from an OpenID Connect identity provider</a> in the <i>Amazon
    /// EKS User Guide</i>.
    /// </summary>
    public partial class OidcIdentityProviderConfigRequest
    {
        private string _clientId;
        private string _groupsClaim;
        private string _groupsPrefix;
        private string _identityProviderConfigName;
        private string _issuerUrl;
        private Dictionary<string, string> _requiredClaims = new Dictionary<string, string>();
        private string _usernameClaim;
        private string _usernamePrefix;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// This is also known as <i>audience</i>. The ID for the client application that makes
        /// authentication requests to the OpenID identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupsClaim. 
        /// <para>
        /// The JWT claim that the provider uses to return your groups.
        /// </para>
        /// </summary>
        public string GroupsClaim
        {
            get { return this._groupsClaim; }
            set { this._groupsClaim = value; }
        }

        // Check to see if GroupsClaim property is set
        internal bool IsSetGroupsClaim()
        {
            return this._groupsClaim != null;
        }

        /// <summary>
        /// Gets and sets the property GroupsPrefix. 
        /// <para>
        /// The prefix that is prepended to group claims to prevent clashes with existing names
        /// (such as <code>system:</code> groups). For example, the value<code> oidc:</code> will
        /// create group names like <code>oidc:engineering</code> and <code>oidc:infra</code>.
        /// </para>
        /// </summary>
        public string GroupsPrefix
        {
            get { return this._groupsPrefix; }
            set { this._groupsPrefix = value; }
        }

        // Check to see if GroupsPrefix property is set
        internal bool IsSetGroupsPrefix()
        {
            return this._groupsPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderConfigName. 
        /// <para>
        /// The name of the OIDC provider configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityProviderConfigName
        {
            get { return this._identityProviderConfigName; }
            set { this._identityProviderConfigName = value; }
        }

        // Check to see if IdentityProviderConfigName property is set
        internal bool IsSetIdentityProviderConfigName()
        {
            return this._identityProviderConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The URL of the OpenID identity provider that allows the API server to discover public
        /// signing keys for verifying tokens. The URL must begin with <code>https://</code> and
        /// should correspond to the <code>iss</code> claim in the provider's OIDC ID tokens.
        /// Per the OIDC standard, path components are allowed but query parameters are not. Typically
        /// the URL consists of only a hostname, like <code>https://server.example.org</code>
        /// or <code>https://example.com</code>. This URL should point to the level below <code>.well-known/openid-configuration</code>
        /// and must be publicly accessible over the internet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IssuerUrl
        {
            get { return this._issuerUrl; }
            set { this._issuerUrl = value; }
        }

        // Check to see if IssuerUrl property is set
        internal bool IsSetIssuerUrl()
        {
            return this._issuerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredClaims. 
        /// <para>
        /// The key value pairs that describe required claims in the identity token. If set, each
        /// claim is verified to be present in the token with a matching value. For the maximum
        /// number of claims that you can require, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/service-quotas.html">Amazon
        /// EKS service quotas</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequiredClaims
        {
            get { return this._requiredClaims; }
            set { this._requiredClaims = value; }
        }

        // Check to see if RequiredClaims property is set
        internal bool IsSetRequiredClaims()
        {
            return this._requiredClaims != null && this._requiredClaims.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsernameClaim. 
        /// <para>
        /// The JSON Web Token (JWT) claim to use as the username. The default is <code>sub</code>,
        /// which is expected to be a unique identifier of the end user. You can choose other
        /// claims, such as <code>email</code> or <code>name</code>, depending on the OpenID identity
        /// provider. Claims other than <code>email</code> are prefixed with the issuer URL to
        /// prevent naming clashes with other plug-ins.
        /// </para>
        /// </summary>
        public string UsernameClaim
        {
            get { return this._usernameClaim; }
            set { this._usernameClaim = value; }
        }

        // Check to see if UsernameClaim property is set
        internal bool IsSetUsernameClaim()
        {
            return this._usernameClaim != null;
        }

        /// <summary>
        /// Gets and sets the property UsernamePrefix. 
        /// <para>
        /// The prefix that is prepended to username claims to prevent clashes with existing names.
        /// If you do not provide this field, and <code>username</code> is a value other than
        /// <code>email</code>, the prefix defaults to <code>issuerurl#</code>. You can use the
        /// value <code>-</code> to disable all prefixing.
        /// </para>
        /// </summary>
        public string UsernamePrefix
        {
            get { return this._usernamePrefix; }
            set { this._usernamePrefix = value; }
        }

        // Check to see if UsernamePrefix property is set
        internal bool IsSetUsernamePrefix()
        {
            return this._usernamePrefix != null;
        }

    }
}