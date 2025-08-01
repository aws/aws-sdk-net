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
    /// This is the response object from the InvokeAgentRuntime operation.
    /// </summary>
    public partial class InvokeAgentRuntimeResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _baggage;
        private string _contentType;
        private string _mcpProtocolVersion;
        private string _mcpSessionId;
        private Stream _response;
        private string _runtimeSessionId;
        private int? _statusCode;
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
            return this._baggage != null;
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
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property McpProtocolVersion. 
        /// <para>
        /// The version of the MCP protocol being used.
        /// </para>
        /// </summary>
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
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Response. 
        /// <para>
        /// The response data from the agent runtime. The format of this data depends on the specific
        /// agent configuration and the requested accept type. For most agents, this is a JSON
        /// object containing the agent's response to the user's request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Stream Response
        {
            get { return this._response; }
            set { this._response = value; }
        }

        // Check to see if Response property is set
        internal bool IsSetResponse()
        {
            return this._response != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The identifier of the runtime session.
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
            return this._runtimeSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code of the response. A status code of 200 indicates a successful
        /// operation. Other status codes indicate various error conditions.
        /// </para>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
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
            return this._traceId != null;
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
            return this._traceParent != null;
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
            return this._traceState != null;
        }

        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._response?.Dispose();
                this._response = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}