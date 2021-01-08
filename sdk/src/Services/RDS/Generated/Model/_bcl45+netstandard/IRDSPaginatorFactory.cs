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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Paginators for the RDS service
    ///</summary>
    public interface IRDSPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeDBEngineVersions operation
        ///</summary>
        IDescribeDBEngineVersionsPaginator DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeDBInstances operation
        ///</summary>
        IDescribeDBInstancesPaginator DescribeDBInstances(DescribeDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameterGroups operation
        ///</summary>
        IDescribeDBParameterGroupsPaginator DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBParameters operation
        ///</summary>
        IDescribeDBParametersPaginator DescribeDBParameters(DescribeDBParametersRequest request);

        /// <summary>
        /// Paginator for DescribeDBSecurityGroups operation
        ///</summary>
        IDescribeDBSecurityGroupsPaginator DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSnapshots operation
        ///</summary>
        IDescribeDBSnapshotsPaginator DescribeDBSnapshots(DescribeDBSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeEngineDefaultParameters operation
        ///</summary>
        IDescribeEngineDefaultParametersPaginator DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeOptionGroupOptions operation
        ///</summary>
        IDescribeOptionGroupOptionsPaginator DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeOptionGroups operation
        ///</summary>
        IDescribeOptionGroupsPaginator DescribeOptionGroups(DescribeOptionGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedDBInstances operation
        ///</summary>
        IDescribeReservedDBInstancesPaginator DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeReservedDBInstancesOfferings operation
        ///</summary>
        IDescribeReservedDBInstancesOfferingsPaginator DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request);
    }
}
#endif