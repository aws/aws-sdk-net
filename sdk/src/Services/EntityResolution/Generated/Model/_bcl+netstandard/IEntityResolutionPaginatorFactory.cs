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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Paginators for the EntityResolution service
    ///</summary>
    public interface IEntityResolutionPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListIdMappingJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIdMappingJobsPaginator ListIdMappingJobs(ListIdMappingJobsRequest request);

        /// <summary>
        /// Paginator for ListIdMappingWorkflows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIdMappingWorkflowsPaginator ListIdMappingWorkflows(ListIdMappingWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListIdNamespaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIdNamespacesPaginator ListIdNamespaces(ListIdNamespacesRequest request);

        /// <summary>
        /// Paginator for ListMatchingJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMatchingJobsPaginator ListMatchingJobs(ListMatchingJobsRequest request);

        /// <summary>
        /// Paginator for ListMatchingWorkflows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMatchingWorkflowsPaginator ListMatchingWorkflows(ListMatchingWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListProviderServices operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProviderServicesPaginator ListProviderServices(ListProviderServicesRequest request);

        /// <summary>
        /// Paginator for ListSchemaMappings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSchemaMappingsPaginator ListSchemaMappings(ListSchemaMappingsRequest request);
    }
}