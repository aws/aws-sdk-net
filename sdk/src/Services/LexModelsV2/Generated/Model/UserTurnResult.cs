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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
        private UserTurnOutputSpecification _actualOutput;
        private ConversationLevelResultDetail _conversationLevelResult;
        private TestResultMatchStatus _endToEndResult;
        private ExecutionErrorDetails _errorDetails;
        private UserTurnOutputSpecification _expectedOutput;
        private UserTurnInputSpecification _input;
        private TestResultMatchStatus _intentMatchResult;
        private TestResultMatchStatus _slotMatchResult;
        private TestResultMatchStatus _speechTranscriptionResult;

        /// <summary>
        /// Gets and sets the property ActualOutput. 
        /// <para>
        /// Contains information about the actual output for the user turn.
        /// </para>
        /// </summary>
        public UserTurnOutputSpecification ActualOutput
        {
            get { return this._actualOutput; }
            set { this._actualOutput = value; }
        }

        // Check to see if ActualOutput property is set
        internal bool IsSetActualOutput()
        {
            return this._actualOutput != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationLevelResult. 
        /// <para>
        /// Contains information about the results related to the conversation associated with
        /// the user turn.
        /// </para>
        /// </summary>
        public ConversationLevelResultDetail ConversationLevelResult
        {
            get { return this._conversationLevelResult; }
            set { this._conversationLevelResult = value; }
        }

        // Check to see if ConversationLevelResult property is set
        internal bool IsSetConversationLevelResult()
        {
            return this._conversationLevelResult != null;
        }

        /// <summary>
        /// Gets and sets the property EndToEndResult. 
        /// <para>
        /// Specifies whether the expected and actual outputs match or not, or if there is an
        /// error in execution.
        /// </para>
        /// </summary>
        public TestResultMatchStatus EndToEndResult
        {
            get { return this._endToEndResult; }
            set { this._endToEndResult = value; }
        }

        // Check to see if EndToEndResult property is set
        internal bool IsSetEndToEndResult()
        {
            return this._endToEndResult != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails.
        /// </summary>
        public ExecutionErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedOutput. 
        /// <para>
        /// Contains information about the expected output for the user turn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserTurnOutputSpecification ExpectedOutput
        {
            get { return this._expectedOutput; }
            set { this._expectedOutput = value; }
        }

        // Check to see if ExpectedOutput property is set
        internal bool IsSetExpectedOutput()
        {
            return this._expectedOutput != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains information about the user messages in the turn in the input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserTurnInputSpecification Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property IntentMatchResult. 
        /// <para>
        /// Specifies whether the expected and actual intents match or not.
        /// </para>
        /// </summary>
        public TestResultMatchStatus IntentMatchResult
        {
            get { return this._intentMatchResult; }
            set { this._intentMatchResult = value; }
        }

        // Check to see if IntentMatchResult property is set
        internal bool IsSetIntentMatchResult()
        {
            return this._intentMatchResult != null;
        }

        /// <summary>
        /// Gets and sets the property SlotMatchResult. 
        /// <para>
        /// Specifies whether the expected and actual slots match or not.
        /// </para>
        /// </summary>
        public TestResultMatchStatus SlotMatchResult
        {
            get { return this._slotMatchResult; }
            set { this._slotMatchResult = value; }
        }

        // Check to see if SlotMatchResult property is set
        internal bool IsSetSlotMatchResult()
        {
            return this._slotMatchResult != null;
        }

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResult. 
        /// <para>
        /// Specifies whether the expected and actual speech transcriptions match or not, or if
        /// there is an error in execution.
        /// </para>
        /// </summary>
        public TestResultMatchStatus SpeechTranscriptionResult
        {
            get { return this._speechTranscriptionResult; }
            set { this._speechTranscriptionResult = value; }
        }

        // Check to see if SpeechTranscriptionResult property is set
        internal bool IsSetSpeechTranscriptionResult()
        {
            return this._speechTranscriptionResult != null;
        }

    }
}