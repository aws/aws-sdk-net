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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Paginators for the OAM service
    ///</summary>
    public class OAMPaginatorFactory : IOAMPaginatorFactory
    {
        private readonly IAmazonOAM client;

        internal OAMPaginatorFactory(IAmazonOAM client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAttachedLinks operation
        ///</summary>
        public IListAttachedLinksPaginator ListAttachedLinks(ListAttachedLinksRequest request) 
        {
            return new ListAttachedLinksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLinks operation
        ///</summary>
        public IListLinksPaginator ListLinks(ListLinksRequest request) 
        {
            return new ListLinksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSinks operation
        ///</summary>
        public IListSinksPaginator ListSinks(ListSinksRequest request) 
        {
            return new ListSinksPaginator(this.client, request);
        }
    }
}