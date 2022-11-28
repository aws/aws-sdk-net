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
    /// Flag the presence or absence of specific sentiments detected in your Call Analytics
    /// transcription output.
    /// 
    ///  
    /// <para>
    /// Rules using <code>SentimentFilter</code> are designed to match:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The presence or absence of a positive sentiment felt by the customer, agent, or both
    /// at specified points in the call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The presence or absence of a negative sentiment felt by the customer, agent, or both
    /// at specified points in the call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The presence or absence of a neutral sentiment felt by the customer, agent, or both
    /// at specified points in the call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The presence or absence of a mixed sentiment felt by the customer, the agent, or both
    /// at specified points in the call
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html#tca-rules-batch">Rule
    /// criteria for batch categories</a> for usage examples.
    /// </para>
    /// </summary>
    public partial class SentimentFilter
    {
        private AbsoluteTimeRange _absoluteTimeRange;
        private bool? _negate;
        private ParticipantRole _participantRole;
        private RelativeTimeRange _relativeTimeRange;
        private List<string> _sentiments = new List<string>();

        /// <summary>
        /// Gets and sets the property AbsoluteTimeRange. 
        /// <para>
        /// Makes it possible to specify a time range (in milliseconds) in your audio, during
        /// which you want to search for the specified sentiments. See for more detail.
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
        /// Set to <code>TRUE</code> to flag the sentiments that you didn't include in your request.
        /// Set to <code>FALSE</code> to flag the sentiments that you specified in your request.
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
        /// which you want to search for the specified sentiments. See for more detail.
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
        /// Gets and sets the property Sentiments. 
        /// <para>
        /// Specify the sentiments that you want to flag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Sentiments
        {
            get { return this._sentiments; }
            set { this._sentiments = value; }
        }

        // Check to see if Sentiments property is set
        internal bool IsSetSentiments()
        {
            return this._sentiments != null && this._sentiments.Count > 0; 
        }

    }
}