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
    /// Contains the unused capacity of a DB capacity reservation in one Availability Zone.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CancelDBCapacityReservation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateDBCapacityReservation</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDBCapacityReservations</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModifyDBCapacityReservation</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AvailableCapacityPerAvailabilityZone
    {
        private string _availabilityZone;
        private int? _availableCapacity;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailableCapacity. 
        /// <para>
        /// The number of DB instances that remain available in this Availability Zone. Amazon
        /// RDS decreases this value when a DB instance takes a unit of reserved capacity in this
        /// Availability Zone, and it increases this value when a DB instance releases that unit.
        /// </para>
        ///  
        /// <para>
        /// A DB instance with a pending modification also holds a unit of reserved capacity.
        /// A DB instance has a pending modification when Amazon RDS accepts a change to the DB
        /// instance and applies that change later, during the maintenance window. Amazon RDS
        /// holds the unit from the time that it accepts the request. To find a DB instance with
        /// a pending modification, check <c>PendingModifiedValues</c> in the response of <c>DescribeDBInstances</c>.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS reports available capacity only for a reservation that is in the <c>active</c>
        /// state and not past its end date. Otherwise, this value is <c>0</c>.
        /// </para>
        /// </summary>
        public int? AvailableCapacity
        {
            get { return this._availableCapacity; }
            set { this._availableCapacity = value; }
        }

        // Check to see if AvailableCapacity property is set
        internal bool IsSetAvailableCapacity()
        {
            return this._availableCapacity.HasValue; 
        }

    }
}