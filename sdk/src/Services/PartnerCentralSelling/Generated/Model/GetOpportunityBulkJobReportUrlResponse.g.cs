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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the GetOpportunityBulkJobReportUrl operation.
    /// </summary>
    public partial class GetOpportunityBulkJobReportUrlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time, in UTC, when the URL expires. Present only when <c>ReportStatus</c>
        /// is <c>AVAILABLE</c>.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that Partner Central couldn't generate the report. Present only when <c>ReportStatus</c>
        /// is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property ReportFormat. 
        /// <para>
        /// The format of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkFileFormat ReportFormat { get; set; }

        /// <summary>
        /// Checks to see if the ReportFormat property is set.
        /// </summary>
        internal bool IsSetReportFormat() => this.ReportFormat != null;

        /// <summary>
        /// Gets and sets the property ReportStatus. 
        /// <para>
        /// The status of the report. The <c>Url</c> is returned only when the status is <c>AVAILABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkReportStatus ReportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReportStatus property is set.
        /// </summary>
        internal bool IsSetReportStatus() => this.ReportStatus != null;

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// The records that the report covers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkReportType ReportType { get; set; }

        /// <summary>
        /// Checks to see if the ReportType property is set.
        /// </summary>
        internal bool IsSetReportType() => this.ReportType != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// A temporary URL for downloading the report. Present only when <c>ReportStatus</c>
        /// is <c>AVAILABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
