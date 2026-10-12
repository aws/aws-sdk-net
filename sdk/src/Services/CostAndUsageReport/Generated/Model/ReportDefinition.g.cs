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

namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// The definition of Amazon Web Services Cost and Usage Report. You can specify the report
    /// name, time unit, report format, compression format, S3 bucket, additional artifacts,
    /// and schema elements in the definition.
    /// </summary>
    public partial class ReportDefinition
    {
        /// <summary>
        /// Gets and sets the property AdditionalArtifacts. 
        /// <para>
        /// A list of manifests that you want Amazon Web Services to create for this report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalArtifacts property is set.
        /// </summary>
        internal bool IsSetAdditionalArtifacts() => this.AdditionalArtifacts != null && (this.AdditionalArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalSchemaElements. 
        /// <para>
        /// A list of strings that indicate additional content that Amazon Web Services includes
        /// in the report, such as individual resource IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AdditionalSchemaElements { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalSchemaElements property is set.
        /// </summary>
        internal bool IsSetAdditionalSchemaElements() => this.AdditionalSchemaElements != null && (this.AdditionalSchemaElements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingViewArn. 
        /// <para>
        ///  The Amazon resource name of the billing view. The <c>BillingViewArn</c> is needed
        /// to create Amazon Web Services Cost and Usage Report for each billing group maintained
        /// in the Amazon Web Services Billing Conductor service. The <c>BillingViewArn</c> for
        /// a billing group can be constructed as: <c>arn:aws:billing::payer-account-id:billingview/billing-group-primary-account-id</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string BillingViewArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingViewArn property is set.
        /// </summary>
        internal bool IsSetBillingViewArn() => this.BillingViewArn != null;

        /// <summary>
        /// Gets and sets the property Compression.
        /// </summary>
        [AWSProperty(Required = true)]
        public CompressionFormat Compression { get; set; }

        /// <summary>
        /// Checks to see if the Compression property is set.
        /// </summary>
        internal bool IsSetCompression() => this.Compression != null;

        /// <summary>
        /// Gets and sets the property Format.
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property RefreshClosedReports. 
        /// <para>
        /// Whether you want Amazon Web Services to update your reports after they have been finalized
        /// if Amazon Web Services detects charges related to previous months. These charges can
        /// include refunds, credits, or support fees.
        /// </para>
        /// </summary>
        public bool? RefreshClosedReports { get; set; }

        /// <summary>
        /// Checks to see if the RefreshClosedReports property is set.
        /// </summary>
        internal bool IsSetRefreshClosedReports() => this.RefreshClosedReports.HasValue;

        /// <summary>
        /// Gets and sets the property ReportName.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ReportName { get; set; }

        /// <summary>
        /// Checks to see if the ReportName property is set.
        /// </summary>
        internal bool IsSetReportName() => this.ReportName != null;

        /// <summary>
        /// Gets and sets the property ReportStatus. 
        /// <para>
        /// The status of the report.
        /// </para>
        /// </summary>
        public ReportStatus ReportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReportStatus property is set.
        /// </summary>
        internal bool IsSetReportStatus() => this.ReportStatus != null;

        /// <summary>
        /// Gets and sets the property ReportVersioning. 
        /// <para>
        /// Whether you want Amazon Web Services to overwrite the previous version of each report
        /// or to deliver the report in addition to the previous versions.
        /// </para>
        /// </summary>
        public ReportVersioning ReportVersioning { get; set; }

        /// <summary>
        /// Checks to see if the ReportVersioning property is set.
        /// </summary>
        internal bool IsSetReportVersioning() => this.ReportVersioning != null;

        /// <summary>
        /// Gets and sets the property S3Bucket.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Prefix.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;

        /// <summary>
        /// Gets and sets the property S3Region.
        /// </summary>
        [AWSProperty(Required = true)]
        public AWSRegion S3Region { get; set; }

        /// <summary>
        /// Checks to see if the S3Region property is set.
        /// </summary>
        internal bool IsSetS3Region() => this.S3Region != null;

        /// <summary>
        /// Gets and sets the property TimeUnit.
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeUnit TimeUnit { get; set; }

        /// <summary>
        /// Checks to see if the TimeUnit property is set.
        /// </summary>
        internal bool IsSetTimeUnit() => this.TimeUnit != null;
    }
}
