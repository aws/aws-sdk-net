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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A list of additional authentication providers for the GraphqlApi API.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        ///  The type of security configuration for your GraphQL API: API key, Identity and Access
        /// Management (IAM), OpenID Connect (OIDC), Amazon Cognito user pools, or Lambda. 
        /// </para>
        /// </summary>
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerConfig. 
        /// <para>
        ///  The configuration for Lambda function authorization. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetails LambdaAuthorizerConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaAuthorizerConfig property is set.
        /// </summary>
        internal bool IsSetLambdaAuthorizerConfig() => this.LambdaAuthorizerConfig != null;

        /// <summary>
        /// Gets and sets the property OpenIdConnectConfig. 
        /// <para>
        ///  The OpenID Connect configuration. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiOpenIdConnectConfigDetails OpenIdConnectConfig { get; set; }

        /// <summary>
        /// Checks to see if the OpenIdConnectConfig property is set.
        /// </summary>
        internal bool IsSetOpenIdConnectConfig() => this.OpenIdConnectConfig != null;

        /// <summary>
        /// Gets and sets the property UserPoolConfig. 
        /// <para>
        ///  The Amazon Cognito user pools configuration. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiUserPoolConfigDetails UserPoolConfig { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolConfig property is set.
        /// </summary>
        internal bool IsSetUserPoolConfig() => this.UserPoolConfig != null;
    }
}
