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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceOauth2Token operation. Returns the
    /// OAuth 2.0 token of the provided resource.
    /// </summary>
    public partial class GetResourceOauth2TokenRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The audiences to include in the token request. These are used to specify the intended
        /// recipients of the OAuth2 token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Audiences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Audiences property is set.
        /// </summary>
        internal bool IsSetAudiences() => this.Audiences != null && (this.Audiences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomParameters. 
        /// <para>
        /// A map of custom parameters to include in the authorization request to the resource
        /// credential provider. These parameters are in addition to the standard OAuth 2.0 flow
        /// parameters, and will not override them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CustomParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomParameters property is set.
        /// </summary>
        internal bool IsSetCustomParameters() => this.CustomParameters != null && (this.CustomParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomState. 
        /// <para>
        /// An opaque string that will be sent back to the callback URL provided in resourceOauth2ReturnUrl.
        /// This state should be used to protect the callback URL of your application against
        /// CSRF attacks by ensuring the response corresponds to the original request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string CustomState { get; set; }

        /// <summary>
        /// Checks to see if the CustomState property is set.
        /// </summary>
        internal bool IsSetCustomState() => this.CustomState != null;

        /// <summary>
        /// Gets and sets the property ForceAuthentication. 
        /// <para>
        /// Indicates whether to always initiate a new three-legged OAuth (3LO) flow, regardless
        /// of any existing session.
        /// </para>
        /// </summary>
        public bool? ForceAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the ForceAuthentication property is set.
        /// </summary>
        internal bool IsSetForceAuthentication() => this.ForceAuthentication.HasValue;

        /// <summary>
        /// Gets and sets the property Oauth2Flow. 
        /// <para>
        /// The type of flow to be performed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Oauth2FlowType Oauth2Flow { get; set; }

        /// <summary>
        /// Checks to see if the Oauth2Flow property is set.
        /// </summary>
        internal bool IsSetOauth2Flow() => this.Oauth2Flow != null;

        /// <summary>
        /// Gets and sets the property ResourceCredentialProviderName. 
        /// <para>
        /// The name of the resource's credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ResourceCredentialProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCredentialProviderName property is set.
        /// </summary>
        internal bool IsSetResourceCredentialProviderName() => this.ResourceCredentialProviderName != null;

        /// <summary>
        /// Gets and sets the property ResourceOauth2ReturnUrl. 
        /// <para>
        /// The callback URL to redirect to after the OAuth 2.0 token retrieval is complete. This
        /// URL must be one of the provided URLs configured for the workload identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ResourceOauth2ReturnUrl { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOauth2ReturnUrl property is set.
        /// </summary>
        internal bool IsSetResourceOauth2ReturnUrl() => this.ResourceOauth2ReturnUrl != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources to include in the token request. These are used to specify the target
        /// resources for which the OAuth2 token is being requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes being requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionUri. 
        /// <para>
        /// Unique identifier for the user's authentication session for retrieving OAuth2 tokens.
        /// This ID tracks the authorization flow state across multiple requests and responses
        /// during the OAuth2 authentication process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SessionUri { get; set; }

        /// <summary>
        /// Checks to see if the SessionUri property is set.
        /// </summary>
        internal bool IsSetSessionUri() => this.SessionUri != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityToken. 
        /// <para>
        /// The identity token of the workload from which you want to retrieve the OAuth2 token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 131072)]
        public string WorkloadIdentityToken { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityToken property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityToken() => this.WorkloadIdentityToken != null;
    }
}
