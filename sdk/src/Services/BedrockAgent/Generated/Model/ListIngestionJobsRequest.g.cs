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
    /// Container for the parameters to the ListIngestionJobs operation. Lists the data ingestion
    /// jobs for a data source. The list also includes information about each job.
    /// </summary>
    public partial class ListIngestionJobsRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source for the list of data ingestion jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Contains information about the filters for filtering the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<IngestionJobFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<IngestionJobFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base for the list of data ingestion jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Contains details about how to sort the data.
        /// </para>
        /// </summary>
        public IngestionJobSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;
    }
}
