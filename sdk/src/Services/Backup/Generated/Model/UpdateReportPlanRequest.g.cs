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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReportPlan operation. Updates the specified
    /// report plan.
    /// </summary>
    public partial class UpdateReportPlanRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>UpdateReportPlanInput</c>. Retrying a successful request with the same
        /// idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property ReportDeliveryChannel. 
        /// <para>
        /// The information about where to deliver your reports, specifically your Amazon S3 bucket
        /// name, S3 key prefix, and the formats of your reports.
        /// </para>
        /// </summary>
        public ReportDeliveryChannel ReportDeliveryChannel { get; set; }

        /// <summary>
        /// Checks to see if the ReportDeliveryChannel property is set.
        /// </summary>
        internal bool IsSetReportDeliveryChannel() => this.ReportDeliveryChannel != null;

        /// <summary>
        /// Gets and sets the property ReportPlanDescription. 
        /// <para>
        /// An optional description of the report plan with a maximum 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ReportPlanDescription { get; set; }

        /// <summary>
        /// Checks to see if the ReportPlanDescription property is set.
        /// </summary>
        internal bool IsSetReportPlanDescription() => this.ReportPlanDescription != null;

        /// <summary>
        /// Gets and sets the property ReportPlanName. 
        /// <para>
        /// The unique name of the report plan. This name is between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ReportPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ReportPlanName property is set.
        /// </summary>
        internal bool IsSetReportPlanName() => this.ReportPlanName != null;

        /// <summary>
        /// Gets and sets the property ReportSetting. 
        /// <para>
        /// The report template for the report. Reports are built using a report template. The
        /// report templates are:
        /// </para>
        ///  
        /// <para>
        ///  <c>RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT
        /// | RESTORE_JOB_REPORT</c> 
        /// </para>
        ///  
        /// <para>
        /// If the report template is <c>RESOURCE_COMPLIANCE_REPORT</c> or <c>CONTROL_COMPLIANCE_REPORT</c>,
        /// this API resource also describes the report coverage by Amazon Web Services Regions
        /// and frameworks.
        /// </para>
        /// </summary>
        public ReportSetting ReportSetting { get; set; }

        /// <summary>
        /// Checks to see if the ReportSetting property is set.
        /// </summary>
        internal bool IsSetReportSetting() => this.ReportSetting != null;
    }
}
