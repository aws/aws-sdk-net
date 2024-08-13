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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Paginators for the FinSpaceData service
    ///</summary>
    public class FinSpaceDataPaginatorFactory : IFinSpaceDataPaginatorFactory
    {
        private readonly IAmazonFinSpaceData client;

        internal FinSpaceDataPaginatorFactory(IAmazonFinSpaceData client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListChangesets operation
        ///</summary>
        public IListChangesetsPaginator ListChangesets(ListChangesetsRequest request) 
        {
            return new ListChangesetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDatasets operation
        ///</summary>
        public IListDatasetsPaginator ListDatasets(ListDatasetsRequest request) 
        {
            return new ListDatasetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataViews operation
        ///</summary>
        public IListDataViewsPaginator ListDataViews(ListDataViewsRequest request) 
        {
            return new ListDataViewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissionGroups operation
        ///</summary>
        public IListPermissionGroupsPaginator ListPermissionGroups(ListPermissionGroupsRequest request) 
        {
            return new ListPermissionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }
    }
}