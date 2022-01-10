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
    /// Provides optional settings for the <code>CallAnalyticsJob</code> operation.
    /// </summary>
    public partial class CallAnalyticsJobSettings
    {
        private ContentRedaction _contentRedaction;
        private Dictionary<string, LanguageIdSettings> _languageIdSettings = new Dictionary<string, LanguageIdSettings>();
        private string _languageModelName;
        private List<string> _languageOptions = new List<string>();
        private VocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ContentRedaction.
        /// </summary>
        public ContentRedaction ContentRedaction
        {
            get { return this._contentRedaction; }
            set { this._contentRedaction = value; }
        }

        // Check to see if ContentRedaction property is set
        internal bool IsSetContentRedaction()
        {
            return this._contentRedaction != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageIdSettings. 
        /// <para>
        /// The language identification settings associated with your call analytics job. These
        /// settings include <code>VocabularyName</code>, <code>VocabularyFilterName</code>, and
        /// <code>LanguageModelName</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, LanguageIdSettings> LanguageIdSettings
        {
            get { return this._languageIdSettings; }
            set { this._languageIdSettings = value; }
        }

        // Check to see if LanguageIdSettings property is set
        internal bool IsSetLanguageIdSettings()
        {
            return this._languageIdSettings != null && this._languageIdSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LanguageModelName. 
        /// <para>
        /// The structure used to describe a custom language model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LanguageModelName
        {
            get { return this._languageModelName; }
            set { this._languageModelName = value; }
        }

        // Check to see if LanguageModelName property is set
        internal bool IsSetLanguageModelName()
        {
            return this._languageModelName != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// When you run a call analytics job, you can specify the language spoken in the audio,
        /// or you can have Amazon Transcribe identify the language for you.
        /// </para>
        ///  
        /// <para>
        /// To specify a language, specify an array with one language code. If you don't know
        /// the language, you can leave this field blank and Amazon Transcribe will use machine
        /// learning to identify the language for you. To improve the ability of Amazon Transcribe
        /// to correctly identify the language, you can provide an array of the languages that
        /// can be present in the audio. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> for additional information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> LanguageOptions
        {
            get { return this._languageOptions; }
            set { this._languageOptions = value; }
        }

        // Check to see if LanguageOptions property is set
        internal bool IsSetLanguageOptions()
        {
            return this._languageOptions != null && this._languageOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Set to mask to remove filtered text from the transcript and replace it with three
        /// asterisks ("***") as placeholder text. Set to <code>remove</code> to remove filtered
        /// text from the transcript without using placeholder text. Set to <code>tag</code> to
        /// mark the word in the transcription output that matches the vocabulary filter. When
        /// you set the filter method to <code>tag</code>, the words matching your vocabulary
        /// filter are not masked or removed.
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
        /// The name of the vocabulary filter to use when running a call analytics job. The filter
        /// that you specify must have the same language code as the analytics job.
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
        /// The name of a vocabulary to use when processing the call analytics job.
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