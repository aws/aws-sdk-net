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
    /// If using automatic language identification in your request and you want to apply a
    /// custom language model, a custom vocabulary, or a custom vocabulary filter, include
    /// <code>LanguageIdSettings</code> with the relevant sub-parameters (<code>VocabularyName</code>,
    /// <code>LanguageModelName</code>, and <code>VocabularyFilterName</code>). Note that
    /// multi-language identification (<code>IdentifyMultipleLanguages</code>) doesn't support
    /// custom language models.
    /// 
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
    /// If you want to include a custom language model with your request but <b>do not</b>
    /// want to use automatic language identification, use instead the <code/> parameter with
    /// the <code>LanguageModelName</code> sub-parameter. If you want to include a custom
    /// vocabulary or a custom vocabulary filter (or both) with your request but <b>do not</b>
    /// want to use automatic language identification, use instead the <code/> parameter with
    /// the <code>VocabularyName</code> or <code>VocabularyFilterName</code> (or both) sub-parameter.
    /// </para>
    /// </summary>
    public partial class LanguageIdSettings
    {
        private string _languageModelName;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property LanguageModelName. 
        /// <para>
        /// The name of the custom language model you want to use when processing your transcription
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
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the custom vocabulary filter you want to use when processing your transcription
        /// job. Custom vocabulary filter names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified custom vocabulary filter must match the language code
        /// that you specify in your transcription request. If the languages don't match, the
        /// custom vocabulary filter isn't applied. There are no errors or warnings associated
        /// with a language mismatch.
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
        /// The name of the custom vocabulary you want to use when processing your transcription
        /// job. Custom vocabulary names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified custom vocabulary must match the language code that
        /// you specify in your transcription request. If the languages don't match, the custom
        /// vocabulary isn't applied. There are no errors or warnings associated with a language
        /// mismatch.
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