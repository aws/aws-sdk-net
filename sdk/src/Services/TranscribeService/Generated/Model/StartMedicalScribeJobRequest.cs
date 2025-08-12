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
    /// Container for the parameters to the StartMedicalScribeJob operation.
    /// Transcribes patient-clinician conversations and generates clinical notes. 
    /// 
    ///  
    /// <para>
    /// Amazon Web Services HealthScribe automatically provides rich conversation transcripts,
    /// identifies speaker roles, classifies dialogues, extracts medical terms, and generates
    /// preliminary clinical notes. To learn more about these features, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe.html">Amazon
    /// Web Services HealthScribe</a>.
    /// </para>
    ///  
    /// <para>
    /// To make a <c>StartMedicalScribeJob</c> request, you must first upload your media file
    /// into an Amazon S3 bucket; you can then specify the Amazon S3 location of the file
    /// using the <c>Media</c> parameter.
    /// </para>
    ///  
    /// <para>
    /// You must include the following parameters in your <c>StartMedicalTranscriptionJob</c>
    /// request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DataAccessRoleArn</c>: The ARN of an IAM role with the these minimum permissions:
    /// read permission on input file Amazon S3 bucket specified in <c>Media</c>, write permission
    /// on the Amazon S3 bucket specified in <c>OutputBucketName</c>, and full permissions
    /// on the KMS key specified in <c>OutputEncryptionKMSKeyId</c> (if set). The role should
    /// also allow <c>transcribe.amazonaws.com</c> to assume it. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Media</c> (<c>MediaFileUri</c>): The Amazon S3 location of your media file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MedicalScribeJobName</c>: A custom name you create for your MedicalScribe job
    /// that is unique within your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>OutputBucketName</c>: The Amazon S3 bucket where you want your output files stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Settings</c>: A <c>MedicalScribeSettings</c> object that must set exactly one
    /// of <c>ShowSpeakerLabels</c> or <c>ChannelIdentification</c> to true. If <c>ShowSpeakerLabels</c>
    /// is true, <c>MaxSpeakerLabels</c> must also be set. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ChannelDefinitions</c>: A <c>MedicalScribeChannelDefinitions</c> array should
    /// be set if and only if the <c>ChannelIdentification</c> value of <c>Settings</c> is
    /// set to true. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartMedicalScribeJobRequest : AmazonTranscribeServiceRequest
    {
        private List<MedicalScribeChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;
        private string _dataAccessRoleArn;
        private Dictionary<string, string> _kmsEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Media _media;
        private MedicalScribeContext _medicalScribeContext;
        private string _medicalScribeJobName;
        private string _outputBucketName;
        private string _outputEncryptionKMSKeyId;
        private MedicalScribeSettings _settings;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Makes it possible to specify which speaker is on which channel. For example, if the
        /// clinician is the first participant to speak, you would set <c>ChannelId</c> of the
        /// first <c>ChannelDefinition</c> in the list to <c>0</c> (to indicate the first channel)
        /// and <c>ParticipantRole</c> to <c>CLINICIAN</c> (to indicate that it's the clinician
        /// speaking). Then you would set the <c>ChannelId</c> of the second <c>ChannelDefinition</c>
        /// in the list to <c>1</c> (to indicate the second channel) and <c>ParticipantRole</c>
        /// to <c>PATIENT</c> (to indicate that it's the patient speaking). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<MedicalScribeChannelDefinition> ChannelDefinitions
        {
            get { return this._channelDefinitions; }
            set { this._channelDefinitions = value; }
        }

        // Check to see if ChannelDefinitions property is set
        internal bool IsSetChannelDefinitions()
        {
            return this._channelDefinitions != null && (this._channelDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files, write to the output bucket, and use your
        /// KMS key if supplied. If the role that you specify doesn’t have the appropriate permissions
        /// your request fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <c>arn:partition:iam::account:role/role-name-with-path</c>.
        /// For example: <c>arn:aws:iam::111122223333:role/Admin</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
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
        /// Gets and sets the property MedicalScribeContext. 
        /// <para>
        /// The <c>MedicalScribeContext</c> object that contains contextual information which
        /// is used during clinical note generation to add relevant context to the note.
        /// </para>
        /// </summary>
        public MedicalScribeContext MedicalScribeContext
        {
            get { return this._medicalScribeContext; }
            set { this._medicalScribeContext = value; }
        }

        // Check to see if MedicalScribeContext property is set
        internal bool IsSetMedicalScribeContext()
        {
            return this._medicalScribeContext != null;
        }

        /// <summary>
        /// Gets and sets the property MedicalScribeJobName. 
        /// <para>
        /// A unique name, chosen by you, for your Medical Scribe job.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new job with the same name as an existing
        /// job, you get a <c>ConflictException</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string MedicalScribeJobName
        {
            get { return this._medicalScribeJobName; }
            set { this._medicalScribeJobName = value; }
        }

        // Check to see if MedicalScribeJobName property is set
        internal bool IsSetMedicalScribeJobName()
        {
            return this._medicalScribeJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputBucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket where you want your Medical Scribe output stored.
        /// Do not include the <c>S3://</c> prefix of the specified bucket.
        /// </para>
        ///  
        /// <para>
        /// Note that the role specified in the <c>DataAccessRoleArn</c> request parameter must
        /// have permission to use the specified location. You can change Amazon S3 permissions
        /// using the <a href="https://console.aws.amazon.com/s3">Amazon Web Services Management
        /// Console</a>. See also <a href="https://docs.aws.amazon.com/transcribe/latest/dg/security_iam_id-based-policy-examples.html#auth-role-iam-user">Permissions
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
        /// The KMS key you want to use to encrypt your Medical Scribe output.
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
        /// Note that the role specified in the <c>DataAccessRoleArn</c> request parameter must
        /// have permission to use the specified KMS key.
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// Makes it possible to control how your Medical Scribe job is processed using a <c>MedicalScribeSettings</c>
        /// object. Specify <c>ChannelIdentification</c> if <c>ChannelDefinitions</c> are set.
        /// Enabled <c>ShowSpeakerLabels</c> if <c>ChannelIdentification</c> and <c>ChannelDefinitions</c>
        /// are not set. One and only one of <c>ChannelIdentification</c> and <c>ShowSpeakerLabels</c>
        /// must be set. If <c>ShowSpeakerLabels</c> is set, <c>MaxSpeakerLabels</c> must also
        /// be set. Use <c>Settings</c> to specify a vocabulary or vocabulary filter or both using
        /// <c>VocabularyName</c>, <c>VocabularyFilterName</c>. <c>VocabularyFilterMethod</c>
        /// must be specified if <c>VocabularyFilterName</c> is set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribeSettings Settings
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds one or more custom tags, each in the form of a key:value pair, to the Medical
        /// Scribe job.
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

    }
}