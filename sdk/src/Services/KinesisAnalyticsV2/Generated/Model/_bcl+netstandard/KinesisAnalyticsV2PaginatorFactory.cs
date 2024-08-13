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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Paginators for the KinesisAnalyticsV2 service
    ///</summary>
    public class KinesisAnalyticsV2PaginatorFactory : IKinesisAnalyticsV2PaginatorFactory
    {
        private readonly IAmazonKinesisAnalyticsV2 client;

        internal KinesisAnalyticsV2PaginatorFactory(IAmazonKinesisAnalyticsV2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplicationOperations operation
        ///</summary>
        public IListApplicationOperationsPaginator ListApplicationOperations(ListApplicationOperationsRequest request) 
        {
            return new ListApplicationOperationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationSnapshots operation
        ///</summary>
        public IListApplicationSnapshotsPaginator ListApplicationSnapshots(ListApplicationSnapshotsRequest request) 
        {
            return new ListApplicationSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationVersions operation
        ///</summary>
        public IListApplicationVersionsPaginator ListApplicationVersions(ListApplicationVersionsRequest request) 
        {
            return new ListApplicationVersionsPaginator(this.client, request);
        }
    }
}