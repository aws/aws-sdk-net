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
    /// Container for the parameters to the PutMethodResponse operation.
    /// Adds a <a>MethodResponse</a> to an existing <a>Method</a> resource.
    /// </summary>
    public partial class PutMethodResponseRequest : AmazonAPIGatewayRequest
    {
        private string _httpMethod;
        private string _resourceId;
        private Dictionary<string, string> _responseModels = new Dictionary<string, string>();
        private Dictionary<string, bool> _responseParameters = new Dictionary<string, bool>();
        private string _restApiId;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// [Required] The HTTP verb of the <a>Method</a> resource.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// [Required] The <a>Resource</a> identifier for the <a>Method</a> resource.
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
        /// Gets and sets the property ResponseModels. 
        /// <para>
        /// Specifies the <a>Model</a> resources used for the response's content type. Response
        /// models are represented as a key/value map, with a content type as the key and a <a>Model</a>
        /// name as the value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseModels
        {
            get { return this._responseModels; }
            set { this._responseModels = value; }
        }

        // Check to see if ResponseModels property is set
        internal bool IsSetResponseModels()
        {
            return this._responseModels != null && this._responseModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// A key-value map specifying required or optional response parameters that API Gateway
        /// can send back to the caller. A key defines a method response header name and the associated
        /// value is a Boolean flag indicating whether the method response parameter is required
        /// or not. The method response header names must match the pattern of <code>method.response.header.{name}</code>,
        /// where <code>name</code> is a valid and unique header name. The response parameter
        /// names defined here are available in the integration response to be mapped from an
        /// integration response header expressed in <code>integration.response.header.{name}</code>,
        /// a static value enclosed within a pair of single quotes (e.g., <code>'application/json'</code>),
        /// or a JSON expression from the back-end response payload in the form of <code>integration.response.body.{JSON-expression}</code>,
        /// where <code>JSON-expression</code> is a valid JSON expression without the <code>$</code>
        /// prefix.)
        /// </para>
        /// </summary>
        public Dictionary<string, bool> ResponseParameters
        {
            get { return this._responseParameters; }
            set { this._responseParameters = value; }
        }

        // Check to see if ResponseParameters property is set
        internal bool IsSetResponseParameters()
        {
            return this._responseParameters != null && this._responseParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// [Required] The method response's status code.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}