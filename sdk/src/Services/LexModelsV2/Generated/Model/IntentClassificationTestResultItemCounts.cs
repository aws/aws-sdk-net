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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The number of items in the intent classification test.
    /// </summary>
    public partial class IntentClassificationTestResultItemCounts
    {
        private Dictionary<string, int> _intentMatchResultCounts = new Dictionary<string, int>();
        private Dictionary<string, int> _speechTranscriptionResultCounts = new Dictionary<string, int>();
        private int? _totalResultCount;

        /// <summary>
        /// Gets and sets the property IntentMatchResultCounts. 
        /// <para>
        /// The number of matched and mismatched results for intent recognition for the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, int> IntentMatchResultCounts
        {
            get { return this._intentMatchResultCounts; }
            set { this._intentMatchResultCounts = value; }
        }

        // Check to see if IntentMatchResultCounts property is set
        internal bool IsSetIntentMatchResultCounts()
        {
            return this._intentMatchResultCounts != null && this._intentMatchResultCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResultCounts. 
        /// <para>
        /// The number of matched, mismatched, and execution error results for speech transcription
        /// for the intent.
        /// </para>
        /// </summary>
        public Dictionary<string, int> SpeechTranscriptionResultCounts
        {
            get { return this._speechTranscriptionResultCounts; }
            set { this._speechTranscriptionResultCounts = value; }
        }

        // Check to see if SpeechTranscriptionResultCounts property is set
        internal bool IsSetSpeechTranscriptionResultCounts()
        {
            return this._speechTranscriptionResultCounts != null && this._speechTranscriptionResultCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalResultCount. 
        /// <para>
        /// The total number of results in the intent classification test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int TotalResultCount
        {
            get { return this._totalResultCount.GetValueOrDefault(); }
            set { this._totalResultCount = value; }
        }

        // Check to see if TotalResultCount property is set
        internal bool IsSetTotalResultCount()
        {
            return this._totalResultCount.HasValue; 
        }

    }
}