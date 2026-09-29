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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Paginators for the QBusiness service
    /// </summary>
    public interface IQBusinessPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetChatControlsConfiguration operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetChatControlsConfigurationPaginator GetChatControlsConfiguration(GetChatControlsConfigurationRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListAttachments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAttachmentsPaginator ListAttachments(ListAttachmentsRequest request);

        /// <summary>
        /// Paginator for ListChatResponseConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChatResponseConfigurationsPaginator ListChatResponseConfigurations(ListChatResponseConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListConversations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListConversationsPaginator ListConversations(ListConversationsRequest request);

        /// <summary>
        /// Paginator for ListDataAccessors operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataAccessorsPaginator ListDataAccessors(ListDataAccessorsRequest request);

        /// <summary>
        /// Paginator for ListDataSourceSyncJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourceSyncJobsPaginator ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListDocuments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDocumentsPaginator ListDocuments(ListDocumentsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIndices operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIndicesPaginator ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Paginator for ListMessages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMessagesPaginator ListMessages(ListMessagesRequest request);

        /// <summary>
        /// Paginator for ListPluginActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPluginActionsPaginator ListPluginActions(ListPluginActionsRequest request);

        /// <summary>
        /// Paginator for ListPluginTypeActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPluginTypeActionsPaginator ListPluginTypeActions(ListPluginTypeActionsRequest request);

        /// <summary>
        /// Paginator for ListPluginTypeMetadata operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPluginTypeMetadataPaginator ListPluginTypeMetadata(ListPluginTypeMetadataRequest request);

        /// <summary>
        /// Paginator for ListPlugins operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPluginsPaginator ListPlugins(ListPluginsRequest request);

        /// <summary>
        /// Paginator for ListRetrievers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRetrieversPaginator ListRetrievers(ListRetrieversRequest request);

        /// <summary>
        /// Paginator for ListSubscriptions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubscriptionsPaginator ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListWebExperiences operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListWebExperiencesPaginator ListWebExperiences(ListWebExperiencesRequest request);

        /// <summary>
        /// Paginator for SearchRelevantContent operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchRelevantContentPaginator SearchRelevantContent(SearchRelevantContentRequest request);
    }
}
