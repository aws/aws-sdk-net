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
    /// Container for the parameters to the DescribeHostReservations operation.
    /// Describes Dedicated Host Reservations which are associated with Dedicated Hosts in
    /// your account.
    /// </summary>
    public partial class DescribeHostReservationsRequest : AmazonEC2Request
    {
        private List<Filter> _filter = new List<Filter>();
        private List<string> _hostReservationIdSet = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>instance-family</code> - The instance family (e.g., <code>m4</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>payment-option</code> - The payment option (<code>No Upfront</code> | <code>Partial
        /// Upfront</code> | <code>All Upfront</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the reservation (<code>payment-pending</code> |
        /// <code>payment-failed</code> | <code>active</code> | <code>retired</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HostReservationIdSet. 
        /// <para>
        /// One or more host reservation IDs.
        /// </para>
        /// </summary>
        public List<string> HostReservationIdSet
        {
            get { return this._hostReservationIdSet; }
            set { this._hostReservationIdSet = value; }
        }

        // Check to see if HostReservationIdSet property is set
        internal bool IsSetHostReservationIdSet()
        {
            return this._hostReservationIdSet != null && this._hostReservationIdSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results can be seen by sending another request with the returned <code>nextToken</code>
        /// value. This value can be between 5 and 500; if <code>maxResults</code> is given a
        /// larger value than 500, you will receive an error.
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