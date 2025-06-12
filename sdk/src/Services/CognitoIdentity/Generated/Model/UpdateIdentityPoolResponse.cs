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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
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
    /// An object representing an Amazon Cognito identity pool.
    /// </summary>
    public partial class UpdateIdentityPoolResponse : AmazonWebServiceResponse
    {
        private bool? _allowClassicFlow;
        private bool? _allowUnauthenticatedIdentities;
        private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders = AWSConfigs.InitializeCollections ? new List<CognitoIdentityProviderInfo>() : null;
        private string _developerProviderName;
        private string _identityPoolId;
        private string _identityPoolName;
        private Dictionary<string, string> _identityPoolTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _openIdConnectProviderARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _samlProviderARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _supportedLoginProviders = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowClassicFlow. 
        /// <para>
        /// Enables or disables the Basic (Classic) authentication flow. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authentication-flow.html">Identity
        /// Pools (Federated Identities) Authentication Flow</a> in the <i>Amazon Cognito Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool? AllowClassicFlow
        {
            get { return this._allowClassicFlow; }
            set { this._allowClassicFlow = value; }
        }

        // Check to see if AllowClassicFlow property is set
        internal bool IsSetAllowClassicFlow()
        {
            return this._allowClassicFlow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowUnauthenticatedIdentities. 
        /// <para>
        /// TRUE if the identity pool supports unauthenticated logins.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AllowUnauthenticatedIdentities
        {
            get { return this._allowUnauthenticatedIdentities; }
            set { this._allowUnauthenticatedIdentities = value; }
        }

        // Check to see if AllowUnauthenticatedIdentities property is set
        internal bool IsSetAllowUnauthenticatedIdentities()
        {
            return this._allowUnauthenticatedIdentities.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CognitoIdentityProviders. 
        /// <para>
        /// A list representing an Amazon Cognito user pool and its client ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
        {
            get { return this._cognitoIdentityProviders; }
            set { this._cognitoIdentityProviders = value; }
        }

        // Check to see if CognitoIdentityProviders property is set
        internal bool IsSetCognitoIdentityProviders()
        {
            return this._cognitoIdentityProviders != null && (this._cognitoIdentityProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeveloperProviderName. 
        /// <para>
        /// The "domain" by which Cognito will refer to your users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DeveloperProviderName
        {
            get { return this._developerProviderName; }
            set { this._developerProviderName = value; }
        }

        // Check to see if DeveloperProviderName property is set
        internal bool IsSetDeveloperProviderName()
        {
            return this._developerProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolName. 
        /// <para>
        /// A string that you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string IdentityPoolName
        {
            get { return this._identityPoolName; }
            set { this._identityPoolName = value; }
        }

        // Check to see if IdentityPoolName property is set
        internal bool IsSetIdentityPoolName()
        {
            return this._identityPoolName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolTags. 
        /// <para>
        /// The tags that are assigned to the identity pool. A tag is a label that you can apply
        /// to identity pools to categorize and manage them in different ways, such as by purpose,
        /// owner, environment, or other criteria.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IdentityPoolTags
        {
            get { return this._identityPoolTags; }
            set { this._identityPoolTags = value; }
        }

        // Check to see if IdentityPoolTags property is set
        internal bool IsSetIdentityPoolTags()
        {
            return this._identityPoolTags != null && (this._identityPoolTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OpenIdConnectProviderARNs. 
        /// <para>
        /// The ARNs of the OpenID Connect providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OpenIdConnectProviderARNs
        {
            get { return this._openIdConnectProviderARNs; }
            set { this._openIdConnectProviderARNs = value; }
        }

        // Check to see if OpenIdConnectProviderARNs property is set
        internal bool IsSetOpenIdConnectProviderARNs()
        {
            return this._openIdConnectProviderARNs != null && (this._openIdConnectProviderARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SamlProviderARNs. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) of the SAML provider for your identity pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SamlProviderARNs
        {
            get { return this._samlProviderARNs; }
            set { this._samlProviderARNs = value; }
        }

        // Check to see if SamlProviderARNs property is set
        internal bool IsSetSamlProviderARNs()
        {
            return this._samlProviderARNs != null && (this._samlProviderARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedLoginProviders. 
        /// <para>
        /// Optional key:value pairs mapping provider names to provider app IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, string> SupportedLoginProviders
        {
            get { return this._supportedLoginProviders; }
            set { this._supportedLoginProviders = value; }
        }

        // Check to see if SupportedLoginProviders property is set
        internal bool IsSetSupportedLoginProviders()
        {
            return this._supportedLoginProviders != null && (this._supportedLoginProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}