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
    /// Container for the parameters to the DescribeFleets operation.
    /// Describes the specified EC2 Fleets or all of your EC2 Fleets.
    /// </summary>
    public partial class DescribeFleetsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _fleetIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>activity-status</code> - The progress of the EC2 Fleet ( <code>error</code>
        /// | <code>pending-fulfillment</code> | <code>pending-termination</code> | <code>fulfilled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>excess-capacity-termination-policy</code> - Indicates whether to terminate
        /// running instances if the target capacity is decreased below the current EC2 Fleet
        /// size (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fleet-state</code> - The state of the EC2 Fleet (<code>submitted</code> | <code>active</code>
        /// | <code>deleted</code> | <code>failed</code> | <code>deleted-running</code> | <code>deleted-terminating</code>
        /// | <code>modifying</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>replace-unhealthy-instances</code> - Indicates whether EC2 Fleet should replace
        /// unhealthy instances (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> - The type of request (<code>instant</code> | <code>request</code>
        /// | <code>maintain</code>).
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
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// The ID of the EC2 Fleets.
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

    }
}