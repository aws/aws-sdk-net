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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
        private string _errorCode;
        private string _errorMessage;
        private DateTime? _generatedAt;
        private string _nextToken;
        private List<QuotaUtilizationInfo> _quotas = AWSConfigs.InitializeCollections ? new List<QuotaUtilizationInfo>() : null;
        private string _reportId;
        private ReportStatus _status;
        private int? _totalCount;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code indicating the reason for failure when the report status is <c>FAILED</c>.
        /// This field is only present when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A detailed error message describing the failure when the report status is <c>FAILED</c>.
        /// This field is only present when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedAt. 
        /// <para>
        /// The timestamp when the report was generated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime GeneratedAt
        {
            get { return this._generatedAt.GetValueOrDefault(); }
            set { this._generatedAt = value; }
        }

        // Check to see if GeneratedAt property is set
        internal bool IsSetGeneratedAt()
        {
            return this._generatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates more results are available. Include this token in the next
        /// request to retrieve the next page of results. If this field is not present, you have
        /// retrieved all available results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Quotas. 
        /// <para>
        /// A list of quota utilization records, sorted by utilization percentage in descending
        /// order. Each record includes the quota code, service code, service name, quota name,
        /// namespace, utilization percentage, default value, applied value, and whether the quota
        /// is adjustable. Up to 1,000 records are returned per page.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<QuotaUtilizationInfo> Quotas
        {
            get { return this._quotas; }
            set { this._quotas = value; }
        }

        // Check to see if Quotas property is set
        internal bool IsSetQuotas()
        {
            return this._quotas != null && (this._quotas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The unique identifier for the quota utilization report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

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
        public ReportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of quotas included in the report across all pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}