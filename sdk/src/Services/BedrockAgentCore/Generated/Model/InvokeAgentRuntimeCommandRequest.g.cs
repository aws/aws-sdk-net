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
    /// Container for the parameters to the InvokeAgentRuntimeCommand operation. Executes
    /// a command in a runtime session container and streams the output back to the caller.
    /// This operation allows you to run shell commands within the agent runtime environment
    /// and receive real-time streaming responses including standard output and standard error.
    /// <para> To invoke a command, you must specify the agent runtime ARN and a runtime session
    /// ID. The command execution supports streaming responses, allowing you to receive output
    /// as it becomes available through <c>contentStart</c>, <c>contentDelta</c>, and <c>contentStop</c>
    /// events. </para> <para> To use this operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntimeCommand</c>
    /// permission. </para>
    /// </summary>
    public partial class InvokeAgentRuntimeCommandRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type for the response from the agent runtime command. This tells
        /// the agent runtime what format to use for the response data. Common values include
        /// application/json for JSON data.
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
        /// The Amazon Resource Name (ARN) of the agent runtime on which to execute the command.
        /// This identifies the specific agent runtime environment where the command will run.
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
        /// Gets and sets the property Body. 
        /// <para>
        /// The request body containing the command to execute and optional configuration parameters
        /// such as timeout settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvokeAgentRuntimeCommandRequestBody Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request payload. This tells the agent runtime
        /// how to interpret the payload data. Common values include application/json for JSON
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

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
        /// The unique identifier of the runtime session in which to execute the command. This
        /// session ID is used to maintain state and context across multiple command invocations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string RuntimeSessionId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSessionId property is set.
        /// </summary>
        internal bool IsSetRuntimeSessionId() => this.RuntimeSessionId != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
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
        [AWSProperty(Min = 0, Max = 1024)]
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
