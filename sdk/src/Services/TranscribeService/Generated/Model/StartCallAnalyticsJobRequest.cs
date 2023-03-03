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
    /// Transcribes the audio from a customer service call and applies any additional Request
    /// Parameters you choose to include in your request.
    /// 
    ///  
    /// <para>
    /// In addition to many standard transcription features, Call Analytics provides you with
    /// call characteristics, call summarization, speaker sentiment, and optional redaction
    /// of your text transcript and your audio file. You can also apply custom categories
    /// to flag specified conditions. To learn more about these features and insights, refer
    /// to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/call-analytics.html">Analyzing
    /// call center audio with Call Analytics</a>.
    /// </para>
    ///  
    /// <para>
    /// If you want to apply categories to your Call Analytics job, you must create them before
    /// submitting your job request. Categories cannot be retroactively applied to a job.
    /// To create a new category, use the operation. To learn more about Call Analytics categories,
    /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-batch.html">Creating
    /// categories for post-call transcriptions</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-categories-stream.html">Creating
    /// categories for real-time transcriptions</a>.
    /// </para>
    ///  
    /// <para>
    /// To make a <code>StartCallAnalyticsJob</code> request, you must first upload your media
    /// file into an Amazon S3 bucket; you can then specify the Amazon S3 location of the
    /// file using the <code>Media</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// Note that job queuing is enabled by default for Call Analytics jobs.
    /// </para>
    ///  
    /// <para>
    /// You must include the following parameters in your <code>StartCallAnalyticsJob</code>
    /// request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>region</code>: The Amazon Web Services Region where you are making your request.
    /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
    /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
    /// Transcribe endpoints and quotas</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CallAnalyticsJobName</code>: A custom name that you create for your transcription
    /// job that's unique within your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DataAccessRoleArn</code>: The Amazon Resource Name (ARN) of an IAM role that
    /// has permissions to access the Amazon S3 bucket that contains your input files.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Media</code> (<code>MediaFileUri</code> or <code>RedactedMediaFileUri</code>):
    /// The Amazon S3 location of your media file.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// With Call Analytics, you can redact the audio contained in your media file by including
    /// <code>RedactedMediaFileUri</code>, instead of <code>MediaFileUri</code>, to specify
    /// the location of your input audio. If you choose to redact your audio, you can find
    /// your redacted media at the location specified in the <code>RedactedMediaFileUri</code>
    /// field of your response.
    /// </para>
    ///  </note>
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
        /// A unique name, chosen by you, for your Call Analytics job.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new job with the same name as an existing
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
        /// Makes it possible to specify which speaker is on which channel. For example, if your
        /// agent is the first participant to speak, you would set <code>ChannelId</code> to <code>0</code>
        /// (to indicate the first channel) and <code>ParticipantRole</code> to <code>AGENT</code>
        /// (to indicate that it's the agent speaking).
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
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files. If the role that you specify doesn’t have
        /// the appropriate permissions to access the specified Amazon S3 location, your request
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <code>arn:partition:iam::account:role/role-name-with-path</code>.
        /// For example: <code>arn:aws:iam::111122223333:role/Admin</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// <para>
        /// Describes the Amazon S3 location of the media file you want to use in your Call Analytics
        /// request.
        /// </para>
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
        /// The KMS key you want to use to encrypt your Call Analytics output.
        /// </para>
        ///  
        /// <para>
        /// If using a key located in the <b>current</b> Amazon Web Services account, you can
        /// specify your KMS key in one of four ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the KMS key ID itself. For example, <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an alias for the KMS key ID. For example, <code>alias/ExampleAlias</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the Amazon Resource Name (ARN) for the KMS key ID. For example, <code>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <code>arn:aws:kms:region:account-ID:alias/ExampleAlias</code>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If using a key located in a <b>different</b> Amazon Web Services account than the
        /// current Amazon Web Services account, you can specify your KMS key in one of two ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the ARN for the KMS key ID. For example, <code>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <code>arn:aws:kms:region:account-ID:alias/ExampleAlias</code>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you don't specify an encryption key, your output is encrypted with the default
        /// Amazon S3 key (SSE-S3).
        /// </para>
        ///  
        /// <para>
        /// If you specify a KMS key to encrypt your output, you must also specify an output location
        /// using the <code>OutputLocation</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// Note that the role making the request must have permission to use the specified KMS
        /// key.
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
        /// The Amazon S3 location where you want your Call Analytics transcription output stored.
        /// You can use any of the following formats to specify the output location:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET/my-output-folder/
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3://DOC-EXAMPLE-BUCKET/my-output-folder/my-call-analytics-job.json
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Unless you specify a file name (option 3), the name of your output file has a default
        /// value that matches the name you specified for your transcription job using the <code>CallAnalyticsJobName</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// You can specify a KMS key to encrypt your output using the <code>OutputEncryptionKMSKeyId</code>
        /// parameter. If you don't specify a KMS key, Amazon Transcribe uses the default Amazon
        /// S3 key for server-side encryption.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <code>OutputLocation</code>, your transcript is placed in a service-managed
        /// Amazon S3 bucket and you are provided with a URI to access your transcript.
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
        /// Specify additional optional settings in your request, including content redaction;
        /// allows you to apply custom language models, vocabulary filters, and custom vocabularies
        /// to your Call Analytics job.
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