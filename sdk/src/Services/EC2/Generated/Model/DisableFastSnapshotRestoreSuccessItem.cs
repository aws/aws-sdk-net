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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes fast snapshot restores that were successfully disabled.
    /// </summary>
    public partial class DisableFastSnapshotRestoreSuccessItem
    {
        private string _availabilityZone;
        private DateTime? _disabledTime;
        private DateTime? _disablingTime;
        private DateTime? _enabledTime;
        private DateTime? _enablingTime;
        private DateTime? _optimizingTime;
        private string _ownerAlias;
        private string _ownerId;
        private string _snapshotId;
        private FastSnapshotRestoreStateCode _state;
        private string _stateTransitionReason;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
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
        /// Gets and sets the property DisabledTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <code>disabled</code> state.
        /// </para>
        /// </summary>
        public DateTime DisabledTime
        {
            get { return this._disabledTime.GetValueOrDefault(); }
            set { this._disabledTime = value; }
        }

        // Check to see if DisabledTime property is set
        internal bool IsSetDisabledTime()
        {
            return this._disabledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisablingTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <code>disabling</code> state.
        /// </para>
        /// </summary>
        public DateTime DisablingTime
        {
            get { return this._disablingTime.GetValueOrDefault(); }
            set { this._disablingTime = value; }
        }

        // Check to see if DisablingTime property is set
        internal bool IsSetDisablingTime()
        {
            return this._disablingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnabledTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <code>enabled</code> state.
        /// </para>
        /// </summary>
        public DateTime EnabledTime
        {
            get { return this._enabledTime.GetValueOrDefault(); }
            set { this._enabledTime = value; }
        }

        // Check to see if EnabledTime property is set
        internal bool IsSetEnabledTime()
        {
            return this._enabledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablingTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <code>enabling</code> state.
        /// </para>
        /// </summary>
        public DateTime EnablingTime
        {
            get { return this._enablingTime.GetValueOrDefault(); }
            set { this._enablingTime = value; }
        }

        // Check to see if EnablingTime property is set
        internal bool IsSetEnablingTime()
        {
            return this._enablingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizingTime. 
        /// <para>
        /// The time at which fast snapshot restores entered the <code>optimizing</code> state.
        /// </para>
        /// </summary>
        public DateTime OptimizingTime
        {
            get { return this._optimizingTime.GetValueOrDefault(); }
            set { this._optimizingTime = value; }
        }

        // Check to see if OptimizingTime property is set
        internal bool IsSetOptimizingTime()
        {
            return this._optimizingTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        /// The AWS owner alias that enabled fast snapshot restores on the snapshot. This is intended
        /// for future use.
        /// </para>
        /// </summary>
        public string OwnerAlias
        {
            get { return this._ownerAlias; }
            set { this._ownerAlias = value; }
        }

        // Check to see if OwnerAlias property is set
        internal bool IsSetOwnerAlias()
        {
            return this._ownerAlias != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the AWS account that enabled fast snapshot restores on the snapshot.
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of fast snapshot restores for the snapshot.
        /// </para>
        /// </summary>
        public FastSnapshotRestoreStateCode State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// The reason for the state transition. The possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Client.UserInitiated</code> - The state successfully transitioned to <code>enabling</code>
        /// or <code>disabling</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.UserInitiated - Lifecycle state transition</code> - The state successfully
        /// transitioned to <code>optimizing</code>, <code>enabled</code>, or <code>disabled</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StateTransitionReason
        {
            get { return this._stateTransitionReason; }
            set { this._stateTransitionReason = value; }
        }

        // Check to see if StateTransitionReason property is set
        internal bool IsSetStateTransitionReason()
        {
            return this._stateTransitionReason != null;
        }

    }
}