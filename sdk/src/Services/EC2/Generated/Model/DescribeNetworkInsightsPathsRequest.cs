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
    /// Container for the parameters to the DescribeNetworkInsightsPaths operation.
    /// Describes one or more of your paths.
    /// </summary>
    public partial class DescribeNetworkInsightsPathsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private List<string> _networkInsightsPathIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Destination - The ID of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DestinationPort - The destination port.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Name - The path name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Protocol - The protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Source - The ID of the resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NetworkInsightsPathIds. 
        /// <para>
        /// The IDs of the paths.
        /// </para>
        /// </summary>
        public List<string> NetworkInsightsPathIds
        {
            get { return this._networkInsightsPathIds; }
            set { this._networkInsightsPathIds = value; }
        }

        // Check to see if NetworkInsightsPathIds property is set
        internal bool IsSetNetworkInsightsPathIds()
        {
            return this._networkInsightsPathIds != null && this._networkInsightsPathIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
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