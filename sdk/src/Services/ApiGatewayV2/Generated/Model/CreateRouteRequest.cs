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
    /// Container for the parameters to the CreateRoute operation.
    /// Creates a Route for an API.
    /// </summary>
    public partial class CreateRouteRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private bool? _apiKeyRequired;
        private List<string> _authorizationScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AuthorizationType _authorizationType;
        private string _authorizerId;
        private string _modelSelectionExpression;
        private string _operationName;
        private Dictionary<string, string> _requestModels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, ParameterConstraints> _requestParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, ParameterConstraints>() : null;
        private string _routeKey;
        private string _routeResponseSelectionExpression;
        private string _target;

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
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// Specifies whether an API key is required for the route. Supported only for WebSocket
        /// APIs.
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
        /// The authorization scopes supported by this route.
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
        /// The authorization type for the route. For WebSocket APIs, valid values are NONE for
        /// open access, AWS_IAM for using AWS IAM permissions, and CUSTOM for using a Lambda
        /// authorizer For HTTP APIs, valid values are NONE for open access, JWT for using JSON
        /// Web Tokens, AWS_IAM for using AWS IAM permissions, and CUSTOM for using a Lambda authorizer.
        /// </para>
        /// </summary>
        public AuthorizationType AuthorizationType
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
        /// The identifier of the Authorizer resource to be associated with this route. The authorizer
        /// identifier is generated by API Gateway when you created the authorizer.
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
        /// Gets and sets the property ModelSelectionExpression. 
        /// <para>
        /// The model selection expression for the route. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        public string ModelSelectionExpression
        {
            get { return this._modelSelectionExpression; }
            set { this._modelSelectionExpression = value; }
        }

        // Check to see if ModelSelectionExpression property is set
        internal bool IsSetModelSelectionExpression()
        {
            return this._modelSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// The operation name for the route.
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
        /// The request models for the route. Supported only for WebSocket APIs.
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
        /// The request parameters for the route. Supported only for WebSocket APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ParameterConstraints> RequestParameters
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
        /// Gets and sets the property RouteKey. 
        /// <para>
        /// The route key for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteKey
        {
            get { return this._routeKey; }
            set { this._routeKey = value; }
        }

        // Check to see if RouteKey property is set
        internal bool IsSetRouteKey()
        {
            return this._routeKey != null;
        }

        /// <summary>
        /// Gets and sets the property RouteResponseSelectionExpression. 
        /// <para>
        /// The route response selection expression for the route. Supported only for WebSocket
        /// APIs.
        /// </para>
        /// </summary>
        public string RouteResponseSelectionExpression
        {
            get { return this._routeResponseSelectionExpression; }
            set { this._routeResponseSelectionExpression = value; }
        }

        // Check to see if RouteResponseSelectionExpression property is set
        internal bool IsSetRouteResponseSelectionExpression()
        {
            return this._routeResponseSelectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target for the route.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}