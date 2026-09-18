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
    /// Provides details about an AppSync Graph QL API, which lets you query multiple databases,
    /// microservices, and APIs from a single GraphQL endpoint.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiDetails
    {
        /// <summary>
        /// Gets and sets the property AdditionalAuthenticationProviders. 
        /// <para>
        ///  A list of additional authentication providers for the GraphQL API. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails> AdditionalAuthenticationProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetails>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAuthenticationProviders property is set.
        /// </summary>
        internal bool IsSetAdditionalAuthenticationProviders() => this.AdditionalAuthenticationProviders != null && (this.AdditionalAuthenticationProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        ///  The unique identifier for the API. 
        /// </para>
        /// </summary>
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the API. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the API.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerConfig. 
        /// <para>
        ///  Specifies the configuration for Lambda function authorization. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetails LambdaAuthorizerConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaAuthorizerConfig property is set.
        /// </summary>
        internal bool IsSetLambdaAuthorizerConfig() => this.LambdaAuthorizerConfig != null;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        ///  The Amazon CloudWatch Logs configuration. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiLogConfigDetails LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The API name. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenIdConnectConfig. 
        /// <para>
        ///  Specifies the authorization configuration for using an OpenID Connect compliant service
        /// with an AppSync GraphQL API endpoint. 
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

        /// <summary>
        /// Gets and sets the property WafWebAclArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the WAF web access control list (web ACL) associated
        /// with this GraphQL API, if one exists. 
        /// </para>
        /// </summary>
        public string WafWebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WafWebAclArn property is set.
        /// </summary>
        internal bool IsSetWafWebAclArn() => this.WafWebAclArn != null;

        /// <summary>
        /// Gets and sets the property XrayEnabled. 
        /// <para>
        ///  Indicates whether to use X-Ray tracing for the GraphQL API. 
        /// </para>
        /// </summary>
        public bool? XrayEnabled { get; set; }

        /// <summary>
        /// Checks to see if the XrayEnabled property is set.
        /// </summary>
        internal bool IsSetXrayEnabled() => this.XrayEnabled.HasValue;
    }
}
