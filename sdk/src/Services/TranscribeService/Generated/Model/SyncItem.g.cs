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
    /// A word or punctuation mark in your transcript. Labels such as <c>SpeakerLabel</c>
    /// and <c>ChannelLabel</c> are present only if you enabled the related feature.
    /// </summary>
    public partial class SyncItem
    {
        /// <summary>
        /// Gets and sets the property ChannelLabel. 
        /// <para>
        /// The audio channel this item came from (<c>ch_0</c> or <c>ch_1</c>). Present if you
        /// enabled <c>ChannelIdentification</c>.
        /// </para>
        ///  
        /// <para>
        /// Item start and end times are measured from the start of the audio, separately for
        /// each channel.
        /// </para>
        /// </summary>
        public string ChannelLabel { get; set; }

        /// <summary>
        /// Checks to see if the ChannelLabel property is set.
        /// </summary>
        internal bool IsSetChannelLabel() => this.ChannelLabel != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The word or punctuation mark. In <c>RedactedResults</c>, Amazon Transcribe replaces
        /// redacted words with <c>[PII]</c>.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time, in seconds from the start of your audio, when this item ends.
        /// </para>
        /// </summary>
        public double? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The position of this item in the transcript, starting at 0.
        /// </para>
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of this item, as a locale (for example, <c>en-US</c>).
        /// </para>
        /// </summary>
        public SyncLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Redactions. 
        /// <para>
        /// The types of personally identifiable information (PII) that Amazon Transcribe redacted
        /// from this item. Present only on redacted items in <c>RedactedResults</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SyncRedaction> Redactions { get; set; } = AWSConfigs.InitializeCollections ? new List<SyncRedaction>() : null;

        /// <summary>
        /// Checks to see if the Redactions property is set.
        /// </summary>
        internal bool IsSetRedactions() => this.Redactions != null && (this.Redactions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpeakerLabel. 
        /// <para>
        /// The speaker of this item (for example, <c>spk_0</c>). Present if you enabled <c>ShowSpeakerLabels</c>.
        /// </para>
        /// </summary>
        public string SpeakerLabel { get; set; }

        /// <summary>
        /// Checks to see if the SpeakerLabel property is set.
        /// </summary>
        internal bool IsSetSpeakerLabel() => this.SpeakerLabel != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time, in seconds from the start of your audio, when this item starts.
        /// </para>
        /// </summary>
        public double? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMatch. 
        /// <para>
        /// Indicates whether this item matched a word in your custom vocabulary filter. Present
        /// if you included <c>VocabularyFilterSettings</c>.
        /// </para>
        /// </summary>
        public bool? VocabularyFilterMatch { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMatch property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMatch() => this.VocabularyFilterMatch.HasValue;
    }
}
