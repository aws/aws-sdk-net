#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Paginators for the Transfer service
    ///</summary>
    public class TransferPaginatorFactory : ITransferPaginatorFactory
    {
        private readonly IAmazonTransfer client;

        internal TransferPaginatorFactory(IAmazonTransfer client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListSecurityPolicies operation
        ///</summary>
        public IListSecurityPoliciesPaginator ListSecurityPolicies(ListSecurityPoliciesRequest request) 
        {
            return new ListSecurityPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListServers operation
        ///</summary>
        public IListServersPaginator ListServers(ListServersRequest request) 
        {
            return new ListServersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        public IListUsersPaginator ListUsers(ListUsersRequest request) 
        {
            return new ListUsersPaginator(this.client, request);
        }
    }
}
#endif