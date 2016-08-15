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
    /// </summary>
    public partial class GetAuthorizerResponse : AmazonWebServiceResponse
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
        /// Specifies the credentials required for the authorizer, if any. Two options are available.
        /// To specify an IAM Role for Amazon API Gateway to assume, use the role's Amazon Resource
        /// Name (ARN). To use resource-based permissions on the Lambda function, specify null.
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
        /// The TTL in seconds of cached authorizer results. If greater than 0, API Gateway will
        /// cache authorizer responses. If this field is not set, the default value is 300. The
        /// maximum value is 3600, or 1 hour.
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
        /// [Required] Specifies the authorizer's Uniform Resource Identifier (URI). For TOKEN
        /// authorizers, this must be a well-formed Lambda function URI. The URI should be of
        /// the form <code>arn:aws:apigateway:{region}:lambda:path/{service_api}</code>. <code>Region</code>
        /// is used to determine the right endpoint. In this case, <code>path</code> is used to
        /// indicate that the remaining substring in the URI should be treated as the path to
        /// the resource, including the initial <code>/</code>. For Lambda functions, this is
        /// usually of the form /2015-03-31/functions/[FunctionARN]/invocations
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
        /// Optional customer-defined field, used in Swagger imports/exports. Has no functional
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
        /// [Required] The source of the identity in an incoming request. For TOKEN authorizers,
        /// this value is a mapping expression with the same syntax as integration parameter mappings.
        /// The only valid source for tokens is 'header', so the expression should match 'method.request.header.[headerName]'.
        /// The value of the header '[headerName]' will be interpreted as the incoming token.
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
        /// A validation expression for the incoming identity. For TOKEN authorizers, this value
        /// should be a regular expression. The incoming token from the client is matched against
        /// this expression, and will proceed if the token matches. If the token doesn't match,
        /// the client receives a 401 Unauthorized response.
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
        /// [Required] The type of the authorizer. Currently, the only valid type is TOKEN.
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