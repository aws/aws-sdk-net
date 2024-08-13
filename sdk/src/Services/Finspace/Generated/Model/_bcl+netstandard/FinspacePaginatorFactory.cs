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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Paginators for the Finspace service
    ///</summary>
    public class FinspacePaginatorFactory : IFinspacePaginatorFactory
    {
        private readonly IAmazonFinspace client;

        internal FinspacePaginatorFactory(IAmazonFinspace client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListKxChangesets operation
        ///</summary>
        public IListKxChangesetsPaginator ListKxChangesets(ListKxChangesetsRequest request) 
        {
            return new ListKxChangesetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKxClusterNodes operation
        ///</summary>
        public IListKxClusterNodesPaginator ListKxClusterNodes(ListKxClusterNodesRequest request) 
        {
            return new ListKxClusterNodesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKxDatabases operation
        ///</summary>
        public IListKxDatabasesPaginator ListKxDatabases(ListKxDatabasesRequest request) 
        {
            return new ListKxDatabasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKxDataviews operation
        ///</summary>
        public IListKxDataviewsPaginator ListKxDataviews(ListKxDataviewsRequest request) 
        {
            return new ListKxDataviewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKxEnvironments operation
        ///</summary>
        public IListKxEnvironmentsPaginator ListKxEnvironments(ListKxEnvironmentsRequest request) 
        {
            return new ListKxEnvironmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKxScalingGroups operation
        ///</summary>
        public IListKxScalingGroupsPaginator ListKxScalingGroups(ListKxScalingGroupsRequest request) 
        {
            return new ListKxScalingGroupsPaginator(this.client, request);
        }
    }
}