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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The conversation history data to included in conversation context data before the
    /// Amazon Q in Connect session.
    /// </summary>
    public partial class SelfServiceConversationHistory
    {
        /// <summary>
        /// Gets and sets the property BotResponse. 
        /// <para>
        /// The bot response of the conversation history data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string BotResponse { get; set; }

        /// <summary>
        /// Checks to see if the BotResponse property is set.
        /// </summary>
        internal bool IsSetBotResponse() => this.BotResponse != null;

        /// <summary>
        /// Gets and sets the property InputTranscript. 
        /// <para>
        /// The input transcript of the conversation history data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string InputTranscript { get; set; }

        /// <summary>
        /// Checks to see if the InputTranscript property is set.
        /// </summary>
        internal bool IsSetInputTranscript() => this.InputTranscript != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the conversation history entry.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TurnNumber. 
        /// <para>
        /// The number of turn of the conversation history data.
        /// </para>
        /// </summary>
        public int? TurnNumber { get; set; }

        /// <summary>
        /// Checks to see if the TurnNumber property is set.
        /// </summary>
        internal bool IsSetTurnNumber() => this.TurnNumber.HasValue;
    }
}
