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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Matches the output of the transcription to either the specific phrases that you specify,
    /// or the intent of the phrases that you specify.
    /// </summary>
    public partial class TranscriptFilter
    {
        private AbsoluteTimeRange _absoluteTimeRange;
        private bool? _negate;
        private ParticipantRole _participantRole;
        private RelativeTimeRange _relativeTimeRange;
        private List<string> _targets = new List<string>();
        private TranscriptFilterType _transcriptFilterType;

        /// <summary>
        /// Gets and sets the property AbsoluteTimeRange. 
        /// <para>
        /// A time range, set in seconds, between two points in the call.
        /// </para>
        /// </summary>
        public AbsoluteTimeRange AbsoluteTimeRange
        {
            get { return this._absoluteTimeRange; }
            set { this._absoluteTimeRange = value; }
        }

        // Check to see if AbsoluteTimeRange property is set
        internal bool IsSetAbsoluteTimeRange()
        {
            return this._absoluteTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// If <code>TRUE</code>, the rule that you specify is applied to everything except for
        /// the phrases that you specify.
        /// </para>
        /// </summary>
        public bool Negate
        {
            get { return this._negate.GetValueOrDefault(); }
            set { this._negate = value; }
        }

        // Check to see if Negate property is set
        internal bool IsSetNegate()
        {
            return this._negate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Determines whether the customer or the agent is speaking the phrases that you've specified.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeTimeRange. 
        /// <para>
        /// An object that allows percentages to specify the proportion of the call where you
        /// would like to apply a filter. For example, you can specify the first half of the call.
        /// You can also specify the period of time between halfway through to three-quarters
        /// of the way through the call. Because the length of conversation can vary between calls,
        /// you can apply relative time ranges across all calls.
        /// </para>
        /// </summary>
        public RelativeTimeRange RelativeTimeRange
        {
            get { return this._relativeTimeRange; }
            set { this._relativeTimeRange = value; }
        }

        // Check to see if RelativeTimeRange property is set
        internal bool IsSetRelativeTimeRange()
        {
            return this._relativeTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The phrases that you're specifying for the transcript filter to match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TranscriptFilterType. 
        /// <para>
        /// Matches the phrase to the transcription output in a word for word fashion. For example,
        /// if you specify the phrase "I want to speak to the manager." Amazon Transcribe attempts
        /// to match that specific phrase to the transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscriptFilterType TranscriptFilterType
        {
            get { return this._transcriptFilterType; }
            set { this._transcriptFilterType = value; }
        }

        // Check to see if TranscriptFilterType property is set
        internal bool IsSetTranscriptFilterType()
        {
            return this._transcriptFilterType != null;
        }

    }
}