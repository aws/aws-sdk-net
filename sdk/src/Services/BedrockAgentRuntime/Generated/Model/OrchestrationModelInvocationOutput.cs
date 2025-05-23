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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The foundation model output from the orchestration step.
    /// </summary>
    public partial class OrchestrationModelInvocationOutput
    {
        private Metadata _metadata;
        private RawResponse _rawResponse;
        private ReasoningContentBlock _reasoningContent;
        private string _traceId;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Contains information about the foundation model output from the orchestration step.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Metadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property RawResponse. 
        /// <para>
        /// Contains details of the raw response from the foundation model output.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RawResponse RawResponse
        {
            get { return this._rawResponse; }
            set { this._rawResponse = value; }
        }

        // Check to see if RawResponse property is set
        internal bool IsSetRawResponse()
        {
            return this._rawResponse != null;
        }

        /// <summary>
        /// Gets and sets the property ReasoningContent. 
        /// <para>
        /// Contains content about the reasoning that the model made during the orchestration
        /// step. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ReasoningContentBlock ReasoningContent
        {
            get { return this._reasoningContent; }
            set { this._reasoningContent = value; }
        }

        // Check to see if ReasoningContent property is set
        internal bool IsSetReasoningContent()
        {
            return this._reasoningContent != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The unique identifier of the trace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
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

    }
}