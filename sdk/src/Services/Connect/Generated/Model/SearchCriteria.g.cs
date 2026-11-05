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
    /// A structure of search criteria to be used to return contacts.
    /// </summary>
    public partial class SearchCriteria
    {
        /// <summary>
        /// Gets and sets the property ActiveRegions. 
        /// <para>
        /// The list of active regions for contacts in ACGR instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ActiveRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ActiveRegions property is set.
        /// </summary>
        internal bool IsSetActiveRegions() => this.ActiveRegions != null && (this.ActiveRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalTimeRange. 
        /// <para>
        /// Additional TimeRange used to filter contacts.
        /// </para>
        /// </summary>
        public SearchContactsAdditionalTimeRange AdditionalTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalTimeRange property is set.
        /// </summary>
        internal bool IsSetAdditionalTimeRange() => this.AdditionalTimeRange != null;

        /// <summary>
        /// Gets and sets the property AgentHierarchyGroups. 
        /// <para>
        /// The agent hierarchy groups of the agent at the time of handling the contact.
        /// </para>
        /// </summary>
        public AgentHierarchyGroups AgentHierarchyGroups { get; set; }

        /// <summary>
        /// Checks to see if the AgentHierarchyGroups property is set.
        /// </summary>
        internal bool IsSetAgentHierarchyGroups() => this.AgentHierarchyGroups != null;

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// The identifiers of agents who handled the contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AgentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentIds property is set.
        /// </summary>
        internal bool IsSetAgentIds() => this.AgentIds != null && (this.AgentIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AiAgents. 
        /// <para>
        /// AI Agent search criteria definitions.
        /// </para>
        /// </summary>
        public AiAgentsCriteria AiAgents { get; set; }

        /// <summary>
        /// Checks to see if the AiAgents property is set.
        /// </summary>
        internal bool IsSetAiAgents() => this.AiAgents != null;

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The list of channels associated with contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Channels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Channels property is set.
        /// </summary>
        internal bool IsSetChannels() => this.Channels != null && (this.Channels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContactAnalysis. 
        /// <para>
        /// Search criteria based on analysis outputs from Connect Customer Contact Lens.
        /// </para>
        /// </summary>
        public ContactAnalysis ContactAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the ContactAnalysis property is set.
        /// </summary>
        internal bool IsSetContactAnalysis() => this.ContactAnalysis != null;

        /// <summary>
        /// Gets and sets the property ContactTags.
        /// </summary>
        public ControlPlaneTagFilter ContactTags { get; set; }

        /// <summary>
        /// Checks to see if the ContactTags property is set.
        /// </summary>
        internal bool IsSetContactTags() => this.ContactTags != null;

        /// <summary>
        /// Gets and sets the property InitiationMethods. 
        /// <para>
        /// The list of initiation methods associated with contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InitiationMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InitiationMethods property is set.
        /// </summary>
        internal bool IsSetInitiationMethods() => this.InitiationMethods != null && (this.InitiationMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the contact.
        /// </para>
        /// </summary>
        public NameCriteria Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QueueIds. 
        /// <para>
        /// The list of queue IDs associated with contacts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> QueueIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueueIds property is set.
        /// </summary>
        internal bool IsSetQueueIds() => this.QueueIds != null && (this.QueueIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// Routing criteria for the contact.
        /// </para>
        /// </summary>
        public SearchableRoutingCriteria RoutingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the RoutingCriteria property is set.
        /// </summary>
        internal bool IsSetRoutingCriteria() => this.RoutingCriteria != null;

        /// <summary>
        /// Gets and sets the property SearchableContactAttributes. 
        /// <para>
        /// The search criteria based on user-defined contact attributes that have been configured
        /// for contact search. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/search-custom-attributes.html">Search
        /// by custom contact attributes</a> in the <i>Connect Customer Administrator Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To use <c>SearchableContactAttributes</c> in a search request, the <c>GetContactAttributes</c>
        /// action is required to perform an API request. For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonconnect.html#amazonconnect-actions-as-permissions">https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonconnect.html#amazonconnect-actions-as-permissions</a>Actions
        /// defined by Connect Customer.
        /// </para>
        ///  </important>
        /// </summary>
        public SearchableContactAttributes SearchableContactAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SearchableContactAttributes property is set.
        /// </summary>
        internal bool IsSetSearchableContactAttributes() => this.SearchableContactAttributes != null;

        /// <summary>
        /// Gets and sets the property SearchableSegmentAttributes. 
        /// <para>
        /// The search criteria based on searchable segment attributes of a contact.
        /// </para>
        /// </summary>
        public SearchableSegmentAttributes SearchableSegmentAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SearchableSegmentAttributes property is set.
        /// </summary>
        internal bool IsSetSearchableSegmentAttributes() => this.SearchableSegmentAttributes != null;
    }
}
