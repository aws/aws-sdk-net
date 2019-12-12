/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for this Microsoft Windows file system.
    /// </summary>
    public partial class WindowsFileSystemConfiguration
    {
        private string _activeDirectoryId;
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private string _dailyAutomaticBackupStartTime;
        private WindowsDeploymentType _deploymentType;
        private List<string> _maintenanceOperationsInProgress = new List<string>();
        private string _preferredFileServerIp;
        private string _preferredSubnetId;
        private string _remoteAdministrationEndpoint;
        private SelfManagedActiveDirectoryAttributes _selfManagedActiveDirectoryConfiguration;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryId. 
        /// <para>
        /// The ID for an existing Microsoft Active Directory instance that the file system should
        /// join when it's created.
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
        /// Gets and sets the property AutomaticBackupRetentionDays. 
        /// <para>
        /// The number of days to retain automatic backups. Setting this to 0 disables automatic
        /// backups. You can retain automatic backups for a maximum of 35 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=35)]
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
        /// A boolean flag indicating whether tags on the file system should be copied to backups.
        /// This value defaults to false. If it's set to true, all tags on the file system are
        /// copied to all automatic backups and any user-initiated backups where the user doesn't
        /// specify any tags. If this value is true, and you specify one or more tags, only the
        /// specified tags are copied to backups.
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
        ///  <code>MULTI_AZ_1</code> - Specifies a high availability file system that is configured
        /// for Multi-AZ redundancy to tolerate temporary Availability Zone (AZ) unavailability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_AZ_1</code> - (Default) Specifies a file system that is configured for
        /// single AZ redundancy.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property MaintenanceOperationsInProgress. 
        /// <para>
        /// The list of maintenance operations in progress for this file system.
        /// </para>
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
            return this._maintenanceOperationsInProgress != null && this._maintenanceOperationsInProgress.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreferredFileServerIp. 
        /// <para>
        /// For <code>MULTI_AZ_1</code> deployment types, the IP address of the primary, or preferred,
        /// file server.
        /// </para>
        ///  
        /// <para>
        /// Use this IP address when mounting the file system on Linux SMB clients or Windows
        /// SMB clients that are not joined to a Microsoft Active Directory. Applicable for both
        /// <code>SINGLE_AZ_1</code> and <code>MULTI_AZ_1</code> deployment types. This IP address
        /// is temporarily unavailable when the file system is undergoing maintenance. For Linux
        /// and Windows SMB clients that are joined to an Active Directory, use the file system's
        /// DNSName instead. For more information and instruction on mapping and mounting file
        /// shares, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/accessing-file-shares.html">https://docs.aws.amazon.com/fsx/latest/WindowsGuide/accessing-file-shares.html</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// For <code>MULTI_AZ_1</code> deployment types, it specifies the ID of the subnet where
        /// the preferred file server is located. Must be one of the two subnet IDs specified
        /// in <code>SubnetIds</code> property. Amazon FSx serves traffic from this subnet except
        /// in the event of a failover to the secondary file server.
        /// </para>
        ///  
        /// <para>
        /// For <code>SINGLE_AZ_1</code> deployment types, this value is the same as that for
        /// <code>SubnetIDs</code>.
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
        /// For <code>MULTI_AZ_1</code> deployment types, use this endpoint when performing administrative
        /// tasks on the file system using Amazon FSx Remote PowerShell.
        /// </para>
        ///  
        /// <para>
        /// For <code>SINGLE_AZ_1</code> deployment types, this is the DNS name of the file system.
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
        /// The throughput of an Amazon FSx file system, measured in megabytes per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=2048)]
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
        /// <para>
        /// The preferred time to perform weekly maintenance, in the UTC time zone.
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