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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeReservedDBInstances operation. Returns
    /// information about reserved DB instances for this account, or about a specified reserved
    /// DB instance.
    /// </summary>
    public partial class DescribeReservedDBInstancesRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeReservedDBInstancesRequest() { }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The DB instance class filter value. Specify this parameter to show only those reservations
        /// matching the specified DB instances class.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration filter value, specified in years or seconds. Specify this parameter to
        /// show only reservations for this duration.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>1 | 3 | 31536000 | 94608000</c> 
        /// </para>
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This parameter isn't currently supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LeaseId. 
        /// <para>
        /// The lease identifier filter value. Specify this parameter to show only the reservation
        /// that matches the specified lease ID.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services Support might request the lease ID for an issue related to a reserved
        /// DB instance.
        /// </para>
        ///  </note>
        /// </summary>
        public string LeaseId { get; set; }

        /// <summary>
        /// Checks to see if the LeaseId property is set.
        /// </summary>
        internal bool IsSetLeaseId() => this.LeaseId != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more than the <c>MaxRecords</c>
        /// value is available, a pagination token called a marker is included in the response
        /// so you can retrieve the remaining results.
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
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Specifies whether to show only those reservations that support Multi-AZ.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type filter value. Specify this parameter to show only the available
        /// offerings matching the specified offering type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>"Partial Upfront" | "All Upfront" | "No Upfront" </c> 
        /// </para>
        /// </summary>
        public string OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The product description filter value. Specify this parameter to show only those reservations
        /// matching the specified product description.
        /// </para>
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProductDescription property is set.
        /// </summary>
        internal bool IsSetProductDescription() => this.ProductDescription != null;

        /// <summary>
        /// Gets and sets the property ReservedDBInstanceId. 
        /// <para>
        /// The reserved DB instance identifier filter value. Specify this parameter to show only
        /// the reservation that matches the specified reservation ID.
        /// </para>
        /// </summary>
        public string ReservedDBInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstanceId property is set.
        /// </summary>
        internal bool IsSetReservedDBInstanceId() => this.ReservedDBInstanceId != null;

        /// <summary>
        /// Gets and sets the property ReservedDBInstancesOfferingId. 
        /// <para>
        /// The offering identifier filter value. Specify this parameter to show only purchased
        /// reservations matching the specified offering identifier.
        /// </para>
        /// </summary>
        public string ReservedDBInstancesOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstancesOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedDBInstancesOfferingId() => this.ReservedDBInstancesOfferingId != null;
    }
}
