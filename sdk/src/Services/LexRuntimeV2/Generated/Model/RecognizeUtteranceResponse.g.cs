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
    /// This is the response object from the RecognizeUtterance operation.
    /// </summary>
    public partial class RecognizeUtteranceResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        /// The prompt or statement to send to the user. This is based on the bot configuration
        /// and context. For example, if Amazon Lex V2 did not understand the user intent, it
        /// sends the <c>clarificationPrompt</c> configured for the bot. If the intent requires
        /// confirmation before taking the fulfillment action, it sends the <c>confirmationPrompt</c>.
        /// Another example: Suppose that the Lambda function successfully fulfilled the intent,
        /// and sent a message to convey to the user. Then Amazon Lex V2 sends that message in
        /// the response.
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
        /// Content type as specified in the <c>responseContentType</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property InputMode. 
        /// <para>
        /// Indicates whether the input mode to the operation was text, speech, or from a touch-tone
        /// keypad. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InputMode { get; set; }

        /// <summary>
        /// Checks to see if the InputMode property is set.
        /// </summary>
        internal bool IsSetInputMode() => this.InputMode != null;

        /// <summary>
        /// Gets and sets the property InputTranscript. 
        /// <para>
        /// The text used to process the request.
        /// </para>
        ///  
        /// <para>
        /// If the input was an audio stream, the <c>inputTranscript</c> field contains the text
        /// extracted from the audio stream. This is the text that is actually processed to recognize
        /// intents and slot values. You can use this information to determine if Amazon Lex V2
        /// is correctly processing the audio that you send.
        /// </para>
        ///  
        /// <para>
        /// The <c>inputTranscript</c> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InputTranscript { get; set; }

        /// <summary>
        /// Checks to see if the InputTranscript property is set.
        /// </summary>
        internal bool IsSetInputTranscript() => this.InputTranscript != null;

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
        /// The <c>interpretations</c> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Interpretations { get; set; }

        /// <summary>
        /// Checks to see if the Interpretations property is set.
        /// </summary>
        internal bool IsSetInterpretations() => this.Interpretations != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages that were last sent to the user. The messages are ordered based
        /// on the order that you returned the messages from your Lambda function or the order
        /// that the messages are defined in the bot.
        /// </para>
        ///  
        /// <para>
        /// The <c>messages</c> field is compressed with gzip and then base64 encoded. Before
        /// you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Messages { get; set; }

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null;

        /// <summary>
        /// Gets and sets the property RecognizedBotMember. 
        /// <para>
        /// The bot member that recognized the utterance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RecognizedBotMember { get; set; }

        /// <summary>
        /// Checks to see if the RecognizedBotMember property is set.
        /// </summary>
        internal bool IsSetRecognizedBotMember() => this.RecognizedBotMember != null;

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// The attributes sent in the request.
        /// </para>
        ///  
        /// <para>
        /// The <c>requestAttributes</c> field is compressed with gzip and then base64 encoded.
        /// Before you can use the contents of the field, you must decode and decompress the contents.
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
        /// The identifier of the session in use.
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
        /// Represents the current state of the dialog between the user and the bot.
        /// </para>
        ///  
        /// <para>
        /// Use this to determine the progress of the conversation and what the next action might
        /// be.
        /// </para>
        ///  
        /// <para>
        /// The <c>sessionState</c> field is compressed with gzip and then base64 encoded. Before
        /// you can use the contents of the field, you must decode and decompress the contents.
        /// See the example for a simple function to decode and decompress the contents.
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
