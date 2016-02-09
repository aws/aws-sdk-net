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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Represents the returned data in response to a request action.
    /// </summary>
    public partial class ListFleetsResponse : AmazonWebServiceResponse
    {
        private List<string> _fleetIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// Set of fleet IDs matching the list request. You can retrieve additional information
        /// about all returned fleets by passing this result set to a call to <a>DescribeFleetAttributes</a>,
        /// <a>DescribeFleetCapacity</a>, and <a>DescribeFleetUtilization</a>.
        /// </para>
        /// </summary>
        public List<string> FleetIds
        {
            get { return this._fleetIds; }
            set { this._fleetIds = value; }
        }

        // Check to see if FleetIds property is set
        internal bool IsSetFleetIds()
        {
            return this._fleetIds != null && this._fleetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token indicating where to resume retrieving results on the next call to this action.
        /// If no token is returned, these results represent the end of the list.
        /// </para>
        ///  <note>
        /// <para>
        /// If a request has a limit that exactly matches the number of remaining results, a token
        /// is returned even though there are no more results to retrieve.
        /// </para>
        /// </note>
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