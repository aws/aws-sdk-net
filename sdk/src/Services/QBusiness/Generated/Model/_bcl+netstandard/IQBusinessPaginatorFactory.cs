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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Paginators for the QBusiness service
    ///</summary>
    public interface IQBusinessPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetChatControlsConfiguration operation
        ///</summary>
        IGetChatControlsConfigurationPaginator GetChatControlsConfiguration(GetChatControlsConfigurationRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListAttachments operation
        ///</summary>
        IListAttachmentsPaginator ListAttachments(ListAttachmentsRequest request);

        /// <summary>
        /// Paginator for ListConversations operation
        ///</summary>
        IListConversationsPaginator ListConversations(ListConversationsRequest request);

        /// <summary>
        /// Paginator for ListDataAccessors operation
        ///</summary>
        IListDataAccessorsPaginator ListDataAccessors(ListDataAccessorsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDataSourceSyncJobs operation
        ///</summary>
        IListDataSourceSyncJobsPaginator ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request);

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        IListDocumentsPaginator ListDocuments(ListDocumentsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        IListIndicesPaginator ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Paginator for ListMessages operation
        ///</summary>
        IListMessagesPaginator ListMessages(ListMessagesRequest request);

        /// <summary>
        /// Paginator for ListPluginActions operation
        ///</summary>
        IListPluginActionsPaginator ListPluginActions(ListPluginActionsRequest request);

        /// <summary>
        /// Paginator for ListPlugins operation
        ///</summary>
        IListPluginsPaginator ListPlugins(ListPluginsRequest request);

        /// <summary>
        /// Paginator for ListPluginTypeActions operation
        ///</summary>
        IListPluginTypeActionsPaginator ListPluginTypeActions(ListPluginTypeActionsRequest request);

        /// <summary>
        /// Paginator for ListPluginTypeMetadata operation
        ///</summary>
        IListPluginTypeMetadataPaginator ListPluginTypeMetadata(ListPluginTypeMetadataRequest request);

        /// <summary>
        /// Paginator for ListRetrievers operation
        ///</summary>
        IListRetrieversPaginator ListRetrievers(ListRetrieversRequest request);

        /// <summary>
        /// Paginator for ListWebExperiences operation
        ///</summary>
        IListWebExperiencesPaginator ListWebExperiences(ListWebExperiencesRequest request);

        /// <summary>
        /// Paginator for SearchRelevantContent operation
        ///</summary>
        ISearchRelevantContentPaginator SearchRelevantContent(SearchRelevantContentRequest request);
    }
}