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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
    /// Container for the parameters to the PutMethod operation.
    /// Add a method to an existing Resource resource.
    /// </summary>
    public partial class PutMethodRequest : AmazonAPIGatewayRequest
    {
        private bool? _apiKeyRequired;
        private List<string> _authorizationScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _authorizationType;
        private string _authorizerId;
        private string _httpMethod;
        private string _operationName;
        private Dictionary<string, string> _requestModels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, bool> _requestParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;
        private string _requestValidatorId;
        private string _resourceId;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// Specifies whether the method required a valid ApiKey.
        /// </para>
        /// </summary>
        public bool? ApiKeyRequired
        {
            get { return this._apiKeyRequired; }
            set { this._apiKeyRequired = value; }
        }

        // Check to see if ApiKeyRequired property is set
        internal bool IsSetApiKeyRequired()
        {
            return this._apiKeyRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizationScopes. 
        /// <para>
        /// A list of authorization scopes configured on the method. The scopes are used with
        /// a <c>COGNITO_USER_POOLS</c> authorizer to authorize the method invocation. The authorization
        /// works by matching the method scopes against the scopes parsed from the access token
        /// in the incoming request. The method invocation is authorized if any method scopes
        /// matches a claimed scope in the access token. Otherwise, the invocation is not authorized.
        /// When the method scope is configured, the client must provide an access token instead
        /// of an identity token for authorization purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizationScopes
        {
            get { return this._authorizationScopes; }
            set { this._authorizationScopes = value; }
        }

        // Check to see if AuthorizationScopes property is set
        internal bool IsSetAuthorizationScopes()
        {
            return this._authorizationScopes != null && (this._authorizationScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The method's authorization type. Valid values are <c>NONE</c> for open access, <c>AWS_IAM</c>
        /// for using AWS IAM permissions, <c>CUSTOM</c> for using a custom authorizer, or <c>COGNITO_USER_POOLS</c>
        /// for using a Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AuthorizationType
        {
            get { return this._authorizationType; }
            set { this._authorizationType = value; }
        }

        // Check to see if AuthorizationType property is set
        internal bool IsSetAuthorizationType()
        {
            return this._authorizationType != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerId. 
        /// <para>
        /// Specifies the identifier of an Authorizer to use on this Method, if the type is CUSTOM
        /// or COGNITO_USER_POOLS. The authorizer identifier is generated by API Gateway when
        /// you created the authorizer.
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
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// Specifies the method request's HTTP method type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// A human-friendly operation identifier for the method. For example, you can assign
        /// the <c>operationName</c> of <c>ListPets</c> for the <c>GET /pets</c> method in the
        /// <c>PetStore</c> example.
        /// </para>
        /// </summary>
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

        /// <summary>
        /// Gets and sets the property RequestModels. 
        /// <para>
        /// Specifies the Model resources used for the request's content type. Request models
        /// are represented as a key/value map, with a content type as the key and a Model name
        /// as the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestModels
        {
            get { return this._requestModels; }
            set { this._requestModels = value; }
        }

        // Check to see if RequestModels property is set
        internal bool IsSetRequestModels()
        {
            return this._requestModels != null && (this._requestModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// A key-value map defining required or optional method request parameters that can be
        /// accepted by API Gateway. A key defines a method request parameter name matching the
        /// pattern of <c>method.request.{location}.{name}</c>, where <c>location</c> is <c>querystring</c>,
        /// <c>path</c>, or <c>header</c> and <c>name</c> is a valid and unique parameter name.
        /// The value associated with the key is a Boolean flag indicating whether the parameter
        /// is required (<c>true</c>) or optional (<c>false</c>). The method request parameter
        /// names defined here are available in Integration to be mapped to integration request
        /// parameters or body-mapping templates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool> RequestParameters
        {
            get { return this._requestParameters; }
            set { this._requestParameters = value; }
        }

        // Check to see if RequestParameters property is set
        internal bool IsSetRequestParameters()
        {
            return this._requestParameters != null && (this._requestParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestValidatorId. 
        /// <para>
        /// The identifier of a RequestValidator for validating the method request.
        /// </para>
        /// </summary>
        public string RequestValidatorId
        {
            get { return this._requestValidatorId; }
            set { this._requestValidatorId = value; }
        }

        // Check to see if RequestValidatorId property is set
        internal bool IsSetRequestValidatorId()
        {
            return this._requestValidatorId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Resource identifier for the new Method resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}