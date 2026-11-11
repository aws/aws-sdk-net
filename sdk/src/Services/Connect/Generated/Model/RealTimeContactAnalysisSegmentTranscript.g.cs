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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The analyzed transcript segment.
    /// </summary>
    public partial class RealTimeContactAnalysisSegmentTranscript
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the transcript. Can be redacted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16384)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of content of the item. For example, <c>text/plain</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the participant. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantRole ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property Redaction. 
        /// <para>
        /// Object describing redaction that was applied to the transcript. If transcript has
        /// the field it means part of the transcript was redacted.
        /// </para>
        /// </summary>
        public RealTimeContactAnalysisTranscriptItemRedaction Redaction { get; set; }

        /// <summary>
        /// Checks to see if the Redaction property is set.
        /// </summary>
        internal bool IsSetRedaction() => this.Redaction != null;

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The sentiment detected for this piece of transcript.
        /// </para>
        /// </summary>
        public RealTimeContactAnalysisSentimentLabel Sentiment { get; set; }

        /// <summary>
        /// Checks to see if the Sentiment property is set.
        /// </summary>
        internal bool IsSetSentiment() => this.Sentiment != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// Field describing the time of the event. It can have different representations of time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RealTimeContactAnalysisTimeData Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null;
    }
}
