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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Paginators for the AutoScaling service
    /// </summary>
    public interface IAutoScalingPaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeAutoScalingGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeAutoScalingGroupsPaginator DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeAutoScalingInstances operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeAutoScalingInstancesPaginator DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceRefreshes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeInstanceRefreshesPaginator DescribeInstanceRefreshes(DescribeInstanceRefreshesRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeLaunchConfigurationsPaginator DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeLoadBalancerTargetGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeLoadBalancerTargetGroupsPaginator DescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeLoadBalancers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeLoadBalancersPaginator DescribeLoadBalancers(DescribeLoadBalancersRequest request);

        /// <summary>
        /// Paginator for DescribeNotificationConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeNotificationConfigurationsPaginator DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribePolicies operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribePoliciesPaginator DescribePolicies(DescribePoliciesRequest request);

        /// <summary>
        /// Paginator for DescribeScalingActivities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeScalingActivitiesPaginator DescribeScalingActivities(DescribeScalingActivitiesRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeScheduledActionsPaginator DescribeScheduledActions(DescribeScheduledActionsRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeTrafficSourcesPaginator DescribeTrafficSources(DescribeTrafficSourcesRequest request);

        /// <summary>
        /// Paginator for DescribeWarmPool operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxRecords", OutputToken = ["NextToken"])]
        IDescribeWarmPoolPaginator DescribeWarmPool(DescribeWarmPoolRequest request);
    }
}
