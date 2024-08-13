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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Paginators for the ApplicationAutoScaling service
    ///</summary>
    public class ApplicationAutoScalingPaginatorFactory : IApplicationAutoScalingPaginatorFactory
    {
        private readonly IAmazonApplicationAutoScaling client;

        internal ApplicationAutoScalingPaginatorFactory(IAmazonApplicationAutoScaling client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeScalableTargets operation
        ///</summary>
        public IDescribeScalableTargetsPaginator DescribeScalableTargets(DescribeScalableTargetsRequest request) 
        {
            return new DescribeScalableTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScalingActivities operation
        ///</summary>
        public IDescribeScalingActivitiesPaginator DescribeScalingActivities(DescribeScalingActivitiesRequest request) 
        {
            return new DescribeScalingActivitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScalingPolicies operation
        ///</summary>
        public IDescribeScalingPoliciesPaginator DescribeScalingPolicies(DescribeScalingPoliciesRequest request) 
        {
            return new DescribeScalingPoliciesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScheduledActions operation
        ///</summary>
        public IDescribeScheduledActionsPaginator DescribeScheduledActions(DescribeScheduledActionsRequest request) 
        {
            return new DescribeScheduledActionsPaginator(this.client, request);
        }
    }
}