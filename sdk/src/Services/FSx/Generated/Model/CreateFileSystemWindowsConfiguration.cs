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
    /// The configuration object for the Microsoft Windows file system used in <code>CreateFileSystem</code>
    /// and <code>CreateFileSystemFromBackup</code> operations.
    /// </summary>
    public partial class CreateFileSystemWindowsConfiguration
    {
        private string _activeDirectoryId;
        private List<string> _aliases = new List<string>();
        private WindowsAuditLogCreateConfiguration _auditLogConfiguration;
        private int? _automaticBackupRetentionDays;
        private bool? _copyTagsToBackups;
        private string _dailyAutomaticBackupStartTime;
        private WindowsDeploymentType _deploymentType;
        private string _preferredSubnetId;
        private SelfManagedActiveDirectoryConfiguration _selfManagedActiveDirectoryConfiguration;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryId. 
        /// <para>
        /// The ID for an existing Amazon Web Services Managed Microsoft Active Directory (AD)
        /// instance that the file system should join when it's created.
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
        /// <para>
        /// An array of one or more DNS alias names that you want to associate with the Amazon
        /// FSx file system. Aliases allow you to use existing DNS names to access the data in
        /// your Amazon FSx file system. You can associate up to 50 aliases with a file system
        /// at any time. You can associate additional DNS aliases after you create the file system
        /// using the AssociateFileSystemAliases operation. You can remove DNS aliases from the
        /// file system after it is created using the DisassociateFileSystemAliases operation.
        /// You only need to specify the alias name in the request payload.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a> and <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/walkthrough05-file-system-custom-CNAME.html">Walkthrough
        /// 5: Using DNS aliases to access your file system</a>, including additional steps you
        /// must take to be able to access your file system using a DNS alias.
        /// </para>
        ///  
        /// <para>
        /// An alias name has to meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Formatted as a fully-qualified domain name (FQDN), <code>hostname.domain</code>, for
        /// example, <code>accounting.example.com</code>.
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
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && this._aliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuditLogConfiguration. 
        /// <para>
        /// The configuration that Amazon FSx for Windows File Server uses to audit and log user
        /// accesses of files, folders, and file shares on the Amazon FSx for Windows File Server
        /// file system.
        /// </para>
        /// </summary>
        public WindowsAuditLogCreateConfiguration AuditLogConfiguration
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
        /// The number of days to retain automatic backups. The default is to retain backups for
        /// 7 days. Setting this value to 0 disables the creation of automatic backups. The maximum
        /// retention period for backups is 90 days.
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
        /// A boolean flag indicating whether tags for the file system should be copied to backups.
        /// This value defaults to false. If it's set to true, all tags for the file system are
        /// copied to all automatic and user-initiated backups where the user doesn't specify
        /// tags. If this value is true, and you specify one or more tags, only the specified
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
        /// Gets and sets the property DailyAutomaticBackupStartTime. 
        /// <para>
        /// The preferred time to take daily automatic backups, formatted HH:MM in the UTC time
        /// zone.
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
        ///  <code>MULTI_AZ_1</code> - Deploys a high availability file system that is configured
        /// for Multi-AZ redundancy to tolerate temporary Availability Zone (AZ) unavailability.
        /// You can only deploy a Multi-AZ file system in Amazon Web Services Regions that have
        /// a minimum of three Availability Zones. Also supports HDD storage type
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_AZ_1</code> - (Default) Choose to deploy a file system that is configured
        /// for single AZ redundancy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SINGLE_AZ_2</code> - The latest generation Single AZ file system. Specifies
        /// a file system that is configured for single AZ redundancy and supports HDD storage
        /// type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/high-availability-multiAZ.html">
        /// Availability and Durability: Single-AZ and Multi-AZ File Systems</a>.
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
        /// Gets and sets the property PreferredSubnetId. 
        /// <para>
        /// Required when <code>DeploymentType</code> is set to <code>MULTI_AZ_1</code>. This
        /// specifies the subnet in which you want the preferred file server to be located. For
        /// in-Amazon Web Services applications, we recommend that you launch your clients in
        /// the same Availability Zone (AZ) as your preferred file server to reduce cross-AZ data
        /// transfer costs and minimize latency. 
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
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration.
        /// </summary>
        public SelfManagedActiveDirectoryConfiguration SelfManagedActiveDirectoryConfiguration
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
        /// Sets the throughput capacity of an Amazon FSx file system, measured in megabytes per
        /// second (MB/s), in 2 to the <i>n</i>th increments, between 2^3 (8) and 2^11 (2048).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=100000)]
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
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone, where d is the weekday number, from 1 through 7, beginning with Monday
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