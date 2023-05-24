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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGraphqlApi operation.
    /// Creates a <code>GraphqlApi</code> object.
    /// </summary>
    public partial class CreateGraphqlApiRequest : AmazonAppSyncRequest
    {
        private List<AdditionalAuthenticationProvider> _additionalAuthenticationProviders = new List<AdditionalAuthenticationProvider>();
        private GraphQLApiType _apiType;
        private AuthenticationType _authenticationType;
        private LambdaAuthorizerConfig _lambdaAuthorizerConfig;
        private LogConfig _logConfig;
        private string _mergedApiExecutionRoleArn;
        private string _name;
        private OpenIDConnectConfig _openidConnectConfig;
        private string _ownerContact;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UserPoolConfig _userPoolConfig;
        private GraphQLApiVisibility _visibility;
        private bool? _xrayEnabled;

        /// <summary>
        /// Gets and sets the property AdditionalAuthenticationProviders. 
        /// <para>
        /// A list of additional authentication providers for the <code>GraphqlApi</code> API.
        /// </para>
        /// </summary>
        public List<AdditionalAuthenticationProvider> AdditionalAuthenticationProviders
        {
            get { return this._additionalAuthenticationProviders; }
            set { this._additionalAuthenticationProviders = value; }
        }

        // Check to see if AdditionalAuthenticationProviders property is set
        internal bool IsSetAdditionalAuthenticationProviders()
        {
            return this._additionalAuthenticationProviders != null && this._additionalAuthenticationProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ApiType. 
        /// <para>
        /// The value that indicates whether the GraphQL API is a standard API (<code>GRAPHQL</code>)
        /// or merged API (<code>MERGED</code>).
        /// </para>
        /// </summary>
        public GraphQLApiType ApiType
        {
            get { return this._apiType; }
            set { this._apiType = value; }
        }

        // Check to see if ApiType property is set
        internal bool IsSetApiType()
        {
            return this._apiType != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication type: API key, Identity and Access Management (IAM), OpenID Connect
        /// (OIDC), Amazon Cognito user pools, or Lambda.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerConfig. 
        /// <para>
        /// Configuration for Lambda function authorization.
        /// </para>
        /// </summary>
        public LambdaAuthorizerConfig LambdaAuthorizerConfig
        {
            get { return this._lambdaAuthorizerConfig; }
            set { this._lambdaAuthorizerConfig = value; }
        }

        // Check to see if LambdaAuthorizerConfig property is set
        internal bool IsSetLambdaAuthorizerConfig()
        {
            return this._lambdaAuthorizerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The Amazon CloudWatch Logs configuration.
        /// </para>
        /// </summary>
        public LogConfig LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MergedApiExecutionRoleArn. 
        /// <para>
        /// The Identity and Access Management service role ARN for a merged API. The AppSync
        /// service assumes this role on behalf of the Merged API to validate access to source
        /// APIs at runtime and to prompt the <code>AUTO_MERGE</code> to update the merged API
        /// endpoint with the source API changes automatically.
        /// </para>
        /// </summary>
        public string MergedApiExecutionRoleArn
        {
            get { return this._mergedApiExecutionRoleArn; }
            set { this._mergedApiExecutionRoleArn = value; }
        }

        // Check to see if MergedApiExecutionRoleArn property is set
        internal bool IsSetMergedApiExecutionRoleArn()
        {
            return this._mergedApiExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name for the <code>GraphqlApi</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OpenIDConnectConfig. 
        /// <para>
        /// The OIDC configuration.
        /// </para>
        /// </summary>
        public OpenIDConnectConfig OpenIDConnectConfig
        {
            get { return this._openidConnectConfig; }
            set { this._openidConnectConfig = value; }
        }

        // Check to see if OpenIDConnectConfig property is set
        internal bool IsSetOpenIDConnectConfig()
        {
            return this._openidConnectConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerContact. 
        /// <para>
        /// The owner contact information for an API resource.
        /// </para>
        ///  
        /// <para>
        /// This field accepts any string input with a length of 0 - 256 characters.
        /// </para>
        /// </summary>
        public string OwnerContact
        {
            get { return this._ownerContact; }
            set { this._ownerContact = value; }
        }

        // Check to see if OwnerContact property is set
        internal bool IsSetOwnerContact()
        {
            return this._ownerContact != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A <code>TagMap</code> object.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolConfig. 
        /// <para>
        /// The Amazon Cognito user pool configuration.
        /// </para>
        /// </summary>
        public UserPoolConfig UserPoolConfig
        {
            get { return this._userPoolConfig; }
            set { this._userPoolConfig = value; }
        }

        // Check to see if UserPoolConfig property is set
        internal bool IsSetUserPoolConfig()
        {
            return this._userPoolConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Sets the value of the GraphQL API to public (<code>GLOBAL</code>) or private (<code>PRIVATE</code>).
        /// If no value is provided, the visibility will be set to <code>GLOBAL</code> by default.
        /// This value cannot be changed once the API has been created.
        /// </para>
        /// </summary>
        public GraphQLApiVisibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

        /// <summary>
        /// Gets and sets the property XrayEnabled. 
        /// <para>
        /// A flag indicating whether to use X-Ray tracing for the <code>GraphqlApi</code>.
        /// </para>
        /// </summary>
        public bool XrayEnabled
        {
            get { return this._xrayEnabled.GetValueOrDefault(); }
            set { this._xrayEnabled = value; }
        }

        // Check to see if XrayEnabled property is set
        internal bool IsSetXrayEnabled()
        {
            return this._xrayEnabled.HasValue; 
        }

    }
}