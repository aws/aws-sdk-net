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
    /// Allows additional optional settings in your request, including channel identification,
    /// alternative transcriptions, and speaker partitioning. You can use that to apply custom
    /// vocabularies to your medical transcription job.
    /// </summary>
    public partial class MedicalTranscriptionSetting
    {
        private bool? _channelIdentification;
        private int? _maxAlternatives;
        private int? _maxSpeakerLabels;
        private bool? _showAlternatives;
        private bool? _showSpeakerLabels;
        private string _vocabularyName;

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
        /// If you have multi-channel audio and do not enable channel identification, your audio
        /// is transcribed in a continuous manner and your transcript does not separate the speech
        /// by channel.
        /// </para>
        ///  
        /// <para>
        /// You can't include both <code>ShowSpeakerLabels</code> and <code>ChannelIdentification</code>
        /// in the same request. Including both parameters returns a <code>BadRequestException</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/channel-id.html">Transcribing
        /// multi-channel audio</a>.
        /// </para>
        /// </summary>
        public bool ChannelIdentification
        {
            get { return this._channelIdentification.GetValueOrDefault(); }
            set { this._channelIdentification = value; }
        }

        // Check to see if ChannelIdentification property is set
        internal bool IsSetChannelIdentification()
        {
            return this._channelIdentification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAlternatives. 
        /// <para>
        /// Indicate the maximum number of alternative transcriptions you want Amazon Transcribe
        /// Medical to include in your transcript.
        /// </para>
        ///  
        /// <para>
        /// If you select a number greater than the number of alternative transcriptions generated
        /// by Amazon Transcribe Medical, only the actual number of alternative transcriptions
        /// are included.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>MaxAlternatives</code> in your request, you must also include
        /// <code>ShowAlternatives</code> with a value of <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-alternatives.html">Alternative
        /// transcriptions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int MaxAlternatives
        {
            get { return this._maxAlternatives.GetValueOrDefault(); }
            set { this._maxAlternatives = value; }
        }

        // Check to see if MaxAlternatives property is set
        internal bool IsSetMaxAlternatives()
        {
            return this._maxAlternatives.HasValue; 
        }

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
        /// If you specify the <code>MaxSpeakerLabels</code> field, you must set the <code>ShowSpeakerLabels</code>
        /// field to true.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=10)]
        public int MaxSpeakerLabels
        {
            get { return this._maxSpeakerLabels.GetValueOrDefault(); }
            set { this._maxSpeakerLabels = value; }
        }

        // Check to see if MaxSpeakerLabels property is set
        internal bool IsSetMaxSpeakerLabels()
        {
            return this._maxSpeakerLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShowAlternatives. 
        /// <para>
        /// To include alternative transcriptions within your transcription output, include <code>ShowAlternatives</code>
        /// in your transcription request.
        /// </para>
        ///  
        /// <para>
        /// If you include <code>ShowAlternatives</code>, you must also include <code>MaxAlternatives</code>,
        /// which is the maximum number of alternative transcriptions you want Amazon Transcribe
        /// Medical to generate.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-alternatives.html">Alternative
        /// transcriptions</a>.
        /// </para>
        /// </summary>
        public bool ShowAlternatives
        {
            get { return this._showAlternatives.GetValueOrDefault(); }
            set { this._showAlternatives = value; }
        }

        // Check to see if ShowAlternatives property is set
        internal bool IsSetShowAlternatives()
        {
            return this._showAlternatives.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShowSpeakerLabels. 
        /// <para>
        /// Enables speaker partitioning (diarization) in your transcription output. Speaker partitioning
        /// labels the speech from individual speakers in your media file.
        /// </para>
        ///  
        /// <para>
        /// If you enable <code>ShowSpeakerLabels</code> in your request, you must also include
        /// <code>MaxSpeakerLabels</code>.
        /// </para>
        ///  
        /// <para>
        /// You can't include <code>ShowSpeakerLabels</code> and <code>ChannelIdentification</code>
        /// in the same request. Including both parameters returns a <code>BadRequestException</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/diarization.html">Partitioning
        /// speakers (diarization)</a>.
        /// </para>
        /// </summary>
        public bool ShowSpeakerLabels
        {
            get { return this._showSpeakerLabels.GetValueOrDefault(); }
            set { this._showSpeakerLabels = value; }
        }

        // Check to see if ShowSpeakerLabels property is set
        internal bool IsSetShowSpeakerLabels()
        {
            return this._showSpeakerLabels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom vocabulary you want to use when processing your medical transcription
        /// job. Custom vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified custom vocabulary must match the language code that
        /// you specify in your transcription request. If the languages don't match, the custom
        /// vocabulary isn't applied. There are no errors or warnings associated with a language
        /// mismatch. US English (<code>en-US</code>) is the only valid language for Amazon Transcribe
        /// Medical.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string VocabularyName
        {
            get { return this._vocabularyName; }
            set { this._vocabularyName = value; }
        }

        // Check to see if VocabularyName property is set
        internal bool IsSetVocabularyName()
        {
            return this._vocabularyName != null;
        }

    }
}