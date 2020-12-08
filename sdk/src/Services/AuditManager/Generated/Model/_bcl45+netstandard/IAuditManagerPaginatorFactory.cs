#if !NETSTANDARD13
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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Paginators for the AuditManager service
    ///</summary>
    public interface IAuditManagerPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetChangeLogs operation
        ///</summary>
        IGetChangeLogsPaginator GetChangeLogs(GetChangeLogsRequest request);

        /// <summary>
        /// Paginator for GetDelegations operation
        ///</summary>
        IGetDelegationsPaginator GetDelegations(GetDelegationsRequest request);

        /// <summary>
        /// Paginator for GetEvidenceByEvidenceFolder operation
        ///</summary>
        IGetEvidenceByEvidenceFolderPaginator GetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request);

        /// <summary>
        /// Paginator for GetEvidenceFoldersByAssessment operation
        ///</summary>
        IGetEvidenceFoldersByAssessmentPaginator GetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request);

        /// <summary>
        /// Paginator for GetEvidenceFoldersByAssessmentControl operation
        ///</summary>
        IGetEvidenceFoldersByAssessmentControlPaginator GetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request);

        /// <summary>
        /// Paginator for ListAssessmentFrameworks operation
        ///</summary>
        IListAssessmentFrameworksPaginator ListAssessmentFrameworks(ListAssessmentFrameworksRequest request);

        /// <summary>
        /// Paginator for ListAssessmentReports operation
        ///</summary>
        IListAssessmentReportsPaginator ListAssessmentReports(ListAssessmentReportsRequest request);

        /// <summary>
        /// Paginator for ListAssessments operation
        ///</summary>
        IListAssessmentsPaginator ListAssessments(ListAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListControls operation
        ///</summary>
        IListControlsPaginator ListControls(ListControlsRequest request);

        /// <summary>
        /// Paginator for ListKeywordsForDataSource operation
        ///</summary>
        IListKeywordsForDataSourcePaginator ListKeywordsForDataSource(ListKeywordsForDataSourceRequest request);

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        IListNotificationsPaginator ListNotifications(ListNotificationsRequest request);
    }
}
#endif