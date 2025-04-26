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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Paginators for the Synthetics service
    ///</summary>
    public interface ISyntheticsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeCanaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCanariesPaginator DescribeCanaries(DescribeCanariesRequest request);

        /// <summary>
        /// Paginator for DescribeCanariesLastRun operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCanariesLastRunPaginator DescribeCanariesLastRun(DescribeCanariesLastRunRequest request);

        /// <summary>
        /// Paginator for DescribeRuntimeVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRuntimeVersionsPaginator DescribeRuntimeVersions(DescribeRuntimeVersionsRequest request);

        /// <summary>
        /// Paginator for GetCanaryRuns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetCanaryRunsPaginator GetCanaryRuns(GetCanaryRunsRequest request);

        /// <summary>
        /// Paginator for ListAssociatedGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssociatedGroupsPaginator ListAssociatedGroups(ListAssociatedGroupsRequest request);

        /// <summary>
        /// Paginator for ListGroupResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupResourcesPaginator ListGroupResources(ListGroupResourcesRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListGroupsPaginator ListGroups(ListGroupsRequest request);
    }
}