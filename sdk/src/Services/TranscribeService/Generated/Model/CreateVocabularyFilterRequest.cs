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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVocabularyFilter operation.
    /// Creates a new vocabulary filter that you can use to filter words, such as profane
    /// words, from the output of a transcription job.
    /// </summary>
    public partial class CreateVocabularyFilterRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private string _vocabularyFilterFileUri;
        private string _vocabularyFilterName;
        private List<string> _words = new List<string>();

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code of the words in the vocabulary filter. All words in the filter must
        /// be in the same language. The vocabulary filter can only be used with transcription
        /// jobs in the specified language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterFileUri. 
        /// <para>
        /// The Amazon S3 location of a text file used as input to create the vocabulary filter.
        /// Only use characters from the character set defined for custom vocabularies. For a
        /// list of character sets, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-vocabulary.html#charsets">Character
        /// Sets for Custom Vocabularies</a>.
        /// </para>
        ///  
        /// <para>
        /// The specified file must be less than 50 KB of UTF-8 characters.
        /// </para>
        ///  
        /// <para>
        /// If you provide the location of a list of words in the <code>VocabularyFilterFileUri</code>
        /// parameter, you can't use the <code>Words</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string VocabularyFilterFileUri
        {
            get { return this._vocabularyFilterFileUri; }
            set { this._vocabularyFilterFileUri = value; }
        }

        // Check to see if VocabularyFilterFileUri property is set
        internal bool IsSetVocabularyFilterFileUri()
        {
            return this._vocabularyFilterFileUri != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The vocabulary filter name. The name must be unique within the account that contains
        /// it. If you try to create a vocabulary filter with the same name as another vocabulary
        /// filter, you get a <code>ConflictException</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Words. 
        /// <para>
        /// The words to use in the vocabulary filter. Only use characters from the character
        /// set defined for custom vocabularies. For a list of character sets, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-vocabulary.html#charsets">Character
        /// Sets for Custom Vocabularies</a>.
        /// </para>
        ///  
        /// <para>
        /// If you provide a list of words in the <code>Words</code> parameter, you can't use
        /// the <code>VocabularyFilterFileUri</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Words
        {
            get { return this._words; }
            set { this._words = value; }
        }

        // Check to see if Words property is set
        internal bool IsSetWords()
        {
            return this._words != null && this._words.Count > 0; 
        }

    }
}