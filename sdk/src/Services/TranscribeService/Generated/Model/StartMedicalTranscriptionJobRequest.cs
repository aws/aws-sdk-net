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
    /// Container for the parameters to the StartMedicalTranscriptionJob operation.
    /// Starts a batch job to transcribe medical speech to text.
    /// </summary>
    public partial class StartMedicalTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private string _medicalTranscriptionJobName;
        private string _outputBucketName;
        private string _outputEncryptionKMSKeyId;
        private string _outputKey;
        private MedicalTranscriptionSetting _settings;
        private Specialty _specialty;
        private Type _type;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for the language spoken in the input media file. US English (en-US)
        /// is the valid value for medical transcription jobs. Any other value you enter for language
        /// code results in a <code>BadRequestException</code> error.
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
        /// Gets and sets the property MediaFormat. 
        /// <para>
        /// The audio format of the input media file.
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
        /// If you do not specify the media sample rate, Amazon Transcribe Medical determines
        /// the sample rate. If you specify the sample rate, it must match the rate detected by
        /// Amazon Transcribe Medical. In most cases, you should leave the <code>MediaSampleRateHertz</code>
        /// field blank and let Amazon Transcribe Medical determine the sample rate.
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
        /// Gets and sets the property MedicalTranscriptionJobName. 
        /// <para>
        /// The name of the medical transcription job. You can't use the strings "<code>.</code>"
        /// or "<code>..</code>" by themselves as the job name. The name must also be unique within
        /// an AWS account. If you try to create a medical transcription job with the same name
        /// as a previous medical transcription job, you get a <code>ConflictException</code>
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string MedicalTranscriptionJobName
        {
            get { return this._medicalTranscriptionJobName; }
            set { this._medicalTranscriptionJobName = value; }
        }

        // Check to see if MedicalTranscriptionJobName property is set
        internal bool IsSetMedicalTranscriptionJobName()
        {
            return this._medicalTranscriptionJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputBucketName. 
        /// <para>
        /// The Amazon S3 location where the transcription is stored.
        /// </para>
        ///  
        /// <para>
        /// You must set <code>OutputBucketName</code> for Amazon Transcribe Medical to store
        /// the transcription results. Your transcript appears in the S3 location you specify.
        /// When you call the <a>GetMedicalTranscriptionJob</a>, the operation returns this location
        /// in the <code>TranscriptFileUri</code> field. The S3 bucket must have permissions that
        /// allow Amazon Transcribe Medical to put files in the bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/security_iam_id-based-policy-examples.html#auth-role-iam-user">Permissions
        /// Required for IAM User Roles</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify an AWS Key Management Service (KMS) key to encrypt the output of your
        /// transcription using the <code>OutputEncryptionKMSKeyId</code> parameter. If you don't
        /// specify a KMS key, Amazon Transcribe Medical uses the default Amazon S3 key for server-side
        /// encryption of transcripts that are placed in your S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        /// encrypt the output of the transcription job. The user calling the <a>StartMedicalTranscriptionJob</a>
        /// operation must have permission to use the specified KMS key.
        /// </para>
        ///  
        /// <para>
        /// You use either of the following to identify a KMS key in the current account:
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
        /// Amazon Resource Name (ARN) of a KMS key in the current account or another account:
        /// "arn:aws:kms:region:account ID:key/1234abcd-12ab-34cd-56ef-1234567890ab"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN of a KMS Key Alias: "arn:aws:kms:region:account ID:alias/ExampleAlias"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify an encryption key, the output of the medical transcription job
        /// is encrypted with the default Amazon S3 key (SSE-S3).
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
        /// You can specify a location in an Amazon S3 bucket to store the output of your medical
        /// transcription job.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an output key, Amazon Transcribe Medical stores the output of
        /// your transcription job in the Amazon S3 bucket you specified. By default, the object
        /// key is "your-transcription-job-name.json".
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
        /// Optional settings for the medical transcription job.
        /// </para>
        /// </summary>
        public MedicalTranscriptionSetting Settings
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
        /// Gets and sets the property Specialty. 
        /// <para>
        /// The medical specialty of any clinician speaking in the input media.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Specialty Specialty
        {
            get { return this._specialty; }
            set { this._specialty = value; }
        }

        // Check to see if Specialty property is set
        internal bool IsSetSpecialty()
        {
            return this._specialty != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of speech in the input audio. <code>CONVERSATION</code> refers to conversations
        /// between two or more speakers, e.g., a conversations between doctors and patients.
        /// <code>DICTATION</code> refers to single-speaker dictated speech, e.g., for clinical
        /// notes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}