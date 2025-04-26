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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Paginators for the Omics service
    ///</summary>
    public interface IOmicsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAnnotationImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnnotationImportJobsPaginator ListAnnotationImportJobs(ListAnnotationImportJobsRequest request);

        /// <summary>
        /// Paginator for ListAnnotationStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnnotationStoresPaginator ListAnnotationStores(ListAnnotationStoresRequest request);

        /// <summary>
        /// Paginator for ListAnnotationStoreVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnnotationStoreVersionsPaginator ListAnnotationStoreVersions(ListAnnotationStoreVersionsRequest request);

        /// <summary>
        /// Paginator for ListMultipartReadSetUploads operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMultipartReadSetUploadsPaginator ListMultipartReadSetUploads(ListMultipartReadSetUploadsRequest request);

        /// <summary>
        /// Paginator for ListReadSetActivationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReadSetActivationJobsPaginator ListReadSetActivationJobs(ListReadSetActivationJobsRequest request);

        /// <summary>
        /// Paginator for ListReadSetExportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReadSetExportJobsPaginator ListReadSetExportJobs(ListReadSetExportJobsRequest request);

        /// <summary>
        /// Paginator for ListReadSetImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReadSetImportJobsPaginator ListReadSetImportJobs(ListReadSetImportJobsRequest request);

        /// <summary>
        /// Paginator for ListReadSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReadSetsPaginator ListReadSets(ListReadSetsRequest request);

        /// <summary>
        /// Paginator for ListReadSetUploadParts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReadSetUploadPartsPaginator ListReadSetUploadParts(ListReadSetUploadPartsRequest request);

        /// <summary>
        /// Paginator for ListReferenceImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReferenceImportJobsPaginator ListReferenceImportJobs(ListReferenceImportJobsRequest request);

        /// <summary>
        /// Paginator for ListReferences operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReferencesPaginator ListReferences(ListReferencesRequest request);

        /// <summary>
        /// Paginator for ListReferenceStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReferenceStoresPaginator ListReferenceStores(ListReferenceStoresRequest request);

        /// <summary>
        /// Paginator for ListRunCaches operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartingToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRunCachesPaginator ListRunCaches(ListRunCachesRequest request);

        /// <summary>
        /// Paginator for ListRunGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartingToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRunGroupsPaginator ListRunGroups(ListRunGroupsRequest request);

        /// <summary>
        /// Paginator for ListRuns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartingToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRunsPaginator ListRuns(ListRunsRequest request);

        /// <summary>
        /// Paginator for ListRunTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartingToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRunTasksPaginator ListRunTasks(ListRunTasksRequest request);

        /// <summary>
        /// Paginator for ListSequenceStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSequenceStoresPaginator ListSequenceStores(ListSequenceStoresRequest request);

        /// <summary>
        /// Paginator for ListShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSharesPaginator ListShares(ListSharesRequest request);

        /// <summary>
        /// Paginator for ListVariantImportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVariantImportJobsPaginator ListVariantImportJobs(ListVariantImportJobsRequest request);

        /// <summary>
        /// Paginator for ListVariantStores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListVariantStoresPaginator ListVariantStores(ListVariantStoresRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartingToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "StartingToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkflowVersionsPaginator ListWorkflowVersions(ListWorkflowVersionsRequest request);
    }
}