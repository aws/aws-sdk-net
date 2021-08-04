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
    /// A condition in the call between the customer and the agent that you want to filter
    /// for.
    /// </summary>
    public partial class Rule
    {
        private InterruptionFilter _interruptionFilter;
        private NonTalkTimeFilter _nonTalkTimeFilter;
        private SentimentFilter _sentimentFilter;
        private TranscriptFilter _transcriptFilter;

        /// <summary>
        /// Gets and sets the property InterruptionFilter. 
        /// <para>
        /// A condition for a time period when either the customer or agent was interrupting the
        /// other person. 
        /// </para>
        /// </summary>
        public InterruptionFilter InterruptionFilter
        {
            get { return this._interruptionFilter; }
            set { this._interruptionFilter = value; }
        }

        // Check to see if InterruptionFilter property is set
        internal bool IsSetInterruptionFilter()
        {
            return this._interruptionFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NonTalkTimeFilter. 
        /// <para>
        /// A condition for a time period when neither the customer nor the agent was talking.
        /// </para>
        /// </summary>
        public NonTalkTimeFilter NonTalkTimeFilter
        {
            get { return this._nonTalkTimeFilter; }
            set { this._nonTalkTimeFilter = value; }
        }

        // Check to see if NonTalkTimeFilter property is set
        internal bool IsSetNonTalkTimeFilter()
        {
            return this._nonTalkTimeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property SentimentFilter. 
        /// <para>
        /// A condition that is applied to a particular customer sentiment.
        /// </para>
        /// </summary>
        public SentimentFilter SentimentFilter
        {
            get { return this._sentimentFilter; }
            set { this._sentimentFilter = value; }
        }

        // Check to see if SentimentFilter property is set
        internal bool IsSetSentimentFilter()
        {
            return this._sentimentFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptFilter. 
        /// <para>
        /// A condition that catches particular words or phrases based on a exact match. For example,
        /// if you set the phrase "I want to speak to the manager", only that exact phrase will
        /// be returned.
        /// </para>
        /// </summary>
        public TranscriptFilter TranscriptFilter
        {
            get { return this._transcriptFilter; }
            set { this._transcriptFilter = value; }
        }

        // Check to see if TranscriptFilter property is set
        internal bool IsSetTranscriptFilter()
        {
            return this._transcriptFilter != null;
        }

    }
}