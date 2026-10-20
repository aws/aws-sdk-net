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
    /// Container for the parameters to the CreateDBCapacityReservation operation.
    /// Creates a DB capacity reservation. A DB capacity reservation reserves compute and
    /// memory capacity for DB instances of one DB instance class and one database engine.
    /// Amazon RDS reserves that capacity in each Availability Zone that you specify.
    /// 
    ///  
    /// <para>
    /// Amazon RDS reserves the same amount of capacity in every Availability Zone in the
    /// request. You set that amount with <c>CapacityPerAvailabilityZone</c>, and you set
    /// the Availability Zones with <c>AvailabilityZones</c>. The total reserved capacity
    /// is <c>CapacityPerAvailabilityZone</c> multiplied by the number of Availability Zones.
    /// </para>
    ///  
    /// <para>
    /// Specify <c>StartDate</c> and <c>CommitmentDuration</c> together to create a future-dated
    /// reservation. A future-dated reservation reserves capacity for a period that starts
    /// later. Amazon RDS holds that capacity for the length of the commitment.
    /// </para>
    ///  
    /// <para>
    /// A future-dated reservation has the following additional constraints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DBInstanceClass</c> must be a <c>db.c</c>, <c>db.m</c>, <c>db.r</c>, <c>db.t</c>,
    /// or <c>db.x</c> DB instance class. The letter after <c>db.</c> gives the DB instance
    /// class family. For example, <c>db.x2g.xlarge</c> qualifies, and <c>db.z1d.xlarge</c>
    /// doesn't.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>DBInstanceClass</c> is a <c>db.m</c> or <c>db.r</c> DB instance class, it must
    /// be from generation 7 or later. The digit after the family letter gives the generation.
    /// For example, <c>db.m7g.xlarge</c> qualifies, and <c>db.m5.xlarge</c> doesn't. A <c>db.c</c>,
    /// <c>db.t</c>, or <c>db.x</c> DB instance class has no generation requirement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The reserved capacity must total at least 32 vCPUs in each Availability Zone. Multiply
    /// <c>CapacityPerAvailabilityZone</c> by the number of vCPUs of the DB instance class.
    /// The product must be 32 or more.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CommitmentDuration</c> must be at least 14 days. For a <c>db.x</c> DB instance
    /// class, it must be at least 84 days.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StartDate</c> must be from 5 to 120 days in the future.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Therefore, a DB instance class with 2 vCPUs needs a <c>CapacityPerAvailabilityZone</c>
    /// of 16 or more, a class with 4 vCPUs needs 8 or more, a class with 8 vCPUs needs 4
    /// or more, and a class with 16 vCPUs needs 2 or more. For the number of vCPUs of each
    /// DB instance class, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
    /// instance classes</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't modify a future-dated reservation before it starts. You can't cancel a future-dated
    /// reservation in the <c>scheduled</c> state. You can't cancel a reservation in the <c>active</c>
    /// state during its capacity commitment. Therefore, you can't cancel a future-dated reservation
    /// from the time that Amazon RDS schedules it until the commitment ends.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDBCapacityReservationRequest : AmazonRDSRequest
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _capacityPerAvailabilityZone;
        private long? _commitmentDuration;
        private string _dbCapacityReservationName;
        private string _dbInstanceClass;
        private DateTime? _endDate;
        private string _engine;
        private string _licenseModel;
        private DateTime? _startDate;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones for the reservation.
        /// </para>
        ///  
        /// <para>
        /// You can't change the Availability Zones of a reservation after you create it. Reserved
        /// capacity in an Availability Zone that no DB instance uses stays unused.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must specify one or more Availability Zones.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each Availability Zone can appear only once.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each Availability Zone must be in the Amazon Web Services Region of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each Availability Zone must have capacity for the requested DB instance class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must include two or more Availability Zones to use the reservation for a Multi-AZ
        /// DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A DB instance can use reserved capacity only in an Availability Zone that its DB subnet
        /// group covers.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>us-east-1a</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityPerAvailabilityZone. 
        /// <para>
        /// The number of DB instances to reserve in each Availability Zone that you list in <c>AvailabilityZones</c>.
        /// Amazon RDS reserves this number of DB instances in every listed Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// A Single-AZ DB instance uses one unit of reserved capacity, in one Availability Zone.
        /// A Multi-AZ DB instance is one DB instance, and it uses one unit of reserved capacity
        /// in each of two Availability Zones. Therefore, a Multi-AZ DB instance uses two units
        /// in total. A read replica uses one unit of reserved capacity, in the same way as any
        /// other DB instance.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS reserves capacity in each Availability Zone separately. Reserved capacity
        /// in one Availability Zone can't serve a DB instance in another Availability Zone. A
        /// request for a DB instance fails when the Availability Zone of the DB instance has
        /// no available capacity.
        /// </para>
        ///  
        /// <para>
        /// Therefore, set this value to the number of DB instances that you want to run at the
        /// same time in one Availability Zone. Don't set it to the number that you want in total.
        /// </para>
        ///  
        /// <para>
        /// This value multiplied by the number of Availability Zones counts against the DB instances
        /// quota for your Amazon Web Services account in the Amazon Web Services Region. Your
        /// existing DB instances, and the unused capacity of your other reservations, count against
        /// the same quota.
        /// </para>
        ///  
        /// <para>
        /// To find the value of the DB instances quota, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Limits.html">Quotas
        /// and constraints for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Minimum 1.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? CapacityPerAvailabilityZone
        {
            get { return this._capacityPerAvailabilityZone; }
            set { this._capacityPerAvailabilityZone = value; }
        }

        // Check to see if CapacityPerAvailabilityZone property is set
        internal bool IsSetCapacityPerAvailabilityZone()
        {
            return this._capacityPerAvailabilityZone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// The length of the capacity commitment that you request for a future-dated reservation,
        /// in seconds. Amazon RDS measures this length from <c>StartDate</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon RDS can grant a shorter capacity commitment than you request. Therefore, read
        /// <c>CommitmentEndDate</c> in <c>CommitmentInfo</c> for the commitment that Amazon RDS
        /// granted.
        /// </para>
        ///  </note> 
        /// <para>
        /// The commitment doesn't end the reservation. Specify <c>EndDate</c> to set an expiration
        /// date. You can't cancel a reservation in the <c>active</c> state during the commitment.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Minimum 1209600, which is 14 days. For a <c>db.x</c> DB instance class, such as <c>db.x2g.xlarge</c>,
        /// the minimum is 7257600, which is 84 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be less than 315576000, which is 10 years.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify <c>StartDate</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2592000</c> 
        /// </para>
        /// </summary>
        public long? CommitmentDuration
        {
            get { return this._commitmentDuration; }
            set { this._commitmentDuration = value; }
        }

        // Check to see if CommitmentDuration property is set
        internal bool IsSetCommitmentDuration()
        {
            return this._commitmentDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBCapacityReservationName. 
        /// <para>
        /// The name of the DB capacity reservation. This name must be unique for your Amazon
        /// Web Services account in the Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 lowercase letters, digits, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a lowercase letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't contain more than 16 groups of characters separated by hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't begin with <c>dbcr-</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DBCapacityReservationName
        {
            get { return this._dbCapacityReservationName; }
            set { this._dbCapacityReservationName = value; }
        }

        // Check to see if DBCapacityReservationName property is set
        internal bool IsSetDBCapacityReservationName()
        {
            return this._dbCapacityReservationName != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The compute and memory capacity to reserve, for example <c>db.m5.large</c>. Not all
        /// DB instance classes are available in all Amazon Web Services Regions, or for all database
        /// engines. For the full list of DB instance classes, and availability for your engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// instance classes</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a DB instance class that the specified <c>Engine</c> supports.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For RDS for Oracle with <c>LicenseModel</c> set to <c>license-included</c>, some DB
        /// instance classes aren't supported. Either choose a supported DB instance class, or
        /// set <c>LicenseModel</c> to <c>bring-your-own-license</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=30)]
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
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time when the reservation expires, in Universal Coordinated Time (UTC).
        /// If you don't specify a value, the reservation doesn't expire.
        /// </para>
        ///  
        /// <para>
        /// To change the expiration of an existing reservation, use <c>ModifyDBCapacityReservation</c>.
        /// That operation takes <c>EndDateType</c> along with <c>EndDate</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a date and time in the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a future-dated reservation, must be at or after <c>StartDate</c> plus <c>CommitmentDuration</c>.
        /// For example, a reservation that starts on 2026-12-01 with a 30-day commitment can't
        /// expire before 2026-12-31. To reserve capacity for one calendar month, set <c>CommitmentDuration</c>
        /// to 30 days or fewer, not to the length of the month.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2026-12-31T23:59:59Z</c> 
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine to reserve capacity for.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>aurora-mysql</c> | <c>aurora-postgresql</c> | <c>mysql</c> | <c>postgres</c>
        /// | <c>mariadb</c> | <c>oracle-ee</c> | <c>oracle-ee-cdb</c> | <c>oracle-se2</c> | <c>oracle-se2-cdb</c>
        /// | <c>sqlserver-ee</c> | <c>sqlserver-se</c> | <c>sqlserver-web</c> | <c>sqlserver-ex</c>
        /// | <c>sqlserver-dev-ee</c> | <c>sqlserver-dev-se</c> | <c>db2-ae</c> | <c>db2-ce</c>
        /// | <c>db2-se</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Developer Edition engines <c>sqlserver-dev-ee</c> and <c>sqlserver-dev-se</c>
        /// support no Multi-AZ DB instance and no read replica. Therefore, a reservation for
        /// either engine serves Single-AZ DB instances only.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model to reserve capacity for. Specify this parameter only for RDS for
        /// Microsoft SQL Server Enterprise Edition, Standard Edition, and Developer Edition,
        /// for RDS for Oracle, or for RDS for Db2 Standard Edition and Advanced Edition. Amazon
        /// RDS rejects the request for any other engine. This includes Amazon Aurora, the Web
        /// and Express editions of RDS for Microsoft SQL Server, and RDS for Db2 Community Edition.
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
        /// A DB instance launches into the reservation only when the license model of the DB
        /// instance matches the license model of the reservation. For a reservation that holds
        /// no license model, Amazon RDS applies no license model check at launch.
        /// </para>
        ///  
        /// <para>
        /// For RDS for Microsoft SQL Server Enterprise Edition and Standard Edition, if you don't
        /// specify a value, Amazon RDS uses <c>license-included</c>.
        /// </para>
        ///  
        /// <para>
        /// For RDS for Microsoft SQL Server Developer Edition, if you don't specify a value,
        /// Amazon RDS uses <c>bring-your-own-license</c>. That is the only license model that
        /// these engines accept, and Amazon RDS rejects any other value.
        /// </para>
        ///  
        /// <para>
        /// For RDS for Oracle, if you don't specify a value, Amazon RDS uses the only orderable
        /// license model for the DB instance class. If more than one license model is orderable,
        /// you must specify one.
        /// </para>
        ///  
        /// <para>
        /// For RDS for Db2 Standard Edition and Advanced Edition, if you don't specify a value,
        /// Amazon RDS uses <c>bring-your-own-license</c>. To reserve capacity for Db2 DB instances
        /// that you license through Amazon Web Services Marketplace, specify <c>marketplace-license</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For RDS for Oracle, the license models that you can reserve depend on the engine and
        /// the DB instance class. RDS for Oracle Enterprise Edition doesn't support <c>license-included</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time when the reservation starts, in Universal Coordinated Time (UTC).
        /// Specify this parameter to create a future-dated reservation. If you don't specify
        /// a value, the reservation starts immediately.
        /// </para>
        ///  
        /// <para>
        /// A reservation that starts later always carries a capacity commitment. Therefore, a
        /// request that specifies <c>StartDate</c> must also meet every constraint of a future-dated
        /// reservation, including the minimum reserved capacity in each Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be from 5 to 120 days in the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must also specify <c>CommitmentDuration</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2026-12-01T00:00:00Z</c> 
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the DB capacity reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}