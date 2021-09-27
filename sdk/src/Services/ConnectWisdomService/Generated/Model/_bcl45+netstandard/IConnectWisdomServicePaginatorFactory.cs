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
        IListAssistantAssociationsPaginator ListAssistantAssociations(ListAssistantAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAssistants operation
        ///</summary>
        IListAssistantsPaginator ListAssistants(ListAssistantsRequest request);

        /// <summary>
        /// Paginator for ListContents operation
        ///</summary>
        IListContentsPaginator ListContents(ListContentsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        ///</summary>
        IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for QueryAssistant operation
        ///</summary>
        IQueryAssistantPaginator QueryAssistant(QueryAssistantRequest request);

        /// <summary>
        /// Paginator for SearchContent operation
        ///</summary>
        ISearchContentPaginator SearchContent(SearchContentRequest request);

        /// <summary>
        /// Paginator for SearchSessions operation
        ///</summary>
        ISearchSessionsPaginator SearchSessions(SearchSessionsRequest request);
    }
}