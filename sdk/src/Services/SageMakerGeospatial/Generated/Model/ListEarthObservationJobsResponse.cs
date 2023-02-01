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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// This is the response object from the ListEarthObservationJobs operation.
    /// </summary>
    public partial class ListEarthObservationJobsResponse : AmazonWebServiceResponse
    {
        private List<ListEarthObservationJobOutputConfig> _earthObservationJobSummaries = new List<ListEarthObservationJobOutputConfig>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EarthObservationJobSummaries. 
        /// <para>
        /// Contains summary information about the Earth Observation jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListEarthObservationJobOutputConfig> EarthObservationJobSummaries
        {
            get { return this._earthObservationJobSummaries; }
            set { this._earthObservationJobSummaries = value; }
        }

        // Check to see if EarthObservationJobSummaries property is set
        internal bool IsSetEarthObservationJobSummaries()
        {
            return this._earthObservationJobSummaries != null && this._earthObservationJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, you receive this token. Use it in your next
        /// request to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8192)]
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