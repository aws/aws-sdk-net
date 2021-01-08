#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Paginators for the RDS service
    ///</summary>
    public class RDSPaginatorFactory : IRDSPaginatorFactory
    {
        private readonly IAmazonRDS client;

        internal RDSPaginatorFactory(IAmazonRDS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        ///</summary>
        public IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request) 
        {
            return new DescribeDBEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        public IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request) 
        {
            return new DescribeDBInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        public IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request) 
        {
            return new DescribeDBParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        public IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request) 
        {
            return new DescribeDBParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSecurityGroups operation
        ///</summary>
        public IDescribeDBSecurityGroupsPaginator DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request) 
        {
            return new DescribeDBSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSnapshots operation
        ///</summary>
        public IDescribeDBSnapshotsPaginator DescribeDBSnapshots(DescribeDBSnapshotsRequest request) 
        {
            return new DescribeDBSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        public IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request) 
        {
            return new DescribeDBSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        public IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request) 
        {
            return new DescribeEngineDefaultParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        public IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request) 
        {
            return new DescribeEventSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOptionGroupOptions operation
        ///</summary>
        public IDescribeOptionGroupOptionsPaginator DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request) 
        {
            return new DescribeOptionGroupOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOptionGroups operation
        ///</summary>
        public IDescribeOptionGroupsPaginator DescribeOptionGroups(DescribeOptionGroupsRequest request) 
        {
            return new DescribeOptionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        public IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request) 
        {
            return new DescribeOrderableDBInstanceOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedDBInstances operation
        ///</summary>
        public IDescribeReservedDBInstancesPaginator DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request) 
        {
            return new DescribeReservedDBInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedDBInstancesOfferings operation
        ///</summary>
        public IDescribeReservedDBInstancesOfferingsPaginator DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request) 
        {
            return new DescribeReservedDBInstancesOfferingsPaginator(this.client, request);
        }
    }
}
#endif