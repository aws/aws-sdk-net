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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the SearchJobs operation.
    /// </summary>
    public partial class SearchJobsResponse : AmazonWebServiceResponse
    {
        private List<JobSearchSummary> _jobs = AWSConfigs.InitializeCollections ? new List<JobSearchSummary>() : null;
        private int? _nextItemOffset;
        private int? _totalResults;

        /// <summary>
        /// Gets and sets the property Jobs. 
        /// <para>
        /// The jobs in the search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<JobSearchSummary> Jobs
        {
            get { return this._jobs; }
            set { this._jobs = value; }
        }

        // Check to see if Jobs property is set
        internal bool IsSetJobs()
        {
            return this._jobs != null && (this._jobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextItemOffset. 
        /// <para>
        /// The next incremental starting point after the defined <c>itemOffset</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int? NextItemOffset
        {
            get { return this._nextItemOffset; }
            set { this._nextItemOffset = value; }
        }

        // Check to see if NextItemOffset property is set
        internal bool IsSetNextItemOffset()
        {
            return this._nextItemOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResults. 
        /// <para>
        /// The total number of results in the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public int? TotalResults
        {
            get { return this._totalResults; }
            set { this._totalResults = value; }
        }

        // Check to see if TotalResults property is set
        internal bool IsSetTotalResults()
        {
            return this._totalResults.HasValue; 
        }

    }
}