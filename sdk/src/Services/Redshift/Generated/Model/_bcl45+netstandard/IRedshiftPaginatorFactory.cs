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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Paginators for the Redshift service
    ///</summary>
    public interface IRedshiftPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeClusterDbRevisions operation
        ///</summary>
        IDescribeClusterDbRevisionsPaginator DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterParameterGroups operation
        ///</summary>
        IDescribeClusterParameterGroupsPaginator DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterParameters operation
        ///</summary>
        IDescribeClusterParametersPaginator DescribeClusterParameters(DescribeClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Paginator for DescribeClusterSecurityGroups operation
        ///</summary>
        IDescribeClusterSecurityGroupsPaginator DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterSnapshots operation
        ///</summary>
        IDescribeClusterSnapshotsPaginator DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterSubnetGroups operation
        ///</summary>
        IDescribeClusterSubnetGroupsPaginator DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterTracks operation
        ///</summary>
        IDescribeClusterTracksPaginator DescribeClusterTracks(DescribeClusterTracksRequest request);

        /// <summary>
        /// Paginator for DescribeClusterVersions operation
        ///</summary>
        IDescribeClusterVersionsPaginator DescribeClusterVersions(DescribeClusterVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeDefaultClusterParameters operation
        ///</summary>
        IDescribeDefaultClusterParametersPaginator DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeHsmClientCertificates operation
        ///</summary>
        IDescribeHsmClientCertificatesPaginator DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeHsmConfigurations operation
        ///</summary>
        IDescribeHsmConfigurationsPaginator DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeNodeConfigurationOptions operation
        ///</summary>
        IDescribeNodeConfigurationOptionsPaginator DescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableClusterOptions operation
        ///</summary>
        IDescribeOrderableClusterOptionsPaginator DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodeOfferings operation
        ///</summary>
        IDescribeReservedNodeOfferingsPaginator DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodes operation
        ///</summary>
        IDescribeReservedNodesPaginator DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledActions operation
        ///</summary>
        IDescribeScheduledActionsPaginator DescribeScheduledActions(DescribeScheduledActionsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshotCopyGrants operation
        ///</summary>
        IDescribeSnapshotCopyGrantsPaginator DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshotSchedules operation
        ///</summary>
        IDescribeSnapshotSchedulesPaginator DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request);

        /// <summary>
        /// Paginator for DescribeTableRestoreStatus operation
        ///</summary>
        IDescribeTableRestoreStatusPaginator DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for DescribeUsageLimits operation
        ///</summary>
        IDescribeUsageLimitsPaginator DescribeUsageLimits(DescribeUsageLimitsRequest request);

        /// <summary>
        /// Paginator for GetReservedNodeExchangeOfferings operation
        ///</summary>
        IGetReservedNodeExchangeOfferingsPaginator GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request);
    }
}
#endif