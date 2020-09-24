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
    /// Container for the parameters to the StartTranscriptionJob operation.
    /// Starts an asynchronous job to transcribe speech to text.
    /// </summary>
    public partial class StartTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private ContentRedaction _contentRedaction;
        private bool? _identifyLanguage;
        private JobExecutionSettings _jobExecutionSettings;
        private LanguageCode _languageCode;
        private List<string> _languageOptions = new List<string>();
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private ModelSettings _modelSettings;
        private string _outputBucketName;
        private string _outputEncryptionKMSKeyId;
        private string _outputKey;
        private Settings _settings;
        private string _transcriptionJobName;

        /// <summary>
        /// Gets and sets the property ContentRedaction. 
        /// <para>
        /// An object that contains the request parameters for content redaction.
        /// </para>
        /// </summary>
        public ContentRedaction ContentRedaction
        {
            get { return this._contentRedaction; }
            set { this._contentRedaction = value; }
        }

        // Check to see if ContentRedaction property is set
        internal bool IsSetContentRedaction()
        {
            return this._contentRedaction != null;
        }

        /// <summary>
        /// Gets and sets the property IdentifyLanguage. 
        /// <para>
        /// Set this field to <code>true</code> to enable automatic language identification. Automatic
        /// language identification is disabled by default. You receive a <code>BadRequestException</code>
        /// error if you enter a value for a <code>LanguageCode</code>.
        /// </para>
        /// </summary>
        public bool IdentifyLanguage
        {
            get { return this._identifyLanguage.GetValueOrDefault(); }
            set { this._identifyLanguage = value; }
        }

        // Check to see if IdentifyLanguage property is set
        internal bool IsSetIdentifyLanguage()
        {
            return this._identifyLanguage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobExecutionSettings. 
        /// <para>
        /// Provides information about how a transcription job is executed. Use this field to
        /// indicate that the job can be queued for deferred execution if the concurrency limit
        /// is reached and there are no slots available to immediately run the job.
        /// </para>
        /// </summary>
        public JobExecutionSettings JobExecutionSettings
        {
            get { return this._jobExecutionSettings; }
            set { this._jobExecutionSettings = value; }
        }

        // Check to see if JobExecutionSettings property is set
        internal bool IsSetJobExecutionSettings()
        {
            return this._jobExecutionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for the language used in the input media file.
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
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// An object containing a list of languages that might be present in your collection
        /// of audio files. Automatic language identification chooses a language that best matches
        /// the source audio from that list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public List<string> LanguageOptions
        {
            get { return this._languageOptions; }
            set { this._languageOptions = value; }
        }

        // Check to see if LanguageOptions property is set
        internal bool IsSetLanguageOptions()
        {
            return this._languageOptions != null && this._languageOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// An object that describes the input media for a transcription job.
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
        /// Gets and sets the property MediaFormat. 
        /// <para>
        /// The format of the input media file.
        /// </para>
        /// </summary>
        public MediaFormat MediaFormat
        {
            get { return this._mediaFormat; }
            set { this._mediaFormat = value; }
        }

        // Check to see if MediaFormat property is set
        internal bool IsSetMediaFormat()
        {
            return this._mediaFormat != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate, in Hertz, of the audio track in the input media file. 
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the media sample rate, Amazon Transcribe determines the sample
        /// rate. If you specify the sample rate, it must match the sample rate detected by Amazon
        /// Transcribe. In most cases, you should leave the <code>MediaSampleRateHertz</code>
        /// field blank and let Amazon Transcribe determine the sample rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8000, Max=48000)]
        public int MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz.GetValueOrDefault(); }
            set { this._mediaSampleRateHertz = value; }
        }

        // Check to see if MediaSampleRateHertz property is set
        internal bool IsSetMediaSampleRateHertz()
        {
            return this._mediaSampleRateHertz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelSettings. 
        /// <para>
        /// Choose the custom language model you use for your transcription job in this parameter.
        /// </para>
        /// </summary>
        public ModelSettings ModelSettings
        {
            get { return this._modelSettings; }
            set { this._modelSettings = value; }
        }

        // Check to see if ModelSettings property is set
        internal bool IsSetModelSettings()
        {
            return this._modelSettings != null;
        }

        /// <summary>
        /// Gets and sets the property OutputBucketName. 
        /// <para>
        /// The location where the transcription is stored.
        /// </para>
        ///  
        /// <para>
        /// If you set the <code>OutputBucketName</code>, Amazon Transcribe puts the transcript
        /// in the specified S3 bucket. When you call the <a>GetTranscriptionJob</a> operation,
        /// the operation returns this location in the <code>TranscriptFileUri</code> field. If
        /// you enable content redaction, the redacted transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// If you enable content redaction and choose to output an unredacted transcript, that
        /// transcript's location still appears in the <code>TranscriptFileUri</code>. The S3
        /// bucket must have permissions that allow Amazon Transcribe to put files in the bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/security_iam_id-based-policy-examples.html#auth-role-iam-user">Permissions
        /// Required for IAM User Roles</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify an AWS Key Management Service (KMS) key to encrypt the output of your
        /// transcription using the <code>OutputEncryptionKMSKeyId</code> parameter. If you don't
        /// specify a KMS key, Amazon Transcribe uses the default Amazon S3 key for server-side
        /// encryption of transcripts that are placed in your S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// If you don't set the <code>OutputBucketName</code>, Amazon Transcribe generates a
        /// pre-signed URL, a shareable URL that provides secure access to your transcription,
        /// and returns it in the <code>TranscriptFileUri</code> field. Use this URL to download
        /// the transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string OutputBucketName
        {
            get { return this._outputBucketName; }
            set { this._outputBucketName = value; }
        }

        // Check to see if OutputBucketName property is set
        internal bool IsSetOutputBucketName()
        {
            return this._outputBucketName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputEncryptionKMSKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Key Management Service (KMS) key used to
        /// encrypt the output of the transcription job. The user calling the <code>StartTranscriptionJob</code>
        /// operation must have permission to use the specified KMS key.
        /// </para>
        ///  
        /// <para>
        /// You can use either of the following to identify a KMS key in the current account:
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
        /// You can use either of the following to identify a KMS key in the current account or
        /// another account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: "arn:aws:kms:region:account ID:key/1234abcd-12ab-34cd-56ef-1234567890ab"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN of a KMS Key Alias: "arn:aws:kms:region:account ID:alias/ExampleAlias"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify an encryption key, the output of the transcription job is encrypted
        /// with the default Amazon S3 key (SSE-S3). 
        /// </para>
        ///  
        /// <para>
        /// If you specify a KMS key to encrypt your output, you must also specify an output location
        /// in the <code>OutputBucketName</code> parameter.
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
        /// Gets and sets the property OutputKey. 
        /// <para>
        /// You can specify a location in an Amazon S3 bucket to store the output of your transcription
        /// job.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an output key, Amazon Transcribe stores the output of your transcription
        /// job in the Amazon S3 bucket you specified. By default, the object key is "your-transcription-job-name.json".
        /// </para>
        ///  
        /// <para>
        /// You can use output keys to specify the Amazon S3 prefix and file name of the transcription
        /// output. For example, specifying the Amazon S3 prefix, "folder1/folder2/", as an output
        /// key would lead to the output being stored as "folder1/folder2/your-transcription-job-name.json".
        /// If you specify "my-other-job-name.json" as the output key, the object key is changed
        /// to "my-other-job-name.json". You can use an output key to change both the prefix and
        /// the file name, for example "folder/my-other-job-name.json".
        /// </para>
        ///  
        /// <para>
        /// If you specify an output key, you must also specify an S3 bucket in the <code>OutputBucketName</code>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OutputKey
        {
            get { return this._outputKey; }
            set { this._outputKey = value; }
        }

        // Check to see if OutputKey property is set
        internal bool IsSetOutputKey()
        {
            return this._outputKey != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// A <code>Settings</code> object that provides optional settings for a transcription
        /// job.
        /// </para>
        /// </summary>
        public Settings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptionJobName. 
        /// <para>
        /// The name of the job. You can't use the strings "<code>.</code>" or "<code>..</code>"
        /// by themselves as the job name. The name must also be unique within an AWS account.
        /// If you try to create a transcription job with the same name as a previous transcription
        /// job, you get a <code>ConflictException</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string TranscriptionJobName
        {
            get { return this._transcriptionJobName; }
            set { this._transcriptionJobName = value; }
        }

        // Check to see if TranscriptionJobName property is set
        internal bool IsSetTranscriptionJobName()
        {
            return this._transcriptionJobName != null;
        }

    }
}