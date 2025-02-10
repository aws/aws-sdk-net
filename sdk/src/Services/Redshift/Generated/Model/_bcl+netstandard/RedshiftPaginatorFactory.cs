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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Paginators for the Redshift service
    ///</summary>
    public class RedshiftPaginatorFactory : IRedshiftPaginatorFactory
    {
        private readonly IAmazonRedshift client;

        internal RedshiftPaginatorFactory(IAmazonRedshift client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeClusterDbRevisions operation
        ///</summary>
        public IDescribeClusterDbRevisionsPaginator DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request) 
        {
            return new DescribeClusterDbRevisionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterParameterGroups operation
        ///</summary>
        public IDescribeClusterParameterGroupsPaginator DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request) 
        {
            return new DescribeClusterParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterParameters operation
        ///</summary>
        public IDescribeClusterParametersPaginator DescribeClusterParameters(DescribeClusterParametersRequest request) 
        {
            return new DescribeClusterParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusters operation
        ///</summary>
        public IDescribeClustersPaginator DescribeClusters(DescribeClustersRequest request) 
        {
            return new DescribeClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterSecurityGroups operation
        ///</summary>
        public IDescribeClusterSecurityGroupsPaginator DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request) 
        {
            return new DescribeClusterSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterSnapshots operation
        ///</summary>
        public IDescribeClusterSnapshotsPaginator DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request) 
        {
            return new DescribeClusterSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterSubnetGroups operation
        ///</summary>
        public IDescribeClusterSubnetGroupsPaginator DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request) 
        {
            return new DescribeClusterSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterTracks operation
        ///</summary>
        public IDescribeClusterTracksPaginator DescribeClusterTracks(DescribeClusterTracksRequest request) 
        {
            return new DescribeClusterTracksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClusterVersions operation
        ///</summary>
        public IDescribeClusterVersionsPaginator DescribeClusterVersions(DescribeClusterVersionsRequest request) 
        {
            return new DescribeClusterVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCustomDomainAssociations operation
        ///</summary>
        public IDescribeCustomDomainAssociationsPaginator DescribeCustomDomainAssociations(DescribeCustomDomainAssociationsRequest request) 
        {
            return new DescribeCustomDomainAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataShares operation
        ///</summary>
        public IDescribeDataSharesPaginator DescribeDataShares(DescribeDataSharesRequest request) 
        {
            return new DescribeDataSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataSharesForConsumer operation
        ///</summary>
        public IDescribeDataSharesForConsumerPaginator DescribeDataSharesForConsumer(DescribeDataSharesForConsumerRequest request) 
        {
            return new DescribeDataSharesForConsumerPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDataSharesForProducer operation
        ///</summary>
        public IDescribeDataSharesForProducerPaginator DescribeDataSharesForProducer(DescribeDataSharesForProducerRequest request) 
        {
            return new DescribeDataSharesForProducerPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDefaultClusterParameters operation
        ///</summary>
        public IDescribeDefaultClusterParametersPaginator DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request) 
        {
            return new DescribeDefaultClusterParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEndpointAccess operation
        ///</summary>
        public IDescribeEndpointAccessPaginator DescribeEndpointAccess(DescribeEndpointAccessRequest request) 
        {
            return new DescribeEndpointAccessPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEndpointAuthorization operation
        ///</summary>
        public IDescribeEndpointAuthorizationPaginator DescribeEndpointAuthorization(DescribeEndpointAuthorizationRequest request) 
        {
            return new DescribeEndpointAuthorizationPaginator(this.client, request);
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
        /// Paginator for DescribeHsmClientCertificates operation
        ///</summary>
        public IDescribeHsmClientCertificatesPaginator DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request) 
        {
            return new DescribeHsmClientCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeHsmConfigurations operation
        ///</summary>
        public IDescribeHsmConfigurationsPaginator DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request) 
        {
            return new DescribeHsmConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInboundIntegrations operation
        ///</summary>
        public IDescribeInboundIntegrationsPaginator DescribeInboundIntegrations(DescribeInboundIntegrationsRequest request) 
        {
            return new DescribeInboundIntegrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIntegrations operation
        ///</summary>
        public IDescribeIntegrationsPaginator DescribeIntegrations(DescribeIntegrationsRequest request) 
        {
            return new DescribeIntegrationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNodeConfigurationOptions operation
        ///</summary>
        public IDescribeNodeConfigurationOptionsPaginator DescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request) 
        {
            return new DescribeNodeConfigurationOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrderableClusterOptions operation
        ///</summary>
        public IDescribeOrderableClusterOptionsPaginator DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request) 
        {
            return new DescribeOrderableClusterOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRedshiftIdcApplications operation
        ///</summary>
        public IDescribeRedshiftIdcApplicationsPaginator DescribeRedshiftIdcApplications(DescribeRedshiftIdcApplicationsRequest request) 
        {
            return new DescribeRedshiftIdcApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedNodeExchangeStatus operation
        ///</summary>
        public IDescribeReservedNodeExchangeStatusPaginator DescribeReservedNodeExchangeStatus(DescribeReservedNodeExchangeStatusRequest request) 
        {
            return new DescribeReservedNodeExchangeStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedNodeOfferings operation
        ///</summary>
        public IDescribeReservedNodeOfferingsPaginator DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request) 
        {
            return new DescribeReservedNodeOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedNodes operation
        ///</summary>
        public IDescribeReservedNodesPaginator DescribeReservedNodes(DescribeReservedNodesRequest request) 
        {
            return new DescribeReservedNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScheduledActions operation
        ///</summary>
        public IDescribeScheduledActionsPaginator DescribeScheduledActions(DescribeScheduledActionsRequest request) 
        {
            return new DescribeScheduledActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshotCopyGrants operation
        ///</summary>
        public IDescribeSnapshotCopyGrantsPaginator DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request) 
        {
            return new DescribeSnapshotCopyGrantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshotSchedules operation
        ///</summary>
        public IDescribeSnapshotSchedulesPaginator DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request) 
        {
            return new DescribeSnapshotSchedulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTableRestoreStatus operation
        ///</summary>
        public IDescribeTableRestoreStatusPaginator DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request) 
        {
            return new DescribeTableRestoreStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        public IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request) 
        {
            return new DescribeTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeUsageLimits operation
        ///</summary>
        public IDescribeUsageLimitsPaginator DescribeUsageLimits(DescribeUsageLimitsRequest request) 
        {
            return new DescribeUsageLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetReservedNodeExchangeConfigurationOptions operation
        ///</summary>
        public IGetReservedNodeExchangeConfigurationOptionsPaginator GetReservedNodeExchangeConfigurationOptions(GetReservedNodeExchangeConfigurationOptionsRequest request) 
        {
            return new GetReservedNodeExchangeConfigurationOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetReservedNodeExchangeOfferings operation
        ///</summary>
        public IGetReservedNodeExchangeOfferingsPaginator GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request) 
        {
            return new GetReservedNodeExchangeOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendations operation
        ///</summary>
        public IListRecommendationsPaginator ListRecommendations(ListRecommendationsRequest request) 
        {
            return new ListRecommendationsPaginator(this.client, request);
        }
    }
}