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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeNetworkInsightsAnalyses operation.
    /// Describes one or more of your network insights analyses.
    /// </summary>
    public partial class DescribeNetworkInsightsAnalysesRequest : AmazonEC2Request
    {
        private DateTime? _analysisEndTime;
        private DateTime? _analysisStartTime;
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private List<string> _networkInsightsAnalysisIds = new List<string>();
        private string _networkInsightsPathId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnalysisEndTime. 
        /// <para>
        /// The time when the network insights analyses ended.
        /// </para>
        /// </summary>
        public DateTime AnalysisEndTime
        {
            get { return this._analysisEndTime.GetValueOrDefault(); }
            set { this._analysisEndTime = value; }
        }

        // Check to see if AnalysisEndTime property is set
        internal bool IsSetAnalysisEndTime()
        {
            return this._analysisEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AnalysisStartTime. 
        /// <para>
        /// The time when the network insights analyses started.
        /// </para>
        /// </summary>
        public DateTime AnalysisStartTime
        {
            get { return this._analysisStartTime.GetValueOrDefault(); }
            set { this._analysisStartTime = value; }
        }

        // Check to see if AnalysisStartTime property is set
        internal bool IsSetAnalysisStartTime()
        {
            return this._analysisStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PathFound - A Boolean value that indicates whether a feasible path is found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status - The status of the analysis (running | succeeded | failed).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NetworkInsightsAnalysisIds. 
        /// <para>
        /// The ID of the network insights analyses. You must specify either analysis IDs or a
        /// path ID.
        /// </para>
        /// </summary>
        public List<string> NetworkInsightsAnalysisIds
        {
            get { return this._networkInsightsAnalysisIds; }
            set { this._networkInsightsAnalysisIds = value; }
        }

        // Check to see if NetworkInsightsAnalysisIds property is set
        internal bool IsSetNetworkInsightsAnalysisIds()
        {
            return this._networkInsightsAnalysisIds != null && this._networkInsightsAnalysisIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathId. 
        /// <para>
        /// The ID of the path. You must specify either a path ID or analysis IDs.
        /// </para>
        /// </summary>
        public string NetworkInsightsPathId
        {
            get { return this._networkInsightsPathId; }
            set { this._networkInsightsPathId = value; }
        }

        // Check to see if NetworkInsightsPathId property is set
        internal bool IsSetNetworkInsightsPathId()
        {
            return this._networkInsightsPathId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
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