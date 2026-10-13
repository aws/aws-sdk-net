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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details of the license configuration that this generator reports on.
    /// </summary>
    public partial class ReportContext
    {
        /// <summary>
        /// Gets and sets the property LicenseAssetGroupArns. 
        /// <para>
        /// Amazon Resource Names (ARNs) of the license asset groups to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseAssetGroupArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LicenseAssetGroupArns property is set.
        /// </summary>
        internal bool IsSetLicenseAssetGroupArns() => this.LicenseAssetGroupArns != null && (this.LicenseAssetGroupArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LicenseConfigurationArns. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license configuration that this generator reports
        /// on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LicenseConfigurationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LicenseConfigurationArns property is set.
        /// </summary>
        internal bool IsSetLicenseConfigurationArns() => this.LicenseConfigurationArns != null && (this.LicenseConfigurationArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportEndDate. 
        /// <para>
        /// End date for the report data collection period.
        /// </para>
        /// </summary>
        public DateTime? ReportEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ReportEndDate property is set.
        /// </summary>
        internal bool IsSetReportEndDate() => this.ReportEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property ReportStartDate. 
        /// <para>
        /// Start date for the report data collection period.
        /// </para>
        /// </summary>
        public DateTime? ReportStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ReportStartDate property is set.
        /// </summary>
        internal bool IsSetReportStartDate() => this.ReportStartDate.HasValue;
    }
}
