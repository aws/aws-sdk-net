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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The conversation history data to included in conversation context data before the
    /// Amazon Q in Connect session.
    /// </summary>
    public partial class SelfServiceConversationHistory
    {
        private string _botResponse;
        private string _inputTranscript;
        private int? _turnNumber;

        /// <summary>
        /// Gets and sets the property BotResponse. 
        /// <para>
        /// The bot response of the conversation history data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string BotResponse
        {
            get { return this._botResponse; }
            set { this._botResponse = value; }
        }

        // Check to see if BotResponse property is set
        internal bool IsSetBotResponse()
        {
            return this._botResponse != null;
        }

        /// <summary>
        /// Gets and sets the property InputTranscript. 
        /// <para>
        /// The input transcript of the conversation history data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property TurnNumber. 
        /// <para>
        /// The number of turn of the conversation history data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TurnNumber
        {
            get { return this._turnNumber; }
            set { this._turnNumber = value; }
        }

        // Check to see if TurnNumber property is set
        internal bool IsSetTurnNumber()
        {
            return this._turnNumber.HasValue; 
        }

    }
}