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
    /// Allows additional optional settings in your request, including channel identification,
    /// alternative transcriptions, and speaker partitioning. You can use that to apply custom
    /// vocabularies to your transcription job.
    /// </summary>
    public partial class Settings
    {
        /// <summary>
        /// Gets and sets the property ChannelIdentification. 
        /// <para>
        /// Enables channel identification in multi-channel audio.
        /// </para>
        ///  
        /// <para>
        /// Channel identification transcribes the audio on each channel independently, then appends
        /// the output for each channel into one transcript.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/channel-id.html">Transcribing
        /// multi-channel audio</a>.
        /// </para>
        /// </summary>
        public bool? ChannelIdentification { get; set; }

        /// <summary>
        /// Checks to see if the ChannelIdentification property is set.
        /// </summary>
        internal bool IsSetChannelIdentification() => this.ChannelIdentification.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAlternatives. 
        /// <para>
        /// Indicate the maximum number of alternative transcriptions you want Amazon Transcribe
        /// to include in your transcript.
        /// </para>
        ///  
        /// <para>
        /// If you select a number greater than the number of alternative transcriptions generated
        /// by Amazon Transcribe, only the actual number of alternative transcriptions are included.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>MaxAlternatives</c> in your request, you must also include <c>ShowAlternatives</c>
        /// with a value of <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-alternatives.html">Alternative
        /// transcriptions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public int? MaxAlternatives { get; set; }

        /// <summary>
        /// Checks to see if the MaxAlternatives property is set.
        /// </summary>
        internal bool IsSetMaxAlternatives() => this.MaxAlternatives.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSpeakerLabels. 
        /// <para>
        /// Specify the maximum number of speakers you want to partition in your media.
        /// </para>
        ///  
        /// <para>
        /// Note that if your media contains more speakers than the specified number, multiple
        /// speakers are treated as a single speaker.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>MaxSpeakerLabels</c> field, you must set the <c>ShowSpeakerLabels</c>
        /// field to true.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 30)]
        public int? MaxSpeakerLabels { get; set; }

        /// <summary>
        /// Checks to see if the MaxSpeakerLabels property is set.
        /// </summary>
        internal bool IsSetMaxSpeakerLabels() => this.MaxSpeakerLabels.HasValue;

        /// <summary>
        /// Gets and sets the property ShowAlternatives. 
        /// <para>
        /// To include alternative transcriptions within your transcription output, include <c>ShowAlternatives</c>
        /// in your transcription request.
        /// </para>
        ///  
        /// <para>
        /// If you have multi-channel audio and do not enable channel identification, your audio
        /// is transcribed in a continuous manner and your transcript does not separate the speech
        /// by channel.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>ShowAlternatives</c>, you must also include <c>MaxAlternatives</c>,
        /// which is the maximum number of alternative transcriptions you want Amazon Transcribe
        /// to generate.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-alternatives.html">Alternative
        /// transcriptions</a>.
        /// </para>
        /// </summary>
        public bool? ShowAlternatives { get; set; }

        /// <summary>
        /// Checks to see if the ShowAlternatives property is set.
        /// </summary>
        internal bool IsSetShowAlternatives() => this.ShowAlternatives.HasValue;

        /// <summary>
        /// Gets and sets the property ShowSpeakerLabels. 
        /// <para>
        /// Enables speaker partitioning (diarization) in your transcription output. Speaker partitioning
        /// labels the speech from individual speakers in your media file.
        /// </para>
        ///  
        /// <para>
        /// If you enable <c>ShowSpeakerLabels</c> in your request, you must also include <c>MaxSpeakerLabels</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/diarization.html">Partitioning
        /// speakers (diarization)</a>.
        /// </para>
        /// </summary>
        public bool? ShowSpeakerLabels { get; set; }

        /// <summary>
        /// Checks to see if the ShowSpeakerLabels property is set.
        /// </summary>
        internal bool IsSetShowSpeakerLabels() => this.ShowSpeakerLabels.HasValue;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Specify how you want your custom vocabulary filter applied to your transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <c>***</c>, choose <c>mask</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete words, choose <c>remove</c>.
        /// </para>
        ///  
        /// <para>
        /// To flag words without changing them, choose <c>tag</c>.
        /// </para>
        /// </summary>
        public VocabularyFilterMethod VocabularyFilterMethod { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMethod property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMethod() => this.VocabularyFilterMethod != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the custom vocabulary filter you want to use in your transcription job
        /// request. This name is case sensitive, cannot contain spaces, and must be unique within
        /// an Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <c>VocabularyFilterName</c> in your request, you must also
        /// include <c>VocabularyFilterMethod</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyFilterName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterName property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterName() => this.VocabularyFilterName != null;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom vocabulary you want to use in your transcription job request.
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;
    }
}
