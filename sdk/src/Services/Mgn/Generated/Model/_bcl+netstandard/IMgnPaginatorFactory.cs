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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeJobLogItemsPaginator DescribeJobLogItems(DescribeJobLogItemsRequest request);

        /// <summary>
        /// Paginator for DescribeJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeJobsPaginator DescribeJobs(DescribeJobsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchConfigurationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLaunchConfigurationTemplatesPaginator DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeReplicationConfigurationTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReplicationConfigurationTemplatesPaginator DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeSourceServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSourceServersPaginator DescribeSourceServers(DescribeSourceServersRequest request);

        /// <summary>
        /// Paginator for DescribeVcenterClients operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVcenterClientsPaginator DescribeVcenterClients(DescribeVcenterClientsRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListConnectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListConnectorsPaginator ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Paginator for ListExportErrors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExportErrorsPaginator ListExportErrors(ListExportErrorsRequest request);

        /// <summary>
        /// Paginator for ListExports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListExportsPaginator ListExports(ListExportsRequest request);

        /// <summary>
        /// Paginator for ListImportErrors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportErrorsPaginator ListImportErrors(ListImportErrorsRequest request);

        /// <summary>
        /// Paginator for ListImportFileEnrichments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportFileEnrichmentsPaginator ListImportFileEnrichments(ListImportFileEnrichmentsRequest request);

        /// <summary>
        /// Paginator for ListImports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImportsPaginator ListImports(ListImportsRequest request);

        /// <summary>
        /// Paginator for ListManagedAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListManagedAccountsPaginator ListManagedAccounts(ListManagedAccountsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationAnalyses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationAnalysesPaginator ListNetworkMigrationAnalyses(ListNetworkMigrationAnalysesRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationAnalysisResults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationAnalysisResultsPaginator ListNetworkMigrationAnalysisResults(ListNetworkMigrationAnalysisResultsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationCodeGenerations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationCodeGenerationsPaginator ListNetworkMigrationCodeGenerations(ListNetworkMigrationCodeGenerationsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationCodeGenerationSegments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationCodeGenerationSegmentsPaginator ListNetworkMigrationCodeGenerationSegments(ListNetworkMigrationCodeGenerationSegmentsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationDefinitionsPaginator ListNetworkMigrationDefinitions(ListNetworkMigrationDefinitionsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationDeployedStacks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationDeployedStacksPaginator ListNetworkMigrationDeployedStacks(ListNetworkMigrationDeployedStacksRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationDeployments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationDeploymentsPaginator ListNetworkMigrationDeployments(ListNetworkMigrationDeploymentsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationExecutionsPaginator ListNetworkMigrationExecutions(ListNetworkMigrationExecutionsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationMapperSegmentConstructs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationMapperSegmentConstructsPaginator ListNetworkMigrationMapperSegmentConstructs(ListNetworkMigrationMapperSegmentConstructsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationMapperSegments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationMapperSegmentsPaginator ListNetworkMigrationMapperSegments(ListNetworkMigrationMapperSegmentsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationMappings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationMappingsPaginator ListNetworkMigrationMappings(ListNetworkMigrationMappingsRequest request);

        /// <summary>
        /// Paginator for ListNetworkMigrationMappingUpdates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNetworkMigrationMappingUpdatesPaginator ListNetworkMigrationMappingUpdates(ListNetworkMigrationMappingUpdatesRequest request);

        /// <summary>
        /// Paginator for ListSourceServerActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSourceServerActionsPaginator ListSourceServerActions(ListSourceServerActionsRequest request);

        /// <summary>
        /// Paginator for ListTemplateActions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplateActionsPaginator ListTemplateActions(ListTemplateActionsRequest request);

        /// <summary>
        /// Paginator for ListWaves operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWavesPaginator ListWaves(ListWavesRequest request);
    }
}