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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Paginators for the AWSHealth service
    ///</summary>
    public class AWSHealthPaginatorFactory : IAWSHealthPaginatorFactory
    {
        private readonly IAmazonAWSHealth client;

        internal AWSHealthPaginatorFactory(IAmazonAWSHealth client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAffectedAccountsForOrganization operation
        ///</summary>
        public IDescribeAffectedAccountsForOrganizationPaginator DescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request) 
        {
            return new DescribeAffectedAccountsForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAffectedEntities operation
        ///</summary>
        public IDescribeAffectedEntitiesPaginator DescribeAffectedEntities(DescribeAffectedEntitiesRequest request) 
        {
            return new DescribeAffectedEntitiesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAffectedEntitiesForOrganization operation
        ///</summary>
        public IDescribeAffectedEntitiesForOrganizationPaginator DescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request) 
        {
            return new DescribeAffectedEntitiesForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEventAggregates operation
        ///</summary>
        public IDescribeEventAggregatesPaginator DescribeEventAggregates(DescribeEventAggregatesRequest request) 
        {
            return new DescribeEventAggregatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEventsForOrganization operation
        ///</summary>
        public IDescribeEventsForOrganizationPaginator DescribeEventsForOrganization(DescribeEventsForOrganizationRequest request) 
        {
            return new DescribeEventsForOrganizationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEventTypes operation
        ///</summary>
        public IDescribeEventTypesPaginator DescribeEventTypes(DescribeEventTypesRequest request) 
        {
            return new DescribeEventTypesPaginator(this.client, request);
        }
    }
}