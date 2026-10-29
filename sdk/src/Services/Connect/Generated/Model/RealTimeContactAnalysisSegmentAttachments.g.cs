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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Segment containing list of attachments.
    /// </summary>
    public partial class RealTimeContactAnalysisSegmentAttachments
    {
        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// List of objects describing an individual attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<RealTimeContactAnalysisAttachment> Attachments { get; set; } = AWSConfigs.InitializeCollections ? new List<RealTimeContactAnalysisAttachment>() : null;

        /// <summary>
        /// Checks to see if the Attachments property is set.
        /// </summary>
        internal bool IsSetAttachments() => this.Attachments != null && (this.Attachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the participant. Can be redacted. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier of the participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of the participant. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantRole ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// Field describing the time of the event. It can have different representations of time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RealTimeContactAnalysisTimeData Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null;
    }
}
