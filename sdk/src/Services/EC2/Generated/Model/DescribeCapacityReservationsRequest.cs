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
    /// Container for the parameters to the DescribeCapacityReservations operation.
    /// Describes one or more of your Capacity Reservations. The results describe only the
    /// Capacity Reservations in the AWS Region that you're currently using.
    /// </summary>
    public partial class DescribeCapacityReservationsRequest : AmazonEC2Request
    {
        private List<string> _capacityReservationIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CapacityReservationIds. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public List<string> CapacityReservationIds
        {
            get { return this._capacityReservationIds; }
            set { this._capacityReservationIds = value; }
        }

        // Check to see if CapacityReservationIds property is set
        internal bool IsSetCapacityReservationIds()
        {
            return this._capacityReservationIds != null && this._capacityReservationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>instance-type</code> - The type of instance for which the Capacity Reservation
        /// reserves capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The ID of the AWS account that owns the Capacity Reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone-id</code> - The Availability Zone ID of the Capacity Reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-platform</code> - The type of operating system for which the Capacity
        /// Reservation reserves capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone ID of the Capacity Reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tenancy</code> - Indicates the tenancy of the Capacity Reservation. A Capacity
        /// Reservation can have one of the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>default</code> - The Capacity Reservation is created on hardware that is shared
        /// with other AWS accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dedicated</code> - The Capacity Reservation is created on single-tenant hardware
        /// that is dedicated to a single AWS account.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>state</code> - The current state of the Capacity Reservation. A Capacity Reservation
        /// can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>active</code>- The Capacity Reservation is active and the capacity is available
        /// for your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>expired</code> - The Capacity Reservation expired automatically at the date
        /// and time specified in your request. The reserved capacity is no longer available for
        /// your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cancelled</code> - The Capacity Reservation was manually cancelled. The reserved
        /// capacity is no longer available for your use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code> - The Capacity Reservation request was successful but the capacity
        /// provisioning is still pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>failed</code> - The Capacity Reservation request has failed. A request might
        /// fail due to invalid request parameters, capacity constraints, or instance limit constraints.
        /// Failed requests are retained for 60 minutes.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>end-date</code> - The date and time at which the Capacity Reservation expires.
        /// When a Capacity Reservation expires, the reserved capacity is released and you can
        /// no longer launch instances into it. The Capacity Reservation's state changes to expired
        /// when it reaches its end date and time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>end-date-type</code> - Indicates the way in which the Capacity Reservation
        /// ends. A Capacity Reservation can have one of the following end types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>unlimited</code> - The Capacity Reservation remains active until you explicitly
        /// cancel it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>limited</code> - The Capacity Reservation expires automatically at a specified
        /// date and time.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>instance-match-criteria</code> - Indicates the type of instance launches that
        /// the Capacity Reservation accepts. The options include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>open</code> - The Capacity Reservation accepts all instances that have matching
        /// attributes (instance type, platform, and Availability Zone). Instances that have matching
        /// attributes launch into the Capacity Reservation automatically without specifying any
        /// additional parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>targeted</code> - The Capacity Reservation only accepts instances that have
        /// matching attributes (instance type, platform, and Availability Zone), and explicitly
        /// target the Capacity Reservation. This ensures that only permitted instances can use
        /// the reserved capacity.
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// results can be seen by sending another request with the returned nextToken value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The token to retrieve the next page of results.
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