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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKMessaging service
    /// </summary>
    public interface IChimeSDKMessagingPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListChannelBans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelBansPaginator ListChannelBans(ListChannelBansRequest request);

        /// <summary>
        /// Paginator for ListChannelFlows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelFlowsPaginator ListChannelFlows(ListChannelFlowsRequest request);

        /// <summary>
        /// Paginator for ListChannelMemberships operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelMembershipsPaginator ListChannelMemberships(ListChannelMembershipsRequest request);

        /// <summary>
        /// Paginator for ListChannelMembershipsForAppInstanceUser operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelMembershipsForAppInstanceUserPaginator ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request);

        /// <summary>
        /// Paginator for ListChannelMessages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelMessagesPaginator ListChannelMessages(ListChannelMessagesRequest request);

        /// <summary>
        /// Paginator for ListChannelModerators operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelModeratorsPaginator ListChannelModerators(ListChannelModeratorsRequest request);

        /// <summary>
        /// Paginator for ListChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelsPaginator ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Paginator for ListChannelsAssociatedWithChannelFlow operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelsAssociatedWithChannelFlowPaginator ListChannelsAssociatedWithChannelFlow(ListChannelsAssociatedWithChannelFlowRequest request);

        /// <summary>
        /// Paginator for ListChannelsModeratedByAppInstanceUser operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListChannelsModeratedByAppInstanceUserPaginator ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request);

        /// <summary>
        /// Paginator for ListSubChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubChannelsPaginator ListSubChannels(ListSubChannelsRequest request);

        /// <summary>
        /// Paginator for SearchChannels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchChannelsPaginator SearchChannels(SearchChannelsRequest request);
    }
}
