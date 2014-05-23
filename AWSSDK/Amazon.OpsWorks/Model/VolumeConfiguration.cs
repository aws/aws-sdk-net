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
    /// Describes an Amazon EBS volume configuration.
    /// </summary>
    public partial class VolumeConfiguration
    {
        private int? _iops;
        private string _mountPoint;
        private int? _numberOfDisks;
        private int? _raidLevel;
        private int? _size;
        private string _volumeType;


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
        public VolumeConfiguration WithIops(int iops)
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
        /// The volume mount point. For example "/dev/sdh".
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
        public VolumeConfiguration WithMountPoint(string mountPoint)
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
        /// Gets and sets the property NumberOfDisks. 
        /// <para>
        /// The number of disks in the volume.
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
        public VolumeConfiguration WithNumberOfDisks(int numberOfDisks)
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
        /// Gets and sets the property RaidLevel. 
        /// <para>
        /// The volume <a href="http://en.wikipedia.org/wiki/Standard_RAID_levels">RAID level</a>.
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
        public VolumeConfiguration WithRaidLevel(int raidLevel)
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
        /// The volume size.
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
        public VolumeConfiguration WithSize(int size)
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
        public VolumeConfiguration WithVolumeType(string volumeType)
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