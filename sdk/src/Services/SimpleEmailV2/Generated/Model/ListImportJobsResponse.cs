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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An HTTP 200 response if the request succeeds, or an error message if the request fails.
    /// </summary>
    public partial class ListImportJobsResponse : AmazonWebServiceResponse
    {
        private List<ImportJobSummary> _importJobs = new List<ImportJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImportJobs. 
        /// <para>
        /// A list of the import job summaries.
        /// </para>
        /// </summary>
        public List<ImportJobSummary> ImportJobs
        {
            get { return this._importJobs; }
            set { this._importJobs = value; }
        }

        // Check to see if ImportJobs property is set
        internal bool IsSetImportJobs()
        {
            return this._importJobs != null && this._importJobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string token indicating that there might be additional import jobs available to
        /// be listed. Copy this token to a subsequent call to <code>ListImportJobs</code> with
        /// the same parameters to retrieve the next page of import jobs.
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

    }
}