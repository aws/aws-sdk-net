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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IDescribePortfolioSharesPaginator DescribePortfolioShares(DescribePortfolioSharesRequest request);

        /// <summary>
        /// Paginator for GetProvisionedProductOutputs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IGetProvisionedProductOutputsPaginator GetProvisionedProductOutputs(GetProvisionedProductOutputsRequest request);

        /// <summary>
        /// Paginator for ListAcceptedPortfolioShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListAcceptedPortfolioSharesPaginator ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request);

        /// <summary>
        /// Paginator for ListBudgetsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListBudgetsForResourcePaginator ListBudgetsForResource(ListBudgetsForResourceRequest request);

        /// <summary>
        /// Paginator for ListConstraintsForPortfolio operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListConstraintsForPortfolioPaginator ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request);

        /// <summary>
        /// Paginator for ListLaunchPaths operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListLaunchPathsPaginator ListLaunchPaths(ListLaunchPathsRequest request);

        /// <summary>
        /// Paginator for ListOrganizationPortfolioAccess operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListOrganizationPortfolioAccessPaginator ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request);

        /// <summary>
        /// Paginator for ListPortfolioAccess operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListPortfolioAccessPaginator ListPortfolioAccess(ListPortfolioAccessRequest request);

        /// <summary>
        /// Paginator for ListPortfolios operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListPortfoliosPaginator ListPortfolios(ListPortfoliosRequest request);

        /// <summary>
        /// Paginator for ListPortfoliosForProduct operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListPortfoliosForProductPaginator ListPortfoliosForProduct(ListPortfoliosForProductRequest request);

        /// <summary>
        /// Paginator for ListPrincipalsForPortfolio operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListPrincipalsForPortfolioPaginator ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request);

        /// <summary>
        /// Paginator for ListProvisioningArtifactsForServiceAction operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListProvisioningArtifactsForServiceActionPaginator ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request);

        /// <summary>
        /// Paginator for ListResourcesForTagOption operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "PageToken" }
        )]
        IListResourcesForTagOptionPaginator ListResourcesForTagOption(ListResourcesForTagOptionRequest request);

        /// <summary>
        /// Paginator for ListServiceActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListServiceActionsPaginator ListServiceActions(ListServiceActionsRequest request);

        /// <summary>
        /// Paginator for ListServiceActionsForProvisioningArtifact operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        IListServiceActionsForProvisioningArtifactPaginator ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request);

        /// <summary>
        /// Paginator for ListTagOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "PageToken" }
        )]
        IListTagOptionsPaginator ListTagOptions(ListTagOptionsRequest request);

        /// <summary>
        /// Paginator for SearchProducts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        ISearchProductsPaginator SearchProducts(SearchProductsRequest request);

        /// <summary>
        /// Paginator for SearchProductsAsAdmin operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        ISearchProductsAsAdminPaginator SearchProductsAsAdmin(SearchProductsAsAdminRequest request);

        /// <summary>
        /// Paginator for SearchProvisionedProducts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "PageToken" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextPageToken" }
        )]
        ISearchProvisionedProductsPaginator SearchProvisionedProducts(SearchProvisionedProductsRequest request);
    }
}