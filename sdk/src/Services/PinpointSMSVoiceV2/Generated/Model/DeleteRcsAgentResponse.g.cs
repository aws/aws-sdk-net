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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DeleteRcsAgent operation.
    /// </summary>
    public partial class DeleteRcsAgentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the RCS agent was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// When set to true deletion protection is enabled. By default this is set to false.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetDeletionProtectionEnabled() => this.DeletionProtectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList that was associated with the deleted RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property RcsAgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deleted RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RcsAgentArn { get; set; }

        /// <summary>
        /// Checks to see if the RcsAgentArn property is set.
        /// </summary>
        internal bool IsSetRcsAgentArn() => this.RcsAgentArn != null;

        /// <summary>
        /// Gets and sets the property RcsAgentId. 
        /// <para>
        /// The unique identifier for the deleted RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RcsAgentId { get; set; }

        /// <summary>
        /// Checks to see if the RcsAgentId property is set.
        /// </summary>
        internal bool IsSetRcsAgentId() => this.RcsAgentId != null;

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you're responsible for responding
        /// to HELP and STOP requests. You're also responsible for tracking and honoring opt-out
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? SelfManagedOptOutsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedOptOutsEnabled property is set.
        /// </summary>
        internal bool IsSetSelfManagedOptOutsEnabled() => this.SelfManagedOptOutsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RcsAgentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the two way channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayChannelArn property is set.
        /// </summary>
        internal bool IsSetTwoWayChannelArn() => this.TwoWayChannelArn != null;

        /// <summary>
        /// Gets and sets the property TwoWayChannelRole. 
        /// <para>
        /// An optional IAM Role Arn for a service to assume, to be able to post inbound SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string TwoWayChannelRole { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayChannelRole property is set.
        /// </summary>
        internal bool IsSetTwoWayChannelRole() => this.TwoWayChannelRole != null;

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? TwoWayEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TwoWayEnabled property is set.
        /// </summary>
        internal bool IsSetTwoWayEnabled() => this.TwoWayEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TwoWayRcsEventsEnabled. 
        /// <para>
        /// The list of RCS event types that were enabled for two-way messaging on the deleted
        /// agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> TwoWayRcsEventsEnabled { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TwoWayRcsEventsEnabled property is set.
        /// </summary>
        internal bool IsSetTwoWayRcsEventsEnabled() => this.TwoWayRcsEventsEnabled != null && (this.TwoWayRcsEventsEnabled.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
