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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Paginators for the RedshiftServerless service
    ///</summary>
    public interface IRedshiftServerlessPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEndpointAccess operation
        ///</summary>
        IListEndpointAccessPaginator ListEndpointAccess(ListEndpointAccessRequest request);

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPoints operation
        ///</summary>
        IListRecoveryPointsPaginator ListRecoveryPoints(ListRecoveryPointsRequest request);

        /// <summary>
        /// Paginator for ListSnapshots operation
        ///</summary>
        IListSnapshotsPaginator ListSnapshots(ListSnapshotsRequest request);

        /// <summary>
        /// Paginator for ListTableRestoreStatus operation
        ///</summary>
        IListTableRestoreStatusPaginator ListTableRestoreStatus(ListTableRestoreStatusRequest request);

        /// <summary>
        /// Paginator for ListUsageLimits operation
        ///</summary>
        IListUsageLimitsPaginator ListUsageLimits(ListUsageLimitsRequest request);

        /// <summary>
        /// Paginator for ListWorkgroups operation
        ///</summary>
        IListWorkgroupsPaginator ListWorkgroups(ListWorkgroupsRequest request);
    }
}