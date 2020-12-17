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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Paginators for the ServiceCatalog service
    ///</summary>
    public interface IServiceCatalogPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribePortfolioShares operation
        ///</summary>
        IDescribePortfolioSharesPaginator DescribePortfolioShares(DescribePortfolioSharesRequest request);

        /// <summary>
        /// Paginator for GetProvisionedProductOutputs operation
        ///</summary>
        IGetProvisionedProductOutputsPaginator GetProvisionedProductOutputs(GetProvisionedProductOutputsRequest request);

        /// <summary>
        /// Paginator for ListAcceptedPortfolioShares operation
        ///</summary>
        IListAcceptedPortfolioSharesPaginator ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request);

        /// <summary>
        /// Paginator for ListBudgetsForResource operation
        ///</summary>
        IListBudgetsForResourcePaginator ListBudgetsForResource(ListBudgetsForResourceRequest request);

        /// <summary>
        /// Paginator for ListConstraintsForPortfolio operation
        ///</summary>
        IListConstraintsForPortfolioPaginator ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request);

        /// <summary>
        /// Paginator for ListLaunchPaths operation
        ///</summary>
        IListLaunchPathsPaginator ListLaunchPaths(ListLaunchPathsRequest request);

        /// <summary>
        /// Paginator for ListOrganizationPortfolioAccess operation
        ///</summary>
        IListOrganizationPortfolioAccessPaginator ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request);

        /// <summary>
        /// Paginator for ListPortfolioAccess operation
        ///</summary>
        IListPortfolioAccessPaginator ListPortfolioAccess(ListPortfolioAccessRequest request);

        /// <summary>
        /// Paginator for ListPortfolios operation
        ///</summary>
        IListPortfoliosPaginator ListPortfolios(ListPortfoliosRequest request);

        /// <summary>
        /// Paginator for ListPortfoliosForProduct operation
        ///</summary>
        IListPortfoliosForProductPaginator ListPortfoliosForProduct(ListPortfoliosForProductRequest request);

        /// <summary>
        /// Paginator for ListPrincipalsForPortfolio operation
        ///</summary>
        IListPrincipalsForPortfolioPaginator ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request);

        /// <summary>
        /// Paginator for ListProvisioningArtifactsForServiceAction operation
        ///</summary>
        IListProvisioningArtifactsForServiceActionPaginator ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request);

        /// <summary>
        /// Paginator for ListResourcesForTagOption operation
        ///</summary>
        IListResourcesForTagOptionPaginator ListResourcesForTagOption(ListResourcesForTagOptionRequest request);

        /// <summary>
        /// Paginator for ListServiceActions operation
        ///</summary>
        IListServiceActionsPaginator ListServiceActions(ListServiceActionsRequest request);

        /// <summary>
        /// Paginator for ListServiceActionsForProvisioningArtifact operation
        ///</summary>
        IListServiceActionsForProvisioningArtifactPaginator ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request);

        /// <summary>
        /// Paginator for ListTagOptions operation
        ///</summary>
        IListTagOptionsPaginator ListTagOptions(ListTagOptionsRequest request);

        /// <summary>
        /// Paginator for SearchProducts operation
        ///</summary>
        ISearchProductsPaginator SearchProducts(SearchProductsRequest request);

        /// <summary>
        /// Paginator for SearchProductsAsAdmin operation
        ///</summary>
        ISearchProductsAsAdminPaginator SearchProductsAsAdmin(SearchProductsAsAdminRequest request);

        /// <summary>
        /// Paginator for SearchProvisionedProducts operation
        ///</summary>
        ISearchProvisionedProductsPaginator SearchProvisionedProducts(SearchProvisionedProductsRequest request);
    }
}
#endif