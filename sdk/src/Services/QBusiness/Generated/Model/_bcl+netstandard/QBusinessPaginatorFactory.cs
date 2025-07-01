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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Paginators for the QBusiness service
    ///</summary>
    public class QBusinessPaginatorFactory : IQBusinessPaginatorFactory
    {
        private readonly IAmazonQBusiness client;

        internal QBusinessPaginatorFactory(IAmazonQBusiness client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetChatControlsConfiguration operation
        ///</summary>
        public IGetChatControlsConfigurationPaginator GetChatControlsConfiguration(GetChatControlsConfigurationRequest request) 
        {
            return new GetChatControlsConfigurationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAttachments operation
        ///</summary>
        public IListAttachmentsPaginator ListAttachments(ListAttachmentsRequest request) 
        {
            return new ListAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListChatResponseConfigurations operation
        ///</summary>
        public IListChatResponseConfigurationsPaginator ListChatResponseConfigurations(ListChatResponseConfigurationsRequest request) 
        {
            return new ListChatResponseConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConversations operation
        ///</summary>
        public IListConversationsPaginator ListConversations(ListConversationsRequest request) 
        {
            return new ListConversationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataAccessors operation
        ///</summary>
        public IListDataAccessorsPaginator ListDataAccessors(ListDataAccessorsRequest request) 
        {
            return new ListDataAccessorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        public IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request) 
        {
            return new ListDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSourceSyncJobs operation
        ///</summary>
        public IListDataSourceSyncJobsPaginator ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request) 
        {
            return new ListDataSourceSyncJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDocuments operation
        ///</summary>
        public IListDocumentsPaginator ListDocuments(ListDocumentsRequest request) 
        {
            return new ListDocumentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        public IListGroupsPaginator ListGroups(ListGroupsRequest request) 
        {
            return new ListGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIndices operation
        ///</summary>
        public IListIndicesPaginator ListIndices(ListIndicesRequest request) 
        {
            return new ListIndicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMessages operation
        ///</summary>
        public IListMessagesPaginator ListMessages(ListMessagesRequest request) 
        {
            return new ListMessagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPluginActions operation
        ///</summary>
        public IListPluginActionsPaginator ListPluginActions(ListPluginActionsRequest request) 
        {
            return new ListPluginActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPlugins operation
        ///</summary>
        public IListPluginsPaginator ListPlugins(ListPluginsRequest request) 
        {
            return new ListPluginsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPluginTypeActions operation
        ///</summary>
        public IListPluginTypeActionsPaginator ListPluginTypeActions(ListPluginTypeActionsRequest request) 
        {
            return new ListPluginTypeActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPluginTypeMetadata operation
        ///</summary>
        public IListPluginTypeMetadataPaginator ListPluginTypeMetadata(ListPluginTypeMetadataRequest request) 
        {
            return new ListPluginTypeMetadataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRetrievers operation
        ///</summary>
        public IListRetrieversPaginator ListRetrievers(ListRetrieversRequest request) 
        {
            return new ListRetrieversPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubscriptions operation
        ///</summary>
        public IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request) 
        {
            return new ListSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWebExperiences operation
        ///</summary>
        public IListWebExperiencesPaginator ListWebExperiences(ListWebExperiencesRequest request) 
        {
            return new ListWebExperiencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchRelevantContent operation
        ///</summary>
        public ISearchRelevantContentPaginator SearchRelevantContent(SearchRelevantContentRequest request) 
        {
            return new SearchRelevantContentPaginator(this.client, request);
        }
    }
}