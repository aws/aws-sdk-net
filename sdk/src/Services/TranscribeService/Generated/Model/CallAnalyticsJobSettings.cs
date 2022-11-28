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
    /// Provides additional optional settings for your request, including content redaction,
    /// automatic language identification; allows you to apply custom language models, custom
    /// vocabulary filters, and custom vocabularies.
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
        /// If using automatic language identification in your request and you want to apply a
        /// custom language model, a custom vocabulary, or a custom vocabulary filter, include
        /// <code>LanguageIdSettings</code> with the relevant sub-parameters (<code>VocabularyName</code>,
        /// <code>LanguageModelName</code>, and <code>VocabularyFilterName</code>).
        /// </para>
        ///  
        /// <para>
        ///  <code>LanguageIdSettings</code> supports two to five language codes. Each language
        /// code you include can have an associated custom language model, custom vocabulary,
        /// and custom vocabulary filter. The language codes that you specify must match the languages
        /// of the associated custom language models, custom vocabularies, and custom vocabulary
        /// filters.
        /// </para>
        ///  
        /// <para>
        /// It's recommended that you include <code>LanguageOptions</code> when using <code>LanguageIdSettings</code>
        /// to ensure that the correct language dialect is identified. For example, if you specify
        /// a custom vocabulary that is in <code>en-US</code> but Amazon Transcribe determines
        /// that the language spoken in your media is <code>en-AU</code>, your custom vocabulary
        /// <i>is not</i> applied to your transcription. If you include <code>LanguageOptions</code>
        /// and include <code>en-US</code> as the only English language dialect, your custom vocabulary
        /// <i>is</i> applied to your transcription.
        /// </para>
        ///  
        /// <para>
        /// If you want to include a custom language model, custom vocabulary, or custom vocabulary
        /// filter with your request but <b>do not</b> want to use automatic language identification,
        /// use instead the <code/> parameter with the <code>LanguageModelName</code>, <code>VocabularyName</code>,
        /// or <code>VocabularyFilterName</code> sub-parameters.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages supported with Call Analytics, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages and language-specific features</a>.
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
        /// The name of the custom language model you want to use when processing your Call Analytics
        /// job. Note that custom language model names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified custom language model must match the language code that
        /// you specify in your transcription request. If the languages don't match, the custom
        /// language model isn't applied. There are no errors or warnings associated with a language
        /// mismatch.
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
        /// You can specify two or more language codes that represent the languages you think
        /// may be present in your media. Including more than five is not recommended. If you're
        /// unsure what languages are present, do not include this parameter.
        /// </para>
        ///  
        /// <para>
        /// Including language options can improve the accuracy of language identification.
        /// </para>
        ///  
        /// <para>
        /// For a list of languages supported with Call Analytics, refer to the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        ///  
        /// <para>
        /// To transcribe speech in Modern Standard Arabic (<code>ar-SA</code>), your media file
        /// must be encoded at a sample rate of 16,000 Hz or higher.
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
        /// Specify how you want your custom vocabulary filter applied to your transcript.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <code>***</code>, choose <code>mask</code>.
        /// </para>
        ///  
        /// <para>
        /// To delete words, choose <code>remove</code>.
        /// </para>
        ///  
        /// <para>
        /// To flag words without changing them, choose <code>tag</code>.
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
        /// The name of the custom vocabulary filter you want to include in your Call Analytics
        /// transcription request. Custom vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>VocabularyFilterName</code> in your request, you must
        /// also include <code>VocabularyFilterMethod</code>.
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
        /// The name of the custom vocabulary you want to include in your Call Analytics transcription
        /// request. Custom vocabulary names are case sensitive.
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