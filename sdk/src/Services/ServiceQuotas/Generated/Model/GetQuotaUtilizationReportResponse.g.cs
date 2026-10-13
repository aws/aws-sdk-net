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

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// This is the response object from the GetQuotaUtilizationReport operation.
    /// </summary>
    public partial class GetQuotaUtilizationReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code indicating the reason for failure when the report status is <c>FAILED</c>.
        /// This field is only present when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A detailed error message describing the failure when the report status is <c>FAILED</c>.
        /// This field is only present when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property GeneratedAt. 
        /// <para>
        /// The timestamp when the report was generated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedAt property is set.
        /// </summary>
        internal bool IsSetGeneratedAt() => this.GeneratedAt.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates more results are available. Include this token in the next
        /// request to retrieve the next page of results. If this field is not present, you have
        /// retrieved all available results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Quotas. 
        /// <para>
        /// A list of quota utilization records, sorted by utilization percentage in descending
        /// order. Each record includes the quota code, service code, service name, quota name,
        /// namespace, utilization percentage, default value, applied value, and whether the quota
        /// is adjustable. Up to 1,000 records are returned per page.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<QuotaUtilizationInfo> Quotas { get; set; } = AWSConfigs.InitializeCollections ? new List<QuotaUtilizationInfo>() : null;

        /// <summary>
        /// Checks to see if the Quotas property is set.
        /// </summary>
        internal bool IsSetQuotas() => this.Quotas != null && (this.Quotas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The unique identifier for the quota utilization report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the report generation. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The report generation is in progress. Retry this operation after
        /// a few seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The report is being processed. Continue polling until the status
        /// changes to <c>COMPLETED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The report is ready and quota utilization data is available in
        /// the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The report generation failed. Check the <c>ErrorCode</c> and <c>ErrorMessage</c>
        /// fields for details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of quotas included in the report across all pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
