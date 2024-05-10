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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the ListTimeSeries operation.
    /// </summary>
    public partial class ListTimeSeriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TimeSeriesSummary> _timeSeriesSummaries = AWSConfigs.InitializeCollections ? new List<TimeSeriesSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property TimeSeriesSummaries. 
        /// <para>
        /// One or more time series summaries to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TimeSeriesSummary> TimeSeriesSummaries
        {
            get { return this._timeSeriesSummaries; }
            set { this._timeSeriesSummaries = value; }
        }

        // Check to see if TimeSeriesSummaries property is set
        internal bool IsSetTimeSeriesSummaries()
        {
            return this._timeSeriesSummaries != null && (this._timeSeriesSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}