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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Detailed information about a Medical Scribe listening session
    /// </summary>
    public partial class MedicalScribeListeningSessionDetails
    {
        private List<MedicalScribeChannelDefinition> _channelDefinitions = AWSConfigs.InitializeCollections ? new List<MedicalScribeChannelDefinition>() : null;
        private string _domainId;
        private bool? _encounterContextProvided;
        private MedicalScribeLanguageCode _languageCode;
        private MedicalScribeMediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private MedicalScribePostStreamActionsResult _postStreamActionResult;
        private MedicalScribePostStreamActionSettingsResponse _postStreamActionSettings;
        private string _sessionId;
        private DateTime? _streamCreationTime;
        private DateTime? _streamEndTime;
        private MedicalScribeStreamStatus _streamStatus;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Channel definitions for the audio stream
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The Domain identifier
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EncounterContextProvided. 
        /// <para>
        /// Indicates whether encounter context was provided
        /// </para>
        /// </summary>
        public bool? EncounterContextProvided
        {
            get { return this._encounterContextProvided; }
            set { this._encounterContextProvided = value; }
        }

        // Check to see if EncounterContextProvided property is set
        internal bool IsSetEncounterContextProvided()
        {
            return this._encounterContextProvided.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code for the audio in the session
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
        /// The encoding for the input audio
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
        /// The sample rate of the input audio
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
        /// Gets and sets the property PostStreamActionResult. 
        /// <para>
        /// Results of post-stream actions
        /// </para>
        /// </summary>
        public MedicalScribePostStreamActionsResult PostStreamActionResult
        {
            get { return this._postStreamActionResult; }
            set { this._postStreamActionResult = value; }
        }

        // Check to see if PostStreamActionResult property is set
        internal bool IsSetPostStreamActionResult()
        {
            return this._postStreamActionResult != null;
        }

        /// <summary>
        /// Gets and sets the property PostStreamActionSettings. 
        /// <para>
        /// Settings for post-stream actions
        /// </para>
        /// </summary>
        public MedicalScribePostStreamActionSettingsResponse PostStreamActionSettings
        {
            get { return this._postStreamActionSettings; }
            set { this._postStreamActionSettings = value; }
        }

        // Check to see if PostStreamActionSettings property is set
        internal bool IsSetPostStreamActionSettings()
        {
            return this._postStreamActionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The Session identifier
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
        /// Gets and sets the property StreamCreationTime. 
        /// <para>
        /// The timestamp when the stream was created
        /// </para>
        /// </summary>
        public DateTime? StreamCreationTime
        {
            get { return this._streamCreationTime; }
            set { this._streamCreationTime = value; }
        }

        // Check to see if StreamCreationTime property is set
        internal bool IsSetStreamCreationTime()
        {
            return this._streamCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamEndTime. 
        /// <para>
        /// The timestamp when the stream ended
        /// </para>
        /// </summary>
        public DateTime? StreamEndTime
        {
            get { return this._streamEndTime; }
            set { this._streamEndTime = value; }
        }

        // Check to see if StreamEndTime property is set
        internal bool IsSetStreamEndTime()
        {
            return this._streamEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The current status of the stream
        /// </para>
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
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The Subscription identifier
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

    }
}