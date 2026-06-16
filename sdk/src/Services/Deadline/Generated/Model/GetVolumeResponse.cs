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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Mixin that adds an optional ARN field to response structures. Apply to SummaryMixins
    /// (flows into Get, Summary, and BatchGet) and Create outputs.
    /// </summary>
    public partial class GetVolumeResponse : AmazonWebServiceResponse
    {
        private string _attachedWorkerId;
        private string _availabilityZoneId;
        private DateTime? _createdAt;
        private DateTime? _expiresAt;
        private string _farmId;
        private string _fleetId;
        private int? _iops;
        private DateTime? _lastAssignedAt;
        private DateTime? _lastReleasedAt;
        private int? _sizeGiB;
        private VolumeState _state;
        private int? _throughputMiB;
        private string _volumeId;
        private EbsVolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property AttachedWorkerId. 
        /// <para>
        /// The worker ID of the worker the volume is attached to.
        /// </para>
        /// </summary>
        public string AttachedWorkerId
        {
            get { return this._attachedWorkerId; }
            set { this._attachedWorkerId = value; }
        }

        // Check to see if AttachedWorkerId property is set
        internal bool IsSetAttachedWorkerId()
        {
            return this._attachedWorkerId != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time the volume expires and will be deleted.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the farm that contains the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID of the fleet that contains the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The IOPS of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=80000)]
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAssignedAt. 
        /// <para>
        /// The date and time the volume was last assigned to a worker.
        /// </para>
        /// </summary>
        public DateTime? LastAssignedAt
        {
            get { return this._lastAssignedAt; }
            set { this._lastAssignedAt = value; }
        }

        // Check to see if LastAssignedAt property is set
        internal bool IsSetLastAssignedAt()
        {
            return this._lastAssignedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastReleasedAt. 
        /// <para>
        /// The date and time the volume was last released from a worker.
        /// </para>
        /// </summary>
        public DateTime? LastReleasedAt
        {
            get { return this._lastReleasedAt; }
            set { this._lastReleasedAt = value; }
        }

        // Check to see if LastReleasedAt property is set
        internal bool IsSetLastReleasedAt()
        {
            return this._lastReleasedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeGiB. 
        /// <para>
        /// The volume size in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public int? SizeGiB
        {
            get { return this._sizeGiB; }
            set { this._sizeGiB = value; }
        }

        // Check to see if SizeGiB property is set
        internal bool IsSetSizeGiB()
        {
            return this._sizeGiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the volume.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VolumeState State
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
        /// Gets and sets the property ThroughputMiB. 
        /// <para>
        /// The throughput of the volume in MiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=125, Max=2000)]
        public int? ThroughputMiB
        {
            get { return this._throughputMiB; }
            set { this._throughputMiB = value; }
        }

        // Check to see if ThroughputMiB property is set
        internal bool IsSetThroughputMiB()
        {
            return this._throughputMiB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The volume ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The EBS volume type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EbsVolumeType VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}