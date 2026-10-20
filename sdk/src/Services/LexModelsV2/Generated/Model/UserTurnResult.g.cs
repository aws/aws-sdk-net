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
    /// Contains the results for the user turn by the test execution.
    /// </summary>
    public partial class UserTurnResult
    {
        /// <summary>
        /// Gets and sets the property ActualOutput. 
        /// <para>
        /// Contains information about the actual output for the user turn.
        /// </para>
        /// </summary>
        public UserTurnOutputSpecification ActualOutput { get; set; }

        /// <summary>
        /// Checks to see if the ActualOutput property is set.
        /// </summary>
        internal bool IsSetActualOutput() => this.ActualOutput != null;

        /// <summary>
        /// Gets and sets the property ConversationLevelResult. 
        /// <para>
        /// Contains information about the results related to the conversation associated with
        /// the user turn.
        /// </para>
        /// </summary>
        public ConversationLevelResultDetail ConversationLevelResult { get; set; }

        /// <summary>
        /// Checks to see if the ConversationLevelResult property is set.
        /// </summary>
        internal bool IsSetConversationLevelResult() => this.ConversationLevelResult != null;

        /// <summary>
        /// Gets and sets the property EndToEndResult. 
        /// <para>
        /// Specifies whether the expected and actual outputs match or not, or if there is an
        /// error in execution.
        /// </para>
        /// </summary>
        public TestResultMatchStatus EndToEndResult { get; set; }

        /// <summary>
        /// Checks to see if the EndToEndResult property is set.
        /// </summary>
        internal bool IsSetEndToEndResult() => this.EndToEndResult != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails.
        /// </summary>
        public ExecutionErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ExpectedOutput. 
        /// <para>
        /// Contains information about the expected output for the user turn.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserTurnOutputSpecification ExpectedOutput { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedOutput property is set.
        /// </summary>
        internal bool IsSetExpectedOutput() => this.ExpectedOutput != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains information about the user messages in the turn in the input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserTurnInputSpecification Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property IntentMatchResult. 
        /// <para>
        /// Specifies whether the expected and actual intents match or not.
        /// </para>
        /// </summary>
        public TestResultMatchStatus IntentMatchResult { get; set; }

        /// <summary>
        /// Checks to see if the IntentMatchResult property is set.
        /// </summary>
        internal bool IsSetIntentMatchResult() => this.IntentMatchResult != null;

        /// <summary>
        /// Gets and sets the property SlotMatchResult. 
        /// <para>
        /// Specifies whether the expected and actual slots match or not.
        /// </para>
        /// </summary>
        public TestResultMatchStatus SlotMatchResult { get; set; }

        /// <summary>
        /// Checks to see if the SlotMatchResult property is set.
        /// </summary>
        internal bool IsSetSlotMatchResult() => this.SlotMatchResult != null;

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResult. 
        /// <para>
        /// Specifies whether the expected and actual speech transcriptions match or not, or if
        /// there is an error in execution.
        /// </para>
        /// </summary>
        public TestResultMatchStatus SpeechTranscriptionResult { get; set; }

        /// <summary>
        /// Checks to see if the SpeechTranscriptionResult property is set.
        /// </summary>
        internal bool IsSetSpeechTranscriptionResult() => this.SpeechTranscriptionResult != null;
    }
}
