#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        IDescribeAffectedAccountsForOrganizationPaginator DescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request);

        /// <summary>
        /// Paginator for DescribeAffectedEntities operation
        ///</summary>
        IDescribeAffectedEntitiesPaginator DescribeAffectedEntities(DescribeAffectedEntitiesRequest request);

        /// <summary>
        /// Paginator for DescribeAffectedEntitiesForOrganization operation
        ///</summary>
        IDescribeAffectedEntitiesForOrganizationPaginator DescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request);

        /// <summary>
        /// Paginator for DescribeEventAggregates operation
        ///</summary>
        IDescribeEventAggregatesPaginator DescribeEventAggregates(DescribeEventAggregatesRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventsForOrganization operation
        ///</summary>
        IDescribeEventsForOrganizationPaginator DescribeEventsForOrganization(DescribeEventsForOrganizationRequest request);

        /// <summary>
        /// Paginator for DescribeEventTypes operation
        ///</summary>
        IDescribeEventTypesPaginator DescribeEventTypes(DescribeEventTypesRequest request);
    }
}
#endif