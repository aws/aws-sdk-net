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
    /// Container for the parameters to the StartCallAnalyticsJob operation.
    /// Starts an asynchronous analytics job that not only transcribes the audio recording
    /// of a caller and agent, but also returns additional insights. These insights include
    /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
    /// with your analytics jobs, create categories. A category is a way to classify analytics
    /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
    /// used during the call. For more information, see the operation.
    /// </summary>
    public partial class StartCallAnalyticsJobRequest : AmazonTranscribeServiceRequest
    {
        private string _callAnalyticsJobName;
        private List<ChannelDefinition> _channelDefinitions = new List<ChannelDefinition>();
        private string _dataAccessRoleArn;
        private Media _media;
        private string _outputEncryptionKMSKeyId;
        private string _outputLocation;
        private CallAnalyticsJobSettings _settings;

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobName. 
        /// <para>
        /// The name of the call analytics job. You can't use the string "." or ".." by themselves
        /// as the job name. The name must also be unique within an Amazon Web Services account.
        /// If you try to create a call analytics job with the same name as a previous call analytics
        /// job, you get a <code>ConflictException</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string CallAnalyticsJobName
        {
            get { return this._callAnalyticsJobName; }
            set { this._callAnalyticsJobName = value; }
        }

        // Check to see if CallAnalyticsJobName property is set
        internal bool IsSetCallAnalyticsJobName()
        {
            return this._callAnalyticsJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// When you start a call analytics job, you must pass an array that maps the agent and
        /// the customer to specific audio channels. The values you can assign to a channel are
        /// 0 and 1. The agent and the customer must each have their own channel. You can't assign
        /// more than one channel to an agent or customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<ChannelDefinition> ChannelDefinitions
        {
            get { return this._channelDefinitions; }
            set { this._channelDefinitions = value; }
        }

        // Check to see if ChannelDefinitions property is set
        internal bool IsSetChannelDefinitions()
        {
            return this._channelDefinitions != null && this._channelDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role that has access to the S3 bucket that contains
        /// your input files. Amazon Transcribe assumes this role to read queued audio files.
        /// If you have specified an output S3 bucket for your transcription results, this role
        /// should have access to the output bucket as well.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Media.
        /// </summary>
        [AWSProperty(Required=true)]
        public Media Media
        {
            get { return this._media; }
            set { this._media = value; }
        }

        // Check to see if Media property is set
        internal bool IsSetMedia()
        {
            return this._media != null;
        }

        /// <summary>
        /// Gets and sets the property OutputEncryptionKMSKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Key Management Service key
        /// used to encrypt the output of the call analytics job. The user calling the operation
        /// must have permission to use the specified KMS key.
        /// </para>
        ///  
        /// <para>
        /// You use either of the following to identify an Amazon Web Services KMS key in the
        /// current account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: "1234abcd-12ab-34cd-56ef-1234567890ab"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS Key Alias: "alias/ExampleAlias"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  You can use either of the following to identify a KMS key in the current account
        /// or another account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS key in the current account or another account:
        /// "arn:aws:kms:region:account ID:key/1234abcd-12ab-34cd-56ef1234567890ab"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN of a KMS Key Alias: "arn:aws:kms:region:account ID:alias/ExampleAlias"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify an encryption key, the output of the call analytics job is encrypted
        /// with the default Amazon S3 key (SSE-S3).
        /// </para>
        ///  
        /// <para>
        /// If you specify a KMS key to encrypt your output, you must also specify an output location
        /// in the <code>OutputLocation</code> parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string OutputEncryptionKMSKeyId
        {
            get { return this._outputEncryptionKMSKeyId; }
            set { this._outputEncryptionKMSKeyId = value; }
        }

        // Check to see if OutputEncryptionKMSKeyId property is set
        internal bool IsSetOutputEncryptionKMSKeyId()
        {
            return this._outputEncryptionKMSKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// The Amazon S3 location where the output of the call analytics job is stored. You can
        /// provide the following location types to store the output of call analytics job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET1
        /// </para>
        ///  
        /// <para>
        ///  If you specify a bucket, Amazon Transcribe saves the output of the analytics job
        /// as a JSON file at the root level of the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET1/folder/
        /// </para>
        ///  
        /// <para>
        /// f you specify a path, Amazon Transcribe saves the output of the analytics job as s3://DOC-EXAMPLE-BUCKET1/folder/your-transcription-job-name.json
        /// </para>
        ///  
        /// <para>
        /// If you specify a folder, you must provide a trailing slash.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET1/folder/filename.json
        /// </para>
        ///  
        /// <para>
        ///  If you provide a path that has the filename specified, Amazon Transcribe saves the
        /// output of the analytics job as s3://DOC-EXAMPLEBUCKET1/folder/filename.json
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify an Amazon Web Services Key Management Service (KMS) key to encrypt
        /// the output of our analytics job using the <code>OutputEncryptionKMSKeyId</code> parameter.
        /// If you don't specify a KMS key, Amazon Transcribe uses the default Amazon S3 key for
        /// server-side encryption of the analytics job output that is placed in your S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// A <code>Settings</code> object that provides optional settings for a call analytics
        /// job. 
        /// </para>
        /// </summary>
        public CallAnalyticsJobSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}