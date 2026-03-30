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
    /// Represents a recommendation with all its properties and metadata
    /// </summary>
    public partial class Recommendation
    {
        private string _additionalContext;
        private string _agentSpaceArn;
        private RecommendationContent _content;
        private DateTime? _createdAt;
        private string _goalId;
        private long? _goalVersion;
        private RecommendationPriority _priority;
        private string _recommendationId;
        private RecommendationStatus _status;
        private string _taskId;
        private string _title;
        private DateTime? _updatedAt;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// Additional context for recommendation
        /// </para>
        /// </summary>
        public string AdditionalContext
        {
            get { return this._additionalContext; }
            set { this._additionalContext = value; }
        }

        // Check to see if AdditionalContext property is set
        internal bool IsSetAdditionalContext()
        {
            return this._additionalContext != null;
        }

        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// ARN of the agent space this recommendation belongs to
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
        /// Content of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationContent Content
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
        /// Timestamp when this recommendation was created
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
        /// Gets and sets the property GoalId. 
        /// <para>
        /// ID of the goal this recommendation is associated with
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GoalVersion. 
        /// <para>
        /// Version of the goal at the time this recommendation was generated
        /// </para>
        /// </summary>
        public long? GoalVersion
        {
            get { return this._goalVersion; }
            set { this._goalVersion = value; }
        }

        // Check to see if GoalVersion property is set
        internal bool IsSetGoalVersion()
        {
            return this._goalVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Priority level of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationPriority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The unique identifier for this recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationStatus Status
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
        /// Gets and sets the property TaskId. 
        /// <para>
        /// ID of the task that generated the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the recommendation
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
        /// Timestamp when this recommendation was last updated
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
        public long? Version
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