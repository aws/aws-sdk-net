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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Paginators for the B2bi service
    ///</summary>
    public class B2biPaginatorFactory : IB2biPaginatorFactory
    {
        private readonly IAmazonB2bi client;

        internal B2biPaginatorFactory(IAmazonB2bi client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCapabilities operation
        ///</summary>
        public IListCapabilitiesPaginator ListCapabilities(ListCapabilitiesRequest request) 
        {
            return new ListCapabilitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPartnerships operation
        ///</summary>
        public IListPartnershipsPaginator ListPartnerships(ListPartnershipsRequest request) 
        {
            return new ListPartnershipsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        public IListProfilesPaginator ListProfiles(ListProfilesRequest request) 
        {
            return new ListProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTransformers operation
        ///</summary>
        public IListTransformersPaginator ListTransformers(ListTransformersRequest request) 
        {
            return new ListTransformersPaginator(this.client, request);
        }
    }
}