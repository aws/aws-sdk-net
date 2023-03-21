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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Paginators for the Mgn service
    ///</summary>
    public interface IMgnPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeJobLogItems operation
        ///</summary>
        IDescribeJobLogItemsPaginator DescribeJobLogItems(DescribeJobLogItemsRequest request);

        /// <summary>
        /// Paginator for DescribeJobs operation
        ///</summary>
        IDescribeJobsPaginator DescribeJobs(DescribeJobsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchConfigurationTemplates operation
        ///</summary>
        IDescribeLaunchConfigurationTemplatesPaginator DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        ///</summary>
        IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        ///</summary>
        IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request);

        /// <summary>
        /// Paginator for DescribeVcenterClients operation
        ///</summary>
        IDescribeVcenterClientsPaginator DescribeVcenterClients(DescribeVcenterClientsRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListExportErrors operation
        ///</summary>
        IListExportErrorsPaginator ListExportErrors(ListExportErrorsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListImportErrors operation
        ///</summary>
        IListImportErrorsPaginator ListImportErrors(ListImportErrorsRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListSourceServerActions operation
        ///</summary>
        IListSourceServerActionsPaginator ListSourceServerActions(ListSourceServerActionsRequest request);

        /// <summary>
        /// Paginator for ListTemplateActions operation
        ///</summary>
        IListTemplateActionsPaginator ListTemplateActions(ListTemplateActionsRequest request);

        /// <summary>
        /// Paginator for ListWaves operation
        ///</summary>
        IListWavesPaginator ListWaves(ListWavesRequest request);
    }
}