/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSpotFleetRequests operation.
    /// Describes your Spot fleet requests.
    /// 
    ///  
    /// <para>
    /// Spot fleet requests are deleted 48 hours after they are canceled and their instances
    /// are terminated.
    /// </para>
    /// </summary>
    public partial class DescribeSpotFleetRequestsRequest : AmazonEC2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _spotFleetRequestIds = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Specify a value between
        /// 1 and 1000. The default value is 1000. To retrieve the remaining results, make another
        /// call with the returned <code>NextToken</code> value.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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
        /// Gets and sets the property SpotFleetRequestIds. 
        /// <para>
        /// The IDs of the Spot fleet requests.
        /// </para>
        /// </summary>
        public List<string> SpotFleetRequestIds
        {
            get { return this._spotFleetRequestIds; }
            set { this._spotFleetRequestIds = value; }
        }

        // Check to see if SpotFleetRequestIds property is set
        internal bool IsSetSpotFleetRequestIds()
        {
            return this._spotFleetRequestIds != null && this._spotFleetRequestIds.Count > 0; 
        }

    }
}