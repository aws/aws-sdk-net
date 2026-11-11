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

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// This is the response object from the CreateIdentityPool operation.
    /// </summary>
    public partial class CreateIdentityPoolResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowClassicFlow. 
        /// <para>
        /// Enables or disables the Basic (Classic) authentication flow. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flow.html">Identity
        /// Pools (Federated Identities) Authentication Flow</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool? AllowClassicFlow { get; set; }

        /// <summary>
        /// Checks to see if the AllowClassicFlow property is set.
        /// </summary>
        internal bool IsSetAllowClassicFlow() => this.AllowClassicFlow.HasValue;

        /// <summary>
        /// Gets and sets the property AllowUnauthenticatedIdentities. 
        /// <para>
        /// TRUE if the identity pool supports unauthenticated logins.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowUnauthenticatedIdentities { get; set; }

        /// <summary>
        /// Checks to see if the AllowUnauthenticatedIdentities property is set.
        /// </summary>
        internal bool IsSetAllowUnauthenticatedIdentities() => this.AllowUnauthenticatedIdentities.HasValue;

        /// <summary>
        /// Gets and sets the property CognitoIdentityProviders. 
        /// <para>
        /// A list representing an Amazon Cognito user pool and its client ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CognitoIdentityProviderInfo> CognitoIdentityProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<CognitoIdentityProviderInfo>() : null;

        /// <summary>
        /// Checks to see if the CognitoIdentityProviders property is set.
        /// </summary>
        internal bool IsSetCognitoIdentityProviders() => this.CognitoIdentityProviders != null && (this.CognitoIdentityProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeveloperProviderName. 
        /// <para>
        /// The "domain" by which Cognito will refer to your users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DeveloperProviderName { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperProviderName property is set.
        /// </summary>
        internal bool IsSetDeveloperProviderName() => this.DeveloperProviderName != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolName. 
        /// <para>
        /// A string that you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string IdentityPoolName { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolName property is set.
        /// </summary>
        internal bool IsSetIdentityPoolName() => this.IdentityPoolName != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolTags. 
        /// <para>
        /// The tags that are assigned to the identity pool. A tag is a label that you can apply
        /// to identity pools to categorize and manage them in different ways, such as by purpose,
        /// owner, environment, or other criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IdentityPoolTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IdentityPoolTags property is set.
        /// </summary>
        internal bool IsSetIdentityPoolTags() => this.IdentityPoolTags != null && (this.IdentityPoolTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpenIdConnectProviderARNs. 
        /// <para>
        /// The ARNs of the OpenID Connect providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OpenIdConnectProviderARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OpenIdConnectProviderARNs property is set.
        /// </summary>
        internal bool IsSetOpenIdConnectProviderARNs() => this.OpenIdConnectProviderARNs != null && (this.OpenIdConnectProviderARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SamlProviderARNs. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) of the SAML provider for your identity pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SamlProviderARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SamlProviderARNs property is set.
        /// </summary>
        internal bool IsSetSamlProviderARNs() => this.SamlProviderARNs != null && (this.SamlProviderARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportedLoginProviders. 
        /// <para>
        /// Optional key:value pairs mapping provider names to provider app IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> SupportedLoginProviders { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SupportedLoginProviders property is set.
        /// </summary>
        internal bool IsSetSupportedLoginProviders() => this.SupportedLoginProviders != null && (this.SupportedLoginProviders.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
