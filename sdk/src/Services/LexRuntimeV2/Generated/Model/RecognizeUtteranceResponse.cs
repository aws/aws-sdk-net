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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// This is the response object from the RecognizeUtterance operation.
    /// </summary>
    public partial class RecognizeUtteranceResponse : AmazonWebServiceResponse, IDisposable
    {
        private Stream _audioStream;
        private string _contentType;
        private string _inputMode;
        private string _inputTranscript;
        private string _interpretations;
        private string _messages;
        private string _recognizedBotMember;
        private string _requestAttributes;
        private string _sessionId;
        private string _sessionStateValue;

        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        /// The prompt or statement to send to the user. This is based on the bot configuration
        /// and context. For example, if Amazon Lex V2 did not understand the user intent, it
        /// sends the <code>clarificationPrompt</code> configured for the bot. If the intent requires
        /// confirmation before taking the fulfillment action, it sends the <code>confirmationPrompt</code>.
        /// Another example: Suppose that the Lambda function successfully fulfilled the intent,
        /// and sent a message to convey to the user. Then Amazon Lex V2 sends that message in
        /// the response.
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
        /// Content type as specified in the <code>responseContentType</code> in the request.
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
        /// Gets and sets the property InputMode. 
        /// <para>
        /// Indicates whether the input mode to the operation was text or speech. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string InputMode
        {
            get { return this._inputMode; }
            set { this._inputMode = value; }
        }

        // Check to see if InputMode property is set
        internal bool IsSetInputMode()
        {
            return this._inputMode != null;
        }

        /// <summary>
        /// Gets and sets the property InputTranscript. 
        /// <para>
        /// The text used to process the request.
        /// </para>
        ///  
        /// <para>
        /// If the input was an audio stream, the <code>inputTranscript</code> field contains
        /// the text extracted from the audio stream. This is the text that is actually processed
        /// to recognize intents and slot values. You can use this information to determine if
        /// Amazon Lex V2 is correctly processing the audio that you send.
        /// </para>
        ///  
        /// <para>
        /// The <code>inputTranscript</code> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string InputTranscript
        {
            get { return this._inputTranscript; }
            set { this._inputTranscript = value; }
        }

        // Check to see if InputTranscript property is set
        internal bool IsSetInputTranscript()
        {
            return this._inputTranscript != null;
        }

        /// <summary>
        /// Gets and sets the property Interpretations. 
        /// <para>
        /// A list of intents that Amazon Lex V2 determined might satisfy the user's utterance.
        /// </para>
        ///  
        /// <para>
        /// Each interpretation includes the intent, a score that indicates how confident Amazon
        /// Lex V2 is that the interpretation is the correct one, and an optional sentiment response
        /// that indicates the sentiment expressed in the utterance.
        /// </para>
        ///  
        /// <para>
        /// The <code>interpretations</code> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Interpretations
        {
            get { return this._interpretations; }
            set { this._interpretations = value; }
        }

        // Check to see if Interpretations property is set
        internal bool IsSetInterpretations()
        {
            return this._interpretations != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages that were last sent to the user. The messages are ordered based
        /// on the order that you returned the messages from your Lambda function or the order
        /// that the messages are defined in the bot.
        /// </para>
        ///  
        /// <para>
        /// The <code>messages</code> field is compressed with gzip and then base64 encoded. Before
        /// you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
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
        /// Gets and sets the property RecognizedBotMember. 
        /// <para>
        /// The bot member that recognized the utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RecognizedBotMember
        {
            get { return this._recognizedBotMember; }
            set { this._recognizedBotMember = value; }
        }

        // Check to see if RecognizedBotMember property is set
        internal bool IsSetRecognizedBotMember()
        {
            return this._recognizedBotMember != null;
        }

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// The attributes sent in the request.
        /// </para>
        ///  
        /// <para>
        /// The <code>requestAttributes</code> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
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
        /// The identifier of the session in use.
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
        /// Represents the current state of the dialog between the user and the bot.
        /// </para>
        ///  
        /// <para>
        /// Use this to determine the progress of the conversation and what the next action might
        /// be.
        /// </para>
        ///  
        /// <para>
        /// The <code>sessionState</code> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
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