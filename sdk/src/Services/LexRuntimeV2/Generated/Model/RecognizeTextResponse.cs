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
    /// This is the response object from the RecognizeText operation.
    /// </summary>
    public partial class RecognizeTextResponse : AmazonWebServiceResponse
    {
        private List<Interpretation> _interpretations = new List<Interpretation>();
        private List<Message> _messages = new List<Message>();
        private RecognizedBotMember _recognizedBotMember;
        private Dictionary<string, string> _requestAttributes = new Dictionary<string, string>();
        private string _sessionId;
        private SessionState _sessionStateValue;

        /// <summary>
        /// Gets and sets the property Interpretations. 
        /// <para>
        /// A list of intents that Amazon Lex V2 determined might satisfy the user's utterance.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Each interpretation includes the intent, a score that indicates now confident Amazon
        /// Lex V2 is that the interpretation is the correct one, and an optional sentiment response
        /// that indicates the sentiment expressed in the utterance.
        /// </para>
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
            return this._interpretations != null && this._interpretations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// A list of messages last sent to the user. The messages are ordered based on the order
        /// that you returned the messages from your Lambda function or the order that the messages
        /// are defined in the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Message> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && this._messages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecognizedBotMember. 
        /// <para>
        /// The bot member that recognized the text.
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
        /// </summary>
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && this._requestAttributes.Count > 0; 
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
        /// Use this to determine the progress of the conversation and what the next action may
        /// be.
        /// </para>
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