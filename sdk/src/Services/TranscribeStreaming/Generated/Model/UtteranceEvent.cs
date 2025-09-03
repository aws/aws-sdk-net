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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains set of transcription results from one or more audio segments, along with
    /// additional information about the parameters included in your request. For example,
    /// channel definitions, partial result stabilization, sentiment, and issue detection.
    /// </summary>
    public partial class UtteranceEvent
        : IEventStreamEvent
    {
        private long? _beginOffsetMillis;
        private long? _endOffsetMillis;
        private List<CallAnalyticsEntity> _entities = AWSConfigs.InitializeCollections ? new List<CallAnalyticsEntity>() : null;
        private bool? _isPartial;
        private List<IssueDetected> _issuesDetected = AWSConfigs.InitializeCollections ? new List<IssueDetected>() : null;
        private List<CallAnalyticsItem> _items = AWSConfigs.InitializeCollections ? new List<CallAnalyticsItem>() : null;
        private CallAnalyticsLanguageCode _languageCode;
        private List<CallAnalyticsLanguageWithScore> _languageIdentification = AWSConfigs.InitializeCollections ? new List<CallAnalyticsLanguageWithScore>() : null;
        private ParticipantRole _participantRole;
        private Sentiment _sentiment;
        private string _transcript;
        private string _utteranceId;

        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the start of
        /// the <c>UtteranceEvent</c>.
        /// </para>
        /// </summary>
        public long? BeginOffsetMillis
        {
            get { return this._beginOffsetMillis; }
            set { this._beginOffsetMillis = value; }
        }

        // Check to see if BeginOffsetMillis property is set
        internal bool IsSetBeginOffsetMillis()
        {
            return this._beginOffsetMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The time, in milliseconds, from the beginning of the audio stream to the start of
        /// the <c>UtteranceEvent</c>.
        /// </para>
        /// </summary>
        public long? EndOffsetMillis
        {
            get { return this._endOffsetMillis; }
            set { this._endOffsetMillis = value; }
        }

        // Check to see if EndOffsetMillis property is set
        internal bool IsSetEndOffsetMillis()
        {
            return this._endOffsetMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// Contains entities identified as personally identifiable information (PII) in your
        /// transcription output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsEntity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && (this._entities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsPartial. 
        /// <para>
        /// Indicates whether the segment in the <c>UtteranceEvent</c> is complete (<c>FALSE</c>)
        /// or partial (<c>TRUE</c>).
        /// </para>
        /// </summary>
        public bool? IsPartial
        {
            get { return this._isPartial; }
            set { this._isPartial = value; }
        }

        // Check to see if IsPartial property is set
        internal bool IsSetIsPartial()
        {
            return this._isPartial.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IssuesDetected. 
        /// <para>
        /// Provides the issue that was detected in the specified segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IssueDetected> IssuesDetected
        {
            get { return this._issuesDetected; }
            set { this._issuesDetected = value; }
        }

        // Check to see if IssuesDetected property is set
        internal bool IsSetIssuesDetected()
        {
            return this._issuesDetected != null && (this._issuesDetected.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Contains words, phrases, or punctuation marks that are associated with the specified
        /// <c>UtteranceEvent</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language spoken in your audio stream.
        /// </para>
        /// </summary>
        public CallAnalyticsLanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageIdentification. 
        /// <para>
        /// The language code of the dominant language identified in your stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CallAnalyticsLanguageWithScore> LanguageIdentification
        {
            get { return this._languageIdentification; }
            set { this._languageIdentification = value; }
        }

        // Check to see if LanguageIdentification property is set
        internal bool IsSetLanguageIdentification()
        {
            return this._languageIdentification != null && (this._languageIdentification.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// Provides the role of the speaker for each audio channel, either <c>CUSTOMER</c> or
        /// <c>AGENT</c>.
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
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// Provides the sentiment that was detected in the specified segment.
        /// </para>
        /// </summary>
        public Sentiment Sentiment
        {
            get { return this._sentiment; }
            set { this._sentiment = value; }
        }

        // Check to see if Sentiment property is set
        internal bool IsSetSentiment()
        {
            return this._sentiment != null;
        }

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// Contains transcribed text.
        /// </para>
        /// </summary>
        public string Transcript
        {
            get { return this._transcript; }
            set { this._transcript = value; }
        }

        // Check to see if Transcript property is set
        internal bool IsSetTranscript()
        {
            return this._transcript != null;
        }

        /// <summary>
        /// Gets and sets the property UtteranceId. 
        /// <para>
        /// The unique identifier that is associated with the specified <c>UtteranceEvent</c>.
        /// </para>
        /// </summary>
        public string UtteranceId
        {
            get { return this._utteranceId; }
            set { this._utteranceId = value; }
        }

        // Check to see if UtteranceId property is set
        internal bool IsSetUtteranceId()
        {
            return this._utteranceId != null;
        }

    }
}