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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Paginators for the ServiceCatalog service
    ///</summary>
    public class ServiceCatalogPaginatorFactory : IServiceCatalogPaginatorFactory
    {
        private readonly IAmazonServiceCatalog client;

        internal ServiceCatalogPaginatorFactory(IAmazonServiceCatalog client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribePortfolioShares operation
        ///</summary>
        public IDescribePortfolioSharesPaginator DescribePortfolioShares(DescribePortfolioSharesRequest request) 
        {
            return new DescribePortfolioSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetProvisionedProductOutputs operation
        ///</summary>
        public IGetProvisionedProductOutputsPaginator GetProvisionedProductOutputs(GetProvisionedProductOutputsRequest request) 
        {
            return new GetProvisionedProductOutputsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAcceptedPortfolioShares operation
        ///</summary>
        public IListAcceptedPortfolioSharesPaginator ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request) 
        {
            return new ListAcceptedPortfolioSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBudgetsForResource operation
        ///</summary>
        public IListBudgetsForResourcePaginator ListBudgetsForResource(ListBudgetsForResourceRequest request) 
        {
            return new ListBudgetsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConstraintsForPortfolio operation
        ///</summary>
        public IListConstraintsForPortfolioPaginator ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request) 
        {
            return new ListConstraintsForPortfolioPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLaunchPaths operation
        ///</summary>
        public IListLaunchPathsPaginator ListLaunchPaths(ListLaunchPathsRequest request) 
        {
            return new ListLaunchPathsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOrganizationPortfolioAccess operation
        ///</summary>
        public IListOrganizationPortfolioAccessPaginator ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request) 
        {
            return new ListOrganizationPortfolioAccessPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPortfolioAccess operation
        ///</summary>
        public IListPortfolioAccessPaginator ListPortfolioAccess(ListPortfolioAccessRequest request) 
        {
            return new ListPortfolioAccessPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPortfolios operation
        ///</summary>
        public IListPortfoliosPaginator ListPortfolios(ListPortfoliosRequest request) 
        {
            return new ListPortfoliosPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPortfoliosForProduct operation
        ///</summary>
        public IListPortfoliosForProductPaginator ListPortfoliosForProduct(ListPortfoliosForProductRequest request) 
        {
            return new ListPortfoliosForProductPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrincipalsForPortfolio operation
        ///</summary>
        public IListPrincipalsForPortfolioPaginator ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request) 
        {
            return new ListPrincipalsForPortfolioPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProvisioningArtifactsForServiceAction operation
        ///</summary>
        public IListProvisioningArtifactsForServiceActionPaginator ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request) 
        {
            return new ListProvisioningArtifactsForServiceActionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourcesForTagOption operation
        ///</summary>
        public IListResourcesForTagOptionPaginator ListResourcesForTagOption(ListResourcesForTagOptionRequest request) 
        {
            return new ListResourcesForTagOptionPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceActions operation
        ///</summary>
        public IListServiceActionsPaginator ListServiceActions(ListServiceActionsRequest request) 
        {
            return new ListServiceActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServiceActionsForProvisioningArtifact operation
        ///</summary>
        public IListServiceActionsForProvisioningArtifactPaginator ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request) 
        {
            return new ListServiceActionsForProvisioningArtifactPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagOptions operation
        ///</summary>
        public IListTagOptionsPaginator ListTagOptions(ListTagOptionsRequest request) 
        {
            return new ListTagOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchProducts operation
        ///</summary>
        public ISearchProductsPaginator SearchProducts(SearchProductsRequest request) 
        {
            return new SearchProductsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchProductsAsAdmin operation
        ///</summary>
        public ISearchProductsAsAdminPaginator SearchProductsAsAdmin(SearchProductsAsAdminRequest request) 
        {
            return new SearchProductsAsAdminPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchProvisionedProducts operation
        ///</summary>
        public ISearchProvisionedProductsPaginator SearchProvisionedProducts(SearchProvisionedProductsRequest request) 
        {
            return new SearchProvisionedProductsPaginator(this.client, request);
        }
    }
}