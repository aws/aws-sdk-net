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
    /// Container for the parameters to the InvokeAgentRuntimeCommand operation.
    /// Executes a command in a runtime session container and streams the output back to the
    /// caller. This operation allows you to run shell commands within the agent runtime environment
    /// and receive real-time streaming responses including standard output and standard error.
    /// 
    ///  
    /// <para>
    /// To invoke a command, you must specify the agent runtime ARN and a runtime session
    /// ID. The command execution supports streaming responses, allowing you to receive output
    /// as it becomes available through <c>contentStart</c>, <c>contentDelta</c>, and <c>contentStop</c>
    /// events.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntimeCommand</c>
    /// permission.
    /// </para>
    /// </summary>
    public partial class InvokeAgentRuntimeCommandRequest : AmazonBedrockAgentCoreRequest
    {
        private string _accept;
        private string _accountId;
        private string _agentRuntimeArn;
        private string _baggage;
        private InvokeAgentRuntimeCommandRequestBody _body;
        private string _contentType;
        private string _qualifier;
        private string _runtimeSessionId;
        private string _traceId;
        private string _traceParent;
        private string _traceState;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type for the response from the agent runtime command. This tells
        /// the agent runtime what format to use for the response data. Common values include
        /// application/json for JSON data.
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
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account for the agent runtime resource.
        /// This parameter is required when you specify an agent ID instead of the full ARN for
        /// <c>agentRuntimeArn</c>.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent runtime on which to execute the command.
        /// This identifies the specific agent runtime environment where the command will run.
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
        /// Gets and sets the property Body. 
        /// <para>
        /// The request body containing the command to execute and optional configuration parameters
        /// such as timeout settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvokeAgentRuntimeCommandRequestBody Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request payload. This tells the agent runtime
        /// how to interpret the payload data. Common values include application/json for JSON
        /// data.
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
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The qualifier to use for the agent runtime. This is an endpoint name that points to
        /// a specific version. If not specified, Amazon Bedrock AgentCore uses the default endpoint
        /// of the agent runtime.
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
        /// The unique identifier of the runtime session in which to execute the command. This
        /// session ID is used to maintain state and context across multiple command invocations.
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
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        [AWSProperty(Min=0, Max=1024)]
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