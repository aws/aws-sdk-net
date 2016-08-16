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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
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
    /// Container for the parameters to the DescribeHostReservationOfferings operation.
    /// Describes the Dedicated Host Reservations that are available to purchase.
    /// 
    ///  
    /// <para>
    /// The results describe all the Dedicated Host Reservation offerings, including offerings
    /// that may not match the instance family and region of your Dedicated Hosts. When purchasing
    /// an offering, ensure that the the instance family and region of the offering matches
    /// that of the Dedicated Host/s it will be associated with. For an overview of supported
    /// instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
    /// Hosts Overview</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DescribeHostReservationOfferingsRequest : AmazonEC2Request
    {
        private List<Filter> _filter = new List<Filter>();
        private int? _maxDuration;
        private int? _maxResults;
        private int? _minDuration;
        private string _nextToken;
        private string _offeringId;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>instance-family</code> - The instance family of the offering (e.g., <code>m4</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>payment-option</code> - The payment option (<code>No Upfront</code> | <code>Partial
        /// Upfront</code> | <code>All Upfront</code>).
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
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// This is the maximum duration of the reservation you'd like to purchase, specified
        /// in seconds.Reservations are available in 1, 3, and 5 year terms. The number of seconds
        /// specified must be the number of seconds in a year (365x24x60x60) times one of the
        /// supported durations (1, 3, or 5). For example, specify 157680000 for 5 years.
        /// </para>
        /// </summary>
        public int MaxDuration
        {
            get { return this._maxDuration.GetValueOrDefault(); }
            set { this._maxDuration = value; }
        }

        // Check to see if MaxDuration property is set
        internal bool IsSetMaxDuration()
        {
            return this._maxDuration.HasValue; 
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
        /// Gets and sets the property MinDuration. 
        /// <para>
        /// This is the minimum duration of the reservation you'd like to purchase, specified
        /// in seconds. Reservations are available in 1, 3, and 5 year terms. The number of seconds
        /// specified must be the number of seconds in a year (365x24x60x60) times one of the
        /// supported durations (1, 3, or 5). For example, specify 94608000 for 3 years.
        /// </para>
        /// </summary>
        public int MinDuration
        {
            get { return this._minDuration.GetValueOrDefault(); }
            set { this._minDuration = value; }
        }

        // Check to see if MinDuration property is set
        internal bool IsSetMinDuration()
        {
            return this._minDuration.HasValue; 
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

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the reservation offering.
        /// </para>
        /// </summary>
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

    }
}