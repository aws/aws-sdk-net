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
    /// Container for the parameters to the UpdateCodeReview operation. Updates an existing
    /// code review configuration.
    /// </summary>
    public partial class UpdateCodeReviewRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The updated assets for the code review.
        /// </para>
        /// </summary>
        public Assets Assets { get; set; }

        /// <summary>
        /// Checks to see if the Assets property is set.
        /// </summary>
        internal bool IsSetAssets() => this.Assets != null;

        /// <summary>
        /// Gets and sets the property CodeRemediationStrategy. 
        /// <para>
        /// The updated code remediation strategy for the code review.
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
        /// The unique identifier of the code review to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CodeReviewId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewId property is set.
        /// </summary>
        internal bool IsSetCodeReviewId() => this.CodeReviewId != null;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The updated CloudWatch Logs configuration for the code review.
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
        /// The updated maximum number of billable task hours allowed for jobs started from this
        /// code review.
        /// </para>
        /// </summary>
        public double? MaxTaskHours { get; set; }

        /// <summary>
        /// Checks to see if the MaxTaskHours property is set.
        /// </summary>
        internal bool IsSetMaxTaskHours() => this.MaxTaskHours.HasValue;

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
        /// Gets and sets the property ReportFilters. 
        /// <para>
        /// The report-generation filters applied when the report is exported.
        /// </para>
        /// </summary>
        public ReportFilters ReportFilters { get; set; }

        /// <summary>
        /// Checks to see if the ReportFilters property is set.
        /// </summary>
        internal bool IsSetReportFilters() => this.ReportFilters != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The updated IAM service role for the code review.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The updated title of the code review.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property ValidationMode. 
        /// <para>
        /// The updated validation mode for the code review. Valid values are SIMULATED and DISABLED.
        /// </para>
        /// </summary>
        public ValidationMode ValidationMode { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMode property is set.
        /// </summary>
        internal bool IsSetValidationMode() => this.ValidationMode != null;
    }
}
