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
    /// Container for the parameters to the DescribeCapacityReservationFleets operation.
    /// Describes one or more Capacity Reservation Fleets.
    /// </summary>
    public partial class DescribeCapacityReservationFleetsRequest : AmazonEC2Request
    {
        private List<string> _capacityReservationFleetIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetIds. 
        /// <para>
        /// The IDs of the Capacity Reservation Fleets to describe.
        /// </para>
        /// </summary>
        public List<string> CapacityReservationFleetIds
        {
            get { return this._capacityReservationFleetIds; }
            set { this._capacityReservationFleetIds = value; }
        }

        // Check to see if CapacityReservationFleetIds property is set
        internal bool IsSetCapacityReservationFleetIds()
        {
            return this._capacityReservationFleetIds != null && this._capacityReservationFleetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>state</code> - The state of the Fleet (<code>submitted</code> | <code>modifying</code>
        /// | <code>active</code> | <code>partially_fulfilled</code> | <code>expiring</code> |
        /// <code>expired</code> | <code>cancelling</code> | <code>cancelled</code> | <code>failed</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-match-criteria</code> - The instance matching criteria for the Fleet.
        /// Only <code>open</code> is supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tenancy</code> - The tenancy of the Fleet (<code>default</code> | <code>dedicated</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allocation-strategy</code> - The allocation strategy used by the Fleet. Only
        /// <code>prioritized</code> is supported.
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
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <code>nextToken</code>
        /// value. This value can be between 5 and 500. If <code>maxResults</code> is given a
        /// larger value than 500, you receive an error.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
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