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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the ListDatasetImportJobs operation.
    /// </summary>
    public partial class ListDatasetImportJobsResponse : AmazonWebServiceResponse
    {
        private List<DatasetImportJobSummary> _datasetImportJobs = new List<DatasetImportJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DatasetImportJobs. 
        /// <para>
        /// An array of objects that summarize each dataset import job's properties.
        /// </para>
        /// </summary>
        public List<DatasetImportJobSummary> DatasetImportJobs
        {
            get { return this._datasetImportJobs; }
            set { this._datasetImportJobs = value; }
        }

        // Check to see if DatasetImportJobs property is set
        internal bool IsSetDatasetImportJobs()
        {
            return this._datasetImportJobs != null && this._datasetImportJobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon Forecast returns this token. To retrieve the
        /// next set of results, use the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
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