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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeAgentRuntime operation.
    /// Sends a request to an agent or tool hosted in an Amazon Bedrock AgentCore Runtime
    /// and receives responses in real-time. 
    /// 
    ///  
    /// <para>
    /// To invoke an agent you must specify the AgentCore Runtime ARN and provide a payload
    /// containing your request. You can optionally specify a qualifier to target a specific
    /// version or endpoint of the agent.
    /// </para>
    ///  
    /// <para>
    /// This operation supports streaming responses, allowing you to receive partial responses
    /// as they become available. We recommend using pagination to ensure that the operation
    /// returns quickly and successfully when processing large responses.
    /// </para>
    ///  
    /// <para>
    /// For example code, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-invoke-agent.html">Invoke
    /// an AgentCore Runtime agent</a>. 
    /// </para>
    ///  
    /// <para>
    /// If you're integrating your agent with OAuth, you can't use the Amazon Web Services
    /// SDK to call <c>InvokeAgentRuntime</c>. Instead, make a HTTPS request to <c>InvokeAgentRuntime</c>.
    /// For an example, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-oauth.html">Authenticate
    /// and authorize with Inbound Auth and Outbound Auth</a>.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntime</c>
    /// permission.
    /// </para>
    /// </summary>
    public partial class InvokeAgentRuntimeRequest : AmazonBedrockAgentCoreRequest
    {
        private string _accept;
        private string _agentRuntimeArn;
        private string _baggage;
        private string _contentType;
        private string _mcpProtocolVersion;
        private string _mcpSessionId;
        private MemoryStream _payload;
        private string _qualifier;
        private string _runtimeSessionId;
        private string _runtimeUserId;
        private string _traceId;
        private string _traceParent;
        private string _traceState;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type for the response from the agent runtime. This tells the agent
        /// runtime what format to use for the response data. Common values include application/json
        /// for JSON data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The Amazon Web Services Resource Name (ARN) of the agent runtime to invoke. The ARN
        /// uniquely identifies the agent runtime resource in Amazon Bedrock.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeArn
        {
            get { return this._agentRuntimeArn; }
            set { this._agentRuntimeArn = value; }
        }

        // Check to see if AgentRuntimeArn property is set
        internal bool IsSetAgentRuntimeArn()
        {
            return this._agentRuntimeArn != null;
        }

        /// <summary>
        /// Gets and sets the property Baggage. 
        /// <para>
        /// Additional context information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Baggage
        {
            get { return this._baggage; }
            set { this._baggage = value; }
        }

        // Check to see if Baggage property is set
        internal bool IsSetBaggage()
        {
            return this._baggage != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the payload. This tells the agent runtime how to
        /// interpret the payload data. Common values include application/json for JSON data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property McpProtocolVersion. 
        /// <para>
        /// The version of the MCP protocol being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string McpProtocolVersion
        {
            get { return this._mcpProtocolVersion; }
            set { this._mcpProtocolVersion = value; }
        }

        // Check to see if McpProtocolVersion property is set
        internal bool IsSetMcpProtocolVersion()
        {
            return this._mcpProtocolVersion != null;
        }

        /// <summary>
        /// Gets and sets the property McpSessionId. 
        /// <para>
        /// The identifier of the MCP session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string McpSessionId
        {
            get { return this._mcpSessionId; }
            set { this._mcpSessionId = value; }
        }

        // Check to see if McpSessionId property is set
        internal bool IsSetMcpSessionId()
        {
            return this._mcpSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The input data to send to the agent runtime. The format of this data depends on the
        /// specific agent configuration and must match the specified content type. For most agents,
        /// this is a JSON object containing the user's request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=100000000)]
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The qualifier to use for the agent runtime. This can be a version number or an endpoint
        /// name that points to a specific version. If not specified, Amazon Bedrock uses the
        /// default version of the agent runtime.
        /// </para>
        /// </summary>
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The identifier of the runtime session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string RuntimeSessionId
        {
            get { return this._runtimeSessionId; }
            set { this._runtimeSessionId = value; }
        }

        // Check to see if RuntimeSessionId property is set
        internal bool IsSetRuntimeSessionId()
        {
            return this._runtimeSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeUserId. 
        /// <para>
        /// The identifier of the runtime user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RuntimeUserId
        {
            get { return this._runtimeUserId; }
            set { this._runtimeUserId = value; }
        }

        // Check to see if RuntimeUserId property is set
        internal bool IsSetRuntimeUserId()
        {
            return this._runtimeUserId != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// The parent trace information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string TraceParent
        {
            get { return this._traceParent; }
            set { this._traceParent = value; }
        }

        // Check to see if TraceParent property is set
        internal bool IsSetTraceParent()
        {
            return this._traceParent != null;
        }

        /// <summary>
        /// Gets and sets the property TraceState. 
        /// <para>
        /// The trace state information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string TraceState
        {
            get { return this._traceState; }
            set { this._traceState = value; }
        }

        // Check to see if TraceState property is set
        internal bool IsSetTraceState()
        {
            return this._traceState != null;
        }

    }
}