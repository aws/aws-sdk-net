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
    /// This is the response object from the GetMedicalVocabulary operation.
    /// </summary>
    public partial class GetMedicalVocabularyResponse : AmazonWebServiceResponse
    {
        private string _downloadUri;
        private string _failureReason;
        private LanguageCode _languageCode;
        private DateTime? _lastModifiedTime;
        private string _vocabularyName;
        private VocabularyState _vocabularyState;

        /// <summary>
        /// Gets and sets the property DownloadUri. 
        /// <para>
        /// The location in Amazon S3 where the vocabulary is stored. Use this URI to get the
        /// contents of the vocabulary. You can download your vocabulary from the URI for a limited
        /// time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string DownloadUri
        {
            get { return this._downloadUri; }
            set { this._downloadUri = value; }
        }

        // Check to see if DownloadUri property is set
        internal bool IsSetDownloadUri()
        {
            return this._downloadUri != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the <code>VocabularyState</code> is <code>FAILED</code>, this field contains information
        /// about why the job failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The valid language code for your vocabulary entries.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the vocabulary was last modified with a text file different
        /// from the one that was previously used.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the vocabulary returned by Amazon Transcribe Medical.
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

        /// <summary>
        /// Gets and sets the property VocabularyState. 
        /// <para>
        /// The processing state of the vocabulary. If the <code>VocabularyState</code> is <code>READY</code>
        /// then you can use it in the <code>StartMedicalTranscriptionJob</code> operation. 
        /// </para>
        /// </summary>
        public VocabularyState VocabularyState
        {
            get { return this._vocabularyState; }
            set { this._vocabularyState = value; }
        }

        // Check to see if VocabularyState property is set
        internal bool IsSetVocabularyState()
        {
            return this._vocabularyState != null;
        }

    }
}