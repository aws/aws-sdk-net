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
    /// This is the response object from the InvokeFlow operation.
    /// </summary>
    public partial class InvokeFlowResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _executionId;
        private FlowResponseStream _responseStream;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier for the current flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseStream. 
        /// <para>
        /// The output of the flow, returned as a stream. If there's an error, the error is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowResponseStream ResponseStream
        {
            get { return this._responseStream; }
            set { this._responseStream = value; }
        }

        // Check to see if ResponseStream property is set
        internal bool IsSetResponseStream()
        {
            return this._responseStream != null;
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
                this._responseStream?.Dispose();
                this._responseStream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}