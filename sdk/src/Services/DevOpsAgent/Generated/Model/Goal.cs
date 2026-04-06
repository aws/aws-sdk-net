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
    /// Represents a goal with all its properties and metadata
    /// </summary>
    public partial class Goal
    {
        private string _agentSpaceArn;
        private GoalContent _content;
        private DateTime? _createdAt;
        private GoalSchedule _evaluationSchedule;
        private string _goalId;
        private GoalType _goalType;
        private DateTime? _lastEvaluatedAt;
        private string _lastSuccessfulTaskId;
        private string _lastTaskId;
        private GoalStatus _status;
        private string _title;
        private DateTime? _updatedAt;
        private int? _version;

        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// The unique identifier for the agent space containing this goal
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceArn
        {
            get { return this._agentSpaceArn; }
            set { this._agentSpaceArn = value; }
        }

        // Check to see if AgentSpaceArn property is set
        internal bool IsSetAgentSpaceArn()
        {
            return this._agentSpaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Content of the goal
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GoalContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this goal was created
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationSchedule. 
        /// <para>
        /// Goal Schedule. Allows to schedule the goal to run periodically, as well as disable
        /// a goal temporarily
        /// </para>
        /// </summary>
        public GoalSchedule EvaluationSchedule
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
        /// The unique identifier for this goal
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

        /// <summary>
        /// Gets and sets the property GoalType. 
        /// <para>
        /// Type of goal based on its origin
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GoalType GoalType
        {
            get { return this._goalType; }
            set { this._goalType = value; }
        }

        // Check to see if GoalType property is set
        internal bool IsSetGoalType()
        {
            return this._goalType != null;
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedAt. 
        /// <para>
        /// Timestamp when the goal was last evaluated
        /// </para>
        /// </summary>
        public DateTime? LastEvaluatedAt
        {
            get { return this._lastEvaluatedAt; }
            set { this._lastEvaluatedAt = value; }
        }

        // Check to see if LastEvaluatedAt property is set
        internal bool IsSetLastEvaluatedAt()
        {
            return this._lastEvaluatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulTaskId. 
        /// <para>
        /// ID of the most recent successful task associated with this goal
        /// </para>
        /// </summary>
        public string LastSuccessfulTaskId
        {
            get { return this._lastSuccessfulTaskId; }
            set { this._lastSuccessfulTaskId = value; }
        }

        // Check to see if LastSuccessfulTaskId property is set
        internal bool IsSetLastSuccessfulTaskId()
        {
            return this._lastSuccessfulTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property LastTaskId. 
        /// <para>
        /// ID of the most recent task associated with this goal
        /// </para>
        /// </summary>
        public string LastTaskId
        {
            get { return this._lastTaskId; }
            set { this._lastTaskId = value; }
        }

        // Check to see if LastTaskId property is set
        internal bool IsSetLastTaskId()
        {
            return this._lastTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the goal itself
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GoalStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the goal
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this goal was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version number for optimistic locking
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}