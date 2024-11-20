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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Paginators for the Keyspaces service
    ///</summary>
    public class KeyspacesPaginatorFactory : IKeyspacesPaginatorFactory
    {
        private readonly IAmazonKeyspaces client;

        internal KeyspacesPaginatorFactory(IAmazonKeyspaces client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListKeyspaces operation
        ///</summary>
        public IListKeyspacesPaginator ListKeyspaces(ListKeyspacesRequest request) 
        {
            return new ListKeyspacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTables operation
        ///</summary>
        public IListTablesPaginator ListTables(ListTablesRequest request) 
        {
            return new ListTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTypes operation
        ///</summary>
        public IListTypesPaginator ListTypes(ListTypesRequest request) 
        {
            return new ListTypesPaginator(this.client, request);
        }
    }
}