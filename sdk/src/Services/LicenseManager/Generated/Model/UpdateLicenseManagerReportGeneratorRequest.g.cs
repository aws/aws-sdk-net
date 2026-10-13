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
    /// Container for the parameters to the UpdateLicenseManagerReportGenerator operation.
    /// Updates a report generator. <para> After you make changes to a report generator, it
    /// starts generating new reports within 60 minutes of being updated. </para>
    /// </summary>
    public partial class UpdateLicenseManagerReportGeneratorRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the report generator.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LicenseManagerReportGeneratorArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the report generator to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LicenseManagerReportGeneratorArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseManagerReportGeneratorArn property is set.
        /// </summary>
        internal bool IsSetLicenseManagerReportGeneratorArn() => this.LicenseManagerReportGeneratorArn != null;

        /// <summary>
        /// Gets and sets the property ReportContext. 
        /// <para>
        /// The report context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportContext ReportContext { get; set; }

        /// <summary>
        /// Checks to see if the ReportContext property is set.
        /// </summary>
        internal bool IsSetReportContext() => this.ReportContext != null;

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// Frequency by which reports are generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportFrequency ReportFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ReportFrequency property is set.
        /// </summary>
        internal bool IsSetReportFrequency() => this.ReportFrequency != null;

        /// <summary>
        /// Gets and sets the property ReportGeneratorName. 
        /// <para>
        /// Name of the report generator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ReportGeneratorName { get; set; }

        /// <summary>
        /// Checks to see if the ReportGeneratorName property is set.
        /// </summary>
        internal bool IsSetReportGeneratorName() => this.ReportGeneratorName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of reports to generate. The following report types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// License configuration report - Reports the number and details of consumed licenses
        /// for a license configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource report - Reports the tracked licenses and resource consumption for a license
        /// configuration.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Type { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null && (this.Type.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
