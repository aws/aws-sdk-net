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
    /// An object that enables you to specify a particular customer or agent sentiment. If
    /// at least 50 percent of the conversation turns (the back-and-forth between two speakers)
    /// in a specified time period match the specified sentiment, Amazon Transcribe will consider
    /// the sentiment a match.
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
        /// The time range, measured in seconds, of the sentiment.
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
        /// Set to <code>TRUE</code> to look for sentiments that weren't specified in the request.
        /// 
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
        /// A value that determines whether the sentiment belongs to the customer or the agent.
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
        /// The time range, set in percentages, that correspond to proportion of the call.
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
        /// An array that enables you to specify sentiments for the customer or agent. You can
        /// specify one or more values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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