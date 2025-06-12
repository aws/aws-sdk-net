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
    /// Contains information about an agent status.
    /// </summary>
    public partial class AgentStatus
    {
        private string _agentStatusARN;
        private string _agentStatusId;
        private string _description;
        private int? _displayOrder;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private string _name;
        private AgentStatusState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AgentStatusType _type;

        /// <summary>
        /// Gets and sets the property AgentStatusARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent status.
        /// </para>
        /// </summary>
        public string AgentStatusARN
        {
            get { return this._agentStatusARN; }
            set { this._agentStatusARN = value; }
        }

        // Check to see if AgentStatusARN property is set
        internal bool IsSetAgentStatusARN()
        {
            return this._agentStatusARN != null;
        }

        /// <summary>
        /// Gets and sets the property AgentStatusId. 
        /// <para>
        /// The identifier of the agent status.
        /// </para>
        /// </summary>
        public string AgentStatusId
        {
            get { return this._agentStatusId; }
            set { this._agentStatusId = value; }
        }

        // Check to see if AgentStatusId property is set
        internal bool IsSetAgentStatusId()
        {
            return this._agentStatusId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayOrder. 
        /// <para>
        /// The display order of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? DisplayOrder
        {
            get { return this._displayOrder; }
            set { this._displayOrder = value; }
        }

        // Check to see if DisplayOrder property is set
        internal bool IsSetDisplayOrder()
        {
            return this._displayOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the agent status.
        /// </para>
        /// </summary>
        public AgentStatusState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of agent status.
        /// </para>
        /// </summary>
        public AgentStatusType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}