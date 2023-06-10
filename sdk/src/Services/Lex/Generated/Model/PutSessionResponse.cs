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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// This is the response object from the PutSession operation.
    /// </summary>
    public partial class PutSessionResponse : AmazonWebServiceResponse, IDisposable
    {
        private string _activeContexts;
        private Stream _audioStream;
        private string _contentType;
        private DialogState _dialogState;
        private string _encodedMessage;
        private string _intentName;
        private string _message;
        private MessageFormatType _messageFormat;
        private string _sessionAttributes;
        private string _sessionId;
        private string _slots;
        private string _slotToElicit;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of active contexts for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ActiveContexts
        {
            get { return this._activeContexts; }
            set { this._activeContexts = value; }
        }

        // Check to see if ActiveContexts property is set
        internal bool IsSetActiveContexts()
        {
            return this._activeContexts != null;
        }

        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        /// The audio version of the message to convey to the user.
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
        /// Content type as specified in the <code>Accept</code> HTTP header in the request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DialogState.  <ul> <li> 
        /// <para>
        ///  <code>ConfirmIntent</code> - Amazon Lex is expecting a "yes" or "no" response to
        /// confirm the intent before fulfilling an intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ElicitIntent</code> - Amazon Lex wants to elicit the user's intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ElicitSlot</code> - Amazon Lex is expecting the value of a slot for the current
        /// intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - Conveys that the conversation with the user has failed. This
        /// can happen for various reasons, including the user does not provide an appropriate
        /// response to prompts from the service, or if the Lambda function fails to fulfill the
        /// intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Fulfilled</code> - Conveys that the Lambda function has sucessfully fulfilled
        /// the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReadyForFulfillment</code> - Conveys that the client has to fulfill the intent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DialogState DialogState
        {
            get { return this._dialogState; }
            set { this._dialogState = value; }
        }

        // Check to see if DialogState property is set
        internal bool IsSetDialogState()
        {
            return this._dialogState != null;
        }

        /// <summary>
        /// Gets and sets the property EncodedMessage. 
        /// <para>
        /// The next message that should be presented to the user.
        /// </para>
        ///  
        /// <para>
        /// The <code>encodedMessage</code> field is base-64 encoded. You must decode the field
        /// before you can use the value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1366)]
        public string EncodedMessage
        {
            get { return this._encodedMessage; }
            set { this._encodedMessage = value; }
        }

        // Check to see if EncodedMessage property is set
        internal bool IsSetEncodedMessage()
        {
            return this._encodedMessage != null;
        }

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the current intent.
        /// </para>
        /// </summary>
        public string IntentName
        {
            get { return this._intentName; }
            set { this._intentName = value; }
        }

        // Check to see if IntentName property is set
        internal bool IsSetIntentName()
        {
            return this._intentName != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The next message that should be presented to the user.
        /// </para>
        ///  
        /// <para>
        /// You can only use this field in the de-DE, en-AU, en-GB, en-US, es-419, es-ES, es-US,
        /// fr-CA, fr-FR, and it-IT locales. In all other locales, the <code>message</code> field
        /// is null. You should use the <code>encodedMessage</code> field instead.
        /// </para>
        /// </summary>
        [Obsolete("The message field is deprecated, use the encodedMessage field instead. The message field is available only in the de-DE, en-AU, en-GB, en-US, es-419, es-ES, es-US, fr-CA, fr-FR and it-IT locales.")]
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MessageFormat. 
        /// <para>
        /// The format of the response message. One of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PlainText</code> - The message contains plain UTF-8 text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CustomPayload</code> - The message is a custom format for the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SSML</code> - The message contains text formatted for voice output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Composite</code> - The message contains an escaped JSON object containing one
        /// or more messages from the groups that messages were assigned to when the intent was
        /// created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MessageFormatType MessageFormat
        {
            get { return this._messageFormat; }
            set { this._messageFormat = value; }
        }

        // Check to see if MessageFormat property is set
        internal bool IsSetMessageFormat()
        {
            return this._messageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing session-specific context information.
        /// </para>
        /// </summary>
        public string SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the session.
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
        /// Gets and sets the property Slots. 
        /// <para>
        /// Map of zero or more intent slots Amazon Lex detected from the user input during the
        /// conversation.
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex creates a resolution list containing likely values for a slot. The value
        /// that it returns is determined by the <code>valueSelectionStrategy</code> selected
        /// when the slot type was created or updated. If <code>valueSelectionStrategy</code>
        /// is set to <code>ORIGINAL_VALUE</code>, the value provided by the user is returned,
        /// if the user value is similar to the slot values. If <code>valueSelectionStrategy</code>
        /// is set to <code>TOP_RESOLUTION</code> Amazon Lex returns the first value in the resolution
        /// list or, if there is no resolution list, null. If you don't specify a <code>valueSelectionStrategy</code>
        /// the default is <code>ORIGINAL_VALUE</code>. 
        /// </para>
        /// </summary>
        public string Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null;
        }

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// If the <code>dialogState</code> is <code>ElicitSlot</code>, returns the name of the
        /// slot for which Amazon Lex is eliciting a value.
        /// </para>
        /// </summary>
        public string SlotToElicit
        {
            get { return this._slotToElicit; }
            set { this._slotToElicit = value; }
        }

        // Check to see if SlotToElicit property is set
        internal bool IsSetSlotToElicit()
        {
            return this._slotToElicit != null;
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