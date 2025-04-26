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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Paginators for the BedrockAgent service
    ///</summary>
    public interface IBedrockAgentPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAgentActionGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentActionGroupsPaginator ListAgentActionGroups(ListAgentActionGroupsRequest request);

        /// <summary>
        /// Paginator for ListAgentAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentAliasesPaginator ListAgentAliases(ListAgentAliasesRequest request);

        /// <summary>
        /// Paginator for ListAgentCollaborators operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentCollaboratorsPaginator ListAgentCollaborators(ListAgentCollaboratorsRequest request);

        /// <summary>
        /// Paginator for ListAgentKnowledgeBases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentKnowledgeBasesPaginator ListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListAgents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentsPaginator ListAgents(ListAgentsRequest request);

        /// <summary>
        /// Paginator for ListAgentVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAgentVersionsPaginator ListAgentVersions(ListAgentVersionsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListFlowAliases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowAliasesPaginator ListFlowAliases(ListFlowAliasesRequest request);

        /// <summary>
        /// Paginator for ListFlows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowsPaginator ListFlows(ListFlowsRequest request);

        /// <summary>
        /// Paginator for ListFlowVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowVersionsPaginator ListFlowVersions(ListFlowVersionsRequest request);

        /// <summary>
        /// Paginator for ListIngestionJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIngestionJobsPaginator ListIngestionJobs(ListIngestionJobsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBaseDocuments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKnowledgeBaseDocumentsPaginator ListKnowledgeBaseDocuments(ListKnowledgeBaseDocumentsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListPrompts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPromptsPaginator ListPrompts(ListPromptsRequest request);
    }
}