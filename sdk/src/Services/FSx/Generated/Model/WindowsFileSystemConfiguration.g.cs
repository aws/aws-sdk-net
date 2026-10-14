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
    /// The configuration for this Microsoft Windows file system.
    /// </summary>
    public partial class WindowsFileSystemConfiguration
    {
        /// <summary>
        /// Gets and sets the property ActiveDirectoryId. 
        /// <para>
        /// The ID for an existing Amazon Web Services Managed Microsoft Active Directory instance
        /// that the file system is joined to.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Alias> Aliases { get; set; } = AWSConfigs.InitializeCollections ? new List<Alias>() : null;

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
        public WindowsAuditLogConfiguration AuditLogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuditLogConfiguration property is set.
        /// </summary>
        internal bool IsSetAuditLogConfiguration() => this.AuditLogConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays. 
        /// <para>
        /// The number of days to retain automatic backups. Setting this to 0 disables automatic
        /// backups. You can retain automatic backups for a maximum of 90 days.
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
        /// A boolean flag indicating whether tags on the file system should be copied to backups.
        /// This value defaults to false. If it's set to true, all tags on the file system are
        /// copied to all automatic backups and any user-initiated backups where the user doesn't
        /// specify any tags. If this value is true, and you specify one or more tags, only the
        /// specified tags are copied to backups. If you specify one or more tags when creating
        /// a user-initiated backup, no tags are copied from the file system, regardless of this
        /// value.
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
        /// The preferred time to take daily automatic backups, in the UTC time zone.
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
        ///  <c>MULTI_AZ_1</c> - Specifies a high availability file system that is configured
        /// for Multi-AZ redundancy to tolerate temporary Availability Zone (AZ) unavailability,
        /// and supports SSD and HDD storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_1</c> - (Default) Specifies a file system that is configured for single
        /// AZ redundancy, only supports SSD storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_AZ_2</c> - Latest generation Single AZ file system. Specifies a file system
        /// that is configured for single AZ redundancy and supports SSD and HDD storage.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/high-availability-multiAZ.html">Single-AZ
        /// and Multi-AZ File Systems</a>.
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
        /// Gets and sets the property MaintenanceOperationsInProgress. 
        /// <para>
        /// The list of maintenance operations in progress for this file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> MaintenanceOperationsInProgress { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MaintenanceOperationsInProgress property is set.
        /// </summary>
        internal bool IsSetMaintenanceOperationsInProgress() => this.MaintenanceOperationsInProgress != null && (this.MaintenanceOperationsInProgress.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreferredFileServerIp. 
        /// <para>
        /// For <c>MULTI_AZ_1</c> deployment types, the IPv4 address of the primary, or preferred,
        /// file server.
        /// </para>
        ///  
        /// <para>
        /// Use this IP address when mounting the file system on Linux SMB clients or Windows
        /// SMB clients that are not joined to a Microsoft Active Directory. Applicable for all
        /// Windows file system deployment types. This IPv4 address is temporarily unavailable
        /// when the file system is undergoing maintenance. For Linux and Windows SMB clients
        /// that are joined to an Active Directory, use the file system's DNSName instead. For
        /// more information on mapping and mounting file shares, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-file-shares.html">Accessing
        /// data using file shares</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 45)]
        public string PreferredFileServerIp { get; set; }

        /// <summary>
        /// Checks to see if the PreferredFileServerIp property is set.
        /// </summary>
        internal bool IsSetPreferredFileServerIp() => this.PreferredFileServerIp != null;

        /// <summary>
        /// Gets and sets the property PreferredFileServerIpv6. 
        /// <para>
        /// For MULTI_AZ_1 deployment types, the IPv6 address of the primary, or preferred, file
        /// server. Use this IP address when mounting the file system on Linux SMB clients or
        /// Windows SMB clients that are not joined to a Microsoft Active Directory. Applicable
        /// for all Windows file system deployment types. This IPv6 address is temporarily unavailable
        /// when the file system is undergoing maintenance. For Linux and Windows SMB clients
        /// that are joined to an Active Directory, use the file system's DNSName instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 45)]
        public string PreferredFileServerIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PreferredFileServerIpv6 property is set.
        /// </summary>
        internal bool IsSetPreferredFileServerIpv6() => this.PreferredFileServerIpv6 != null;

        /// <summary>
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// For <c>MULTI_AZ_1</c> deployment types, it specifies the ID of the subnet where the
        /// preferred file server is located. Must be one of the two subnet IDs specified in <c>SubnetIds</c>
        /// property. Amazon FSx serves traffic from this subnet except in the event of a failover
        /// to the secondary file server.
        /// </para>
        ///  
        /// <para>
        /// For <c>SINGLE_AZ_1</c> and <c>SINGLE_AZ_2</c> deployment types, this value is the
        /// same as that for <c>SubnetIDs</c>. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/high-availability-multiAZ.html#single-multi-az-resources">Availability
        /// and durability: Single-AZ and Multi-AZ file systems</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string PreferredSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the PreferredSubnetId property is set.
        /// </summary>
        internal bool IsSetPreferredSubnetId() => this.PreferredSubnetId != null;

        /// <summary>
        /// Gets and sets the property RemoteAdministrationEndpoint. 
        /// <para>
        /// For <c>MULTI_AZ_1</c> deployment types, use this endpoint when performing administrative
        /// tasks on the file system using Amazon FSx Remote PowerShell.
        /// </para>
        ///  
        /// <para>
        /// For <c>SINGLE_AZ_1</c> and <c>SINGLE_AZ_2</c> deployment types, this is the DNS name
        /// of the file system.
        /// </para>
        ///  
        /// <para>
        /// This endpoint is temporarily unavailable when the file system is undergoing maintenance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 275)]
        public string RemoteAdministrationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAdministrationEndpoint property is set.
        /// </summary>
        internal bool IsSetRemoteAdministrationEndpoint() => this.RemoteAdministrationEndpoint != null;

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration.
        /// </summary>
        public SelfManagedActiveDirectoryAttributes SelfManagedActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedActiveDirectoryConfiguration property is set.
        /// </summary>
        internal bool IsSetSelfManagedActiveDirectoryConfiguration() => this.SelfManagedActiveDirectoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of the Amazon FSx file system, measured in megabytes per second.
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
        /// time zone. d is the weekday number, from 1 through 7, beginning with Monday and ending
        /// with Sunday.
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
