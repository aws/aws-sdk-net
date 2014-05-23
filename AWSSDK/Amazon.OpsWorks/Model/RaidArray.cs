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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes an instance's RAID array.
    /// </summary>
    public partial class RaidArray
    {
        private string _availabilityZone;
        private string _createdAt;
        private string _device;
        private string _instanceId;
        private int? _iops;
        private string _mountPoint;
        private string _name;
        private int? _numberOfDisks;
        private string _raidArrayId;
        private int? _raidLevel;
        private int? _size;
        private string _volumeType;


        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The array's Availability Zone. For more information, see  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }


        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithAvailabilityZone(string availabilityZone)
        {
            this._availabilityZone = availabilityZone;
            return this;
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the RAID array was created.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }


        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithCreatedAt(string createdAt)
        {
            this._createdAt = createdAt;
            return this;
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }


        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The array's Linux device. For example /dev/mdadm0.
        /// </para>
        /// </summary>
        public string Device
        {
            get { return this._device; }
            set { this._device = value; }
        }


        /// <summary>
        /// Sets the Device property
        /// </summary>
        /// <param name="device">The value to set for the Device property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithDevice(string device)
        {
            this._device = device;
            return this;
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }


        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// For PIOPS volumes, the IOPS per disk.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }


        /// <summary>
        /// Sets the Iops property
        /// </summary>
        /// <param name="iops">The value to set for the Iops property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithIops(int iops)
        {
            this._iops = iops;
            return this;
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MountPoint. 
        /// <para>
        /// The array's mount point.
        /// </para>
        /// </summary>
        public string MountPoint
        {
            get { return this._mountPoint; }
            set { this._mountPoint = value; }
        }


        /// <summary>
        /// Sets the MountPoint property
        /// </summary>
        /// <param name="mountPoint">The value to set for the MountPoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithMountPoint(string mountPoint)
        {
            this._mountPoint = mountPoint;
            return this;
        }

        // Check to see if MountPoint property is set
        internal bool IsSetMountPoint()
        {
            return this._mountPoint != null;
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The array name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property NumberOfDisks. 
        /// <para>
        /// The number of disks in the array.
        /// </para>
        /// </summary>
        public int NumberOfDisks
        {
            get { return this._numberOfDisks.GetValueOrDefault(); }
            set { this._numberOfDisks = value; }
        }


        /// <summary>
        /// Sets the NumberOfDisks property
        /// </summary>
        /// <param name="numberOfDisks">The value to set for the NumberOfDisks property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithNumberOfDisks(int numberOfDisks)
        {
            this._numberOfDisks = numberOfDisks;
            return this;
        }

        // Check to see if NumberOfDisks property is set
        internal bool IsSetNumberOfDisks()
        {
            return this._numberOfDisks.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RaidArrayId. 
        /// <para>
        /// The array ID.
        /// </para>
        /// </summary>
        public string RaidArrayId
        {
            get { return this._raidArrayId; }
            set { this._raidArrayId = value; }
        }


        /// <summary>
        /// Sets the RaidArrayId property
        /// </summary>
        /// <param name="raidArrayId">The value to set for the RaidArrayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithRaidArrayId(string raidArrayId)
        {
            this._raidArrayId = raidArrayId;
            return this;
        }

        // Check to see if RaidArrayId property is set
        internal bool IsSetRaidArrayId()
        {
            return this._raidArrayId != null;
        }


        /// <summary>
        /// Gets and sets the property RaidLevel. 
        /// <para>
        /// The <a href="http://en.wikipedia.org/wiki/Standard_RAID_levels">RAID level</a>.
        /// </para>
        /// </summary>
        public int RaidLevel
        {
            get { return this._raidLevel.GetValueOrDefault(); }
            set { this._raidLevel = value; }
        }


        /// <summary>
        /// Sets the RaidLevel property
        /// </summary>
        /// <param name="raidLevel">The value to set for the RaidLevel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithRaidLevel(int raidLevel)
        {
            this._raidLevel = raidLevel;
            return this;
        }

        // Check to see if RaidLevel property is set
        internal bool IsSetRaidLevel()
        {
            return this._raidLevel.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The array's size.
        /// </para>
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }


        /// <summary>
        /// Sets the Size property
        /// </summary>
        /// <param name="size">The value to set for the Size property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithSize(int size)
        {
            this._size = size;
            return this;
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type, standard or PIOPS.
        /// </para>
        /// </summary>
        public string VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }


        /// <summary>
        /// Sets the VolumeType property
        /// </summary>
        /// <param name="volumeType">The value to set for the VolumeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithVolumeType(string volumeType)
        {
            this._volumeType = volumeType;
            return this;
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}