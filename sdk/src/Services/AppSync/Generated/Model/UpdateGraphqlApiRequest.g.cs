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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGraphqlApi operation. Updates a <c>GraphqlApi</c>
    /// object.
    /// </summary>
    public partial class UpdateGraphqlApiRequest : AmazonAppSyncRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalAuthenticationProviders. 
        /// <para>
        /// A list of additional authentication providers for the <c>GraphqlApi</c> API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalAuthenticationProvider> AdditionalAuthenticationProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalAuthenticationProvider>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAuthenticationProviders property is set.
        /// </summary>
        internal bool IsSetAdditionalAuthenticationProviders() => this.AdditionalAuthenticationProviders != null && (this.AdditionalAuthenticationProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The new authentication type for the <c>GraphqlApi</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property EnhancedMetricsConfig. 
        /// <para>
        /// The <c>enhancedMetricsConfig</c> object.
        /// </para>
        /// </summary>
        public EnhancedMetricsConfig EnhancedMetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMetricsConfig property is set.
        /// </summary>
        internal bool IsSetEnhancedMetricsConfig() => this.EnhancedMetricsConfig != null;

        /// <summary>
        /// Gets and sets the property IntrospectionConfig. 
        /// <para>
        /// Sets the value of the GraphQL API to enable (<c>ENABLED</c>) or disable (<c>DISABLED</c>)
        /// introspection. If no value is provided, the introspection configuration will be set
        /// to <c>ENABLED</c> by default. This field will produce an error if the operation attempts
        /// to use the introspection feature while this field is disabled.
        /// </para>
        ///  
        /// <para>
        /// For more information about introspection, see <a href="https://graphql.org/learn/introspection/">GraphQL
        /// introspection</a>.
        /// </para>
        /// </summary>
        public GraphQLApiIntrospectionConfig IntrospectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the IntrospectionConfig property is set.
        /// </summary>
        internal bool IsSetIntrospectionConfig() => this.IntrospectionConfig != null;

        /// <summary>
        /// Gets and sets the property LambdaAuthorizerConfig. 
        /// <para>
        /// Configuration for Lambda function authorization.
        /// </para>
        /// </summary>
        public LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaAuthorizerConfig property is set.
        /// </summary>
        internal bool IsSetLambdaAuthorizerConfig() => this.LambdaAuthorizerConfig != null;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The Amazon CloudWatch Logs configuration for the <c>GraphqlApi</c> object.
        /// </para>
        /// </summary>
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property MergedApiExecutionRoleArn. 
        /// <para>
        /// The Identity and Access Management service role ARN for a merged API. The AppSync
        /// service assumes this role on behalf of the Merged API to validate access to source
        /// APIs at runtime and to prompt the <c>AUTO_MERGE</c> to update the merged API endpoint
        /// with the source API changes automatically.
        /// </para>
        /// </summary>
        public string MergedApiExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the MergedApiExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetMergedApiExecutionRoleArn() => this.MergedApiExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the <c>GraphqlApi</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenIDConnectConfig. 
        /// <para>
        /// The OpenID Connect configuration for the <c>GraphqlApi</c> object.
        /// </para>
        /// </summary>
        public OpenIDConnectConfig OpenIDConnectConfig { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDConnectConfig property is set.
        /// </summary>
        internal bool IsSetOpenIDConnectConfig() => this.OpenIDConnectConfig != null;

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
        public string OwnerContact { get; set; }

        /// <summary>
        /// Checks to see if the OwnerContact property is set.
        /// </summary>
        internal bool IsSetOwnerContact() => this.OwnerContact != null;

        /// <summary>
        /// Gets and sets the property QueryDepthLimit. 
        /// <para>
        /// The maximum depth a query can have in a single request. Depth refers to the amount
        /// of nested levels allowed in the body of query. The default value is <c>0</c> (or unspecified),
        /// which indicates there's no depth limit. If you set a limit, it can be between <c>1</c>
        /// and <c>75</c> nested levels. This field will produce a limit error if the operation
        /// falls out of bounds.
        /// </para>
        ///  
        /// <para>
        /// Note that fields can still be set to nullable or non-nullable. If a non-nullable field
        /// produces an error, the error will be thrown upwards to the first nullable field available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 75)]
        public int? QueryDepthLimit { get; set; }

        /// <summary>
        /// Checks to see if the QueryDepthLimit property is set.
        /// </summary>
        internal bool IsSetQueryDepthLimit() => this.QueryDepthLimit.HasValue;

        /// <summary>
        /// Gets and sets the property ResolverCountLimit. 
        /// <para>
        /// The maximum number of resolvers that can be invoked in a single request. The default
        /// value is <c>0</c> (or unspecified), which will set the limit to <c>10000</c>. When
        /// specified, the limit value can be between <c>1</c> and <c>10000</c>. This field will
        /// produce a limit error if the operation falls out of bounds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public int? ResolverCountLimit { get; set; }

        /// <summary>
        /// Checks to see if the ResolverCountLimit property is set.
        /// </summary>
        internal bool IsSetResolverCountLimit() => this.ResolverCountLimit.HasValue;

        /// <summary>
        /// Gets and sets the property UserPoolConfig. 
        /// <para>
        /// The new Amazon Cognito user pool configuration for the <c>~GraphqlApi</c> object.
        /// </para>
        /// </summary>
        public UserPoolConfig UserPoolConfig { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolConfig property is set.
        /// </summary>
        internal bool IsSetUserPoolConfig() => this.UserPoolConfig != null;

        /// <summary>
        /// Gets and sets the property XrayEnabled. 
        /// <para>
        /// A flag indicating whether to use X-Ray tracing for the <c>GraphqlApi</c>.
        /// </para>
        /// </summary>
        public bool? XrayEnabled { get; set; }

        /// <summary>
        /// Checks to see if the XrayEnabled property is set.
        /// </summary>
        internal bool IsSetXrayEnabled() => this.XrayEnabled.HasValue;
    }
}
