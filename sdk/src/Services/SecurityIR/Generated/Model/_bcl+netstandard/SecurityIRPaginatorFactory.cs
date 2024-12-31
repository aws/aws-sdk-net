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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Paginators for the SecurityIR service
    ///</summary>
    public class SecurityIRPaginatorFactory : ISecurityIRPaginatorFactory
    {
        private readonly IAmazonSecurityIR client;

        internal SecurityIRPaginatorFactory(IAmazonSecurityIR client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCaseEdits operation
        ///</summary>
        public IListCaseEditsPaginator ListCaseEdits(ListCaseEditsRequest request) 
        {
            return new ListCaseEditsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCases operation
        ///</summary>
        public IListCasesPaginator ListCases(ListCasesRequest request) 
        {
            return new ListCasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListComments operation
        ///</summary>
        public IListCommentsPaginator ListComments(ListCommentsRequest request) 
        {
            return new ListCommentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemberships operation
        ///</summary>
        public IListMembershipsPaginator ListMemberships(ListMembershipsRequest request) 
        {
            return new ListMembershipsPaginator(this.client, request);
        }
    }
}