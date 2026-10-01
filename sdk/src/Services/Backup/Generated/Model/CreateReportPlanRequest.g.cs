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
    /// Container for the parameters to the CreateReportPlan operation. Creates a report plan.
    /// A report plan is a document that contains information about the contents of the report
    /// and where Backup will deliver it. <para> If you call <c>CreateReportPlan</c> with
    /// a plan that already exists, you receive an <c>AlreadyExistsException</c> exception.
    /// </para>
    /// </summary>
    public partial class CreateReportPlanRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>CreateReportPlanInput</c>. Retrying a successful request with the same
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
        /// A structure that contains information about where and how to deliver your reports,
        /// specifically your Amazon S3 bucket name, S3 key prefix, and the formats of your reports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportDeliveryChannel ReportDeliveryChannel { get; set; }

        /// <summary>
        /// Checks to see if the ReportDeliveryChannel property is set.
        /// </summary>
        internal bool IsSetReportDeliveryChannel() => this.ReportDeliveryChannel != null;

        /// <summary>
        /// Gets and sets the property ReportPlanDescription. 
        /// <para>
        /// An optional description of the report plan with a maximum of 1,024 characters.
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
        /// The unique name of the report plan. The name must be between 1 and 256 characters,
        /// starting with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
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
        /// Gets and sets the property ReportPlanTags. 
        /// <para>
        /// The tags to assign to the report plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ReportPlanTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ReportPlanTags property is set.
        /// </summary>
        internal bool IsSetReportPlanTags() => this.ReportPlanTags != null && (this.ReportPlanTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportSetting. 
        /// <para>
        /// Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are:
        /// </para>
        ///  
        /// <para>
        ///  <c>RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT
        /// | RESTORE_JOB_REPORT | SCAN_JOB_REPORT </c> 
        /// </para>
        ///  
        /// <para>
        /// If the report template is <c>RESOURCE_COMPLIANCE_REPORT</c> or <c>CONTROL_COMPLIANCE_REPORT</c>,
        /// this API resource also describes the report coverage by Amazon Web Services Regions
        /// and frameworks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportSetting ReportSetting { get; set; }

        /// <summary>
        /// Checks to see if the ReportSetting property is set.
        /// </summary>
        internal bool IsSetReportSetting() => this.ReportSetting != null;
    }
}
