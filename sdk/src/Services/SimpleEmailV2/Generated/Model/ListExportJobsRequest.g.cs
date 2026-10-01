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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListExportJobs operation. Lists all of the export
    /// jobs.
    /// </summary>
    public partial class ListExportJobsRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ExportSourceType. 
        /// <para>
        /// A value used to list export jobs that have a certain <c>ExportSourceType</c>.
        /// </para>
        /// </summary>
        public ExportSourceType ExportSourceType { get; set; }

        /// <summary>
        /// Checks to see if the ExportSourceType property is set.
        /// </summary>
        internal bool IsSetExportSourceType() => this.ExportSourceType != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// A value used to list export jobs that have a certain <c>JobStatus</c>.
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token returned from a previous call to <c>ListExportJobs</c> to indicate
        /// the position in the list of export jobs.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Maximum number of export jobs to return at once. Use this parameter to paginate results.
        /// If additional export jobs exist beyond the specified limit, the <c>NextToken</c> element
        /// is sent in the response. Use the <c>NextToken</c> value in subsequent calls to <c>ListExportJobs</c>
        /// to retrieve additional export jobs.
        /// </para>
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;
    }
}
