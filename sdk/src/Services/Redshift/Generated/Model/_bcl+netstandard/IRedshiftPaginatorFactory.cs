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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterDbRevisionsPaginator DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterParameterGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterParameterGroupsPaginator DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterParametersPaginator DescribeClusterParameters(DescribeClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Paginator for DescribeClusterSecurityGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterSecurityGroupsPaginator DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterSnapshotsPaginator DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterSubnetGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterSubnetGroupsPaginator DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeClusterTracks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterTracksPaginator DescribeClusterTracks(DescribeClusterTracksRequest request);

        /// <summary>
        /// Paginator for DescribeClusterVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeClusterVersionsPaginator DescribeClusterVersions(DescribeClusterVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeCustomDomainAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeCustomDomainAssociationsPaginator DescribeCustomDomainAssociations(DescribeCustomDomainAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeDataShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDataSharesPaginator DescribeDataShares(DescribeDataSharesRequest request);

        /// <summary>
        /// Paginator for DescribeDataSharesForConsumer operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDataSharesForConsumerPaginator DescribeDataSharesForConsumer(DescribeDataSharesForConsumerRequest request);

        /// <summary>
        /// Paginator for DescribeDataSharesForProducer operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeDataSharesForProducerPaginator DescribeDataSharesForProducer(DescribeDataSharesForProducerRequest request);

        /// <summary>
        /// Paginator for DescribeDefaultClusterParameters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "DefaultClusterParameters.Marker" }
        )]
        IDescribeDefaultClusterParametersPaginator DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request);

        /// <summary>
        /// Paginator for DescribeEndpointAccess operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEndpointAccessPaginator DescribeEndpointAccess(DescribeEndpointAccessRequest request);

        /// <summary>
        /// Paginator for DescribeEndpointAuthorization operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEndpointAuthorizationPaginator DescribeEndpointAuthorization(DescribeEndpointAuthorizationRequest request);

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Paginator for DescribeEventSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeEventSubscriptionsPaginator DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeHsmClientCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeHsmClientCertificatesPaginator DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request);

        /// <summary>
        /// Paginator for DescribeHsmConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeHsmConfigurationsPaginator DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeInboundIntegrations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeInboundIntegrationsPaginator DescribeInboundIntegrations(DescribeInboundIntegrationsRequest request);

        /// <summary>
        /// Paginator for DescribeIntegrations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeIntegrationsPaginator DescribeIntegrations(DescribeIntegrationsRequest request);

        /// <summary>
        /// Paginator for DescribeNodeConfigurationOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeNodeConfigurationOptionsPaginator DescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeOrderableClusterOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeOrderableClusterOptionsPaginator DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeRedshiftIdcApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeRedshiftIdcApplicationsPaginator DescribeRedshiftIdcApplications(DescribeRedshiftIdcApplicationsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodeExchangeStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReservedNodeExchangeStatusPaginator DescribeReservedNodeExchangeStatus(DescribeReservedNodeExchangeStatusRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodeOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReservedNodeOfferingsPaginator DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeReservedNodesPaginator DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeScheduledActionsPaginator DescribeScheduledActions(DescribeScheduledActionsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshotCopyGrants operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeSnapshotCopyGrantsPaginator DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshotSchedules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeSnapshotSchedulesPaginator DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request);

        /// <summary>
        /// Paginator for DescribeTableRestoreStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeTableRestoreStatusPaginator DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for DescribeUsageLimits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IDescribeUsageLimitsPaginator DescribeUsageLimits(DescribeUsageLimitsRequest request);

        /// <summary>
        /// Paginator for GetReservedNodeExchangeConfigurationOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IGetReservedNodeExchangeConfigurationOptionsPaginator GetReservedNodeExchangeConfigurationOptions(GetReservedNodeExchangeConfigurationOptionsRequest request);

        /// <summary>
        /// Paginator for GetReservedNodeExchangeOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IGetReservedNodeExchangeOfferingsPaginator GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request);

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "Marker" },
            LimitKey = "MaxRecords",
            OutputToken = new[] { "Marker" }
        )]
        IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request);
    }
}