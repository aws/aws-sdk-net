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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private int? _afterContactWorkDuration;
        private DateTime? _afterContactWorkEndTimestamp;
        private DateTime? _afterContactWorkStartTimestamp;
        private int? _agentInitiatedHoldDuration;
        private int? _agentPauseDurationInSeconds;
        private ParticipantCapabilities _capabilities;
        private DateTime? _connectedToAgentTimestamp;
        private DeviceInfo _deviceInfo;
        private HierarchyGroups _hierarchyGroups;
        private string _id;
        private List<StateTransition> _stateTransitions = AWSConfigs.InitializeCollections ? new List<StateTransition>() : null;

        /// <summary>
        /// Gets and sets the property AfterContactWorkDuration. 
        /// <para>
        /// The difference in time, in whole seconds, between <c>AfterContactWorkStartTimestamp</c>
        /// and <c>AfterContactWorkEndTimestamp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AfterContactWorkDuration
        {
            get { return this._afterContactWorkDuration; }
            set { this._afterContactWorkDuration = value; }
        }

        // Check to see if AfterContactWorkDuration property is set
        internal bool IsSetAfterContactWorkDuration()
        {
            return this._afterContactWorkDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AfterContactWorkEndTimestamp. 
        /// <para>
        /// The date and time when the agent ended After Contact Work for the contact, in UTC
        /// time. In cases when agent finishes doing <c>AfterContactWork</c> for chat contacts
        /// and switches their activity status to offline or equivalent without clearing the contact
        /// in CCP, discrepancies may be noticed for <c>AfterContactWorkEndTimestamp</c>.
        /// </para>
        /// </summary>
        public DateTime? AfterContactWorkEndTimestamp
        {
            get { return this._afterContactWorkEndTimestamp; }
            set { this._afterContactWorkEndTimestamp = value; }
        }

        // Check to see if AfterContactWorkEndTimestamp property is set
        internal bool IsSetAfterContactWorkEndTimestamp()
        {
            return this._afterContactWorkEndTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AfterContactWorkStartTimestamp. 
        /// <para>
        /// The date and time when the agent started doing After Contact Work for the contact,
        /// in UTC time.
        /// </para>
        /// </summary>
        public DateTime? AfterContactWorkStartTimestamp
        {
            get { return this._afterContactWorkStartTimestamp; }
            set { this._afterContactWorkStartTimestamp = value; }
        }

        // Check to see if AfterContactWorkStartTimestamp property is set
        internal bool IsSetAfterContactWorkStartTimestamp()
        {
            return this._afterContactWorkStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AgentInitiatedHoldDuration. 
        /// <para>
        /// The total hold duration in seconds initiated by the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AgentInitiatedHoldDuration
        {
            get { return this._agentInitiatedHoldDuration; }
            set { this._agentInitiatedHoldDuration = value; }
        }

        // Check to see if AgentInitiatedHoldDuration property is set
        internal bool IsSetAgentInitiatedHoldDuration()
        {
            return this._agentInitiatedHoldDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AgentPauseDurationInSeconds. 
        /// <para>
        /// Agent pause duration for a contact in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AgentPauseDurationInSeconds
        {
            get { return this._agentPauseDurationInSeconds; }
            set { this._agentPauseDurationInSeconds = value; }
        }

        // Check to see if AgentPauseDurationInSeconds property is set
        internal bool IsSetAgentPauseDurationInSeconds()
        {
            return this._agentPauseDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Capabilities.
        /// </summary>
        public ParticipantCapabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedToAgentTimestamp. 
        /// <para>
        /// The timestamp when the contact was connected to the agent.
        /// </para>
        /// </summary>
        public DateTime? ConnectedToAgentTimestamp
        {
            get { return this._connectedToAgentTimestamp; }
            set { this._connectedToAgentTimestamp = value; }
        }

        // Check to see if ConnectedToAgentTimestamp property is set
        internal bool IsSetConnectedToAgentTimestamp()
        {
            return this._connectedToAgentTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceInfo. 
        /// <para>
        /// Information regarding Agent’s device.
        /// </para>
        /// </summary>
        public DeviceInfo DeviceInfo
        {
            get { return this._deviceInfo; }
            set { this._deviceInfo = value; }
        }

        // Check to see if DeviceInfo property is set
        internal bool IsSetDeviceInfo()
        {
            return this._deviceInfo != null;
        }

        /// <summary>
        /// Gets and sets the property HierarchyGroups. 
        /// <para>
        /// The agent hierarchy groups for the agent.
        /// </para>
        /// </summary>
        public HierarchyGroups HierarchyGroups
        {
            get { return this._hierarchyGroups; }
            set { this._hierarchyGroups = value; }
        }

        // Check to see if HierarchyGroups property is set
        internal bool IsSetHierarchyGroups()
        {
            return this._hierarchyGroups != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the agent who accepted the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitions. 
        /// <para>
        /// List of <c>StateTransition</c> for a supervisor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StateTransition> StateTransitions
        {
            get { return this._stateTransitions; }
            set { this._stateTransitions = value; }
        }

        // Check to see if StateTransitions property is set
        internal bool IsSetStateTransitions()
        {
            return this._stateTransitions != null && (this._stateTransitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}