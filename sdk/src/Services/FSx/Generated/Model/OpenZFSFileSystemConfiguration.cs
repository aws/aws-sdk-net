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
    /// The configuration for the Amazon FSx for OpenZFS file system.
    /// </summary>
    public partial class OpenZFSFileSystemConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private bool? _copyTagsToVolumes;
        private string _dailyAutomaticBackupStartTime;
        private OpenZFSDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private string _rootVolumeId;
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
        /// A Boolean value indicating whether tags on the file system should be copied to backups.
        /// If it's set to <code>true</code>, all tags on the file system are copied to all automatic
        /// backups and any user-initiated backups where the user doesn't specify any tags. If
        /// this value is <code>true</code> and you specify one or more tags, only the specified
        /// tags are copied to backups. If you specify one or more tags when creating a user-initiated
        /// backup, no tags are copied from the file system, regardless of this value. 
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
        /// A Boolean value indicating whether tags for the volume should be copied to snapshots.
        /// This value defaults to <code>false</code>. If it's set to <code>true</code>, all tags
        /// for the volume are copied to snapshots where the user doesn't specify tags. If this
        /// value is <code>true</code> and you specify one or more tags, only the specified tags
        /// are copied to snapshots. If you specify one or more tags when creating the snapshot,
        /// no tags are copied from the volume, regardless of this value. 
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
        /// Specifies the file-system deployment type. Amazon FSx for OpenZFS supports&#x2028;
        /// <code>SINGLE_AZ_1</code> and <code>SINGLE_AZ_2</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RootVolumeId. 
        /// <para>
        /// The ID of the root volume of the OpenZFS file system. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=23, Max=23)]
        public string RootVolumeId
        {
            get { return this._rootVolumeId; }
            set { this._rootVolumeId = value; }
        }

        // Check to see if RootVolumeId property is set
        internal bool IsSetRootVolumeId()
        {
            return this._rootVolumeId != null;
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx file system, measured in megabytes per second (MBps).
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=100000)]
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