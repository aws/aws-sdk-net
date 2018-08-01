/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private int? _maxSpeakerLabels;
        private bool? _showSpeakerLabels;
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
        /// Gets and sets the property MaxSpeakerLabels. 
        /// <para>
        /// The maximum number of speakers to identify in the input audio. If there are more speakers
        /// in the audio than this number, multiple speakers will be identified as a single speaker.
        /// If you specify the <code>MaxSpeakerLabels</code> field, you must set the <code>ShowSpeakerLabels</code>
        /// field to true.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of a vocabulary to use when processing the transcription job.
        /// </para>
        /// </summary>
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