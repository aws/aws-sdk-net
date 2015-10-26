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
    /// Represents a method.
    /// </summary>
    public partial class Method
    {
        private bool? _apiKeyRequired;
        private string _authorizationType;
        private string _httpMethod;
        private Integration _methodIntegration;
        private Dictionary<string, MethodResponse> _methodResponses = new Dictionary<string, MethodResponse>();
        private Dictionary<string, string> _requestModels = new Dictionary<string, string>();
        private Dictionary<string, bool> _requestParameters = new Dictionary<string, bool>();

        /// <summary>
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// Specifies whether the method requires a valid <a>ApiKey</a>.
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
        /// The method's authorization type.
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
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP method.
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
        /// The method's integration.
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
        /// Represents available responses that can be sent to the caller. Method responses are
        /// represented as a key/value map, with an HTTP status code as the key and a <a>MethodResponse</a>
        /// as the value. The status codes are available for the <a>Integration</a> responses
        /// to map to.
        /// </para>
        /// </summary>
        public Dictionary<string, MethodResponse> MethodResponses
        {
            get { return this._methodResponses; }
            set { this._methodResponses = value; }
        }

        // Check to see if MethodResponses property is set
        internal bool IsSetMethodResponses()
        {
            return this._methodResponses != null && this._methodResponses.Count > 0; 
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
        /// Represents request parameters that can be accepted by Amazon API Gateway. Request
        /// parameters are represented as a key/value map, with a source as the key and a Boolean
        /// flag as the value. The Boolean flag is used to specify whether the parameter is required.
        /// A source must match the pattern <code>method.request.{location}.{name}</code>, where
        /// <code>location</code> is either querystring, path, or header. <code>name</code> is
        /// a valid, unique parameter name. Sources specified here are available to the integration
        /// for mapping to integration request parameters or templates.
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

    }
}