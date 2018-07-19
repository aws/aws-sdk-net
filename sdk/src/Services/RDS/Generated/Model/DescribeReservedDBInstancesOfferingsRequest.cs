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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeReservedDBInstancesOfferings operation.
    /// Lists available reserved DB instance offerings.
    /// </summary>
    public partial class DescribeReservedDBInstancesOfferingsRequest : AmazonRDSRequest
    {
        private string _dbInstanceClass;
        private string _duration;
        private List<Filter> _filters = new List<Filter>();
        private string _marker;
        private int? _maxRecords;
        private bool? _multiAZ;
        private string _offeringType;
        private string _productDescription;
        private string _reservedDBInstancesOfferingId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeReservedDBInstancesOfferingsRequest() { }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The DB instance class filter value. Specify this parameter to show only the available
        /// offerings matching the specified DB instance class.
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration filter value, specified in years or seconds. Specify this parameter to show
        /// only reservations for this duration.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>1 | 3 | 31536000 | 94608000</code> 
        /// </para>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter is not currently supported.
        /// </para>
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
        /// Gets and sets the property Marker. 
        /// <para>
        ///  An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>. 
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
        ///  The maximum number of records to include in the response. If more than the <code>MaxRecords</code>
        /// value is available, a pagination token called a marker is included in the response
        /// so that the following results can be retrieved. 
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// The Multi-AZ filter value. Specify this parameter to show only the available offerings
        /// matching the specified Multi-AZ parameter.
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type filter value. Specify this parameter to show only the available
        /// offerings matching the specified offering type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>"Partial Upfront" | "All Upfront" | "No Upfront" </code> 
        /// </para>
        /// </summary>
        public string OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// Product description filter value. Specify this parameter to show only the available
        /// offerings that contain the specified product description.
        /// </para>
        ///  <note> 
        /// <para>
        /// The results show offerings that partially match the filter value.
        /// </para>
        ///  </note>
        /// </summary>
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedDBInstancesOfferingId. 
        /// <para>
        /// The offering identifier filter value. Specify this parameter to show only the available
        /// offering that matches the specified reservation identifier.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>438012d3-4052-4cc7-b2e3-8d3372e0e706</code> 
        /// </para>
        /// </summary>
        public string ReservedDBInstancesOfferingId
        {
            get { return this._reservedDBInstancesOfferingId; }
            set { this._reservedDBInstancesOfferingId = value; }
        }

        // Check to see if ReservedDBInstancesOfferingId property is set
        internal bool IsSetReservedDBInstancesOfferingId()
        {
            return this._reservedDBInstancesOfferingId != null;
        }

    }
}