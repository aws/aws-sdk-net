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
        IListBackupJobsPaginator ListBackupJobs(ListBackupJobsRequest request);

        /// <summary>
        /// Paginator for ListBackupPlans operation
        ///</summary>
        IListBackupPlansPaginator ListBackupPlans(ListBackupPlansRequest request);

        /// <summary>
        /// Paginator for ListBackupPlanTemplates operation
        ///</summary>
        IListBackupPlanTemplatesPaginator ListBackupPlanTemplates(ListBackupPlanTemplatesRequest request);

        /// <summary>
        /// Paginator for ListBackupPlanVersions operation
        ///</summary>
        IListBackupPlanVersionsPaginator ListBackupPlanVersions(ListBackupPlanVersionsRequest request);

        /// <summary>
        /// Paginator for ListBackupSelections operation
        ///</summary>
        IListBackupSelectionsPaginator ListBackupSelections(ListBackupSelectionsRequest request);

        /// <summary>
        /// Paginator for ListBackupVaults operation
        ///</summary>
        IListBackupVaultsPaginator ListBackupVaults(ListBackupVaultsRequest request);

        /// <summary>
        /// Paginator for ListCopyJobs operation
        ///</summary>
        IListCopyJobsPaginator ListCopyJobs(ListCopyJobsRequest request);

        /// <summary>
        /// Paginator for ListFrameworks operation
        ///</summary>
        IListFrameworksPaginator ListFrameworks(ListFrameworksRequest request);

        /// <summary>
        /// Paginator for ListLegalHolds operation
        ///</summary>
        IListLegalHoldsPaginator ListLegalHolds(ListLegalHoldsRequest request);

        /// <summary>
        /// Paginator for ListProtectedResources operation
        ///</summary>
        IListProtectedResourcesPaginator ListProtectedResources(ListProtectedResourcesRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPointsByBackupVault operation
        ///</summary>
        IListRecoveryPointsByBackupVaultPaginator ListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPointsByLegalHold operation
        ///</summary>
        IListRecoveryPointsByLegalHoldPaginator ListRecoveryPointsByLegalHold(ListRecoveryPointsByLegalHoldRequest request);

        /// <summary>
        /// Paginator for ListRecoveryPointsByResource operation
        ///</summary>
        IListRecoveryPointsByResourcePaginator ListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request);

        /// <summary>
        /// Paginator for ListReportJobs operation
        ///</summary>
        IListReportJobsPaginator ListReportJobs(ListReportJobsRequest request);

        /// <summary>
        /// Paginator for ListReportPlans operation
        ///</summary>
        IListReportPlansPaginator ListReportPlans(ListReportPlansRequest request);

        /// <summary>
        /// Paginator for ListRestoreJobs operation
        ///</summary>
        IListRestoreJobsPaginator ListRestoreJobs(ListRestoreJobsRequest request);

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        IListTagsPaginator ListTags(ListTagsRequest request);
    }
}