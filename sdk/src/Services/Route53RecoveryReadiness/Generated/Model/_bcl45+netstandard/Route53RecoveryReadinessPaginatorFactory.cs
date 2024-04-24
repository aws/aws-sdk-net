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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Paginators for the Route53RecoveryReadiness service
    ///</summary>
    public class Route53RecoveryReadinessPaginatorFactory : IRoute53RecoveryReadinessPaginatorFactory
    {
        private readonly IAmazonRoute53RecoveryReadiness client;

        internal Route53RecoveryReadinessPaginatorFactory(IAmazonRoute53RecoveryReadiness client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetCellReadinessSummary operation
        ///</summary>
        public IGetCellReadinessSummaryPaginator GetCellReadinessSummary(GetCellReadinessSummaryRequest request) 
        {
            return new GetCellReadinessSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetReadinessCheckResourceStatus operation
        ///</summary>
        public IGetReadinessCheckResourceStatusPaginator GetReadinessCheckResourceStatus(GetReadinessCheckResourceStatusRequest request) 
        {
            return new GetReadinessCheckResourceStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetReadinessCheckStatus operation
        ///</summary>
        public IGetReadinessCheckStatusPaginator GetReadinessCheckStatus(GetReadinessCheckStatusRequest request) 
        {
            return new GetReadinessCheckStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetRecoveryGroupReadinessSummary operation
        ///</summary>
        public IGetRecoveryGroupReadinessSummaryPaginator GetRecoveryGroupReadinessSummary(GetRecoveryGroupReadinessSummaryRequest request) 
        {
            return new GetRecoveryGroupReadinessSummaryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCells operation
        ///</summary>
        public IListCellsPaginator ListCells(ListCellsRequest request) 
        {
            return new ListCellsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCrossAccountAuthorizations operation
        ///</summary>
        public IListCrossAccountAuthorizationsPaginator ListCrossAccountAuthorizations(ListCrossAccountAuthorizationsRequest request) 
        {
            return new ListCrossAccountAuthorizationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReadinessChecks operation
        ///</summary>
        public IListReadinessChecksPaginator ListReadinessChecks(ListReadinessChecksRequest request) 
        {
            return new ListReadinessChecksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecoveryGroups operation
        ///</summary>
        public IListRecoveryGroupsPaginator ListRecoveryGroups(ListRecoveryGroupsRequest request) 
        {
            return new ListRecoveryGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListResourceSets operation
        ///</summary>
        public IListResourceSetsPaginator ListResourceSets(ListResourceSetsRequest request) 
        {
            return new ListResourceSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRules operation
        ///</summary>
        public IListRulesPaginator ListRules(ListRulesRequest request) 
        {
            return new ListRulesPaginator(this.client, request);
        }
    }
}