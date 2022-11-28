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
    /// Container for the parameters to the CreateMedicalVocabulary operation.
    /// Creates a new custom medical vocabulary.
    /// 
    ///  
    /// <para>
    /// Before creating a new custom medical vocabulary, you must first upload a text file
    /// that contains your new entries, phrases, and terms into an Amazon S3 bucket. Note
    /// that this differs from , where you can include a list of terms within your request
    /// using the <code>Phrases</code> flag; <code>CreateMedicalVocabulary</code> does not
    /// support the <code>Phrases</code> flag.
    /// </para>
    ///  
    /// <para>
    /// Each language has a character set that contains all allowed characters for that specific
    /// language. If you use unsupported characters, your custom vocabulary request fails.
    /// Refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/charsets.html">Character
    /// Sets for Custom Vocabularies</a> to get the character set for your language.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-vocabulary.html">Custom
    /// vocabularies</a>.
    /// </para>
    /// </summary>
    public partial class CreateMedicalVocabularyRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private List<Tag> _tags = new List<Tag>();
        private string _vocabularyFileUri;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language of the entries in your custom vocabulary.
        /// US English (<code>en-US</code>) is the only language supported with Amazon Transcribe
        /// Medical.
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
        /// medical vocabulary at the time you create this new custom vocabulary.
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
        /// Gets and sets the property VocabularyFileUri. 
        /// <para>
        /// The Amazon S3 location (URI) of the text file that contains your custom medical vocabulary.
        /// The URI must be in the same Amazon Web Services Region as the resource you're calling.
        /// </para>
        ///  
        /// <para>
        /// Here's an example URI path: <code>s3://DOC-EXAMPLE-BUCKET/my-vocab-file.txt</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string VocabularyFileUri
        {
            get { return this._vocabularyFileUri; }
            set { this._vocabularyFileUri = value; }
        }

        // Check to see if VocabularyFileUri property is set
        internal bool IsSetVocabularyFileUri()
        {
            return this._vocabularyFileUri != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// A unique name, chosen by you, for your new custom medical vocabulary.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new custom medical vocabulary with the
        /// same name as an existing custom medical vocabulary, you get a <code>ConflictException</code>
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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