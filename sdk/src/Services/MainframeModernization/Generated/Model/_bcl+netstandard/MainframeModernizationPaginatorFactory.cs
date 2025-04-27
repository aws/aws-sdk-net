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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Paginators for the MainframeModernization service
    ///</summary>
    public class MainframeModernizationPaginatorFactory : IMainframeModernizationPaginatorFactory
    {
        private readonly IAmazonMainframeModernization client;

        internal MainframeModernizationPaginatorFactory(IAmazonMainframeModernization client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        public IListApplicationsPaginator ListApplications(ListApplicationsRequest request) 
        {
            return new ListApplicationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApplicationVersions operation
        ///</summary>
        public IListApplicationVersionsPaginator ListApplicationVersions(ListApplicationVersionsRequest request) 
        {
            return new ListApplicationVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBatchJobDefinitions operation
        ///</summary>
        public IListBatchJobDefinitionsPaginator ListBatchJobDefinitions(ListBatchJobDefinitionsRequest request) 
        {
            return new ListBatchJobDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBatchJobExecutions operation
        ///</summary>
        public IListBatchJobExecutionsPaginator ListBatchJobExecutions(ListBatchJobExecutionsRequest request) 
        {
            return new ListBatchJobExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSetExportHistory operation
        ///</summary>
        public IListDataSetExportHistoryPaginator ListDataSetExportHistory(ListDataSetExportHistoryRequest request) 
        {
            return new ListDataSetExportHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSetImportHistory operation
        ///</summary>
        public IListDataSetImportHistoryPaginator ListDataSetImportHistory(ListDataSetImportHistoryRequest request) 
        {
            return new ListDataSetImportHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        public IListDataSetsPaginator ListDataSets(ListDataSetsRequest request) 
        {
            return new ListDataSetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        public IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request) 
        {
            return new ListDeploymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEngineVersions operation
        ///</summary>
        public IListEngineVersionsPaginator ListEngineVersions(ListEngineVersionsRequest request) 
        {
            return new ListEngineVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        public IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request) 
        {
            return new ListEnvironmentsPaginator(this.client, request);
        }
    }
}