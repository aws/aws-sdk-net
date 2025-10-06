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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Container for the parameters to the GetResourceOauth2Token operation.
    /// Returns the OAuth 2.0 token of the provided resource.
    /// </summary>
    public partial class GetResourceOauth2TokenRequest : AmazonBedrockAgentCoreRequest
    {
        private Dictionary<string, string> _customParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _forceAuthentication;
        private Oauth2FlowType _oauth2Flow;
        private string _resourceCredentialProviderName;
        private string _resourceOauth2ReturnUrl;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workloadIdentityToken;

        /// <summary>
        /// Gets and sets the property CustomParameters. 
        /// <para>
        /// A map of custom parameters to include in the authorization request to the resource
        /// credential provider. These parameters are in addition to the standard OAuth 2.0 flow
        /// parameters, and will not override them.
        /// </para>
        /// </summary>
        public Dictionary<string, string> CustomParameters
        {
            get { return this._customParameters; }
            set { this._customParameters = value; }
        }

        // Check to see if CustomParameters property is set
        internal bool IsSetCustomParameters()
        {
            return this._customParameters != null && (this._customParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ForceAuthentication. 
        /// <para>
        /// Indicates whether to always initiate a new three-legged OAuth (3LO) flow, regardless
        /// of any existing session.
        /// </para>
        /// </summary>
        public bool ForceAuthentication
        {
            get { return this._forceAuthentication.GetValueOrDefault(); }
            set { this._forceAuthentication = value; }
        }

        // Check to see if ForceAuthentication property is set
        internal bool IsSetForceAuthentication()
        {
            return this._forceAuthentication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Oauth2Flow. 
        /// <para>
        /// The type of flow to be performed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Oauth2FlowType Oauth2Flow
        {
            get { return this._oauth2Flow; }
            set { this._oauth2Flow = value; }
        }

        // Check to see if Oauth2Flow property is set
        internal bool IsSetOauth2Flow()
        {
            return this._oauth2Flow != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCredentialProviderName. 
        /// <para>
        /// The name of the resource's credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceCredentialProviderName
        {
            get { return this._resourceCredentialProviderName; }
            set { this._resourceCredentialProviderName = value; }
        }

        // Check to see if ResourceCredentialProviderName property is set
        internal bool IsSetResourceCredentialProviderName()
        {
            return this._resourceCredentialProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOauth2ReturnUrl. 
        /// <para>
        /// The callback URL to redirect to after the OAuth 2.0 token retrieval is complete. This
        /// URL must be one of the provided URLs configured for the workload identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceOauth2ReturnUrl
        {
            get { return this._resourceOauth2ReturnUrl; }
            set { this._resourceOauth2ReturnUrl = value; }
        }

        // Check to see if ResourceOauth2ReturnUrl property is set
        internal bool IsSetResourceOauth2ReturnUrl()
        {
            return this._resourceOauth2ReturnUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes being requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && (this._scopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityToken. 
        /// <para>
        /// The identity token of the workload from which you want to retrieve the OAuth2 token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=131072)]
        public string WorkloadIdentityToken
        {
            get { return this._workloadIdentityToken; }
            set { this._workloadIdentityToken = value; }
        }

        // Check to see if WorkloadIdentityToken property is set
        internal bool IsSetWorkloadIdentityToken()
        {
            return this._workloadIdentityToken != null;
        }

    }
}