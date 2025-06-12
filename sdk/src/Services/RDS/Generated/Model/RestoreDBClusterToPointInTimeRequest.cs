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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBClusterToPointInTime operation.
    /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
    /// in time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c>
    /// days. The target DB cluster is created from the source DB cluster with the same configuration
    /// as the original DB cluster, except that the new DB cluster is created with the default
    /// DB security group. Unless the <c>RestoreType</c> is set to <c>copy-on-write</c>, the
    /// restore may occur in a different Availability Zone (AZ) from the original DB cluster.
    /// The AZ where RDS restores the DB cluster depends on the AZs in the specified subnet
    /// group.
    /// 
    ///  <note> 
    /// <para>
    /// For Aurora, this operation only restores the DB cluster, not the DB instances for
    /// that DB cluster. You must invoke the <c>CreateDBInstance</c> operation to create DB
    /// instances for the restored DB cluster, specifying the identifier of the restored DB
    /// cluster in <c>DBClusterIdentifier</c>. You can create DB instances only after the
    /// <c>RestoreDBClusterToPointInTime</c> operation has completed and the DB cluster is
    /// available.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class RestoreDBClusterToPointInTimeRequest : AmazonRDSRequest
    {
        private long? _backtrackWindow;
        private bool? _copyTagsToSnapshot;
        private string _dbClusterIdentifier;
        private string _dbClusterInstanceClass;
        private string _dbClusterParameterGroupName;
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private string _engineLifecycleSupport;
        private string _engineMode;
        private int? _iops;
        private string _kmsKeyId;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private string _networkType;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private bool? _publiclyAccessible;
        private RdsCustomClusterConfiguration _rdsCustomClusterConfiguration;
        private DateTime? _restoreToTime;
        private string _restoreType;
        private ScalingConfiguration _scalingConfiguration;
        private ServerlessV2ScalingConfiguration _serverlessV2ScalingConfiguration;
        private string _sourceDBClusterIdentifier;
        private string _sourceDbClusterResourceId;
        private string _storageType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _useLatestRestorableTime;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. To disable backtracking, set this value to
        /// 0.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If specified, this value must be set to a number from 0 to 259,200 (72 hours).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for: Aurora MySQL DB clusters only
        /// </para>
        /// </summary>
        public long? BacktrackWindow
        {
            get { return this._backtrackWindow; }
            set { this._backtrackWindow = value; }
        }

        // Check to see if BacktrackWindow property is set
        internal bool IsSetBacktrackWindow()
        {
            return this._backtrackWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// Specifies whether to copy all tags from the restored DB cluster to snapshots of the
        /// restored DB cluster. The default is not to copy them.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
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
        /// The name of the new DB cluster to be created.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DBClusterInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the each DB instance in the Multi-AZ DB cluster,
        /// for example db.m6gd.xlarge. Not all DB instance classes are available in all Amazon
        /// Web Services Regions, or for all database engines.
        /// </para>
        ///  
        /// <para>
        /// For the full list of DB instance classes, and availability for your engine, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// instance class</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Multi-AZ DB clusters only
        /// </para>
        /// </summary>
        public string DBClusterInstanceClass
        {
            get { return this._dbClusterInstanceClass; }
            set { this._dbClusterInstanceClass = value; }
        }

        // Check to see if DBClusterInstanceClass property is set
        internal bool IsSetDBClusterInstanceClass()
        {
            return this._dbClusterInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the custom DB cluster parameter group to associate with this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DBClusterParameterGroupName</c> parameter is omitted, the default DB cluster
        /// parameter group for the specified engine is used.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB cluster parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The DB subnet group name to use for the new DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: If supplied, must match the name of an existing DBSubnetGroup.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>mydbsubnetgroup</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the DB cluster. The database can't
        /// be deleted when deletion protection is enabled. By default, deletion protection isn't
        /// enabled.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Active Directory directory ID to restore the DB cluster in. The domain must be
        /// created prior to this operation.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Aurora DB clusters, Amazon RDS can use Kerberos Authentication to authenticate
        /// users that connect to the DB cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html">Kerberos
        /// Authentication</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIAMRoleName. 
        /// <para>
        /// The name of the IAM role to be used when making API calls to the Directory Service.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string DomainIAMRoleName
        {
            get { return this._domainIAMRoleName; }
            set { this._domainIAMRoleName = value; }
        }

        // Check to see if DomainIAMRoleName property is set
        internal bool IsSetDomainIAMRoleName()
        {
            return this._domainIAMRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property EnableCloudwatchLogsExports. 
        /// <para>
        /// The list of logs that the restored DB cluster is to export to CloudWatch Logs. The
        /// values in the list depend on the DB engine being used.
        /// </para>
        ///  
        /// <para>
        ///  <b>RDS for MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <c>error</c>, <c>general</c>, <c>slowquery</c>, and <c>iam-db-auth-error</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>RDS for PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <c>postgresql</c>, <c>upgrade</c>, and <c>iam-db-auth-error</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <c>audit</c>, <c>error</c>, <c>general</c>, <c>instance</c>, <c>slowquery</c>,
        /// and <c>iam-db-auth-error</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible value are <c>instance</c>, <c>postgresql</c>, and <c>iam-db-auth-error</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon RDS, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about exporting CloudWatch Logs for Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnableCloudwatchLogsExports
        {
            get { return this._enableCloudwatchLogsExports; }
            set { this._enableCloudwatchLogsExports = value; }
        }

        // Check to see if EnableCloudwatchLogsExports property is set
        internal bool IsSetEnableCloudwatchLogsExports()
        {
            return this._enableCloudwatchLogsExports != null && (this._enableCloudwatchLogsExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// Specifies whether to enable mapping of Amazon Web Services Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping isn't enabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication</a> in the <i>Amazon Aurora User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM database authentication for MariaDB, MySQL, and PostgreSQL</a> in the <i>Amazon
        /// RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? EnableIAMDatabaseAuthentication
        {
            get { return this._enableIAMDatabaseAuthentication; }
            set { this._enableIAMDatabaseAuthentication = value; }
        }

        // Check to see if EnableIAMDatabaseAuthentication property is set
        internal bool IsSetEnableIAMDatabaseAuthentication()
        {
            return this._enableIAMDatabaseAuthentication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePerformanceInsights. 
        /// <para>
        /// Specifies whether to turn on Performance Insights for the DB cluster.
        /// </para>
        /// </summary>
        public bool? EnablePerformanceInsights
        {
            get { return this._enablePerformanceInsights; }
            set { this._enablePerformanceInsights = value; }
        }

        // Check to see if EnablePerformanceInsights property is set
        internal bool IsSetEnablePerformanceInsights()
        {
            return this._enablePerformanceInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineLifecycleSupport. 
        /// <para>
        /// The life cycle type for this DB cluster.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, this value is set to <c>open-source-rds-extended-support</c>, which enrolls
        /// your DB cluster into Amazon RDS Extended Support. At the end of standard support,
        /// you can avoid charges for Extended Support by setting the value to <c>open-source-rds-extended-support-disabled</c>.
        /// In this case, RDS automatically upgrades your restored DB cluster to a higher engine
        /// version, if the major engine version is past its end of standard support date.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use this setting to enroll your DB cluster into Amazon RDS Extended Support.
        /// With RDS Extended Support, you can run the selected major engine version on your DB
        /// cluster past the end of standard support for that engine version. For more information,
        /// see the following sections:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora - <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon Aurora</a> in the <i>Amazon Aurora User Guide</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon RDS - <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/extended-support.html">Amazon
        /// RDS Extended Support with Amazon RDS</a> in the <i>Amazon RDS User Guide</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for Cluster Type: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>open-source-rds-extended-support | open-source-rds-extended-support-disabled</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>open-source-rds-extended-support</c> 
        /// </para>
        /// </summary>
        public string EngineLifecycleSupport
        {
            get { return this._engineLifecycleSupport; }
            set { this._engineLifecycleSupport = value; }
        }

        // Check to see if EngineLifecycleSupport property is set
        internal bool IsSetEngineLifecycleSupport()
        {
            return this._engineLifecycleSupport != null;
        }

        /// <summary>
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The engine mode of the new cluster. Specify <c>provisioned</c> or <c>serverless</c>,
        /// depending on the type of the cluster you are creating. You can create an Aurora Serverless
        /// v1 clone from a provisioned cluster, or a provisioned clone from an Aurora Serverless
        /// v1 cluster. To create a clone that is an Aurora Serverless v1 cluster, the original
        /// cluster must be an Aurora Serverless v1 cluster or an encrypted provisioned cluster.
        /// To create a full copy that is an Aurora Serverless v1 cluster, specify the engine
        /// mode <c>serverless</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string EngineMode
        {
            get { return this._engineMode; }
            set { this._engineMode = value; }
        }

        // Check to see if EngineMode property is set
        internal bool IsSetEngineMode()
        {
            return this._engineMode != null;
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for each DB instance in the Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For information about valid IOPS values, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Storage.html#USER_PIOPS">Amazon
        /// RDS Provisioned IOPS storage</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be a multiple between .5 and 50 of the storage amount for the DB
        /// instance.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Multi-AZ DB clusters only
        /// </para>
        /// </summary>
        public int? Iops
        {
            get { return this._iops; }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to use when restoring an encrypted DB cluster
        /// from an encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key. To use a KMS key in a different Amazon Web Services account,
        /// specify the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// You can restore to a new DB cluster and encrypt the new DB cluster with a KMS key
        /// that is different from the KMS key used to encrypt the source DB cluster. The new
        /// DB cluster is encrypted with the KMS key identified by the <c>KmsKeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyId</c> parameter, then the following
        /// occurs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the DB cluster is encrypted, then the restored DB cluster is encrypted using the
        /// KMS key that was used to encrypt the source DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DB cluster isn't encrypted, then the restored DB cluster isn't encrypted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBClusterIdentifier</c> refers to a DB cluster that isn't encrypted, then the
        /// restore request is rejected.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
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
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the DB cluster. To turn off collecting Enhanced Monitoring metrics, specify <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringRoleArn</c> is specified, also set <c>MonitoringInterval</c> to a
        /// value other than <c>0</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>0 | 1 | 5 | 10 | 15 | 30 | 60</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> 
        /// </para>
        /// </summary>
        public int? MonitoringInterval
        {
            get { return this._monitoringInterval; }
            set { this._monitoringInterval = value; }
        }

        // Check to see if MonitoringInterval property is set
        internal bool IsSetMonitoringInterval()
        {
            return this._monitoringInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that permits RDS to send Enhanced
        /// Monitoring metrics to Amazon CloudWatch Logs. An example is <c>arn:aws:iam:123456789012:role/emaccess</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>MonitoringInterval</c> is set to a value other than <c>0</c>, supply a <c>MonitoringRoleArn</c>
        /// value.
        /// </para>
        /// </summary>
        public string MonitoringRoleArn
        {
            get { return this._monitoringRoleArn; }
            set { this._monitoringRoleArn = value; }
        }

        // Check to see if MonitoringRoleArn property is set
        internal bool IsSetMonitoringRoleArn()
        {
            return this._monitoringRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The network type is determined by the <c>DBSubnetGroup</c> specified for the DB cluster.
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon Aurora User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public string NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The name of the option group for the new DB cluster.
        /// </para>
        ///  
        /// <para>
        /// DB clusters are associated with a default option group that can't be modified.
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceInsightsKMSKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of Performance Insights
        /// data.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for <c>PerformanceInsightsKMSKeyId</c>, then Amazon RDS
        /// uses your default KMS key. There is a default KMS key for your Amazon Web Services
        /// account. Your Amazon Web Services account has a different default KMS key for each
        /// Amazon Web Services Region.
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
        /// Gets and sets the property PerformanceInsightsRetentionPeriod. 
        /// <para>
        /// The number of days to retain Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>7</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>month</i> * 31, where <i>month</i> is a number of months from 1-23. Examples:
        /// <c>93</c> (3 months * 31), <c>341</c> (11 months * 31), <c>589</c> (19 months * 31)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>731</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>7</c> days
        /// </para>
        ///  
        /// <para>
        /// If you specify a retention period that isn't valid, such as <c>94</c>, Amazon RDS
        /// issues an error.
        /// </para>
        /// </summary>
        public int? PerformanceInsightsRetentionPeriod
        {
            get { return this._performanceInsightsRetentionPeriod; }
            set { this._performanceInsightsRetentionPeriod = value; }
        }

        // Check to see if PerformanceInsightsRetentionPeriod property is set
        internal bool IsSetPerformanceInsightsRetentionPeriod()
        {
            return this._performanceInsightsRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the new DB cluster accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Constraints: A value from <c>1150-65535</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: The default port for the engine.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB cluster is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB cluster's virtual private cloud
        /// (VPC). It resolves to the public IP address from outside of the DB cluster's VPC.
        /// Access to the DB cluster is ultimately controlled by the security group it uses. That
        /// public access is not permitted if the security group assigned to the DB cluster doesn't
        /// permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB cluster isn't publicly accessible, it is an internal DB cluster with a
        /// DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// Default: The default behavior varies depending on whether <c>DBSubnetGroupName</c>
        /// is specified.
        /// </para>
        ///  
        /// <para>
        /// If <c>DBSubnetGroupName</c> isn't specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the default VPC in the target Region doesn’t have an internet gateway attached
        /// to it, the DB cluster is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the default VPC in the target Region has an internet gateway attached to it, the
        /// DB cluster is public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBSubnetGroupName</c> is specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the subnets are part of a VPC that doesn’t have an internet gateway attached to
        /// it, the DB cluster is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the subnets are part of a VPC that has an internet gateway attached to it, the
        /// DB cluster is public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for: Multi-AZ DB clusters only
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
        /// Gets and sets the property RdsCustomClusterConfiguration. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public RdsCustomClusterConfiguration RdsCustomClusterConfiguration
        {
            get { return this._rdsCustomClusterConfiguration; }
            set { this._rdsCustomClusterConfiguration = value; }
        }

        // Check to see if RdsCustomClusterConfiguration property is set
        internal bool IsSetRdsCustomClusterConfiguration()
        {
            return this._rdsCustomClusterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreToTime. 
        /// <para>
        /// The date and time to restore the DB cluster to.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: Value must be a time in Universal Coordinated Time (UTC) format
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be before the latest restorable time for the DB instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be specified if <c>UseLatestRestorableTime</c> parameter isn't provided
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <c>UseLatestRestorableTime</c> parameter is enabled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be specified if the <c>RestoreType</c> parameter is <c>copy-on-write</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>2015-03-07T23:45:00Z</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public DateTime? RestoreToTime
        {
            get { return this._restoreToTime; }
            set { this._restoreToTime = value; }
        }

        // Check to see if RestoreToTime property is set
        internal bool IsSetRestoreToTime()
        {
            return this._restoreToTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreType. 
        /// <para>
        /// The type of restore to be performed. You can specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>full-copy</c> - The new DB cluster is restored as a full copy of the source DB
        /// cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>copy-on-write</c> - The new DB cluster is restored as a clone of the source DB
        /// cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>RestoreType</c> value, then the new DB cluster is restored
        /// as a full copy of the source DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string RestoreType
        {
            get { return this._restoreType; }
            set { this._restoreType = value; }
        }

        // Check to see if RestoreType property is set
        internal bool IsSetRestoreType()
        {
            return this._restoreType != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// For DB clusters in <c>serverless</c> DB engine mode, the scaling properties of the
        /// DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        public ScalingConfiguration ScalingConfiguration
        {
            get { return this._scalingConfiguration; }
            set { this._scalingConfiguration = value; }
        }

        // Check to see if ScalingConfiguration property is set
        internal bool IsSetScalingConfiguration()
        {
            return this._scalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2ScalingConfiguration.
        /// </summary>
        public ServerlessV2ScalingConfiguration ServerlessV2ScalingConfiguration
        {
            get { return this._serverlessV2ScalingConfiguration; }
            set { this._serverlessV2ScalingConfiguration = value; }
        }

        // Check to see if ServerlessV2ScalingConfiguration property is set
        internal bool IsSetServerlessV2ScalingConfiguration()
        {
            return this._serverlessV2ScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBClusterIdentifier. 
        /// <para>
        /// The identifier of the source DB cluster from which to restore.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DBCluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string SourceDBClusterIdentifier
        {
            get { return this._sourceDBClusterIdentifier; }
            set { this._sourceDBClusterIdentifier = value; }
        }

        // Check to see if SourceDBClusterIdentifier property is set
        internal bool IsSetSourceDBClusterIdentifier()
        {
            return this._sourceDBClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDbClusterResourceId. 
        /// <para>
        /// The resource ID of the source DB cluster from which to restore.
        /// </para>
        /// </summary>
        public string SourceDbClusterResourceId
        {
            get { return this._sourceDbClusterResourceId; }
            set { this._sourceDbClusterResourceId = value; }
        }

        // Check to see if SourceDbClusterResourceId property is set
        internal bool IsSetSourceDbClusterResourceId()
        {
            return this._sourceDbClusterResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies the storage type to be associated with the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// When specified for a Multi-AZ DB cluster, a value for the <c>Iops</c> parameter is
        /// required.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>aurora</c>, <c>aurora-iopt1</c> (Aurora DB clusters); <c>io1</c>
        /// (Multi-AZ DB clusters)
        /// </para>
        ///  
        /// <para>
        /// Default: <c>aurora</c> (Aurora DB clusters); <c>io1</c> (Multi-AZ DB clusters)
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        /// Specifies whether to restore the DB cluster to the latest restorable backup time.
        /// By default, the DB cluster isn't restored to the latest restorable backup time.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Can't be specified if <c>RestoreToTime</c> parameter is provided.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// </summary>
        public bool? UseLatestRestorableTime
        {
            get { return this._useLatestRestorableTime; }
            set { this._useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this._useLatestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security groups that the new DB cluster belongs to.
        /// </para>
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters and Multi-AZ DB clusters
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}