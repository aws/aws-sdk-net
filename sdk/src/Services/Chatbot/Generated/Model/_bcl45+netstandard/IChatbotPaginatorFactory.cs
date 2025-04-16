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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Paginators for the Chatbot service
    ///</summary>
    public interface IChatbotPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeChimeWebhookConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeChimeWebhookConfigurationsPaginator DescribeChimeWebhookConfigurations(DescribeChimeWebhookConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeSlackChannelConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSlackChannelConfigurationsPaginator DescribeSlackChannelConfigurations(DescribeSlackChannelConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeSlackUserIdentities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSlackUserIdentitiesPaginator DescribeSlackUserIdentities(DescribeSlackUserIdentitiesRequest request);

        /// <summary>
        /// Paginator for DescribeSlackWorkspaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSlackWorkspacesPaginator DescribeSlackWorkspaces(DescribeSlackWorkspacesRequest request);

        /// <summary>
        /// Paginator for ListAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociationsPaginator ListAssociations(ListAssociationsRequest request);

        /// <summary>
        /// Paginator for ListCustomActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCustomActionsPaginator ListCustomActions(ListCustomActionsRequest request);

        /// <summary>
        /// Paginator for ListMicrosoftTeamsChannelConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrosoftTeamsChannelConfigurationsPaginator ListMicrosoftTeamsChannelConfigurations(ListMicrosoftTeamsChannelConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListMicrosoftTeamsConfiguredTeams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrosoftTeamsConfiguredTeamsPaginator ListMicrosoftTeamsConfiguredTeams(ListMicrosoftTeamsConfiguredTeamsRequest request);

        /// <summary>
        /// Paginator for ListMicrosoftTeamsUserIdentities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMicrosoftTeamsUserIdentitiesPaginator ListMicrosoftTeamsUserIdentities(ListMicrosoftTeamsUserIdentitiesRequest request);
    }
}