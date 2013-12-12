/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeReservedDBInstances operation.
    /// <para> Returns information about reserved DB instances for this account, or about a specified reserved DB instance. </para>
    /// </summary>
    public partial class DescribeReservedDBInstancesRequest : AmazonRDSRequest
    {
        private string reservedDBInstanceId;
        private string reservedDBInstancesOfferingId;
        private string dBInstanceClass;
        private string duration;
        private string productDescription;
        private string offeringType;
        private bool? multiAZ;
        private List<Filter> filters = new List<Filter>();
        private int? maxRecords;
        private string marker;


        /// <summary>
        /// The reserved DB instance identifier filter value. Specify this parameter to show only the reservation that matches the specified reservation
        /// ID.
        ///  
        /// </summary>
        public string ReservedDBInstanceId
        {
            get { return this.reservedDBInstanceId; }
            set { this.reservedDBInstanceId = value; }
        }

        // Check to see if ReservedDBInstanceId property is set
        internal bool IsSetReservedDBInstanceId()
        {
            return this.reservedDBInstanceId != null;
        }

        /// <summary>
        /// The offering identifier filter value. Specify this parameter to show only purchased reservations matching the specified offering identifier.
        ///  
        /// </summary>
        public string ReservedDBInstancesOfferingId
        {
            get { return this.reservedDBInstancesOfferingId; }
            set { this.reservedDBInstancesOfferingId = value; }
        }

        // Check to see if ReservedDBInstancesOfferingId property is set
        internal bool IsSetReservedDBInstancesOfferingId()
        {
            return this.reservedDBInstancesOfferingId != null;
        }

        /// <summary>
        /// The DB instance class filter value. Specify this parameter to show only those reservations matching the specified DB instances class.
        ///  
        /// </summary>
        public string DBInstanceClass
        {
            get { return this.dBInstanceClass; }
            set { this.dBInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;
        }

        /// <summary>
        /// The duration filter value, specified in years or seconds. Specify this parameter to show only reservations for this duration. Valid Values:
        /// <c>1 | 3 | 31536000 | 94608000</c>
        ///  
        /// </summary>
        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration != null;
        }

        /// <summary>
        /// The product description filter value. Specify this parameter to show only those reservations matching the specified product description.
        ///  
        /// </summary>
        public string ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// The offering type filter value. Specify this parameter to show only the available offerings matching the specified offering type. Valid
        /// Values: <c>"Light Utilization" | "Medium Utilization" | "Heavy Utilization" </c>
        ///  
        /// </summary>
        public string OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

        /// <summary>
        /// The Multi-AZ filter value. Specify this parameter to show only those reservations matching the specified Multi-AZ parameter.
        ///  
        /// </summary>
        public bool MultiAZ
        {
            get { return this.multiAZ ?? default(bool); }
            set { this.multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;
        }

        /// <summary>
        /// This parameter is not currently supported.
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more than the <c>MaxRecords</c> value is available, a pagination token called a
        /// marker is included in the response so that the following results can be retrieved. Default: 100 Constraints: minimum 20, maximum 100
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

        /// <summary>
        /// An optional pagination token provided by a previous request. If this parameter is specified, the response includes only records beyond the
        /// marker, up to the value specified by <c>MaxRecords</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
