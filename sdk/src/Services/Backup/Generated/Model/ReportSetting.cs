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
    /// Contains detailed information about a report setting.
    /// </summary>
    public partial class ReportSetting
    {
        private List<string> _accounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _frameworkArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _numberOfFrameworks;
        private List<string> _organizationUnits = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _reportTemplate;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// These are the accounts to be included in the report.
        /// </para>
        ///  
        /// <para>
        /// Use string value of <c>ROOT</c> to include all organizational units.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FrameworkArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the frameworks a report covers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FrameworkArns
        {
            get { return this._frameworkArns; }
            set { this._frameworkArns = value; }
        }

        // Check to see if FrameworkArns property is set
        internal bool IsSetFrameworkArns()
        {
            return this._frameworkArns != null && (this._frameworkArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberOfFrameworks. 
        /// <para>
        /// The number of frameworks a report covers.
        /// </para>
        /// </summary>
        public int? NumberOfFrameworks
        {
            get { return this._numberOfFrameworks; }
            set { this._numberOfFrameworks = value; }
        }

        // Check to see if NumberOfFrameworks property is set
        internal bool IsSetNumberOfFrameworks()
        {
            return this._numberOfFrameworks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationUnits. 
        /// <para>
        /// These are the Organizational Units to be included in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationUnits
        {
            get { return this._organizationUnits; }
            set { this._organizationUnits = value; }
        }

        // Check to see if OrganizationUnits property is set
        internal bool IsSetOrganizationUnits()
        {
            return this._organizationUnits != null && (this._organizationUnits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// These are the Regions to be included in the report.
        /// </para>
        ///  
        /// <para>
        /// Use the wildcard as the string value to include all Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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