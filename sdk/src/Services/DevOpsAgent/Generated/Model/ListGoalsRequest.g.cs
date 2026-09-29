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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the ListGoals operation. Lists goals in the specified
    /// agent space with optional filtering
    /// </summary>
    public partial class ListGoalsRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property GoalType. 
        /// <para>
        /// Filter goals by goal type
        /// </para>
        /// </summary>
        public GoalType GoalType { get; set; }

        /// <summary>
        /// Checks to see if the GoalType property is set.
        /// </summary>
        internal bool IsSetGoalType() => this.GoalType != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of goals to return
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token for the next set of results
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter goals by goal status
        /// </para>
        /// </summary>
        public GoalStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
