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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains details about a Amazon Web Services HealthScribe streaming session.
    /// </summary>
    public partial class MedicalScribeStreamDetails
    {
        private List<MedicalScribeChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;
        private MedicalScribeEncryptionSettings _encryptionSettings;
        private MedicalScribeLanguageCode _languageCode;
        private MedicalScribeMediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private bool? _medicalScribeContextProvided;
        private MedicalScribePostStreamAnalyticsResult _postStreamAnalyticsResult;
        private MedicalScribePostStreamAnalyticsSettings _postStreamAnalyticsSettings;
        private string _resourceAccessRoleArn;
        private string _sessionId;
        private DateTime? _streamCreatedAt;
        private DateTime? _streamEndedAt;
        private MedicalScribeStreamStatus _streamStatus;
        private MedicalScribeVocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// The Channel Definitions of the HealthScribe streaming session.
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
        /// Gets and sets the property EncryptionSettings. 
        /// <para>
        /// The Encryption Settings of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeEncryptionSettings EncryptionSettings
        {
            get { return this._encryptionSettings; }
            set { this._encryptionSettings = value; }
        }

        // Check to see if EncryptionSettings property is set
        internal bool IsSetEncryptionSettings()
        {
            return this._encryptionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code of the HealthScribe streaming session.
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
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// The Media Encoding of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeMediaEncoding MediaEncoding
        {
            get { return this._mediaEncoding; }
            set { this._mediaEncoding = value; }
        }

        // Check to see if MediaEncoding property is set
        internal bool IsSetMediaEncoding()
        {
            return this._mediaEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate (in hertz) of the HealthScribe streaming session.
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
        /// Gets and sets the property MedicalScribeContextProvided. 
        /// <para>
        /// Indicates whether the <c>MedicalScribeContext</c> object was provided when the stream
        /// was started.
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
        /// Gets and sets the property PostStreamAnalyticsResult. 
        /// <para>
        /// The result of post-stream analytics for the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribePostStreamAnalyticsResult PostStreamAnalyticsResult
        {
            get { return this._postStreamAnalyticsResult; }
            set { this._postStreamAnalyticsResult = value; }
        }

        // Check to see if PostStreamAnalyticsResult property is set
        internal bool IsSetPostStreamAnalyticsResult()
        {
            return this._postStreamAnalyticsResult != null;
        }

        /// <summary>
        /// Gets and sets the property PostStreamAnalyticsSettings. 
        /// <para>
        /// The post-stream analytics settings of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribePostStreamAnalyticsSettings PostStreamAnalyticsSettings
        {
            get { return this._postStreamAnalyticsSettings; }
            set { this._postStreamAnalyticsSettings = value; }
        }

        // Check to see if PostStreamAnalyticsSettings property is set
        internal bool IsSetPostStreamAnalyticsSettings()
        {
            return this._postStreamAnalyticsSettings != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role used in the HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceAccessRoleArn
        {
            get { return this._resourceAccessRoleArn; }
            set { this._resourceAccessRoleArn = value; }
        }

        // Check to see if ResourceAccessRoleArn property is set
        internal bool IsSetResourceAccessRoleArn()
        {
            return this._resourceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamCreatedAt. 
        /// <para>
        /// The date and time when the HealthScribe streaming session was created.
        /// </para>
        /// </summary>
        public DateTime? StreamCreatedAt
        {
            get { return this._streamCreatedAt; }
            set { this._streamCreatedAt = value; }
        }

        // Check to see if StreamCreatedAt property is set
        internal bool IsSetStreamCreatedAt()
        {
            return this._streamCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamEndedAt. 
        /// <para>
        /// The date and time when the HealthScribe streaming session was ended.
        /// </para>
        /// </summary>
        public DateTime? StreamEndedAt
        {
            get { return this._streamEndedAt; }
            set { this._streamEndedAt = value; }
        }

        // Check to see if StreamEndedAt property is set
        internal bool IsSetStreamEndedAt()
        {
            return this._streamEndedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The streaming status of the HealthScribe streaming session.
        /// </para>
        ///  
        /// <para>
        /// Possible Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAUSED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This status is specific to real-time streaming. A <c>COMPLETED</c> status doesn't
        /// mean that the post-stream analytics is complete. To get status of an analytics result,
        /// check the <c>Status</c> field for the analytics result within the <c>MedicalScribePostStreamAnalyticsResult</c>.
        /// For example, you can view the status of the <c>ClinicalNoteGenerationResult</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        public MedicalScribeStreamStatus StreamStatus
        {
            get { return this._streamStatus; }
            set { this._streamStatus = value; }
        }

        // Check to see if StreamStatus property is set
        internal bool IsSetStreamStatus()
        {
            return this._streamStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// The method of the vocabulary filter for the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeVocabularyFilterMethod VocabularyFilterMethod
        {
            get { return this._vocabularyFilterMethod; }
            set { this._vocabularyFilterMethod = value; }
        }

        // Check to see if VocabularyFilterMethod property is set
        internal bool IsSetVocabularyFilterMethod()
        {
            return this._vocabularyFilterMethod != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the vocabulary filter used for the HealthScribe streaming session .
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string VocabularyFilterName
        {
            get { return this._vocabularyFilterName; }
            set { this._vocabularyFilterName = value; }
        }

        // Check to see if VocabularyFilterName property is set
        internal bool IsSetVocabularyFilterName()
        {
            return this._vocabularyFilterName != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The vocabulary name of the HealthScribe streaming session.
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

    }
}