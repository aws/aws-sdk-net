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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an AppSync Graph QL API, which lets you query multiple databases,
    /// microservices, and APIs from a single GraphQL endpoint.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiDetails
    {
        private List<AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails> _additionalAuthenticationProviders = AWSConfigs.InitializeCollections ? new List<AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails>() : null;
        private string _apiId;
        private string _arn;
        private string _authenticationType;
        private string _id;
        private AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetails _lambdaAuthorizerConfig;
        private AwsAppSyncGraphQlApiLogConfigDetails _logConfig;
        private string _name;
        private AwsAppSyncGraphQlApiOpenIdConnectConfigDetails _openIdConnectConfig;
        private AwsAppSyncGraphQlApiUserPoolConfigDetails _userPoolConfig;
        private string _wafWebAclArn;
        private bool? _xrayEnabled;

        /// <summary>
        /// Gets and sets the property AdditionalAuthenticationProviders. 
        /// <para>
        ///  A list of additional authentication providers for the GraphQL API. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails> AdditionalAuthenticationProviders
        {
            get { return this._additionalAuthenticationProviders; }
            set { this._additionalAuthenticationProviders = value; }
        }

        // Check to see if AdditionalAuthenticationProviders property is set
        internal bool IsSetAdditionalAuthenticationProviders()
        {
            return this._additionalAuthenticationProviders != null && (this._additionalAuthenticationProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        ///  The unique identifier for the API. 
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the API. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        ///  The type of security configuration for your GraphQL API: API key, Identity and Access
        /// Management (IAM), OpenID Connect (OIDC), Amazon Cognito user pools, or Lambda. 
        /// </para>
        /// </summary>
        public string AuthenticationType
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the API.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerConfig. 
        /// <para>
        ///  Specifies the configuration for Lambda function authorization. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetails LambdaAuthorizerConfig
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
        ///  The Amazon CloudWatch Logs configuration. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiLogConfigDetails LogConfig
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The API name. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OpenIdConnectConfig. 
        /// <para>
        ///  Specifies the authorization configuration for using an OpenID Connect compliant service
        /// with an AppSync GraphQL API endpoint. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiOpenIdConnectConfigDetails OpenIdConnectConfig
        {
            get { return this._openIdConnectConfig; }
            set { this._openIdConnectConfig = value; }
        }

        // Check to see if OpenIdConnectConfig property is set
        internal bool IsSetOpenIdConnectConfig()
        {
            return this._openIdConnectConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolConfig. 
        /// <para>
        ///  The Amazon Cognito user pools configuration. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiUserPoolConfigDetails UserPoolConfig
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
        /// Gets and sets the property WafWebAclArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the WAF web access control list (web ACL) associated
        /// with this GraphQL API, if one exists. 
        /// </para>
        /// </summary>
        public string WafWebAclArn
        {
            get { return this._wafWebAclArn; }
            set { this._wafWebAclArn = value; }
        }

        // Check to see if WafWebAclArn property is set
        internal bool IsSetWafWebAclArn()
        {
            return this._wafWebAclArn != null;
        }

        /// <summary>
        /// Gets and sets the property XrayEnabled. 
        /// <para>
        ///  Indicates whether to use X-Ray tracing for the GraphQL API. 
        /// </para>
        /// </summary>
        public bool? XrayEnabled
        {
            get { return this._xrayEnabled; }
            set { this._xrayEnabled = value; }
        }

        // Check to see if XrayEnabled property is set
        internal bool IsSetXrayEnabled()
        {
            return this._xrayEnabled.HasValue; 
        }

    }
}