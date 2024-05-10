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
    /// Contains the results of the test execution, grouped by type of results. See <a href="https://docs.aws.amazon.com/lexv2/latest/dg/test-results-details-test-set.html">Test
    /// result details"&gt;Test results details</a> for details about different types of results.
    /// </summary>
    public partial class TestExecutionResultItems
    {
        private ConversationLevelTestResults _conversationLevelTestResults;
        private IntentClassificationTestResults _intentClassificationTestResults;
        private IntentLevelSlotResolutionTestResults _intentLevelSlotResolutionTestResults;
        private OverallTestResults _overallTestResults;
        private UtteranceLevelTestResults _utteranceLevelTestResults;

        /// <summary>
        /// Gets and sets the property ConversationLevelTestResults. 
        /// <para>
        /// Results related to conversations in the test set, including metrics about success
        /// and failure of conversations and intent and slot failures.
        /// </para>
        /// </summary>
        public ConversationLevelTestResults ConversationLevelTestResults
        {
            get { return this._conversationLevelTestResults; }
            set { this._conversationLevelTestResults = value; }
        }

        // Check to see if ConversationLevelTestResults property is set
        internal bool IsSetConversationLevelTestResults()
        {
            return this._conversationLevelTestResults != null;
        }

        /// <summary>
        /// Gets and sets the property IntentClassificationTestResults. 
        /// <para>
        /// Intent recognition results aggregated by intent name. The aggregated results contain
        /// success and failure rates of intent recognition, speech transcriptions, and end-to-end
        /// conversations.
        /// </para>
        /// </summary>
        public IntentClassificationTestResults IntentClassificationTestResults
        {
            get { return this._intentClassificationTestResults; }
            set { this._intentClassificationTestResults = value; }
        }

        // Check to see if IntentClassificationTestResults property is set
        internal bool IsSetIntentClassificationTestResults()
        {
            return this._intentClassificationTestResults != null;
        }

        /// <summary>
        /// Gets and sets the property IntentLevelSlotResolutionTestResults. 
        /// <para>
        /// Slot resolution results aggregated by intent and slot name. The aggregated results
        /// contain success and failure rates of slot resolution, speech transcriptions, and end-to-end
        /// conversations
        /// </para>
        /// </summary>
        public IntentLevelSlotResolutionTestResults IntentLevelSlotResolutionTestResults
        {
            get { return this._intentLevelSlotResolutionTestResults; }
            set { this._intentLevelSlotResolutionTestResults = value; }
        }

        // Check to see if IntentLevelSlotResolutionTestResults property is set
        internal bool IsSetIntentLevelSlotResolutionTestResults()
        {
            return this._intentLevelSlotResolutionTestResults != null;
        }

        /// <summary>
        /// Gets and sets the property OverallTestResults. 
        /// <para>
        /// Overall results for the test execution, including the breakdown of conversations and
        /// single-input utterances.
        /// </para>
        /// </summary>
        public OverallTestResults OverallTestResults
        {
            get { return this._overallTestResults; }
            set { this._overallTestResults = value; }
        }

        // Check to see if OverallTestResults property is set
        internal bool IsSetOverallTestResults()
        {
            return this._overallTestResults != null;
        }

        /// <summary>
        /// Gets and sets the property UtteranceLevelTestResults. 
        /// <para>
        /// Results related to utterances in the test set.
        /// </para>
        /// </summary>
        public UtteranceLevelTestResults UtteranceLevelTestResults
        {
            get { return this._utteranceLevelTestResults; }
            set { this._utteranceLevelTestResults = value; }
        }

        // Check to see if UtteranceLevelTestResults property is set
        internal bool IsSetUtteranceLevelTestResults()
        {
            return this._utteranceLevelTestResults != null;
        }

    }
}