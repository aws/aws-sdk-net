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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Paginators for the LakeFormation service
    ///</summary>
    public interface ILakeFormationPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetEffectivePermissionsForPath operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetEffectivePermissionsForPathPaginator GetEffectivePermissionsForPath(GetEffectivePermissionsForPathRequest request);

        /// <summary>
        /// Paginator for GetTableObjects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTableObjectsPaginator GetTableObjects(GetTableObjectsRequest request);

        /// <summary>
        /// Paginator for GetWorkUnits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextToken" }
        )]
        IGetWorkUnitsPaginator GetWorkUnits(GetWorkUnitsRequest request);

        /// <summary>
        /// Paginator for ListDataCellsFilter operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListDataCellsFilterPaginator ListDataCellsFilter(ListDataCellsFilterRequest request);

        /// <summary>
        /// Paginator for ListLakeFormationOptIns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLakeFormationOptInsPaginator ListLakeFormationOptIns(ListLakeFormationOptInsRequest request);

        /// <summary>
        /// Paginator for ListLFTagExpressions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLFTagExpressionsPaginator ListLFTagExpressions(ListLFTagExpressionsRequest request);

        /// <summary>
        /// Paginator for ListLFTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLFTagsPaginator ListLFTags(ListLFTagsRequest request);

        /// <summary>
        /// Paginator for ListPermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPermissionsPaginator ListPermissions(ListPermissionsRequest request);

        /// <summary>
        /// Paginator for ListResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListResourcesPaginator ListResources(ListResourcesRequest request);

        /// <summary>
        /// Paginator for ListTableStorageOptimizers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTableStorageOptimizersPaginator ListTableStorageOptimizers(ListTableStorageOptimizersRequest request);

        /// <summary>
        /// Paginator for ListTransactions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTransactionsPaginator ListTransactions(ListTransactionsRequest request);

        /// <summary>
        /// Paginator for SearchDatabasesByLFTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchDatabasesByLFTagsPaginator SearchDatabasesByLFTags(SearchDatabasesByLFTagsRequest request);

        /// <summary>
        /// Paginator for SearchTablesByLFTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchTablesByLFTagsPaginator SearchTablesByLFTags(SearchTablesByLFTagsRequest request);
    }
}