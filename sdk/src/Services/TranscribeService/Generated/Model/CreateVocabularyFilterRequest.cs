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
    /// Container for the parameters to the CreateVocabularyFilter operation.
    /// Creates a new vocabulary filter that you can use to filter words from your transcription
    /// output. For example, you can use this operation to remove profanity from your transcript.
    /// </summary>
    public partial class CreateVocabularyFilterRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private List<Tag> _tags = new List<Tag>();
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more tags, each in the form of a key:value pair, to a new vocabulary filter
        /// at the time you create this new vocabulary filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterFileUri. 
        /// <para>
        /// The Amazon S3 location of a text file used as input to create the vocabulary filter.
        /// Only use characters from the character set defined for custom vocabularies. For a
        /// list of character sets, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a>.
        /// </para>
        ///  
        /// <para>
        /// Your vocabulary filter file must be less than 50 KB in size.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>VocabularyFilterFileUri</code> in your request, you
        /// cannot use <code>Words</code>; you must choose one or the other.
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
        /// The name of your new vocabulary filter.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a vocabulary filter with the same name
        /// as a previous vocabulary filter, you get a <code>ConflictException</code> error.
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
        /// The words you want in your vocabulary filter. Only use characters specified in the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// sets</a> for the language you're transcribing.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>Words</code> in your request, you cannot use <code>VocabularyFilterFileUri</code>;
        /// you must choose one or the other.
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