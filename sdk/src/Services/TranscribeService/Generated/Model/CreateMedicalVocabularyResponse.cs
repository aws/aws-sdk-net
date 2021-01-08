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
    /// This is the response object from the CreateMedicalVocabulary operation.
    /// </summary>
    public partial class CreateMedicalVocabularyResponse : AmazonWebServiceResponse
    {
        private string _failureReason;
        private LanguageCode _languageCode;
        private DateTime? _lastModifiedTime;
        private string _vocabularyName;
        private VocabularyState _vocabularyState;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the <code>VocabularyState</code> field is <code>FAILED</code>, this field contains
        /// information about why the job failed.
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
        /// The language code for the entries in your custom vocabulary. US English (en-US) is
        /// the only valid language code for Amazon Transcribe Medical.
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
        /// The date and time that you created the vocabulary.
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
        /// The name of the vocabulary. The name must be unique within an AWS account and is case
        /// sensitive.
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
        /// The processing state of your custom vocabulary in Amazon Transcribe Medical. If the
        /// state is <code>READY</code>, you can use the vocabulary in a <code>StartMedicalTranscriptionJob</code>
        /// request.
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