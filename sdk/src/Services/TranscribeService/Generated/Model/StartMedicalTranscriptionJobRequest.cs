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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the StartMedicalTranscriptionJob operation.
    /// Transcribes the audio from a medical dictation or conversation and applies any additional
    /// Request Parameters you choose to include in your request.
    /// 
    ///  
    /// <para>
    /// In addition to many standard transcription features, Amazon Transcribe Medical provides
    /// you with a robust medical vocabulary and, optionally, content identification, which
    /// adds flags to personal health information (PHI). To learn more about these features,
    /// refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/how-it-works-med.html">How
    /// Amazon Transcribe Medical works</a>.
    /// </para>
    ///  
    /// <para>
    /// To make a <c>StartMedicalTranscriptionJob</c> request, you must first upload your
    /// media file into an Amazon S3 bucket; you can then specify the Amazon S3 location of
    /// the file using the <c>Media</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// You must include the following parameters in your <c>StartMedicalTranscriptionJob</c>
    /// request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>region</c>: The Amazon Web Services Region where you are making your request.
    /// For a list of Amazon Web Services Regions supported with Amazon Transcribe, refer
    /// to <a href="https://docs.aws.amazon.com/general/latest/gr/transcribe.html">Amazon
    /// Transcribe endpoints and quotas</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MedicalTranscriptionJobName</c>: A custom name you create for your transcription
    /// job that is unique within your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LanguageCode</c>: This must be <c>en-US</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OutputBucketName</c>: The Amazon S3 bucket where you want your transcript stored.
    /// If you want your output stored in a sub-folder of this bucket, you must also include
    /// <c>OutputKey</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Specialty</c>: This must be <c>PRIMARYCARE</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Type</c>: Choose whether your audio is a conversation or a dictation.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartMedicalTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private MedicalContentIdentificationType _contentIdentificationType;
        private Dictionary<string, string> _kmsEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private Type _type;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Labels all personal health information (PHI) identified in your transcript. For more
        /// information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/phi-id.html">Identifying
        /// personal health information (PHI) in a transcription</a>.
        /// </para>
        /// </summary>
        public MedicalContentIdentificationType ContentIdentificationType
        {
            get { return this._contentIdentificationType; }
            set { this._contentIdentificationType = value; }
        }

        // Check to see if ContentIdentificationType property is set
        internal bool IsSetContentIdentificationType()
        {
            return this._contentIdentificationType != null;
        }

        /// <summary>
        /// Gets and sets the property KMSEncryptionContext. 
        /// <para>
        /// A map of plain text, non-secret key:value pairs, known as encryption context pairs,
        /// that provide an added layer of security for your data. For more information, see <a
        /// href="https://docs.aws.amazon.com/transcribe/latest/dg/key-management.html#kms-context">KMS
        /// encryption context</a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/symmetric-asymmetric.html">Asymmetric
        /// keys in KMS</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public Dictionary<string, string> KMSEncryptionContext
        {
            get { return this._kmsEncryptionContext; }
            set { this._kmsEncryptionContext = value; }
        }

        // Check to see if KMSEncryptionContext property is set
        internal bool IsSetKMSEncryptionContext()
        {
            return this._kmsEncryptionContext != null && (this._kmsEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code that represents the language spoken in the input media file. US
        /// English (<c>en-US</c>) is the only valid value for medical transcription jobs. Any
        /// other value you enter for language code results in a <c>BadRequestException</c> error.
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
        /// Specify the format of your input media file.
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
        /// The sample rate, in hertz, of the audio track in your input media file.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the media sample rate, Amazon Transcribe Medical determines
        /// it for you. If you specify the sample rate, it must match the rate detected by Amazon
        /// Transcribe Medical; if there's a mismatch between the value that you specify and the
        /// value detected, your job fails. Therefore, in most cases, it's advised to omit <c>MediaSampleRateHertz</c>
        /// and let Amazon Transcribe Medical determine the sample rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16000, Max=48000)]
        public int? MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz; }
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
        /// A unique name, chosen by you, for your medical transcription job. The name that you
        /// specify is also used as the default name of your transcription output file. If you
        /// want to specify a different name for your transcription output, use the <c>OutputKey</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new job with the same name as an existing
        /// job, you get a <c>ConflictException</c> error.
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
        /// The name of the Amazon S3 bucket where you want your medical transcription output
        /// stored. Do not include the <c>S3://</c> prefix of the specified bucket.
        /// </para>
        ///  
        /// <para>
        /// If you want your output to go to a sub-folder of this bucket, specify it using the
        /// <c>OutputKey</c> parameter; <c>OutputBucketName</c> only accepts the name of a bucket.
        /// </para>
        ///  
        /// <para>
        /// For example, if you want your output stored in <c>S3://DOC-EXAMPLE-BUCKET</c>, set
        /// <c>OutputBucketName</c> to <c>DOC-EXAMPLE-BUCKET</c>. However, if you want your output
        /// stored in <c>S3://DOC-EXAMPLE-BUCKET/test-files/</c>, set <c>OutputBucketName</c>
        /// to <c>DOC-EXAMPLE-BUCKET</c> and <c>OutputKey</c> to <c>test-files/</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that Amazon Transcribe must have permission to use the specified location. You
        /// can change Amazon S3 permissions using the <a href="https://console.aws.amazon.com/s3">Amazon
        /// Web Services Management Console</a>. See also <a href="https://docs.aws.amazon.com/transcribe/latest/dg/security_iam_id-based-policy-examples.html#auth-role-iam-user">Permissions
        /// Required for IAM User Roles</a>.
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
        /// The KMS key you want to use to encrypt your medical transcription output.
        /// </para>
        ///  
        /// <para>
        /// If using a key located in the <b>current</b> Amazon Web Services account, you can
        /// specify your KMS key in one of four ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the KMS key ID itself. For example, <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an alias for the KMS key ID. For example, <c>alias/ExampleAlias</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the Amazon Resource Name (ARN) for the KMS key ID. For example, <c>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <c>arn:aws:kms:region:account-ID:alias/ExampleAlias</c>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If using a key located in a <b>different</b> Amazon Web Services account than the
        /// current Amazon Web Services account, you can specify your KMS key in one of two ways:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the ARN for the KMS key ID. For example, <c>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <c>arn:aws:kms:region:account-ID:alias/ExampleAlias</c>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// If you do not specify an encryption key, your output is encrypted with the default
        /// Amazon S3 key (SSE-S3).
        /// </para>
        ///  
        /// <para>
        /// If you specify a KMS key to encrypt your output, you must also specify an output location
        /// using the <c>OutputLocation</c> parameter.
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
        /// Gets and sets the property OutputKey. 
        /// <para>
        /// Use in combination with <c>OutputBucketName</c> to specify the output location of
        /// your transcript and, optionally, a unique name for your output file. The default name
        /// for your transcription output is the same as the name you specified for your medical
        /// transcription job (<c>MedicalTranscriptionJobName</c>).
        /// </para>
        ///  
        /// <para>
        /// Here are some examples of how you can use <c>OutputKey</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify 'DOC-EXAMPLE-BUCKET' as the <c>OutputBucketName</c> and 'my-transcript.json'
        /// as the <c>OutputKey</c>, your transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/my-transcript.json</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify 'my-first-transcription' as the <c>MedicalTranscriptionJobName</c>,
        /// 'DOC-EXAMPLE-BUCKET' as the <c>OutputBucketName</c>, and 'my-transcript' as the <c>OutputKey</c>,
        /// your transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/my-transcript/my-first-transcription.json</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify 'DOC-EXAMPLE-BUCKET' as the <c>OutputBucketName</c> and 'test-files/my-transcript.json'
        /// as the <c>OutputKey</c>, your transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/test-files/my-transcript.json</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify 'my-first-transcription' as the <c>MedicalTranscriptionJobName</c>,
        /// 'DOC-EXAMPLE-BUCKET' as the <c>OutputBucketName</c>, and 'test-files/my-transcript'
        /// as the <c>OutputKey</c>, your transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/test-files/my-transcript/my-first-transcription.json</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify the name of an Amazon S3 bucket sub-folder that doesn't exist, one
        /// is created for you.
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
        /// Specify additional optional settings in your request, including channel identification,
        /// alternative transcriptions, and speaker partitioning. You can use that to apply custom
        /// vocabularies to your transcription job.
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
        /// Specify the predominant medical specialty represented in your media. For batch transcriptions,
        /// <c>PRIMARYCARE</c> is the only valid value. If you require additional specialties,
        /// refer to .
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more custom tags, each in the form of a key:value pair, to a new medical
        /// transcription job at the time you start this new job.
        /// </para>
        ///  
        /// <para>
        /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
        /// resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specify whether your input media contains only one person (<c>DICTATION</c>) or contains
        /// a conversation between two people (<c>CONVERSATION</c>).
        /// </para>
        ///  
        /// <para>
        /// For example, <c>DICTATION</c> could be used for a medical professional wanting to
        /// transcribe voice memos; <c>CONVERSATION</c> could be used for transcribing the doctor-patient
        /// dialogue during the patient's office visit.
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