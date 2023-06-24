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
    /// The Lustre configuration for the file system being created.
    /// 
    ///  <note> 
    /// <para>
    /// The following parameters are not supported for file systems with a data repository
    /// association created with .
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AutoImportPolicy</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ExportPath</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ImportedChunkSize</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ImportPath</code> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateFileSystemLustreConfiguration
    {
        private AutoImportPolicyType _autoImportPolicy;
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private string _dailyAutomaticBackupStartTime;
        private DataCompressionType _dataCompressionType;
        private LustreDeploymentType _deploymentType;
        private DriveCacheType _driveCacheType;
        private string _exportPath;
        private int? _importedFileChunkSize;
        private string _importPath;
        private LustreLogCreateConfiguration _logConfiguration;
        private int? _perUnitStorageThroughput;
        private LustreRootSquashConfiguration _rootSquashConfiguration;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AutoImportPolicy. 
        /// <para>
        ///  (Optional) When you create your file system, your existing S3 objects appear as file
        /// and directory listings. Use this parameter to choose how Amazon FSx keeps your file
        /// and directory listings up to date as you add or modify objects in your linked S3 bucket.
        /// <code>AutoImportPolicy</code> can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - (Default) AutoImport is off. Amazon FSx only updates file and
        /// directory listings from the linked S3 bucket when the file system is created. FSx
        /// does not update file and directory listings for any new or changed objects after choosing
        /// this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW</code> - AutoImport is on. Amazon FSx automatically imports directory listings
        /// of any new objects added to the linked S3 bucket that do not currently exist in the
        /// FSx file system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_CHANGED</code> - AutoImport is on. Amazon FSx automatically imports file
        /// and directory listings of any new objects added to the S3 bucket and any existing
        /// objects that are changed in the S3 bucket after you choose this option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEW_CHANGED_DELETED</code> - AutoImport is on. Amazon FSx automatically imports
        /// file and directory listings of any new objects added to the S3 bucket, any existing
        /// objects that are changed in the S3 bucket, and any objects that were deleted in the
        /// S3 bucket.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/older-deployment-types.html#legacy-auto-import-from-s3">
        /// Automatically import updates from your S3 bucket</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for file systems with a data repository association.
        /// </para>
        ///  </note>
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
        /// The number of days to retain automatic backups. Setting this property to <code>0</code>
        /// disables automatic backups. You can retain automatic backups for a maximum of 90 days.
        /// The default is <code>0</code>.
        /// </para>
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
        /// (Optional) Not available for use with file systems that are linked to a data repository.
        /// A boolean flag indicating whether tags for the file system should be copied to backups.
        /// The default value is false. If <code>CopyTagsToBackups</code> is set to true, all
        /// file system tags are copied to all automatic and user-initiated backups when the user
        /// doesn't specify any backup-specific tags. If <code>CopyTagsToBackups</code> is set
        /// to true and you specify one or more backup tags, only the specified tags are copied
        /// to backups. If you specify one or more tags when creating a user-initiated backup,
        /// no tags are copied from the file system, regardless of this value.
        /// </para>
        ///  
        /// <para>
        /// (Default = <code>false</code>)
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html">
        /// Working with backups</a> in the <i>Amazon FSx for Lustre User Guide</i>.
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
        /// Sets the data compression configuration for the file system. <code>DataCompressionType</code>
        /// can have the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code> - (Default) Data compression is turned off when the file system
        /// is created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LZ4</code> - Data compression is turned on with the LZ4 algorithm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-compression.html">Lustre
        /// data compression</a> in the <i>Amazon FSx for Lustre User Guide</i>.
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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// (Optional) Choose <code>SCRATCH_1</code> and <code>SCRATCH_2</code> deployment types
        /// when you need temporary storage and shorter-term processing of data. The <code>SCRATCH_2</code>
        /// deployment type provides in-transit encryption of data and higher burst throughput
        /// capacity than <code>SCRATCH_1</code>.
        /// </para>
        ///  
        /// <para>
        /// Choose <code>PERSISTENT_1</code> for longer-term storage and for throughput-focused
        /// workloads that aren’t latency-sensitive. <code>PERSISTENT_1</code> supports encryption
        /// of data in transit, and is available in all Amazon Web Services Regions in which FSx
        /// for Lustre is available.
        /// </para>
        ///  
        /// <para>
        /// Choose <code>PERSISTENT_2</code> for longer-term storage and for latency-sensitive
        /// workloads that require the highest levels of IOPS/throughput. <code>PERSISTENT_2</code>
        /// supports SSD storage, and offers higher <code>PerUnitStorageThroughput</code> (up
        /// to 1000 MB/s/TiB). <code>PERSISTENT_2</code> is available in a limited number of Amazon
        /// Web Services Regions. For more information, and an up-to-date list of Amazon Web Services
        /// Regions in which <code>PERSISTENT_2</code> is available, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-fsx-lustre.html#lustre-deployment-types">File
        /// system deployment options for FSx for Lustre</a> in the <i>Amazon FSx for Lustre User
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose <code>PERSISTENT_2</code>, and you set <code>FileSystemTypeVersion</code>
        /// to <code>2.10</code>, the <code>CreateFileSystem</code> operation fails.
        /// </para>
        ///  </note> 
        /// <para>
        /// Encryption of data in transit is automatically turned on when you access <code>SCRATCH_2</code>,
        /// <code>PERSISTENT_1</code> and <code>PERSISTENT_2</code> file systems from Amazon EC2
        /// instances that support automatic encryption in the Amazon Web Services Regions where
        /// they are available. For more information about encryption in transit for FSx for Lustre
        /// file systems, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/encryption-in-transit-fsxl.html">Encrypting
        /// data in transit</a> in the <i>Amazon FSx for Lustre User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// (Default = <code>SCRATCH_1</code>)
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
        /// with HDD storage devices. This parameter is required when storage type is HDD. Set
        /// this property to <code>READ</code> to improve the performance for frequently accessed
        /// files by caching up to 20% of the total storage capacity of the file system.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required when <code>StorageType</code> is set to <code>HDD</code>.
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
        /// Gets and sets the property ExportPath. 
        /// <para>
        /// (Optional) Specifies the path in the Amazon S3 bucket where the root of your Amazon
        /// FSx file system is exported. The path must use the same Amazon S3 bucket as specified
        /// in ImportPath. You can provide an optional prefix to which new and changed data is
        /// to be exported from your Amazon FSx for Lustre file system. If an <code>ExportPath</code>
        /// value is not provided, Amazon FSx sets a default export path, <code>s3://import-bucket/FSxLustre[creation-timestamp]</code>.
        /// The timestamp is in UTC format, for example <code>s3://import-bucket/FSxLustre20181105T222312Z</code>.
        /// </para>
        ///  
        /// <para>
        /// The Amazon S3 export bucket must be the same as the import bucket specified by <code>ImportPath</code>.
        /// If you specify only a bucket name, such as <code>s3://import-bucket</code>, you get
        /// a 1:1 mapping of file system objects to S3 bucket objects. This mapping means that
        /// the input data in S3 is overwritten on export. If you provide a custom prefix in the
        /// export path, such as <code>s3://import-bucket/[custom-optional-prefix]</code>, Amazon
        /// FSx exports the contents of your file system to that export prefix in the Amazon S3
        /// bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for file systems with a data repository association.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=3, Max=4357)]
        public string ExportPath
        {
            get { return this._exportPath; }
            set { this._exportPath = value; }
        }

        // Check to see if ExportPath property is set
        internal bool IsSetExportPath()
        {
            return this._exportPath != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedFileChunkSize. 
        /// <para>
        /// (Optional) For files imported from a data repository, this value determines the stripe
        /// count and maximum amount of data per file (in MiB) stored on a single physical disk.
        /// The maximum number of disks that a single file can be striped across is limited by
        /// the total number of disks that make up the file system.
        /// </para>
        ///  
        /// <para>
        /// The default chunk size is 1,024 MiB (1 GiB) and can go as high as 512,000 MiB (500
        /// GiB). Amazon S3 objects have a maximum size of 5 TB.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for file systems with a data repository association.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=512000)]
        public int ImportedFileChunkSize
        {
            get { return this._importedFileChunkSize.GetValueOrDefault(); }
            set { this._importedFileChunkSize = value; }
        }

        // Check to see if ImportedFileChunkSize property is set
        internal bool IsSetImportedFileChunkSize()
        {
            return this._importedFileChunkSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportPath. 
        /// <para>
        /// (Optional) The path to the Amazon S3 bucket (including the optional prefix) that you're
        /// using as the data repository for your Amazon FSx for Lustre file system. The root
        /// of your FSx for Lustre file system will be mapped to the root of the Amazon S3 bucket
        /// you select. An example is <code>s3://import-bucket/optional-prefix</code>. If you
        /// specify a prefix after the Amazon S3 bucket name, only object keys with that prefix
        /// are loaded into the file system.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for file systems with a data repository association.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=3, Max=4357)]
        public string ImportPath
        {
            get { return this._importPath; }
            set { this._importPath = value; }
        }

        // Check to see if ImportPath property is set
        internal bool IsSetImportPath()
        {
            return this._importPath != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The Lustre logging configuration used when creating an Amazon FSx for Lustre file
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
        /// Gets and sets the property PerUnitStorageThroughput. 
        /// <para>
        /// Required with <code>PERSISTENT_1</code> and <code>PERSISTENT_2</code> deployment types,
        /// provisions the amount of read and write throughput for each 1 tebibyte (TiB) of file
        /// system storage capacity, in MB/s/TiB. File system throughput capacity is calculated
        /// by multiplying ﬁle system storage capacity (TiB) by the <code>PerUnitStorageThroughput</code>
        /// (MB/s/TiB). For a 2.4-TiB ﬁle system, provisioning 50 MB/s/TiB of <code>PerUnitStorageThroughput</code>
        /// yields 120 MB/s of ﬁle system throughput. You pay for the amount of throughput that
        /// you provision. 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>PERSISTENT_1</code> SSD storage: 50, 100, 200 MB/s/TiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>PERSISTENT_1</code> HDD storage: 12, 40 MB/s/TiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>PERSISTENT_2</code> SSD storage: 125, 250, 500, 1000 MB/s/TiB.
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
        /// The Lustre root squash configuration used when creating an Amazon FSx for Lustre file
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
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// (Optional) The preferred start time to perform weekly maintenance, formatted d:HH:MM
        /// in the UTC time zone, where d is the weekday number, from 1 through 7, beginning with
        /// Monday and ending with Sunday.
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