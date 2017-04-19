/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Obtains information from the user. To define a prompt, provide one or more messages
    /// and specify the number of attempts to get information from the user. If you provide
    /// more than one message, Amazon Lex chooses one of the messages to use to prompt the
    /// user. For more information, see <a>how-it-works</a>.
    /// </summary>
    public partial class Prompt
    {
        private int? _maxAttempts;
        private List<Message> _messages = new List<Message>();
        private string _responseCard;

        /// <summary>
        /// Gets and sets the property MaxAttempts. 
        /// <para>
        /// The number of times to prompt the user for information.
        /// </para>
        /// </summary>
        public int MaxAttempts
        {
            get { return this._maxAttempts.GetValueOrDefault(); }
            set { this._maxAttempts = value; }
        }

        // Check to see if MaxAttempts property is set
        internal bool IsSetMaxAttempts()
        {
            return this._maxAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// An array of objects, each of which provides a message string and its type. You can
        /// specify the message string in plain text or in Speech Synthesis Markup Language (SSML).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResponseCard. 
        /// <para>
        /// A response card. Amazon Lex uses this prompt at runtime, in the <code>PostText</code>
        /// API response. It substitutes session attributes and slot values for placeholders in
        /// the response card. For more information, see <a>ex-resp-card</a>. 
        /// </para>
        /// </summary>
        public string ResponseCard
        {
            get { return this._responseCard; }
            set { this._responseCard = value; }
        }

        // Check to see if ResponseCard property is set
        internal bool IsSetResponseCard()
        {
            return this._responseCard != null;
        }

    }
}