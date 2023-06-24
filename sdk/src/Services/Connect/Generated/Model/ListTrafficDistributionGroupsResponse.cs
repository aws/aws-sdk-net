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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListTrafficDistributionGroups operation.
    /// </summary>
    public partial class ListTrafficDistributionGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TrafficDistributionGroupSummary> _trafficDistributionGroupSummaryList = new List<TrafficDistributionGroupSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
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
        /// Gets and sets the property TrafficDistributionGroupSummaryList. 
        /// <para>
        /// A list of traffic distribution groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<TrafficDistributionGroupSummary> TrafficDistributionGroupSummaryList
        {
            get { return this._trafficDistributionGroupSummaryList; }
            set { this._trafficDistributionGroupSummaryList = value; }
        }

        // Check to see if TrafficDistributionGroupSummaryList property is set
        internal bool IsSetTrafficDistributionGroupSummaryList()
        {
            return this._trafficDistributionGroupSummaryList != null && this._trafficDistributionGroupSummaryList.Count > 0; 
        }

    }
}