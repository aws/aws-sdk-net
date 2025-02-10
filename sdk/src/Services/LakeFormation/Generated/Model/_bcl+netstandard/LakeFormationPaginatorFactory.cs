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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Paginators for the LakeFormation service
    ///</summary>
    public class LakeFormationPaginatorFactory : ILakeFormationPaginatorFactory
    {
        private readonly IAmazonLakeFormation client;

        internal LakeFormationPaginatorFactory(IAmazonLakeFormation client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetEffectivePermissionsForPath operation
        ///</summary>
        public IGetEffectivePermissionsForPathPaginator GetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request) 
        {
            return new GetEffectivePermissionsForPathPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTableObjects operation
        ///</summary>
        public IGetTableObjectsPaginator GetTableObjects(GetTableObjectsRequest request) 
        {
            return new GetTableObjectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetWorkUnits operation
        ///</summary>
        public IGetWorkUnitsPaginator GetWorkUnits(GetWorkUnitsRequest request) 
        {
            return new GetWorkUnitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataCellsFilter operation
        ///</summary>
        public IListDataCellsFilterPaginator ListDataCellsFilter(ListDataCellsFilterRequest request) 
        {
            return new ListDataCellsFilterPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLakeFormationOptIns operation
        ///</summary>
        public IListLakeFormationOptInsPaginator ListLakeFormationOptIns(ListLakeFormationOptInsRequest request) 
        {
            return new ListLakeFormationOptInsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLFTagExpressions operation
        ///</summary>
        public IListLFTagExpressionsPaginator ListLFTagExpressions(ListLFTagExpressionsRequest request) 
        {
            return new ListLFTagExpressionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLFTags operation
        ///</summary>
        public IListLFTagsPaginator ListLFTags(ListLFTagsRequest request) 
        {
            return new ListLFTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        public IListPermissionsPaginator ListPermissions(ListPermissionsRequest request) 
        {
            return new ListPermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        public IListResourcesPaginator ListResources(ListResourcesRequest request) 
        {
            return new ListResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTableStorageOptimizers operation
        ///</summary>
        public IListTableStorageOptimizersPaginator ListTableStorageOptimizers(ListTableStorageOptimizersRequest request) 
        {
            return new ListTableStorageOptimizersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTransactions operation
        ///</summary>
        public IListTransactionsPaginator ListTransactions(ListTransactionsRequest request) 
        {
            return new ListTransactionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchDatabasesByLFTags operation
        ///</summary>
        public ISearchDatabasesByLFTagsPaginator SearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request) 
        {
            return new SearchDatabasesByLFTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchTablesByLFTags operation
        ///</summary>
        public ISearchTablesByLFTagsPaginator SearchTablesByLFTags(SearchTablesByLFTagsRequest request) 
        {
            return new SearchTablesByLFTagsPaginator(this.client, request);
        }
    }
}