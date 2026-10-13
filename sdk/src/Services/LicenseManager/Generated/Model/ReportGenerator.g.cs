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
    /// Describe the details of a report generator.
    /// </summary>
    public partial class ReportGenerator
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the report was created.
        /// </para>
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime != null;

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
        /// Gets and sets the property LastReportGenerationTime. 
        /// <para>
        /// Time the last report was generated at.
        /// </para>
        /// </summary>
        public string LastReportGenerationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastReportGenerationTime property is set.
        /// </summary>
        internal bool IsSetLastReportGenerationTime() => this.LastReportGenerationTime != null;

        /// <summary>
        /// Gets and sets the property LastRunFailureReason. 
        /// <para>
        /// Failure message for the last report generation attempt.
        /// </para>
        /// </summary>
        public string LastRunFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the LastRunFailureReason property is set.
        /// </summary>
        internal bool IsSetLastRunFailureReason() => this.LastRunFailureReason != null;

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// Status of the last report generation attempt.
        /// </para>
        /// </summary>
        public string LastRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastRunStatus property is set.
        /// </summary>
        internal bool IsSetLastRunStatus() => this.LastRunStatus != null;

        /// <summary>
        /// Gets and sets the property LicenseManagerReportGeneratorArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the report generator.
        /// </para>
        /// </summary>
        public string LicenseManagerReportGeneratorArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseManagerReportGeneratorArn property is set.
        /// </summary>
        internal bool IsSetLicenseManagerReportGeneratorArn() => this.LicenseManagerReportGeneratorArn != null;

        /// <summary>
        /// Gets and sets the property ReportContext. 
        /// <para>
        /// License configuration type for this generator.
        /// </para>
        /// </summary>
        public ReportContext ReportContext { get; set; }

        /// <summary>
        /// Checks to see if the ReportContext property is set.
        /// </summary>
        internal bool IsSetReportContext() => this.ReportContext != null;

        /// <summary>
        /// Gets and sets the property ReportCreatorAccount. 
        /// <para>
        /// The Amazon Web Services account ID used to create the report generator.
        /// </para>
        /// </summary>
        public string ReportCreatorAccount { get; set; }

        /// <summary>
        /// Checks to see if the ReportCreatorAccount property is set.
        /// </summary>
        internal bool IsSetReportCreatorAccount() => this.ReportCreatorAccount != null;

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// Details about how frequently reports are generated.
        /// </para>
        /// </summary>
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
        public string ReportGeneratorName { get; set; }

        /// <summary>
        /// Checks to see if the ReportGeneratorName property is set.
        /// </summary>
        internal bool IsSetReportGeneratorName() => this.ReportGeneratorName != null;

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// Type of reports that are generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReportType { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReportType property is set.
        /// </summary>
        internal bool IsSetReportType() => this.ReportType != null && (this.ReportType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// Details of the S3 bucket that report generator reports are published to.
        /// </para>
        /// </summary>
        public S3Location S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the report generator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
