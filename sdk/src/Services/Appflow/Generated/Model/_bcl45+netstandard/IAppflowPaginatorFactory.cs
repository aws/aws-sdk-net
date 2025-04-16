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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Paginators for the Appflow service
    ///</summary>
    public interface IAppflowPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeConnectorProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeConnectorProfilesPaginator DescribeConnectorProfiles(DescribeConnectorProfilesRequest request);

        /// <summary>
        /// Paginator for DescribeConnectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeConnectorsPaginator DescribeConnectors(DescribeConnectorsRequest request);

        /// <summary>
        /// Paginator for DescribeFlowExecutionRecords operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFlowExecutionRecordsPaginator DescribeFlowExecutionRecords(DescribeFlowExecutionRecordsRequest request);

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListFlows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowsPaginator ListFlows(ListFlowsRequest request);
    }
}