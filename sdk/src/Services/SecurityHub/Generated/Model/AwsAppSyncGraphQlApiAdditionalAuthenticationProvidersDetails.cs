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
    /// A list of additional authentication providers for the GraphqlApi API.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails
    {
        private string _authenticationType;
        private AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetails _lambdaAuthorizerConfig;
        private AwsAppSyncGraphQlApiOpenIdConnectConfigDetails _openIdConnectConfig;
        private AwsAppSyncGraphQlApiUserPoolConfigDetails _userPoolConfig;

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
        /// Gets and sets the property LambdaAuthorizerConfig. 
        /// <para>
        ///  The configuration for Lambda function authorization. 
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
        /// Gets and sets the property OpenIdConnectConfig. 
        /// <para>
        ///  The OpenID Connect configuration. 
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

    }
}