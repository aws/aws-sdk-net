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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
    /// Container for the parameters to the ListExportJobs operation.
    /// Lists all of the export jobs.
    /// </summary>
    public partial class ListExportJobsRequest : AmazonSimpleEmailServiceV2Request
    {
        private ExportSourceType _exportSourceType;
        private JobStatus _jobStatus;
        private string _nextToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property ExportSourceType. 
        /// <para>
        /// A value used to list export jobs that have a certain <c>ExportSourceType</c>.
        /// </para>
        /// </summary>
        public ExportSourceType ExportSourceType
        {
            get { return this._exportSourceType; }
            set { this._exportSourceType = value; }
        }

        // Check to see if ExportSourceType property is set
        internal bool IsSetExportSourceType()
        {
            return this._exportSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// A value used to list export jobs that have a certain <c>JobStatus</c>.
        /// </para>
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token returned from a previous call to <c>ListExportJobs</c> to indicate
        /// the position in the list of export jobs.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PageSize. 
        /// <para>
        /// Maximum number of export jobs to return at once. Use this parameter to paginate results.
        /// If additional export jobs exist beyond the specified limit, the <c>NextToken</c> element
        /// is sent in the response. Use the <c>NextToken</c> value in subsequent calls to <c>ListExportJobs</c>
        /// to retrieve additional export jobs.
        /// </para>
        /// </summary>
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}