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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about a data ingestion job. Data sources are ingested into a knowledge
    /// base so that Large Language Models (LLMs) can use your data.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_StartIngestionJob.html#API_agent_StartIngestionJob_ResponseSyntax">StartIngestionJob
    /// response</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_GetIngestionJob.html#API_agent_GetIngestionJob_ResponseSyntax">GetIngestionJob
    /// response</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_ListIngestionJobs.html#API_agent_ListIngestionJobs_ResponseSyntax">ListIngestionJob
    /// response</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class IngestionJob
    {
        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source for the data ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// A list of reasons that the data ingestion job failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IngestionJobId. 
        /// <para>
        /// The unique identifier of the data ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IngestionJobId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionJobId property is set.
        /// </summary>
        internal bool IsSetIngestionJobId() => this.IngestionJobId != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge for the data ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the data ingestion job started.
        /// </para>
        ///  
        /// <para>
        /// If you stop a data ingestion job, the <c>startedAt</c> time is the time the job was
        /// started before the job was stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Contains statistics about the data ingestion job.
        /// </para>
        /// </summary>
        public IngestionJobStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data ingestion job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestionJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time the data ingestion job was last updated.
        /// </para>
        ///  
        /// <para>
        /// If you stop a data ingestion job, the <c>updatedAt</c> time is the time the job was
        /// stopped.
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
