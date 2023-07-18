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
    /// Output of a list milestones call.
    /// </summary>
    public partial class ListMilestonesResponse : AmazonWebServiceResponse
    {
        private List<MilestoneSummary> _milestoneSummaries = new List<MilestoneSummary>();
        private string _nextToken;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property MilestoneSummaries.
        /// </summary>
        public List<MilestoneSummary> MilestoneSummaries
        {
            get { return this._milestoneSummaries; }
            set { this._milestoneSummaries = value; }
        }

        // Check to see if MilestoneSummaries property is set
        internal bool IsSetMilestoneSummaries()
        {
            return this._milestoneSummaries != null && this._milestoneSummaries.Count > 0; 
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