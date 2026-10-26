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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the PutIntegration operation.
    /// </summary>
    public partial class PutIntegrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CacheKeyParameters. 
        /// <para>
        /// A list of request parameters whose values API Gateway caches. To be valid values for
        /// <c>cacheKeyParameters</c>, these parameters must also be specified for Method <c>requestParameters</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CacheKeyParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CacheKeyParameters property is set.
        /// </summary>
        internal bool IsSetCacheKeyParameters() => this.CacheKeyParameters != null && (this.CacheKeyParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CacheNamespace. 
        /// <para>
        /// Specifies a group of related cached parameters. By default, API Gateway uses the resource
        /// ID as the <c>cacheNamespace</c>. You can specify the same <c>cacheNamespace</c> across
        /// resources to return the same cached data for requests to different resources.
        /// </para>
        /// </summary>
        public string CacheNamespace { get; set; }

        /// <summary>
        /// Checks to see if the CacheNamespace property is set.
        /// </summary>
        internal bool IsSetCacheNamespace() => this.CacheNamespace != null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the VpcLink used for the integration when <c>connectionType=VPC_LINK</c>
        /// and undefined, otherwise.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the network connection to the integration endpoint. The valid value is
        /// <c>INTERNET</c> for connections through the public routable internet or <c>VPC_LINK</c>
        /// for private connections between API Gateway and a network load balancer in a VPC.
        /// The default value is <c>INTERNET</c>.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

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
        public ContentHandlingStrategy ContentHandling { get; set; }

        /// <summary>
        /// Checks to see if the ContentHandling property is set.
        /// </summary>
        internal bool IsSetContentHandling() => this.ContentHandling != null;

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
        public string Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// Specifies the integration's HTTP method type. For the Type property, if you specify
        /// <c>MOCK</c>, this property is optional. For Lambda integrations, you must set the
        /// integration method to <c>POST</c>. For all other types, you must specify this property.
        /// </para>
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property IntegrationResponses. 
        /// <para>
        /// Specifies the integration's responses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, IntegrationResponse> IntegrationResponses { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, IntegrationResponse>() : null;

        /// <summary>
        /// Checks to see if the IntegrationResponses property is set.
        /// </summary>
        internal bool IsSetIntegrationResponses() => this.IntegrationResponses != null && (this.IntegrationResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegrationTarget. 
        /// <para>
        ///  The ALB or NLB listener to send the request to. 
        /// </para>
        /// </summary>
        public string IntegrationTarget { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationTarget property is set.
        /// </summary>
        internal bool IsSetIntegrationTarget() => this.IntegrationTarget != null;

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
        public string PassthroughBehavior { get; set; }

        /// <summary>
        /// Checks to see if the PassthroughBehavior property is set.
        /// </summary>
        internal bool IsSetPassthroughBehavior() => this.PassthroughBehavior != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestParameters property is set.
        /// </summary>
        internal bool IsSetRequestParameters() => this.RequestParameters != null && (this.RequestParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestTemplates. 
        /// <para>
        /// Represents a map of Velocity templates that are applied on the request payload based
        /// on the value of the Content-Type header sent by the client. The content type value
        /// is the key in this map, and the template (as a String) is the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestTemplates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestTemplates property is set.
        /// </summary>
        internal bool IsSetRequestTemplates() => this.RequestTemplates != null && (this.RequestTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseTransferMode. 
        /// <para>
        ///  The response transfer mode of the integration. 
        /// </para>
        /// </summary>
        public ResponseTransferMode ResponseTransferMode { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTransferMode property is set.
        /// </summary>
        internal bool IsSetResponseTransferMode() => this.ResponseTransferMode != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// Custom timeout between 50 and 29,000 milliseconds. The default value is 29,000 milliseconds
        /// or 29 seconds. You can increase the default value to longer than 29 seconds for Regional
        /// or private APIs only.
        /// </para>
        /// </summary>
        public int? TimeoutInMillis { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMillis property is set.
        /// </summary>
        internal bool IsSetTimeoutInMillis() => this.TimeoutInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property TlsConfig. 
        /// <para>
        /// Specifies the TLS configuration for an integration.
        /// </para>
        /// </summary>
        public TlsConfig TlsConfig { get; set; }

        /// <summary>
        /// Checks to see if the TlsConfig property is set.
        /// </summary>
        internal bool IsSetTlsConfig() => this.TlsConfig != null;

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
        public IntegrationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

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
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
