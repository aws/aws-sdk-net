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
    /// Container for the parameters to the PutMethod operation.
    /// Add a method to an existing <a>Resource</a> resource.
    /// </summary>
    public partial class PutMethodRequest : AmazonAPIGatewayRequest
    {
        private bool? _apiKeyRequired;
        private string _authorizationType;
        private string _authorizerId;
        private string _httpMethod;
        private Dictionary<string, string> _requestModels = new Dictionary<string, string>();
        private Dictionary<string, bool> _requestParameters = new Dictionary<string, bool>();
        private string _resourceId;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// Specifies whether the method required a valid <a>ApiKey</a>.
        /// </para>
        /// </summary>
        public bool ApiKeyRequired
        {
            get { return this._apiKeyRequired.GetValueOrDefault(); }
            set { this._apiKeyRequired = value; }
        }

        // Check to see if ApiKeyRequired property is set
        internal bool IsSetApiKeyRequired()
        {
            return this._apiKeyRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// Specifies the type of authorization used for the method.
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
        /// Specifies the identifier of an <a>Authorizer</a> to use on this Method, if the type
        /// is CUSTOM.
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
        /// Gets and sets the property RequestModels. 
        /// <para>
        /// Specifies the <a>Model</a> resources used for the request's content type. Request
        /// models are represented as a key/value map, with a content type as the key and a <a>Model</a>
        /// name as the value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestModels
        {
            get { return this._requestModels; }
            set { this._requestModels = value; }
        }

        // Check to see if RequestModels property is set
        internal bool IsSetRequestModels()
        {
            return this._requestModels != null && this._requestModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// A key-value map defining required or optional method request parameters that can be
        /// accepted by Amazon API Gateway. A key defines a method request parameter name matching
        /// the pattern of <code>method.request.{location}.{name}</code>, where <code>location</code>
        /// is <code>querystring</code>, <code>path</code>, or <code>header</code> and <code>name</code>
        /// is a valid and unique parameter name. The value associated with the key is a Boolean
        /// flag indicating whether the parameter is required (<code>true</code>) or optional
        /// (<code>false</code>). The method request parameter names defined here are available
        /// in <a>Integration</a> to be mapped to integration request parameters or body-mapping
        /// templates.
        /// </para>
        /// </summary>
        public Dictionary<string, bool> RequestParameters
        {
            get { return this._requestParameters; }
            set { this._requestParameters = value; }
        }

        // Check to see if RequestParameters property is set
        internal bool IsSetRequestParameters()
        {
            return this._requestParameters != null && this._requestParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The <a>Resource</a> identifier for the new <a>Method</a> resource.
        /// </para>
        /// </summary>
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
        /// The <a>RestApi</a> identifier for the new <a>Method</a> resource.
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

    }
}