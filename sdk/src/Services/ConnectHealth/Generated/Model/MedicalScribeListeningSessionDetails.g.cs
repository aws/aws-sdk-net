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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Detailed information about a Medical Scribe listening session
    /// </summary>
    public partial class MedicalScribeListeningSessionDetails
    {
        /// <summary>
        /// Gets and sets the property ChannelDefinitions. 
        /// <para>
        /// Channel definitions for the audio stream
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The Domain identifier
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EncounterContextProvided. 
        /// <para>
        /// Indicates whether encounter context was provided
        /// </para>
        /// </summary>
        public bool? EncounterContextProvided { get; set; }

        /// <summary>
        /// Checks to see if the EncounterContextProvided property is set.
        /// </summary>
        internal bool IsSetEncounterContextProvided() => this.EncounterContextProvided.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code for the audio in the session
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
        /// The encoding for the input audio
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
        /// The sample rate of the input audio
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8000, Max = 48000)]
        public int? MediaSampleRateHertz { get; set; }

        /// <summary>
        /// Checks to see if the MediaSampleRateHertz property is set.
        /// </summary>
        internal bool IsSetMediaSampleRateHertz() => this.MediaSampleRateHertz.HasValue;

        /// <summary>
        /// Gets and sets the property PostStreamActionResult. 
        /// <para>
        /// Results of post-stream actions
        /// </para>
        /// </summary>
        public MedicalScribePostStreamActionsResult PostStreamActionResult { get; set; }

        /// <summary>
        /// Checks to see if the PostStreamActionResult property is set.
        /// </summary>
        internal bool IsSetPostStreamActionResult() => this.PostStreamActionResult != null;

        /// <summary>
        /// Gets and sets the property PostStreamActionSettings. 
        /// <para>
        /// Settings for post-stream actions
        /// </para>
        /// </summary>
        public MedicalScribePostStreamActionSettingsResponse PostStreamActionSettings { get; set; }

        /// <summary>
        /// Checks to see if the PostStreamActionSettings property is set.
        /// </summary>
        internal bool IsSetPostStreamActionSettings() => this.PostStreamActionSettings != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The Session identifier
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StreamCreationTime. 
        /// <para>
        /// The timestamp when the stream was created
        /// </para>
        /// </summary>
        public DateTime? StreamCreationTime { get; set; }

        /// <summary>
        /// Checks to see if the StreamCreationTime property is set.
        /// </summary>
        internal bool IsSetStreamCreationTime() => this.StreamCreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property StreamEndTime. 
        /// <para>
        /// The timestamp when the stream ended
        /// </para>
        /// </summary>
        public DateTime? StreamEndTime { get; set; }

        /// <summary>
        /// Checks to see if the StreamEndTime property is set.
        /// </summary>
        internal bool IsSetStreamEndTime() => this.StreamEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The current status of the stream
        /// </para>
        /// </summary>
        public MedicalScribeStreamStatus StreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamStatus property is set.
        /// </summary>
        internal bool IsSetStreamStatus() => this.StreamStatus != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The Subscription identifier
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 25)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;
    }
}
