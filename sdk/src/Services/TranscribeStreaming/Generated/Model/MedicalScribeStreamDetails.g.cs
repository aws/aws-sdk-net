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

namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains details about a Amazon Web Services HealthScribe streaming session.
    /// </summary>
    public partial class MedicalScribeStreamDetails
    {
        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// The Channel Definitions of the HealthScribe streaming session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public List<MedicalScribeChannelDefinition> ChannelDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;

        /// <summary>
        /// Checks to see if the ChannelDefinitions property is set.
        /// </summary>
        internal bool IsSetChannelDefinitions() => this.ChannelDefinitions != null && (this.ChannelDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionSettings. 
        /// <para>
        /// The Encryption Settings of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeEncryptionSettings EncryptionSettings { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSettings property is set.
        /// </summary>
        internal bool IsSetEncryptionSettings() => this.EncryptionSettings != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// The Media Encoding of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeMediaEncoding MediaEncoding { get; set; }

        /// <summary>
        /// Checks to see if the MediaEncoding property is set.
        /// </summary>
        internal bool IsSetMediaEncoding() => this.MediaEncoding != null;

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate (in hertz) of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property MedicalScribeContextProvided. 
        /// <para>
        /// Indicates whether the <c>MedicalScribeContext</c> object was provided when the stream
        /// was started.
        /// </para>
        /// </summary>
        public bool? MedicalScribeContextProvided { get; set; }

        /// <summary>
        /// Checks to see if the MedicalScribeContextProvided property is set.
        /// </summary>
        internal bool IsSetMedicalScribeContextProvided() => this.MedicalScribeContextProvided.HasValue;

        /// <summary>
        /// Gets and sets the property PostStreamAnalyticsResult. 
        /// <para>
        /// The result of post-stream analytics for the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribePostStreamAnalyticsResult PostStreamAnalyticsResult { get; set; }

        /// <summary>
        /// Checks to see if the PostStreamAnalyticsResult property is set.
        /// </summary>
        internal bool IsSetPostStreamAnalyticsResult() => this.PostStreamAnalyticsResult != null;

        /// <summary>
        /// Gets and sets the property PostStreamAnalyticsSettings. 
        /// <para>
        /// The post-stream analytics settings of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribePostStreamAnalyticsSettings PostStreamAnalyticsSettings { get; set; }

        /// <summary>
        /// Checks to see if the PostStreamAnalyticsSettings property is set.
        /// </summary>
        internal bool IsSetPostStreamAnalyticsSettings() => this.PostStreamAnalyticsSettings != null;

        /// <summary>
        /// Gets and sets the property ResourceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role used in the HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetResourceAccessRoleArn() => this.ResourceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StreamCreatedAt. 
        /// <para>
        /// The date and time when the HealthScribe streaming session was created.
        /// </para>
        /// </summary>
        public DateTime? StreamCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the StreamCreatedAt property is set.
        /// </summary>
        internal bool IsSetStreamCreatedAt() => this.StreamCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StreamEndedAt. 
        /// <para>
        /// The date and time when the HealthScribe streaming session was ended.
        /// </para>
        /// </summary>
        public DateTime? StreamEndedAt { get; set; }

        /// <summary>
        /// Checks to see if the StreamEndedAt property is set.
        /// </summary>
        internal bool IsSetStreamEndedAt() => this.StreamEndedAt.HasValue;

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
        public MedicalScribeStreamStatus StreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamStatus property is set.
        /// </summary>
        internal bool IsSetStreamStatus() => this.StreamStatus != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// The method of the vocabulary filter for the HealthScribe streaming session.
        /// </para>
        /// </summary>
        public MedicalScribeVocabularyFilterMethod VocabularyFilterMethod { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterMethod property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterMethod() => this.VocabularyFilterMethod != null;

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the vocabulary filter used for the HealthScribe streaming session .
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyFilterName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyFilterName property is set.
        /// </summary>
        internal bool IsSetVocabularyFilterName() => this.VocabularyFilterName != null;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The vocabulary name of the HealthScribe streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;
    }
}
