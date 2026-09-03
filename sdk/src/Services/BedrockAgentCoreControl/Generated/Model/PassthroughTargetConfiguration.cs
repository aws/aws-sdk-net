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
    /// The configuration for an HTTP passthrough target. A passthrough target forwards requests
    /// directly to an external HTTP endpoint.
    /// </summary>
    public partial class PassthroughTargetConfiguration
    {
        private string _endpoint;
        private PassthroughProtocolType _protocolType;
        private HttpApiSchemaConfiguration _schema;
        private StaticQueryParameterConflictResolution _staticQueryParameterConflictResolution;
        private Dictionary<string, string> _staticQueryParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private StickinessConfiguration _stickinessConfiguration;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The HTTPS endpoint that the gateway forwards requests to for this passthrough target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolType. 
        /// <para>
        /// The application protocol that the passthrough target implements. This value is required
        /// for passthrough targets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MCP</c> - The Model Context Protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>A2A</c> - The Agent-to-Agent protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INFERENCE</c> - The protocol for routing requests to a large language model (LLM)
        /// provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM</c> - A custom application protocol.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PassthroughProtocolType ProtocolType
        {
            get { return this._protocolType; }
            set { this._protocolType = value; }
        }

        // Check to see if ProtocolType property is set
        internal bool IsSetProtocolType()
        {
            return this._protocolType != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The API schema configuration that defines the structure of the passthrough target's
        /// API.
        /// </para>
        /// </summary>
        public HttpApiSchemaConfiguration Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property StaticQueryParameterConflictResolution. 
        /// <para>
        /// Controls precedence when a client request supplies a query parameter whose name matches
        /// a configured static query parameter. If not set, defaults to <c>CLIENT_OVERRIDE</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLIENT_OVERRIDE</c> - The client-supplied value overrides the configured static
        /// value for that parameter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STATIC_OVERRIDE</c> - The configured static value is retained, overriding the
        /// client-supplied value for that parameter name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StaticQueryParameterConflictResolution StaticQueryParameterConflictResolution
        {
            get { return this._staticQueryParameterConflictResolution; }
            set { this._staticQueryParameterConflictResolution = value; }
        }

        // Check to see if StaticQueryParameterConflictResolution property is set
        internal bool IsSetStaticQueryParameterConflictResolution()
        {
            return this._staticQueryParameterConflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property StaticQueryParameters. 
        /// <para>
        /// A map of static query parameters that the gateway always appends to the outbound URL
        /// when forwarding requests to the target. The total outbound URL length, which includes
        /// the endpoint and the percent-encoded query parameters, is enforced by the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StaticQueryParameters
        {
            get { return this._staticQueryParameters; }
            set { this._staticQueryParameters = value; }
        }

        // Check to see if StaticQueryParameters property is set
        internal bool IsSetStaticQueryParameters()
        {
            return this._staticQueryParameters != null && (this._staticQueryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StickinessConfiguration. 
        /// <para>
        /// The session stickiness configuration for the passthrough target. This configuration
        /// routes requests within the same session to the same target.
        /// </para>
        /// </summary>
        public StickinessConfiguration StickinessConfiguration
        {
            get { return this._stickinessConfiguration; }
            set { this._stickinessConfiguration = value; }
        }

        // Check to see if StickinessConfiguration property is set
        internal bool IsSetStickinessConfiguration()
        {
            return this._stickinessConfiguration != null;
        }

    }
}