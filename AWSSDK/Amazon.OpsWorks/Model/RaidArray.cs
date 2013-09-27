/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes an instance's RAID array.</para>
    /// </summary>
    public class RaidArray
    {
        
        private string raidArrayId;
        private string instanceId;
        private string name;
        private int? raidLevel;
        private int? numberOfDisks;
        private int? size;
        private string device;
        private string mountPoint;
        private string availabilityZone;
        private string createdAt;

        /// <summary>
        /// The array ID.
        ///  
        /// </summary>
        public string RaidArrayId
        {
            get { return this.raidArrayId; }
            set { this.raidArrayId = value; }
        }

        /// <summary>
        /// Sets the RaidArrayId property
        /// </summary>
        /// <param name="raidArrayId">The value to set for the RaidArrayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithRaidArrayId(string raidArrayId)
        {
            this.raidArrayId = raidArrayId;
            return this;
        }
            

        // Check to see if RaidArrayId property is set
        internal bool IsSetRaidArrayId()
        {
            return this.raidArrayId != null;
        }

        /// <summary>
        /// The instance ID.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The array name.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The <a href="http://en.wikipedia.org/wiki/Standard_RAID_levels">RAID level</a>.
        ///  
        /// </summary>
        public int RaidLevel
        {
            get { return this.raidLevel ?? default(int); }
            set { this.raidLevel = value; }
        }

        /// <summary>
        /// Sets the RaidLevel property
        /// </summary>
        /// <param name="raidLevel">The value to set for the RaidLevel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithRaidLevel(int raidLevel)
        {
            this.raidLevel = raidLevel;
            return this;
        }
            

        // Check to see if RaidLevel property is set
        internal bool IsSetRaidLevel()
        {
            return this.raidLevel.HasValue;
        }

        /// <summary>
        /// The number of disks in the array.
        ///  
        /// </summary>
        public int NumberOfDisks
        {
            get { return this.numberOfDisks ?? default(int); }
            set { this.numberOfDisks = value; }
        }

        /// <summary>
        /// Sets the NumberOfDisks property
        /// </summary>
        /// <param name="numberOfDisks">The value to set for the NumberOfDisks property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithNumberOfDisks(int numberOfDisks)
        {
            this.numberOfDisks = numberOfDisks;
            return this;
        }
            

        // Check to see if NumberOfDisks property is set
        internal bool IsSetNumberOfDisks()
        {
            return this.numberOfDisks.HasValue;
        }

        /// <summary>
        /// The array's size.
        ///  
        /// </summary>
        public int Size
        {
            get { return this.size ?? default(int); }
            set { this.size = value; }
        }

        /// <summary>
        /// Sets the Size property
        /// </summary>
        /// <param name="size">The value to set for the Size property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithSize(int size)
        {
            this.size = size;
            return this;
        }
            

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }

        /// <summary>
        /// The array's Linux device. For example /dev/mdadm0.
        ///  
        /// </summary>
        public string Device
        {
            get { return this.device; }
            set { this.device = value; }
        }

        /// <summary>
        /// Sets the Device property
        /// </summary>
        /// <param name="device">The value to set for the Device property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithDevice(string device)
        {
            this.device = device;
            return this;
        }
            

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this.device != null;
        }

        /// <summary>
        /// The array's mount point.
        ///  
        /// </summary>
        public string MountPoint
        {
            get { return this.mountPoint; }
            set { this.mountPoint = value; }
        }

        /// <summary>
        /// Sets the MountPoint property
        /// </summary>
        /// <param name="mountPoint">The value to set for the MountPoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithMountPoint(string mountPoint)
        {
            this.mountPoint = mountPoint;
            return this;
        }
            

        // Check to see if MountPoint property is set
        internal bool IsSetMountPoint()
        {
            return this.mountPoint != null;
        }

        /// <summary>
        /// The array's Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// When the RAID array was created.
        ///  
        /// </summary>
        public string CreatedAt
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RaidArray WithCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
            return this;
        }
            

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this.createdAt != null;
        }
    }
}
