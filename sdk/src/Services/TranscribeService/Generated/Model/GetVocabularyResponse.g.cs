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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the GetVocabulary operation.
    /// </summary>
    public partial class GetVocabularyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to access the Amazon S3 bucket
        /// that contains your input files and, if applicable, the KMS key specified in <c>EncryptionConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DownloadUri. 
        /// <para>
        /// The Amazon S3 location where the custom vocabulary is stored; use this URI to view
        /// or download the custom vocabulary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string DownloadUri { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUri property is set.
        /// </summary>
        internal bool IsSetDownloadUri() => this.DownloadUri != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration used for your custom vocabulary.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>VocabularyState</c> is <c>FAILED</c>, <c>FailureReason</c> contains information
        /// about why the custom vocabulary request failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code you selected for your custom vocabulary.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the specified custom vocabulary was last modified.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom vocabulary you requested information about.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;

        /// <summary>
        /// Gets and sets the property VocabularyState. 
        /// <para>
        /// The processing state of your custom vocabulary. If the state is <c>READY</c>, you
        /// can use the custom vocabulary in a <c>StartTranscriptionJob</c> request.
        /// </para>
        /// </summary>
        public VocabularyState VocabularyState { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyState property is set.
        /// </summary>
        internal bool IsSetVocabularyState() => this.VocabularyState != null;
    }
}
