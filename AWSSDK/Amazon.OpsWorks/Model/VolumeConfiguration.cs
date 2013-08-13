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
    /// <para>Describes an Amazon EBS volume configuration.</para>
    /// </summary>
    public class VolumeConfiguration
    {
        
        private string mountPoint;
        private int? raidLevel;
        private int? numberOfDisks;
        private int? size;

        /// <summary>
        /// The volume mount point. For example "/dev/sdh".
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
        public VolumeConfiguration WithMountPoint(string mountPoint)
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
        /// The volume <a href="http://en.wikipedia.org/wiki/Standard_RAID_levels">RAID level</a>.
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
        public VolumeConfiguration WithRaidLevel(int raidLevel)
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
        /// The number of disks in the volume.
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
        public VolumeConfiguration WithNumberOfDisks(int numberOfDisks)
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
        /// The volume size.
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
        public VolumeConfiguration WithSize(int size)
        {
            this.size = size;
            return this;
        }
            

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }
    }
}
