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
    /// Describe the details of a report generator.
    /// </summary>
    public partial class ReportGenerator
    {
        private string _createTime;
        private string _description;
        private string _lastReportGenerationTime;
        private string _lastRunFailureReason;
        private string _lastRunStatus;
        private string _licenseManagerReportGeneratorArn;
        private ReportContext _reportContext;
        private string _reportCreatorAccount;
        private ReportFrequency _reportFrequency;
        private string _reportGeneratorName;
        private List<string> _reportType = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3Location _s3Location;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the report was created.
        /// </para>
        /// </summary>
        public string CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the report generator.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastReportGenerationTime. 
        /// <para>
        /// Time the last report was generated at.
        /// </para>
        /// </summary>
        public string LastReportGenerationTime
        {
            get { return this._lastReportGenerationTime; }
            set { this._lastReportGenerationTime = value; }
        }

        // Check to see if LastReportGenerationTime property is set
        internal bool IsSetLastReportGenerationTime()
        {
            return this._lastReportGenerationTime != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunFailureReason. 
        /// <para>
        /// Failure message for the last report generation attempt.
        /// </para>
        /// </summary>
        public string LastRunFailureReason
        {
            get { return this._lastRunFailureReason; }
            set { this._lastRunFailureReason = value; }
        }

        // Check to see if LastRunFailureReason property is set
        internal bool IsSetLastRunFailureReason()
        {
            return this._lastRunFailureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// Status of the last report generation attempt.
        /// </para>
        /// </summary>
        public string LastRunStatus
        {
            get { return this._lastRunStatus; }
            set { this._lastRunStatus = value; }
        }

        // Check to see if LastRunStatus property is set
        internal bool IsSetLastRunStatus()
        {
            return this._lastRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseManagerReportGeneratorArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the report generator.
        /// </para>
        /// </summary>
        public string LicenseManagerReportGeneratorArn
        {
            get { return this._licenseManagerReportGeneratorArn; }
            set { this._licenseManagerReportGeneratorArn = value; }
        }

        // Check to see if LicenseManagerReportGeneratorArn property is set
        internal bool IsSetLicenseManagerReportGeneratorArn()
        {
            return this._licenseManagerReportGeneratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReportContext. 
        /// <para>
        /// License configuration type for this generator.
        /// </para>
        /// </summary>
        public ReportContext ReportContext
        {
            get { return this._reportContext; }
            set { this._reportContext = value; }
        }

        // Check to see if ReportContext property is set
        internal bool IsSetReportContext()
        {
            return this._reportContext != null;
        }

        /// <summary>
        /// Gets and sets the property ReportCreatorAccount. 
        /// <para>
        /// The Amazon Web Services account ID used to create the report generator.
        /// </para>
        /// </summary>
        public string ReportCreatorAccount
        {
            get { return this._reportCreatorAccount; }
            set { this._reportCreatorAccount = value; }
        }

        // Check to see if ReportCreatorAccount property is set
        internal bool IsSetReportCreatorAccount()
        {
            return this._reportCreatorAccount != null;
        }

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// Details about how frequently reports are generated.
        /// </para>
        /// </summary>
        public ReportFrequency ReportFrequency
        {
            get { return this._reportFrequency; }
            set { this._reportFrequency = value; }
        }

        // Check to see if ReportFrequency property is set
        internal bool IsSetReportFrequency()
        {
            return this._reportFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ReportGeneratorName. 
        /// <para>
        /// Name of the report generator.
        /// </para>
        /// </summary>
        public string ReportGeneratorName
        {
            get { return this._reportGeneratorName; }
            set { this._reportGeneratorName = value; }
        }

        // Check to see if ReportGeneratorName property is set
        internal bool IsSetReportGeneratorName()
        {
            return this._reportGeneratorName != null;
        }

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// Type of reports that are generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReportType
        {
            get { return this._reportType; }
            set { this._reportType = value; }
        }

        // Check to see if ReportType property is set
        internal bool IsSetReportType()
        {
            return this._reportType != null && (this._reportType.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// Details of the S3 bucket that report generator reports are published to.
        /// </para>
        /// </summary>
        public S3Location S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the report generator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}