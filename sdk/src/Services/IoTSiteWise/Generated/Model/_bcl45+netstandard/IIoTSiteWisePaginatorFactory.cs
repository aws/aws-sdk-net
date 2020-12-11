#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Paginators for the IoTSiteWise service
    ///</summary>
    public interface IIoTSiteWisePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetAssetPropertyAggregates operation
        ///</summary>
        IGetAssetPropertyAggregatesPaginator GetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request);

        /// <summary>
        /// Paginator for GetAssetPropertyValueHistory operation
        ///</summary>
        IGetAssetPropertyValueHistoryPaginator GetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request);

        /// <summary>
        /// Paginator for ListAccessPolicies operation
        ///</summary>
        IListAccessPoliciesPaginator ListAccessPolicies(ListAccessPoliciesRequest request);

        /// <summary>
        /// Paginator for ListAssetModels operation
        ///</summary>
        IListAssetModelsPaginator ListAssetModels(ListAssetModelsRequest request);

        /// <summary>
        /// Paginator for ListAssetRelationships operation
        ///</summary>
        IListAssetRelationshipsPaginator ListAssetRelationships(ListAssetRelationshipsRequest request);

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedAssets operation
        ///</summary>
        IListAssociatedAssetsPaginator ListAssociatedAssets(ListAssociatedAssetsRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListGateways operation
        ///</summary>
        IListGatewaysPaginator ListGateways(ListGatewaysRequest request);

        /// <summary>
        /// Paginator for ListPortals operation
        ///</summary>
        IListPortalsPaginator ListPortals(ListPortalsRequest request);

        /// <summary>
        /// Paginator for ListProjectAssets operation
        ///</summary>
        IListProjectAssetsPaginator ListProjectAssets(ListProjectAssetsRequest request);

        /// <summary>
        /// Paginator for ListProjects operation
        ///</summary>
        IListProjectsPaginator ListProjects(ListProjectsRequest request);
    }
}
#endif