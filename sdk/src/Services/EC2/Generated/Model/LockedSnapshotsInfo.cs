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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a locked snapshot.
    /// </summary>
    public partial class LockedSnapshotsInfo
    {
        private int? _coolOffPeriod;
        private DateTime? _coolOffPeriodExpiresOn;
        private DateTime? _lockCreatedOn;
        private int? _lockDuration;
        private DateTime? _lockDurationStartTime;
        private DateTime? _lockExpiresOn;
        private LockState _lockState;
        private string _ownerId;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property CoolOffPeriod. 
        /// <para>
        /// The compliance mode cooling-off period, in hours.
        /// </para>
        /// </summary>
        public int? CoolOffPeriod
        {
            get { return this._coolOffPeriod; }
            set { this._coolOffPeriod = value; }
        }

        // Check to see if CoolOffPeriod property is set
        internal bool IsSetCoolOffPeriod()
        {
            return this._coolOffPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CoolOffPeriodExpiresOn. 
        /// <para>
        /// The date and time at which the compliance mode cooling-off period expires, in the
        /// UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? CoolOffPeriodExpiresOn
        {
            get { return this._coolOffPeriodExpiresOn; }
            set { this._coolOffPeriodExpiresOn = value; }
        }

        // Check to see if CoolOffPeriodExpiresOn property is set
        internal bool IsSetCoolOffPeriodExpiresOn()
        {
            return this._coolOffPeriodExpiresOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockCreatedOn. 
        /// <para>
        /// The date and time at which the snapshot was locked, in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? LockCreatedOn
        {
            get { return this._lockCreatedOn; }
            set { this._lockCreatedOn = value; }
        }

        // Check to see if LockCreatedOn property is set
        internal bool IsSetLockCreatedOn()
        {
            return this._lockCreatedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockDuration. 
        /// <para>
        /// The period of time for which the snapshot is locked, in days.
        /// </para>
        /// </summary>
        public int? LockDuration
        {
            get { return this._lockDuration; }
            set { this._lockDuration = value; }
        }

        // Check to see if LockDuration property is set
        internal bool IsSetLockDuration()
        {
            return this._lockDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockDurationStartTime. 
        /// <para>
        /// The date and time at which the lock duration started, in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        ///  
        /// <para>
        /// If you lock a snapshot that is in the <c>pending</c> state, the lock duration starts
        /// only once the snapshot enters the <c>completed</c> state.
        /// </para>
        /// </summary>
        public DateTime? LockDurationStartTime
        {
            get { return this._lockDurationStartTime; }
            set { this._lockDurationStartTime = value; }
        }

        // Check to see if LockDurationStartTime property is set
        internal bool IsSetLockDurationStartTime()
        {
            return this._lockDurationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockExpiresOn. 
        /// <para>
        /// The date and time at which the lock will expire, in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? LockExpiresOn
        {
            get { return this._lockExpiresOn; }
            set { this._lockExpiresOn = value; }
        }

        // Check to see if LockExpiresOn property is set
        internal bool IsSetLockExpiresOn()
        {
            return this._lockExpiresOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockState. 
        /// <para>
        /// The state of the snapshot lock. Valid states include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>compliance-cooloff</c> - The snapshot has been locked in compliance mode but it
        /// is still within the cooling-off period. The snapshot can't be deleted, but it can
        /// be unlocked and the lock settings can be modified by users with appropriate permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>governance</c> - The snapshot is locked in governance mode. The snapshot can't
        /// be deleted, but it can be unlocked and the lock settings can be modified by users
        /// with appropriate permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>compliance</c> - The snapshot is locked in compliance mode and the cooling-off
        /// period has expired. The snapshot can't be unlocked or deleted. The lock duration can
        /// only be increased by users with appropriate permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expired</c> - The snapshot was locked in compliance or governance mode but the
        /// lock duration has expired. The snapshot is not locked and can be deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LockState LockState
        {
            get { return this._lockState; }
            set { this._lockState = value; }
        }

        // Check to see if LockState property is set
        internal bool IsSetLockState()
        {
            return this._lockState != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The account ID of the Amazon Web Services account that owns the snapshot.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}