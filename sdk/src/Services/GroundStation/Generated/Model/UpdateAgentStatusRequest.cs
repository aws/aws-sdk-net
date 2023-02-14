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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentStatus operation.
    /// Update the status of the agent.
    /// </summary>
    public partial class UpdateAgentStatusRequest : AmazonGroundStationRequest
    {
        private string _agentId;
        private AggregateStatus _aggregateStatus;
        private List<ComponentStatusData> _componentStatuses = new List<ComponentStatusData>();
        private string _taskId;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// UUID of agent to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AggregateStatus. 
        /// <para>
        /// Aggregate status for agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregateStatus AggregateStatus
        {
            get { return this._aggregateStatus; }
            set { this._aggregateStatus = value; }
        }

        // Check to see if AggregateStatus property is set
        internal bool IsSetAggregateStatus()
        {
            return this._aggregateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentStatuses. 
        /// <para>
        /// List of component statuses for agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<ComponentStatusData> ComponentStatuses
        {
            get { return this._componentStatuses; }
            set { this._componentStatuses = value; }
        }

        // Check to see if ComponentStatuses property is set
        internal bool IsSetComponentStatuses()
        {
            return this._componentStatuses != null && this._componentStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// GUID of agent task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}