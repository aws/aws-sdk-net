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
    /// Contains detailed information about a report job. A report job compiles a report based
    /// on a report plan and publishes it to Amazon S3.
    /// </summary>
    public partial class ReportJob
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time that a report job is completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a report job is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReportDestination. 
        /// <para>
        /// The S3 bucket name and S3 keys for the destination where the report job publishes
        /// the report.
        /// </para>
        /// </summary>
        public ReportDestination ReportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ReportDestination property is set.
        /// </summary>
        internal bool IsSetReportDestination() => this.ReportDestination != null;

        /// <summary>
        /// Gets and sets the property ReportJobId. 
        /// <para>
        /// The identifier for a report job. A unique, randomly generated, Unicode, UTF-8 encoded
        /// string that is at most 1,024 bytes long. Report job IDs cannot be edited.
        /// </para>
        /// </summary>
        public string ReportJobId { get; set; }

        /// <summary>
        /// Checks to see if the ReportJobId property is set.
        /// </summary>
        internal bool IsSetReportJobId() => this.ReportJobId != null;

        /// <summary>
        /// Gets and sets the property ReportPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string ReportPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportPlanArn property is set.
        /// </summary>
        internal bool IsSetReportPlanArn() => this.ReportPlanArn != null;

        /// <summary>
        /// Gets and sets the property ReportTemplate. 
        /// <para>
        /// Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are: 
        /// </para>
        ///  
        /// <para>
        ///  <c>RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT
        /// | RESTORE_JOB_REPORT</c> 
        /// </para>
        /// </summary>
        public string ReportTemplate { get; set; }

        /// <summary>
        /// Checks to see if the ReportTemplate property is set.
        /// </summary>
        internal bool IsSetReportTemplate() => this.ReportTemplate != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a report job. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATED | RUNNING | COMPLETED | FAILED</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>COMPLETED</c> means that the report is available for your review at your designated
        /// destination. If the status is <c>FAILED</c>, review the <c>StatusMessage</c> for the
        /// reason.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the status of the report job.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
