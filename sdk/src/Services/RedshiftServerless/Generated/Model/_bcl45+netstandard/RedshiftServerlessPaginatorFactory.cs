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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Paginators for the RedshiftServerless service
    ///</summary>
    public class RedshiftServerlessPaginatorFactory : IRedshiftServerlessPaginatorFactory
    {
        private readonly IAmazonRedshiftServerless client;

        internal RedshiftServerlessPaginatorFactory(IAmazonRedshiftServerless client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListCustomDomainAssociations operation
        ///</summary>
        public IListCustomDomainAssociationsPaginator ListCustomDomainAssociations(ListCustomDomainAssociationsRequest request) 
        {
            return new ListCustomDomainAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEndpointAccess operation
        ///</summary>
        public IListEndpointAccessPaginator ListEndpointAccess(ListEndpointAccessRequest request) 
        {
            return new ListEndpointAccessPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListManagedWorkgroups operation
        ///</summary>
        public IListManagedWorkgroupsPaginator ListManagedWorkgroups(ListManagedWorkgroupsRequest request) 
        {
            return new ListManagedWorkgroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        public IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request) 
        {
            return new ListNamespacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecoveryPoints operation
        ///</summary>
        public IListRecoveryPointsPaginator ListRecoveryPoints(ListRecoveryPointsRequest request) 
        {
            return new ListRecoveryPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReservationOfferings operation
        ///</summary>
        public IListReservationOfferingsPaginator ListReservationOfferings(ListReservationOfferingsRequest request) 
        {
            return new ListReservationOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReservations operation
        ///</summary>
        public IListReservationsPaginator ListReservations(ListReservationsRequest request) 
        {
            return new ListReservationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListScheduledActions operation
        ///</summary>
        public IListScheduledActionsPaginator ListScheduledActions(ListScheduledActionsRequest request) 
        {
            return new ListScheduledActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSnapshotCopyConfigurations operation
        ///</summary>
        public IListSnapshotCopyConfigurationsPaginator ListSnapshotCopyConfigurations(ListSnapshotCopyConfigurationsRequest request) 
        {
            return new ListSnapshotCopyConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSnapshots operation
        ///</summary>
        public IListSnapshotsPaginator ListSnapshots(ListSnapshotsRequest request) 
        {
            return new ListSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTableRestoreStatus operation
        ///</summary>
        public IListTableRestoreStatusPaginator ListTableRestoreStatus(ListTableRestoreStatusRequest request) 
        {
            return new ListTableRestoreStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTracks operation
        ///</summary>
        public IListTracksPaginator ListTracks(ListTracksRequest request) 
        {
            return new ListTracksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListUsageLimits operation
        ///</summary>
        public IListUsageLimitsPaginator ListUsageLimits(ListUsageLimitsRequest request) 
        {
            return new ListUsageLimitsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkgroups operation
        ///</summary>
        public IListWorkgroupsPaginator ListWorkgroups(ListWorkgroupsRequest request) 
        {
            return new ListWorkgroupsPaginator(this.client, request);
        }
    }
}