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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Paginators for the ElasticLoadBalancingV2 service
    ///</summary>
    public class ElasticLoadBalancingV2PaginatorFactory : IElasticLoadBalancingV2PaginatorFactory
    {
        private readonly IAmazonElasticLoadBalancingV2 client;

        internal ElasticLoadBalancingV2PaginatorFactory(IAmazonElasticLoadBalancingV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        public IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request) 
        {
            return new DescribeAccountLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeListenerCertificates operation
        ///</summary>
        public IDescribeListenerCertificatesPaginator DescribeListenerCertificates(DescribeListenerCertificatesRequest request) 
        {
            return new DescribeListenerCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeListeners operation
        ///</summary>
        public IDescribeListenersPaginator DescribeListeners(DescribeListenersRequest request) 
        {
            return new DescribeListenersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLoadBalancers operation
        ///</summary>
        public IDescribeLoadBalancersPaginator DescribeLoadBalancers(DescribeLoadBalancersRequest request) 
        {
            return new DescribeLoadBalancersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRules operation
        ///</summary>
        public IDescribeRulesPaginator DescribeRules(DescribeRulesRequest request) 
        {
            return new DescribeRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTargetGroups operation
        ///</summary>
        public IDescribeTargetGroupsPaginator DescribeTargetGroups(DescribeTargetGroupsRequest request) 
        {
            return new DescribeTargetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrustStoreAssociations operation
        ///</summary>
        public IDescribeTrustStoreAssociationsPaginator DescribeTrustStoreAssociations(DescribeTrustStoreAssociationsRequest request) 
        {
            return new DescribeTrustStoreAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrustStoreRevocations operation
        ///</summary>
        public IDescribeTrustStoreRevocationsPaginator DescribeTrustStoreRevocations(DescribeTrustStoreRevocationsRequest request) 
        {
            return new DescribeTrustStoreRevocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrustStores operation
        ///</summary>
        public IDescribeTrustStoresPaginator DescribeTrustStores(DescribeTrustStoresRequest request) 
        {
            return new DescribeTrustStoresPaginator(this.client, request);
        }
    }
}