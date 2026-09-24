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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a code review job, which is an execution instance of a code review. A code
    /// review job progresses through preflight, static analysis, and finalizing steps.
    /// </summary>
    public partial class CodeReviewJob
    {
        /// <summary>
        /// Gets and sets the property CodeRemediationStrategy. 
        /// <para>
        /// The code remediation strategy for the code review job.
        /// </para>
        /// </summary>
        public CodeRemediationStrategy CodeRemediationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the CodeRemediationStrategy property is set.
        /// </summary>
        internal bool IsSetCodeRemediationStrategy() => this.CodeRemediationStrategy != null;

        /// <summary>
        /// Gets and sets the property CodeReviewId. 
        /// <para>
        /// The unique identifier of the code review associated with the job.
        /// </para>
        /// </summary>
        public string CodeReviewId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewId property is set.
        /// </summary>
        internal bool IsSetCodeReviewId() => this.CodeReviewId != null;

        /// <summary>
        /// Gets and sets the property CodeReviewJobId. 
        /// <para>
        /// The unique identifier of the code review job.
        /// </para>
        /// </summary>
        public string CodeReviewJobId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewJobId property is set.
        /// </summary>
        internal bool IsSetCodeReviewJobId() => this.CodeReviewJobId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the code review job was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The list of documents providing context for the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> Documents { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;

        /// <summary>
        /// Checks to see if the Documents property is set.
        /// </summary>
        internal bool IsSetDocuments() => this.Documents != null && (this.Documents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ErrorInformation. 
        /// <para>
        /// Error information if the code review job encountered an error.
        /// </para>
        /// </summary>
        public ErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInformation property is set.
        /// </summary>
        internal bool IsSetErrorInformation() => this.ErrorInformation != null;

        /// <summary>
        /// Gets and sets the property ExecutionContext. 
        /// <para>
        /// The execution context messages for the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExecutionContext> ExecutionContext { get; set; } = AWSConfigs.InitializeCollections ? new List<ExecutionContext>() : null;

        /// <summary>
        /// Checks to see if the ExecutionContext property is set.
        /// </summary>
        internal bool IsSetExecutionContext() => this.ExecutionContext != null && (this.ExecutionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegratedRepositories. 
        /// <para>
        /// The list of integrated repositories associated with the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegratedRepository> IntegratedRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegratedRepository>() : null;

        /// <summary>
        /// Checks to see if the IntegratedRepositories property is set.
        /// </summary>
        internal bool IsSetIntegratedRepositories() => this.IntegratedRepositories != null && (this.IntegratedRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the code review job.
        /// </para>
        /// </summary>
        public CloudWatchLog LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property MaxTaskHours. 
        /// <para>
        /// The maximum number of billable task hours allowed for this code review job. If the
        /// cumulative task hours reach this limit, the job is gracefully stopped.
        /// </para>
        /// </summary>
        public double? MaxTaskHours { get; set; }

        /// <summary>
        /// Checks to see if the MaxTaskHours property is set.
        /// </summary>
        internal bool IsSetMaxTaskHours() => this.MaxTaskHours.HasValue;

        /// <summary>
        /// Gets and sets the property Overview. 
        /// <para>
        /// An overview of the code review job results.
        /// </para>
        /// </summary>
        public string Overview { get; set; }

        /// <summary>
        /// Checks to see if the Overview property is set.
        /// </summary>
        internal bool IsSetOverview() => this.Overview != null;

        /// <summary>
        /// Gets and sets the property ReportDestination. 
        /// <para>
        /// The destination for publishing scan reports to an integrated document provider.
        /// </para>
        /// </summary>
        public ReportDestination ReportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ReportDestination property is set.
        /// </summary>
        internal bool IsSetReportDestination() => this.ReportDestination != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role used for the code review job.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property SourceCode. 
        /// <para>
        /// The list of source code repositories analyzed during the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCodeRepository> SourceCode { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceCodeRepository>() : null;

        /// <summary>
        /// Checks to see if the SourceCode property is set.
        /// </summary>
        internal bool IsSetSourceCode() => this.SourceCode != null && (this.SourceCode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code review job.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The list of steps in the code review job execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Step> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<Step>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the code review job.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the code review job was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
