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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetChangeLogsPaginator GetChangeLogs(GetChangeLogsRequest request);

        /// <summary>
        /// Paginator for GetDelegations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetDelegationsPaginator GetDelegations(GetDelegationsRequest request);

        /// <summary>
        /// Paginator for GetEvidenceByEvidenceFolder operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetEvidenceByEvidenceFolderPaginator GetEvidenceByEvidenceFolder(GetEvidenceByEvidenceFolderRequest request);

        /// <summary>
        /// Paginator for GetEvidenceFoldersByAssessment operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetEvidenceFoldersByAssessmentPaginator GetEvidenceFoldersByAssessment(GetEvidenceFoldersByAssessmentRequest request);

        /// <summary>
        /// Paginator for GetEvidenceFoldersByAssessmentControl operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetEvidenceFoldersByAssessmentControlPaginator GetEvidenceFoldersByAssessmentControl(GetEvidenceFoldersByAssessmentControlRequest request);

        /// <summary>
        /// Paginator for ListAssessmentControlInsightsByControlDomain operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentControlInsightsByControlDomainPaginator ListAssessmentControlInsightsByControlDomain(ListAssessmentControlInsightsByControlDomainRequest request);

        /// <summary>
        /// Paginator for ListAssessmentFrameworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentFrameworksPaginator ListAssessmentFrameworks(ListAssessmentFrameworksRequest request);

        /// <summary>
        /// Paginator for ListAssessmentFrameworkShareRequests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentFrameworkShareRequestsPaginator ListAssessmentFrameworkShareRequests(ListAssessmentFrameworkShareRequestsRequest request);

        /// <summary>
        /// Paginator for ListAssessmentReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentReportsPaginator ListAssessmentReports(ListAssessmentReportsRequest request);

        /// <summary>
        /// Paginator for ListAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssessmentsPaginator ListAssessments(ListAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListControlDomainInsights operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListControlDomainInsightsPaginator ListControlDomainInsights(ListControlDomainInsightsRequest request);

        /// <summary>
        /// Paginator for ListControlDomainInsightsByAssessment operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListControlDomainInsightsByAssessmentPaginator ListControlDomainInsightsByAssessment(ListControlDomainInsightsByAssessmentRequest request);

        /// <summary>
        /// Paginator for ListControlInsightsByControlDomain operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListControlInsightsByControlDomainPaginator ListControlInsightsByControlDomain(ListControlInsightsByControlDomainRequest request);

        /// <summary>
        /// Paginator for ListControls operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListControlsPaginator ListControls(ListControlsRequest request);

        /// <summary>
        /// Paginator for ListKeywordsForDataSource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListKeywordsForDataSourcePaginator ListKeywordsForDataSource(ListKeywordsForDataSourceRequest request);

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNotificationsPaginator ListNotifications(ListNotificationsRequest request);
    }
}