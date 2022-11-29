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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the ListReadSetExportJobs operation.
    /// </summary>
    public partial class ListReadSetExportJobsResponse : AmazonWebServiceResponse
    {
        private List<ExportReadSetJobDetail> _exportJobs = new List<ExportReadSetJobDetail>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportJobs. 
        /// <para>
        /// A list of jobs.
        /// </para>
        /// </summary>
        public List<ExportReadSetJobDetail> ExportJobs
        {
            get { return this._exportJobs; }
            set { this._exportJobs = value; }
        }

        // Check to see if ExportJobs property is set
        internal bool IsSetExportJobs()
        {
            return this._exportJobs != null && this._exportJobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that's included if more results are available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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