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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGoal operation.
    /// Update an existing goal
    /// </summary>
    public partial class UpdateGoalRequest : AmazonDevOpsAgentRequest
    {
        private string _agentSpaceId;
        private string _clientToken;
        private GoalScheduleInput _evaluationSchedule;
        private string _goalId;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing the goal
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Client-provided token for idempotent operations
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationSchedule. 
        /// <para>
        /// Update goal schedule state
        /// </para>
        /// </summary>
        public GoalScheduleInput EvaluationSchedule
        {
            get { return this._evaluationSchedule; }
            set { this._evaluationSchedule = value; }
        }

        // Check to see if EvaluationSchedule property is set
        internal bool IsSetEvaluationSchedule()
        {
            return this._evaluationSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property GoalId. 
        /// <para>
        /// The unique identifier of the goal to update
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GoalId
        {
            get { return this._goalId; }
            set { this._goalId = value; }
        }

        // Check to see if GoalId property is set
        internal bool IsSetGoalId()
        {
            return this._goalId != null;
        }

    }
}