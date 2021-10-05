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
    /// Contains detailed information about a report job. A report job compiles a report based
    /// on a report plan and publishes it to Amazon S3.
    /// </summary>
    public partial class ReportJob
    {
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private ReportDestination _reportDestination;
        private string _reportJobId;
        private string _reportPlanArn;
        private string _reportTemplate;
        private string _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time that a report job is completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>CompletionTime</code> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a report job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property ReportDestination. 
        /// <para>
        /// The S3 bucket name and S3 keys for the destination where the report job publishes
        /// the report.
        /// </para>
        /// </summary>
        public ReportDestination ReportDestination
        {
            get { return this._reportDestination; }
            set { this._reportDestination = value; }
        }

        // Check to see if ReportDestination property is set
        internal bool IsSetReportDestination()
        {
            return this._reportDestination != null;
        }

        /// <summary>
        /// Gets and sets the property ReportJobId. 
        /// <para>
        /// The identifier for a report job. A unique, randomly generated, Unicode, UTF-8 encoded
        /// string that is at most 1,024 bytes long. Report job IDs cannot be edited.
        /// </para>
        /// </summary>
        public string ReportJobId
        {
            get { return this._reportJobId; }
            set { this._reportJobId = value; }
        }

        // Check to see if ReportJobId property is set
        internal bool IsSetReportJobId()
        {
            return this._reportJobId != null;
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
        /// Gets and sets the property ReportTemplate. 
        /// <para>
        /// Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are: 
        /// </para>
        ///  
        /// <para>
        ///  <code>RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT
        /// | COPY_JOB_REPORT | RESTORE_JOB_REPORT</code> 
        /// </para>
        /// </summary>
        public string ReportTemplate
        {
            get { return this._reportTemplate; }
            set { this._reportTemplate = value; }
        }

        // Check to see if ReportTemplate property is set
        internal bool IsSetReportTemplate()
        {
            return this._reportTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a report job. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATED | RUNNING | COMPLETED | FAILED</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>COMPLETED</code> means that the report is available for your review at your
        /// designated destination. If the status is <code>FAILED</code>, review the <code>StatusMessage</code>
        /// for the reason.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the status of the report job.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}