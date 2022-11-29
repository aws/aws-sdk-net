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
        IListAnnotationImportJobsPaginator ListAnnotationImportJobs(ListAnnotationImportJobsRequest request);

        /// <summary>
        /// Paginator for ListAnnotationStores operation
        ///</summary>
        IListAnnotationStoresPaginator ListAnnotationStores(ListAnnotationStoresRequest request);

        /// <summary>
        /// Paginator for ListReadSetActivationJobs operation
        ///</summary>
        IListReadSetActivationJobsPaginator ListReadSetActivationJobs(ListReadSetActivationJobsRequest request);

        /// <summary>
        /// Paginator for ListReadSetExportJobs operation
        ///</summary>
        IListReadSetExportJobsPaginator ListReadSetExportJobs(ListReadSetExportJobsRequest request);

        /// <summary>
        /// Paginator for ListReadSetImportJobs operation
        ///</summary>
        IListReadSetImportJobsPaginator ListReadSetImportJobs(ListReadSetImportJobsRequest request);

        /// <summary>
        /// Paginator for ListReadSets operation
        ///</summary>
        IListReadSetsPaginator ListReadSets(ListReadSetsRequest request);

        /// <summary>
        /// Paginator for ListReferenceImportJobs operation
        ///</summary>
        IListReferenceImportJobsPaginator ListReferenceImportJobs(ListReferenceImportJobsRequest request);

        /// <summary>
        /// Paginator for ListReferences operation
        ///</summary>
        IListReferencesPaginator ListReferences(ListReferencesRequest request);

        /// <summary>
        /// Paginator for ListReferenceStores operation
        ///</summary>
        IListReferenceStoresPaginator ListReferenceStores(ListReferenceStoresRequest request);

        /// <summary>
        /// Paginator for ListRunGroups operation
        ///</summary>
        IListRunGroupsPaginator ListRunGroups(ListRunGroupsRequest request);

        /// <summary>
        /// Paginator for ListRuns operation
        ///</summary>
        IListRunsPaginator ListRuns(ListRunsRequest request);

        /// <summary>
        /// Paginator for ListRunTasks operation
        ///</summary>
        IListRunTasksPaginator ListRunTasks(ListRunTasksRequest request);

        /// <summary>
        /// Paginator for ListSequenceStores operation
        ///</summary>
        IListSequenceStoresPaginator ListSequenceStores(ListSequenceStoresRequest request);

        /// <summary>
        /// Paginator for ListVariantImportJobs operation
        ///</summary>
        IListVariantImportJobsPaginator ListVariantImportJobs(ListVariantImportJobsRequest request);

        /// <summary>
        /// Paginator for ListVariantStores operation
        ///</summary>
        IListVariantStoresPaginator ListVariantStores(ListVariantStoresRequest request);

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request);
    }
}