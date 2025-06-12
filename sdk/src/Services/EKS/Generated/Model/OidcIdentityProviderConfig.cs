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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the configuration for an OpenID Connect (OIDC) identity provider.
    /// </summary>
    public partial class OidcIdentityProviderConfig
    {
        private string _clientId;
        private string _clusterName;
        private string _groupsClaim;
        private string _groupsPrefix;
        private string _identityProviderConfigArn;
        private string _identityProviderConfigName;
        private string _issuerUrl;
        private Dictionary<string, string> _requiredClaims = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ConfigStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _usernameClaim;
        private string _usernamePrefix;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// This is also known as <i>audience</i>. The ID of the client application that makes
        /// authentication requests to the OIDC identity provider.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupsClaim. 
        /// <para>
        /// The JSON web token (JWT) claim that the provider uses to return your groups.
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
        /// (such as <c>system:</c> groups). For example, the value<c> oidc:</c> creates group
        /// names like <c>oidc:engineering</c> and <c>oidc:infra</c>. The prefix can't contain
        /// <c>system:</c> 
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
        /// Gets and sets the property IdentityProviderConfigArn. 
        /// <para>
        /// The ARN of the configuration.
        /// </para>
        /// </summary>
        public string IdentityProviderConfigArn
        {
            get { return this._identityProviderConfigArn; }
            set { this._identityProviderConfigArn = value; }
        }

        // Check to see if IdentityProviderConfigArn property is set
        internal bool IsSetIdentityProviderConfigArn()
        {
            return this._identityProviderConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderConfigName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
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
        /// The URL of the OIDC identity provider that allows the API server to discover public
        /// signing keys for verifying tokens.
        /// </para>
        /// </summary>
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
        /// The key-value pairs that describe required claims in the identity token. If set, each
        /// claim is verified to be present in the token with a matching value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequiredClaims
        {
            get { return this._requiredClaims; }
            set { this._requiredClaims = value; }
        }

        // Check to see if RequiredClaims property is set
        internal bool IsSetRequiredClaims()
        {
            return this._requiredClaims != null && (this._requiredClaims.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the OIDC identity provider.
        /// </para>
        /// </summary>
        public ConfigStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UsernameClaim. 
        /// <para>
        /// The JSON Web token (JWT) claim that is used as the username.
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
        /// The prefix can't contain <c>system:</c> 
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