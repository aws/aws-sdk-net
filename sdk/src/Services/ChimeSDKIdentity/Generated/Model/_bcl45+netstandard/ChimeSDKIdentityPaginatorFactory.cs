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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKIdentity service
    ///</summary>
    public class ChimeSDKIdentityPaginatorFactory : IChimeSDKIdentityPaginatorFactory
    {
        private readonly IAmazonChimeSDKIdentity client;

        internal ChimeSDKIdentityPaginatorFactory(IAmazonChimeSDKIdentity client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAppInstanceAdmins operation
        ///</summary>
        public IListAppInstanceAdminsPaginator ListAppInstanceAdmins(ListAppInstanceAdminsRequest request) 
        {
            return new ListAppInstanceAdminsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstanceBots operation
        ///</summary>
        public IListAppInstanceBotsPaginator ListAppInstanceBots(ListAppInstanceBotsRequest request) 
        {
            return new ListAppInstanceBotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstances operation
        ///</summary>
        public IListAppInstancesPaginator ListAppInstances(ListAppInstancesRequest request) 
        {
            return new ListAppInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstanceUserEndpoints operation
        ///</summary>
        public IListAppInstanceUserEndpointsPaginator ListAppInstanceUserEndpoints(ListAppInstanceUserEndpointsRequest request) 
        {
            return new ListAppInstanceUserEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAppInstanceUsers operation
        ///</summary>
        public IListAppInstanceUsersPaginator ListAppInstanceUsers(ListAppInstanceUsersRequest request) 
        {
            return new ListAppInstanceUsersPaginator(this.client, request);
        }
    }
}