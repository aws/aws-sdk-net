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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// A word, phrase, or punctuation mark in your transcription output, along with various
    /// associated attributes, such as confidence score, type, and start and end times.
    /// </summary>
    public partial class MedicalScribeTranscriptItem
    {
        private double? _beginAudioTime;
        private double? _confidence;
        private string _content;
        private double? _endAudioTime;
        private MedicalScribeTranscriptItemType _type;
        private bool? _vocabularyFilterMatch;

        /// <summary>
        /// Gets and sets the property BeginAudioTime. 
        /// <para>
        /// The start time, in milliseconds, of the transcribed item.
        /// </para>
        /// </summary>
        public double? BeginAudioTime
        {
            get { return this._beginAudioTime; }
            set { this._beginAudioTime = value; }
        }

        // Check to see if BeginAudioTime property is set
        internal bool IsSetBeginAudioTime()
        {
            return this._beginAudioTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence score associated with a word or phrase in your transcript.
        /// </para>
        ///  
        /// <para>
        /// Confidence scores are values between 0 and 1. A larger value indicates a higher probability
        /// that the identified item correctly matches the item spoken in your media. 
        /// </para>
        /// </summary>
        public double? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The word, phrase or punctuation mark that was transcribed.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property EndAudioTime. 
        /// <para>
        /// The end time, in milliseconds, of the transcribed item.
        /// </para>
        /// </summary>
        public double? EndAudioTime
        {
            get { return this._endAudioTime; }
            set { this._endAudioTime = value; }
        }

        // Check to see if EndAudioTime property is set
        internal bool IsSetEndAudioTime()
        {
            return this._endAudioTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of item identified. Options are: <c>PRONUNCIATION</c> (spoken words) and
        /// <c>PUNCTUATION</c>. 
        /// </para>
        /// </summary>
        public MedicalScribeTranscriptItemType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterMatch. 
        /// <para>
        /// Indicates whether the specified item matches a word in the vocabulary filter included
        /// in your configuration event. If <c>true</c>, there is a vocabulary filter match. 
        /// </para>
        /// </summary>
        public bool? VocabularyFilterMatch
        {
            get { return this._vocabularyFilterMatch; }
            set { this._vocabularyFilterMatch = value; }
        }

        // Check to see if VocabularyFilterMatch property is set
        internal bool IsSetVocabularyFilterMatch()
        {
            return this._vocabularyFilterMatch.HasValue; 
        }

    }
}