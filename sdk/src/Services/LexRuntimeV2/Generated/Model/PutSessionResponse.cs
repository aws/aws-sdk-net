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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
        private Stream _audioStream;
        private string _contentType;
        private string _messages;
        private string _requestAttributes;
        private string _sessionId;
        private string _sessionStateValue;

        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        /// If the requested content type was audio, the audio version of the message to convey
        /// to the user.
        /// </para>
        /// </summary>
        public Stream AudioStream
        {
            get { return this._audioStream; }
            set { this._audioStream = value; }
        }

        // Check to see if AudioStream property is set
        internal bool IsSetAudioStream()
        {
            return this._audioStream != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of response. Same as the type specified in the <c>responseContentType</c>
        /// field in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages that were last sent to the user. The messages are ordered based
        /// on how you return the messages from you Lambda function or the order that the messages
        /// are defined in the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null;
        }

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// A base-64-encoded gzipped field that provides request-specific information passed
        /// between the client application and Amazon Lex V2. These are the same as the <c>requestAttribute</c>
        /// parameter in the call to the <c>PutSession</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session that received the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
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
        /// Gets and sets the property SessionStateValue. 
        /// <para>
        /// A base-64-encoded gzipped field that represents the current state of the dialog between
        /// the user and the bot. Use this to determine the progress of the conversation and what
        /// the next action may be.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SessionStateValue
        {
            get { return this._sessionStateValue; }
            set { this._sessionStateValue = value; }
        }

        // Check to see if SessionStateValue property is set
        internal bool IsSetSessionStateValue()
        {
            return this._sessionStateValue != null;
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
                this._audioStream?.Dispose();
                this._audioStream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}