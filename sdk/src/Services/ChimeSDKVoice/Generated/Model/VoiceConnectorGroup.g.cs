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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The Amazon Chime SDK Voice Connector group configuration, including associated Voice
    /// Connectors. You can include Voice Connectors from different AWS Regions in a group.
    /// This creates a fault tolerant mechanism for fallback in case of availability events.
    /// </summary>
    public partial class VoiceConnectorGroup
    {
        /// <summary>
        /// Gets and sets the property CallDistributionType.
        /// </summary>
        public CallDistributionType CallDistributionType { get; set; }

        /// <summary>
        /// Checks to see if the CallDistributionType property is set.
        /// </summary>
        internal bool IsSetCallDistributionType() => this.CallDistributionType != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The Voice Connector group's creation time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a Voice Connector group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The Voice Connector group's creation time stamp, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceConnectorGroupArn. 
        /// <para>
        /// The ARN of the Voice Connector group.
        /// </para>
        /// </summary>
        public string VoiceConnectorGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorGroupArn property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorGroupArn() => this.VoiceConnectorGroupArn != null;

        /// <summary>
        /// Gets and sets the property VoiceConnectorGroupId. 
        /// <para>
        /// The ID of a Voice Connector group.
        /// </para>
        /// </summary>
        public string VoiceConnectorGroupId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceConnectorGroupId property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorGroupId() => this.VoiceConnectorGroupId != null;

        /// <summary>
        /// Gets and sets the property VoiceConnectorItems. 
        /// <para>
        /// The Voice Connectors to which you route inbound calls.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VoiceConnectorItem> VoiceConnectorItems { get; set; } = AWSConfigs.InitializeCollections ? new List<VoiceConnectorItem>() : null;

        /// <summary>
        /// Checks to see if the VoiceConnectorItems property is set.
        /// </summary>
        internal bool IsSetVoiceConnectorItems() => this.VoiceConnectorItems != null && (this.VoiceConnectorItems.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
