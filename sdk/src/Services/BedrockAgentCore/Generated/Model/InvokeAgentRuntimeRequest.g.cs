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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeAgentRuntime operation. Sends a request
    /// to an agent or tool hosted in an Amazon Bedrock AgentCore Runtime and receives responses
    /// in real-time. <para> To invoke an agent, you can specify either the AgentCore Runtime
    /// ARN or the agent ID with an account ID, and provide a payload containing your request.
    /// When you use the agent ID instead of the full ARN, you don't need to URL-encode the
    /// identifier. You can optionally specify a qualifier to target a specific endpoint of
    /// the agent. </para> <para> This operation supports streaming responses, allowing you
    /// to receive partial responses as they become available. We recommend using pagination
    /// to ensure that the operation returns quickly and successfully when processing large
    /// responses. </para> <para> For example code, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-invoke-agent.html">Invoke
    /// an AgentCore Runtime agent</a>. </para> <para> If you're integrating your agent with
    /// OAuth, you can't use the Amazon Web Services SDK to call <c>InvokeAgentRuntime</c>.
    /// Instead, make a HTTPS request to <c>InvokeAgentRuntime</c>. For an example, see <a
    /// href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-oauth.html">Authenticate
    /// and authorize with Inbound Auth and Outbound Auth</a>. </para> <para> To use this
    /// operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntime</c> permission.
    /// If you are making a call to <c>InvokeAgentRuntime</c> on behalf of a user ID with
    /// the <c>X-Amzn-Bedrock-AgentCore-Runtime-User-Id</c> header, You require permissions
    /// to both actions (<c>bedrock-agentcore:InvokeAgentRuntime</c> and <c>bedrock-agentcore:InvokeAgentRuntimeForUser</c>).
    /// </para>
    /// </summary>
    public partial class InvokeAgentRuntimeRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type for the response from the agent runtime. This tells the agent
        /// runtime what format to use for the response data. Common values include application/json
        /// for JSON data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account for the agent runtime resource.
        /// This parameter is required when you specify an agent ID instead of the full ARN for
        /// <c>agentRuntimeArn</c>.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The identifier of the agent runtime to invoke. You can specify either the full Amazon
        /// Web Services Resource Name (ARN) or the agent ID. If you use the agent ID, you must
        /// also provide the <c>accountId</c> query parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentRuntimeArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentRuntimeArn property is set.
        /// </summary>
        internal bool IsSetAgentRuntimeArn() => this.AgentRuntimeArn != null;

        /// <summary>
        /// Gets and sets the property Baggage. 
        /// <para>
        /// Additional context information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string Baggage { get; set; }

        /// <summary>
        /// Checks to see if the Baggage property is set.
        /// </summary>
        internal bool IsSetBaggage() => this.Baggage != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the payload. This tells the agent runtime how to
        /// interpret the payload data. Common values include application/json for JSON data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property McpMethod. 
        /// <para>
        /// The MCP method being invoked. For example, <c>tools/call</c>, <c>resources/read</c>,
        /// or <c>prompts/get</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string McpMethod { get; set; }

        /// <summary>
        /// Checks to see if the McpMethod property is set.
        /// </summary>
        internal bool IsSetMcpMethod() => this.McpMethod != null;

        /// <summary>
        /// Gets and sets the property McpName. 
        /// <para>
        /// The name of the MCP resource, tool, or prompt being accessed. The value depends on
        /// the method:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tools/call</c> – The tool name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resources/read</c> – The resource URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>prompts/get</c> – The prompt name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string McpName { get; set; }

        /// <summary>
        /// Checks to see if the McpName property is set.
        /// </summary>
        internal bool IsSetMcpName() => this.McpName != null;

        /// <summary>
        /// Gets and sets the property McpProtocolVersion. 
        /// <para>
        /// The version of the MCP protocol being used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string McpProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the McpProtocolVersion property is set.
        /// </summary>
        internal bool IsSetMcpProtocolVersion() => this.McpProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property McpSessionId. 
        /// <para>
        /// The identifier of the MCP session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string McpSessionId { get; set; }

        /// <summary>
        /// Checks to see if the McpSessionId property is set.
        /// </summary>
        internal bool IsSetMcpSessionId() => this.McpSessionId != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The input data to send to the agent runtime. The format of this data depends on the
        /// specific agent configuration and must match the specified content type. For most agents,
        /// this is a JSON object containing the user's request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 100000000)]
        public MemoryStream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The qualifier to use for the agent runtime. This is an endpoint name that points to
        /// a specific version. If not specified, Amazon Bedrock AgentCore uses the default endpoint
        /// of the agent runtime.
        /// </para>
        /// </summary>
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The identifier of the runtime session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string RuntimeSessionId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSessionId property is set.
        /// </summary>
        internal bool IsSetRuntimeSessionId() => this.RuntimeSessionId != null;

        /// <summary>
        /// Gets and sets the property RuntimeUserId. 
        /// <para>
        /// The identifier of the runtime user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RuntimeUserId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeUserId property is set.
        /// </summary>
        internal bool IsSetRuntimeUserId() => this.RuntimeUserId != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// The parent trace information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TraceParent { get; set; }

        /// <summary>
        /// Checks to see if the TraceParent property is set.
        /// </summary>
        internal bool IsSetTraceParent() => this.TraceParent != null;

        /// <summary>
        /// Gets and sets the property TraceState. 
        /// <para>
        /// The trace state information for distributed tracing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string TraceState { get; set; }

        /// <summary>
        /// Checks to see if the TraceState property is set.
        /// </summary>
        internal bool IsSetTraceState() => this.TraceState != null;
    }
}
