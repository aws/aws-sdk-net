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
    /// This is the response object from the InvokeCodeInterpreter operation.
    /// </summary>
    public partial class InvokeCodeInterpreterResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _sessionId;
        private CodeInterpreterStreamOutput _stream;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the code interpreter session.
        /// </para>
        /// </summary>
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Stream. 
        /// <para>
        /// The stream containing the results of the code execution. This includes output, errors,
        /// and execution status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeInterpreterStreamOutput Stream
        {
            get { return this._stream; }
            set { this._stream = value; }
        }

        // Check to see if Stream property is set
        internal bool IsSetStream()
        {
            return this._stream != null;
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
                this._stream?.Dispose();
                this._stream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}