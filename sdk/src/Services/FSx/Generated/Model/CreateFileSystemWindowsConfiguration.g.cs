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
    /// The configuration object for the Microsoft Windows file system used in <c>CreateFileSystem</c>
    /// and <c>CreateFileSystemFromBackup</c> operations.
    /// </summary>
    public partial class CreateFileSystemWindowsConfiguration
    {
        /// <summary>
        /// Gets and sets the property ActiveDirectoryId. 
        /// <para>
        /// The ID for an existing Amazon Web Services Managed Microsoft Active Directory (AD)
        /// instance that the file system should join when it's created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ActiveDirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryId property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryId() => this.ActiveDirectoryId != null;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// An array of one or more DNS alias names that you want to associate with the Amazon
        /// FSx file system. Aliases allow you to use existing DNS names to access the data in
        /// your Amazon FSx file system. You can associate up to 50 aliases with a file system
        /// at any time. You can associate additional DNS aliases after you create the file system
        /// using the AssociateFileSystemAliases operation. You can remove DNS aliases from the
        /// file system after it is created using the DisassociateFileSystemAliases operation.
        /// You only need to specify the alias name in the request payload. For more information,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Managing
        /// DNS aliases</a> and <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/dns-aliases.html">Accessing
        /// data using DNS aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// An alias name has to meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Formatted as a fully-qualified domain name (FQDN), <c>hostname.domain</c>, for example,
        /// <c>accounting.example.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can contain alphanumeric characters, the underscore (_), and the hyphen (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot start or end with a hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can start with a numeric.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For DNS alias names, Amazon FSx stores alphabetic characters as lowercase letters
        /// (a-z), regardless of how you specify them: as uppercase letters, lowercase letters,
        /// or the corresponding letters in escape codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Aliases { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Aliases property is set.
        /// </summary>
        internal bool IsSetAliases() => this.Aliases != null && (this.Aliases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuditLogConfiguration. 
        /// <para>
        /// The configuration that Amazon FSx for Windows File Server uses to audit and log user
        /// accesses of files, folders, and file shares on the Amazon FSx for Windows File Server
        /// file system.
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
        /// The default is <c>30</c>.
        /// </para>
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
        /// A boolean flag indicating whether tags for the file system should be copied to backups.
        /// This value defaults to false. If it's set to true, all tags for the file system are
        /// copied to all automatic and user-initiated backups where the user doesn't specify
        /// tags. If this value is true, and you specify one or more tags, only the specified
        /// tags are copied to backups. If you specify one or more tags when creating a user-initiated
        /// backup, no tags are copied from the file system, regardless of this value.
        /// </para>
        /// </summary>
        public bool? CopyTagsToBackups { get; set; }

        /// <summary>
        /// Checks to see if the CopyTagsToBackups property is set.
        /// </summary>
        internal bool IsSetCopyTagsToBackups() => this.CopyTagsToBackups.HasValue;

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime. 
        /// <para>
        /// The preferred time to take daily automatic backups, formatted HH:MM in the UTC time
        /// zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string DailyAutomaticBackupStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DailyAutomaticBackupStartTime property is set.
        /// </summary>
        internal bool IsSetDailyAutomaticBackupStartTime() => this.DailyAutomaticBackupStartTime != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the file system deployment type, valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MULTI_AZ_1</c> - Deploys a high availability file system that is configured for
        /// Multi-AZ redundancy to tolerate temporary Availability Zone (AZ) unavailability. You
        /// can only deploy a Multi-AZ file system in Amazon Web Services Regions that have a
        /// minimum of three Availability Zones. Also supports HDD storage type
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_1</c> - (Default) Choose to deploy a file system that is configured
        /// for single AZ redundancy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_2</c> - The latest generation Single AZ file system. Specifies a file
        /// system that is configured for single AZ redundancy and supports HDD storage type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/high-availability-multiAZ.html">
        /// Availability and Durability: Single-AZ and Multi-AZ File Systems</a>.
        /// </para>
        /// </summary>
        public WindowsDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// Required when <c>DeploymentType</c> is set to <c>MULTI_AZ_1</c>. This specifies the
        /// subnet in which you want the preferred file server to be located. For in-Amazon Web
        /// Services applications, we recommend that you launch your clients in the same Availability
        /// Zone (AZ) as your preferred file server to reduce cross-AZ data transfer costs and
        /// minimize latency. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string PreferredSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the PreferredSubnetId property is set.
        /// </summary>
        internal bool IsSetPreferredSubnetId() => this.PreferredSubnetId != null;

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration.
        /// </summary>
        public SelfManagedActiveDirectoryConfiguration SelfManagedActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedActiveDirectoryConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfManagedActiveDirectoryConfiguration() => this.SelfManagedActiveDirectoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Sets the throughput capacity of an Amazon FSx file system, measured in megabytes per
        /// second (MB/s), in 2 to the <i>n</i>th increments, between 2^3 (8) and 2^11 (2048).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 2147483647)]
        public int? ThroughputCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputCapacity property is set.
        /// </summary>
        internal bool IsSetThroughputCapacity() => this.ThroughputCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone, where d is the weekday number, from 1 through 7, beginning with Monday
        /// and ending with Sunday.
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
