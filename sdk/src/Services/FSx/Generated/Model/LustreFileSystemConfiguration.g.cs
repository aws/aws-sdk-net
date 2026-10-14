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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The configuration for the Amazon FSx for Lustre file system.
    /// </summary>
    public partial class LustreFileSystemConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays.
        /// </summary>
        [AWSProperty(Min = 0, Max = 90)]
        public int? AutomaticBackupRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticBackupRetentionDays property is set.
        /// </summary>
        internal bool IsSetAutomaticBackupRetentionDays() => this.AutomaticBackupRetentionDays.HasValue;

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
        public bool? CopyTagsToBackups { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToBackups property is set.
        /// </summary>
        internal bool IsSetCopyTagsToBackups() => this.CopyTagsToBackups.HasValue;

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime.
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string DailyAutomaticBackupStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DailyAutomaticBackupStartTime property is set.
        /// </summary>
        internal bool IsSetDailyAutomaticBackupStartTime() => this.DailyAutomaticBackupStartTime != null;

        /// <summary>
        /// Gets and sets the property DataCompressionType. 
        /// <para>
        /// The data compression configuration for the file system. <c>DataCompressionType</c>
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
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-compression.html">Lustre
        /// data compression</a>.
        /// </para>
        /// </summary>
        public DataCompressionType DataCompressionType { get; set; }

        /// <summary>
        /// Checks to see if the DataCompressionType property is set.
        /// </summary>
        internal bool IsSetDataCompressionType() => this.DataCompressionType != null;

        /// <summary>
        /// Gets and sets the property DataReadCacheConfiguration. 
        /// <para>
        /// Required when <c>StorageType</c> is set to <c>INTELLIGENT_TIERING</c>. Specifies the
        /// optional provisioned SSD read cache.
        /// </para>
        /// </summary>
        public LustreReadCacheConfiguration DataReadCacheConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataReadCacheConfiguration property is set.
        /// </summary>
        internal bool IsSetDataReadCacheConfiguration() => this.DataReadCacheConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataRepositoryConfiguration.
        /// </summary>
        public DataRepositoryConfiguration DataRepositoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataRepositoryConfiguration property is set.
        /// </summary>
        internal bool IsSetDataRepositoryConfiguration() => this.DataRepositoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the FSx for Lustre file system. <i>Scratch deployment type</i>
        /// is designed for temporary storage and shorter-term processing of data.
        /// </para>
        ///  
        /// <para>
        ///  <c>SCRATCH_1</c> and <c>SCRATCH_2</c> deployment types are best suited for when you
        /// need temporary storage and shorter-term processing of data. The <c>SCRATCH_2</c> deployment
        /// type provides in-transit encryption of data and higher burst throughput capacity than
        /// <c>SCRATCH_1</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PERSISTENT_1</c> and <c>PERSISTENT_2</c> deployment type is used for longer-term
        /// storage and workloads and encryption of data in transit. <c>PERSISTENT_2</c> offers
        /// higher <c>PerUnitStorageThroughput</c> (up to 1000 MB/s/TiB) along with a lower minimum
        /// storage capacity requirement (600 GiB). To learn more about FSx for Lustre deployment
        /// types, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-fsx-lustre.html">Deployment
        /// and storage class options for FSx for Lustre file systems</a>.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>SCRATCH_1</c>.
        /// </para>
        /// </summary>
        public LustreDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property DriveCacheType. 
        /// <para>
        /// The type of drive cache used by <c>PERSISTENT_1</c> file systems that are provisioned
        /// with HDD storage devices. This parameter is required when <c>StorageType</c> is HDD.
        /// When set to <c>READ</c> the file system has an SSD storage cache that is sized to
        /// 20% of the file system's storage capacity. This improves the performance for frequently
        /// accessed files by caching up to 20% of the total storage capacity.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when <c>StorageType</c> is set to HDD.
        /// </para>
        /// </summary>
        public DriveCacheType DriveCacheType { get; set; }

        /// <summary>
        /// Checks to see if the DriveCacheType property is set.
        /// </summary>
        internal bool IsSetDriveCacheType() => this.DriveCacheType != null;

        /// <summary>
        /// Gets and sets the property EfaEnabled. 
        /// <para>
        /// Specifies whether Elastic Fabric Adapter (EFA) and GPUDirect Storage (GDS) support
        /// is enabled for the Amazon FSx for Lustre file system.
        /// </para>
        /// </summary>
        public bool? EfaEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EfaEnabled property is set.
        /// </summary>
        internal bool IsSetEfaEnabled() => this.EfaEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The Lustre logging configuration. Lustre logging writes the enabled log events for
        /// your file system to Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LustreLogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// The Lustre metadata performance configuration for an Amazon FSx for Lustre file system
        /// using a <c>PERSISTENT_2</c> deployment type.
        /// </para>
        /// </summary>
        public FileSystemLustreMetadataConfiguration MetadataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MetadataConfiguration property is set.
        /// </summary>
        internal bool IsSetMetadataConfiguration() => this.MetadataConfiguration != null;

        /// <summary>
        /// Gets and sets the property MountName. 
        /// <para>
        /// You use the <c>MountName</c> value when mounting the file system.
        /// </para>
        ///  
        /// <para>
        /// For the <c>SCRATCH_1</c> deployment type, this value is always "<c>fsx</c>". For <c>SCRATCH_2</c>,
        /// <c>PERSISTENT_1</c>, and <c>PERSISTENT_2</c> deployment types, this value is a string
        /// that is unique within an Amazon Web Services Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public string MountName { get; set; }

        /// <summary>
        /// Checks to see if the MountName property is set.
        /// </summary>
        internal bool IsSetMountName() => this.MountName != null;

        /// <summary>
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// Per unit storage throughput represents the megabytes per second of read or write throughput
        /// per 1 tebibyte of storage provisioned. File system throughput capacity is equal to
        /// Storage capacity (TiB) * PerUnitStorageThroughput (MB/s/TiB). This option is only
        /// valid for <c>PERSISTENT_1</c> and <c>PERSISTENT_2</c> deployment types. 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>PERSISTENT_1</c> SSD storage: 50, 100, 200.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>PERSISTENT_1</c> HDD storage: 12, 40.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>PERSISTENT_2</c> SSD storage: 125, 250, 500, 1000.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1000)]
        public int? PerUnitStorageThroughput { get; set; }

        /// <summary>
        /// Checks to see if the PerUnitStorageThroughput property is set.
        /// </summary>
        internal bool IsSetPerUnitStorageThroughput() => this.PerUnitStorageThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property RootSquashConfiguration. 
        /// <para>
        /// The Lustre root squash configuration for an Amazon FSx for Lustre file system. When
        /// enabled, root squash restricts root-level access from clients that try to access your
        /// file system as a root user.
        /// </para>
        /// </summary>
        public LustreRootSquashConfiguration RootSquashConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RootSquashConfiguration property is set.
        /// </summary>
        internal bool IsSetRootSquashConfiguration() => this.RootSquashConfiguration != null;

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of an Amazon FSx for Lustre file system using the Intelligent-Tiering
        /// storage class, measured in megabytes per second (MBps).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4000, Max = 2000000)]
        public int? ThroughputCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputCapacity property is set.
        /// </summary>
        internal bool IsSetThroughputCapacity() => this.ThroughputCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone. Here, <c>d</c> is the weekday number, from 1 through 7, beginning with
        /// Monday and ending with Sunday.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 7)]
        public string WeeklyMaintenanceStartTime { get; set; }

        /// <summary>
        /// Checks to see if the WeeklyMaintenanceStartTime property is set.
        /// </summary>
        internal bool IsSetWeeklyMaintenanceStartTime() => this.WeeklyMaintenanceStartTime != null;
    }
}
