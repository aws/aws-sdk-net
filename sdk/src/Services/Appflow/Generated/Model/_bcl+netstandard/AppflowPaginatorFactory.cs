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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Paginators for the Appflow service
    ///</summary>
    public class AppflowPaginatorFactory : IAppflowPaginatorFactory
    {
        private readonly IAmazonAppflow client;

        internal AppflowPaginatorFactory(IAmazonAppflow client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeConnectorProfiles operation
        ///</summary>
        public IDescribeConnectorProfilesPaginator DescribeConnectorProfiles(DescribeConnectorProfilesRequest request) 
        {
            return new DescribeConnectorProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeConnectors operation
        ///</summary>
        public IDescribeConnectorsPaginator DescribeConnectors(DescribeConnectorsRequest request) 
        {
            return new DescribeConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFlowExecutionRecords operation
        ///</summary>
        public IDescribeFlowExecutionRecordsPaginator DescribeFlowExecutionRecords(DescribeFlowExecutionRecordsRequest request) 
        {
            return new DescribeFlowExecutionRecordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        public IListConnectorsPaginator ListConnectors(ListConnectorsRequest request) 
        {
            return new ListConnectorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlows operation
        ///</summary>
        public IListFlowsPaginator ListFlows(ListFlowsRequest request) 
        {
            return new ListFlowsPaginator(this.client, request);
        }
    }
}