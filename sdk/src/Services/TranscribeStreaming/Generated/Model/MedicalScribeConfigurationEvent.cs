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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Specify details to configure the streaming session, including channel definitions,
    /// encryption settings, post-stream analytics settings, resource access role ARN and
    /// vocabulary settings. 
    /// 
    ///  
    /// <para>
    /// Whether you are starting a new session or resuming an existing session, your first
    /// event must be a <c>MedicalScribeConfigurationEvent</c>. If you are resuming a session,
    /// then this event must have the same configurations that you provided to start the session.
    /// 
    /// </para>
    /// </summary>
    public partial class MedicalScribeConfigurationEvent
        : IEventStreamEvent
    {
        private List<MedicalScribeChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;
        private MedicalScribeEncryptionSettings _encryptionSettings;
        private MedicalScribeContext _medicalScribeContext;
        private MedicalScribePostStreamAnalyticsSettings _postStreamAnalyticsSettings;
        private string _resourceAccessRoleArn;
        private MedicalScribeVocabularyFilterMethod _vocabularyFilterMethod;
        private string _vocabularyFilterName;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Specify which speaker is on which audio channel.
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
        /// Specify the encryption settings for your streaming session.
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
        /// Gets and sets the property MedicalScribeContext. 
        /// <para>
        /// The <c>MedicalScribeContext</c> object that contains contextual information used to
        /// generate customized clinical notes.
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
        /// Gets and sets the property PostStreamAnalyticsSettings. 
        /// <para>
        /// Specify settings for post-stream analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 output bucket you specified, and use your KMS key if supplied. If the role that
        /// you specify doesn’t have the appropriate permissions, your request fails. 
        /// </para>
        ///  
        /// <para>
        ///  IAM role ARNs have the format <c>arn:partition:iam::account:role/role-name-with-path</c>.
        /// For example: <c>arn:aws:iam::111122223333:role/Admin</c>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe-streaming.html">Amazon
        /// Web Services HealthScribe</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property VocabularyFilterMethod. 
        /// <para>
        /// Specify how you want your custom vocabulary filter applied to the streaming session.
        /// </para>
        ///  
        /// <para>
        /// To replace words with <c>***</c>, specify <c>mask</c>. 
        /// </para>
        ///  
        /// <para>
        /// To delete words, specify <c>remove</c>. 
        /// </para>
        ///  
        /// <para>
        /// To flag words without changing them, specify <c>tag</c>. 
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
        /// Specify the name of the custom vocabulary filter you want to include in your streaming
        /// session. Custom vocabulary filter names are case-sensitive. 
        /// </para>
        ///  
        /// <para>
        /// If you include <c>VocabularyFilterName</c> in the <c>MedicalScribeConfigurationEvent</c>,
        /// you must also include <c>VocabularyFilterMethod</c>. 
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
        /// Specify the name of the custom vocabulary you want to use for your streaming session.
        /// Custom vocabulary names are case-sensitive. 
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