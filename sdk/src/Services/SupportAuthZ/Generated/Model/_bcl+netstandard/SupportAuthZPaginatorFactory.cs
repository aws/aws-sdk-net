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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// Paginators for the SupportAuthZ service
    ///</summary>
    public class SupportAuthZPaginatorFactory : ISupportAuthZPaginatorFactory
    {
        private readonly IAmazonSupportAuthZ client;

        internal SupportAuthZPaginatorFactory(IAmazonSupportAuthZ client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListActions operation
        ///</summary>
        public IListActionsPaginator ListActions(ListActionsRequest request) 
        {
            return new ListActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSupportPermitRequests operation
        ///</summary>
        public IListSupportPermitRequestsPaginator ListSupportPermitRequests(ListSupportPermitRequestsRequest request) 
        {
            return new ListSupportPermitRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSupportPermits operation
        ///</summary>
        public IListSupportPermitsPaginator ListSupportPermits(ListSupportPermitsRequest request) 
        {
            return new ListSupportPermitsPaginator(this.client, request);
        }
    }
}