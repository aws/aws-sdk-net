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
    /// Flag the presence or absence of specific words or phrases detected in your Call Analytics
    /// transcription output.
    /// 
    ///  
    /// <para>
    /// Rules using <code>TranscriptFilter</code> are designed to match:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Custom words or phrases spoken by the agent, the customer, or both
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom words or phrases <b>not</b> spoken by the agent, the customer, or either
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom words or phrases that occur at a specific time frame
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html#tca-rules-batch">Rule
    /// criteria for batch categories</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html#tca-rules-stream">Rule
    /// criteria for streaming categories</a> for usage examples.
    /// </para>
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
        /// Makes it possible to specify a time range (in milliseconds) in your audio, during
        /// which you want to search for the specified key words or phrases. See for more detail.
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
        /// Set to <code>TRUE</code> to flag the absence of the phrase that you specified in your
        /// request. Set to <code>FALSE</code> to flag the presence of the phrase that you specified
        /// in your request.
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
        /// Specify the participant that you want to flag. Omitting this parameter is equivalent
        /// to specifying both participants.
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
        /// Makes it possible to specify a time range (in percentage) in your media file, during
        /// which you want to search for the specified key words or phrases. See for more detail.
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
        /// Specify the phrases that you want to flag.
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
        /// Flag the presence or absence of an exact match to the phrases that you specify. For
        /// example, if you specify the phrase "speak to a manager" as your <code>Targets</code>
        /// value, only that exact phrase is flagged.
        /// </para>
        ///  
        /// <para>
        /// Note that semantic matching is not supported. For example, if your customer says "speak
        /// to <i>the</i> manager", instead of "speak to <i>a</i> manager", your content is not
        /// flagged.
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