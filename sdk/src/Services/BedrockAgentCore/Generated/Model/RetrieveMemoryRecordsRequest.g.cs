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
    /// Container for the parameters to the RetrieveMemoryRecords operation. Searches for
    /// and retrieves memory records from an AgentCore Memory resource based on specified
    /// search criteria. We recommend using pagination to ensure that the operation returns
    /// quickly and successfully. <para> To use this operation, you must have the <c>bedrock-agentcore:RetrieveMemoryRecords</c>
    /// permission. </para>
    /// </summary>
    public partial class RetrieveMemoryRecordsRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. The default value is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryId. 
        /// <para>
        /// The identifier of the AgentCore Memory resource from which to retrieve memory records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12)]
        public string MemoryId { get; set; }

        /// <summary>
        /// Checks to see if the MemoryId property is set.
        /// </summary>
        internal bool IsSetMemoryId() => this.MemoryId != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace prefix to filter memory records by. Searches for memory records in namespaces
        /// that start with the provided prefix. Either <c>namespace</c> or <c>namespacePath</c>
        /// is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NamespacePath. 
        /// <para>
        /// Use namespacePath for hierarchical retrievals. Return all memory records where namespace
        /// falls under the same parent hierarchy. Either <c>namespace</c> or <c>namespacePath</c>
        /// is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NamespacePath { get; set; }

        /// <summary>
        /// Checks to see if the NamespacePath property is set.
        /// </summary>
        internal bool IsSetNamespacePath() => this.NamespacePath != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SearchCriteria. 
        /// <para>
        /// The search criteria to use for finding relevant memory records. This includes the
        /// search query, memory strategy ID, and other search parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchCriteria SearchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the SearchCriteria property is set.
        /// </summary>
        internal bool IsSetSearchCriteria() => this.SearchCriteria != null;
    }
}
