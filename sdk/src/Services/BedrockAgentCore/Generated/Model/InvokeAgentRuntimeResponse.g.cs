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
    /// This is the response object from the InvokeAgentRuntime operation.
    /// </summary>
    public partial class InvokeAgentRuntimeResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property Baggage. 
        /// <para>
        /// Additional context information for distributed tracing.
        /// </para>
        /// </summary>
        public string Baggage { get; set; }

        /// <summary>
        /// Checks to see if the Baggage property is set.
        /// </summary>
        internal bool IsSetBaggage() => this.Baggage != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the response data. This indicates how to interpret the response data.
        /// Common values include application/json for JSON data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property McpProtocolVersion. 
        /// <para>
        /// The version of the MCP protocol being used.
        /// </para>
        /// </summary>
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
        [AWSProperty(Min = 1, Max = 100)]
        public string McpSessionId { get; set; }

        /// <summary>
        /// Checks to see if the McpSessionId property is set.
        /// </summary>
        internal bool IsSetMcpSessionId() => this.McpSessionId != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// The response data from the agent runtime. The format of this data depends on the specific
        /// agent configuration and the requested accept type. For most agents, this is a JSON
        /// object containing the agent's response to the user's request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Stream Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The identifier of the runtime session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuntimeSessionId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSessionId property is set.
        /// </summary>
        internal bool IsSetRuntimeSessionId() => this.RuntimeSessionId != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code of the response. A status code of 200 indicates a successful
        /// operation. Other status codes indicate various error conditions.
        /// </para>
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The trace identifier for request tracking.
        /// </para>
        /// </summary>
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
        public string TraceState { get; set; }

        /// <summary>
        /// Checks to see if the TraceState property is set.
        /// </summary>
        internal bool IsSetTraceState() => this.TraceState != null;

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
            {
                return;
            }

            if (disposing)
            {
                this.Response?.Dispose();
                this.Response = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
