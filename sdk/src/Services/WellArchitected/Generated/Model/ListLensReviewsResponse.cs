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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Output of a list lens reviews call.
    /// </summary>
    public partial class ListLensReviewsResponse : AmazonWebServiceResponse
    {
        private List<LensReviewSummary> _lensReviewSummaries = new List<LensReviewSummary>();
        private int? _milestoneNumber;
        private string _nextToken;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property LensReviewSummaries.
        /// </summary>
        public List<LensReviewSummary> LensReviewSummaries
        {
            get { return this._lensReviewSummaries; }
            set { this._lensReviewSummaries = value; }
        }

        // Check to see if LensReviewSummaries property is set
        internal bool IsSetLensReviewSummaries()
        {
            return this._lensReviewSummaries != null && this._lensReviewSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MilestoneNumber.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MilestoneNumber
        {
            get { return this._milestoneNumber.GetValueOrDefault(); }
            set { this._milestoneNumber = value; }
        }

        // Check to see if MilestoneNumber property is set
        internal bool IsSetMilestoneNumber()
        {
            return this._milestoneNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}