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
    /// Contains the current state of the conversation between the client application and
    /// Amazon Lex V2.
    /// </summary>
    public partial class IntentResultEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier of the event sent by Amazon Lex V2. The identifier is in the form
        /// <c>RESPONSE-N</c>, where N is a number starting with one and incremented for each
        /// event sent by Amazon Lex V2 in the current session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property InputMode. 
        /// <para>
        /// Indicates whether the input to the operation was text, speech, or from a touch-tone
        /// keypad.
        /// </para>
        /// </summary>
        public InputMode InputMode { get; set; }

        /// <summary>
        /// Checks to see if the InputMode property is set.
        /// </summary>
        internal bool IsSetInputMode() => this.InputMode != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Interpretation> Interpretations { get; set; } = AWSConfigs.InitializeCollections ? new List<Interpretation>() : null;

        /// <summary>
        /// Checks to see if the Interpretations property is set.
        /// </summary>
        internal bool IsSetInterpretations() => this.Interpretations != null && (this.Interpretations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecognizedBotMember. 
        /// <para>
        /// The bot member that is processing the intent.
        /// </para>
        /// </summary>
        public RecognizedBotMember RecognizedBotMember { get; set; }

        /// <summary>
        /// Checks to see if the RecognizedBotMember property is set.
        /// </summary>
        internal bool IsSetRecognizedBotMember() => this.RecognizedBotMember != null;

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// The attributes sent in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestAttributes property is set.
        /// </summary>
        internal bool IsSetRequestAttributes() => this.RequestAttributes != null && (this.RequestAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// </summary>
        public SessionState SessionStateValue { get; set; }

        /// <summary>
        /// Checks to see if the SessionStateValue property is set.
        /// </summary>
        internal bool IsSetSessionStateValue() => this.SessionStateValue != null;
    }
}
