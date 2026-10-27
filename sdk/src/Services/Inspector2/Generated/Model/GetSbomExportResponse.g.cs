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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the GetSbomExport operation.
    /// </summary>
    public partial class GetSbomExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code.
        /// </para>
        /// </summary>
        public ReportingErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// Contains details about the resource filter criteria used for the software bill of
        /// materials (SBOM) report.
        /// </para>
        /// </summary>
        public ResourceFilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteria property is set.
        /// </summary>
        internal bool IsSetFilterCriteria() => this.FilterCriteria != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the software bill of materials (SBOM) report.
        /// </para>
        /// </summary>
        public SbomReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The report ID of the software bill of materials (SBOM) report.
        /// </para>
        /// </summary>
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// Contains details of the Amazon S3 bucket and KMS key used to export findings
        /// </para>
        /// </summary>
        public Destination S3Destination { get; set; }

        /// <summary>
        /// Checks to see if the S3Destination property is set.
        /// </summary>
        internal bool IsSetS3Destination() => this.S3Destination != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the software bill of materials (SBOM) report.
        /// </para>
        /// </summary>
        public ExternalReportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
