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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Paginators for the Ivschat service
    ///</summary>
    public class IvschatPaginatorFactory : IIvschatPaginatorFactory
    {
        private readonly IAmazonIvschat client;

        internal IvschatPaginatorFactory(IAmazonIvschat client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListLoggingConfigurations operation
        ///</summary>
        public IListLoggingConfigurationsPaginator ListLoggingConfigurations(ListLoggingConfigurationsRequest request) 
        {
            return new ListLoggingConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRooms operation
        ///</summary>
        public IListRoomsPaginator ListRooms(ListRoomsRequest request) 
        {
            return new ListRoomsPaginator(this.client, request);
        }
    }
}