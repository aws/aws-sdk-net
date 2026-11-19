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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetSpotPlacementScores operation.
    /// </summary>
    public partial class GetSpotPlacementScoresResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is <c>null</c> when there are no more items to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SpotPlacementScores. 
        /// <para>
        /// The Spot placement score for the top 10 Regions or Availability Zones, scored on a
        /// scale from 1 to 10. Each score reflects how likely it is that each Region or Availability
        /// Zone will succeed at fulfilling the specified target capacity <i>at the time of the
        /// Spot placement score request</i>. A score of <c>10</c> means that your Spot capacity
        /// request is highly likely to succeed in that Region or Availability Zone. 
        /// </para>
        ///  
        /// <para>
        /// If you request a Spot placement score for Regions, a high score assumes that your
        /// fleet request will be configured to use all Availability Zones and the <c>capacity-optimized</c>
        /// allocation strategy. If you request a Spot placement score for Availability Zones,
        /// a high score assumes that your fleet request will be configured to use a single Availability
        /// Zone and the <c>capacity-optimized</c> allocation strategy.
        /// </para>
        ///  
        /// <para>
        /// Different Regions or Availability Zones might return the same score.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Spot placement score serves as a recommendation only. No score guarantees that
        /// your Spot request will be fully or partially fulfilled.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpotPlacementScore> SpotPlacementScores { get; set; } = AWSConfigs.InitializeCollections ? new List<SpotPlacementScore>() : null;

        /// <summary>
        /// Checks to see if the SpotPlacementScores property is set.
        /// </summary>
        internal bool IsSetSpotPlacementScores() => this.SpotPlacementScores != null && (this.SpotPlacementScores.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
