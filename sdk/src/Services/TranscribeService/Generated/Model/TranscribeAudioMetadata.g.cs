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
    /// Information about your audio.
    /// </summary>
    public partial class TranscribeAudioMetadata
    {
        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of your transcript, as a locale (for example, <c>en-US</c>). Present
        /// if you used <c>LanguageDetectionMode</c>.
        /// </para>
        /// </summary>
        public SyncLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageCodes. 
        /// <para>
        /// The language identified in your audio, and how long it's spoken. Present if you used
        /// <c>LanguageDetectionMode</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SyncLanguageCodeItem> LanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<SyncLanguageCodeItem>() : null;

        /// <summary>
        /// Checks to see if the LanguageCodes property is set.
        /// </summary>
        internal bool IsSetLanguageCodes() => this.LanguageCodes != null && (this.LanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MediaFormat. 
        /// <para>
        /// The format of your audio, as detected by Amazon Transcribe.
        /// </para>
        /// </summary>
        public MediaFormat MediaFormat { get; set; }

        /// <summary>
        /// Checks to see if the MediaFormat property is set.
        /// </summary>
        internal bool IsSetMediaFormat() => this.MediaFormat != null;

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate of your audio, in hertz, as detected by Amazon Transcribe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfChannels. 
        /// <para>
        /// The number of audio channels in your media. Present if you enabled <c>ChannelIdentification</c>.
        /// </para>
        /// </summary>
        public int? NumberOfChannels { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfChannels property is set.
        /// </summary>
        internal bool IsSetNumberOfChannels() => this.NumberOfChannels.HasValue;

        /// <summary>
        /// Gets and sets the property SpeakersCount. 
        /// <para>
        /// The number of speakers identified in your audio. Present if you enabled <c>ShowSpeakerLabels</c>.
        /// </para>
        /// </summary>
        public int? SpeakersCount { get; set; }

        /// <summary>
        /// Checks to see if the SpeakersCount property is set.
        /// </summary>
        internal bool IsSetSpeakersCount() => this.SpeakersCount.HasValue;
    }
}
