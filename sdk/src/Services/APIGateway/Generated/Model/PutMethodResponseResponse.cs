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
    /// Represents a method response of a given HTTP status code returned to the client. The
    /// method response is passed from the back end through the associated integration response
    /// that can be transformed using a mapping template. 
    /// 
    ///  <div class="remarks">  <h4>Example: A <b>MethodResponse</b> instance of an API</h4>
    /// <h5>Request</h5> 
    /// <para>
    /// The example request retrieves a <b>MethodResponse</b> of the 200 status code.
    /// </para>
    ///  <pre><code>GET /restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200
    /// HTTP/1.1 Content-Type: application/json Host: apigateway.us-east-1.amazonaws.com X-Amz-Date:
    /// 20160603T222952Z Authorization: AWS4-HMAC-SHA256 Credential={access_key_ID}/20160603/us-east-1/apigateway/aws4_request,
    /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash}</code></pre> <h5>Response</h5>
    /// 
    /// <para>
    /// The successful response returns <code>200 OK</code> status and a payload as follows:
    /// </para>
    ///  <pre><code>{ "_links": { "curies": { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-method-response-{rel}.html",
    /// "name": "methodresponse", "templated": true }, "self": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200",
    /// "title": "200" }, "methodresponse:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200"
    /// }, "methodresponse:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200"
    /// } }, "responseModels": { "application/json": "Empty" }, "responseParameters": { "method.response.header.Content-Type":
    /// false }, "statusCode": "200" }</code></pre>  </div> <div class="seeAlso"> <a>Method</a>,
    /// <a>IntegrationResponse</a>, <a>Integration</a> <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-create-api.html">Creating
    /// an API</a> </div>
    /// </summary>
    public partial class PutMethodResponseResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _responseModels = new Dictionary<string, string>();
        private Dictionary<string, bool> _responseParameters = new Dictionary<string, bool>();
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ResponseModels. 
        /// <para>
        /// Specifies the <a>Model</a> resources used for the response's content-type. Response
        /// models are represented as a key/value map, with a content-type as the key and a <a>Model</a>
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
        /// can send back to the caller. A key defines a method response header and the value
        /// specifies whether the associated method response header is required or not. The expression
        /// of the key must match the pattern <code>method.response.header.{name}</code>, where
        /// <code>name</code> is a valid and unique header name. API Gateway passes certain integration
        /// response data to the method response headers specified here according to the mapping
        /// you prescribe in the API's <a>IntegrationResponse</a>. The integration response data
        /// that can be mapped include an integration response header expressed in <code>integration.response.header.{name}</code>,
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The method response's status code.
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