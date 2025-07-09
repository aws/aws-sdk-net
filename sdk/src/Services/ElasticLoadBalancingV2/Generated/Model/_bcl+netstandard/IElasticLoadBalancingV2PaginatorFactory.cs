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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Paginators for the ElasticLoadBalancingV2 service
    ///</summary>
    public interface IElasticLoadBalancingV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeListenerCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeListenerCertificatesPaginator DescribeListenerCertificates(DescribeListenerCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeListeners operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeListenersPaginator DescribeListeners(DescribeListenersRequest request);

        /// <summary>
        /// Paginator for DescribeLoadBalancers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeLoadBalancersPaginator DescribeLoadBalancers(DescribeLoadBalancersRequest request);

        /// <summary>
        /// Paginator for DescribeRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeRulesPaginator DescribeRules(DescribeRulesRequest request);

        /// <summary>
        /// Paginator for DescribeTargetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeTargetGroupsPaginator DescribeTargetGroups(DescribeTargetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeTrustStoreAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeTrustStoreAssociationsPaginator DescribeTrustStoreAssociations(DescribeTrustStoreAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeTrustStoreRevocations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeTrustStoreRevocationsPaginator DescribeTrustStoreRevocations(DescribeTrustStoreRevocationsRequest request);

        /// <summary>
        /// Paginator for DescribeTrustStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "PageSize",
            OutputToken = new[] { "NextMarker" }
        )]
        IDescribeTrustStoresPaginator DescribeTrustStores(DescribeTrustStoresRequest request);
    }
}