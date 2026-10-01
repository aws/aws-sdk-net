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
    /// Contains detailed information about a report plan.
    /// </summary>
    public partial class ReportPlan
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a report plan is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The deployment status of a report plan. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATE_IN_PROGRESS | UPDATE_IN_PROGRESS | DELETE_IN_PROGRESS | COMPLETED</c> 
        /// </para>
        /// </summary>
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property LastAttemptedExecutionTime. 
        /// <para>
        /// The date and time that a report job associated with this report plan last attempted
        /// to run, in Unix format and Coordinated Universal Time (UTC). The value of <c>LastAttemptedExecutionTime</c>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? LastAttemptedExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAttemptedExecutionTime property is set.
        /// </summary>
        internal bool IsSetLastAttemptedExecutionTime() => this.LastAttemptedExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulExecutionTime. 
        /// <para>
        /// The date and time that a report job associated with this report plan last successfully
        /// ran, in Unix format and Coordinated Universal Time (UTC). The value of <c>LastSuccessfulExecutionTime</c>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulExecutionTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulExecutionTime() => this.LastSuccessfulExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReportDeliveryChannel. 
        /// <para>
        /// Contains information about where and how to deliver your reports, specifically your
        /// Amazon S3 bucket name, S3 key prefix, and the formats of your reports.
        /// </para>
        /// </summary>
        public ReportDeliveryChannel ReportDeliveryChannel { get; set; }

        /// <summary>
        /// Checks to see if the ReportDeliveryChannel property is set.
        /// </summary>
        internal bool IsSetReportDeliveryChannel() => this.ReportDeliveryChannel != null;

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
        /// The unique name of the report plan. This name is between 1 and 256 characters starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ReportPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ReportPlanName property is set.
        /// </summary>
        internal bool IsSetReportPlanName() => this.ReportPlanName != null;

        /// <summary>
        /// Gets and sets the property ReportSetting. 
        /// <para>
        /// Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are:
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
