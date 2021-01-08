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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Paginators for the DocDB service
    ///</summary>
    public class DocDBPaginatorFactory : IDocDBPaginatorFactory
    {
        private readonly IAmazonDocDB client;

        internal DocDBPaginatorFactory(IAmazonDocDB client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeCertificates operation
        ///</summary>
        public IDescribeCertificatesPaginator DescribeCertificates(DescribeCertificatesRequest request) 
        {
            return new DescribeCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterParameterGroups operation
        ///</summary>
        public IDescribeDBClusterParameterGroupsPaginator DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request) 
        {
            return new DescribeDBClusterParameterGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterParameters operation
        ///</summary>
        public IDescribeDBClusterParametersPaginator DescribeDBClusterParameters(DescribeDBClusterParametersRequest request) 
        {
            return new DescribeDBClusterParametersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusters operation
        ///</summary>
        public IDescribeDBClustersPaginator DescribeDBClusters(DescribeDBClustersRequest request) 
        {
            return new DescribeDBClustersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDBClusterSnapshots operation
        ///</summary>
        public IDescribeDBClusterSnapshotsPaginator DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request) 
        {
            return new DescribeDBClusterSnapshotsPaginator(this.client, request);
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
        /// Paginator for DescribeDBSubnetGroups operation
        ///</summary>
        public IDescribeDBSubnetGroupsPaginator DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request) 
        {
            return new DescribeDBSubnetGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEvents operation
        ///</summary>
        public IDescribeEventsPaginator DescribeEvents(DescribeEventsRequest request) 
        {
            return new DescribeEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeOrderableDBInstanceOptions operation
        ///</summary>
        public IDescribeOrderableDBInstanceOptionsPaginator DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request) 
        {
            return new DescribeOrderableDBInstanceOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePendingMaintenanceActions operation
        ///</summary>
        public IDescribePendingMaintenanceActionsPaginator DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request) 
        {
            return new DescribePendingMaintenanceActionsPaginator(this.client, request);
        }
    }
}
#endif