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
    /// Container for the parameters to the GetQuotaUtilizationReport operation.
    /// Retrieves the quota utilization report for your Amazon Web Services account. This
    /// operation returns paginated results showing your quota usage across all Amazon Web
    /// Services services, sorted by utilization percentage in descending order (highest utilization
    /// first).
    /// 
    ///  
    /// <para>
    /// You must first initiate a report using the <c>StartQuotaUtilizationReport</c> operation.
    /// The report generation process is asynchronous and may take several seconds to complete.
    /// Poll this operation periodically to check the status and retrieve results when the
    /// report is ready.
    /// </para>
    ///  
    /// <para>
    /// Each report contains up to 1,000 quota records per page. Use the <c>NextToken</c>
    /// parameter to retrieve additional pages of results. Reports are automatically deleted
    /// after 15 minutes.
    /// </para>
    /// </summary>
    public partial class GetQuotaUtilizationReportRequest : AmazonServiceQuotasRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _reportId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page. The default value is 1,000 and the
        /// maximum allowed value is 1,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the next page of results to retrieve. This token is returned
        /// in the response when there are more results available. Omit this parameter for the
        /// first request.
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
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The unique identifier for the quota utilization report. This identifier is returned
        /// by the <c>StartQuotaUtilizationReport</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

    }
}