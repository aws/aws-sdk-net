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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Paginators for the PaymentCryptography service
    ///</summary>
    public interface IPaymentCryptographyPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAliases operation
        ///</summary>
        IListAliasesPaginator ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Paginator for ListKeys operation
        ///</summary>
        IListKeysPaginator ListKeys(ListKeysRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}