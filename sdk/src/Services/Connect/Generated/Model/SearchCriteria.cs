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
    /// A structure of search criteria to be used to return contacts.
    /// </summary>
    public partial class SearchCriteria
    {
        private AgentHierarchyGroups _agentHierarchyGroups;
        private List<string> _agentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _channels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ContactAnalysis _contactAnalysis;
        private List<string> _initiationMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _queueIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SearchableContactAttributes _searchableContactAttributes;

        /// <summary>
        /// Gets and sets the property AgentHierarchyGroups. 
        /// <para>
        /// The agent hierarchy groups of the agent at the time of handling the contact.
        /// </para>
        /// </summary>
        public AgentHierarchyGroups AgentHierarchyGroups
        {
            get { return this._agentHierarchyGroups; }
            set { this._agentHierarchyGroups = value; }
        }

        // Check to see if AgentHierarchyGroups property is set
        internal bool IsSetAgentHierarchyGroups()
        {
            return this._agentHierarchyGroups != null;
        }

        /// <summary>
        /// Gets and sets the property AgentIds. 
        /// <para>
        /// The identifiers of agents who handled the contacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> AgentIds
        {
            get { return this._agentIds; }
            set { this._agentIds = value; }
        }

        // Check to see if AgentIds property is set
        internal bool IsSetAgentIds()
        {
            return this._agentIds != null && (this._agentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// The list of channels associated with contacts.
        /// </para>
        /// </summary>
        public List<string> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && (this._channels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContactAnalysis. 
        /// <para>
        /// Search criteria based on analysis outputs from Amazon Connect Contact Lens.
        /// </para>
        /// </summary>
        public ContactAnalysis ContactAnalysis
        {
            get { return this._contactAnalysis; }
            set { this._contactAnalysis = value; }
        }

        // Check to see if ContactAnalysis property is set
        internal bool IsSetContactAnalysis()
        {
            return this._contactAnalysis != null;
        }

        /// <summary>
        /// Gets and sets the property InitiationMethods. 
        /// <para>
        /// The list of initiation methods associated with contacts.
        /// </para>
        /// </summary>
        public List<string> InitiationMethods
        {
            get { return this._initiationMethods; }
            set { this._initiationMethods = value; }
        }

        // Check to see if InitiationMethods property is set
        internal bool IsSetInitiationMethods()
        {
            return this._initiationMethods != null && (this._initiationMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueIds. 
        /// <para>
        /// The list of queue IDs associated with contacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> QueueIds
        {
            get { return this._queueIds; }
            set { this._queueIds = value; }
        }

        // Check to see if QueueIds property is set
        internal bool IsSetQueueIds()
        {
            return this._queueIds != null && (this._queueIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SearchableContactAttributes. 
        /// <para>
        /// The search criteria based on user-defined contact attributes that have been configured
        /// for contact search. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/search-custom-attributes.html">Search
        /// by customer contact attributes</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To use <c>SearchableContactAttributes</c> in a search request, the <c>GetContactAttributes</c>
        /// action is required to perform an API request. For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonconnect.html#amazonconnect-actions-as-permissions">https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonconnect.html#amazonconnect-actions-as-permissions</a>Actions
        /// defined by Amazon Connect.
        /// </para>
        ///  </important>
        /// </summary>
        public SearchableContactAttributes SearchableContactAttributes
        {
            get { return this._searchableContactAttributes; }
            set { this._searchableContactAttributes = value; }
        }

        // Check to see if SearchableContactAttributes property is set
        internal bool IsSetSearchableContactAttributes()
        {
            return this._searchableContactAttributes != null;
        }

    }
}