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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Pricing.Model
{
    /// <summary>
    /// Paginators for the Pricing service
    ///</summary>
    public class PricingPaginatorFactory : IPricingPaginatorFactory
    {
        private readonly IAmazonPricing client;

        internal PricingPaginatorFactory(IAmazonPricing client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeServices operation
        ///</summary>
        public IDescribeServicesPaginator DescribeServices(DescribeServicesRequest request) 
        {
            return new DescribeServicesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAttributeValues operation
        ///</summary>
        public IGetAttributeValuesPaginator GetAttributeValues(GetAttributeValuesRequest request) 
        {
            return new GetAttributeValuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetProducts operation
        ///</summary>
        public IGetProductsPaginator GetProducts(GetProductsRequest request) 
        {
            return new GetProductsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPriceLists operation
        ///</summary>
        public IListPriceListsPaginator ListPriceLists(ListPriceListsRequest request) 
        {
            return new ListPriceListsPaginator(this.client, request);
        }
    }
}