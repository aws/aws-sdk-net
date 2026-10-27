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
    /// Contains the results of the test execution, grouped by type of results. See <a href="https://docs.aws.amazon.com/lexv2/latest/dg/test-results-details-test-set.html">Test
    /// result details">Test results details</a> for details about different types of results.
    /// </summary>
    public partial class TestExecutionResultItems
    {
        /// <summary>
        /// Gets and sets the property ConversationLevelTestResults. 
        /// <para>
        /// Results related to conversations in the test set, including metrics about success
        /// and failure of conversations and intent and slot failures.
        /// </para>
        /// </summary>
        public ConversationLevelTestResults ConversationLevelTestResults { get; set; }

        /// <summary>
        /// Checks to see if the ConversationLevelTestResults property is set.
        /// </summary>
        internal bool IsSetConversationLevelTestResults() => this.ConversationLevelTestResults != null;

        /// <summary>
        /// Gets and sets the property IntentClassificationTestResults. 
        /// <para>
        /// Intent recognition results aggregated by intent name. The aggregated results contain
        /// success and failure rates of intent recognition, speech transcriptions, and end-to-end
        /// conversations.
        /// </para>
        /// </summary>
        public IntentClassificationTestResults IntentClassificationTestResults { get; set; }

        /// <summary>
        /// Checks to see if the IntentClassificationTestResults property is set.
        /// </summary>
        internal bool IsSetIntentClassificationTestResults() => this.IntentClassificationTestResults != null;

        /// <summary>
        /// Gets and sets the property IntentLevelSlotResolutionTestResults. 
        /// <para>
        /// Slot resolution results aggregated by intent and slot name. The aggregated results
        /// contain success and failure rates of slot resolution, speech transcriptions, and end-to-end
        /// conversations
        /// </para>
        /// </summary>
        public IntentLevelSlotResolutionTestResults IntentLevelSlotResolutionTestResults { get; set; }

        /// <summary>
        /// Checks to see if the IntentLevelSlotResolutionTestResults property is set.
        /// </summary>
        internal bool IsSetIntentLevelSlotResolutionTestResults() => this.IntentLevelSlotResolutionTestResults != null;

        /// <summary>
        /// Gets and sets the property OverallTestResults. 
        /// <para>
        /// Overall results for the test execution, including the breakdown of conversations and
        /// single-input utterances.
        /// </para>
        /// </summary>
        public OverallTestResults OverallTestResults { get; set; }

        /// <summary>
        /// Checks to see if the OverallTestResults property is set.
        /// </summary>
        internal bool IsSetOverallTestResults() => this.OverallTestResults != null;

        /// <summary>
        /// Gets and sets the property UtteranceLevelTestResults. 
        /// <para>
        /// Results related to utterances in the test set.
        /// </para>
        /// </summary>
        public UtteranceLevelTestResults UtteranceLevelTestResults { get; set; }

        /// <summary>
        /// Checks to see if the UtteranceLevelTestResults property is set.
        /// </summary>
        internal bool IsSetUtteranceLevelTestResults() => this.UtteranceLevelTestResults != null;
    }
}
