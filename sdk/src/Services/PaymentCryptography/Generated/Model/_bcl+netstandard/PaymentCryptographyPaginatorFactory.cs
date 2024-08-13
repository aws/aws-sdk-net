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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Paginators for the PaymentCryptography service
    ///</summary>
    public class PaymentCryptographyPaginatorFactory : IPaymentCryptographyPaginatorFactory
    {
        private readonly IAmazonPaymentCryptography client;

        internal PaymentCryptographyPaginatorFactory(IAmazonPaymentCryptography client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        public IListAliasesPaginator ListAliases(ListAliasesRequest request) 
        {
            return new ListAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeys operation
        ///</summary>
        public IListKeysPaginator ListKeys(ListKeysRequest request) 
        {
            return new ListKeysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}