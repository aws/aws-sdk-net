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
    /// Container for the parameters to the CreateIdentityPool operation. Creates a new identity
    /// pool. The identity pool is a store of user identity information that is specific to
    /// your Amazon Web Services account. The keys for <c>SupportedLoginProviders</c> are
    /// as follows: <ul> <li> <para> Facebook: <c>graph.facebook.com</c> </para> </li> <li>
    /// <para> Google: <c>accounts.google.com</c> </para> </li> <li> <para> Sign in With Apple:
    /// <c>appleid.apple.com</c> </para> </li> <li> <para> Amazon: <c>www.amazon.com</c> </para>
    /// </li> <li> <para> Twitter: <c>api.twitter.com</c> </para> </li> <li> <para> Digits:
    /// <c>www.digits.com</c> </para> </li> </ul> <important> <para> If you don't provide
    /// a value for a parameter, Amazon Cognito sets it to its default value. </para> </important>
    /// <para> You must use Amazon Web Services developer credentials to call this operation.
    /// </para>
    /// </summary>
    public partial class CreateIdentityPoolRequest : AmazonCognitoIdentityRequest
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
        /// An array of Amazon Cognito user pools and their client IDs.
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
        /// The "domain" by which Cognito will refer to your users. This name acts as a placeholder
        /// that allows your backend and the Cognito service to communicate about the developer
        /// provider. For the <c>DeveloperProviderName</c>, you can use letters as well as period
        /// (<c>.</c>), underscore (<c>_</c>), and dash (<c>-</c>).
        /// </para>
        ///  
        /// <para>
        /// Once you have set a developer provider name, you cannot change it. Please take care
        /// in setting this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DeveloperProviderName { get; set; }

        /// <summary>
        /// Checks to see if the DeveloperProviderName property is set.
        /// </summary>
        internal bool IsSetDeveloperProviderName() => this.DeveloperProviderName != null;

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
        /// Tags to assign to the identity pool. A tag is a label that you can apply to identity
        /// pools to categorize and manage them in different ways, such as by purpose, owner,
        /// environment, or other criteria.
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
        /// The Amazon Resource Names (ARN) of the OpenID Connect providers.
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
