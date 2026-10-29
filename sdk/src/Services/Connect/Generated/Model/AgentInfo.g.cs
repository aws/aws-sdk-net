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
    /// Information about the agent who accepted the contact.
    /// </summary>
    public partial class AgentInfo
    {
        /// <summary>
        /// Gets and sets the property AcceptedByAgentTimestamp. 
        /// <para>
        /// The timestamp when the contact was accepted by the agent.
        /// </para>
        /// </summary>
        public DateTime? AcceptedByAgentTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AcceptedByAgentTimestamp property is set.
        /// </summary>
        internal bool IsSetAcceptedByAgentTimestamp() => this.AcceptedByAgentTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ActiveRegion. 
        /// <para>
        /// The Region where the agent was active when they handled the contact. For Amazon Connect
        /// Global Resiliency instances enabled for global routing, this indicates the Region
        /// in which the agent's session was established at the time of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ActiveRegion { get; set; }

        /// <summary>
        /// Checks to see if the ActiveRegion property is set.
        /// </summary>
        internal bool IsSetActiveRegion() => this.ActiveRegion != null;

        /// <summary>
        /// Gets and sets the property AfterContactWorkDuration. 
        /// <para>
        /// The difference in time, in whole seconds, between <c>AfterContactWorkStartTimestamp</c>
        /// and <c>AfterContactWorkEndTimestamp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AfterContactWorkDuration { get; set; }

        /// <summary>
        /// Checks to see if the AfterContactWorkDuration property is set.
        /// </summary>
        internal bool IsSetAfterContactWorkDuration() => this.AfterContactWorkDuration.HasValue;

        /// <summary>
        /// Gets and sets the property AfterContactWorkEndTimestamp. 
        /// <para>
        /// The date and time when the agent ended After Contact Work for the contact, in UTC
        /// time. In cases when agent finishes doing <c>AfterContactWork</c> for chat contacts
        /// and switches their activity status to offline or equivalent without clearing the contact
        /// in CCP, discrepancies may be noticed for <c>AfterContactWorkEndTimestamp</c>.
        /// </para>
        /// </summary>
        public DateTime? AfterContactWorkEndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AfterContactWorkEndTimestamp property is set.
        /// </summary>
        internal bool IsSetAfterContactWorkEndTimestamp() => this.AfterContactWorkEndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property AfterContactWorkStartTimestamp. 
        /// <para>
        /// The date and time when the agent started doing After Contact Work for the contact,
        /// in UTC time.
        /// </para>
        /// </summary>
        public DateTime? AfterContactWorkStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AfterContactWorkStartTimestamp property is set.
        /// </summary>
        internal bool IsSetAfterContactWorkStartTimestamp() => this.AfterContactWorkStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property AgentInitiatedHoldDuration. 
        /// <para>
        /// The total hold duration in seconds initiated by the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AgentInitiatedHoldDuration { get; set; }

        /// <summary>
        /// Checks to see if the AgentInitiatedHoldDuration property is set.
        /// </summary>
        internal bool IsSetAgentInitiatedHoldDuration() => this.AgentInitiatedHoldDuration.HasValue;

        /// <summary>
        /// Gets and sets the property AgentPauseDurationInSeconds. 
        /// <para>
        /// Agent pause duration for a contact in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AgentPauseDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AgentPauseDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetAgentPauseDurationInSeconds() => this.AgentPauseDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Capabilities.
        /// </summary>
        public ParticipantCapabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property ConnectedToAgentTimestamp. 
        /// <para>
        /// The timestamp when the contact was connected to the agent.
        /// </para>
        /// </summary>
        public DateTime? ConnectedToAgentTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedToAgentTimestamp property is set.
        /// </summary>
        internal bool IsSetConnectedToAgentTimestamp() => this.ConnectedToAgentTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceInfo. 
        /// <para>
        /// Information regarding Agent’s device.
        /// </para>
        /// </summary>
        public DeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// Checks to see if the DeviceInfo property is set.
        /// </summary>
        internal bool IsSetDeviceInfo() => this.DeviceInfo != null;

        /// <summary>
        /// Gets and sets the property HierarchyGroups. 
        /// <para>
        /// The agent hierarchy groups for the agent.
        /// </para>
        /// </summary>
        public HierarchyGroups HierarchyGroups { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyGroups property is set.
        /// </summary>
        internal bool IsSetHierarchyGroups() => this.HierarchyGroups != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the agent who accepted the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PreviewEndTimestamp. 
        /// <para>
        /// The timestamp when the agent finished previewing the contact.
        /// </para>
        /// </summary>
        public DateTime? PreviewEndTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PreviewEndTimestamp property is set.
        /// </summary>
        internal bool IsSetPreviewEndTimestamp() => this.PreviewEndTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StateTransitions. 
        /// <para>
        /// List of <c>StateTransition</c> for a supervisor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StateTransition> StateTransitions { get; set; } = AWSConfigs.InitializeCollections ? new List<StateTransition>() : null;

        /// <summary>
        /// Checks to see if the StateTransitions property is set.
        /// </summary>
        internal bool IsSetStateTransitions() => this.StateTransitions != null && (this.StateTransitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VoiceEnhancementMode. 
        /// <para>
        /// The voice enhancement mode used by the agent as the call is ending. Valid values:
        /// VOICE_ISOLATION | NOISE_SUPPRESSION | NONE. A value of null indicates this mode has
        /// not yet been set for this user.
        /// </para>
        /// </summary>
        public VoiceEnhancementMode VoiceEnhancementMode { get; set; }

        /// <summary>
        /// Checks to see if the VoiceEnhancementMode property is set.
        /// </summary>
        internal bool IsSetVoiceEnhancementMode() => this.VoiceEnhancementMode != null;
    }
}
