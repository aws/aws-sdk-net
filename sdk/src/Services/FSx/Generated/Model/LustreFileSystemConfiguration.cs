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
    /// The configuration for the Amazon FSx for Lustre file system.
    /// </summary>
    public partial class LustreFileSystemConfiguration
    {
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private string _dailyAutomaticBackupStartTime;
        private DataCompressionType _dataCompressionType;
        private DataRepositoryConfiguration _dataRepositoryConfiguration;
        private LustreDeploymentType _deploymentType;
        private DriveCacheType _driveCacheType;
        private LustreLogConfiguration _logConfiguration;
        private string _mountName;
        private int? _perUnitStorageThroughput;
        private LustreRootSquashConfiguration _rootSquashConfiguration;
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
        /// A boolean flag indicating whether tags on the file system are copied to backups. If
        /// it's set to true, all tags on the file system are copied to all automatic backups
        /// and any user-initiated backups where the user doesn't specify any tags. If this value
        /// is true, and you specify one or more tags, only the specified tags are copied to backups.
        /// If you specify one or more tags when creating a user-initiated backup, no tags are
        /// copied from the file system, regardless of this value. (Default = false)
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
        /// Gets and sets the property DataCompressionType. 
        /// <para>
        /// The data compression configuration for the file system. <code>DataCompressionType</code>
        /// can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - Data compression is turned off for the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LZ4</code> - Data compression is turned on with the LZ4 algorithm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-compression.html">Lustre
        /// data compression</a>.
        /// </para>
        /// </summary>
        public DataCompressionType DataCompressionType
        {
            get { return this._dataCompressionType; }
            set { this._dataCompressionType = value; }
        }

        // Check to see if DataCompressionType property is set
        internal bool IsSetDataCompressionType()
        {
            return this._dataCompressionType != null;
        }

        /// <summary>
        /// Gets and sets the property DataRepositoryConfiguration.
        /// </summary>
        public DataRepositoryConfiguration DataRepositoryConfiguration
        {
            get { return this._dataRepositoryConfiguration; }
            set { this._dataRepositoryConfiguration = value; }
        }

        // Check to see if DataRepositoryConfiguration property is set
        internal bool IsSetDataRepositoryConfiguration()
        {
            return this._dataRepositoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the FSx for Lustre file system. <i>Scratch deployment type</i>
        /// is designed for temporary storage and shorter-term processing of data.
        /// </para>
        ///  
        /// <para>
        ///  <code>SCRATCH_1</code> and <code>SCRATCH_2</code> deployment types are best suited
        /// for when you need temporary storage and shorter-term processing of data. The <code>SCRATCH_2</code>
        /// deployment type provides in-transit encryption of data and higher burst throughput
        /// capacity than <code>SCRATCH_1</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>PERSISTENT_1</code> and <code>PERSISTENT_2</code> deployment type is used
        /// for longer-term storage and workloads and encryption of data in transit. <code>PERSISTENT_2</code>
        /// is built on Lustre v2.12 and offers higher <code>PerUnitStorageThroughput</code> (up
        /// to 1000 MB/s/TiB) along with a lower minimum storage capacity requirement (600 GiB).
        /// To learn more about FSx for Lustre deployment types, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/lustre-deployment-types.html">
        /// FSx for Lustre deployment options</a>.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>SCRATCH_1</code>.
        /// </para>
        /// </summary>
        public LustreDeploymentType DeploymentType
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
        /// Gets and sets the property DriveCacheType. 
        /// <para>
        /// The type of drive cache used by <code>PERSISTENT_1</code> file systems that are provisioned
        /// with HDD storage devices. This parameter is required when <code>StorageType</code>
        /// is HDD. When set to <code>READ</code> the file system has an SSD storage cache that
        /// is sized to 20% of the file system's storage capacity. This improves the performance
        /// for frequently accessed files by caching up to 20% of the total storage capacity.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when <code>StorageType</code> is set to HDD.
        /// </para>
        /// </summary>
        public DriveCacheType DriveCacheType
        {
            get { return this._driveCacheType; }
            set { this._driveCacheType = value; }
        }

        // Check to see if DriveCacheType property is set
        internal bool IsSetDriveCacheType()
        {
            return this._driveCacheType != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The Lustre logging configuration. Lustre logging writes the enabled log events for
        /// your file system to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LustreLogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MountName. 
        /// <para>
        /// You use the <code>MountName</code> value when mounting the file system.
        /// </para>
        ///  
        /// <para>
        /// For the <code>SCRATCH_1</code> deployment type, this value is always "<code>fsx</code>".
        /// For <code>SCRATCH_2</code>, <code>PERSISTENT_1</code>, and <code>PERSISTENT_2</code>
        /// deployment types, this value is a string that is unique within an Amazon Web Services
        /// Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8)]
        public string MountName
        {
            get { return this._mountName; }
            set { this._mountName = value; }
        }

        // Check to see if MountName property is set
        internal bool IsSetMountName()
        {
            return this._mountName != null;
        }

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// Per unit storage throughput represents the megabytes per second of read or write throughput
        /// per 1 tebibyte of storage provisioned. File system throughput capacity is equal to
        /// Storage capacity (TiB) * PerUnitStorageThroughput (MB/s/TiB). This option is only
        /// valid for <code>PERSISTENT_1</code> and <code>PERSISTENT_2</code> deployment types.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>PERSISTENT_1</code> SSD storage: 50, 100, 200.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>PERSISTENT_1</code> HDD storage: 12, 40.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>PERSISTENT_2</code> SSD storage: 125, 250, 500, 1000.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=12, Max=1000)]
        public int PerUnitStorageThroughput
        {
            get { return this._perUnitStorageThroughput.GetValueOrDefault(); }
            set { this._perUnitStorageThroughput = value; }
        }

        // Check to see if PerUnitStorageThroughput property is set
        internal bool IsSetPerUnitStorageThroughput()
        {
            return this._perUnitStorageThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RootSquashConfiguration. 
        /// <para>
        /// The Lustre root squash configuration for an Amazon FSx for Lustre file system. When
        /// enabled, root squash restricts root-level access from clients that try to access your
        /// file system as a root user.
        /// </para>
        /// </summary>
        public LustreRootSquashConfiguration RootSquashConfiguration
        {
            get { return this._rootSquashConfiguration; }
            set { this._rootSquashConfiguration = value; }
        }

        // Check to see if RootSquashConfiguration property is set
        internal bool IsSetRootSquashConfiguration()
        {
            return this._rootSquashConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone. Here, <code>d</code> is the weekday number, from 1 through 7, beginning
        /// with Monday and ending with Sunday.
        /// </para>
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