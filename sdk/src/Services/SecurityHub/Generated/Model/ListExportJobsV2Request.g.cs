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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListExportJobsV2 operation. Returns the findings
    /// export jobs in your account as a paginated list of <c>ExportSummary</c> objects. You
    /// can filter the results by job <c>Status</c> or <c>DataType</c>. <para> To page through
    /// the results, use the <c>MaxResults</c> and <c>NextToken</c> parameters. If the response
    /// includes a <c>NextToken</c> value, pass it in a subsequent request to retrieve the
    /// next page of results. </para> <para> Each <c>ExportSummary</c> reports the output
    /// <c>Format</c> of the job but not its full <c>OutputConfiguration</c>. To retrieve
    /// the filters and selected fields that a job was started with, call <c>GetExportJobV2</c>.
    /// </para>
    /// </summary>
    public partial class ListExportJobsV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Filters the results to export jobs that produce the specified data type.
        /// </para>
        /// </summary>
        public ExportDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Valid range is 1–20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required for pagination. On your first call, set the value of this parameter
        /// to <c>NULL</c>. For subsequent calls, to continue listing data, set the value of this
        /// parameter to the value returned in the previous response.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the results to export jobs that have the specified status.
        /// </para>
        /// </summary>
        public ExportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
