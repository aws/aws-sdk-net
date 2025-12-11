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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private ApiGatewayTargetConfiguration _apiGateway;
        private McpLambdaTargetConfiguration _lambda;
        private McpServerTargetConfiguration _mcpServer;
        private ApiSchemaConfiguration _openApiSchema;
        private ApiSchemaConfiguration _smithyModel;

        /// <summary>
        /// Gets and sets the property ApiGateway. 
        /// <para>
        /// The configuration for an Amazon API Gateway target.
        /// </para>
        /// </summary>
        public ApiGatewayTargetConfiguration ApiGateway
        {
            get { return this._apiGateway; }
            set { this._apiGateway = value; }
        }

        // Check to see if ApiGateway property is set
        internal bool IsSetApiGateway()
        {
            return this._apiGateway != null;
        }

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// The Lambda configuration for the Model Context Protocol target. This configuration
        /// defines how the gateway uses a Lambda function to communicate with the target.
        /// </para>
        /// </summary>
        public McpLambdaTargetConfiguration Lambda
        {
            get { return this._lambda; }
            set { this._lambda = value; }
        }

        // Check to see if Lambda property is set
        internal bool IsSetLambda()
        {
            return this._lambda != null;
        }

        /// <summary>
        /// Gets and sets the property McpServer. 
        /// <para>
        /// The MCP server specified as the gateway target.
        /// </para>
        /// </summary>
        public McpServerTargetConfiguration McpServer
        {
            get { return this._mcpServer; }
            set { this._mcpServer = value; }
        }

        // Check to see if McpServer property is set
        internal bool IsSetMcpServer()
        {
            return this._mcpServer != null;
        }

        /// <summary>
        /// Gets and sets the property OpenApiSchema. 
        /// <para>
        /// The OpenAPI schema for the Model Context Protocol target. This schema defines the
        /// API structure of the target.
        /// </para>
        /// </summary>
        public ApiSchemaConfiguration OpenApiSchema
        {
            get { return this._openApiSchema; }
            set { this._openApiSchema = value; }
        }

        // Check to see if OpenApiSchema property is set
        internal bool IsSetOpenApiSchema()
        {
            return this._openApiSchema != null;
        }

        /// <summary>
        /// Gets and sets the property SmithyModel. 
        /// <para>
        /// The Smithy model for the Model Context Protocol target. This model defines the API
        /// structure of the target using the Smithy specification.
        /// </para>
        /// </summary>
        public ApiSchemaConfiguration SmithyModel
        {
            get { return this._smithyModel; }
            set { this._smithyModel = value; }
        }

        // Check to see if SmithyModel property is set
        internal bool IsSetSmithyModel()
        {
            return this._smithyModel != null;
        }

    }
}