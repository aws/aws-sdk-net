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
    /// Container for the parameters to the CreateAuthorizer operation.
    /// Adds a new <a>Authorizer</a> resource to an existing <a>RestApi</a> resource.
    /// 
    ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/create-authorizer.html">AWS
    /// CLI</a></div>
    /// </summary>
    public partial class CreateAuthorizerRequest : AmazonAPIGatewayRequest
    {
        private string _authorizerCredentials;
        private int? _authorizerResultTtlInSeconds;
        private string _authorizerUri;
        private string _authType;
        private string _identitySource;
        private string _identityValidationExpression;
        private string _name;
        private List<string> _providerarNs = new List<string>();
        private string _restApiId;
        private AuthorizerType _type;

        /// <summary>
        /// Gets and sets the property AuthorizerCredentials. 
        /// <para>
        /// Specifies the credentials required for the authorizer, if any.
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
        /// The TTL of cached authorizer results.
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
        /// [Required] Specifies the authorizer's Uniform Resource Identifier (URI).
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
        /// Gets and sets the property IdentitySource. 
        /// <para>
        /// [Required] The source of the identity in an incoming request.
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
        /// A validation expression for the incoming identity.
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
        /// A list of the Cognito Your User Pool authorizer's provider ARNs.
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
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The <a>RestApi</a> identifier under which the <a>Authorizer</a> will be created.
        /// </para>
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// [Required] The type of the authorizer.
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