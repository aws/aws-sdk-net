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

#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Paginators for the MainframeModernization service
    ///</summary>
    public interface IMainframeModernizationPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListApplicationVersions operation
        ///</summary>
        IListApplicationVersionsPaginator ListApplicationVersions(ListApplicationVersionsRequest request);

        /// <summary>
        /// Paginator for ListBatchJobDefinitions operation
        ///</summary>
        IListBatchJobDefinitionsPaginator ListBatchJobDefinitions(ListBatchJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListBatchJobExecutions operation
        ///</summary>
        IListBatchJobExecutionsPaginator ListBatchJobExecutions(ListBatchJobExecutionsRequest request);

        /// <summary>
        /// Paginator for ListDataSetImportHistory operation
        ///</summary>
        IListDataSetImportHistoryPaginator ListDataSetImportHistory(ListDataSetImportHistoryRequest request);

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        IListDataSetsPaginator ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Paginator for ListDeployments operation
        ///</summary>
        IListDeploymentsPaginator ListDeployments(ListDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListEngineVersions operation
        ///</summary>
        IListEngineVersionsPaginator ListEngineVersions(ListEngineVersionsRequest request);

        /// <summary>
        /// Paginator for ListEnvironments operation
        ///</summary>
        IListEnvironmentsPaginator ListEnvironments(ListEnvironmentsRequest request);
    }
}