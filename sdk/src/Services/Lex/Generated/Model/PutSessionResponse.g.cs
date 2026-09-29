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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// This is the response object from the PutSession operation.
    /// </summary>
    public partial class PutSessionResponse : AmazonWebServiceResponse, IDisposable
    {
        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of active contexts for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ActiveContexts { get; set; }

        /// <summary>
        /// Checks to see if the ActiveContexts property is set.
        /// </summary>
        internal bool IsSetActiveContexts() => this.ActiveContexts != null;

        /// <summary>
        /// Gets and sets the property AudioStream. 
        /// <para>
        /// The audio version of the message to convey to the user.
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
        /// Content type as specified in the <c>Accept</c> HTTP header in the request.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DialogState. 
        /// <para>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConfirmIntent</c> - Amazon Lex is expecting a "yes" or "no" response to confirm
        /// the intent before fulfilling an intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitIntent</c> - Amazon Lex wants to elicit the user's intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitSlot</c> - Amazon Lex is expecting the value of a slot for the current intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Conveys that the conversation with the user has failed. This can
        /// happen for various reasons, including the user does not provide an appropriate response
        /// to prompts from the service, or if the Lambda function fails to fulfill the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fulfilled</c> - Conveys that the Lambda function has sucessfully fulfilled the
        /// intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReadyForFulfillment</c> - Conveys that the client has to fulfill the intent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DialogState DialogState { get; set; }

        /// <summary>
        /// Checks to see if the DialogState property is set.
        /// </summary>
        internal bool IsSetDialogState() => this.DialogState != null;

        /// <summary>
        /// Gets and sets the property EncodedMessage. 
        /// <para>
        /// The next message that should be presented to the user.
        /// </para>
        ///  
        /// <para>
        /// The <c>encodedMessage</c> field is base-64 encoded. You must decode the field before
        /// you can use the value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1366)]
        public string EncodedMessage { get; set; }

        /// <summary>
        /// Checks to see if the EncodedMessage property is set.
        /// </summary>
        internal bool IsSetEncodedMessage() => this.EncodedMessage != null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the current intent.
        /// </para>
        /// </summary>
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The next message that should be presented to the user.
        /// </para>
        ///  
        /// <para>
        /// You can only use this field in the de-DE, en-AU, en-GB, en-US, es-419, es-ES, es-US,
        /// fr-CA, fr-FR, and it-IT locales. In all other locales, the <c>message</c> field is
        /// null. You should use the <c>encodedMessage</c> field instead.
        /// </para>
        /// </summary>
        [Obsolete("The message field is deprecated, use the encodedMessage field instead. The message field is available only in the de-DE, en-AU, en-GB, en-US, es-419, es-ES, es-US, fr-CA, fr-FR and it-IT locales.")]
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MessageFormat. 
        /// <para>
        /// The format of the response message. One of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PlainText</c> - The message contains plain UTF-8 text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomPayload</c> - The message is a custom format for the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSML</c> - The message contains text formatted for voice output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Composite</c> - The message contains an escaped JSON object containing one or
        /// more messages from the groups that messages were assigned to when the intent was created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MessageFormatType MessageFormat { get; set; }

        /// <summary>
        /// Checks to see if the MessageFormat property is set.
        /// </summary>
        internal bool IsSetMessageFormat() => this.MessageFormat != null;

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key/value pairs representing session-specific context information.
        /// </para>
        /// </summary>
        public string SessionAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SessionAttributes property is set.
        /// </summary>
        internal bool IsSetSessionAttributes() => this.SessionAttributes != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the session.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// If the <c>dialogState</c> is <c>ElicitSlot</c>, returns the name of the slot for which
        /// Amazon Lex is eliciting a value.
        /// </para>
        /// </summary>
        public string SlotToElicit { get; set; }

        /// <summary>
        /// Checks to see if the SlotToElicit property is set.
        /// </summary>
        internal bool IsSetSlotToElicit() => this.SlotToElicit != null;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// Map of zero or more intent slots Amazon Lex detected from the user input during the
        /// conversation.
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex creates a resolution list containing likely values for a slot. The value
        /// that it returns is determined by the <c>valueSelectionStrategy</c> selected when the
        /// slot type was created or updated. If <c>valueSelectionStrategy</c> is set to <c>ORIGINAL_VALUE</c>,
        /// the value provided by the user is returned, if the user value is similar to the slot
        /// values. If <c>valueSelectionStrategy</c> is set to <c>TOP_RESOLUTION</c> Amazon Lex
        /// returns the first value in the resolution list or, if there is no resolution list,
        /// null. If you don't specify a <c>valueSelectionStrategy</c> the default is <c>ORIGINAL_VALUE</c>.
        /// 
        /// </para>
        /// </summary>
        public string Slots { get; set; }

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null;

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
