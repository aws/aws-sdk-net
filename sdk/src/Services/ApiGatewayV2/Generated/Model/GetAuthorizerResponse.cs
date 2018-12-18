/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the GetAuthorizer operation.
    /// </summary>
    public partial class GetAuthorizerResponse : AmazonWebServiceResponse
    {
        private string _authorizerCredentialsArn;
        private string _authorizerId;
        private int? _authorizerResultTtlInSeconds;
        private AuthorizerType _authorizerType;
        private string _authorizerUri;
        private List<string> _identitySource = new List<string>();
        private string _identityValidationExpression;
        private string _name;
        private List<string> _providerArns = new List<string>();

        /// <summary>
        /// Gets and sets the property AuthorizerCredentialsArn. 
        /// <para>
        /// Specifies the required credentials as an IAM role for API Gateway to invoke the authorizer.
        /// To specify an IAM role for API Gateway to assume, use the role's Amazon Resource Name
        /// (ARN). To use resource-based permissions on the Lambda function, specify null.
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
        /// Gets and sets the property AuthorizerId. 
        /// <para>
        /// The authorizer identifier.
        /// </para>
        /// </summary>
        public string AuthorizerId
        {
            get { return this._authorizerId; }
            set { this._authorizerId = value; }
        }

        // Check to see if AuthorizerId property is set
        internal bool IsSetAuthorizerId()
        {
            return this._authorizerId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerResultTtlInSeconds. 
        /// <para>
        /// The time to live (TTL), in seconds, of cached authorizer results. If it equals 0,
        /// authorization caching is disabled. If it is greater than 0, API Gateway will cache
        /// authorizer responses. If this field is not set, the default value is 300. The maximum
        /// value is 3600, or 1 hour.
        /// </para>
        /// </summary>
        public int AuthorizerResultTtlInSeconds
        {
            get { return this._authorizerResultTtlInSeconds.GetValueOrDefault(); }
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
        /// The authorizer type. Currently the only valid value is REQUEST, for a Lambda function
        /// using incoming request parameters.
        /// </para>
        /// </summary>
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
        /// The authorizer's Uniform Resource Identifier (URI). ForREQUEST authorizers, this must
        /// be a well-formed Lambda function URI, for example, arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:{account_id}:function:{lambda_function_name}/invocations.
        /// In general, the URI has this form: arn:aws:apigateway:{region}:lambda:path/{service_api}
        /// , where {region} is the same as the region hosting the Lambda function, path indicates
        /// that the remaining substring in the URI should be treated as the path to the resource,
        /// including the initial /. For Lambda functions, this is usually of the form /2015-03-31/functions/[FunctionARN]/invocations.
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
        /// Gets and sets the property IdentitySource. 
        /// <para>
        /// The identity source for which authorization is requested.
        /// </para>
        /// 
        /// <para>
        /// For the REQUEST authorizer, this is required when authorization caching is enabled.
        /// The value is a comma-separated string of one or more mapping expressions of the specified
        /// request parameters. For example, if an Auth header and a Name query string parameters
        /// are defined as identity sources, this value is method.request.header.Auth, method.request.querystring.Name.
        /// These parameters will be used to derive the authorization caching key and to perform
        /// runtime validation of the REQUEST authorizer by verifying all of the identity-related
        /// request parameters are present, not null, and non-empty. Only when this is true does
        /// the authorizer invoke the authorizer Lambda function, otherwise, it returns a 401
        /// Unauthorized response without calling the Lambda function. The valid value is a string
        /// of comma-separated mapping expressions of the specified request parameters. When the
        /// authorization caching is not enabled, this property is optional.
        /// </para>
        /// </summary>
        public List<string> IdentitySource
        {
            get { return this._identitySource; }
            set { this._identitySource = value; }
        }

        // Check to see if IdentitySource property is set
        internal bool IsSetIdentitySource()
        {
            return this._identitySource != null && this._identitySource.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdentityValidationExpression. 
        /// <para>
        /// The validation expression does not apply to the REQUEST authorizer.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the authorizer.
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
        /// Gets and sets the property ProviderArns. 
        /// <para>
        /// For REQUEST authorizer, this is not defined.
        /// </para>
        /// </summary>
        public List<string> ProviderArns
        {
            get { return this._providerArns; }
            set { this._providerArns = value; }
        }

        // Check to see if ProviderArns property is set
        internal bool IsSetProviderArns()
        {
            return this._providerArns != null && this._providerArns.Count > 0; 
        }

    }
}