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
    /// Container for the parameters to the StopDBInstance operation.
    /// Stops an Amazon RDS DB instance temporarily. When you stop a DB instance, Amazon RDS
    /// retains the DB instance's metadata, including its endpoint, DB parameter group, and
    /// option group membership. Amazon RDS also retains the transaction logs so you can do
    /// a point-in-time restore if necessary. The instance restarts automatically after 7
    /// days.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_StopInstance.html">
    /// Stopping an Amazon RDS DB Instance Temporarily</a> in the <i>Amazon RDS User Guide.</i>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// This command doesn't apply to RDS Custom, Aurora MySQL, and Aurora PostgreSQL. For
    /// Aurora clusters, use <c>StopDBCluster</c> instead.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StopDBInstanceRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _dbSnapshotIdentifier;
        private bool? _detachFromDBCapacityReservation;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The user-supplied instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The user-supplied instance identifier of the DB Snapshot created immediately before
        /// the DB instance is stopped.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this._dbSnapshotIdentifier; }
            set { this._dbSnapshotIdentifier = value; }
        }

        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this._dbSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DetachFromDBCapacityReservation. 
        /// <para>
        /// Specifies whether the DB instance stops using its DB capacity reservation when the
        /// DB instance stops. When you specify <c>true</c>, the DB instance belongs to no reservation
        /// after it stops, and a later start launches it outside the reservation.
        /// </para>
        ///  
        /// <para>
        /// By default, a stopped DB instance keeps its DB capacity reservation, and a later start
        /// returns the DB instance to the same reservation.
        /// </para>
        ///  
        /// <para>
        /// Every stop releases the unit of reserved capacity that the DB instance holds, for
        /// either value of this parameter. Another DB instance can then use that capacity. This
        /// parameter controls the reservation that the DB instance belongs to, and it does not
        /// control the release of the capacity.
        /// </para>
        ///  
        /// <para>
        /// If the DB instance uses no DB capacity reservation, this parameter has no effect.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon RDS holds no capacity for a stopped DB instance. When the reservation has no
        /// available capacity in the Availability Zone of the DB instance, a later start waits
        /// for capacity in that Availability Zone. When the DB instance belongs to no reservation,
        /// a later start can fail because the Amazon Web Services Region has insufficient capacity
        /// for the DB instance class.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? DetachFromDBCapacityReservation
        {
            get { return this._detachFromDBCapacityReservation; }
            set { this._detachFromDBCapacityReservation = value; }
        }

        // Check to see if DetachFromDBCapacityReservation property is set
        internal bool IsSetDetachFromDBCapacityReservation()
        {
            return this._detachFromDBCapacityReservation.HasValue; 
        }

    }
}