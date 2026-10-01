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
    /// A word, phrase, or punctuation mark in your transcription output, along with various
    /// associated attributes, such as confidence score, type, and start and end times.
    /// </summary>
    public partial class MedicalScribeTranscriptItem
    {
        /// <summary>
        /// Gets and sets the property BeginAudioTime. 
        /// <para>
        /// The start time, in milliseconds, of the transcribed item.
        /// </para>
        /// </summary>
        public double? BeginAudioTime { get; set; }

        /// <summary>
        /// Checks to see if the BeginAudioTime property is set.
        /// </summary>
        internal bool IsSetBeginAudioTime() => this.BeginAudioTime.HasValue;

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
        public double? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The word, phrase or punctuation mark that was transcribed.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property EndAudioTime. 
        /// <para>
        /// The end time, in milliseconds, of the transcribed item.
        /// </para>
        /// </summary>
        public double? EndAudioTime { get; set; }

        /// <summary>
        /// Checks to see if the EndAudioTime property is set.
        /// </summary>
        internal bool IsSetEndAudioTime() => this.EndAudioTime.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of item identified. Options are: <c>PRONUNCIATION</c> (spoken words) and
        /// <c>PUNCTUATION</c>. 
        /// </para>
        /// </summary>
        public MedicalScribeTranscriptItemType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMatch. 
        /// <para>
        /// Indicates whether the specified item matches a word in the vocabulary filter included
        /// in your configuration event. If <c>true</c>, there is a vocabulary filter match. 
        /// </para>
        /// </summary>
        public bool? VocabularyFilterMatch { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMatch property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMatch() => this.VocabularyFilterMatch.HasValue;
    }
}
