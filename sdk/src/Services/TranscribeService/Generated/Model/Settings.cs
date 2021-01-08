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
    /// Provides optional settings for the <code>StartTranscriptionJob</code> operation.
    /// </summary>
    public partial class Settings
    {
        private bool? _channelIdentification;
        private int? _maxAlternatives;
        private int? _maxSpeakerLabels;
        private bool? _showAlternatives;
        private bool? _showSpeakerLabels;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ChannelIdentification. 
        /// <para>
        /// Instructs Amazon Transcribe to process each audio channel separately and then merge
        /// the transcription output of each channel into a single transcription. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Transcribe also produces a transcription of each item detected on an audio
        /// channel, including the start time and end time of the item and alternative transcriptions
        /// of the item including the confidence that Amazon Transcribe has in the transcription.
        /// </para>
        ///  
        /// <para>
        /// You can't set both <code>ShowSpeakerLabels</code> and <code>ChannelIdentification</code>
        /// in the same request. If you set both, your request returns a <code>BadRequestException</code>.
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
        /// The number of alternative transcriptions that the service should return. If you specify
        /// the <code>MaxAlternatives</code> field, you must set the <code>ShowAlternatives</code>
        /// field to true.
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
        /// The maximum number of speakers to identify in the input audio. If there are more speakers
        /// in the audio than this number, multiple speakers are identified as a single speaker.
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
        /// Determines whether the transcription contains alternative transcriptions. If you set
        /// the <code>ShowAlternatives</code> field to true, you must also set the maximum number
        /// of alternatives to return in the <code>MaxAlternatives</code> field.
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
        /// Determines whether the transcription job uses speaker recognition to identify different
        /// speakers in the input audio. Speaker recognition labels individual speakers in the
        /// audio file. If you set the <code>ShowSpeakerLabels</code> field to true, you must
        /// also set the maximum number of speaker labels <code>MaxSpeakerLabels</code> field.
        /// </para>
        ///  
        /// <para>
        /// You can't set both <code>ShowSpeakerLabels</code> and <code>ChannelIdentification</code>
        /// in the same request. If you set both, your request returns a <code>BadRequestException</code>.
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
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Set to <code>mask</code> to remove filtered text from the transcript and replace it
        /// with three asterisks ("***") as placeholder text. Set to <code>remove</code> to remove
        /// filtered text from the transcript without using placeholder text.
        /// </para>
        /// </summary>
        public VocabularyFilterMethod VocabularyFilterMethod
        {
            get { return this._vocabularyFilterMethod; }
            set { this._vocabularyFilterMethod = value; }
        }

        // Check to see if VocabularyFilterMethod property is set
        internal bool IsSetVocabularyFilterMethod()
        {
            return this._vocabularyFilterMethod != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the vocabulary filter to use when transcribing the audio. The filter that
        /// you specify must have the same language code as the transcription job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string VocabularyFilterName
        {
            get { return this._vocabularyFilterName; }
            set { this._vocabularyFilterName = value; }
        }

        // Check to see if VocabularyFilterName property is set
        internal bool IsSetVocabularyFilterName()
        {
            return this._vocabularyFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of a vocabulary to use when processing the transcription job.
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