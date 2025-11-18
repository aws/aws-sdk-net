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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Paginators for the Backup service
    ///</summary>
    public interface IBackupPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBackupJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupJobsPaginator ListBackupJobs(ListBackupJobsRequest request);

        /// <summary>
        /// Paginator for ListBackupJobSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupJobSummariesPaginator ListBackupJobSummaries(ListBackupJobSummariesRequest request);

        /// <summary>
        /// Paginator for ListBackupPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupPlansPaginator ListBackupPlans(ListBackupPlansRequest request);

        /// <summary>
        /// Paginator for ListBackupPlanTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupPlanTemplatesPaginator ListBackupPlanTemplates(ListBackupPlanTemplatesRequest request);

        /// <summary>
        /// Paginator for ListBackupPlanVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupPlanVersionsPaginator ListBackupPlanVersions(ListBackupPlanVersionsRequest request);

        /// <summary>
        /// Paginator for ListBackupSelections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupSelectionsPaginator ListBackupSelections(ListBackupSelectionsRequest request);

        /// <summary>
        /// Paginator for ListBackupVaults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBackupVaultsPaginator ListBackupVaults(ListBackupVaultsRequest request);

        /// <summary>
        /// Paginator for ListCopyJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCopyJobsPaginator ListCopyJobs(ListCopyJobsRequest request);

        /// <summary>
        /// Paginator for ListCopyJobSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCopyJobSummariesPaginator ListCopyJobSummaries(ListCopyJobSummariesRequest request);

        /// <summary>
        /// Paginator for ListFrameworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFrameworksPaginator ListFrameworks(ListFrameworksRequest request);

        /// <summary>
        /// Paginator for ListIndexedRecoveryPoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListIndexedRecoveryPointsPaginator ListIndexedRecoveryPoints(ListIndexedRecoveryPointsRequest request);

        /// <summary>
        /// Paginator for ListLegalHolds operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLegalHoldsPaginator ListLegalHolds(ListLegalHoldsRequest request);

        /// <summary>
        /// Paginator for ListProtectedResources operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProtectedResourcesPaginator ListProtectedResources(ListProtectedResourcesRequest request);

        /// <summary>
        /// Paginator for ListProtectedResourcesByBackupVault operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProtectedResourcesByBackupVaultPaginator ListProtectedResourcesByBackupVault(ListProtectedResourcesByBackupVaultRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPointsByBackupVault operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecoveryPointsByBackupVaultPaginator ListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPointsByLegalHold operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecoveryPointsByLegalHoldPaginator ListRecoveryPointsByLegalHold(ListRecoveryPointsByLegalHoldRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPointsByResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRecoveryPointsByResourcePaginator ListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request);

        /// <summary>
        /// Paginator for ListReportJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReportJobsPaginator ListReportJobs(ListReportJobsRequest request);

        /// <summary>
        /// Paginator for ListReportPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReportPlansPaginator ListReportPlans(ListReportPlansRequest request);

        /// <summary>
        /// Paginator for ListRestoreAccessBackupVaults operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRestoreAccessBackupVaultsPaginator ListRestoreAccessBackupVaults(ListRestoreAccessBackupVaultsRequest request);

        /// <summary>
        /// Paginator for ListRestoreJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRestoreJobsPaginator ListRestoreJobs(ListRestoreJobsRequest request);

        /// <summary>
        /// Paginator for ListRestoreJobsByProtectedResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRestoreJobsByProtectedResourcePaginator ListRestoreJobsByProtectedResource(ListRestoreJobsByProtectedResourceRequest request);

        /// <summary>
        /// Paginator for ListRestoreJobSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRestoreJobSummariesPaginator ListRestoreJobSummaries(ListRestoreJobSummariesRequest request);

        /// <summary>
        /// Paginator for ListRestoreTestingPlans operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRestoreTestingPlansPaginator ListRestoreTestingPlans(ListRestoreTestingPlansRequest request);

        /// <summary>
        /// Paginator for ListRestoreTestingSelections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRestoreTestingSelectionsPaginator ListRestoreTestingSelections(ListRestoreTestingSelectionsRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsPaginator ListTags(ListTagsRequest request);

        /// <summary>
        /// Paginator for ListTieringConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTieringConfigurationsPaginator ListTieringConfigurations(ListTieringConfigurationsRequest request);
    }
}