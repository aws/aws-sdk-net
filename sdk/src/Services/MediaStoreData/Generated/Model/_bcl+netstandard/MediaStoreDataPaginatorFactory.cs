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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Paginators for the MediaStoreData service
    ///</summary>
    public class MediaStoreDataPaginatorFactory : IMediaStoreDataPaginatorFactory
    {
        private readonly IAmazonMediaStoreData client;

        internal MediaStoreDataPaginatorFactory(IAmazonMediaStoreData client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListItems operation
        ///</summary>
        public IListItemsPaginator ListItems(ListItemsRequest request) 
        {
            return new ListItemsPaginator(this.client, request);
        }
    }
}