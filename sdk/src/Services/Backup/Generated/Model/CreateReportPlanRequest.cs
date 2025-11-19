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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReportPlan operation.
    /// Creates a report plan. A report plan is a document that contains information about
    /// the contents of the report and where Backup will deliver it.
    /// 
    ///  
    /// <para>
    /// If you call <c>CreateReportPlan</c> with a plan that already exists, you receive an
    /// <c>AlreadyExistsException</c> exception.
    /// </para>
    /// </summary>
    public partial class CreateReportPlanRequest : AmazonBackupRequest
    {
        private string _idempotencyToken;
        private ReportDeliveryChannel _reportDeliveryChannel;
        private string _reportPlanDescription;
        private string _reportPlanName;
        private Dictionary<string, string> _reportPlanTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ReportSetting _reportSetting;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>CreateReportPlanInput</c>. Retrying a successful request with the same
        /// idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReportDeliveryChannel. 
        /// <para>
        /// A structure that contains information about where and how to deliver your reports,
        /// specifically your Amazon S3 bucket name, S3 key prefix, and the formats of your reports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReportPlanDescription. 
        /// <para>
        /// An optional description of the report plan with a maximum of 1,024 characters.
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
        /// The unique name of the report plan. The name must be between 1 and 256 characters,
        /// starting with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ReportPlanTags. 
        /// <para>
        /// The tags to assign to the report plan.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ReportPlanTags
        {
            get { return this._reportPlanTags; }
            set { this._reportPlanTags = value; }
        }

        // Check to see if ReportPlanTags property is set
        internal bool IsSetReportPlanTags()
        {
            return this._reportPlanTags != null && (this._reportPlanTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
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