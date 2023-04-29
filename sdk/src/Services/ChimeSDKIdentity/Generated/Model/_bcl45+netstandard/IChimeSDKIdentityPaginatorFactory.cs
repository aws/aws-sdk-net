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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKIdentity service
    ///</summary>
    public interface IChimeSDKIdentityPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAppInstanceAdmins operation
        ///</summary>
        IListAppInstanceAdminsPaginator ListAppInstanceAdmins(ListAppInstanceAdminsRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceBots operation
        ///</summary>
        IListAppInstanceBotsPaginator ListAppInstanceBots(ListAppInstanceBotsRequest request);

        /// <summary>
        /// Paginator for ListAppInstances operation
        ///</summary>
        IListAppInstancesPaginator ListAppInstances(ListAppInstancesRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceUserEndpoints operation
        ///</summary>
        IListAppInstanceUserEndpointsPaginator ListAppInstanceUserEndpoints(ListAppInstanceUserEndpointsRequest request);

        /// <summary>
        /// Paginator for ListAppInstanceUsers operation
        ///</summary>
        IListAppInstanceUsersPaginator ListAppInstanceUsers(ListAppInstanceUsersRequest request);
    }
}