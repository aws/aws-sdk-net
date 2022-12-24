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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRecommendationExportJobs operation.
    /// Describes recommendation export jobs created in the last seven days.
    /// 
    ///  
    /// <para>
    /// Use the <a>ExportAutoScalingGroupRecommendations</a> or <a>ExportEC2InstanceRecommendations</a>
    /// actions to request an export of your recommendations. Then use the <a>DescribeRecommendationExportJobs</a>
    /// action to view your export jobs.
    /// </para>
    /// </summary>
    public partial class DescribeRecommendationExportJobsRequest : AmazonComputeOptimizerRequest
    {
        private List<JobFilter> _filters = new List<JobFilter>();
        private List<string> _jobIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of objects to specify a filter that returns a more specific list of export
        /// jobs.
        /// </para>
        /// </summary>
        public List<JobFilter> Filters
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
        /// Gets and sets the property JobIds. 
        /// <para>
        /// The identification numbers of the export jobs to return.
        /// </para>
        ///  
        /// <para>
        /// An export job ID is returned when you create an export using the <a>ExportAutoScalingGroupRecommendations</a>
        /// or <a>ExportEC2InstanceRecommendations</a> actions.
        /// </para>
        ///  
        /// <para>
        /// All export jobs created in the last seven days are returned if this parameter is omitted.
        /// </para>
        /// </summary>
        public List<string> JobIds
        {
            get { return this._jobIds; }
            set { this._jobIds = value; }
        }

        // Check to see if JobIds property is set
        internal bool IsSetJobIds()
        {
            return this._jobIds != null && this._jobIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of export jobs to return with a single request.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another request with the returned <code>nextToken</code>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to advance to the next page of export jobs.
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