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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Paginators for the Omics service
    ///</summary>
    public class OmicsPaginatorFactory : IOmicsPaginatorFactory
    {
        private readonly IAmazonOmics client;

        internal OmicsPaginatorFactory(IAmazonOmics client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAnnotationImportJobs operation
        ///</summary>
        public IListAnnotationImportJobsPaginator ListAnnotationImportJobs(ListAnnotationImportJobsRequest request) 
        {
            return new ListAnnotationImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnnotationStores operation
        ///</summary>
        public IListAnnotationStoresPaginator ListAnnotationStores(ListAnnotationStoresRequest request) 
        {
            return new ListAnnotationStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReadSetActivationJobs operation
        ///</summary>
        public IListReadSetActivationJobsPaginator ListReadSetActivationJobs(ListReadSetActivationJobsRequest request) 
        {
            return new ListReadSetActivationJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReadSetExportJobs operation
        ///</summary>
        public IListReadSetExportJobsPaginator ListReadSetExportJobs(ListReadSetExportJobsRequest request) 
        {
            return new ListReadSetExportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReadSetImportJobs operation
        ///</summary>
        public IListReadSetImportJobsPaginator ListReadSetImportJobs(ListReadSetImportJobsRequest request) 
        {
            return new ListReadSetImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReadSets operation
        ///</summary>
        public IListReadSetsPaginator ListReadSets(ListReadSetsRequest request) 
        {
            return new ListReadSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReferenceImportJobs operation
        ///</summary>
        public IListReferenceImportJobsPaginator ListReferenceImportJobs(ListReferenceImportJobsRequest request) 
        {
            return new ListReferenceImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReferences operation
        ///</summary>
        public IListReferencesPaginator ListReferences(ListReferencesRequest request) 
        {
            return new ListReferencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReferenceStores operation
        ///</summary>
        public IListReferenceStoresPaginator ListReferenceStores(ListReferenceStoresRequest request) 
        {
            return new ListReferenceStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRunGroups operation
        ///</summary>
        public IListRunGroupsPaginator ListRunGroups(ListRunGroupsRequest request) 
        {
            return new ListRunGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRuns operation
        ///</summary>
        public IListRunsPaginator ListRuns(ListRunsRequest request) 
        {
            return new ListRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRunTasks operation
        ///</summary>
        public IListRunTasksPaginator ListRunTasks(ListRunTasksRequest request) 
        {
            return new ListRunTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSequenceStores operation
        ///</summary>
        public IListSequenceStoresPaginator ListSequenceStores(ListSequenceStoresRequest request) 
        {
            return new ListSequenceStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVariantImportJobs operation
        ///</summary>
        public IListVariantImportJobsPaginator ListVariantImportJobs(ListVariantImportJobsRequest request) 
        {
            return new ListVariantImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListVariantStores operation
        ///</summary>
        public IListVariantStoresPaginator ListVariantStores(ListVariantStoresRequest request) 
        {
            return new ListVariantStoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        public IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request) 
        {
            return new ListWorkflowsPaginator(this.client, request);
        }
    }
}