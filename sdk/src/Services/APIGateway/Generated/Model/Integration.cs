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
    /// Represents an <c>HTTP</c>, <c>HTTP_PROXY</c>, <c>AWS</c>, <c>AWS_PROXY</c>, or Mock
    /// integration.
    /// </summary>
    public partial class Integration
    {
        private List<string> _cacheKeyParameters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _cacheNamespace;
        private string _connectionId;
        private ConnectionType _connectionType;
        private ContentHandlingStrategy _contentHandling;
        private string _credentials;
        private string _httpMethod;
        private Dictionary<string, IntegrationResponse> _integrationResponses = AWSConfigs.InitializeCollections ? new Dictionary<string, IntegrationResponse>() : null;
        private string _passthroughBehavior;
        private Dictionary<string, string> _requestParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _requestTemplates = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _timeoutInMillis;
        private TlsConfig _tlsConfig;
        private IntegrationType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property CacheKeyParameters. 
        /// <para>
        /// A list of request parameters whose values API Gateway caches. To be valid values for
        /// <c>cacheKeyParameters</c>, these parameters must also be specified for Method <c>requestParameters</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CacheKeyParameters
        {
            get { return this._cacheKeyParameters; }
            set { this._cacheKeyParameters = value; }
        }

        // Check to see if CacheKeyParameters property is set
        internal bool IsSetCacheKeyParameters()
        {
            return this._cacheKeyParameters != null && (this._cacheKeyParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CacheNamespace. 
        /// <para>
        /// Specifies a group of related cached parameters. By default, API Gateway uses the resource
        /// ID as the <c>cacheNamespace</c>. You can specify the same <c>cacheNamespace</c> across
        /// resources to return the same cached data for requests to different resources.
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
        /// The ID of the VpcLink used for the integration when <c>connectionType=VPC_LINK</c>
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
        /// <c>INTERNET</c> for connections through the public routable internet or <c>VPC_LINK</c>
        /// for private connections between API Gateway and a network load balancer in a VPC.
        /// The default value is <c>INTERNET</c>.
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
        /// are <c>CONVERT_TO_BINARY</c> and <c>CONVERT_TO_TEXT</c>, with the following behaviors:
        /// </para>
        ///  
        /// <para>
        /// If this property is not defined, the request payload will be passed through from the
        /// method request to integration request without modification, provided that the <c>passthroughBehavior</c>
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
        /// three options are available. To specify an IAM Role for API Gateway to assume, use
        /// the role's Amazon Resource Name (ARN). To require that the caller's identity be passed
        /// through from the request, specify the string <c>arn:aws:iam::\*:user/\*</c>. To use
        /// resource-based permissions on supported Amazon Web Services services, specify null.
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
        /// Specifies the integration's HTTP method type. For the Type property, if you specify
        /// <c>MOCK</c>, this property is optional. For Lambda integrations, you must set the
        /// integration method to <c>POST</c>. For all other types, you must specify this property.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, IntegrationResponse> IntegrationResponses
        {
            get { return this._integrationResponses; }
            set { this._integrationResponses = value; }
        }

        // Check to see if IntegrationResponses property is set
        internal bool IsSetIntegrationResponses()
        {
            return this._integrationResponses != null && (this._integrationResponses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PassthroughBehavior. 
        /// <para>
        /// Specifies how the method request body of an unmapped content type will be passed through
        /// the integration request to the back end without transformation. A content type is
        /// unmapped if no mapping template is defined in the integration or the content type
        /// does not match any of the mapped content types, as specified in <c>requestTemplates</c>.
        /// The valid value is one of the following: <c>WHEN_NO_MATCH</c>: passes the method request
        /// body through the integration request to the back end without transformation when the
        /// method request content type does not match any content type associated with the mapping
        /// templates defined in the integration request. <c>WHEN_NO_TEMPLATES</c>: passes the
        /// method request body through the integration request to the back end without transformation
        /// when no mapping template is defined in the integration request. If a template is defined
        /// when this option is selected, the method request of an unmapped content-type will
        /// be rejected with an HTTP 415 Unsupported Media Type response. <c>NEVER</c>: rejects
        /// the method request with an HTTP 415 Unsupported Media Type response when either the
        /// method request content type does not match any content type associated with the mapping
        /// templates defined in the integration request or no mapping template is defined in
        /// the integration request.
        /// </para>
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
        /// value must match the pattern of <c>method.request.{location}.{name}</c>, where <c>location</c>
        /// is <c>querystring</c>, <c>path</c>, or <c>header</c> and <c>name</c> must be a valid
        /// and unique method request parameter name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestParameters
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
        /// Gets and sets the property RequestTemplates. 
        /// <para>
        /// Represents a map of Velocity templates that are applied on the request payload based
        /// on the value of the Content-Type header sent by the client. The content type value
        /// is the key in this map, and the template (as a String) is the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestTemplates
        {
            get { return this._requestTemplates; }
            set { this._requestTemplates = value; }
        }

        // Check to see if RequestTemplates property is set
        internal bool IsSetRequestTemplates()
        {
            return this._requestTemplates != null && (this._requestTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000 milliseconds
        /// or 29 seconds. You can increase the default value to longer than 29 seconds for Regional
        /// or private APIs only.
        /// </para>
        /// </summary>
        public int? TimeoutInMillis
        {
            get { return this._timeoutInMillis; }
            set { this._timeoutInMillis = value; }
        }

        // Check to see if TimeoutInMillis property is set
        internal bool IsSetTimeoutInMillis()
        {
            return this._timeoutInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TlsConfig. 
        /// <para>
        /// Specifies the TLS configuration for an integration.
        /// </para>
        /// </summary>
        public TlsConfig TlsConfig
        {
            get { return this._tlsConfig; }
            set { this._tlsConfig = value; }
        }

        // Check to see if TlsConfig property is set
        internal bool IsSetTlsConfig()
        {
            return this._tlsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies an API method integration type. The valid value is one of the following:
        /// </para>
        ///  
        /// <para>
        /// For the HTTP and HTTP proxy integrations, each integration can specify a protocol
        /// (<c>http/https</c>), port and path. Standard 80 and 443 ports are supported as well
        /// as custom ports above 1024. An HTTP or HTTP proxy integration with a <c>connectionType</c>
        /// of <c>VPC_LINK</c> is referred to as a private integration and uses a VpcLink to connect
        /// API Gateway to a network load balancer of a VPC.
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
        ///  
        /// <para>
        /// For <c>HTTP</c> or <c>HTTP_PROXY</c> integrations, the URI must be a fully formed,
        /// encoded HTTP(S) URL according to the RFC-3986 specification for standard integrations.
        /// If <c>connectionType</c> is <c>VPC_LINK</c> specify the Network Load Balancer DNS
        /// name. For <c>AWS</c> or <c>AWS_PROXY</c> integrations, the URI is of the form <c>arn:aws:apigateway:{region}:{subdomain.service|service}:path|action/{service_api}</c>.
        /// Here, {Region} is the API Gateway region (e.g., us-east-1); {service} is the name
        /// of the integrated Amazon Web Services service (e.g., s3); and {subdomain} is a designated
        /// subdomain supported by certain Amazon Web Services service for fast host-name lookup.
        /// action can be used for an Amazon Web Services service action-based API, using an Action={name}&amp;{p1}={v1}&amp;p2={v2}...
        /// query string. The ensuing {service_api} refers to a supported action {name} plus any
        /// required input parameters. Alternatively, path can be used for an Amazon Web Services
        /// service path-based API. The ensuing service_api refers to the path to an Amazon Web
        /// Services service resource, including the region of the integrated Amazon Web Services
        /// service, if applicable. For example, for integration with the S3 API of GetObject,
        /// the uri can be either <c>arn:aws:apigateway:us-west-2:s3:action/GetObject&amp;Bucket={bucket}&amp;Key={key}</c>
        /// or <c>arn:aws:apigateway:us-west-2:s3:path/{bucket}/{key}</c> 
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