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
    /// Container for the parameters to the UpdateMedicalVocabulary operation.
    /// Updates an existing custom medical vocabulary with new values. This operation overwrites
    /// all existing information with your new values; you cannot append new terms onto an
    /// existing custom vocabulary.
    /// </summary>
    public partial class UpdateMedicalVocabularyRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private string _vocabularyFileUri;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language of the entries in the custom vocabulary
        /// you want to update. US English (<code>en-US</code>) is the only language supported
        /// with Amazon Transcribe Medical.
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
        /// Gets and sets the property VocabularyFileUri. 
        /// <para>
        /// The Amazon S3 location of the text file that contains your custom medical vocabulary.
        /// The URI must be located in the same Amazon Web Services Region as the resource you're
        /// calling.
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
        /// The name of the custom medical vocabulary you want to update. Custom medical vocabulary
        /// names are case sensitive.
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