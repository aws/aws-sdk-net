#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Paginators for the FMS service
    ///</summary>
    public class FMSPaginatorFactory : IFMSPaginatorFactory
    {
        private readonly IAmazonFMS client;

        internal FMSPaginatorFactory(IAmazonFMS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListComplianceStatus operation
        ///</summary>
        public IListComplianceStatusPaginator ListComplianceStatus(ListComplianceStatusRequest request) 
        {
            return new ListComplianceStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemberAccounts operation
        ///</summary>
        public IListMemberAccountsPaginator ListMemberAccounts(ListMemberAccountsRequest request) 
        {
            return new ListMemberAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }
    }
}
#endif