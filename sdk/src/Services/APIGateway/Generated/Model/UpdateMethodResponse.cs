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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a client-facing interface by which the client calls the API to access
    /// back-end resources. A <b>Method</b> resource is integrated with an <a>Integration</a>
    /// resource. Both consist of a request and one or more responses. The method request
    /// takes the client input that is passed to the back end through the integration request.
    /// A method response returns the output from the back end to the client through an integration
    /// response. A method request is embodied in a <b>Method</b> resource, whereas an integration
    /// request is embodied in an <a>Integration</a> resource. On the other hand, a method
    /// response is represented by a <a>MethodResponse</a> resource, whereas an integration
    /// response is represented by an <a>IntegrationResponse</a> resource. 
    /// 
    ///  <div class="remarks">  <h4>Example: Retrive the GET method on a specified resource</h4>
    /// <h5>Request</h5> 
    /// <para>
    /// The following example request retrieves the information about the GET method on an
    /// API resource (<code>3kzxbg5sa2</code>) of an API (<code>fugvjdxtri</code>). 
    /// </para>
    ///  <pre><code>GET /restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET HTTP/1.1 Content-Type:
    /// application/json Host: apigateway.us-east-1.amazonaws.com X-Amz-Date: 20160603T210259Z
    /// Authorization: AWS4-HMAC-SHA256 Credential={access_key_ID}/20160603/us-east-1/apigateway/aws4_request,
    /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash}</code></pre> <h5>Response</h5>
    /// 
    /// <para>
    /// The successful response returns a <code>200 OK</code> status code and a payload similar
    /// to the following:
    /// </para>
    ///  <pre><code>{ "_links": { "curies": [ { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-{rel}.html",
    /// "name": "integration", "templated": true }, { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-response-{rel}.html",
    /// "name": "integrationresponse", "templated": true }, { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-method-{rel}.html",
    /// "name": "method", "templated": true }, { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-method-response-{rel}.html",
    /// "name": "methodresponse", "templated": true } ], "self": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET",
    /// "name": "GET", "title": "GET" }, "integration:put": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
    /// }, "method:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET"
    /// }, "method:integration": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
    /// }, "method:responses": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200",
    /// "name": "200", "title": "200" }, "method:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET"
    /// }, "methodresponse:put": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/{status_code}",
    /// "templated": true } }, "apiKeyRequired": true, "authorizationType": "NONE", "httpMethod":
    /// "GET", "_embedded": { "method:integration": { "_links": { "self": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
    /// }, "integration:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
    /// }, "integration:responses": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200",
    /// "name": "200", "title": "200" }, "integration:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
    /// }, "integrationresponse:put": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/{status_code}",
    /// "templated": true } }, "cacheKeyParameters": [], "cacheNamespace": "3kzxbg5sa2", "credentials":
    /// "arn:aws:iam::123456789012:role/apigAwsProxyRole", "httpMethod": "POST", "passthroughBehavior":
    /// "WHEN_NO_MATCH", "requestParameters": { "integration.request.header.Content-Type":
    /// "'application/x-amz-json-1.1'" }, "requestTemplates": { "application/json": "{\n}"
    /// }, "type": "AWS", "uri": "arn:aws:apigateway:us-east-1:kinesis:action/ListStreams",
    /// "_embedded": { "integration:responses": { "_links": { "self": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200",
    /// "name": "200", "title": "200" }, "integrationresponse:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200"
    /// }, "integrationresponse:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200"
    /// } }, "responseParameters": { "method.response.header.Content-Type": "'application/xml'"
    /// }, "responseTemplates": { "application/json": "$util.urlDecode(\"%3CkinesisStreams%3E%23foreach(%24stream%20in%20%24input.path(%27%24.StreamNames%27))%3Cstream%3E%3Cname%3E%24stream%3C%2Fname%3E%3C%2Fstream%3E%23end%3C%2FkinesisStreams%3E\")"
    /// }, "statusCode": "200" } } }, "method:responses": { "_links": { "self": { "href":
    /// "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200", "name": "200",
    /// "title": "200" }, "methodresponse:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200"
    /// }, "methodresponse:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200"
    /// } }, "responseModels": { "application/json": "Empty" }, "responseParameters": { "method.response.header.Content-Type":
    /// false }, "statusCode": "200" } } }</code></pre> 
    /// <para>
    /// In the example above, the response template for the <code>200 OK</code> response maps
    /// the JSON output from the <code>ListStreams</code> action in the back end to an XML
    /// output. The mapping template is URL-encoded as <code>%3CkinesisStreams%3E%23foreach(%24stream%20in%20%24input.path(%27%24.StreamNames%27))%3Cstream%3E%3Cname%3E%24stream%3C%2Fname%3E%3C%2Fstream%3E%23end%3C%2FkinesisStreams%3E</code>
    /// and the output is decoded using the <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-mapping-template-reference.html#util-templat-reference">$util.urlDecode()</a>
    /// helper function.
    /// </para>
    ///  </div> <div class="seeAlso"> <a>MethodResponse</a>, <a>Integration</a>, <a>IntegrationResponse</a>,
    /// <a>Resource</a>, <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-method-settings.html">Set
    /// up an API's method</a> </div>
    /// </summary>
    public partial class UpdateMethodResponse : AmazonWebServiceResponse
    {
        private bool? _apiKeyRequired;
        private List<string> _authorizationScopes = new List<string>();
        private string _authorizationType;
        private string _authorizerId;
        private string _httpMethod;
        private Integration _methodIntegration;
        private Dictionary<string, MethodResponse> _methodResponses = new Dictionary<string, MethodResponse>();
        private string _operationName;
        private Dictionary<string, string> _requestModels = new Dictionary<string, string>();
        private Dictionary<string, bool> _requestParameters = new Dictionary<string, bool>();
        private string _requestValidatorId;

        /// <summary>
        /// Gets and sets the property ApiKeyRequired. 
        /// <para>
        /// A boolean flag specifying whether a valid <a>ApiKey</a> is required to invoke this
        /// method.
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
        /// Gets and sets the property AuthorizationScopes. 
        /// <para>
        /// A list of authorization scopes configured on the method. The scopes are used with
        /// a <code>COGNITO_USER_POOLS</code> authorizer to authorize the method invocation. The
        /// authorization works by matching the method scopes against the scopes parsed from the
        /// access token in the incoming request. The method invocation is authorized if any method
        /// scopes matches a claimed scope in the access token. Otherwise, the invocation is not
        /// authorized. When the method scope is configured, the client must provide an access
        /// token instead of an identity token for authorization purposes.
        /// </para>
        /// </summary>
        public List<string> AuthorizationScopes
        {
            get { return this._authorizationScopes; }
            set { this._authorizationScopes = value; }
        }

        // Check to see if AuthorizationScopes property is set
        internal bool IsSetAuthorizationScopes()
        {
            return this._authorizationScopes != null && this._authorizationScopes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The method's authorization type. Valid values are <code>NONE</code> for open access,
        /// <code>AWS_IAM</code> for using AWS IAM permissions, <code>CUSTOM</code> for using
        /// a custom authorizer, or <code>COGNITO_USER_POOLS</code> for using a Cognito user pool.
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
        /// The identifier of an <a>Authorizer</a> to use on this method. The <code>authorizationType</code>
        /// must be <code>CUSTOM</code>.
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
        ///  <div class="remarks">  <h4>Example: </h4> <h5>Request</h5>  <pre><code>GET /restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration
        /// HTTP/1.1 Content-Type: application/json Host: apigateway.us-east-1.amazonaws.com Content-Length:
        /// 117 X-Amz-Date: 20160613T213210Z Authorization: AWS4-HMAC-SHA256 Credential={access_key_ID}/20160613/us-east-1/apigateway/aws4_request,
        /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash}</code></pre> <h5>Response</h5>
        /// 
        /// <para>
        /// The successful response returns a <code>200 OK</code> status code and a payload similar
        /// to the following:
        /// </para>
        ///  <pre><code>{ "_links": { "curies": [ { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-{rel}.html",
        /// "name": "integration", "templated": true }, { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-response-{rel}.html",
        /// "name": "integrationresponse", "templated": true } ], "self": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration"
        /// }, "integration:delete": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration"
        /// }, "integration:responses": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration/responses/200",
        /// "name": "200", "title": "200" }, "integration:update": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration"
        /// }, "integrationresponse:put": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration/responses/{status_code}",
        /// "templated": true } }, "cacheKeyParameters": [], "cacheNamespace": "0cjtch", "credentials":
        /// "arn:aws:iam::123456789012:role/apigAwsProxyRole", "httpMethod": "POST", "passthroughBehavior":
        /// "WHEN_NO_MATCH", "requestTemplates": { "application/json": "{\n \"a\": \"$input.params('operand1')\",\n
        /// \"b\": \"$input.params('operand2')\", \n \"op\": \"$input.params('operator')\" \n}"
        /// }, "type": "AWS", "uri": "arn:aws:apigateway:us-west-2:lambda:path//2015-03-31/functions/arn:aws:lambda:us-west-2:123456789012:function:Calc/invocations",
        /// "_embedded": { "integration:responses": { "_links": { "self": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration/responses/200",
        /// "name": "200", "title": "200" }, "integrationresponse:delete": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration/responses/200"
        /// }, "integrationresponse:update": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/integration/responses/200"
        /// } }, "responseParameters": { "method.response.header.operator": "integration.response.body.op",
        /// "method.response.header.operand_2": "integration.response.body.b", "method.response.header.operand_1":
        /// "integration.response.body.a" }, "responseTemplates": { "application/json": "#set($res
        /// = $input.path('$'))\n{\n \"result\": \"$res.a, $res.b, $res.op => $res.c\",\n \"a\"
        /// : \"$res.a\",\n \"b\" : \"$res.b\",\n \"op\" : \"$res.op\",\n \"c\" : \"$res.c\"\n}"
        /// }, "selectionPattern": "", "statusCode": "200" } } }</code></pre>  </div> <div class="seeAlso">
        /// <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-integration.html">AWS
        /// CLI</a> </div>
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
        ///  <div class="remarks"> 
        /// <para>
        /// The collection of method responses are encapsulated in a key-value map, where the
        /// key is a response's HTTP status code and the value is a <a>MethodResponse</a> resource
        /// that specifies the response returned to the caller from the back end through the integration
        /// response.
        /// </para>
        ///  <h4>Example: Get a 200 OK response of a GET method</h4> <h5>Request</h5>  <pre><code>GET
        /// /restapis/uojnr9hd57/resources/0cjtch/methods/GET/responses/200 HTTP/1.1 Content-Type:
        /// application/json Host: apigateway.us-east-1.amazonaws.com Content-Length: 117 X-Amz-Date:
        /// 20160613T215008Z Authorization: AWS4-HMAC-SHA256 Credential={access_key_ID}/20160613/us-east-1/apigateway/aws4_request,
        /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash}</code></pre> <h5>Response</h5>
        /// 
        /// <para>
        /// The successful response returns a <code>200 OK</code> status code and a payload similar
        /// to the following:
        /// </para>
        ///  <pre><code>{ "_links": { "curies": { "href": "https://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-method-response-{rel}.html",
        /// "name": "methodresponse", "templated": true }, "self": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/responses/200",
        /// "title": "200" }, "methodresponse:delete": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/responses/200"
        /// }, "methodresponse:update": { "href": "/restapis/uojnr9hd57/resources/0cjtch/methods/GET/responses/200"
        /// } }, "responseModels": { "application/json": "Empty" }, "responseParameters": { "method.response.header.operator":
        /// false, "method.response.header.operand_2": false, "method.response.header.operand_1":
        /// false }, "statusCode": "200" }</code></pre>  </div> <div class="seeAlso"> <a href="https://docs.aws.amazon.com/cli/latest/reference/apigateway/get-method-response.html">AWS
        /// CLI</a> </div>
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
        /// Gets and sets the property OperationName. 
        /// <para>
        /// A human-friendly operation identifier for the method. For example, you can assign
        /// the <code>operationName</code> of <code>ListPets</code> for the <code>GET /pets</code>
        /// method in the <code>PetStore</code> example.
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
        /// A key-value map specifying data schemas, represented by <a>Model</a> resources, (as
        /// the mapped value) of the request payloads of given content types (as the mapping key).
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
        /// accepted by API Gateway. A key is a method request parameter name matching the pattern
        /// of <code>method.request.{location}.{name}</code>, where <code>location</code> is <code>querystring</code>,
        /// <code>path</code>, or <code>header</code> and <code>name</code> is a valid and unique
        /// parameter name. The value associated with the key is a Boolean flag indicating whether
        /// the parameter is required (<code>true</code>) or optional (<code>false</code>). The
        /// method request parameter names defined here are available in <a>Integration</a> to
        /// be mapped to integration request parameters or templates.
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
        /// Gets and sets the property RequestValidatorId. 
        /// <para>
        /// The identifier of a <a>RequestValidator</a> for request validation.
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