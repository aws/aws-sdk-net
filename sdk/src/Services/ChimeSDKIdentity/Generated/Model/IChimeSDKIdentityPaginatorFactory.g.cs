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

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKIdentity service
    /// </summary>
    public interface IChimeSDKIdentityPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAppInstanceAdmins operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppInstanceAdminsPaginator ListAppInstanceAdmins(ListAppInstanceAdminsRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceBots operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppInstanceBotsPaginator ListAppInstanceBots(ListAppInstanceBotsRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceUserEndpoints operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppInstanceUserEndpointsPaginator ListAppInstanceUserEndpoints(ListAppInstanceUserEndpointsRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceUsers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppInstanceUsersPaginator ListAppInstanceUsers(ListAppInstanceUsersRequest request);

        /// <summary>
        /// Paginator for ListAppInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAppInstancesPaginator ListAppInstances(ListAppInstancesRequest request);
    }
}
