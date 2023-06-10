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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Paginators for the AutoScaling service
    ///</summary>
    public class AutoScalingPaginatorFactory : IAutoScalingPaginatorFactory
    {
        private readonly IAmazonAutoScaling client;

        internal AutoScalingPaginatorFactory(IAmazonAutoScaling client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAutoScalingGroups operation
        ///</summary>
        public IDescribeAutoScalingGroupsPaginator DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request) 
        {
            return new DescribeAutoScalingGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAutoScalingInstances operation
        ///</summary>
        public IDescribeAutoScalingInstancesPaginator DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request) 
        {
            return new DescribeAutoScalingInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLaunchConfigurations operation
        ///</summary>
        public IDescribeLaunchConfigurationsPaginator DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request) 
        {
            return new DescribeLaunchConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNotificationConfigurations operation
        ///</summary>
        public IDescribeNotificationConfigurationsPaginator DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request) 
        {
            return new DescribeNotificationConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePolicies operation
        ///</summary>
        public IDescribePoliciesPaginator DescribePolicies(DescribePoliciesRequest request) 
        {
            return new DescribePoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScalingActivities operation
        ///</summary>
        public IDescribeScalingActivitiesPaginator DescribeScalingActivities(DescribeScalingActivitiesRequest request) 
        {
            return new DescribeScalingActivitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScheduledActions operation
        ///</summary>
        public IDescribeScheduledActionsPaginator DescribeScheduledActions(DescribeScheduledActionsRequest request) 
        {
            return new DescribeScheduledActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        public IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request) 
        {
            return new DescribeTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrafficSources operation
        ///</summary>
        public IDescribeTrafficSourcesPaginator DescribeTrafficSources(DescribeTrafficSourcesRequest request) 
        {
            return new DescribeTrafficSourcesPaginator(this.client, request);
        }
    }
}