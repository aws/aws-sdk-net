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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Paginators for the Backup service
    ///</summary>
    public class BackupPaginatorFactory : IBackupPaginatorFactory
    {
        private readonly IAmazonBackup client;

        internal BackupPaginatorFactory(IAmazonBackup client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBackupJobs operation
        ///</summary>
        public IListBackupJobsPaginator ListBackupJobs(ListBackupJobsRequest request) 
        {
            return new ListBackupJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBackupJobSummaries operation
        ///</summary>
        public IListBackupJobSummariesPaginator ListBackupJobSummaries(ListBackupJobSummariesRequest request) 
        {
            return new ListBackupJobSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBackupPlans operation
        ///</summary>
        public IListBackupPlansPaginator ListBackupPlans(ListBackupPlansRequest request) 
        {
            return new ListBackupPlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBackupPlanTemplates operation
        ///</summary>
        public IListBackupPlanTemplatesPaginator ListBackupPlanTemplates(ListBackupPlanTemplatesRequest request) 
        {
            return new ListBackupPlanTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBackupPlanVersions operation
        ///</summary>
        public IListBackupPlanVersionsPaginator ListBackupPlanVersions(ListBackupPlanVersionsRequest request) 
        {
            return new ListBackupPlanVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBackupSelections operation
        ///</summary>
        public IListBackupSelectionsPaginator ListBackupSelections(ListBackupSelectionsRequest request) 
        {
            return new ListBackupSelectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBackupVaults operation
        ///</summary>
        public IListBackupVaultsPaginator ListBackupVaults(ListBackupVaultsRequest request) 
        {
            return new ListBackupVaultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCopyJobs operation
        ///</summary>
        public IListCopyJobsPaginator ListCopyJobs(ListCopyJobsRequest request) 
        {
            return new ListCopyJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCopyJobSummaries operation
        ///</summary>
        public IListCopyJobSummariesPaginator ListCopyJobSummaries(ListCopyJobSummariesRequest request) 
        {
            return new ListCopyJobSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFrameworks operation
        ///</summary>
        public IListFrameworksPaginator ListFrameworks(ListFrameworksRequest request) 
        {
            return new ListFrameworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIndexedRecoveryPoints operation
        ///</summary>
        public IListIndexedRecoveryPointsPaginator ListIndexedRecoveryPoints(ListIndexedRecoveryPointsRequest request) 
        {
            return new ListIndexedRecoveryPointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLegalHolds operation
        ///</summary>
        public IListLegalHoldsPaginator ListLegalHolds(ListLegalHoldsRequest request) 
        {
            return new ListLegalHoldsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtectedResources operation
        ///</summary>
        public IListProtectedResourcesPaginator ListProtectedResources(ListProtectedResourcesRequest request) 
        {
            return new ListProtectedResourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProtectedResourcesByBackupVault operation
        ///</summary>
        public IListProtectedResourcesByBackupVaultPaginator ListProtectedResourcesByBackupVault(ListProtectedResourcesByBackupVaultRequest request) 
        {
            return new ListProtectedResourcesByBackupVaultPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecoveryPointsByBackupVault operation
        ///</summary>
        public IListRecoveryPointsByBackupVaultPaginator ListRecoveryPointsByBackupVault(ListRecoveryPointsByBackupVaultRequest request) 
        {
            return new ListRecoveryPointsByBackupVaultPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecoveryPointsByLegalHold operation
        ///</summary>
        public IListRecoveryPointsByLegalHoldPaginator ListRecoveryPointsByLegalHold(ListRecoveryPointsByLegalHoldRequest request) 
        {
            return new ListRecoveryPointsByLegalHoldPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecoveryPointsByResource operation
        ///</summary>
        public IListRecoveryPointsByResourcePaginator ListRecoveryPointsByResource(ListRecoveryPointsByResourceRequest request) 
        {
            return new ListRecoveryPointsByResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReportJobs operation
        ///</summary>
        public IListReportJobsPaginator ListReportJobs(ListReportJobsRequest request) 
        {
            return new ListReportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReportPlans operation
        ///</summary>
        public IListReportPlansPaginator ListReportPlans(ListReportPlansRequest request) 
        {
            return new ListReportPlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRestoreAccessBackupVaults operation
        ///</summary>
        public IListRestoreAccessBackupVaultsPaginator ListRestoreAccessBackupVaults(ListRestoreAccessBackupVaultsRequest request) 
        {
            return new ListRestoreAccessBackupVaultsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRestoreJobs operation
        ///</summary>
        public IListRestoreJobsPaginator ListRestoreJobs(ListRestoreJobsRequest request) 
        {
            return new ListRestoreJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRestoreJobsByProtectedResource operation
        ///</summary>
        public IListRestoreJobsByProtectedResourcePaginator ListRestoreJobsByProtectedResource(ListRestoreJobsByProtectedResourceRequest request) 
        {
            return new ListRestoreJobsByProtectedResourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRestoreJobSummaries operation
        ///</summary>
        public IListRestoreJobSummariesPaginator ListRestoreJobSummaries(ListRestoreJobSummariesRequest request) 
        {
            return new ListRestoreJobSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRestoreTestingPlans operation
        ///</summary>
        public IListRestoreTestingPlansPaginator ListRestoreTestingPlans(ListRestoreTestingPlansRequest request) 
        {
            return new ListRestoreTestingPlansPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRestoreTestingSelections operation
        ///</summary>
        public IListRestoreTestingSelectionsPaginator ListRestoreTestingSelections(ListRestoreTestingSelectionsRequest request) 
        {
            return new ListRestoreTestingSelectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTags operation
        ///</summary>
        public IListTagsPaginator ListTags(ListTagsRequest request) 
        {
            return new ListTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTieringConfigurations operation
        ///</summary>
        public IListTieringConfigurationsPaginator ListTieringConfigurations(ListTieringConfigurationsRequest request) 
        {
            return new ListTieringConfigurationsPaginator(this.client, request);
        }
    }
}