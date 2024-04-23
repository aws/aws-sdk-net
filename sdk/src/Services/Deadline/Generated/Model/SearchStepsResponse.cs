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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the SearchSteps operation.
    /// </summary>
    public partial class SearchStepsResponse : AmazonWebServiceResponse
    {
        private int? _nextItemOffset;
        private List<StepSearchSummary> _steps = AWSConfigs.InitializeCollections ? new List<StepSearchSummary>() : null;
        private int? _totalResults;

        /// <summary>
        /// Gets and sets the property NextItemOffset. 
        /// <para>
        /// The next incremental starting point after the defined <c>itemOffset</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int NextItemOffset
        {
            get { return this._nextItemOffset.GetValueOrDefault(); }
            set { this._nextItemOffset = value; }
        }

        // Check to see if NextItemOffset property is set
        internal bool IsSetNextItemOffset()
        {
            return this._nextItemOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The steps in the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StepSearchSummary> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalResults. 
        /// <para>
        /// The total number of results in the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public int TotalResults
        {
            get { return this._totalResults.GetValueOrDefault(); }
            set { this._totalResults = value; }
        }

        // Check to see if TotalResults property is set
        internal bool IsSetTotalResults()
        {
            return this._totalResults.HasValue; 
        }

    }
}