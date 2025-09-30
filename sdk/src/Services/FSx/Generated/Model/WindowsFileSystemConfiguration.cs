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
    /// The configuration for this Microsoft Windows file system.
    /// </summary>
    public partial class WindowsFileSystemConfiguration
    {
        private string _activeDirectoryId;
        private List<Alias> _aliases = AWSConfigs.InitializeCollections ? new List<Alias>() : null;
        private WindowsAuditLogConfiguration _auditLogConfiguration;
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private string _dailyAutomaticBackupStartTime;
        private WindowsDeploymentType _deploymentType;
        private DiskIopsConfiguration _diskIopsConfiguration;
        private List<string> _maintenanceOperationsInProgress = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _preferredFileServerIp;
        private string _preferredFileServerIpv6;
        private string _preferredSubnetId;
        private string _remoteAdministrationEndpoint;
        private SelfManagedActiveDirectoryAttributes _selfManagedActiveDirectoryConfiguration;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryId. 
        /// <para>
        /// The ID for an existing Amazon Web Services Managed Microsoft Active Directory instance
        /// that the file system is joined to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ActiveDirectoryId
        {
            get { return this._activeDirectoryId; }
            set { this._activeDirectoryId = value; }
        }

        // Check to see if ActiveDirectoryId property is set
        internal bool IsSetActiveDirectoryId()
        {
            return this._activeDirectoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Aliases.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Alias> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && (this._aliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuditLogConfiguration. 
        /// <para>
        /// The configuration that Amazon FSx for Windows File Server uses to audit and log user
        /// accesses of files, folders, and file shares on the Amazon FSx for Windows File Server
        /// file system.
        /// </para>
        /// </summary>
        public WindowsAuditLogConfiguration AuditLogConfiguration
        {
            get { return this._auditLogConfiguration; }
            set { this._auditLogConfiguration = value; }
        }

        // Check to see if AuditLogConfiguration property is set
        internal bool IsSetAuditLogConfiguration()
        {
            return this._auditLogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays. 
        /// <para>
        /// The number of days to retain automatic backups. Setting this to 0 disables automatic
        /// backups. You can retain automatic backups for a maximum of 90 days.
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
        public bool? CopyTagsToBackups
        {
            get { return this._copyTagsToBackups; }
            set { this._copyTagsToBackups = value; }
        }

        // Check to see if CopyTagsToBackups property is set
        internal bool IsSetCopyTagsToBackups()
        {
            return this._copyTagsToBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime. 
        /// <para>
        /// The preferred time to take daily automatic backups, in the UTC time zone.
        /// </para>
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
        public WindowsDeploymentType DeploymentType
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
        /// <para>
        /// The SSD IOPS (input/output operations per second) configuration for an Amazon FSx
        /// for Windows file system. By default, Amazon FSx automatically provisions 3 IOPS per
        /// GiB of storage capacity. You can provision additional IOPS per GiB of storage, up
        /// to the maximum limit associated with your chosen throughput capacity.
        /// </para>
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
        /// Gets and sets the property MaintenanceOperationsInProgress. 
        /// <para>
        /// The list of maintenance operations in progress for this file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> MaintenanceOperationsInProgress
        {
            get { return this._maintenanceOperationsInProgress; }
            set { this._maintenanceOperationsInProgress = value; }
        }

        // Check to see if MaintenanceOperationsInProgress property is set
        internal bool IsSetMaintenanceOperationsInProgress()
        {
            return this._maintenanceOperationsInProgress != null && (this._maintenanceOperationsInProgress.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=45)]
        public string PreferredFileServerIp
        {
            get { return this._preferredFileServerIp; }
            set { this._preferredFileServerIp = value; }
        }

        // Check to see if PreferredFileServerIp property is set
        internal bool IsSetPreferredFileServerIp()
        {
            return this._preferredFileServerIp != null;
        }

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
        [AWSProperty(Min=1, Max=45)]
        public string PreferredFileServerIpv6
        {
            get { return this._preferredFileServerIpv6; }
            set { this._preferredFileServerIpv6 = value; }
        }

        // Check to see if PreferredFileServerIpv6 property is set
        internal bool IsSetPreferredFileServerIpv6()
        {
            return this._preferredFileServerIpv6 != null;
        }

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
        [AWSProperty(Min=15, Max=24)]
        public string PreferredSubnetId
        {
            get { return this._preferredSubnetId; }
            set { this._preferredSubnetId = value; }
        }

        // Check to see if PreferredSubnetId property is set
        internal bool IsSetPreferredSubnetId()
        {
            return this._preferredSubnetId != null;
        }

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
        [AWSProperty(Min=16, Max=275)]
        public string RemoteAdministrationEndpoint
        {
            get { return this._remoteAdministrationEndpoint; }
            set { this._remoteAdministrationEndpoint = value; }
        }

        // Check to see if RemoteAdministrationEndpoint property is set
        internal bool IsSetRemoteAdministrationEndpoint()
        {
            return this._remoteAdministrationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration.
        /// </summary>
        public SelfManagedActiveDirectoryAttributes SelfManagedActiveDirectoryConfiguration
        {
            get { return this._selfManagedActiveDirectoryConfiguration; }
            set { this._selfManagedActiveDirectoryConfiguration = value; }
        }

        // Check to see if SelfManagedActiveDirectoryConfiguration property is set
        internal bool IsSetSelfManagedActiveDirectoryConfiguration()
        {
            return this._selfManagedActiveDirectoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// The throughput of the Amazon FSx file system, measured in megabytes per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=100000)]
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
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone. d is the weekday number, from 1 through 7, beginning with Monday and ending
        /// with Sunday.
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