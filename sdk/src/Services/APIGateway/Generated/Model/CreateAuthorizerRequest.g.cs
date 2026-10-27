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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuthorizer operation. Adds a new Authorizer
    /// resource to an existing RestApi resource.
    /// </summary>
    public partial class CreateAuthorizerRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// Optional customer-defined field, used in OpenAPI imports and exports without functional
        /// impact.
        /// </para>
        /// </summary>
        public string AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property AuthorizerCredentials. 
        /// <para>
        /// Specifies the required credentials as an IAM role for API Gateway to invoke the authorizer.
        /// To specify an IAM role for API Gateway to assume, use the role's Amazon Resource Name
        /// (ARN). To use resource-based permissions on the Lambda function, specify null.
        /// </para>
        /// </summary>
        public string AuthorizerCredentials { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerCredentials property is set.
        /// </summary>
        internal bool IsSetAuthorizerCredentials() => this.AuthorizerCredentials != null;

        /// <summary>
        /// Gets and sets the property AuthorizerResultTtlInSeconds. 
        /// <para>
        /// The TTL in seconds of cached authorizer results. If it equals 0, authorization caching
        /// is disabled. If it is greater than 0, API Gateway will cache authorizer responses.
        /// If this field is not set, the default value is 300. The maximum value is 3600, or
        /// 1 hour.
        /// </para>
        /// </summary>
        public int? AuthorizerResultTtlInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerResultTtlInSeconds property is set.
        /// </summary>
        internal bool IsSetAuthorizerResultTtlInSeconds() => this.AuthorizerResultTtlInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AuthorizerUri. 
        /// <para>
        /// Specifies the authorizer's Uniform Resource Identifier (URI). For <c>TOKEN</c> or
        /// <c>REQUEST</c> authorizers, this must be a well-formed Lambda function URI, for example,
        /// <c>arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:{account_id}:function:{lambda_function_name}/invocations</c>.
        /// In general, the URI has this form <c>arn:aws:apigateway:{region}:lambda:path/{service_api}</c>,
        /// where <c>{region}</c> is the same as the region hosting the Lambda function, <c>path</c>
        /// indicates that the remaining substring in the URI should be treated as the path to
        /// the resource, including the initial <c>/</c>. For Lambda functions, this is usually
        /// of the form <c>/2015-03-31/functions/[FunctionARN]/invocations</c>.
        /// </para>
        /// </summary>
        public string AuthorizerUri { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizerUri property is set.
        /// </summary>
        internal bool IsSetAuthorizerUri() => this.AuthorizerUri != null;

        /// <summary>
        /// Gets and sets the property IdentitySource. 
        /// <para>
        /// The identity source for which authorization is requested. For a <c>TOKEN</c> or <c>COGNITO_USER_POOLS</c>
        /// authorizer, this is required and specifies the request header mapping expression for
        /// the custom header holding the authorization token submitted by the client. For example,
        /// if the token header name is <c>Auth</c>, the header mapping expression is <c>method.request.header.Auth</c>.
        /// For the <c>REQUEST</c> authorizer, this is required when authorization caching is
        /// enabled. The value is a comma-separated string of one or more mapping expressions
        /// of the specified request parameters. For example, if an <c>Auth</c> header, a <c>Name</c>
        /// query string parameter are defined as identity sources, this value is <c>method.request.header.Auth,
        /// method.request.querystring.Name</c>. These parameters will be used to derive the authorization
        /// caching key and to perform runtime validation of the <c>REQUEST</c> authorizer by
        /// verifying all of the identity-related request parameters are present, not null and
        /// non-empty. Only when this is true does the authorizer invoke the authorizer Lambda
        /// function, otherwise, it returns a 401 Unauthorized response without calling the Lambda
        /// function. The valid value is a string of comma-separated mapping expressions of the
        /// specified request parameters. When the authorization caching is not enabled, this
        /// property is optional.
        /// </para>
        /// </summary>
        public string IdentitySource { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySource property is set.
        /// </summary>
        internal bool IsSetIdentitySource() => this.IdentitySource != null;

        /// <summary>
        /// Gets and sets the property IdentityValidationExpression. 
        /// <para>
        /// A validation expression for the incoming identity token. For <c>TOKEN</c> authorizers,
        /// this value is a regular expression. For <c>COGNITO_USER_POOLS</c> authorizers, API
        /// Gateway will match the <c>aud</c> field of the incoming token from the client against
        /// the specified regular expression. It will invoke the authorizer's Lambda function
        /// when there is a match. Otherwise, it will return a 401 Unauthorized response without
        /// calling the Lambda function. The validation expression does not apply to the <c>REQUEST</c>
        /// authorizer.
        /// </para>
        /// </summary>
        public string IdentityValidationExpression { get; set; }

        /// <summary>
        /// Checks to see if the IdentityValidationExpression property is set.
        /// </summary>
        internal bool IsSetIdentityValidationExpression() => this.IdentityValidationExpression != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the authorizer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderARNs. 
        /// <para>
        /// A list of the Amazon Cognito user pool ARNs for the <c>COGNITO_USER_POOLS</c> authorizer.
        /// Each element is of this format: <c>arn:aws:cognito-idp:{region}:{account_id}:userpool/{user_pool_id}</c>.
        /// For a <c>TOKEN</c> or <c>REQUEST</c> authorizer, this is not defined. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProviderARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProviderARNs property is set.
        /// </summary>
        internal bool IsSetProviderARNs() => this.ProviderARNs != null && (this.ProviderARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestApiId { get; set; }

        /// <summary>
        /// Checks to see if the RestApiId property is set.
        /// </summary>
        internal bool IsSetRestApiId() => this.RestApiId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The authorizer type. Valid values are <c>TOKEN</c> for a Lambda function using a single
        /// authorization token submitted in a custom header, <c>REQUEST</c> for a Lambda function
        /// using incoming request parameters, and <c>COGNITO_USER_POOLS</c> for using an Amazon
        /// Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthorizerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
