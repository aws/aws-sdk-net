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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Output of a list lens reviews call.
    /// </summary>
    public partial class ListLensReviewsResponse : AmazonWebServiceResponse
    {
        private List<LensReviewSummary> _lensReviewSummaries = AWSConfigs.InitializeCollections ? new List<LensReviewSummary>() : null;
        private int? _milestoneNumber;
        private string _nextToken;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property LensReviewSummaries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LensReviewSummary> LensReviewSummaries
        {
            get { return this._lensReviewSummaries; }
            set { this._lensReviewSummaries = value; }
        }

        // Check to see if LensReviewSummaries property is set
        internal bool IsSetLensReviewSummaries()
        {
            return this._lensReviewSummaries != null && (this._lensReviewSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MilestoneNumber.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MilestoneNumber
        {
            get { return this._milestoneNumber; }
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
        [AWSProperty(Min=32, Max=32)]
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