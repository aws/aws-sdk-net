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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// Paginators for the ConnectWisdomService service
    ///</summary>
    public interface IConnectWisdomServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssistantAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssistantAssociationsPaginator ListAssistantAssociations(ListAssistantAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAssistants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssistantsPaginator ListAssistants(ListAssistantsRequest request);

        /// <summary>
        /// Paginator for ListContents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListContentsPaginator ListContents(ListContentsRequest request);

        /// <summary>
        /// Paginator for ListImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request);

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
        /// Paginator for ListQuickResponses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQuickResponsesPaginator ListQuickResponses(ListQuickResponsesRequest request);

        /// <summary>
        /// Paginator for QueryAssistant operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IQueryAssistantPaginator QueryAssistant(QueryAssistantRequest request);

        /// <summary>
        /// Paginator for SearchContent operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchContentPaginator SearchContent(SearchContentRequest request);

        /// <summary>
        /// Paginator for SearchQuickResponses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchQuickResponsesPaginator SearchQuickResponses(SearchQuickResponsesRequest request);

        /// <summary>
        /// Paginator for SearchSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchSessionsPaginator SearchSessions(SearchSessionsRequest request);
    }
}