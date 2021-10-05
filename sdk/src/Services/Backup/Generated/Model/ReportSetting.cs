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
    /// Contains detailed information about a report setting.
    /// </summary>
    public partial class ReportSetting
    {
        private List<string> _frameworkArns = new List<string>();
        private int? _numberOfFrameworks;
        private string _reportTemplate;

        /// <summary>
        /// Gets and sets the property FrameworkArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the frameworks a report covers.
        /// </para>
        /// </summary>
        public List<string> FrameworkArns
        {
            get { return this._frameworkArns; }
            set { this._frameworkArns = value; }
        }

        // Check to see if FrameworkArns property is set
        internal bool IsSetFrameworkArns()
        {
            return this._frameworkArns != null && this._frameworkArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfFrameworks. 
        /// <para>
        /// The number of frameworks a report covers.
        /// </para>
        /// </summary>
        public int NumberOfFrameworks
        {
            get { return this._numberOfFrameworks.GetValueOrDefault(); }
            set { this._numberOfFrameworks = value; }
        }

        // Check to see if NumberOfFrameworks property is set
        internal bool IsSetNumberOfFrameworks()
        {
            return this._numberOfFrameworks.HasValue; 
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
        [AWSProperty(Required=true)]
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

    }
}