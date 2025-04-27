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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Paginators for the AWSHealth service
    ///</summary>
    public interface IAWSHealthPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAffectedAccountsForOrganization operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAffectedAccountsForOrganizationPaginator DescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request);

        /// <summary>
        /// Paginator for DescribeAffectedEntities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAffectedEntitiesPaginator DescribeAffectedEntities(DescribeAffectedEntitiesRequest request);

        /// <summary>
        /// Paginator for DescribeAffectedEntitiesForOrganization operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAffectedEntitiesForOrganizationPaginator DescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request);

        /// <summary>
        /// Paginator for DescribeEventAggregates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEventAggregatesPaginator DescribeEventAggregates(DescribeEventAggregatesRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventsForOrganization operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEventsForOrganizationPaginator DescribeEventsForOrganization(DescribeEventsForOrganizationRequest request);

        /// <summary>
        /// Paginator for DescribeEventTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEventTypesPaginator DescribeEventTypes(DescribeEventTypesRequest request);
    }
}