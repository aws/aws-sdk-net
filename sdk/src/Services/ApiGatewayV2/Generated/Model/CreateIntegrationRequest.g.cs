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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegration operation. Creates an Integration.
    /// </summary>
    public partial class CreateIntegrationRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the VPC link for a private integration. Supported only for HTTP APIs.
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
        /// The type of the network connection to the integration endpoint. Specify INTERNET for
        /// connections through the public routable internet or VPC_LINK for private connections
        /// between API Gateway and resources in a VPC. The default value is INTERNET.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property ContentHandlingStrategy. 
        /// <para>
        /// Supported only for WebSocket APIs. Specifies how to handle response payload content
        /// type conversions. Supported values are CONVERT_TO_BINARY and CONVERT_TO_TEXT, with
        /// the following behaviors:
        /// </para>
        ///  
        /// <para>
        /// CONVERT_TO_BINARY: Converts a response payload from a Base64-encoded string to the
        /// corresponding binary blob.
        /// </para>
        ///  
        /// <para>
        /// CONVERT_TO_TEXT: Converts a response payload from a binary blob to a Base64-encoded
        /// string.
        /// </para>
        ///  
        /// <para>
        /// If this property is not defined, the response payload will be passed through from
        /// the integration response to the route response or method response without modification.
        /// </para>
        /// </summary>
        public ContentHandlingStrategy ContentHandlingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the ContentHandlingStrategy property is set.
        /// </summary>
        internal bool IsSetContentHandlingStrategy() => this.ContentHandlingStrategy != null;

        /// <summary>
        /// Gets and sets the property CredentialsArn. 
        /// <para>
        /// Specifies the credentials required for the integration, if any. For AWS integrations,
        /// three options are available. To specify an IAM Role for API Gateway to assume, use
        /// the role's Amazon Resource Name (ARN). To require that the caller's identity be passed
        /// through from the request, specify the string arn:aws:iam::*:user/*. To use resource-based
        /// permissions on supported AWS services, specify null.
        /// </para>
        /// </summary>
        public string CredentialsArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsArn property is set.
        /// </summary>
        internal bool IsSetCredentialsArn() => this.CredentialsArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the integration.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IntegrationMethod. 
        /// <para>
        /// Specifies the integration's HTTP method type.
        /// </para>
        /// </summary>
        public string IntegrationMethod { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationMethod property is set.
        /// </summary>
        internal bool IsSetIntegrationMethod() => this.IntegrationMethod != null;

        /// <summary>
        /// Gets and sets the property IntegrationSubtype. 
        /// <para>
        /// Supported only for HTTP API AWS_PROXY integrations. Specifies the AWS service action
        /// to invoke. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-develop-integrations-aws-services-reference.html">Integration
        /// subtype reference</a>.
        /// </para>
        /// </summary>
        public string IntegrationSubtype { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationSubtype property is set.
        /// </summary>
        internal bool IsSetIntegrationSubtype() => this.IntegrationSubtype != null;

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The integration type of an integration. One of the following:
        /// </para>
        ///  
        /// <para>
        /// AWS: for integrating the route or method request with an AWS service action, including
        /// the Lambda function-invoking action. With the Lambda function-invoking action, this
        /// is referred to as the Lambda custom integration. With any other AWS service action,
        /// this is known as AWS integration. Supported only for WebSocket APIs.
        /// </para>
        ///  
        /// <para>
        /// AWS_PROXY: for integrating the route or method request with a Lambda function or other
        /// AWS service action. This integration is also referred to as a Lambda proxy integration.
        /// </para>
        ///  
        /// <para>
        /// HTTP: for integrating the route or method request with an HTTP endpoint. This integration
        /// is also referred to as the HTTP custom integration. Supported only for WebSocket APIs.
        /// </para>
        ///  
        /// <para>
        /// HTTP_PROXY: for integrating the route or method request with an HTTP endpoint, with
        /// the client request passed through as-is. This is also referred to as HTTP proxy integration.
        /// For HTTP API private integrations, use an HTTP_PROXY integration.
        /// </para>
        ///  
        /// <para>
        /// MOCK: for integrating the route or method request with API Gateway as a "loopback"
        /// endpoint without invoking any backend. Supported only for WebSocket APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property IntegrationUri. 
        /// <para>
        /// For a Lambda integration, specify the URI of a Lambda function.
        /// </para>
        ///  
        /// <para>
        /// For an HTTP integration, specify a fully-qualified URL.
        /// </para>
        ///  
        /// <para>
        /// For an HTTP API private integration, specify the ARN of an Application Load Balancer
        /// listener, Network Load Balancer listener, or AWS Cloud Map service. If you specify
        /// the ARN of an AWS Cloud Map service, API Gateway uses DiscoverInstances to identify
        /// resources. You can use query parameters to target specific resources. To learn more,
        /// see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_DiscoverInstances.html">DiscoverInstances</a>.
        /// For private integrations, all resources must be owned by the same AWS account.
        /// </para>
        /// </summary>
        public string IntegrationUri { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationUri property is set.
        /// </summary>
        internal bool IsSetIntegrationUri() => this.IntegrationUri != null;

        /// <summary>
        /// Gets and sets the property PassthroughBehavior. 
        /// <para>
        /// Specifies the pass-through behavior for incoming requests based on the Content-Type
        /// header in the request, and the available mapping templates specified as the requestTemplates
        /// property on the Integration resource. There are three valid values: WHEN_NO_MATCH,
        /// WHEN_NO_TEMPLATES, and NEVER. Supported only for WebSocket APIs.
        /// </para>
        ///  
        /// <para>
        /// WHEN_NO_MATCH passes the request body for unmapped content types through to the integration
        /// backend without transformation.
        /// </para>
        ///  
        /// <para>
        /// NEVER rejects unmapped content types with an HTTP 415 Unsupported Media Type response.
        /// </para>
        ///  
        /// <para>
        /// WHEN_NO_TEMPLATES allows pass-through when the integration has no content types mapped
        /// to templates. However, if there is at least one content type defined, unmapped content
        /// types will be rejected with the same HTTP 415 Unsupported Media Type response.
        /// </para>
        /// </summary>
        public PassthroughBehavior PassthroughBehavior { get; set; }

        /// <summary>
        /// Checks to see if the PassthroughBehavior property is set.
        /// </summary>
        internal bool IsSetPassthroughBehavior() => this.PassthroughBehavior != null;

        /// <summary>
        /// Gets and sets the property PayloadFormatVersion. 
        /// <para>
        /// Specifies the format of the payload sent to an integration. Required for HTTP APIs.
        /// Supported values for Lambda proxy integrations are 1.0 and 2.0. For all other integrations,
        /// 1.0 is the only supported value. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-develop-integrations-lambda.html">Working
        /// with AWS Lambda proxy integrations for HTTP APIs</a>.
        /// </para>
        /// </summary>
        public string PayloadFormatVersion { get; set; }

        /// <summary>
        /// Checks to see if the PayloadFormatVersion property is set.
        /// </summary>
        internal bool IsSetPayloadFormatVersion() => this.PayloadFormatVersion != null;

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// For WebSocket APIs, a key-value map specifying request parameters that are passed
        /// from the method request to the backend. The key is an integration request parameter
        /// name and the associated value is a method request parameter value or static value
        /// that must be enclosed within single quotes and pre-encoded as required by the backend.
        /// The method request parameter value must match the pattern of method.request.<replaceable>{location}</replaceable>.<replaceable>{name}</replaceable>
        /// , where <replaceable>{location}</replaceable> is querystring, path, or header; and
        /// <replaceable>{name}</replaceable> must be a valid and unique method request parameter
        /// name.
        /// </para>
        ///  
        /// <para>
        /// For HTTP API integrations with a specified integrationSubtype, request parameters
        /// are a key-value map specifying parameters that are passed to AWS_PROXY integrations.
        /// You can provide static values, or map request data, stage variables, or context variables
        /// that are evaluated at runtime. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-develop-integrations-aws-services.html">Working
        /// with AWS service integrations for HTTP APIs</a>.
        /// </para>
        ///  
        /// <para>
        /// For HTTP API integrations without a specified integrationSubtype request parameters
        /// are a key-value map specifying how to transform HTTP requests before sending them
        /// to the backend. The key should follow the pattern &lt;action&gt;:&lt;header|querystring|path&gt;.&lt;location&gt;
        /// where action can be append, overwrite or remove. For values, you can provide static
        /// values, or map request data, stage variables, or context variables that are evaluated
        /// at runtime. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-parameter-mapping.html">Transforming
        /// API requests and responses</a>.
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
        /// is the key in this map, and the template (as a String) is the value. Supported only
        /// for WebSocket APIs.
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
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// Supported only for HTTP APIs. You use response parameters to transform the HTTP response
        /// from a backend integration before returning the response to clients. Specify a key-value
        /// map from a selection key to response parameters. The selection key must be a valid
        /// HTTP status code within the range of 200-599. Response parameters are a key-value
        /// map. The key must match pattern &lt;action&gt;:&lt;header&gt;.&lt;location&gt; or
        /// overwrite.statuscode. The action can be append, overwrite or remove. The value can
        /// be a static value, or map to response data, stage variables, or context variables
        /// that are evaluated at runtime. To learn more, see <a href="https://docs.aws.amazon.com/apigateway/latest/developerguide/http-api-parameter-mapping.html">Transforming
        /// API requests and responses</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> ResponseParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the ResponseParameters property is set.
        /// </summary>
        internal bool IsSetResponseParameters() => this.ResponseParameters != null && (this.ResponseParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateSelectionExpression. 
        /// <para>
        /// The template selection expression for the integration.
        /// </para>
        /// </summary>
        public string TemplateSelectionExpression { get; set; }

        /// <summary>
        /// Checks to see if the TemplateSelectionExpression property is set.
        /// </summary>
        internal bool IsSetTemplateSelectionExpression() => this.TemplateSelectionExpression != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMillis. 
        /// <para>
        /// Custom timeout between 50 and 29,000 milliseconds for WebSocket APIs and between 50
        /// and 30,000 milliseconds for HTTP APIs. The default timeout is 29 seconds for WebSocket
        /// APIs and 30 seconds for HTTP APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 30000)]
        public int? TimeoutInMillis { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMillis property is set.
        /// </summary>
        internal bool IsSetTimeoutInMillis() => this.TimeoutInMillis.HasValue;

        /// <summary>
        /// Gets and sets the property TlsConfig. 
        /// <para>
        /// The TLS configuration for a private integration. If you specify a TLS configuration,
        /// private integration traffic uses the HTTPS protocol. Supported only for HTTP APIs.
        /// </para>
        /// </summary>
        public TlsConfigInput TlsConfig { get; set; }

        /// <summary>
        /// Checks to see if the TlsConfig property is set.
        /// </summary>
        internal bool IsSetTlsConfig() => this.TlsConfig != null;
    }
}
