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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Paginators for the MPA service
    ///</summary>
    public class MPAPaginatorFactory : IMPAPaginatorFactory
    {
        private readonly IAmazonMPA client;

        internal MPAPaginatorFactory(IAmazonMPA client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApprovalTeams operation
        ///</summary>
        public IListApprovalTeamsPaginator ListApprovalTeams(ListApprovalTeamsRequest request) 
        {
            return new ListApprovalTeamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIdentitySources operation
        ///</summary>
        public IListIdentitySourcesPaginator ListIdentitySources(ListIdentitySourcesRequest request) 
        {
            return new ListIdentitySourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicies operation
        ///</summary>
        public IListPoliciesPaginator ListPolicies(ListPoliciesRequest request) 
        {
            return new ListPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPolicyVersions operation
        ///</summary>
        public IListPolicyVersionsPaginator ListPolicyVersions(ListPolicyVersionsRequest request) 
        {
            return new ListPolicyVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourcePolicies operation
        ///</summary>
        public IListResourcePoliciesPaginator ListResourcePolicies(ListResourcePoliciesRequest request) 
        {
            return new ListResourcePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }
    }
}