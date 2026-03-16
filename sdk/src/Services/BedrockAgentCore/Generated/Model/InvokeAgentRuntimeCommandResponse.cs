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
    /// Response for InvokeAgentRuntimeCommand operation
    /// </summary>
    public partial class InvokeAgentRuntimeCommandResponse : AmazonWebServiceResponse
    {
        private string _baggage;
        private string _contentType;
        private string _runtimeSessionId;
        private int? _statusCode;
        private InvokeAgentRuntimeCommandStreamOutput _stream;
        private string _traceId;
        private string _traceParent;
        private string _traceState;

        /// <summary>
        /// Gets and sets the property Baggage. 
        /// <para>
        /// Additional context information for distributed tracing.
        /// </para>
        /// </summary>
        public string Baggage
        {
            get { return this._baggage; }
            set { this._baggage = value; }
        }

        // Check to see if Baggage property is set
        internal bool IsSetBaggage()
        {
            return !string.IsNullOrEmpty(this._baggage);
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the response data. This indicates how to interpret the response data.
        /// Common values include application/json for JSON data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return !string.IsNullOrEmpty(this._contentType);
        }

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// Runtime session identifier
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuntimeSessionId
        {
            get { return this._runtimeSessionId; }
            set { this._runtimeSessionId = value; }
        }

        // Check to see if RuntimeSessionId property is set
        internal bool IsSetRuntimeSessionId()
        {
            return !string.IsNullOrEmpty(this._runtimeSessionId);
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code of the response. A status code of 200 indicates a successful
        /// operation. Other status codes indicate various error conditions.
        /// </para>
        /// </summary>
        public int StatusCode
        {
            get { return this._statusCode.GetValueOrDefault(); }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stream. 
        /// <para>
        /// Streaming output containing command execution events
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvokeAgentRuntimeCommandStreamOutput Stream
        {
            get { return this._stream; }
            set { this._stream = value; }
        }

        // Check to see if Stream property is set
        internal bool IsSetStream()
        {
            return this._stream != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return !string.IsNullOrEmpty(this._traceId);
        }

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// The parent trace information for distributed tracing.
        /// </para>
        /// </summary>
        public string TraceParent
        {
            get { return this._traceParent; }
            set { this._traceParent = value; }
        }

        // Check to see if TraceParent property is set
        internal bool IsSetTraceParent()
        {
            return !string.IsNullOrEmpty(this._traceParent);
        }

        /// <summary>
        /// Gets and sets the property TraceState. 
        /// <para>
        /// The trace state information for distributed tracing.
        /// </para>
        /// </summary>
        public string TraceState
        {
            get { return this._traceState; }
            set { this._traceState = value; }
        }

        // Check to see if TraceState property is set
        internal bool IsSetTraceState()
        {
            return !string.IsNullOrEmpty(this._traceState);
        }

    }
}