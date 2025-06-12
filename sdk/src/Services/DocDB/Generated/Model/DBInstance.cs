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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about an instance.
    /// </summary>
    public partial class DBInstance
    {
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private int? _backupRetentionPeriod;
        private string _caCertificateIdentifier;
        private CertificateDetails _certificateDetails;
        private bool? _copyTagsToSnapshot;
        private string _dbClusterIdentifier;
        private string _dbInstanceArn;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbInstanceStatus;
        private string _dbiResourceId;
        private DBSubnetGroup _dbSubnetGroup;
        private List<string> _enabledCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Endpoint _endpoint;
        private string _engine;
        private string _engineVersion;
        private DateTime? _instanceCreateTime;
        private string _kmsKeyId;
        private DateTime? _latestRestorableTime;
        private PendingModifiedValues _pendingModifiedValues;
        private bool? _performanceInsightsEnabled;
        private string _performanceInsightsKMSKeyId;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private int? _promotionTier;
        private bool? _publiclyAccessible;
        private List<DBInstanceStatusInfo> _statusInfos = AWSConfigs.InitializeCollections ? new List<DBInstanceStatusInfo>() : null;
        private bool? _storageEncrypted;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Does not apply. This parameter does not apply to Amazon DocumentDB. Amazon DocumentDB
        /// does not perform minor version upgrades regardless of the value set.
        /// </para>
        /// </summary>
        public bool? AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade; }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone that the instance is located in.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// Specifies the number of days for which automatic snapshots are retained.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod; }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CACertificateIdentifier. 
        /// <para>
        /// The identifier of the CA certificate for this DB instance.
        /// </para>
        /// </summary>
        public string CACertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CACertificateIdentifier property is set
        internal bool IsSetCACertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateDetails. 
        /// <para>
        /// The details of the DB instance's server certificate.
        /// </para>
        /// </summary>
        public CertificateDetails CertificateDetails
        {
            get { return this._certificateDetails; }
            set { this._certificateDetails = value; }
        }

        // Check to see if CertificateDetails property is set
        internal bool IsSetCertificateDetails()
        {
            return this._certificateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy tags from the DB instance to snapshots of the
        /// DB instance. By default, tags are not copied.
        /// </para>
        /// </summary>
        public bool? CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot; }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// Contains the name of the cluster that the instance is a member of if the instance
        /// is a member of a cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the instance.
        /// </para>
        /// </summary>
        public string DBInstanceArn
        {
            get { return this._dbInstanceArn; }
            set { this._dbInstanceArn = value; }
        }

        // Check to see if DBInstanceArn property is set
        internal bool IsSetDBInstanceArn()
        {
            return this._dbInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// Contains the name of the compute and memory capacity class of the instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// Contains a user-provided database identifier. This identifier is the unique key that
        /// identifies an instance.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceStatus. 
        /// <para>
        /// Specifies the current state of this database.
        /// </para>
        /// </summary>
        public string DBInstanceStatus
        {
            get { return this._dbInstanceStatus; }
            set { this._dbInstanceStatus = value; }
        }

        // Check to see if DBInstanceStatus property is set
        internal bool IsSetDBInstanceStatus()
        {
            return this._dbInstanceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the instance. This
        /// identifier is found in CloudTrail log entries whenever the KMS key for the instance
        /// is accessed.
        /// </para>
        /// </summary>
        public string DbiResourceId
        {
            get { return this._dbiResourceId; }
            set { this._dbiResourceId = value; }
        }

        // Check to see if DbiResourceId property is set
        internal bool IsSetDbiResourceId()
        {
            return this._dbiResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroup. 
        /// <para>
        /// Specifies information on the subnet group that is associated with the instance, including
        /// the name, description, and subnets in the subnet group.
        /// </para>
        /// </summary>
        public DBSubnetGroup DBSubnetGroup
        {
            get { return this._dbSubnetGroup; }
            set { this._dbSubnetGroup = value; }
        }

        // Check to see if DBSubnetGroup property is set
        internal bool IsSetDBSubnetGroup()
        {
            return this._dbSubnetGroup != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledCloudwatchLogsExports. 
        /// <para>
        /// A list of log types that this instance is configured to export to CloudWatch Logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledCloudwatchLogsExports
        {
            get { return this._enabledCloudwatchLogsExports; }
            set { this._enabledCloudwatchLogsExports = value; }
        }

        // Check to see if EnabledCloudwatchLogsExports property is set
        internal bool IsSetEnabledCloudwatchLogsExports()
        {
            return this._enabledCloudwatchLogsExports != null && (this._enabledCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Specifies the connection endpoint.
        /// </para>
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Provides the name of the database engine to be used for this instance.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Indicates the database engine version.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// Provides the date and time that the instance was created.
        /// </para>
        /// </summary>
        public DateTime? InstanceCreateTime
        {
            get { return this._instanceCreateTime; }
            set { this._instanceCreateTime = value; }
        }

        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this._instanceCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  If <c>StorageEncrypted</c> is <c>true</c>, the KMS key identifier for the encrypted
        /// instance. 
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// Specifies the latest time to which a database can be restored with point-in-time restore.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime
        {
            get { return this._latestRestorableTime; }
            set { this._latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this._latestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Specifies that changes to the instance are pending. This element is included only
        /// when changes are pending. Specific changes are identified by subelements.
        /// </para>
        /// </summary>
        public PendingModifiedValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsEnabled. 
        /// <para>
        /// Set to <c>true</c> if Amazon RDS Performance Insights is enabled for the DB instance,
        /// and otherwise <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PerformanceInsightsEnabled
        {
            get { return this._performanceInsightsEnabled; }
            set { this._performanceInsightsEnabled = value; }
        }

        // Check to see if PerformanceInsightsEnabled property is set
        internal bool IsSetPerformanceInsightsEnabled()
        {
            return this._performanceInsightsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        /// The KMS key identifier for encryption of Performance Insights data. The KMS key ID
        /// is the Amazon Resource Name (ARN), KMS key identifier, or the KMS key alias for the
        /// KMS encryption key.
        /// </para>
        /// </summary>
        public string PerformanceInsightsKMSKeyId
        {
            get { return this._performanceInsightsKMSKeyId; }
            set { this._performanceInsightsKMSKeyId = value; }
        }

        // Check to see if PerformanceInsightsKMSKeyId property is set
        internal bool IsSetPerformanceInsightsKMSKeyId()
        {
            return this._performanceInsightsKMSKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        ///  Specifies the daily time range during which automated backups are created if automated
        /// backups are enabled, as determined by the <c>BackupRetentionPeriod</c>. 
        /// </para>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// Specifies the weekly time range during which system maintenance can occur, in Universal
        /// Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which an Amazon DocumentDB replica is promoted
        /// to the primary instance after a failure of the existing primary instance.
        /// </para>
        /// </summary>
        public int? PromotionTier
        {
            get { return this._promotionTier; }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Not supported. Amazon DocumentDB does not currently support public endpoints. The
        /// value of <c>PubliclyAccessible</c> is always <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusInfos. 
        /// <para>
        /// The status of a read replica. If the instance is not a read replica, this is blank.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBInstanceStatusInfo> StatusInfos
        {
            get { return this._statusInfos; }
            set { this._statusInfos = value; }
        }

        // Check to see if StatusInfos property is set
        internal bool IsSetStatusInfos()
        {
            return this._statusInfos != null && (this._statusInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether or not the instance is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted
        {
            get { return this._storageEncrypted; }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Provides a list of VPC security group elements that the instance belongs to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}