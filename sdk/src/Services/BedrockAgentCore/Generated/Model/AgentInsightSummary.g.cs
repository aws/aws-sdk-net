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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains summary information about an Amazon Bedrock AgentCore Agent Insight, including
    /// its label, description, and creation time. This structure is returned by <c>ListAgentInsights</c>;
    /// use <c>GetAgentInsight</c> to retrieve the sample sessions and root causes for a specific
    /// insight.
    /// </summary>
    public partial class AgentInsightSummary
    {
        /// <summary>
        /// Gets and sets the property AffectedSessionCount. 
        /// <para>
        /// The number of sessions affected by the insight pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AffectedSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the AffectedSessionCount property is set.
        /// </summary>
        internal bool IsSetAffectedSessionCount() => this.AffectedSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property AgentInsightId. 
        /// <para>
        /// The unique identifier of the Agent Insight.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgentInsightId { get; set; }

        /// <summary>
        /// Checks to see if the AgentInsightId property is set.
        /// </summary>
        internal bool IsSetAgentInsightId() => this.AgentInsightId != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application that the Agent Insight belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ArchiveStatus. 
        /// <para>
        /// Specifies whether the Agent Insight is active or archived. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The insight is currently active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c> - The insight has been archived.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInsightArchiveStatus ArchiveStatus { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveStatus property is set.
        /// </summary>
        internal bool IsSetArchiveStatus() => this.ArchiveStatus != null;

        /// <summary>
        /// Gets and sets the property BatchEvaluationId. The Batch Evaluation that produced this
        /// Insight, when applicable.
        /// </summary>
        public string BatchEvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluationId property is set.
        /// </summary>
        internal bool IsSetBatchEvaluationId() => this.BatchEvaluationId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Agent Insight was first created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerMetadataStatus. 
        /// <para>
        /// Specifies whether customer-encrypted metadata is available for the Agent Insight.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInsightCustomerMetadataStatus CustomerMetadataStatus { get; set; }

        /// <summary>
        /// Checks to see if the CustomerMetadataStatus property is set.
        /// </summary>
        internal bool IsSetCustomerMetadataStatus() => this.CustomerMetadataStatus != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A generated description of the Agent Insight that explains the detected pattern and
        /// its observed behavior across sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 4000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The most recent date and time when the insight pattern was observed.
        /// </para>
        /// </summary>
        public DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenAt property is set.
        /// </summary>
        internal bool IsSetLastSeenAt() => this.LastSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A generated display label for the Agent Insight. This is a human-readable summary
        /// of the detected pattern, not an identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the Agent Insight was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
