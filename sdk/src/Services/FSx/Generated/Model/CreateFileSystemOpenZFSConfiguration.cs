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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The Amazon FSx for OpenZFS configuration properties for the file system that you are
    /// creating.
    /// </summary>
    public partial class CreateFileSystemOpenZFSConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private bool? _copyTagsToVolumes;
        private string _dailyAutomaticBackupStartTime;
        private OpenZFSDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private OpenZFSCreateRootVolumeConfiguration _rootVolumeConfiguration;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays.
        /// </summary>
        [AWSProperty(Min=0, Max=90)]
        public int AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays.GetValueOrDefault(); }
            set { this._automaticBackupRetentionDays = value; }
        }

        // Check to see if AutomaticBackupRetentionDays property is set
        internal bool IsSetAutomaticBackupRetentionDays()
        {
            return this._automaticBackupRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToBackups. 
        /// <para>
        /// A Boolean value indicating whether tags for the file system should be copied to backups.
        /// This value defaults to <code>false</code>. If it's set to <code>true</code>, all tags
        /// for the file system are copied to all automatic and user-initiated backups where the
        /// user doesn't specify tags. If this value is <code>true</code>, and you specify one
        /// or more tags, only the specified tags are copied to backups. If you specify one or
        /// more tags when creating a user-initiated backup, no tags are copied from the file
        /// system, regardless of this value.
        /// </para>
        /// </summary>
        public bool CopyTagsToBackups
        {
            get { return this._copyTagsToBackups.GetValueOrDefault(); }
            set { this._copyTagsToBackups = value; }
        }

        // Check to see if CopyTagsToBackups property is set
        internal bool IsSetCopyTagsToBackups()
        {
            return this._copyTagsToBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToVolumes. 
        /// <para>
        /// A Boolean value indicating whether tags for the file system should be copied to volumes.
        /// This value defaults to <code>false</code>. If it's set to <code>true</code>, all tags
        /// for the file system are copied to volumes where the user doesn't specify tags. If
        /// this value is <code>true</code>, and you specify one or more tags, only the specified
        /// tags are copied to volumes. If you specify one or more tags when creating the volume,
        /// no tags are copied from the file system, regardless of this value.
        /// </para>
        /// </summary>
        public bool CopyTagsToVolumes
        {
            get { return this._copyTagsToVolumes.GetValueOrDefault(); }
            set { this._copyTagsToVolumes = value; }
        }

        // Check to see if CopyTagsToVolumes property is set
        internal bool IsSetCopyTagsToVolumes()
        {
            return this._copyTagsToVolumes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime.
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
        public string DailyAutomaticBackupStartTime
        {
            get { return this._dailyAutomaticBackupStartTime; }
            set { this._dailyAutomaticBackupStartTime = value; }
        }

        // Check to see if DailyAutomaticBackupStartTime property is set
        internal bool IsSetDailyAutomaticBackupStartTime()
        {
            return this._dailyAutomaticBackupStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the file system deployment type. Single AZ deployment types are configured
        /// for redundancy within a single Availability Zone in an Amazon Web Services Region
        /// . Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SINGLE_AZ_1</code>- (Default) Creates file systems with throughput capacities
        /// of 64 - 4,096 MB/s. <code>Single_AZ_1</code> is available in all Amazon Web Services
        /// Regions where Amazon FSx for OpenZFS is available, except US West (Oregon).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_AZ_2</code>- Creates file systems with throughput capacities of 160
        /// - 10,240 MB/s using an NVMe L2ARC cache. <code>Single_AZ_2</code> is available only
        /// in the US East (N. Virginia), US East (Ohio), US West (Oregon), and Europe (Ireland)
        /// Amazon Web Services Regions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see: <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/availability-durability.html#available-aws-regions">Deployment
        /// type availability</a> and <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/performance.html#zfs-fs-performance">File
        /// system performance</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenZFSDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration.
        /// </summary>
        public DiskIopsConfiguration DiskIopsConfiguration
        {
            get { return this._diskIopsConfiguration; }
            set { this._diskIopsConfiguration = value; }
        }

        // Check to see if DiskIopsConfiguration property is set
        internal bool IsSetDiskIopsConfiguration()
        {
            return this._diskIopsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RootVolumeConfiguration. 
        /// <para>
        /// The configuration Amazon FSx uses when creating the root value of the Amazon FSx for
        /// OpenZFS file system. All volumes are children of the root volume. 
        /// </para>
        /// </summary>
        public OpenZFSCreateRootVolumeConfiguration RootVolumeConfiguration
        {
            get { return this._rootVolumeConfiguration; }
            set { this._rootVolumeConfiguration = value; }
        }

        // Check to see if RootVolumeConfiguration property is set
        internal bool IsSetRootVolumeConfiguration()
        {
            return this._rootVolumeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Specifies the throughput of an Amazon FSx for OpenZFS file system, measured in megabytes
        /// per second (MB/s). Valid values depend on the DeploymentType you choose, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>SINGLE_AZ_1</code>, valid values are 64, 128, 256, 512, 1024, 2048, 3072,
        /// or 4096 MB/s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>SINGLE_AZ_2</code>, valid values are 160, 320, 640, 1280, 2560, 3840, 5120,
        /// 7680, or 10240 MB/s.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You pay for additional throughput capacity that you provision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=100000)]
        public int ThroughputCapacity
        {
            get { return this._throughputCapacity.GetValueOrDefault(); }
            set { this._throughputCapacity = value; }
        }

        // Check to see if ThroughputCapacity property is set
        internal bool IsSetThroughputCapacity()
        {
            return this._throughputCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime.
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}