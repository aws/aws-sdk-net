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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the ListDICOMImportJobs operation.
    /// </summary>
    public partial class ListDICOMImportJobsResponse : AmazonWebServiceResponse
    {
        private List<DICOMImportJobSummary> _jobSummaries = new List<DICOMImportJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobSummaries. 
        /// <para>
        /// A list of job summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DICOMImportJobSummary> JobSummaries
        {
            get { return this._jobSummaries; }
            set { this._jobSummaries = value; }
        }

        // Check to see if JobSummaries property is set
        internal bool IsSetJobSummaries()
        {
            return this._jobSummaries != null && this._jobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used to retrieve the list of import jobs on the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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