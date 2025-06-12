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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuthorizer operation.
    /// Creates an Authorizer for an API.
    /// </summary>
    public partial class CreateAuthorizerRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _authorizerCredentialsArn;
        private string _authorizerPayloadFormatVersion;
        private int? _authorizerResultTtlInSeconds;
        private AuthorizerType _authorizerType;
        private string _authorizerUri;
        private bool? _enableSimpleResponses;
        private List<string> _identitySource = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identityValidationExpression;
        private JWTConfiguration _jwtConfiguration;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AuthorizerCredentialsArn. 
        /// <para>
        /// Specifies the required credentials as an IAM role for API Gateway to invoke the authorizer.
        /// To specify an IAM role for API Gateway to assume, use the role's Amazon Resource Name
        /// (ARN). To use resource-based permissions on the Lambda function, don't specify this
        /// parameter. Supported only for REQUEST authorizers.
        /// </para>
        /// </summary>
        public string AuthorizerCredentialsArn
        {
            get { return this._authorizerCredentialsArn; }
            set { this._authorizerCredentialsArn = value; }
        }

        // Check to see if AuthorizerCredentialsArn property is set
        internal bool IsSetAuthorizerCredentialsArn()
        {
            return this._authorizerCredentialsArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerPayloadFormatVersion. 
        /// <para>
        /// Specifies the format of the payload sent to an HTTP API Lambda authorizer. Required
        /// for HTTP API Lambda authorizers. Supported values are 1.0 and 2.0. To learn more,
        /// see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-lambda-authorizer.html">Working
        /// with AWS Lambda authorizers for HTTP APIs</a>.
        /// </para>
        /// </summary>
        public string AuthorizerPayloadFormatVersion
        {
            get { return this._authorizerPayloadFormatVersion; }
            set { this._authorizerPayloadFormatVersion = value; }
        }

        // Check to see if AuthorizerPayloadFormatVersion property is set
        internal bool IsSetAuthorizerPayloadFormatVersion()
        {
            return this._authorizerPayloadFormatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerResultTtlInSeconds. 
        /// <para>
        /// The time to live (TTL) for cached authorizer results, in seconds. If it equals 0,
        /// authorization caching is disabled. If it is greater than 0, API Gateway caches authorizer
        /// responses. The maximum value is 3600, or 1 hour. Supported only for HTTP API Lambda
        /// authorizers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? AuthorizerResultTtlInSeconds
        {
            get { return this._authorizerResultTtlInSeconds; }
            set { this._authorizerResultTtlInSeconds = value; }
        }

        // Check to see if AuthorizerResultTtlInSeconds property is set
        internal bool IsSetAuthorizerResultTtlInSeconds()
        {
            return this._authorizerResultTtlInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizerType. 
        /// <para>
        /// The authorizer type. Specify REQUEST for a Lambda function using incoming request
        /// parameters. Specify JWT to use JSON Web Tokens (supported only for HTTP APIs).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthorizerType AuthorizerType
        {
            get { return this._authorizerType; }
            set { this._authorizerType = value; }
        }

        // Check to see if AuthorizerType property is set
        internal bool IsSetAuthorizerType()
        {
            return this._authorizerType != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerUri. 
        /// <para>
        /// The authorizer's Uniform Resource Identifier (URI). For REQUEST authorizers, this
        /// must be a well-formed Lambda function URI, for example, arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:<replaceable>{account_id}</replaceable>:function:<replaceable>{lambda_function_name}</replaceable>/invocations.
        /// In general, the URI has this form: arn:aws:apigateway:<replaceable>{region}</replaceable>:lambda:path/<replaceable>{service_api}</replaceable>
        ///               , where <replaceable></replaceable>{region} is the same as the region
        /// hosting the Lambda function, path indicates that the remaining substring in the URI
        /// should be treated as the path to the resource, including the initial /. For Lambda
        /// functions, this is usually of the form /2015-03-31/functions/[FunctionARN]/invocations.
        /// Supported only for REQUEST authorizers.
        /// </para>
        /// </summary>
        public string AuthorizerUri
        {
            get { return this._authorizerUri; }
            set { this._authorizerUri = value; }
        }

        // Check to see if AuthorizerUri property is set
        internal bool IsSetAuthorizerUri()
        {
            return this._authorizerUri != null;
        }

        /// <summary>
        /// Gets and sets the property EnableSimpleResponses. 
        /// <para>
        /// Specifies whether a Lambda authorizer returns a response in a simple format. By default,
        /// a Lambda authorizer must return an IAM policy. If enabled, the Lambda authorizer can
        /// return a boolean value instead of an IAM policy. Supported only for HTTP APIs. To
        /// learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-lambda-authorizer.html">Working
        /// with AWS Lambda authorizers for HTTP APIs</a>
        /// </para>
        /// </summary>
        public bool? EnableSimpleResponses
        {
            get { return this._enableSimpleResponses; }
            set { this._enableSimpleResponses = value; }
        }

        // Check to see if EnableSimpleResponses property is set
        internal bool IsSetEnableSimpleResponses()
        {
            return this._enableSimpleResponses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentitySource. 
        /// <para>
        /// The identity source for which authorization is requested.
        /// </para>
        ///  
        /// <para>
        /// For a REQUEST authorizer, this is optional. The value is a set of one or more mapping
        /// expressions of the specified request parameters. The identity source can be headers,
        /// query string parameters, stage variables, and context parameters. For example, if
        /// an Auth header and a Name query string parameter are defined as identity sources,
        /// this value is route.request.header.Auth, route.request.querystring.Name for WebSocket
        /// APIs. For HTTP APIs, use selection expressions prefixed with $, for example, $request.header.Auth,
        /// $request.querystring.Name. These parameters are used to perform runtime validation
        /// for Lambda-based authorizers by verifying all of the identity-related request parameters
        /// are present in the request, not null, and non-empty. Only when this is true does the
        /// authorizer invoke the authorizer Lambda function. Otherwise, it returns a 401 Unauthorized
        /// response without calling the Lambda function. For HTTP APIs, identity sources are
        /// also used as the cache key when caching is enabled. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-lambda-authorizer.html">Working
        /// with AWS Lambda authorizers for HTTP APIs</a>.
        /// </para>
        ///  
        /// <para>
        /// For JWT, a single entry that specifies where to extract the JSON Web Token (JWT) from
        /// inbound requests. Currently only header-based and query parameter-based selections
        /// are supported, for example $request.header.Authorization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> IdentitySource
        {
            get { return this._identitySource; }
            set { this._identitySource = value; }
        }

        // Check to see if IdentitySource property is set
        internal bool IsSetIdentitySource()
        {
            return this._identitySource != null && (this._identitySource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentityValidationExpression. 
        /// <para>
        /// This parameter is not used.
        /// </para>
        /// </summary>
        public string IdentityValidationExpression
        {
            get { return this._identityValidationExpression; }
            set { this._identityValidationExpression = value; }
        }

        // Check to see if IdentityValidationExpression property is set
        internal bool IsSetIdentityValidationExpression()
        {
            return this._identityValidationExpression != null;
        }

        /// <summary>
        /// Gets and sets the property JwtConfiguration. 
        /// <para>
        /// Represents the configuration of a JWT authorizer. Required for the JWT authorizer
        /// type. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public JWTConfiguration JwtConfiguration
        {
            get { return this._jwtConfiguration; }
            set { this._jwtConfiguration = value; }
        }

        // Check to see if JwtConfiguration property is set
        internal bool IsSetJwtConfiguration()
        {
            return this._jwtConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the authorizer.
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

    }
}