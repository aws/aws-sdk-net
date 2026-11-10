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
    /// Describes fast snapshot restores that were successfully disabled.
    /// </summary>
    public partial class DisableFastSnapshotRestoreSuccessItem
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property DisabledTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <c>disabled</c> state.
        /// </para>
        /// </summary>
        public DateTime? DisabledTime { get; set; }

        /// <summary>
        /// Checks to see if the DisabledTime property is set.
        /// </summary>
        internal bool IsSetDisabledTime() => this.DisabledTime.HasValue;

        /// <summary>
        /// Gets and sets the property DisablingTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <c>disabling</c> state.
        /// </para>
        /// </summary>
        public DateTime? DisablingTime { get; set; }

        /// <summary>
        /// Checks to see if the DisablingTime property is set.
        /// </summary>
        internal bool IsSetDisablingTime() => this.DisablingTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnabledTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <c>enabled</c> state.
        /// </para>
        /// </summary>
        public DateTime? EnabledTime { get; set; }

        /// <summary>
        /// Checks to see if the EnabledTime property is set.
        /// </summary>
        internal bool IsSetEnabledTime() => this.EnabledTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnablingTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <c>enabling</c> state.
        /// </para>
        /// </summary>
        public DateTime? EnablingTime { get; set; }

        /// <summary>
        /// Checks to see if the EnablingTime property is set.
        /// </summary>
        internal bool IsSetEnablingTime() => this.EnablingTime.HasValue;

        /// <summary>
        /// Gets and sets the property OptimizingTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <c>optimizing</c> state.
        /// </para>
        /// </summary>
        public DateTime? OptimizingTime { get; set; }

        /// <summary>
        /// Checks to see if the OptimizingTime property is set.
        /// </summary>
        internal bool IsSetOptimizingTime() => this.OptimizingTime.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        /// The Amazon Web Services owner alias that enabled fast snapshot restores on the snapshot.
        /// This is intended for future use.
        /// </para>
        /// </summary>
        public string OwnerAlias { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAlias property is set.
        /// </summary>
        internal bool IsSetOwnerAlias() => this.OwnerAlias != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that enabled fast snapshot restores on the
        /// snapshot.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of fast snapshot restores for the snapshot.
        /// </para>
        /// </summary>
        public FastSnapshotRestoreStateCode State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// The reason for the state transition. The possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Client.UserInitiated</c> - The state successfully transitioned to <c>enabling</c>
        /// or <c>disabling</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Client.UserInitiated - Lifecycle state transition</c> - The state successfully
        /// transitioned to <c>optimizing</c>, <c>enabled</c>, or <c>disabled</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StateTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionReason property is set.
        /// </summary>
        internal bool IsSetStateTransitionReason() => this.StateTransitionReason != null;
    }
}
