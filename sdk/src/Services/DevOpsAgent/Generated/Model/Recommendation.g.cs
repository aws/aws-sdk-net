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
    /// Represents a recommendation with all its properties and metadata
    /// </summary>
    public partial class Recommendation
    {
        /// <summary>
        /// Gets and sets the property AdditionalContext. 
        /// <para>
        /// Additional context for recommendation
        /// </para>
        /// </summary>
        public string AdditionalContext { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalContext property is set.
        /// </summary>
        internal bool IsSetAdditionalContext() => this.AdditionalContext != null;

        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// ARN of the agent space this recommendation belongs to
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
        /// Content of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this recommendation was created
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property GoalId. 
        /// <para>
        /// ID of the goal this recommendation is associated with
        /// </para>
        /// </summary>
        public string GoalId { get; set; }

        /// <summary>
        /// Checks to see if the GoalId property is set.
        /// </summary>
        internal bool IsSetGoalId() => this.GoalId != null;

        /// <summary>
        /// Gets and sets the property GoalVersion. 
        /// <para>
        /// Version of the goal at the time this recommendation was generated
        /// </para>
        /// </summary>
        public long? GoalVersion { get; set; }

        /// <summary>
        /// Checks to see if the GoalVersion property is set.
        /// </summary>
        internal bool IsSetGoalVersion() => this.GoalVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Priority level of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationPriority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property RankPosition. 
        /// <para>
        /// Position in ranked list (1 = highest priority)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? RankPosition { get; set; }

        /// <summary>
        /// Checks to see if the RankPosition property is set.
        /// </summary>
        internal bool IsSetRankPosition() => this.RankPosition.HasValue;

        /// <summary>
        /// Gets and sets the property RankedAt. 
        /// <para>
        /// Timestamp when the recommendation was last ranked
        /// </para>
        /// </summary>
        public DateTime? RankedAt { get; set; }

        /// <summary>
        /// Checks to see if the RankedAt property is set.
        /// </summary>
        internal bool IsSetRankedAt() => this.RankedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The unique identifier for this recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommendationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// ID of the task that generated the recommendation
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the recommendation
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
        /// Timestamp when this recommendation was last updated
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
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
