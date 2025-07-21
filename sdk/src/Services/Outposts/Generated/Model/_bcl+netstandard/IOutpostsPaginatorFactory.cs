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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Paginators for the Outposts service
    ///</summary>
    public interface IOutpostsPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetOutpostBillingInformation operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetOutpostBillingInformationPaginator GetOutpostBillingInformation(GetOutpostBillingInformationRequest request);

        /// <summary>
        /// Paginator for GetOutpostInstanceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetOutpostInstanceTypesPaginator GetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request);

        /// <summary>
        /// Paginator for GetOutpostSupportedInstanceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetOutpostSupportedInstanceTypesPaginator GetOutpostSupportedInstanceTypes(GetOutpostSupportedInstanceTypesRequest request);

        /// <summary>
        /// Paginator for ListAssetInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetInstancesPaginator ListAssetInstances(ListAssetInstancesRequest request);

        /// <summary>
        /// Paginator for ListAssets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListBlockingInstancesForCapacityTask operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBlockingInstancesForCapacityTaskPaginator ListBlockingInstancesForCapacityTask(ListBlockingInstancesForCapacityTaskRequest request);

        /// <summary>
        /// Paginator for ListCapacityTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCapacityTasksPaginator ListCapacityTasks(ListCapacityTasksRequest request);

        /// <summary>
        /// Paginator for ListCatalogItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCatalogItemsPaginator ListCatalogItems(ListCatalogItemsRequest request);

        /// <summary>
        /// Paginator for ListOrders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOrdersPaginator ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Paginator for ListOutposts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListOutpostsPaginator ListOutposts(ListOutpostsRequest request);

        /// <summary>
        /// Paginator for ListSites operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSitesPaginator ListSites(ListSitesRequest request);
    }
}