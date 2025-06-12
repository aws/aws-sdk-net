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
    /// The test result evaluation item at the conversation level.
    /// </summary>
    public partial class ConversationLevelTestResultItem
    {
        private string _conversationId;
        private TestResultMatchStatus _endToEndResult;
        private List<ConversationLevelIntentClassificationResultItem> _intentClassificationResults = AWSConfigs.InitializeCollections ? new List<ConversationLevelIntentClassificationResultItem>() : null;
        private List<ConversationLevelSlotResolutionResultItem> _slotResolutionResults = AWSConfigs.InitializeCollections ? new List<ConversationLevelSlotResolutionResultItem>() : null;
        private TestResultMatchStatus _speechTranscriptionResult;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The conversation Id of the test result evaluation item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property EndToEndResult. 
        /// <para>
        /// The end-to-end success or failure of the test result evaluation item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IntentClassificationResults. 
        /// <para>
        /// The intent classification of the test result evaluation item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConversationLevelIntentClassificationResultItem> IntentClassificationResults
        {
            get { return this._intentClassificationResults; }
            set { this._intentClassificationResults = value; }
        }

        // Check to see if IntentClassificationResults property is set
        internal bool IsSetIntentClassificationResults()
        {
            return this._intentClassificationResults != null && (this._intentClassificationResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SlotResolutionResults. 
        /// <para>
        /// The slot success or failure of the test result evaluation item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConversationLevelSlotResolutionResultItem> SlotResolutionResults
        {
            get { return this._slotResolutionResults; }
            set { this._slotResolutionResults = value; }
        }

        // Check to see if SlotResolutionResults property is set
        internal bool IsSetSlotResolutionResults()
        {
            return this._slotResolutionResults != null && (this._slotResolutionResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResult. 
        /// <para>
        /// The speech transcription success or failure of the test result evaluation item.
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