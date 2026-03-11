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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details of the license configuration that this generator reports on.
    /// </summary>
    public partial class ReportContext
    {
        private List<string> _licenseAssetGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _licenseConfigurationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _reportEndDate;
        private DateTime? _reportStartDate;

        /// <summary>
        /// Gets and sets the property LicenseAssetGroupArns. 
        /// <para>
        /// Amazon Resource Names (ARNs) of the license asset groups to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseAssetGroupArns
        {
            get { return this._licenseAssetGroupArns; }
            set { this._licenseAssetGroupArns = value; }
        }

        // Check to see if LicenseAssetGroupArns property is set
        internal bool IsSetLicenseAssetGroupArns()
        {
            return this._licenseAssetGroupArns != null && (this._licenseAssetGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArns. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration that this generator reports
        /// on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseConfigurationArns
        {
            get { return this._licenseConfigurationArns; }
            set { this._licenseConfigurationArns = value; }
        }

        // Check to see if LicenseConfigurationArns property is set
        internal bool IsSetLicenseConfigurationArns()
        {
            return this._licenseConfigurationArns != null && (this._licenseConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportEndDate. 
        /// <para>
        /// End date for the report data collection period.
        /// </para>
        /// </summary>
        public DateTime? ReportEndDate
        {
            get { return this._reportEndDate; }
            set { this._reportEndDate = value; }
        }

        // Check to see if ReportEndDate property is set
        internal bool IsSetReportEndDate()
        {
            return this._reportEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportStartDate. 
        /// <para>
        /// Start date for the report data collection period.
        /// </para>
        /// </summary>
        public DateTime? ReportStartDate
        {
            get { return this._reportStartDate; }
            set { this._reportStartDate = value; }
        }

        // Check to see if ReportStartDate property is set
        internal bool IsSetReportStartDate()
        {
            return this._reportStartDate.HasValue; 
        }

    }
}