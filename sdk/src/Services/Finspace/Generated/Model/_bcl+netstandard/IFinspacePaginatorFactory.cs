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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Paginators for the Finspace service
    ///</summary>
    public interface IFinspacePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListKxChangesets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKxChangesetsPaginator ListKxChangesets(ListKxChangesetsRequest request);

        /// <summary>
        /// Paginator for ListKxClusterNodes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKxClusterNodesPaginator ListKxClusterNodes(ListKxClusterNodesRequest request);

        /// <summary>
        /// Paginator for ListKxDatabases operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKxDatabasesPaginator ListKxDatabases(ListKxDatabasesRequest request);

        /// <summary>
        /// Paginator for ListKxDataviews operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKxDataviewsPaginator ListKxDataviews(ListKxDataviewsRequest request);

        /// <summary>
        /// Paginator for ListKxEnvironments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKxEnvironmentsPaginator ListKxEnvironments(ListKxEnvironmentsRequest request);

        /// <summary>
        /// Paginator for ListKxScalingGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKxScalingGroupsPaginator ListKxScalingGroups(ListKxScalingGroupsRequest request);
    }
}