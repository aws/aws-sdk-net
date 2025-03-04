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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Makes it possible to control how your Medical Scribe job is processed using a <c>MedicalScribeSettings</c>
    /// object. Specify <c>ChannelIdentification</c> if <c>ChannelDefinitions</c> are set.
    /// Enabled <c>ShowSpeakerLabels</c> if <c>ChannelIdentification</c> and <c>ChannelDefinitions</c>
    /// are not set. One and only one of <c>ChannelIdentification</c> and <c>ShowSpeakerLabels</c>
    /// must be set. If <c>ShowSpeakerLabels</c> is set, <c>MaxSpeakerLabels</c> must also
    /// be set. Use <c>Settings</c> to specify a vocabulary or vocabulary filter or both using
    /// <c>VocabularyName</c>, <c>VocabularyFilterName</c>. <c>VocabularyFilterMethod</c>
    /// must be specified if <c>VocabularyFilterName</c> is set.
    /// </summary>
    public partial class MedicalScribeSettings
    {
        private bool? _channelIdentification;
        private ClinicalNoteGenerationSettings _clinicalNoteGenerationSettings;
        private int? _maxSpeakerLabels;
        private bool? _showSpeakerLabels;
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
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
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/channel-id.html">Transcribing
        /// multi-channel audio</a>.
        /// </para>
        /// </summary>
        public bool? ChannelIdentification
        {
            get { return this._channelIdentification; }
            set { this._channelIdentification = value; }
        }

        // Check to see if ChannelIdentification property is set
        internal bool IsSetChannelIdentification()
        {
            return this._channelIdentification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClinicalNoteGenerationSettings. 
        /// <para>
        /// Specify settings for the clinical note generation.
        /// </para>
        /// </summary>
        public ClinicalNoteGenerationSettings ClinicalNoteGenerationSettings
        {
            get { return this._clinicalNoteGenerationSettings; }
            set { this._clinicalNoteGenerationSettings = value; }
        }

        // Check to see if ClinicalNoteGenerationSettings property is set
        internal bool IsSetClinicalNoteGenerationSettings()
        {
            return this._clinicalNoteGenerationSettings != null;
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
        /// If you specify the <c>MaxSpeakerLabels</c> field, you must set the <c>ShowSpeakerLabels</c>
        /// field to true.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=30)]
        public int? MaxSpeakerLabels
        {
            get { return this._maxSpeakerLabels; }
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
        /// Enables speaker partitioning (diarization) in your Medical Scribe output. Speaker
        /// partitioning labels the speech from individual speakers in your media file.
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
        public bool? ShowSpeakerLabels
        {
            get { return this._showSpeakerLabels; }
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
        /// The name of the custom vocabulary filter you want to include in your Medical Scribe
        /// request. Custom vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <c>VocabularyFilterName</c> in your request, you must also
        /// include <c>VocabularyFilterMethod</c>.
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
        /// The name of the custom vocabulary you want to include in your Medical Scribe request.
        /// Custom vocabulary names are case sensitive.
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