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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Paginators for the AuditManager service
    ///</summary>
    public class AuditManagerPaginatorFactory : IAuditManagerPaginatorFactory
    {
        private readonly IAmazonAuditManager client;

        internal AuditManagerPaginatorFactory(IAmazonAuditManager client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetChangeLogs operation
        ///</summary>
        public IGetChangeLogsPaginator GetChangeLogs(GetChangeLogsRequest request) 
        {
            return new GetChangeLogsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDelegations operation
        ///</summary>
        public IGetDelegationsPaginator GetDelegations(GetDelegationsRequest request) 
        {
            return new GetDelegationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEvidenceByEvidenceFolder operation
        ///</summary>
        public IGetEvidenceByEvidenceFolderPaginator GetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request) 
        {
            return new GetEvidenceByEvidenceFolderPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEvidenceFoldersByAssessment operation
        ///</summary>
        public IGetEvidenceFoldersByAssessmentPaginator GetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request) 
        {
            return new GetEvidenceFoldersByAssessmentPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetEvidenceFoldersByAssessmentControl operation
        ///</summary>
        public IGetEvidenceFoldersByAssessmentControlPaginator GetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request) 
        {
            return new GetEvidenceFoldersByAssessmentControlPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentControlInsightsByControlDomain operation
        ///</summary>
        public IListAssessmentControlInsightsByControlDomainPaginator ListAssessmentControlInsightsByControlDomain(ListAssessmentControlInsightsByControlDomainRequest request) 
        {
            return new ListAssessmentControlInsightsByControlDomainPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentFrameworks operation
        ///</summary>
        public IListAssessmentFrameworksPaginator ListAssessmentFrameworks(ListAssessmentFrameworksRequest request) 
        {
            return new ListAssessmentFrameworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentFrameworkShareRequests operation
        ///</summary>
        public IListAssessmentFrameworkShareRequestsPaginator ListAssessmentFrameworkShareRequests(ListAssessmentFrameworkShareRequestsRequest request) 
        {
            return new ListAssessmentFrameworkShareRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessmentReports operation
        ///</summary>
        public IListAssessmentReportsPaginator ListAssessmentReports(ListAssessmentReportsRequest request) 
        {
            return new ListAssessmentReportsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssessments operation
        ///</summary>
        public IListAssessmentsPaginator ListAssessments(ListAssessmentsRequest request) 
        {
            return new ListAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControlDomainInsights operation
        ///</summary>
        public IListControlDomainInsightsPaginator ListControlDomainInsights(ListControlDomainInsightsRequest request) 
        {
            return new ListControlDomainInsightsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControlDomainInsightsByAssessment operation
        ///</summary>
        public IListControlDomainInsightsByAssessmentPaginator ListControlDomainInsightsByAssessment(ListControlDomainInsightsByAssessmentRequest request) 
        {
            return new ListControlDomainInsightsByAssessmentPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControlInsightsByControlDomain operation
        ///</summary>
        public IListControlInsightsByControlDomainPaginator ListControlInsightsByControlDomain(ListControlInsightsByControlDomainRequest request) 
        {
            return new ListControlInsightsByControlDomainPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListControls operation
        ///</summary>
        public IListControlsPaginator ListControls(ListControlsRequest request) 
        {
            return new ListControlsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKeywordsForDataSource operation
        ///</summary>
        public IListKeywordsForDataSourcePaginator ListKeywordsForDataSource(ListKeywordsForDataSourceRequest request) 
        {
            return new ListKeywordsForDataSourcePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        public IListNotificationsPaginator ListNotifications(ListNotificationsRequest request) 
        {
            return new ListNotificationsPaginator(this.client, request);
        }
    }
}