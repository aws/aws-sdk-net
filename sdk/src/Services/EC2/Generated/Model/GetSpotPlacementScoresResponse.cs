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
    /// This is the response object from the GetSpotPlacementScores operation.
    /// </summary>
    public partial class GetSpotPlacementScoresResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SpotPlacementScore> _spotPlacementScores = new List<SpotPlacementScore>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is <code>null</code> when there are no more items to return.
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

        /// <summary>
        /// Gets and sets the property SpotPlacementScores. 
        /// <para>
        /// The Spot placement score for the top 10 Regions or Availability Zones, scored on a
        /// scale from 1 to 10. Each score&#x2028; reflects how likely it is that each Region
        /// or Availability Zone will succeed at fulfilling the specified target capacity&#x2028;
        /// <i>at the time of the Spot placement score request</i>. A score of <code>10</code>
        /// means that your Spot capacity request is highly likely to succeed in that Region or
        /// Availability Zone. 
        /// </para>
        ///  
        /// <para>
        /// If you request a Spot placement score for Regions, a high score assumes that your
        /// fleet request will be configured to use all Availability Zones and the <code>capacity-optimized</code>
        /// allocation strategy. If you request a Spot placement score for Availability Zones,
        /// a high score assumes that your fleet request will be configured to use a single Availability
        /// Zone and the <code>capacity-optimized</code> allocation strategy.
        /// </para>
        ///  
        /// <para>
        /// Different&#x2028; Regions or Availability Zones might return the same score.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Spot placement score serves as a recommendation only. No score guarantees that
        /// your Spot request will be fully or partially fulfilled.
        /// </para>
        ///  </note>
        /// </summary>
        public List<SpotPlacementScore> SpotPlacementScores
        {
            get { return this._spotPlacementScores; }
            set { this._spotPlacementScores = value; }
        }

        // Check to see if SpotPlacementScores property is set
        internal bool IsSetSpotPlacementScores()
        {
            return this._spotPlacementScores != null && this._spotPlacementScores.Count > 0; 
        }

    }
}