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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Paginators for the GameLiftStreams service
    ///</summary>
    public class GameLiftStreamsPaginatorFactory : IGameLiftStreamsPaginatorFactory
    {
        private readonly IAmazonGameLiftStreams client;

        internal GameLiftStreamsPaginatorFactory(IAmazonGameLiftStreams client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamGroups operation
        ///</summary>
        public IListStreamGroupsPaginator ListStreamGroups(ListStreamGroupsRequest request) 
        {
            return new ListStreamGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamSessions operation
        ///</summary>
        public IListStreamSessionsPaginator ListStreamSessions(ListStreamSessionsRequest request) 
        {
            return new ListStreamSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListStreamSessionsByAccount operation
        ///</summary>
        public IListStreamSessionsByAccountPaginator ListStreamSessionsByAccount(ListStreamSessionsByAccountRequest request) 
        {
            return new ListStreamSessionsByAccountPaginator(this.client, request);
        }
    }
}