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
    /// Information about the counts for a slot resolution in the results of a test execution.
    /// </summary>
    public partial class SlotResolutionTestResultItemCounts
    {
        private Dictionary<string, int> _slotMatchResultCounts = new Dictionary<string, int>();
        private Dictionary<string, int> _speechTranscriptionResultCounts = new Dictionary<string, int>();
        private int? _totalResultCount;

        /// <summary>
        /// Gets and sets the property SlotMatchResultCounts. 
        /// <para>
        /// The number of matched and mismatched results for slot resolution for the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, int> SlotMatchResultCounts
        {
            get { return this._slotMatchResultCounts; }
            set { this._slotMatchResultCounts = value; }
        }

        // Check to see if SlotMatchResultCounts property is set
        internal bool IsSetSlotMatchResultCounts()
        {
            return this._slotMatchResultCounts != null && this._slotMatchResultCounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResultCounts. 
        /// <para>
        /// The number of matched, mismatched and execution error results for speech transcription
        /// for the slot.
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
        /// The total number of results.
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