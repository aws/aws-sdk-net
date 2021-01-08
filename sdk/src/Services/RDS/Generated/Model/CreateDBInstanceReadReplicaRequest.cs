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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBInstanceReadReplica operation.
    /// Creates a new DB instance that acts as a read replica for an existing source DB instance.
    /// You can create a read replica for a DB instance running MySQL, MariaDB, Oracle, PostgreSQL,
    /// or SQL Server. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
    /// with Read Replicas</a> in the <i>Amazon RDS User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// Amazon Aurora doesn't support this action. Call the <code>CreateDBInstance</code>
    /// action to create a DB instance for an Aurora DB cluster.
    /// </para>
    ///  
    /// <para>
    /// All read replica DB instances are created with backups disabled. All other DB instance
    /// attributes (including DB security groups and DB parameter groups) are inherited from
    /// the source DB instance, except as specified.
    /// </para>
    ///  <important> 
    /// <para>
    /// Your source DB instance must have backup retention enabled. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateDBInstanceReadReplicaRequest : AmazonRDSRequest
    {
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private bool? _copyTagsToSnapshot;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbParameterGroupName;
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = new List<string>();
        private bool? _enableIAMDatabaseAuthentication;
        private bool? _enablePerformanceInsights;
        private int? _iops;
        private string _kmsKeyId;
        private int? _maxAllocatedStorage;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private bool? _multiAZ;
        private string _optionGroupName;
        private string _performanceInsightsKMSKeyId;
        private int? _performanceInsightsRetentionPeriod;
        private int? _port;
        private string _preSignedUrl;
        private List<ProcessorFeature> _processorFeatures = new List<ProcessorFeature>();
        private bool? _publiclyAccessible;
        private ReplicaMode _replicaMode;
        private string _sourceDBInstanceIdentifier;
        private string _storageType;
        private List<Tag> _tags = new List<Tag>();
        private bool? _useDefaultProcessorFeatures;
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceReadReplicaRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceReadReplicaRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier of the read replica. This identifier is the unique key that identifies a DB instance. This parameter is stored as a lowercase string.</param>
        /// <param name="sourceDBInstanceIdentifier">The identifier of the DB instance that will act as the source for the read replica. Each DB instance can have up to five read replicas. Constraints: <ul> <li> Must be the identifier of an existing MySQL, MariaDB, Oracle, PostgreSQL, or SQL Server DB instance. </li> <li> Can specify a DB instance that is a MySQL read replica only if the source is running MySQL 5.6 or later. </li> <li> For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Read Replica Limitations with Oracle</a> in the <i>Amazon RDS User Guide</i>. </li> <li> For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.Limitations.html">Read Replica Limitations with Microsoft SQL Server</a> in the <i>Amazon RDS User Guide</i>. </li> <li> Can specify a PostgreSQL DB instance only if the source is running PostgreSQL 9.3.5 or later (9.4.7 and higher for cross-region replication). </li> <li> The specified DB instance must have automatic backups enabled, that is, its backup retention period must be greater than 0. </li> <li> If the source DB instance is in the same AWS Region as the read replica, specify a valid DB instance identifier. </li> <li> If the source DB instance is in a different AWS Region from the read replica, specify a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply to SQL Server, which doesn't support cross-region replicas. </li> </ul></param>
        public CreateDBInstanceReadReplicaRequest(string dbInstanceIdentifier, string sourceDBInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
            _sourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// A value that indicates whether minor engine upgrades are applied automatically to
        /// the read replica during the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits from the source DB instance
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
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
        /// The Availability Zone (AZ) where the read replica will be created.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's AWS Region.
        /// </para>
        ///  
        /// <para>
        ///  Example: <code>us-east-1d</code> 
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy all tags from the read replica to snapshots
        /// of the read replica. By default, tags are not copied.
        /// </para>
        /// </summary>
        public bool CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot.GetValueOrDefault(); }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The compute and memory capacity of the read replica, for example, <code>db.m4.large</code>.
        /// Not all DB instance classes are available in all AWS Regions, or for all database
        /// engines. For the full list of DB instance classes, and availability for your engine,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html">DB
        /// Instance Class</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits from the source DB instance.
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
        /// The DB instance identifier of the read replica. This identifier is the unique key
        /// that identifies a DB instance. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group to associate with this DB instance.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for <code>DBParameterGroupName</code>, then Amazon RDS
        /// uses the <code>DBParameterGroup</code> of source DB instance for a same region read
        /// replica, or the default <code>DBParameterGroup</code> for the specified DB engine
        /// for a cross region read replica.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, specifying a parameter group for this operation is only supported for Oracle
        /// DB instances.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
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
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// Specifies a DB subnet group for the DB instance. The new DB instance is created in
        /// the VPC associated with the DB subnet group. If no DB subnet group is specified, then
        /// the new DB instance isn't created in a VPC.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can only be specified if the source DB instance identifier specifies a DB instance
        /// in another AWS Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DBSubnetGroup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB subnet group must be in the same AWS Region in which the operation
        /// is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All read replicas in one AWS Region that are created from the same source DB instance
        /// must either:&gt;
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify DB subnet groups from the same VPC. All these read replicas are created in
        /// the same VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not specify a DB subnet group. All these read replicas are created outside of any
        /// VPC.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Example: <code>mySubnetgroup</code> 
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
        /// A value that indicates whether the DB instance has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection is disabled. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_DeleteInstance.html">
        /// Deleting a DB Instance</a>. 
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
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
        /// The Active Directory directory ID to create the DB instance in. Currently, only MySQL,
        /// Microsoft SQL Server, Oracle, and PostgreSQL DB instances can be created in an Active
        /// Directory Domain.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/kerberos-authentication.html">
        /// Kerberos Authentication</a> in the <i>Amazon RDS User Guide</i>.
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
        /// Specify the name of the IAM role to be used when making API calls to the Directory
        /// Service.
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
        /// The list of logs that the new DB instance is to export to CloudWatch Logs. The values
        /// in the list depend on the DB engine being used. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs </a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> EnableCloudwatchLogsExports
        {
            get { return this._enableCloudwatchLogsExports; }
            set { this._enableCloudwatchLogsExports = value; }
        }

        // Check to see if EnableCloudwatchLogsExports property is set
        internal bool IsSetEnableCloudwatchLogsExports()
        {
            return this._enableCloudwatchLogsExports != null && this._enableCloudwatchLogsExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// A value that indicates whether to enable mapping of AWS Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping is disabled.
        /// </para>
        ///  
        /// <para>
        /// For more information about IAM database authentication, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication for MySQL and PostgreSQL</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        /// </summary>
        public bool EnableIAMDatabaseAuthentication
        {
            get { return this._enableIAMDatabaseAuthentication.GetValueOrDefault(); }
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
        /// A value that indicates whether to enable Performance Insights for the read replica.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">Using
        /// Amazon Performance Insights</a> in the <i>Amazon RDS User Guide</i>. 
        /// </para>
        /// </summary>
        public bool EnablePerformanceInsights
        {
            get { return this._enablePerformanceInsights.GetValueOrDefault(); }
            set { this._enablePerformanceInsights = value; }
        }

        // Check to see if EnablePerformanceInsights property is set
        internal bool IsSetEnablePerformanceInsights()
        {
            return this._enablePerformanceInsights.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for the DB instance.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
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
        /// The AWS KMS key identifier for an encrypted read replica.
        /// </para>
        ///  
        /// <para>
        /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the
        /// AWS KMS CMK.
        /// </para>
        ///  
        /// <para>
        /// If you create an encrypted read replica in the same AWS Region as the source DB instance,
        /// then do not specify a value for this parameter. A read replica in the same Region
        /// is always encrypted with the same AWS KMS CMK as the source DB instance.
        /// </para>
        ///  
        /// <para>
        /// If you create an encrypted read replica in a different AWS Region, then you must specify
        /// a AWS KMS key identifier for the destination AWS Region. AWS KMS CMKs are specific
        /// to the AWS Region that they are created in, and you can't use CMKs from one AWS Region
        /// in another AWS Region.
        /// </para>
        ///  
        /// <para>
        /// You can't create an encrypted read replica from an unencrypted DB instance.
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
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        /// The upper limit to which Amazon RDS can automatically scale the storage of the DB
        /// instance.
        /// </para>
        /// </summary>
        public int MaxAllocatedStorage
        {
            get { return this._maxAllocatedStorage.GetValueOrDefault(); }
            set { this._maxAllocatedStorage = value; }
        }

        // Check to see if MaxAllocatedStorage property is set
        internal bool IsSetMaxAllocatedStorage()
        {
            return this._maxAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonitoringInterval. 
        /// <para>
        /// The interval, in seconds, between points when Enhanced Monitoring metrics are collected
        /// for the read replica. To disable collecting Enhanced Monitoring metrics, specify 0.
        /// The default is 0.
        /// </para>
        ///  
        /// <para>
        /// If <code>MonitoringRoleArn</code> is specified, then you must also set <code>MonitoringInterval</code>
        /// to a value other than 0.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>0, 1, 5, 10, 15, 30, 60</code> 
        /// </para>
        /// </summary>
        public int MonitoringInterval
        {
            get { return this._monitoringInterval.GetValueOrDefault(); }
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
        /// The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to Amazon
        /// CloudWatch Logs. For example, <code>arn:aws:iam:123456789012:role/emaccess</code>.
        /// For information on creating a monitoring role, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If <code>MonitoringInterval</code> is set to a value other than 0, then you must supply
        /// a <code>MonitoringRoleArn</code> value.
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
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// A value that indicates whether the read replica is in a Multi-AZ deployment. 
        /// </para>
        ///  
        /// <para>
        /// You can create a read replica as a Multi-AZ DB instance. RDS creates a standby of
        /// your replica in another Availability Zone for failover support for the replica. Creating
        /// your read replica as a Multi-AZ DB instance is independent of whether the source database
        /// is a Multi-AZ DB instance. 
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group the DB instance is associated with. If omitted, the option group
        /// associated with the source instance is used.
        /// </para>
        ///  <note> 
        /// <para>
        /// For SQL Server, you must use the option group associated with the source instance.
        /// </para>
        ///  </note>
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
        /// The AWS KMS key identifier for encryption of Performance Insights data.
        /// </para>
        ///  
        /// <para>
        /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the
        /// AWS KMS customer master key (CMK).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value for <code>PerformanceInsightsKMSKeyId</code>, then Amazon
        /// RDS uses your default CMK. There is a default CMK for your AWS account. Your AWS account
        /// has a different default CMK for each AWS Region.
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
        /// The amount of time, in days, to retain Performance Insights data. Valid values are
        /// 7 or 731 (2 years). 
        /// </para>
        /// </summary>
        public int PerformanceInsightsRetentionPeriod
        {
            get { return this._performanceInsightsRetentionPeriod.GetValueOrDefault(); }
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
        /// The port number that the DB instance uses for connections.
        /// </para>
        ///  
        /// <para>
        /// Default: Inherits from the source DB instance
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>1150-65535</code> 
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// The URL that contains a Signature Version 4 signed request for the <code>CreateDBInstanceReadReplica</code>
        /// API action in the source AWS Region that contains the source DB instance. 
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter when you create an encrypted read replica from another
        /// AWS Region by using the Amazon RDS API. Don't specify <code>PreSignedUrl</code> when
        /// you are creating an encrypted read replica in the same AWS Region.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <code>CreateDBInstanceReadReplica</code>
        /// API action that can be executed in the source AWS Region that contains the encrypted
        /// source DB instance. The presigned URL request must contain the following parameter
        /// values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The AWS Region that the encrypted read replica is
        /// created in. This AWS Region is the same one where the <code>CreateDBInstanceReadReplica</code>
        /// action is called that contains this presigned URL.
        /// </para>
        ///  
        /// <para>
        /// For example, if you create an encrypted DB instance in the us-west-1 AWS Region, from
        /// a source DB instance in the us-east-2 AWS Region, then you call the <code>CreateDBInstanceReadReplica</code>
        /// action in the us-east-1 AWS Region and provide a presigned URL that contains a call
        /// to the <code>CreateDBInstanceReadReplica</code> action in the us-west-2 AWS Region.
        /// For this example, the <code>DestinationRegion</code> in the presigned URL must be
        /// set to the us-east-1 AWS Region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The AWS KMS key identifier for the key to use to encrypt
        /// the read replica in the destination AWS Region. This is the same identifier for both
        /// the <code>CreateDBInstanceReadReplica</code> action that is called in the destination
        /// AWS Region, and the action contained in the presigned URL. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBInstanceIdentifier</code> - The DB instance identifier for the encrypted
        /// DB instance to be replicated. This identifier must be in the Amazon Resource Name
        /// (ARN) format for the source AWS Region. For example, if you are creating an encrypted
        /// read replica from a DB instance in the us-west-2 AWS Region, then your <code>SourceDBInstanceIdentifier</code>
        /// looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:instance:mysql-instance1-20161115</code>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">Authenticating
        /// Requests: Using Query Parameters (AWS Signature Version 4)</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4 Signing Process</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
        /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
        /// manually. Specifying <code>SourceRegion</code> autogenerates a presigned URL that
        /// is a valid request for the operation that can be executed in the source AWS Region.
        /// </para>
        ///  
        /// <para>
        ///  <code>SourceRegion</code> isn't supported for SQL Server, because SQL Server on Amazon
        /// RDS doesn't support cross-region read replicas.
        /// </para>
        ///  </note>
        /// </summary>
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
        /// </para>
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures
        {
            get { return this._processorFeatures; }
            set { this._processorFeatures = value; }
        }

        // Check to see if ProcessorFeatures property is set
        internal bool IsSetProcessorFeatures()
        {
            return this._processorFeatures != null && this._processorFeatures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A value that indicates whether the DB instance is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance is publicly accessible, its DNS endpoint resolves to the private
        /// IP address from within the DB instance's VPC, and to the public IP address from outside
        /// of the DB instance's VPC. Access to the DB instance is ultimately controlled by the
        /// security group it uses, and that public access is not permitted if the security group
        /// assigned to the DB instance doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB instance isn't publicly accessible, it is an internal DB instance with
        /// a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBInstance</a>.
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaMode. 
        /// <para>
        /// The open mode of the replica database: mounted or read-only.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported for Oracle DB instances.
        /// </para>
        ///  </note> 
        /// <para>
        /// Mounted DB replicas are included in Oracle Enterprise Edition. The main use case for
        /// mounted replicas is cross-Region disaster recovery. The primary database doesn't use
        /// Active Data Guard to transmit information to the mounted replica. Because it doesn't
        /// accept user connections, a mounted replica can't serve a read-only workload.
        /// </para>
        ///  
        /// <para>
        /// You can create a combination of mounted and read-only DB replicas for the same primary
        /// DB instance. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Working
        /// with Oracle Read Replicas for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        public ReplicaMode ReplicaMode
        {
            get { return this._replicaMode; }
            set { this._replicaMode = value; }
        }

        // Check to see if ReplicaMode property is set
        internal bool IsSetReplicaMode()
        {
            return this._replicaMode != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDBInstanceIdentifier. 
        /// <para>
        /// The identifier of the DB instance that will act as the source for the read replica.
        /// Each DB instance can have up to five read replicas.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier of an existing MySQL, MariaDB, Oracle, PostgreSQL, or SQL Server
        /// DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can specify a DB instance that is a MySQL read replica only if the source is running
        /// MySQL 5.6 or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the limitations of Oracle read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/oracle-read-replicas.html">Read
        /// Replica Limitations with Oracle</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the limitations of SQL Server read replicas, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/SQLServer.ReadReplicas.Limitations.html">Read
        /// Replica Limitations with Microsoft SQL Server</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can specify a PostgreSQL DB instance only if the source is running PostgreSQL 9.3.5
        /// or later (9.4.7 and higher for cross-region replication).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB instance must have automatic backups enabled, that is, its backup
        /// retention period must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in the same AWS Region as the read replica, specify a
        /// valid DB instance identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in a different AWS Region from the read replica, specify
        /// a valid DB instance ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">Constructing
        /// an ARN for Amazon RDS</a> in the <i>Amazon RDS User Guide</i>. This doesn't apply
        /// to SQL Server, which doesn't support cross-region replicas.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceDBInstanceIdentifier
        {
            get { return this._sourceDBInstanceIdentifier; }
            set { this._sourceDBInstanceIdentifier = value; }
        }

        // Check to see if SourceDBInstanceIdentifier property is set
        internal bool IsSetSourceDBInstanceIdentifier()
        {
            return this._sourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies the storage type to be associated with the read replica.
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>standard | gp2 | io1</code> 
        /// </para>
        ///  
        /// <para>
        ///  If you specify <code>io1</code>, you must also include a value for the <code>Iops</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        ///  Default: <code>io1</code> if the <code>Iops</code> parameter is specified, otherwise
        /// <code>gp2</code> 
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseDefaultProcessorFeatures. 
        /// <para>
        /// A value that indicates whether the DB instance class of the DB instance uses its default
        /// processor features.
        /// </para>
        /// </summary>
        public bool UseDefaultProcessorFeatures
        {
            get { return this._useDefaultProcessorFeatures.GetValueOrDefault(); }
            set { this._useDefaultProcessorFeatures = value; }
        }

        // Check to see if UseDefaultProcessorFeatures property is set
        internal bool IsSetUseDefaultProcessorFeatures()
        {
            return this._useDefaultProcessorFeatures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        ///  A list of EC2 VPC security groups to associate with the read replica. 
        /// </para>
        ///  
        /// <para>
        ///  Default: The default EC2 VPC security group for the DB subnet group's VPC. 
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

    }
}