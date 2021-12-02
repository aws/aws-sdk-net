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
    /// Container for the parameters to the DescribeNetworkInsightsAccessScopeAnalyses operation.
    /// Describes the specified Network Access Scope analyses.
    /// </summary>
    public partial class DescribeNetworkInsightsAccessScopeAnalysesRequest : AmazonEC2Request
    {
        private DateTime? _analysisStartTimeBegin;
        private DateTime? _analysisStartTimeEnd;
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private List<string> _networkInsightsAccessScopeAnalysisIds = new List<string>();
        private string _networkInsightsAccessScopeId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnalysisStartTimeBegin. 
        /// <para>
        /// Filters the results based on the start time. The analysis must have started on or
        /// after this time.
        /// </para>
        /// </summary>
        public DateTime AnalysisStartTimeBegin
        {
            get { return this._analysisStartTimeBegin.GetValueOrDefault(); }
            set { this._analysisStartTimeBegin = value; }
        }

        // Check to see if AnalysisStartTimeBegin property is set
        internal bool IsSetAnalysisStartTimeBegin()
        {
            return this._analysisStartTimeBegin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AnalysisStartTimeEnd. 
        /// <para>
        /// Filters the results based on the start time. The analysis must have started on or
        /// before this time.
        /// </para>
        /// </summary>
        public DateTime AnalysisStartTimeEnd
        {
            get { return this._analysisStartTimeEnd.GetValueOrDefault(); }
            set { this._analysisStartTimeEnd = value; }
        }

        // Check to see if AnalysisStartTimeEnd property is set
        internal bool IsSetAnalysisStartTimeEnd()
        {
            return this._analysisStartTimeEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// There are no supported filters.
        /// </para>
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
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisIds. 
        /// <para>
        /// The IDs of the Network Access Scope analyses.
        /// </para>
        /// </summary>
        public List<string> NetworkInsightsAccessScopeAnalysisIds
        {
            get { return this._networkInsightsAccessScopeAnalysisIds; }
            set { this._networkInsightsAccessScopeAnalysisIds = value; }
        }

        // Check to see if NetworkInsightsAccessScopeAnalysisIds property is set
        internal bool IsSetNetworkInsightsAccessScopeAnalysisIds()
        {
            return this._networkInsightsAccessScopeAnalysisIds != null && this._networkInsightsAccessScopeAnalysisIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeId. 
        /// <para>
        /// The ID of the Network Access Scope.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeId
        {
            get { return this._networkInsightsAccessScopeId; }
            set { this._networkInsightsAccessScopeId = value; }
        }

        // Check to see if NetworkInsightsAccessScopeId property is set
        internal bool IsSetNetworkInsightsAccessScopeId()
        {
            return this._networkInsightsAccessScopeId != null;
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