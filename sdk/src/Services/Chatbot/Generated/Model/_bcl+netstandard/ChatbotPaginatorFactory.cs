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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Paginators for the Chatbot service
    ///</summary>
    public class ChatbotPaginatorFactory : IChatbotPaginatorFactory
    {
        private readonly IAmazonChatbot client;

        internal ChatbotPaginatorFactory(IAmazonChatbot client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeChimeWebhookConfigurations operation
        ///</summary>
        public IDescribeChimeWebhookConfigurationsPaginator DescribeChimeWebhookConfigurations(DescribeChimeWebhookConfigurationsRequest request) 
        {
            return new DescribeChimeWebhookConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSlackChannelConfigurations operation
        ///</summary>
        public IDescribeSlackChannelConfigurationsPaginator DescribeSlackChannelConfigurations(DescribeSlackChannelConfigurationsRequest request) 
        {
            return new DescribeSlackChannelConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSlackUserIdentities operation
        ///</summary>
        public IDescribeSlackUserIdentitiesPaginator DescribeSlackUserIdentities(DescribeSlackUserIdentitiesRequest request) 
        {
            return new DescribeSlackUserIdentitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSlackWorkspaces operation
        ///</summary>
        public IDescribeSlackWorkspacesPaginator DescribeSlackWorkspaces(DescribeSlackWorkspacesRequest request) 
        {
            return new DescribeSlackWorkspacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        public IListAssociationsPaginator ListAssociations(ListAssociationsRequest request) 
        {
            return new ListAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCustomActions operation
        ///</summary>
        public IListCustomActionsPaginator ListCustomActions(ListCustomActionsRequest request) 
        {
            return new ListCustomActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrosoftTeamsChannelConfigurations operation
        ///</summary>
        public IListMicrosoftTeamsChannelConfigurationsPaginator ListMicrosoftTeamsChannelConfigurations(ListMicrosoftTeamsChannelConfigurationsRequest request) 
        {
            return new ListMicrosoftTeamsChannelConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrosoftTeamsConfiguredTeams operation
        ///</summary>
        public IListMicrosoftTeamsConfiguredTeamsPaginator ListMicrosoftTeamsConfiguredTeams(ListMicrosoftTeamsConfiguredTeamsRequest request) 
        {
            return new ListMicrosoftTeamsConfiguredTeamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMicrosoftTeamsUserIdentities operation
        ///</summary>
        public IListMicrosoftTeamsUserIdentitiesPaginator ListMicrosoftTeamsUserIdentities(ListMicrosoftTeamsUserIdentitiesRequest request) 
        {
            return new ListMicrosoftTeamsUserIdentitiesPaginator(this.client, request);
        }
    }
}