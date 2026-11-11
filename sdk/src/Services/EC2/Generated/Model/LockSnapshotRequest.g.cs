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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the LockSnapshot operation. Locks an Amazon EBS snapshot
    /// in either <i>governance</i> or <i>compliance</i> mode to protect it against accidental
    /// or malicious deletions for a specific duration. A locked snapshot can't be deleted.
    /// <para> You can also use this action to modify the lock settings for a snapshot that
    /// is already locked. The allowed modifications depend on the lock mode and lock state:
    /// </para> <ul> <li> <para> If the snapshot is locked in governance mode, you can modify
    /// the lock mode and the lock duration or lock expiration date. </para> </li> <li> <para>
    /// If the snapshot is locked in compliance mode and it is in the cooling-off period,
    /// you can modify the lock mode and the lock duration or lock expiration date. </para>
    /// </li> <li> <para> If the snapshot is locked in compliance mode and the cooling-off
    /// period has lapsed, you can only increase the lock duration or extend the lock expiration
    /// date. </para> </li> </ul>
    /// </summary>
    public partial class LockSnapshotRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CoolOffPeriod. 
        /// <para>
        /// The cooling-off period during which you can unlock the snapshot or modify the lock
        /// settings after locking the snapshot in compliance mode, in hours. After the cooling-off
        /// period expires, you can't unlock or delete the snapshot, decrease the lock duration,
        /// or change the lock mode. You can increase the lock duration after the cooling-off
        /// period expires.
        /// </para>
        ///  
        /// <para>
        /// The cooling-off period is optional when locking a snapshot in compliance mode. If
        /// you are locking the snapshot in governance mode, omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// To lock the snapshot in compliance mode immediately without a cooling-off period,
        /// omit this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you are extending the lock duration for a snapshot that is locked in compliance
        /// mode after the cooling-off period has expired, omit this parameter. If you specify
        /// a cooling-period in a such a request, the request fails.
        /// </para>
        ///  
        /// <para>
        /// Allowed values: Min 1, max 72.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 72)]
        public int? CoolOffPeriod { get; set; }

        /// <summary>
        /// Checks to see if the CoolOffPeriod property is set.
        /// </summary>
        internal bool IsSetCoolOffPeriod() => this.CoolOffPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date and time at which the snapshot lock is to automatically expire, in the UTC
        /// time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        ///  
        /// <para>
        /// You must specify either this parameter or <b>LockDuration</b>, but not both.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LockDuration. 
        /// <para>
        /// The period of time for which to lock the snapshot, in days. The snapshot lock will
        /// automatically expire after this period lapses.
        /// </para>
        ///  
        /// <para>
        /// You must specify either this parameter or <b>ExpirationDate</b>, but not both.
        /// </para>
        ///  
        /// <para>
        /// Allowed values: Min: 1, max 36500
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36500)]
        public int? LockDuration { get; set; }

        /// <summary>
        /// Checks to see if the LockDuration property is set.
        /// </summary>
        internal bool IsSetLockDuration() => this.LockDuration.HasValue;

        /// <summary>
        /// Gets and sets the property LockMode. 
        /// <para>
        /// The mode in which to lock the snapshot. Specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>governance</c> - Locks the snapshot in governance mode. Snapshots locked in governance
        /// mode can't be deleted until one of the following conditions are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The lock duration expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The snapshot is unlocked by a user with the appropriate permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Users with the appropriate IAM permissions can unlock the snapshot, increase or decrease
        /// the lock duration, and change the lock mode to <c>compliance</c> at any time.
        /// </para>
        ///  
        /// <para>
        /// If you lock a snapshot in <c>governance</c> mode, omit <b> CoolOffPeriod</b>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>compliance</c> - Locks the snapshot in compliance mode. Snapshots locked in compliance
        /// mode can't be unlocked by any user. They can be deleted only after the lock duration
        /// expires. Users can't decrease the lock duration or change the lock mode to <c>governance</c>.
        /// However, users with appropriate IAM permissions can increase the lock duration at
        /// any time.
        /// </para>
        ///  
        /// <para>
        /// If you lock a snapshot in <c>compliance</c> mode, you can optionally specify <b>CoolOffPeriod</b>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public LockMode LockMode { get; set; }

        /// <summary>
        /// Checks to see if the LockMode property is set.
        /// </summary>
        internal bool IsSetLockMode() => this.LockMode != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot to lock.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;
    }
}
