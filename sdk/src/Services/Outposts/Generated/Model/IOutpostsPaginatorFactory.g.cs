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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Paginators for the Outposts service
    /// </summary>
    public interface IOutpostsPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetOutpostBillingInformation operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetOutpostBillingInformationPaginator GetOutpostBillingInformation(GetOutpostBillingInformationRequest request);

        /// <summary>
        /// Paginator for GetOutpostInstanceTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetOutpostInstanceTypesPaginator GetOutpostInstanceTypes(GetOutpostInstanceTypesRequest request);

        /// <summary>
        /// Paginator for GetOutpostSupportedInstanceTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetOutpostSupportedInstanceTypesPaginator GetOutpostSupportedInstanceTypes(GetOutpostSupportedInstanceTypesRequest request);

        /// <summary>
        /// Paginator for ListAssetInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetInstancesPaginator ListAssetInstances(ListAssetInstancesRequest request);

        /// <summary>
        /// Paginator for ListAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssetsPaginator ListAssets(ListAssetsRequest request);

        /// <summary>
        /// Paginator for ListBlockingInstancesForCapacityTask operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBlockingInstancesForCapacityTaskPaginator ListBlockingInstancesForCapacityTask(ListBlockingInstancesForCapacityTaskRequest request);

        /// <summary>
        /// Paginator for ListCapacityTasks operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCapacityTasksPaginator ListCapacityTasks(ListCapacityTasksRequest request);

        /// <summary>
        /// Paginator for ListCatalogItems operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListCatalogItemsPaginator ListCatalogItems(ListCatalogItemsRequest request);

        /// <summary>
        /// Paginator for ListOrderableInstanceTypes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOrderableInstanceTypesPaginator ListOrderableInstanceTypes(ListOrderableInstanceTypesRequest request);

        /// <summary>
        /// Paginator for ListOrders operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOrdersPaginator ListOrders(ListOrdersRequest request);

        /// <summary>
        /// Paginator for ListOutposts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListOutpostsPaginator ListOutposts(ListOutpostsRequest request);

        /// <summary>
        /// Paginator for ListQuotes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQuotesPaginator ListQuotes(ListQuotesRequest request);

        /// <summary>
        /// Paginator for ListSites operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSitesPaginator ListSites(ListSitesRequest request);
    }
}
