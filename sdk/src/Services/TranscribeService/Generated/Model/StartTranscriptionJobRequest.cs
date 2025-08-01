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
    /// Container for the parameters to the StartTranscriptionJob operation.
    /// Transcribes the audio from a media file and applies any additional Request Parameters
    /// you choose to include in your request.
    /// 
    ///  
    /// <para>
    /// To make a <c>StartTranscriptionJob</c> request, you must first upload your media file
    /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
    /// using the <c>Media</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// You must include the following parameters in your <c>StartTranscriptionJob</c> request:
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
    ///  <c>TranscriptionJobName</c>: A custom name you create for your transcription job
    /// that is unique within your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// One of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or <c>IdentifyMultipleLanguages</c>:
    /// If you know the language of your media file, specify it using the <c>LanguageCode</c>
    /// parameter; you can find all valid language codes in the <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
    /// languages</a> table. If you do not know the languages spoken in your media, use either
    /// <c>IdentifyLanguage</c> or <c>IdentifyMultipleLanguages</c> and let Amazon Transcribe
    /// identify the languages for you.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private ContentRedaction _contentRedaction;
        private bool? _identifyLanguage;
        private bool? _identifyMultipleLanguages;
        private JobExecutionSettings _jobExecutionSettings;
        private Dictionary<string, string> _kmsEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private LanguageCode _languageCode;
        private Dictionary<string, LanguageIdSettings> _languageIdSettings = AWSConfigs.InitializeCollections ? new Dictionary<string, LanguageIdSettings>() : null;
        private List<string> _languageOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private ModelSettings _modelSettings;
        private string _outputBucketName;
        private string _outputEncryptionKMSKeyId;
        private string _outputKey;
        private Settings _settings;
        private Subtitles _subtitles;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<ToxicityDetectionSettings> _toxicityDetection = AWSConfigs.InitializeCollections ? new List<ToxicityDetectionSettings>() : null;
        private string _transcriptionJobName;

        /// <summary>
        /// Gets and sets the property ContentRedaction. 
        /// <para>
        /// Makes it possible to redact or flag specified personally identifiable information
        /// (PII) in your transcript. If you use <c>ContentRedaction</c>, you must also include
        /// the sub-parameters: <c>RedactionOutput</c> and <c>RedactionType</c>. You can optionally
        /// include <c>PiiEntityTypes</c> to choose which types of PII you want to redact. If
        /// you do not include <c>PiiEntityTypes</c> in your request, all PII is redacted.
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
        /// Enables automatic language identification in your transcription job request. Use this
        /// parameter if your media file contains only one language. If your media contains multiple
        /// languages, use <c>IdentifyMultipleLanguages</c> instead.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>IdentifyLanguage</c>, you can optionally include a list of language
        /// codes, using <c>LanguageOptions</c>, that you think may be present in your media file.
        /// Including <c>LanguageOptions</c> restricts <c>IdentifyLanguage</c> to only the language
        /// options that you specify, which can improve transcription accuracy.
        /// </para>
        ///  
        /// <para>
        /// If you want to apply a custom language model, a custom vocabulary, or a custom vocabulary
        /// filter to your automatic language identification request, include <c>LanguageIdSettings</c>
        /// with the relevant sub-parameters (<c>VocabularyName</c>, <c>LanguageModelName</c>,
        /// and <c>VocabularyFilterName</c>). If you include <c>LanguageIdSettings</c>, also include
        /// <c>LanguageOptions</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include one of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or
        /// <c>IdentifyMultipleLanguages</c> in your request. If you include more than one of
        /// these parameters, your transcription job fails.
        /// </para>
        /// </summary>
        public bool? IdentifyLanguage
        {
            get { return this._identifyLanguage; }
            set { this._identifyLanguage = value; }
        }

        // Check to see if IdentifyLanguage property is set
        internal bool IsSetIdentifyLanguage()
        {
            return this._identifyLanguage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Enables automatic multi-language identification in your transcription job request.
        /// Use this parameter if your media file contains more than one language. If your media
        /// contains only one language, use <c>IdentifyLanguage</c> instead.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>IdentifyMultipleLanguages</c>, you can optionally include a list
        /// of language codes, using <c>LanguageOptions</c>, that you think may be present in
        /// your media file. Including <c>LanguageOptions</c> restricts <c>IdentifyLanguage</c>
        /// to only the language options that you specify, which can improve transcription accuracy.
        /// </para>
        ///  
        /// <para>
        /// If you want to apply a custom vocabulary or a custom vocabulary filter to your automatic
        /// language identification request, include <c>LanguageIdSettings</c> with the relevant
        /// sub-parameters (<c>VocabularyName</c> and <c>VocabularyFilterName</c>). If you include
        /// <c>LanguageIdSettings</c>, also include <c>LanguageOptions</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include one of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or
        /// <c>IdentifyMultipleLanguages</c> in your request. If you include more than one of
        /// these parameters, your transcription job fails.
        /// </para>
        /// </summary>
        public bool? IdentifyMultipleLanguages
        {
            get { return this._identifyMultipleLanguages; }
            set { this._identifyMultipleLanguages = value; }
        }

        // Check to see if IdentifyMultipleLanguages property is set
        internal bool IsSetIdentifyMultipleLanguages()
        {
            return this._identifyMultipleLanguages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobExecutionSettings. 
        /// <para>
        /// Makes it possible to control how your transcription job is processed. Currently, the
        /// only <c>JobExecutionSettings</c> modification you can choose is enabling job queueing
        /// using the <c>AllowDeferredExecution</c> sub-parameter.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>JobExecutionSettings</c> in your request, you must also include
        /// the sub-parameters: <c>AllowDeferredExecution</c> and <c>DataAccessRoleArn</c>.
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
        /// The language code that represents the language spoken in the input media file.
        /// </para>
        ///  
        /// <para>
        /// If you're unsure of the language spoken in your media file, consider using <c>IdentifyLanguage</c>
        /// or <c>IdentifyMultipleLanguages</c> to enable automatic language identification.
        /// </para>
        ///  
        /// <para>
        /// Note that you must include one of <c>LanguageCode</c>, <c>IdentifyLanguage</c>, or
        /// <c>IdentifyMultipleLanguages</c> in your request. If you include more than one of
        /// these parameters, your transcription job fails.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table.
        /// </para>
        ///  <note> 
        /// <para>
        /// To transcribe speech in Modern Standard Arabic (<c>ar-SA</c>) in Amazon Web Services
        /// GovCloud (US) (US-West, us-gov-west-1), Amazon Web Services GovCloud (US) (US-East,
        /// us-gov-east-1), Canada (Calgary, ca-west-1) and Africa (Cape Town, af-south-1), your
        /// media file must be encoded at a sample rate of 16,000 Hz or higher.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property LanguageIdSettings. 
        /// <para>
        /// If using automatic language identification in your request and you want to apply a
        /// custom language model, a custom vocabulary, or a custom vocabulary filter, include
        /// <c>LanguageIdSettings</c> with the relevant sub-parameters (<c>VocabularyName</c>,
        /// <c>LanguageModelName</c>, and <c>VocabularyFilterName</c>). Note that multi-language
        /// identification (<c>IdentifyMultipleLanguages</c>) doesn't support custom language
        /// models.
        /// </para>
        ///  
        /// <para>
        ///  <c>LanguageIdSettings</c> supports two to five language codes. Each language code
        /// you include can have an associated custom language model, custom vocabulary, and custom
        /// vocabulary filter. The language codes that you specify must match the languages of
        /// the associated custom language models, custom vocabularies, and custom vocabulary
        /// filters.
        /// </para>
        ///  
        /// <para>
        /// It's recommended that you include <c>LanguageOptions</c> when using <c>LanguageIdSettings</c>
        /// to ensure that the correct language dialect is identified. For example, if you specify
        /// a custom vocabulary that is in <c>en-US</c> but Amazon Transcribe determines that
        /// the language spoken in your media is <c>en-AU</c>, your custom vocabulary <i>is not</i>
        /// applied to your transcription. If you include <c>LanguageOptions</c> and include <c>en-US</c>
        /// as the only English language dialect, your custom vocabulary <i>is</i> applied to
        /// your transcription.
        /// </para>
        ///  
        /// <para>
        /// If you want to include a custom language model with your request but <b>do not</b>
        /// want to use automatic language identification, use instead the <code/> parameter with
        /// the <c>LanguageModelName</c> sub-parameter. If you want to include a custom vocabulary
        /// or a custom vocabulary filter (or both) with your request but <b>do not</b> want to
        /// use automatic language identification, use instead the <code/> parameter with the
        /// <c>VocabularyName</c> or <c>VocabularyFilterName</c> (or both) sub-parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, LanguageIdSettings> LanguageIdSettings
        {
            get { return this._languageIdSettings; }
            set { this._languageIdSettings = value; }
        }

        // Check to see if LanguageIdSettings property is set
        internal bool IsSetLanguageIdSettings()
        {
            return this._languageIdSettings != null && (this._languageIdSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LanguageOptions. 
        /// <para>
        /// You can specify two or more language codes that represent the languages you think
        /// may be present in your media. Including more than five is not recommended. If you're
        /// unsure what languages are present, do not include this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you include <c>LanguageOptions</c> in your request, you must also include <c>IdentifyLanguage</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a>.
        /// </para>
        ///  
        /// <para>
        /// To transcribe speech in Modern Standard Arabic (<c>ar-SA</c>)in Amazon Web Services
        /// GovCloud (US) (US-West, us-gov-west-1), Amazon Web Services GovCloud (US) (US-East,
        /// us-gov-east-1), in Canada (Calgary) ca-west-1 and Africa (Cape Town) af-south-1, your
        /// media file must be encoded at a sample rate of 16,000 Hz or higher.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> LanguageOptions
        {
            get { return this._languageOptions; }
            set { this._languageOptions = value; }
        }

        // Check to see if LanguageOptions property is set
        internal bool IsSetLanguageOptions()
        {
            return this._languageOptions != null && (this._languageOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// Describes the Amazon S3 location of the media file you want to use in your request.
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
        /// If you do not specify the media sample rate, Amazon Transcribe determines it for you.
        /// If you specify the sample rate, it must match the rate detected by Amazon Transcribe.
        /// If there's a mismatch between the value that you specify and the value detected, your
        /// job fails. In most cases, you can omit <c>MediaSampleRateHertz</c> and let Amazon
        /// Transcribe determine the sample rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8000, Max=48000)]
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
        /// Gets and sets the property ModelSettings. 
        /// <para>
        /// Specify the custom language model you want to include with your transcription job.
        /// If you include <c>ModelSettings</c> in your request, you must include the <c>LanguageModelName</c>
        /// sub-parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/custom-language-models.html">Custom
        /// language models</a>.
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
        /// The name of the Amazon S3 bucket where you want your transcription output stored.
        /// Do not include the <c>S3://</c> prefix of the specified bucket.
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
        ///  
        /// <para>
        /// If you do not specify <c>OutputBucketName</c>, your transcript is placed in a service-managed
        /// Amazon S3 bucket and you are provided with a URI to access your transcript.
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
        /// The KMS key you want to use to encrypt your transcription output.
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
        /// for your transcription output is the same as the name you specified for your transcription
        /// job (<c>TranscriptionJobName</c>).
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
        /// If you specify 'my-first-transcription' as the <c>TranscriptionJobName</c>, 'DOC-EXAMPLE-BUCKET'
        /// as the <c>OutputBucketName</c>, and 'my-transcript' as the <c>OutputKey</c>, your
        /// transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/my-transcript/my-first-transcription.json</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify 'DOC-EXAMPLE-BUCKET' as the <c>OutputBucketName</c> and 'test-files/my-transcript.json'
        /// as the <c>OutputKey</c>, your transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/test-files/my-transcript.json</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify 'my-first-transcription' as the <c>TranscriptionJobName</c>, 'DOC-EXAMPLE-BUCKET'
        /// as the <c>OutputBucketName</c>, and 'test-files/my-transcript' as the <c>OutputKey</c>,
        /// your transcription output path is <c>s3://DOC-EXAMPLE-BUCKET/test-files/my-transcript/my-first-transcription.json</c>.
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
        /// alternative transcriptions, speaker partitioning. You can use that to apply custom
        /// vocabularies and vocabulary filters.
        /// </para>
        ///  
        /// <para>
        /// If you want to include a custom vocabulary or a custom vocabulary filter (or both)
        /// with your request but <b>do not</b> want to use automatic language identification,
        /// use <c>Settings</c> with the <c>VocabularyName</c> or <c>VocabularyFilterName</c>
        /// (or both) sub-parameter.
        /// </para>
        ///  
        /// <para>
        /// If you're using automatic language identification with your request and want to include
        /// a custom language model, a custom vocabulary, or a custom vocabulary filter, use instead
        /// the <code/> parameter with the <c>LanguageModelName</c>, <c>VocabularyName</c> or
        /// <c>VocabularyFilterName</c> sub-parameters.
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
        /// Gets and sets the property Subtitles. 
        /// <para>
        /// Produces subtitle files for your input media. You can specify WebVTT (*.vtt) and SubRip
        /// (*.srt) formats.
        /// </para>
        /// </summary>
        public Subtitles Subtitles
        {
            get { return this._subtitles; }
            set { this._subtitles = value; }
        }

        // Check to see if Subtitles property is set
        internal bool IsSetSubtitles()
        {
            return this._subtitles != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more custom tags, each in the form of a key:value pair, to a new transcription
        /// job at the time you start this new job.
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
        /// Gets and sets the property ToxicityDetection. 
        /// <para>
        /// Enables toxic speech detection in your transcript. If you include <c>ToxicityDetection</c>
        /// in your request, you must also include <c>ToxicityCategories</c>.
        /// </para>
        ///  
        /// <para>
        /// For information on the types of toxic speech Amazon Transcribe can detect, see <a
        /// href="https://docs.aws.amazon.com/transcribe/latest/dg/toxic-language.html">Detecting
        /// toxic speech</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ToxicityDetectionSettings> ToxicityDetection
        {
            get { return this._toxicityDetection; }
            set { this._toxicityDetection = value; }
        }

        // Check to see if ToxicityDetection property is set
        internal bool IsSetToxicityDetection()
        {
            return this._toxicityDetection != null && (this._toxicityDetection.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TranscriptionJobName. 
        /// <para>
        /// A unique name, chosen by you, for your transcription job. The name that you specify
        /// is also used as the default name of your transcription output file. If you want to
        /// specify a different name for your transcription output, use the <c>OutputKey</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new job with the same name as an existing
        /// job, you get a <c>ConflictException</c> error.
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