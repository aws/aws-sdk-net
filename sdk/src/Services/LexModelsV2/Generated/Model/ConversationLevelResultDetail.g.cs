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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The conversation level details of the conversation used in the test set.
    /// </summary>
    public partial class ConversationLevelResultDetail
    {
        /// <summary>
        /// Gets and sets the property EndToEndResult. 
        /// <para>
        /// The success or failure of the streaming of the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestResultMatchStatus EndToEndResult { get; set; }

        /// <summary>
        /// Checks to see if the EndToEndResult property is set.
        /// </summary>
        internal bool IsSetEndToEndResult() => this.EndToEndResult != null;

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResult. 
        /// <para>
        /// The speech transcription success or failure details of the conversation.
        /// </para>
        /// </summary>
        public TestResultMatchStatus SpeechTranscriptionResult { get; set; }

        /// <summary>
        /// Checks to see if the SpeechTranscriptionResult property is set.
        /// </summary>
        internal bool IsSetSpeechTranscriptionResult() => this.SpeechTranscriptionResult != null;
    }
}
