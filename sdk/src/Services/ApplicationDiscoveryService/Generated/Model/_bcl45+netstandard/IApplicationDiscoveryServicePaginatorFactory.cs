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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Paginators for the ApplicationDiscoveryService service
    ///</summary>
    public interface IApplicationDiscoveryServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAgents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAgentsPaginator DescribeAgents(DescribeAgentsRequest request);

        /// <summary>
        /// Paginator for DescribeContinuousExports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeContinuousExportsPaginator DescribeContinuousExports(DescribeContinuousExportsRequest request);

        /// <summary>
        /// Paginator for DescribeExportConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeExportConfigurationsPaginator DescribeExportConfigurations(DescribeExportConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeExportTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeExportTasksPaginator DescribeExportTasks(DescribeExportTasksRequest request);

        /// <summary>
        /// Paginator for DescribeImportTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImportTasksPaginator DescribeImportTasks(DescribeImportTasksRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for ListConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConfigurationsPaginator ListConfigurations(ListConfigurationsRequest request);
    }
}