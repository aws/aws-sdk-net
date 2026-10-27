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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBCapacityReservations operation.
    /// Describes one or more DB capacity reservations. A DB capacity reservation reserves
    /// capacity for Amazon RDS DB instances in one or more Availability Zones.
    /// 
    ///  
    /// <para>
    /// If you don't specify a <c>DBCapacityReservationIdentifier</c>, this operation returns
    /// information about all DB capacity reservations for your Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// This operation supports pagination.
    /// </para>
    /// </summary>
    public partial class DescribeDBCapacityReservationsRequest : AmazonRDSRequest
    {
        private string _dbCapacityReservationIdentifier;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _marker;
        private int? _maxRecords;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The identifier or the name of the DB capacity reservation to describe. You can specify
        /// the identifier, which has the prefix <c>dbcr-</c>, or the reservation name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DBCapacityReservationIdentifier
        {
            get { return this._dbCapacityReservationIdentifier; }
            set { this._dbCapacityReservationIdentifier = value; }
        }

        // Check to see if DBCapacityReservationIdentifier property is set
        internal bool IsSetDBCapacityReservationIdentifier()
        {
            return this._dbCapacityReservationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A filter that specifies which DB capacity reservations to describe.
        /// </para>
        ///  
        /// <para>
        /// Supported filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db-capacity-reservation-name</c> - Accepts DB capacity reservation names. The
        /// response includes only the reservations that these names identify. Use this filter
        /// to describe several reservations by name in one request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - Accepts reservation states. The response includes only the reservations
        /// in these states.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>engine</c> - Accepts database engine names. The response includes only the reservations
        /// that reserve capacity for these engines.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db-instance-class</c> - Accepts DB instance classes. The response includes only
        /// the reservations that reserve capacity for these DB instance classes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - Accepts Availability Zone names. The response includes
        /// only the reservations that cover these Availability Zones.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify more than one value for a filter, the response includes the reservations
        /// that match any of those values. When you specify more than one filter, the response
        /// includes only the reservations that match every filter.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS rejects the request when a filter name isn't in this list, or when a filter
        /// specifies no values.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>state</c> filter doesn't accept <c>expired</c>. To find an expired reservation,
        /// compare <c>EndDate</c> against the current date and time.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeDBCapacityReservations</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a pagination token called a marker is included
        /// in the response so that you can retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a minimum of 20.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't exceed 100.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=20, Max=100)]
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

    }
}