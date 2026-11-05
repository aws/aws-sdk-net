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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The Model Context Protocol (MCP) configuration for a target. This structure defines
    /// how the gateway uses MCP to communicate with the target.
    /// </summary>
    public partial class McpTargetConfiguration
    {
        /// <summary>
        /// Gets and sets the property ApiGateway. 
        /// <para>
        /// The configuration for an Amazon API Gateway target.
        /// </para>
        /// </summary>
        public ApiGatewayTargetConfiguration ApiGateway { get; set; }

        /// <summary>
        /// Checks to see if the ApiGateway property is set.
        /// </summary>
        internal bool IsSetApiGateway() => this.ApiGateway != null;

        /// <summary>
        /// Gets and sets the property Connector. 
        /// <para>
        /// The connector integration configuration for the Model Context Protocol target. This
        /// configuration defines how the gateway uses a pre-built connector to communicate with
        /// the target.
        /// </para>
        /// </summary>
        public ConnectorTargetConfiguration Connector { get; set; }

        /// <summary>
        /// Checks to see if the Connector property is set.
        /// </summary>
        internal bool IsSetConnector() => this.Connector != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The Lambda configuration for the Model Context Protocol target. This configuration
        /// defines how the gateway uses a Lambda function to communicate with the target.
        /// </para>
        /// </summary>
        public McpLambdaTargetConfiguration Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property McpServer. 
        /// <para>
        /// The MCP server specified as the gateway target.
        /// </para>
        /// </summary>
        public McpServerTargetConfiguration McpServer { get; set; }

        /// <summary>
        /// Checks to see if the McpServer property is set.
        /// </summary>
        internal bool IsSetMcpServer() => this.McpServer != null;

        /// <summary>
        /// Gets and sets the property OpenApiSchema. 
        /// <para>
        /// The OpenAPI schema for the Model Context Protocol target. This schema defines the
        /// API structure of the target.
        /// </para>
        /// </summary>
        public ApiSchemaConfiguration OpenApiSchema { get; set; }

        /// <summary>
        /// Checks to see if the OpenApiSchema property is set.
        /// </summary>
        internal bool IsSetOpenApiSchema() => this.OpenApiSchema != null;

        /// <summary>
        /// Gets and sets the property SmithyModel. 
        /// <para>
        /// The Smithy model for the Model Context Protocol target. This model defines the API
        /// structure of the target using the Smithy specification.
        /// </para>
        /// </summary>
        public ApiSchemaConfiguration SmithyModel { get; set; }

        /// <summary>
        /// Checks to see if the SmithyModel property is set.
        /// </summary>
        internal bool IsSetSmithyModel() => this.SmithyModel != null;
    }
}
