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
    /// Contains detailed information about a report setting.
    /// </summary>
    public partial class ReportSetting
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Accounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Accounts property is set.
        /// </summary>
        internal bool IsSetAccounts() => this.Accounts != null && (this.Accounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FrameworkArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the frameworks a report covers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FrameworkArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FrameworkArns property is set.
        /// </summary>
        internal bool IsSetFrameworkArns() => this.FrameworkArns != null && (this.FrameworkArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfFrameworks. 
        /// <para>
        /// The number of frameworks a report covers.
        /// </para>
        /// </summary>
        public int? NumberOfFrameworks { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfFrameworks property is set.
        /// </summary>
        internal bool IsSetNumberOfFrameworks() => this.NumberOfFrameworks.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationUnits. 
        /// <para>
        /// These are the Organizational Units to be included in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationUnits property is set.
        /// </summary>
        internal bool IsSetOrganizationUnits() => this.OrganizationUnits != null && (this.OrganizationUnits.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportTemplate. 
        /// <para>
        /// Identifies the report template for the report. Reports are built using a report template.
        /// The report templates are:
        /// </para>
        ///  
        /// <para>
        ///  <c>RESOURCE_COMPLIANCE_REPORT | CONTROL_COMPLIANCE_REPORT | BACKUP_JOB_REPORT | COPY_JOB_REPORT
        /// | RESTORE_JOB_REPORT | SCAN_JOB_REPORT</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReportTemplate { get; set; }

        /// <summary>
        /// Checks to see if the ReportTemplate property is set.
        /// </summary>
        internal bool IsSetReportTemplate() => this.ReportTemplate != null;
    }
}
