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
    /// Represents an API resource.
    /// 
    ///  <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-create-api.html">Create
    /// an API</a> </div>
    /// </summary>
    public partial class Resource
    {
        private string _id;
        private string _parentId;
        private string _path;
        private string _pathPart;
        private Dictionary<string, Method> _resourceMethods = new Dictionary<string, Method>();

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The resource's identifier.
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
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The parent resource's identifier.
        /// </para>
        /// </summary>
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The full path for this resource.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PathPart. 
        /// <para>
        /// The last path segment for this resource.
        /// </para>
        /// </summary>
        public string PathPart
        {
            get { return this._pathPart; }
            set { this._pathPart = value; }
        }

        // Check to see if PathPart property is set
        internal bool IsSetPathPart()
        {
            return this._pathPart != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceMethods. 
        /// <para>
        /// Gets an API resource's method of a given HTTP verb.
        /// </para>
        ///  <div class="remarks"> 
        /// <para>
        /// The resource methods are a map of methods indexed by methods' HTTP verbs enabled on
        /// the resource. This method map is included in the <code>200 OK</code> response of the
        /// <code>GET /restapis/{restapi_id}/resources/{resource_id}</code> or <code>GET /restapis/{restapi_id}/resources/{resource_id}?embed=methods</code>
        /// request.
        /// </para>
        ///  <h4>Example: Get the GET method of an API resource</h4> <h5>Request</h5> <pre><code>GET
        /// /restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET HTTP/1.1 Content-Type: application/json
        /// Host: apigateway.us-east-1.amazonaws.com X-Amz-Date: 20170223T031827Z Authorization:
        /// AWS4-HMAC-SHA256 Credential={access_key_ID}/20170223/us-east-1/apigateway/aws4_request,
        /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash}</code></pre> <h5>Response</h5>
        /// <pre><code>{ "_links": { "curies": [ { "href": "http://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-{rel}.html",
        /// "name": "integration", "templated": true }, { "href": "http://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-response-{rel}.html",
        /// "name": "integrationresponse", "templated": true }, { "href": "http://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-method-{rel}.html",
        /// "name": "method", "templated": true }, { "href": "http://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-method-response-{rel}.html",
        /// "name": "methodresponse", "templated": true } ], "self": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET",
        /// "name": "GET", "title": "GET" }, "integration:put": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
        /// }, "method:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET"
        /// }, "method:integration": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration"
        /// }, "method:responses": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200",
        /// "name": "200", "title": "200" }, "method:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET"
        /// }, "methodresponse:put": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/{status_code}",
        /// "templated": true } }, "apiKeyRequired": false, "authorizationType": "NONE", "httpMethod":
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
        /// }, "responseTemplates": { "application/json": "$util.urlDecode(\"%3CkinesisStreams%3E#foreach($stream
        /// in $input.path('$.StreamNames'))%3Cstream%3E%3Cname%3E$stream%3C/name%3E%3C/stream%3E#end%3C/kinesisStreams%3E\")\n"
        /// }, "statusCode": "200" } } }, "method:responses": { "_links": { "self": { "href":
        /// "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200", "name": "200",
        /// "title": "200" }, "methodresponse:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200"
        /// }, "methodresponse:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/responses/200"
        /// } }, "responseModels": { "application/json": "Empty" }, "responseParameters": { "method.response.header.Content-Type":
        /// false }, "statusCode": "200" } } }</code></pre> 
        /// <para>
        /// If the <code>OPTIONS</code> is enabled on the resource, you can follow the example
        /// here to get that method. Just replace the <code>GET</code> of the last path segment
        /// in the request URL with <code>OPTIONS</code>.
        /// </para>
        ///  </div> <div class="seeAlso"> </div>
        /// </summary>
        public Dictionary<string, Method> ResourceMethods
        {
            get { return this._resourceMethods; }
            set { this._resourceMethods = value; }
        }

        // Check to see if ResourceMethods property is set
        internal bool IsSetResourceMethods()
        {
            return this._resourceMethods != null && this._resourceMethods.Count > 0; 
        }

    }
}