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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// A rule is a set of criteria that you can specify to flag an attribute in your Call
    /// Analytics output. Rules define a Call Analytics category.
    /// 
    ///  
    /// <para>
    /// Rules can include these parameters: , , , and .
    /// </para>
    ///  
    /// <para>
    /// To learn more about Call Analytics rules and categories, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html">Creating
    /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
    /// categories for real-time transcriptions</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Call Analytics, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics.html">Analyzing
    /// call center audio with Call Analytics</a>.
    /// </para>
    /// </summary>
    public partial class Rule
    {
        /// <summary>
        /// Gets and sets the property InterruptionFilter. 
        /// <para>
        /// Flag the presence or absence of interruptions in your Call Analytics transcription
        /// output. Refer to for more detail.
        /// </para>
        /// </summary>
        public InterruptionFilter InterruptionFilter { get; set; }

        /// <summary>
        /// Checks to see if the InterruptionFilter property is set.
        /// </summary>
        internal bool IsSetInterruptionFilter() => this.InterruptionFilter != null;

        /// <summary>
        /// Gets and sets the property NonTalkTimeFilter. 
        /// <para>
        /// Flag the presence or absence of periods of silence in your Call Analytics transcription
        /// output. Refer to for more detail.
        /// </para>
        /// </summary>
        public NonTalkTimeFilter NonTalkTimeFilter { get; set; }

        /// <summary>
        /// Checks to see if the NonTalkTimeFilter property is set.
        /// </summary>
        internal bool IsSetNonTalkTimeFilter() => this.NonTalkTimeFilter != null;

        /// <summary>
        /// Gets and sets the property SentimentFilter. 
        /// <para>
        /// Flag the presence or absence of specific sentiments in your Call Analytics transcription
        /// output. Refer to for more detail.
        /// </para>
        /// </summary>
        public SentimentFilter SentimentFilter { get; set; }

        /// <summary>
        /// Checks to see if the SentimentFilter property is set.
        /// </summary>
        internal bool IsSetSentimentFilter() => this.SentimentFilter != null;

        /// <summary>
        /// Gets and sets the property TranscriptFilter. 
        /// <para>
        /// Flag the presence or absence of specific words or phrases in your Call Analytics transcription
        /// output. Refer to for more detail.
        /// </para>
        /// </summary>
        public TranscriptFilter TranscriptFilter { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptFilter property is set.
        /// </summary>
        internal bool IsSetTranscriptFilter() => this.TranscriptFilter != null;
    }
}
