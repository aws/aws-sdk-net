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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// This is the response object from the GetQueryResultsWorkloadInsightsTopContributors operation.
    /// </summary>
    public partial class GetQueryResultsWorkloadInsightsTopContributorsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkloadInsightsTopContributorsRow> _topContributors = AWSConfigs.InitializeCollections ? new List<WorkloadInsightsTopContributorsRow>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
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
        /// Gets and sets the property TopContributors. 
        /// <para>
        /// The top contributor network flows overall for a specific metric type, for example,
        /// the number of retransmissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkloadInsightsTopContributorsRow> TopContributors
        {
            get { return this._topContributors; }
            set { this._topContributors = value; }
        }

        // Check to see if TopContributors property is set
        internal bool IsSetTopContributors()
        {
            return this._topContributors != null && (this._topContributors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}