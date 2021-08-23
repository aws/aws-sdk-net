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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about a report plan.
    /// </summary>
    public partial class ReportPlan
    {
        private DateTime? _creationTime;
        private string _deploymentStatus;
        private DateTime? _lastAttemptedExecutionTime;
        private DateTime? _lastSuccessfulExecutionTime;
        private ReportDeliveryChannel _reportDeliveryChannel;
        private string _reportPlanArn;
        private string _reportPlanDescription;
        private string _reportPlanName;
        private ReportSetting _reportSetting;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a report plan is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>CreationTime</code> is accurate to milliseconds. For
        /// example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The deployment status of a report plan. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATE_IN_PROGRESS | UPDATE_IN_PROGRESS | DELETE_IN_PROGRESS | COMPLETED</code>
        /// 
        /// </para>
        /// </summary>
        public string DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastAttemptedExecutionTime. 
        /// <para>
        /// The date and time that a report job associated with this report plan last attempted
        /// to run, in Unix format and Coordinated Universal Time (UTC). The value of <code>LastAttemptedExecutionTime</code>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime LastAttemptedExecutionTime
        {
            get { return this._lastAttemptedExecutionTime.GetValueOrDefault(); }
            set { this._lastAttemptedExecutionTime = value; }
        }

        // Check to see if LastAttemptedExecutionTime property is set
        internal bool IsSetLastAttemptedExecutionTime()
        {
            return this._lastAttemptedExecutionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulExecutionTime. 
        /// <para>
        /// The date and time that a report job associated with this report plan last successfully
        /// ran, in Unix format and Coordinated Universal Time (UTC). The value of <code>LastSuccessfulExecutionTime</code>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulExecutionTime
        {
            get { return this._lastSuccessfulExecutionTime.GetValueOrDefault(); }
            set { this._lastSuccessfulExecutionTime = value; }
        }

        // Check to see if LastSuccessfulExecutionTime property is set
        internal bool IsSetLastSuccessfulExecutionTime()
        {
            return this._lastSuccessfulExecutionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportDeliveryChannel. 
        /// <para>
        /// Contains information about where and how to deliver your reports, specifically your
        /// Amazon S3 bucket name, S3 key prefix, and the formats of your reports.
        /// </para>
        /// </summary>
        public ReportDeliveryChannel ReportDeliveryChannel
        {
            get { return this._reportDeliveryChannel; }
            set { this._reportDeliveryChannel = value; }
        }

        // Check to see if ReportDeliveryChannel property is set
        internal bool IsSetReportDeliveryChannel()
        {
            return this._reportDeliveryChannel != null;
        }

        /// <summary>
        /// Gets and sets the property ReportPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string ReportPlanArn
        {
            get { return this._reportPlanArn; }
            set { this._reportPlanArn = value; }
        }

        // Check to see if ReportPlanArn property is set
        internal bool IsSetReportPlanArn()
        {
            return this._reportPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReportPlanDescription. 
        /// <para>
        /// An optional description of the report plan with a maximum 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ReportPlanDescription
        {
            get { return this._reportPlanDescription; }
            set { this._reportPlanDescription = value; }
        }

        // Check to see if ReportPlanDescription property is set
        internal bool IsSetReportPlanDescription()
        {
            return this._reportPlanDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReportPlanName. 
        /// <para>
        /// The unique name of the report plan. This name is between 1 and 256 characters starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ReportPlanName
        {
            get { return this._reportPlanName; }
            set { this._reportPlanName = value; }
        }

        // Check to see if ReportPlanName property is set
        internal bool IsSetReportPlanName()
        {
            return this._reportPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ReportSetting. 
        /// <para>
        /// Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are:
        /// </para>
        ///  
        /// <para>
        ///  <code>BACKUP_JOB_REPORT | COPY_JOB_REPORT | RESTORE_JOB_REPORT</code> 
        /// </para>
        /// </summary>
        public ReportSetting ReportSetting
        {
            get { return this._reportSetting; }
            set { this._reportSetting = value; }
        }

        // Check to see if ReportSetting property is set
        internal bool IsSetReportSetting()
        {
            return this._reportSetting != null;
        }

    }
}