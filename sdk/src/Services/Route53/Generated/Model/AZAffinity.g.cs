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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Specifies the location that an AZ-affinity resource record set answers DNS queries
    /// from. For the location types, from most to least specific, see <c>LocationType</c>.
    /// A query matches a location when Route 53 VPC Resolver reports that the query came
    /// from an Availability Zone (AZ) in that location. If Route 53 doesn't know which AZ
    /// a query came from, the query matches only the record for the <c>Global</c> location
    /// type. AZ-affinity routing chooses which record to return. It doesn't restrict which
    /// clients can get a record. You must specify both <c>LocationType</c> and <c>LocationId</c>.
    /// 
    ///  
    /// <para>
    /// To have Route 53 fall back to a less specific location when a resource is unhealthy,
    /// associate a health check with each record, or set <c>EvaluateTargetHealth</c> to <c>true</c>
    /// for alias records. If every record that matches a query is unhealthy, Route 53 responds
    /// with the most specific one.
    /// </para>
    /// </summary>
    public partial class AZAffinity
    {
        /// <summary>
        /// Gets and sets the property LocationType. 
        /// <para>
        /// The level of the location that <c>LocationId</c> identifies. Valid values, from most
        /// to least specific:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AvailabilityZone</c>: A single Availability Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AvailabilityZoneGroup</c>: A Zone Group, which is a group of Availability Zones
        /// in an Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Region</c>: An entire Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Partition</c>: An entire Amazon Web Services partition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Global</c>: All locations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// We recommend that you create a record for the <c>Global</c> location type so that
        /// every query gets an answer. Route 53 responds with it when a query matches no more
        /// specific record, or when it's the only healthy record that matches. Without a <c>Global</c>
        /// record, Route 53 returns a "no answer" response to queries that don't match any other
        /// record.
        /// </para>
        /// </summary>
        public AZAffinityLocationType LocationType { get; set; }

        /// <summary>
        /// Checks to see if the LocationType property is set.
        /// </summary>
        internal bool IsSetLocationType() => this.LocationType != null;

        /// <summary>
        /// Gets and sets the property LocationId. 
        /// <para>
        /// The ID of the location. You can specify only generally available Availability Zones
        /// and Zone Groups. Zone Group, Region, and partition IDs must belong to a partition
        /// that you can use. Specify the ID in lowercase, in the format that corresponds to <c>LocationType</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>AvailabilityZone</c>, the Availability Zone ID (not the Availability Zone name
        /// or a Local Zone ID), such as <c>use1-az1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>AvailabilityZoneGroup</c>, the Zone Group that an Availability Zone belongs
        /// to (not a Local Zone group), such as <c>us-east-1-zg-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>Region</c>, the Region code, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>Partition</c>, the partition name, such as <c>aws</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>Global</c>, the value <c>global</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LocationId { get; set; }

        /// <summary>
        /// Checks to see if the LocationId property is set.
        /// </summary>
        internal bool IsSetLocationId() => this.LocationId != null;
    }
}
