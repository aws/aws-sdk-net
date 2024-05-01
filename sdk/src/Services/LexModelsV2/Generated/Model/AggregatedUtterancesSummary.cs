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
    /// Provides summary information for aggregated utterances. The <c>ListAggregatedUtterances</c>
    /// operations combines all instances of the same utterance into a single aggregated summary.
    /// </summary>
    public partial class AggregatedUtterancesSummary
    {
        private bool? _containsDataFromDeletedResources;
        private int? _hitCount;
        private int? _missedCount;
        private string _utterance;
        private DateTime? _utteranceFirstRecordedInAggregationDuration;
        private DateTime? _utteranceLastRecordedInAggregationDuration;

        /// <summary>
        /// Gets and sets the property ContainsDataFromDeletedResources. 
        /// <para>
        /// Aggregated utterance data may contain utterances from versions of your bot that have
        /// since been deleted. When the aggregated contains this kind of data, this field is
        /// set to true.
        /// </para>
        /// </summary>
        public bool? ContainsDataFromDeletedResources
        {
            get { return this._containsDataFromDeletedResources; }
            set { this._containsDataFromDeletedResources = value; }
        }

        // Check to see if ContainsDataFromDeletedResources property is set
        internal bool IsSetContainsDataFromDeletedResources()
        {
            return this._containsDataFromDeletedResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HitCount. 
        /// <para>
        /// The number of times that the utterance was detected by Amazon Lex during the time
        /// period. When an utterance is detected, it activates an intent or a slot.
        /// </para>
        /// </summary>
        public int? HitCount
        {
            get { return this._hitCount; }
            set { this._hitCount = value; }
        }

        // Check to see if HitCount property is set
        internal bool IsSetHitCount()
        {
            return this._hitCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissedCount. 
        /// <para>
        /// The number of times that the utterance was missed by Amazon Lex An utterance is missed
        /// when it doesn't activate an intent or slot.
        /// </para>
        /// </summary>
        public int? MissedCount
        {
            get { return this._missedCount; }
            set { this._missedCount = value; }
        }

        // Check to see if MissedCount property is set
        internal bool IsSetMissedCount()
        {
            return this._missedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Utterance. 
        /// <para>
        /// The text of the utterance. If the utterance was used with the <c>RecognizeUtterance</c>
        /// operation, the text is the transcription of the audio utterance.
        /// </para>
        /// </summary>
        public string Utterance
        {
            get { return this._utterance; }
            set { this._utterance = value; }
        }

        // Check to see if Utterance property is set
        internal bool IsSetUtterance()
        {
            return this._utterance != null;
        }

        /// <summary>
        /// Gets and sets the property UtteranceFirstRecordedInAggregationDuration. 
        /// <para>
        /// The date and time that the utterance was first recorded in the time window for aggregation.
        /// An utterance may have been sent to Amazon Lex before that time, but only utterances
        /// within the time window are counted.
        /// </para>
        /// </summary>
        public DateTime? UtteranceFirstRecordedInAggregationDuration
        {
            get { return this._utteranceFirstRecordedInAggregationDuration; }
            set { this._utteranceFirstRecordedInAggregationDuration = value; }
        }

        // Check to see if UtteranceFirstRecordedInAggregationDuration property is set
        internal bool IsSetUtteranceFirstRecordedInAggregationDuration()
        {
            return this._utteranceFirstRecordedInAggregationDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UtteranceLastRecordedInAggregationDuration. 
        /// <para>
        /// The last date and time that an utterance was recorded in the time window for aggregation.
        /// An utterance may be sent to Amazon Lex after that time, but only utterances within
        /// the time window are counted.
        /// </para>
        /// </summary>
        public DateTime? UtteranceLastRecordedInAggregationDuration
        {
            get { return this._utteranceLastRecordedInAggregationDuration; }
            set { this._utteranceLastRecordedInAggregationDuration = value; }
        }

        // Check to see if UtteranceLastRecordedInAggregationDuration property is set
        internal bool IsSetUtteranceLastRecordedInAggregationDuration()
        {
            return this._utteranceLastRecordedInAggregationDuration.HasValue; 
        }

    }
}