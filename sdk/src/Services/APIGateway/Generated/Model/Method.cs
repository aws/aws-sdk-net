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
    /// Represents a client-facing interface by which the client calls the API to access
    /// back-end resources. A Method resource is integrated with an Integration resource.
    /// Both consist of a request and one or more responses. The method request takes the
    /// client input that is passed to the back end through the integration request. A method
    /// response returns the output from the back end to the client through an integration
    /// response. A method request is embodied in a Method resource, whereas an integration
    /// request is embodied in an Integration resource. On the other hand, a method response
    /// is represented by a MethodResponse resource, whereas an integration response is represented
    /// by an IntegrationResponse resource.
    /// </summary>
    public partial class Method
    {
        private bool? _apiKeyRequired;
        private List<string> _authorizationScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _authorizationType;
        private string _authorizerId;
        private string _httpMethod;
        private Integration _methodIntegration;
        private Dictionary<string, MethodResponse> _methodResponses = AWSConfigs.InitializeCollections ? new Dictionary<string, MethodResponse>() : null;
        private string _operationName;
        private Dictionary<string, string> _requestModels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, bool> _requestParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;
        private string _requestValidatorId;

        /// <summary>
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// A boolean flag specifying whether a valid ApiKey is required to invoke this method.
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
        /// The identifier of an Authorizer to use on this method. The <c>authorizationType</c>
        /// must be <c>CUSTOM</c>.
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
        /// The method's HTTP verb.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MethodIntegration. 
        /// <para>
        /// Gets the method's integration responsible for passing the client-submitted request
        /// to the back end and performing necessary transformations to make the request compliant
        /// with the back end.
        /// </para>
        /// </summary>
        public Integration MethodIntegration
        {
            get { return this._methodIntegration; }
            set { this._methodIntegration = value; }
        }

        // Check to see if MethodIntegration property is set
        internal bool IsSetMethodIntegration()
        {
            return this._methodIntegration != null;
        }

        /// <summary>
        /// Gets and sets the property MethodResponses. 
        /// <para>
        /// Gets a method response associated with a given HTTP status code. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MethodResponse> MethodResponses
        {
            get { return this._methodResponses; }
            set { this._methodResponses = value; }
        }

        // Check to see if MethodResponses property is set
        internal bool IsSetMethodResponses()
        {
            return this._methodResponses != null && (this._methodResponses.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// A key-value map specifying data schemas, represented by Model resources, (as the mapped
        /// value) of the request payloads of given content types (as the mapping key).
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
        /// accepted by API Gateway. A key is a method request parameter name matching the pattern
        /// of <c>method.request.{location}.{name}</c>, where <c>location</c> is <c>querystring</c>,
        /// <c>path</c>, or <c>header</c> and <c>name</c> is a valid and unique parameter name.
        /// The value associated with the key is a Boolean flag indicating whether the parameter
        /// is required (<c>true</c>) or optional (<c>false</c>). The method request parameter
        /// names defined here are available in Integration to be mapped to integration request
        /// parameters or templates.
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
        /// The identifier of a RequestValidator for request validation.
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

    }
}