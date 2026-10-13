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
    /// Updates the configuration for an existing Amazon FSx for Windows File Server file
    /// system. Amazon FSx only overwrites existing properties with non-null values provided
    /// in the request.
    /// </summary>
    public partial class UpdateFileSystemWindowsConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuditLogConfiguration. 
        /// <para>
        /// The configuration that Amazon FSx for Windows File Server uses to audit and log user
        /// accesses of files, folders, and file shares on the Amazon FSx for Windows File Server
        /// file system..
        /// </para>
        /// </summary>
        public WindowsAuditLogCreateConfiguration AuditLogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuditLogConfiguration property is set.
        /// </summary>
        internal bool IsSetAuditLogConfiguration() => this.AuditLogConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays. 
        /// <para>
        /// The number of days to retain automatic backups. Setting this property to <c>0</c>
        /// disables automatic backups. You can retain automatic backups for a maximum of 90 days.
        /// The default is <c>30</c>. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html#automatic-backups">Working
        /// with Automatic Daily Backups</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 90)]
        public int? AutomaticBackupRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticBackupRetentionDays property is set.
        /// </summary>
        internal bool IsSetAutomaticBackupRetentionDays() => this.AutomaticBackupRetentionDays.HasValue;

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime. 
        /// <para>
        /// The preferred time to start the daily automatic backup, in the UTC time zone, for
        /// example, <c>02:00</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string DailyAutomaticBackupStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DailyAutomaticBackupStartTime property is set.
        /// </summary>
        internal bool IsSetDailyAutomaticBackupStartTime() => this.DailyAutomaticBackupStartTime != null;

        /// <summary>
        /// Gets and sets the property DiskIopsConfiguration. 
        /// <para>
        /// The SSD IOPS (input/output operations per second) configuration for an Amazon FSx
        /// for Windows file system. By default, Amazon FSx automatically provisions 3 IOPS per
        /// GiB of storage capacity. You can provision additional IOPS per GiB of storage, up
        /// to the maximum limit associated with your chosen throughput capacity.
        /// </para>
        /// </summary>
        public DiskIopsConfiguration DiskIopsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DiskIopsConfiguration property is set.
        /// </summary>
        internal bool IsSetDiskIopsConfiguration() => this.DiskIopsConfiguration != null;

        /// <summary>
        /// Gets and sets the property FsrmConfiguration. 
        /// <para>
        /// The File Server Resource Manager (FSRM) configuration that Amazon FSx for Windows
        /// File Server uses for the file system. FSRM is disabled by default.
        /// </para>
        /// </summary>
        public WindowsFsrmConfiguration FsrmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FsrmConfiguration property is set.
        /// </summary>
        internal bool IsSetFsrmConfiguration() => this.FsrmConfiguration != null;

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration. 
        /// <para>
        /// The configuration Amazon FSx uses to join the Windows File Server instance to the
        /// self-managed Microsoft AD directory. You cannot make a self-managed Microsoft AD update
        /// request if there is an existing self-managed Microsoft AD update request in progress.
        /// </para>
        /// </summary>
        public SelfManagedActiveDirectoryConfigurationUpdates SelfManagedActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedActiveDirectoryConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfManagedActiveDirectoryConfiguration() => this.SelfManagedActiveDirectoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Sets the target value for a file system's throughput capacity, in MB/s, that you are
        /// updating the file system to. Valid values are 8, 16, 32, 64, 128, 256, 512, 1024,
        /// 2048. You cannot make a throughput capacity update request if there is an existing
        /// throughput capacity update request in progress. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-throughput-capacity.html">Managing
        /// Throughput Capacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 2147483647)]
        public int? ThroughputCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputCapacity property is set.
        /// </summary>
        internal bool IsSetThroughputCapacity() => this.ThroughputCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone. Where d is the weekday number, from 1 through 7, with 1 = Monday and 7
        /// = Sunday.
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
