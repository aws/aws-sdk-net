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
    /// Contains the details of a DB capacity reservation.
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
    public partial class DBCapacityReservation
    {
        /// <summary>
        /// Gets and sets the property AvailableCapacityPerAvailabilityZoneList. 
        /// <para>
        /// The unused capacity of the reservation, reported for each Availability Zone of the
        /// reservation. Each entry names one Availability Zone, and it reports the number of
        /// DB instances that remain available in that Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS reports available capacity only for a reservation that is in the <c>active</c>
        /// state and not past its end date. Otherwise, each entry reports an available capacity
        /// of <c>0</c>. A future-dated reservation that hasn't started reports <c>0</c>, and
        /// a reservation that Amazon RDS is modifying reports <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// A reservation reports the <c>pending</c> state while Amazon RDS modifies it. Therefore,
        /// a reservation in the <c>active</c> state that reports no available capacity has no
        /// unused capacity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailableCapacityPerAvailabilityZone> AvailableCapacityPerAvailabilityZoneList { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailableCapacityPerAvailabilityZone>() : null;

        /// <summary>
        /// Checks to see if the AvailableCapacityPerAvailabilityZoneList property is set.
        /// </summary>
        internal bool IsSetAvailableCapacityPerAvailabilityZoneList() => this.AvailableCapacityPerAvailabilityZoneList != null && (this.AvailableCapacityPerAvailabilityZoneList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CommitmentInfo. 
        /// <para>
        /// The capacity commitment of the reservation. Amazon RDS returns this object only for
        /// a future-dated reservation.
        /// </para>
        /// </summary>
        public DBCapacityReservationCommitmentInfo CommitmentInfo { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentInfo property is set.
        /// </summary>
        internal bool IsSetCommitmentInfo() => this.CommitmentInfo != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the reservation was created, in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB capacity reservation.
        /// </para>
        /// </summary>
        public string DBCapacityReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationArn property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationArn() => this.DBCapacityReservationArn != null;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationIdentifier. 
        /// <para>
        /// The unique identifier of the DB capacity reservation. The identifier has the prefix
        /// <c>dbcr-</c>. Every other DB capacity reservation operation takes this identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBCapacityReservationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationIdentifier property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationIdentifier() => this.DBCapacityReservationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBCapacityReservationName. 
        /// <para>
        /// The name that you specified for the DB capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBCapacityReservationName { get; set; }

        /// <summary>
        /// Checks to see if the DBCapacityReservationName property is set.
        /// </summary>
        internal bool IsSetDBCapacityReservationName() => this.DBCapacityReservationName != null;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The DB instance class for the reserved capacity. You specify this value when you create
        /// the reservation, and you can't change it afterward.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 30)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time when the reservation expires, in Universal Coordinated Time (UTC).
        /// Amazon RDS doesn't return this value if the reservation doesn't expire.
        /// </para>
        ///  <important> 
        /// <para>
        /// A DB instance that uses the reservation keeps running after the reservation expires.
        /// It continues on unreserved capacity, and Amazon RDS doesn't stop it or modify it.
        /// However, Amazon RDS no longer reserves capacity for the DB instance. Amazon RDS might
        /// later move the DB instance to different hardware, for example during hardware maintenance.
        /// That move can fail when the Amazon Web Services Region has insufficient capacity for
        /// the DB instance class.
        /// </para>
        ///  </important>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine for the reserved capacity. You specify this value when you create
        /// the reservation, and you can't change it afterward.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model for the reserved capacity. Amazon RDS returns this value only for
        /// a reservation that reserves capacity for a specific license model. Amazon RDS doesn't
        /// return this value for a reservation whose database engine doesn't support a license
        /// model.
        /// </para>
        ///  
        /// <para>
        /// A DB instance launches into the reservation only when the license model of the DB
        /// instance matches this value. For a reservation that holds no license model, Amazon
        /// RDS applies no license model check at launch.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server Enterprise Edition and Standard Edition - <c>license-included
        /// | bring-your-own-media</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Microsoft SQL Server Developer Edition - <c>bring-your-own-license</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Oracle - <c>bring-your-own-license | license-included</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS for Db2 Standard Edition and Advanced Edition - <c>bring-your-own-license | marketplace-license</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For RDS for Db2 Standard Edition and Advanced Edition, a reservation created without
        /// a license model holds <c>bring-your-own-license</c>.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property ReservedCapacityPerAvailabilityZone. 
        /// <para>
        /// The number of DB instances that Amazon RDS reserves in each Availability Zone of the
        /// reservation. This value matches the <c>CapacityPerAvailabilityZone</c> parameter of
        /// the request. The total reserved capacity is this value multiplied by the number of
        /// Availability Zones of the reservation.
        /// </para>
        /// </summary>
        public int? ReservedCapacityPerAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCapacityPerAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetReservedCapacityPerAvailabilityZone() => this.ReservedCapacityPerAvailabilityZone.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time when a future-dated reservation starts, in Universal Coordinated
        /// Time (UTC). Amazon RDS doesn't return this value for a reservation that started immediately.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the DB capacity reservation. A DB instance can use the reservation
        /// in the <c>active</c> state only.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - Amazon RDS holds the reserved capacity, and a DB instance can use
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> - The reservation isn't ready to use yet. Amazon RDS is creating the
        /// reserved capacity, or it is applying a requested modification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>assessing</c> - Amazon RDS is evaluating the request for a future-dated reservation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>scheduled</c> - Amazon RDS accepted a future-dated reservation, and the reservation
        /// is waiting for its start date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>delayed</c> - Amazon RDS couldn't provide the reserved capacity of a future-dated
        /// reservation by its start date.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unsupported</c> - Amazon RDS can't fulfill the future-dated reservation as requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expired</c> - The reservation passed its end date. Amazon RDS releases the reserved
        /// capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cancelled</c> - You cancelled the reservation, and Amazon RDS released the reserved
        /// capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - Amazon RDS couldn't reserve the capacity.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The values <c>assessing</c>, <c>scheduled</c>, <c>delayed</c>, and <c>unsupported</c>
        /// apply to a future-dated reservation only.
        /// </para>
        /// </summary>
        public DBCapacityReservationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The tags associated with the DB capacity reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
