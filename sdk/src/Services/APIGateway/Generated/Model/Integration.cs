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
    /// Represents an HTTP, HTTP_PROXY, AWS, AWS_PROXY, or Mock integration.
    /// 
    ///  <div class="remarks">In the API Gateway console, the built-in Lambda integration
    /// is an AWS integration.</div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-create-api.html">Creating
    /// an API</a>, <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/.html"/>
    /// </div>
    /// </summary>
    public partial class Integration
    {
        private List<string> _cacheKeyParameters = new List<string>();
        private string _cacheNamespace;
        private ContentHandlingStrategy _contentHandling;
        private string _credentials;
        private string _httpMethod;
        private Dictionary<string, IntegrationResponse> _integrationResponses = new Dictionary<string, IntegrationResponse>();
        private string _passthroughBehavior;
        private Dictionary<string, string> _requestParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _requestTemplates = new Dictionary<string, string>();
        private IntegrationType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property CacheKeyParameters. 
        /// <para>
        /// Specifies the integration's cache key parameters.
        /// </para>
        /// </summary>
        public List<string> CacheKeyParameters
        {
            get { return this._cacheKeyParameters; }
            set { this._cacheKeyParameters = value; }
        }

        // Check to see if CacheKeyParameters property is set
        internal bool IsSetCacheKeyParameters()
        {
            return this._cacheKeyParameters != null && this._cacheKeyParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CacheNamespace. 
        /// <para>
        /// Specifies the integration's cache namespace.
        /// </para>
        /// </summary>
        public string CacheNamespace
        {
            get { return this._cacheNamespace; }
            set { this._cacheNamespace = value; }
        }

        // Check to see if CacheNamespace property is set
        internal bool IsSetCacheNamespace()
        {
            return this._cacheNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property ContentHandling. 
        /// <para>
        /// Specifies how to handle request payload content type conversions. Supported values
        /// are <code>CONVERT_TO_BINARY</code> and <code>CONVERT_TO_TEXT</code>, with the following
        /// behaviors:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>CONVERT_TO_BINARY</code>: Converts a request payload from a Base64-encoded string
        /// to the corresponding binary blob.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>CONVERT_TO_TEXT</code>: Converts a request payload from a binary blob to a Base64-encoded
        /// string.
        /// </para>
        /// </li> </ul> 
        /// <para>
        /// If this property is not defined, the request payload will be passed through from the
        /// method request to integration request without modification, provided that the <code>passthroughBehaviors</code>
        /// is configured to support payload pass-through.
        /// </para>
        /// </summary>
        public ContentHandlingStrategy ContentHandling
        {
            get { return this._contentHandling; }
            set { this._contentHandling = value; }
        }

        // Check to see if ContentHandling property is set
        internal bool IsSetContentHandling()
        {
            return this._contentHandling != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// Specifies the credentials required for the integration, if any. For AWS integrations,
        /// three options are available. To specify an IAM Role for Amazon API Gateway to assume,
        /// use the role's Amazon Resource Name (ARN). To require that the caller's identity be
        /// passed through from the request, specify the string <code>arn:aws:iam::\*:user/\*</code>.
        /// To use resource-based permissions on supported AWS services, specify null.
        /// </para>
        /// </summary>
        public string Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// Specifies the integration's HTTP method type.
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
        /// Gets and sets the property IntegrationResponses. 
        /// <para>
        /// Specifies the integration's responses.
        /// </para>
        ///  <div class="remarks">  <h4>Example: Get integration responses of a method</h4> <h5>Request</h5>
        ///  <pre><code>GET /restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200
        /// HTTP/1.1 Content-Type: application/json Host: apigateway.us-east-1.amazonaws.com X-Amz-Date:
        /// 20160607T191449Z Authorization: AWS4-HMAC-SHA256 Credential={access_key_ID}/20160607/us-east-1/apigateway/aws4_request,
        /// SignedHeaders=content-type;host;x-amz-date, Signature={sig4_hash} </code></pre> <h5>Response</h5>
        /// 
        /// <para>
        /// The successful response returns <code>200 OK</code> status and a payload as follows:
        /// </para>
        ///  <pre><code>{ "_links": { "curies": { "href": "http://docs.aws.amazon.com/apigateway/latest/developerguide/restapi-integration-response-{rel}.html",
        /// "name": "integrationresponse", "templated": true }, "self": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200",
        /// "title": "200" }, "integrationresponse:delete": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200"
        /// }, "integrationresponse:update": { "href": "/restapis/fugvjdxtri/resources/3kzxbg5sa2/methods/GET/integration/responses/200"
        /// } }, "responseParameters": { "method.response.header.Content-Type": "'application/xml'"
        /// }, "responseTemplates": { "application/json": "$util.urlDecode(\"%3CkinesisStreams%3E#foreach($stream
        /// in $input.path('$.StreamNames'))%3Cstream%3E%3Cname%3E$stream%3C/name%3E%3C/stream%3E#end%3C/kinesisStreams%3E\")\n"
        /// }, "statusCode": "200" }</code></pre>  </div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-create-api.html">Creating
        /// an API</a> </div>
        /// </summary>
        public Dictionary<string, IntegrationResponse> IntegrationResponses
        {
            get { return this._integrationResponses; }
            set { this._integrationResponses = value; }
        }

        // Check to see if IntegrationResponses property is set
        internal bool IsSetIntegrationResponses()
        {
            return this._integrationResponses != null && this._integrationResponses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PassthroughBehavior. <div> 
        /// <para>
        ///  Specifies how the method request body of an unmapped content type will be passed
        /// through the integration request to the back end without transformation. A content
        /// type is unmapped if no mapping template is defined in the integration or the content
        /// type does not match any of the mapped content types, as specified in <code>requestTemplates</code>.
        /// There are three valid values: <code>WHEN_NO_MATCH</code>, <code>WHEN_NO_TEMPLATES</code>,
        /// and <code>NEVER</code>. 
        /// </para>
        ///  <ul> <li> <code>WHEN_NO_MATCH</code> passes the method request body through the integration
        /// request to the back end without transformation when the method request content type
        /// does not match any content type associated with the mapping templates defined in the
        /// integration request. </li> <li> <code>WHEN_NO_TEMPLATES</code> passes the method request
        /// body through the integration request to the back end without transformation when no
        /// mapping template is defined in the integration request. If a template is defined when
        /// this option is selected, the method request of an unmapped content-type will be rejected
        /// with an HTTP <code>415 Unsupported Media Type</code> response. </li> <li> <code>NEVER</code>
        /// rejects the method request with an HTTP <code>415 Unsupported Media Type</code> response
        /// when either the method request content type does not match any content type associated
        /// with the mapping templates defined in the integration request or no mapping template
        /// is defined in the integration request. </li> </ul> </div>
        /// </summary>
        public string PassthroughBehavior
        {
            get { return this._passthroughBehavior; }
            set { this._passthroughBehavior = value; }
        }

        // Check to see if PassthroughBehavior property is set
        internal bool IsSetPassthroughBehavior()
        {
            return this._passthroughBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// A key-value map specifying request parameters that are passed from the method request
        /// to the back end. The key is an integration request parameter name and the associated
        /// value is a method request parameter value or static value that must be enclosed within
        /// single quotes and pre-encoded as required by the back end. The method request parameter
        /// value must match the pattern of <code>method.request.{location}.{name}</code>, where
        /// <code>location</code> is <code>querystring</code>, <code>path</code>, or <code>header</code>
        /// and <code>name</code> must be a valid and unique method request parameter name.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestParameters
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
        /// Gets and sets the property RequestTemplates. 
        /// <para>
        /// Represents a map of Velocity templates that are applied on the request payload based
        /// on the value of the Content-Type header sent by the client. The content type value
        /// is the key in this map, and the template (as a String) is the value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestTemplates
        {
            get { return this._requestTemplates; }
            set { this._requestTemplates = value; }
        }

        // Check to see if RequestTemplates property is set
        internal bool IsSetRequestTemplates()
        {
            return this._requestTemplates != null && this._requestTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the integration's type. The valid value is <code>HTTP</code> for integrating
        /// with an HTTP back end, <code>AWS</code> for any AWS service endpoints, <code>MOCK</code>
        /// for testing without actually invoking the back end, <code>HTTP_PROXY</code> for integrating
        /// with the HTTP proxy integration, or <code>AWS_PROXY</code> for integrating with the
        /// Lambda proxy integration type.
        /// </para>
        /// </summary>
        public IntegrationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// Specifies the integration's Uniform Resource Identifier (URI). For HTTP integrations,
        /// the URI must be a fully formed, encoded HTTP(S) URL according to the <a href="https://www.ietf.org/rfc/rfc3986.txt"
        /// target="_blank">RFC-3986 specification</a>. For AWS integrations, the URI should be
        /// of the form <code>arn:aws:apigateway:{region}:{subdomain.service|service}:{path|action}/{service_api}</code>.
        /// <code>Region</code>, <code>subdomain</code> and <code>service</code> are used to determine
        /// the right endpoint. For AWS services that use the <code>Action=</code> query string
        /// parameter, <code>service_api</code> should be a valid action for the desired service.
        /// For RESTful AWS service APIs, <code>path</code> is used to indicate that the remaining
        /// substring in the URI should be treated as the path to the resource, including the
        /// initial <code>/</code>.
        /// </para>
        /// </summary>
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}