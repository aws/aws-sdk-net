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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration object for Amazon FSx for Lustre file systems used in the <c>UpdateFileSystem</c>
    /// operation.
    /// </summary>
    public partial class UpdateFileSystemLustreConfiguration
    {
        private AutoImportPolicyType _autoImportPolicy;
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private DataCompressionType _dataCompressionType;
        private LustreReadCacheConfiguration _dataReadCacheConfiguration;
        private LustreLogCreateConfiguration _logConfiguration;
        private UpdateFileSystemLustreMetadataConfiguration _metadataConfiguration;
        private int? _perUnitStorageThroughput;
        private LustreRootSquashConfiguration _rootSquashConfiguration;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AutoImportPolicy. 
        /// <para>
        ///  (Optional) When you create your file system, your existing S3 objects appear as file
        /// and directory listings. Use this property to choose how Amazon FSx keeps your file
        /// and directory listing up to date as you add or modify objects in your linked S3 bucket.
        /// <c>AutoImportPolicy</c> can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - (Default) AutoImport is off. Amazon FSx only updates file and directory
        /// listings from the linked S3 bucket when the file system is created. FSx does not update
        /// the file and directory listing for any new or changed objects after choosing this
        /// option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW</c> - AutoImport is on. Amazon FSx automatically imports directory listings
        /// of any new objects added to the linked S3 bucket that do not currently exist in the
        /// FSx file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_CHANGED</c> - AutoImport is on. Amazon FSx automatically imports file and
        /// directory listings of any new objects added to the S3 bucket and any existing objects
        /// that are changed in the S3 bucket after you choose this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_CHANGED_DELETED</c> - AutoImport is on. Amazon FSx automatically imports file
        /// and directory listings of any new objects added to the S3 bucket, any existing objects
        /// that are changed in the S3 bucket, and any objects that were deleted in the S3 bucket.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This parameter is not supported for file systems with a data repository association.
        /// </para>
        /// </summary>
        public AutoImportPolicyType AutoImportPolicy
        {
            get { return this._autoImportPolicy; }
            set { this._autoImportPolicy = value; }
        }

        // Check to see if AutoImportPolicy property is set
        internal bool IsSetAutoImportPolicy()
        {
            return this._autoImportPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays. 
        /// <para>
        /// The number of days to retain automatic backups. Setting this property to <c>0</c>
        /// disables automatic backups. You can retain automatic backups for a maximum of 90 days.
        /// The default is <c>0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=90)]
        public int? AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays; }
            set { this._automaticBackupRetentionDays = value; }
        }

        // Check to see if AutomaticBackupRetentionDays property is set
        internal bool IsSetAutomaticBackupRetentionDays()
        {
            return this._automaticBackupRetentionDays.HasValue; 
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
        /// Sets the data compression configuration for the file system. <c>DataCompressionType</c>
        /// can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - Data compression is turned off for the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LZ4</c> - Data compression is turned on with the LZ4 algorithm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't use <c>DataCompressionType</c>, the file system retains its current data
        /// compression configuration.
        /// </para>
        ///  
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
        /// Gets and sets the property DataReadCacheConfiguration. 
        /// <para>
        /// Specifies the optional provisioned SSD read cache on Amazon FSx for Lustre file systems
        /// that use the Intelligent-Tiering storage class.
        /// </para>
        /// </summary>
        public LustreReadCacheConfiguration DataReadCacheConfiguration
        {
            get { return this._dataReadCacheConfiguration; }
            set { this._dataReadCacheConfiguration = value; }
        }

        // Check to see if DataReadCacheConfiguration property is set
        internal bool IsSetDataReadCacheConfiguration()
        {
            return this._dataReadCacheConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The Lustre logging configuration used when updating an Amazon FSx for Lustre file
        /// system. When logging is enabled, Lustre logs error and warning events for data repositories
        /// associated with your file system to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LustreLogCreateConfiguration LogConfiguration
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
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The Lustre metadata performance configuration for an Amazon FSx for Lustre file system
        /// using a <c>PERSISTENT_2</c> deployment type. When this configuration is enabled, the
        /// file system supports increasing metadata performance.
        /// </para>
        /// </summary>
        public UpdateFileSystemLustreMetadataConfiguration MetadataConfiguration
        {
            get { return this._metadataConfiguration; }
            set { this._metadataConfiguration = value; }
        }

        // Check to see if MetadataConfiguration property is set
        internal bool IsSetMetadataConfiguration()
        {
            return this._metadataConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// The throughput of an Amazon FSx for Lustre Persistent SSD-based file system, measured
        /// in megabytes per second per tebibyte (MB/s/TiB). You can increase or decrease your
        /// file system's throughput. Valid values depend on the deployment type of the file system,
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>PERSISTENT_1</c> SSD-based deployment types, valid values are 50, 100, and
        /// 200 MB/s/TiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>PERSISTENT_2</c> SSD-based deployment types, valid values are 125, 250, 500,
        /// and 1000 MB/s/TiB.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/managing-throughput-capacity.html">
        /// Managing throughput capacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1000)]
        public int? PerUnitStorageThroughput
        {
            get { return this._perUnitStorageThroughput; }
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
        /// The Lustre root squash configuration used when updating an Amazon FSx for Lustre file
        /// system. When enabled, root squash restricts root-level access from clients that try
        /// to access your file system as a root user.
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
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx for Lustre file system using an Intelligent-Tiering
        /// storage class, measured in megabytes per second (MBps). You can only increase your
        /// file system's throughput. Valid values are 4000 MBps or multiples of 4000 MBps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4000, Max=2000000)]
        public int? ThroughputCapacity
        {
            get { return this._throughputCapacity; }
            set { this._throughputCapacity = value; }
        }

        // Check to see if ThroughputCapacity property is set
        internal bool IsSetThroughputCapacity()
        {
            return this._throughputCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// (Optional) The preferred start time to perform weekly maintenance, formatted d:HH:MM
        /// in the UTC time zone. d is the weekday number, from 1 through 7, beginning with Monday
        /// and ending with Sunday.
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