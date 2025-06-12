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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Contains the current state of the conversation between the client application and
    /// Amazon Lex V2.
    /// </summary>
    public partial class IntentResultEvent
        : IEventStreamEvent
    {
        private string _eventId;
        private InputMode _inputMode;
        private List<Interpretation> _interpretations = AWSConfigs.InitializeCollections ? new List<Interpretation>() : null;
        private RecognizedBotMember _recognizedBotMember;
        private Dictionary<string, string> _requestAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _sessionId;
        private SessionState _sessionStateValue;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier of the event sent by Amazon Lex V2. The identifier is in the form
        /// <c>RESPONSE-N</c>, where N is a number starting with one and incremented for each
        /// event sent by Amazon Lex V2 in the current session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property InputMode. 
        /// <para>
        /// Indicates whether the input to the operation was text, speech, or from a touch-tone
        /// keypad.
        /// </para>
        /// </summary>
        public InputMode InputMode
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<Interpretation> Interpretations
        {
            get { return this._interpretations; }
            set { this._interpretations = value; }
        }

        // Check to see if Interpretations property is set
        internal bool IsSetInterpretations()
        {
            return this._interpretations != null && (this._interpretations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecognizedBotMember. 
        /// <para>
        /// The bot member that is processing the intent.
        /// </para>
        /// </summary>
        public RecognizedBotMember RecognizedBotMember
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && (this._requestAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// </summary>
        public SessionState SessionStateValue
        {
            get { return this._sessionStateValue; }
            set { this._sessionStateValue = value; }
        }

        // Check to see if SessionStateValue property is set
        internal bool IsSetSessionStateValue()
        {
            return this._sessionStateValue != null;
        }

    }
}