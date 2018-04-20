/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the properties of the Dedicated Host.
    /// </summary>
    public partial class Host
    {
        private DateTime? _allocationTime;
        private AutoPlacement _autoPlacement;
        private string _availabilityZone;
        private AvailableCapacity _availableCapacity;
        private string _clientToken;
        private string _hostId;
        private HostProperties _hostProperties;
        private string _hostReservationId;
        private List<HostInstance> _instances = new List<HostInstance>();
        private DateTime? _releaseTime;
        private AllocationState _state;

        /// <summary>
        /// Gets and sets the property AllocationTime. 
        /// <para>
        /// The time that the Dedicated Host was allocated.
        /// </para>
        /// </summary>
        public DateTime AllocationTime
        {
            get { return this._allocationTime.GetValueOrDefault(); }
            set { this._allocationTime = value; }
        }

        // Check to see if AllocationTime property is set
        internal bool IsSetAllocationTime()
        {
            return this._allocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoPlacement. 
        /// <para>
        /// Whether auto-placement is on or off.
        /// </para>
        /// </summary>
        public AutoPlacement AutoPlacement
        {
            get { return this._autoPlacement; }
            set { this._autoPlacement = value; }
        }

        // Check to see if AutoPlacement property is set
        internal bool IsSetAutoPlacement()
        {
            return this._autoPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Dedicated Host.
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
        /// The number of new instances that can be launched onto the Dedicated Host.
        /// </para>
        /// </summary>
        public AvailableCapacity AvailableCapacity
        {
            get { return this._availableCapacity; }
            set { this._availableCapacity = value; }
        }

        // Check to see if AvailableCapacity property is set
        internal bool IsSetAvailableCapacity()
        {
            return this._availableCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host.
        /// </para>
        /// </summary>
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property HostProperties. 
        /// <para>
        /// The hardware specifications of the Dedicated Host.
        /// </para>
        /// </summary>
        public HostProperties HostProperties
        {
            get { return this._hostProperties; }
            set { this._hostProperties = value; }
        }

        // Check to see if HostProperties property is set
        internal bool IsSetHostProperties()
        {
            return this._hostProperties != null;
        }

        /// <summary>
        /// Gets and sets the property HostReservationId. 
        /// <para>
        /// The reservation ID of the Dedicated Host. This returns a <code>null</code> response
        /// if the Dedicated Host doesn't have an associated reservation.
        /// </para>
        /// </summary>
        public string HostReservationId
        {
            get { return this._hostReservationId; }
            set { this._hostReservationId = value; }
        }

        // Check to see if HostReservationId property is set
        internal bool IsSetHostReservationId()
        {
            return this._hostReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The IDs and instance type that are currently running on the Dedicated Host.
        /// </para>
        /// </summary>
        public List<HostInstance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReleaseTime. 
        /// <para>
        /// The time that the Dedicated Host was released.
        /// </para>
        /// </summary>
        public DateTime ReleaseTime
        {
            get { return this._releaseTime.GetValueOrDefault(); }
            set { this._releaseTime = value; }
        }

        // Check to see if ReleaseTime property is set
        internal bool IsSetReleaseTime()
        {
            return this._releaseTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The Dedicated Host's state.
        /// </para>
        /// </summary>
        public AllocationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}