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
    /// Container for the parameters to the PutIntegration operation.
    /// Sets up a method's integration.
    /// </summary>
    public partial class PutIntegrationRequest : AmazonAPIGatewayRequest
    {
        private List<string> _cacheKeyParameters = new List<string>();
        private string _cacheNamespace;
        private string _connectionId;
        private ConnectionType _connectionType;
        private ContentHandlingStrategy _contentHandling;
        private string _credentials;
        private string _httpMethod;
        private string _integrationHttpMethod;
        private string _passthroughBehavior;
        private Dictionary<string, string> _requestParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _requestTemplates = new Dictionary<string, string>();
        private string _resourceId;
        private string _restApiId;
        private int? _timeoutInMillis;
        private IntegrationType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property CacheKeyParameters. 
        /// <para>
        /// Specifies a put integration input's cache key parameters.
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
        /// Specifies a put integration input's cache namespace.
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
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The (<a href="http://docs.aws.amazon.com/apigateway/api-reference/resource/vpc-link/#id"><code>id</code></a>)
        /// of the <a>VpcLink</a> used for the integration when <code>connectionType=VPC_LINK</code>
        /// and undefined, otherwise.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the network connection to the integration endpoint. The valid value is
        /// <code>INTERNET</code> for connections through the public routable internet or <code>VPC_LINK</code>
        /// for private connections between API Gateway and a network load balancer in a VPC.
        /// The default value is <code>INTERNET</code>.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
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
        /// Specifies whether credentials are required for a put integration.
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
        /// [Required] Specifies a put integration request's HTTP method.
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
        /// Gets and sets the property IntegrationHttpMethod. 
        /// <para>
        /// Specifies a put integration HTTP method. When the integration type is HTTP or AWS,
        /// this field is required.
        /// </para>
        /// </summary>
        public string IntegrationHttpMethod
        {
            get { return this._integrationHttpMethod; }
            set { this._integrationHttpMethod = value; }
        }

        // Check to see if IntegrationHttpMethod property is set
        internal bool IsSetIntegrationHttpMethod()
        {
            return this._integrationHttpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property PassthroughBehavior. 
        /// <para>
        /// Specifies the pass-through behavior for incoming requests based on the Content-Type
        /// header in the request, and the available mapping templates specified as the <code>requestTemplates</code>
        /// property on the Integration resource. There are three valid values: <code>WHEN_NO_MATCH</code>,
        /// <code>WHEN_NO_TEMPLATES</code>, and <code>NEVER</code>. 
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>WHEN_NO_MATCH</code> passes the request body for unmapped content types through
        /// to the integration back end without transformation.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>NEVER</code> rejects unmapped content types with an HTTP 415 'Unsupported Media
        /// Type' response.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>WHEN_NO_TEMPLATES</code> allows pass-through when the integration has NO content
        /// types mapped to templates. However if there is at least one content type defined,
        /// unmapped content types will be rejected with the same 415 response.
        /// </para>
        /// </li> </ul>
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// [Required] Specifies a put integration request's resource ID.
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
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000 milliseconds
        /// or 29 seconds.
        /// </para>
        /// </summary>
        public int TimeoutInMillis
        {
            get { return this._timeoutInMillis.GetValueOrDefault(); }
            set { this._timeoutInMillis = value; }
        }

        // Check to see if TimeoutInMillis property is set
        internal bool IsSetTimeoutInMillis()
        {
            return this._timeoutInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// [Required] Specifies a put integration input's type.
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
        /// Specifies Uniform Resource Identifier (URI) of the integration endpoint.
        /// </para>
        ///  <ul> <li>
        /// <para>
        ///  For <code>HTTP</code> or <code>HTTP_PROXY</code> integrations, the URI must be a
        /// fully formed, encoded HTTP(S) URL according to the <a target="_blank" href="https://en.wikipedia.org/wiki/Uniform_Resource_Identifier">RFC-3986
        /// specification</a>, for either standard integration, where <code>connectionType</code>
        /// is not <code>VPC_LINK</code>, or private integration, where <code>connectionType</code>
        /// is <code>VPC_LINK</code>. For a private HTTP integration, the URI is not used for
        /// routing. 
        /// </para>
        ///  </li> <li>
        /// <para>
        ///  For <code>AWS</code> or <code>AWS_PROXY</code> integrations, the URI is of the form
        /// <code>arn:aws:apigateway:{region}:{subdomain.service|service}:path|action/{service_api}</code>.
        /// Here, <code>{Region}</code> is the API Gateway region (e.g., <code>us-east-1</code>);
        /// <code>{service}</code> is the name of the integrated AWS service (e.g., <code>s3</code>);
        /// and <code>{subdomain}</code> is a designated subdomain supported by certain AWS service
        /// for fast host-name lookup. <code>action</code> can be used for an AWS service action-based
        /// API, using an <code>Action={name}&amp;{p1}={v1}&amp;p2={v2}...</code> query string.
        /// The ensuing <code>{service_api}</code> refers to a supported action <code>{name}</code>
        /// plus any required input parameters. Alternatively, <code>path</code> can be used for
        /// an AWS service path-based API. The ensuing <code>service_api</code> refers to the
        /// path to an AWS service resource, including the region of the integrated AWS service,
        /// if applicable. For example, for integration with the S3 API of <code><a href="http://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectGET.html">GetObject</a></code>,
        /// the <code>uri</code> can be either <code>arn:aws:apigateway:us-west-2:s3:action/GetObject&amp;Bucket={bucket}&amp;Key={key}</code>
        /// or <code>arn:aws:apigateway:us-west-2:s3:path/{bucket}/{key}</code>
        /// </para>
        ///  </li></ul>
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