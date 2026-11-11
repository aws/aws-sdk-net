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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// This is the response object from the PutSession operation.
    /// </summary>
    public partial class PutSessionResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        /// If the requested content type was audio, the audio version of the message to convey
        /// to the user.
        /// </para>
        /// </summary>
        public Stream AudioStream { get; set; }

        /// <summary>
        /// Checks to see if the AudioStream property is set.
        /// </summary>
        internal bool IsSetAudioStream() => this.AudioStream != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of response. Same as the type specified in the <c>responseContentType</c>
        /// field in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages that were last sent to the user. The messages are ordered based
        /// on how you return the messages from you Lambda function or the order that the messages
        /// are defined in the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Messages { get; set; }

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null;

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// A base-64-encoded gzipped field that provides request-specific information passed
        /// between the client application and Amazon Lex V2. These are the same as the <c>requestAttribute</c>
        /// parameter in the call to the <c>PutSession</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RequestAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RequestAttributes property is set.
        /// </summary>
        internal bool IsSetRequestAttributes() => this.RequestAttributes != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that received the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionStateValue. 
        /// <para>
        /// A base-64-encoded gzipped field that represents the current state of the dialog between
        /// the user and the bot. Use this to determine the progress of the conversation and what
        /// the next action may be.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SessionStateValue { get; set; }

        /// <summary>
        /// Checks to see if the SessionStateValue property is set.
        /// </summary>
        internal bool IsSetSessionStateValue() => this.SessionStateValue != null;

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
                this.AudioStream?.Dispose();
                this.AudioStream = null;
            }

            this._disposed = true;
        }

        #endregion
    }
}
