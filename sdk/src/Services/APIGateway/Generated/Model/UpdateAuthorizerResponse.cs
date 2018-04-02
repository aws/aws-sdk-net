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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents an authorization layer for methods. If enabled on a method, API Gateway
    /// will activate the authorizer when a client calls the method.
    /// 
    ///  <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/use-custom-authorizer.html">Enable
    /// custom authorization</a> </div>
    /// </summary>
    public partial class UpdateAuthorizerResponse : AmazonWebServiceResponse
    {
        private string _authorizerCredentials;
        private int? _authorizerResultTtlInSeconds;
        private string _authorizerUri;
        private string _authType;
        private string _id;
        private string _identitySource;
        private string _identityValidationExpression;
        private string _name;
        private List<string> _providerarNs = new List<string>();
        private AuthorizerType _type;

        /// <summary>
        /// Gets and sets the property AuthorizerCredentials. 
        /// <para>
        /// Specifies the required credentials as an IAM role for API Gateway to invoke the authorizer.
        /// To specify an IAM role for API Gateway to assume, use the role's Amazon Resource Name
        /// (ARN). To use resource-based permissions on the Lambda function, specify null.
        /// </para>
        /// </summary>
        public string AuthorizerCredentials
        {
            get { return this._authorizerCredentials; }
            set { this._authorizerCredentials = value; }
        }

        // Check to see if AuthorizerCredentials property is set
        internal bool IsSetAuthorizerCredentials()
        {
            return this._authorizerCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerResultTtlInSeconds. 
        /// <para>
        /// The TTL in seconds of cached authorizer results. If it equals 0, authorization caching
        /// is disabled. If it is greater than 0, API Gateway will cache authorizer responses.
        /// If this field is not set, the default value is 300. The maximum value is 3600, or
        /// 1 hour.
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
        /// Gets and sets the property AuthorizerUri. 
        /// <para>
        /// Specifies the authorizer's Uniform Resource Identifier (URI). For <code>TOKEN</code>
        /// or <code>REQUEST</code> authorizers, this must be a well-formed Lambda function URI,
        /// for example, <code>arn:aws:apigateway:us-west-2:lambda:path/2015-03-31/functions/arn:aws:lambda:us-west-2:{account_id}:function:{lambda_function_name}/invocations</code>.
        /// In general, the URI has this form <code>arn:aws:apigateway:{region}:lambda:path/{service_api}</code>,
        /// where <code>{region}</code> is the same as the region hosting the Lambda function,
        /// <code>path</code> indicates that the remaining substring in the URI should be treated
        /// as the path to the resource, including the initial <code>/</code>. For Lambda functions,
        /// this is usually of the form <code>/2015-03-31/functions/[FunctionARN]/invocations</code>.
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
        /// Gets and sets the property AuthType. 
        /// <para>
        /// Optional customer-defined field, used in Swagger imports and exports without functional
        /// impact.
        /// </para>
        /// </summary>
        public string AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the authorizer resource.
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
        /// Gets and sets the property IdentitySource. 
        /// <para>
        /// The identity source for which authorization is requested. <ul><li>For a <code>TOKEN</code>
        /// or <code>COGNITO_USER_POOLS</code> authorizer, this is required and specifies the
        /// request header mapping expression for the custom header holding the authorization
        /// token submitted by the client. For example, if the token header name is <code>Auth</code>,
        /// the header mapping expression is <code>method.request.header.Auth</code>.</li><li>For
        /// the <code>REQUEST</code> authorizer, this is required when authorization caching is
        /// enabled. The value is a comma-separated string of one or more mapping expressions
        /// of the specified request parameters. For example, if an <code>Auth</code> header,
        /// a <code>Name</code> query string parameter are defined as identity sources, this value
        /// is <code>method.request.header.Auth, method.request.querystring.Name</code>. These
        /// parameters will be used to derive the authorization caching key and to perform runtime
        /// validation of the <code>REQUEST</code> authorizer by verifying all of the identity-related
        /// request parameters are present, not null and non-empty. Only when this is true does
        /// the authorizer invoke the authorizer Lambda function, otherwise, it returns a 401
        /// Unauthorized response without calling the Lambda function. The valid value is a string
        /// of comma-separated mapping expressions of the specified request parameters. When the
        /// authorization caching is not enabled, this property is optional.</li></ul>
        /// </para>
        /// </summary>
        public string IdentitySource
        {
            get { return this._identitySource; }
            set { this._identitySource = value; }
        }

        // Check to see if IdentitySource property is set
        internal bool IsSetIdentitySource()
        {
            return this._identitySource != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityValidationExpression. 
        /// <para>
        /// A validation expression for the incoming identity token. For <code>TOKEN</code> authorizers,
        /// this value is a regular expression. API Gateway will match the <code>aud</code> field
        /// of the incoming token from the client against the specified regular expression. It
        /// will invoke the authorizer's Lambda function when there is a match. Otherwise, it
        /// will return a 401 Unauthorized response without calling the Lambda function. The validation
        /// expression does not apply to the <code>REQUEST</code> authorizer.
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
        /// [Required] The name of the authorizer.
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
        /// Gets and sets the property ProviderARNs. 
        /// <para>
        /// A list of the Amazon Cognito user pool ARNs for the <code>COGNITO_USER_POOLS</code>
        /// authorizer. Each element is of this format: <code>arn:aws:cognito-idp:{region}:{account_id}:userpool/{user_pool_id}</code>.
        /// For a <code>TOKEN</code> or <code>REQUEST</code> authorizer, this is not defined.
        /// 
        /// </para>
        /// </summary>
        public List<string> ProviderARNs
        {
            get { return this._providerarNs; }
            set { this._providerarNs = value; }
        }

        // Check to see if ProviderARNs property is set
        internal bool IsSetProviderARNs()
        {
            return this._providerarNs != null && this._providerarNs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The authorizer type. Valid values are <code>TOKEN</code> for a Lambda function using
        /// a single authorization token submitted in a custom header, <code>REQUEST</code> for
        /// a Lambda function using incoming request parameters, and <code>COGNITO_USER_POOLS</code>
        /// for using an Amazon Cognito user pool.
        /// </para>
        /// </summary>
        public AuthorizerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}