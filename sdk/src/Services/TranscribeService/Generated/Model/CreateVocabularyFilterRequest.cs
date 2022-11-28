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
    /// Creates a new custom vocabulary filter.
    /// 
    ///  
    /// <para>
    /// You can use custom vocabulary filters to mask, delete, or flag specific words from
    /// your transcript. Custom vocabulary filters are commonly used to mask profanity in
    /// transcripts.
    /// </para>
    ///  
    /// <para>
    /// Each language has a character set that contains all allowed characters for that specific
    /// language. If you use unsupported characters, your custom vocabulary filter request
    /// fails. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
    /// Sets for Custom Vocabularies</a> to get the character set for your language.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/vocabulary-filtering.html">Vocabulary
    /// filtering</a>.
    /// </para>
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
        /// The language code that represents the language of the entries in your vocabulary filter.
        /// Each custom vocabulary filter must contain terms in only one language.
        /// </para>
        ///  
        /// <para>
        /// A custom vocabulary filter can only be used to transcribe files in the same language
        /// as the filter. For example, if you create a custom vocabulary filter using US English
        /// (<code>en-US</code>), you can only apply this filter to files that contain English
        /// audio.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
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
        /// Adds one or more custom tags, each in the form of a key:value pair, to a new custom
        /// vocabulary filter at the time you create this new vocabulary filter.
        /// </para>
        ///  
        /// <para>
        /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
        /// resources</a>.
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
        /// The Amazon S3 location of the text file that contains your custom vocabulary filter
        /// terms. The URI must be located in the same Amazon Web Services Region as the resource
        /// you're calling.
        /// </para>
        ///  
        /// <para>
        /// Here's an example URI path: <code>s3://DOC-EXAMPLE-BUCKET/my-vocab-filter-file.txt</code>
        /// 
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
        /// A unique name, chosen by you, for your new custom vocabulary filter.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new custom vocabulary filter with the
        /// same name as an existing custom vocabulary filter, you get a <code>ConflictException</code>
        /// error.
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
        /// Use this parameter if you want to create your custom vocabulary filter by including
        /// all desired terms, as comma-separated values, within your request. The other option
        /// for creating your vocabulary filter is to save your entries in a text file and upload
        /// them to an Amazon S3 bucket, then specify the location of your file using the <code>VocabularyFilterFileUri</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that if you include <code>Words</code> in your request, you cannot use <code>VocabularyFilterFileUri</code>;
        /// you must choose one or the other.
        /// </para>
        ///  
        /// <para>
        /// Each language has a character set that contains all allowed characters for that specific
        /// language. If you use unsupported characters, your custom vocabulary filter request
        /// fails. Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
        /// Sets for Custom Vocabularies</a> to get the character set for your language.
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