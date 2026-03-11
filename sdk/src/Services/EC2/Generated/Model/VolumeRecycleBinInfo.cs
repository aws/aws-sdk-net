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
    /// Information about a volume that is currently in the Recycle Bin.
    /// </summary>
    public partial class VolumeRecycleBinInfo
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private DateTime? _createTime;
        private int? _iops;
        private OperatorResponse _operator;
        private string _outpostArn;
        private DateTime? _recycleBinEnterTime;
        private DateTime? _recycleBinExitTime;
        private int? _size;
        private string _snapshotId;
        private string _sourceVolumeId;
        private VolumeState _state;
        private int? _throughput;
        private string _volumeId;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the volume.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone for the volume.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time stamp when volume creation was initiated.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) for the volume.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the volume.
        /// </para>
        /// </summary>
        public OperatorResponse Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost on which the volume is stored. For more information, see <a
        /// href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-volumes-outposts.html">Amazon
        /// EBS volumes on Outposts</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecycleBinEnterTime. 
        /// <para>
        /// The date and time when the volume entered the Recycle Bin.
        /// </para>
        /// </summary>
        public DateTime? RecycleBinEnterTime
        {
            get { return this._recycleBinEnterTime; }
            set { this._recycleBinEnterTime = value; }
        }

        // Check to see if RecycleBinEnterTime property is set
        internal bool IsSetRecycleBinEnterTime()
        {
            return this._recycleBinEnterTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecycleBinExitTime. 
        /// <para>
        /// The date and time when the volume is to be permanently deleted from the Recycle Bin.
        /// </para>
        /// </summary>
        public DateTime? RecycleBinExitTime
        {
            get { return this._recycleBinExitTime; }
            set { this._recycleBinExitTime = value; }
        }

        // Check to see if RecycleBinExitTime property is set
        internal bool IsSetRecycleBinExitTime()
        {
            return this._recycleBinExitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The snapshot from which the volume was created, if applicable.
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
        /// Gets and sets the property SourceVolumeId. 
        /// <para>
        /// The ID of the source volume.
        /// </para>
        /// </summary>
        public string SourceVolumeId
        {
            get { return this._sourceVolumeId; }
            set { this._sourceVolumeId = value; }
        }

        // Check to see if SourceVolumeId property is set
        internal bool IsSetSourceVolumeId()
        {
            return this._sourceVolumeId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the volume.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Throughput. 
        /// <para>
        /// The throughput that the volume supports, in MiB/s.
        /// </para>
        /// </summary>
        public int? Throughput
        {
            get { return this._throughput; }
            set { this._throughput = value; }
        }

        // Check to see if Throughput property is set
        internal bool IsSetThroughput()
        {
            return this._throughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
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
        /// The volume type.
        /// </para>
        /// </summary>
        public VolumeType VolumeType
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