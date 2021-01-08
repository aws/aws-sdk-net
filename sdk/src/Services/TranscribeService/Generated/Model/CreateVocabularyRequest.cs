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
    /// Container for the parameters to the CreateVocabulary operation.
    /// Creates a new custom vocabulary that you can use to change the way Amazon Transcribe
    /// handles transcription of an audio file.
    /// </summary>
    public partial class CreateVocabularyRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private List<string> _phrases = new List<string>();
        private string _vocabularyFileUri;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code of the vocabulary entries.
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
        /// Gets and sets the property Phrases. 
        /// <para>
        /// An array of strings that contains the vocabulary entries. 
        /// </para>
        /// </summary>
        public List<string> Phrases
        {
            get { return this._phrases; }
            set { this._phrases = value; }
        }

        // Check to see if Phrases property is set
        internal bool IsSetPhrases()
        {
            return this._phrases != null && this._phrases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyFileUri. 
        /// <para>
        /// The S3 location of the text file that contains the definition of the custom vocabulary.
        /// The URI must be in the same region as the API endpoint that you are calling. The general
        /// form is 
        /// </para>
        ///  
        /// <para>
        /// For more information about S3 object names, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html#object-keys">Object
        /// Keys</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about custom vocabularies, see <a href="http://docs.aws.amazon.com/transcribe/latest/dg/how-it-works.html#how-vocabulary">Custom
        /// Vocabularies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// The name of the vocabulary. The name must be unique within an AWS account. The name
        /// is case sensitive. If you try to create a vocabulary with the same name as a previous
        /// vocabulary you will receive a <code>ConflictException</code> error.
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