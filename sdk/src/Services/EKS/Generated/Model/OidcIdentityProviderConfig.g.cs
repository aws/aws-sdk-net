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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the configuration for an OpenID Connect (OIDC) identity provider.
    /// </summary>
    public partial class OidcIdentityProviderConfig
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// This is also known as <i>audience</i>. The ID of the client application that makes
        /// authentication requests to the OIDC identity provider.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property GroupsClaim. 
        /// <para>
        /// The JSON web token (JWT) claim that the provider uses to return your groups.
        /// </para>
        /// </summary>
        public string GroupsClaim { get; set; }

        /// <summary>
        /// Checks to see if the GroupsClaim property is set.
        /// </summary>
        internal bool IsSetGroupsClaim() => this.GroupsClaim != null;

        /// <summary>
        /// Gets and sets the property GroupsPrefix. 
        /// <para>
        /// The prefix that is prepended to group claims to prevent clashes with existing names
        /// (such as <c>system:</c> groups). For example, the value<c> oidc:</c> creates group
        /// names like <c>oidc:engineering</c> and <c>oidc:infra</c>. The prefix can't contain
        /// <c>system:</c> 
        /// </para>
        /// </summary>
        public string GroupsPrefix { get; set; }

        /// <summary>
        /// Checks to see if the GroupsPrefix property is set.
        /// </summary>
        internal bool IsSetGroupsPrefix() => this.GroupsPrefix != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfigArn. 
        /// <para>
        /// The ARN of the configuration.
        /// </para>
        /// </summary>
        public string IdentityProviderConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderConfigArn property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfigArn() => this.IdentityProviderConfigArn != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderConfigName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        public string IdentityProviderConfigName { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderConfigName property is set.
        /// </summary>
        internal bool IsSetIdentityProviderConfigName() => this.IdentityProviderConfigName != null;

        /// <summary>
        /// Gets and sets the property IssuerUrl. 
        /// <para>
        /// The URL of the OIDC identity provider that allows the API server to discover public
        /// signing keys for verifying tokens.
        /// </para>
        /// </summary>
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Checks to see if the IssuerUrl property is set.
        /// </summary>
        internal bool IsSetIssuerUrl() => this.IssuerUrl != null;

        /// <summary>
        /// Gets and sets the property RequiredClaims. 
        /// <para>
        /// The key-value pairs that describe required claims in the identity token. If set, each
        /// claim is verified to be present in the token with a matching value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequiredClaims { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequiredClaims property is set.
        /// </summary>
        internal bool IsSetRequiredClaims() => this.RequiredClaims != null && (this.RequiredClaims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the OIDC identity provider.
        /// </para>
        /// </summary>
        public ConfigStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsernameClaim. 
        /// <para>
        /// The JSON Web token (JWT) claim that is used as the username.
        /// </para>
        /// </summary>
        public string UsernameClaim { get; set; }

        /// <summary>
        /// Checks to see if the UsernameClaim property is set.
        /// </summary>
        internal bool IsSetUsernameClaim() => this.UsernameClaim != null;

        /// <summary>
        /// Gets and sets the property UsernamePrefix. 
        /// <para>
        /// The prefix that is prepended to username claims to prevent clashes with existing names.
        /// The prefix can't contain <c>system:</c> 
        /// </para>
        /// </summary>
        public string UsernamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the UsernamePrefix property is set.
        /// </summary>
        internal bool IsSetUsernamePrefix() => this.UsernamePrefix != null;
    }
}
