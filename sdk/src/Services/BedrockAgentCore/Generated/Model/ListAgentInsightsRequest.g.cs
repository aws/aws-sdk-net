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
    /// Container for the parameters to the ListAgentInsights operation. Lists Amazon Bedrock
    /// AgentCore Agent Insight summaries in your account and Region. Use this operation to
    /// review patterns across sessions before you investigate or archive an insight. The
    /// response paginates the results. Use the <c>nextToken</c> parameter to retrieve additional
    /// results.
    /// </summary>
    public partial class ListAgentInsightsRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Filters the results to Agent Insights for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ArchiveStatus. 
        /// <para>
        /// Filters the results by archive status.
        /// </para>
        /// </summary>
        public AgentInsightArchiveStatus ArchiveStatus { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveStatus property is set.
        /// </summary>
        internal bool IsSetArchiveStatus() => this.ArchiveStatus != null;

        /// <summary>
        /// Gets and sets the property BatchEvaluationId. 
        /// <para>
        /// Filters the results to Agent Insights produced by a batch evaluation.
        /// </para>
        /// </summary>
        public string BatchEvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluationId property is set.
        /// </summary>
        internal bool IsSetBatchEvaluationId() => this.BatchEvaluationId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of Agent Insight summaries to return in one response. If you don't
        /// specify a value, the operation returns up to 50 summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating the results. This token is returned in
        /// a previous response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
