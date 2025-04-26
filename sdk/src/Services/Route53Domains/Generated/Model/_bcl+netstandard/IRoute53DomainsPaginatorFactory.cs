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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Paginators for the Route53Domains service
    ///</summary>
    public interface IRoute53DomainsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextPageMarker" }
        )]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListOperations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextPageMarker" }
        )]
        IListOperationsPaginator ListOperations(ListOperationsRequest request);

        /// <summary>
        /// Paginator for ListPrices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextPageMarker" }
        )]
        IListPricesPaginator ListPrices(ListPricesRequest request);

        /// <summary>
        /// Paginator for ViewBilling operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextPageMarker" }
        )]
        IViewBillingPaginator ViewBilling(ViewBillingRequest request);
    }
}