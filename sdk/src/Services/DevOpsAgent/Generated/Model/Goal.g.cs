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
    /// Represents a goal with all its properties and metadata
    /// </summary>
    public partial class Goal
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// The unique identifier for the agent space containing this goal
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceArn property is set.
        /// </summary>
        internal bool IsSetAgentSpaceArn() => this.AgentSpaceArn != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Content of the goal
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GoalContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this goal was created
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationSchedule. 
        /// <para>
        /// Goal Schedule. Allows to schedule the goal to run periodically, as well as disable
        /// a goal temporarily
        /// </para>
        /// </summary>
        public GoalSchedule EvaluationSchedule { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationSchedule property is set.
        /// </summary>
        internal bool IsSetEvaluationSchedule() => this.EvaluationSchedule != null;

        /// <summary>
        /// Gets and sets the property GoalId. 
        /// <para>
        /// The unique identifier for this goal
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GoalId { get; set; }

        /// <summary>
        /// Checks to see if the GoalId property is set.
        /// </summary>
        internal bool IsSetGoalId() => this.GoalId != null;

        /// <summary>
        /// Gets and sets the property GoalType. 
        /// <para>
        /// Type of goal based on its origin
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GoalType GoalType { get; set; }

        /// <summary>
        /// Checks to see if the GoalType property is set.
        /// </summary>
        internal bool IsSetGoalType() => this.GoalType != null;

        /// <summary>
        /// Gets and sets the property LastEvaluatedAt. 
        /// <para>
        /// Timestamp when the goal was last evaluated
        /// </para>
        /// </summary>
        public DateTime? LastEvaluatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedAt property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedAt() => this.LastEvaluatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulTaskId. 
        /// <para>
        /// ID of the most recent successful task associated with this goal
        /// </para>
        /// </summary>
        public string LastSuccessfulTaskId { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulTaskId property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulTaskId() => this.LastSuccessfulTaskId != null;

        /// <summary>
        /// Gets and sets the property LastTaskId. 
        /// <para>
        /// ID of the most recent task associated with this goal
        /// </para>
        /// </summary>
        public string LastTaskId { get; set; }

        /// <summary>
        /// Checks to see if the LastTaskId property is set.
        /// </summary>
        internal bool IsSetLastTaskId() => this.LastTaskId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the goal itself
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GoalStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the goal
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this goal was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version number for optimistic locking
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
