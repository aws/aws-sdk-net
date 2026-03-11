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
    /// Provides detailed information about a Medical Scribe job.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified Medical Scribe job, check the <c>MedicalScribeJobStatus</c>
    /// field. If the status is <c>COMPLETED</c>, the job is finished and you can find the
    /// results at the locations specified in <c>MedicalScribeOutput</c>. If the status is
    /// <c>FAILED</c>, <c>FailureReason</c> provides details on why your Medical Scribe job
    /// failed.
    /// </para>
    /// </summary>
    public partial class MedicalScribeJob
    {
        private List<MedicalScribeChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private string _dataAccessRoleArn;
        private string _failureReason;
        private MedicalScribeLanguageCode _languageCode;
        private Media _media;
        private bool? _medicalScribeContextProvided;
        private string _medicalScribeJobName;
        private MedicalScribeJobStatus _medicalScribeJobStatus;
        private MedicalScribeOutput _medicalScribeOutput;
        private MedicalScribeSettings _settings;
        private DateTime? _startTime;
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
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time the specified Medical Scribe job finished processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents a Medical Scribe job that finished
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the specified Medical Scribe job request was made.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents a Medical Scribe job that started
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>MedicalScribeJobStatus</c> is <c>FAILED</c>, <c>FailureReason</c> contains information
        /// about why the transcription job failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
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
        /// The language code used to create your Medical Scribe job. US English (<c>en-US</c>)
        /// is the only supported language for Medical Scribe jobs. 
        /// </para>
        /// </summary>
        public MedicalScribeLanguageCode LanguageCode
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
        /// Gets and sets the property MedicalScribeContextProvided. 
        /// <para>
        /// Indicates whether the <c>MedicalScribeContext</c> object was provided when the Medical
        /// Scribe job was started.
        /// </para>
        /// </summary>
        public bool? MedicalScribeContextProvided
        {
            get { return this._medicalScribeContextProvided; }
            set { this._medicalScribeContextProvided = value; }
        }

        // Check to see if MedicalScribeContextProvided property is set
        internal bool IsSetMedicalScribeContextProvided()
        {
            return this._medicalScribeContextProvided.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MedicalScribeJobName. 
        /// <para>
        /// The name of the Medical Scribe job. Job names are case sensitive and must be unique
        /// within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property MedicalScribeJobStatus. 
        /// <para>
        /// Provides the status of the specified Medical Scribe job.
        /// </para>
        ///  
        /// <para>
        /// If the status is <c>COMPLETED</c>, the job is finished and you can find the results
        /// at the location specified in <c>MedicalScribeOutput</c> If the status is <c>FAILED</c>,
        /// <c>FailureReason</c> provides details on why your Medical Scribe job failed.
        /// </para>
        /// </summary>
        public MedicalScribeJobStatus MedicalScribeJobStatus
        {
            get { return this._medicalScribeJobStatus; }
            set { this._medicalScribeJobStatus = value; }
        }

        // Check to see if MedicalScribeJobStatus property is set
        internal bool IsSetMedicalScribeJobStatus()
        {
            return this._medicalScribeJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MedicalScribeOutput. 
        /// <para>
        /// The location of the output of your Medical Scribe job. <c>ClinicalDocumentUri</c>
        /// holds the Amazon S3 URI for the Clinical Document and <c>TranscriptFileUri</c> holds
        /// the Amazon S3 URI for the Transcript.
        /// </para>
        /// </summary>
        public MedicalScribeOutput MedicalScribeOutput
        {
            get { return this._medicalScribeOutput; }
            set { this._medicalScribeOutput = value; }
        }

        // Check to see if MedicalScribeOutput property is set
        internal bool IsSetMedicalScribeOutput()
        {
            return this._medicalScribeOutput != null;
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time your Medical Scribe job began processing.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.789000-07:00</c> represents a Medical Scribe job that started
        /// processing at 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
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