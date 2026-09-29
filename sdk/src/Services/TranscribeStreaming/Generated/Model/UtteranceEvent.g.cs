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

namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains set of transcription results from one or more audio segments, along with
    /// additional information about the parameters included in your request. For example,
    /// channel definitions, partial result stabilization, sentiment, and issue detection.
    /// </summary>
    public partial class UtteranceEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the start of
        /// the <c>UtteranceEvent</c>.
        /// </para>
        /// </summary>
        public long? BeginOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffsetMillis property is set.
        /// </summary>
        internal bool IsSetBeginOffsetMillis() => this.BeginOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the start of
        /// the <c>UtteranceEvent</c>.
        /// </para>
        /// </summary>
        public long? EndOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the EndOffsetMillis property is set.
        /// </summary>
        internal bool IsSetEndOffsetMillis() => this.EndOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// Contains entities identified as personally identifiable information (PII) in your
        /// transcription output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsEntity> Entities { get; set; } = AWSConfigs.InitializeCollections ? new List<CallAnalyticsEntity>() : null;

        /// <summary>
        /// Checks to see if the Entities property is set.
        /// </summary>
        internal bool IsSetEntities() => this.Entities != null && (this.Entities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// Indicates whether the segment in the <c>UtteranceEvent</c> is complete (<c>FALSE</c>)
        /// or partial (<c>TRUE</c>).
        /// </para>
        /// </summary>
        public bool? IsPartial { get; set; }

        /// <summary>
        /// Checks to see if the IsPartial property is set.
        /// </summary>
        internal bool IsSetIsPartial() => this.IsPartial.HasValue;

        /// <summary>
        /// Gets and sets the property IssuesDetected. 
        /// <para>
        /// Provides the issue that was detected in the specified segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IssueDetected> IssuesDetected { get; set; } = AWSConfigs.InitializeCollections ? new List<IssueDetected>() : null;

        /// <summary>
        /// Checks to see if the IssuesDetected property is set.
        /// </summary>
        internal bool IsSetIssuesDetected() => this.IssuesDetected != null && (this.IssuesDetected.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Contains words, phrases, or punctuation marks that are associated with the specified
        /// <c>UtteranceEvent</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<CallAnalyticsItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language spoken in your audio stream.
        /// </para>
        /// </summary>
        public CallAnalyticsLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageIdentification. 
        /// <para>
        /// The language code of the dominant language identified in your stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsLanguageWithScore> LanguageIdentification { get; set; } = AWSConfigs.InitializeCollections ? new List<CallAnalyticsLanguageWithScore>() : null;

        /// <summary>
        /// Checks to see if the LanguageIdentification property is set.
        /// </summary>
        internal bool IsSetLanguageIdentification() => this.LanguageIdentification != null && (this.LanguageIdentification.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Provides the role of the speaker for each audio channel, either <c>CUSTOMER</c> or
        /// <c>AGENT</c>.
        /// </para>
        /// </summary>
        public ParticipantRole ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// Provides the sentiment that was detected in the specified segment.
        /// </para>
        /// </summary>
        public Sentiment Sentiment { get; set; }

        /// <summary>
        /// Checks to see if the Sentiment property is set.
        /// </summary>
        internal bool IsSetSentiment() => this.Sentiment != null;

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// Contains transcribed text.
        /// </para>
        /// </summary>
        public string Transcript { get; set; }

        /// <summary>
        /// Checks to see if the Transcript property is set.
        /// </summary>
        internal bool IsSetTranscript() => this.Transcript != null;

        /// <summary>
        /// Gets and sets the property UtteranceId. 
        /// <para>
        /// The unique identifier that is associated with the specified <c>UtteranceEvent</c>.
        /// </para>
        /// </summary>
        public string UtteranceId { get; set; }

        /// <summary>
        /// Checks to see if the UtteranceId property is set.
        /// </summary>
        internal bool IsSetUtteranceId() => this.UtteranceId != null;
    }
}
