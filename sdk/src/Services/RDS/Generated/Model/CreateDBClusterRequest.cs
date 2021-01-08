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
    /// Container for the parameters to the CreateDBCluster operation.
    /// Creates a new Amazon Aurora DB cluster.
    /// 
    ///  
    /// <para>
    /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create the DB
    /// cluster as a read replica of another DB cluster or Amazon RDS MySQL DB instance. For
    /// cross-region replication where the DB cluster identified by <code>ReplicationSourceIdentifier</code>
    /// is encrypted, you must also specify the <code>PreSignedUrl</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This action only applies to Aurora DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDBClusterRequest : AmazonRDSRequest
    {
        private List<string> _availabilityZones = new List<string>();
        private long? _backtrackWindow;
        private int? _backupRetentionPeriod;
        private string _characterSetName;
        private bool? _copyTagsToSnapshot;
        private string _databaseName;
        private string _dbClusterIdentifier;
        private string _dbClusterParameterGroupName;
        private string _dbSubnetGroupName;
        private bool? _deletionProtection;
        private string _domain;
        private string _domainIAMRoleName;
        private List<string> _enableCloudwatchLogsExports = new List<string>();
        private bool? _enableGlobalWriteForwarding;
        private bool? _enableHttpEndpoint;
        private bool? _enableIAMDatabaseAuthentication;
        private string _engine;
        private string _engineMode;
        private string _engineVersion;
        private string _globalClusterIdentifier;
        private string _kmsKeyId;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _optionGroupName;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _preSignedUrl;
        private string _replicationSourceIdentifier;
        private ScalingConfiguration _scalingConfiguration;
        private bool? _storageEncrypted;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones (AZs) where instances in the DB cluster can be created.
        /// For information on AWS Regions and Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Concepts.RegionsAndAvailabilityZones.html">Choosing
        /// the Regions and Availability Zones</a> in the <i>Amazon Aurora User Guide</i>. 
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BacktrackWindow. 
        /// <para>
        /// The target backtrack window, in seconds. To disable backtracking, set this value to
        /// 0. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, Backtrack is only supported for Aurora MySQL DB clusters.
        /// </para>
        ///  </note> 
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
        /// </summary>
        public long BacktrackWindow
        {
            get { return this._backtrackWindow.GetValueOrDefault(); }
            set { this._backtrackWindow = value; }
        }

        // Check to see if BacktrackWindow property is set
        internal bool IsSetBacktrackWindow()
        {
            return this._backtrackWindow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be a value from 1 to 35
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this._backupRetentionPeriod.GetValueOrDefault(); }
            set { this._backupRetentionPeriod = value; }
        }

        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this._backupRetentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CharacterSetName. 
        /// <para>
        /// A value that indicates that the DB cluster should be associated with the specified
        /// CharacterSet.
        /// </para>
        /// </summary>
        public string CharacterSetName
        {
            get { return this._characterSetName; }
            set { this._characterSetName = value; }
        }

        // Check to see if CharacterSetName property is set
        internal bool IsSetCharacterSetName()
        {
            return this._characterSetName != null;
        }

        /// <summary>
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// A value that indicates whether to copy all tags from the DB cluster to snapshots of
        /// the DB cluster. The default is not to copy them.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name for your database of up to 64 alphanumeric characters. If you do not provide
        /// a name, Amazon RDS doesn't create a database in the DB cluster you are creating.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
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
        /// Example: <code>my-cluster1</code> 
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
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        ///  The name of the DB cluster parameter group to associate with this DB cluster. If
        /// you do not specify a value, then the default DB cluster parameter group for the specified
        /// DB engine and version is used. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DB cluster parameter group.
        /// </para>
        ///  </li> </ul>
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
        /// A DB subnet group to associate with this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must match the name of an existing DBSubnetGroup. Must not be default.
        /// </para>
        ///  
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
        /// A value that indicates whether the DB cluster has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection is disabled.
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
        /// The Active Directory directory ID to create the DB cluster in.
        /// </para>
        ///  
        /// <para>
        ///  For Amazon Aurora DB clusters, Amazon RDS can use Kerberos Authentication to authenticate
        /// users that connect to the DB cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/kerberos-authentication.html">Kerberos
        /// Authentication</a> in the <i>Amazon Aurora User Guide</i>. 
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
        /// The list of log types that need to be enabled for exporting to CloudWatch Logs. The
        /// values in the list depend on the DB engine being used. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_LogAccess.html#USER_LogAccess.Procedural.UploadtoCloudWatch">Publishing
        /// Database Logs to Amazon CloudWatch Logs</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>audit</code>, <code>error</code>, <code>general</code>,
        /// and <code>slowquery</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Possible values are <code>postgresql</code> and <code>upgrade</code>. 
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
        /// Gets and sets the property EnableGlobalWriteForwarding. 
        /// <para>
        /// A value that indicates whether to enable write operations to be forwarded from this
        /// cluster to the primary cluster in an Aurora global database. The resulting changes
        /// are replicated back to this cluster. This parameter only applies to DB clusters that
        /// are secondary clusters in an Aurora global database. By default, Aurora disallows
        /// write operations for secondary clusters.
        /// </para>
        /// </summary>
        public bool EnableGlobalWriteForwarding
        {
            get { return this._enableGlobalWriteForwarding.GetValueOrDefault(); }
            set { this._enableGlobalWriteForwarding = value; }
        }

        // Check to see if EnableGlobalWriteForwarding property is set
        internal bool IsSetEnableGlobalWriteForwarding()
        {
            return this._enableGlobalWriteForwarding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableHttpEndpoint. 
        /// <para>
        /// A value that indicates whether to enable the HTTP endpoint for an Aurora Serverless
        /// DB cluster. By default, the HTTP endpoint is disabled.
        /// </para>
        ///  
        /// <para>
        /// When enabled, the HTTP endpoint provides a connectionless web service API for running
        /// SQL queries on the Aurora Serverless DB cluster. You can also query your database
        /// from inside the RDS console with the query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// the Data API for Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public bool EnableHttpEndpoint
        {
            get { return this._enableHttpEndpoint.GetValueOrDefault(); }
            set { this._enableHttpEndpoint = value; }
        }

        // Check to see if EnableHttpEndpoint property is set
        internal bool IsSetEnableHttpEndpoint()
        {
            return this._enableHttpEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// A value that indicates whether to enable mapping of AWS Identity and Access Management
        /// (IAM) accounts to database accounts. By default, mapping is disabled.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.IAMDBAuth.html">
        /// IAM Database Authentication</a> in the <i>Amazon Aurora User Guide.</i> 
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine to be used for this DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>aurora</code> (for MySQL 5.6-compatible Aurora), <code>aurora-mysql</code>
        /// (for MySQL 5.7-compatible Aurora), and <code>aurora-postgresql</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EngineMode. 
        /// <para>
        /// The DB engine mode of the DB cluster, either <code>provisioned</code> <code>serverless</code>,
        /// <code>parallelquery</code>, <code>global</code>, or <code>multimaster</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>parallelquery</code> engine mode isn't required for Aurora MySQL version
        /// 1.23 and higher 1.x versions, and version 2.09 and higher 2.x versions.
        /// </para>
        ///  
        /// <para>
        /// The <code>global</code> engine mode isn't required for Aurora MySQL version 1.22 and
        /// higher 1.x versions, and <code>global</code> engine mode isn't required for any 2.x
        /// versions.
        /// </para>
        ///  
        /// <para>
        /// The <code>multimaster</code> engine mode only applies for DB clusters created with
        /// Aurora MySQL version 5.6.10a.
        /// </para>
        ///  
        /// <para>
        /// For Aurora PostgreSQL, the <code>global</code> engine mode isn't required, and both
        /// the <code>parallelquery</code> and the <code>multimaster</code> engine modes currently
        /// aren't supported.
        /// </para>
        ///  
        /// <para>
        /// Limitations and requirements apply to some DB engine modes. For more information,
        /// see the following sections in the <i>Amazon Aurora User Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html#aurora-serverless.limitations">
        /// Limitations of Aurora Serverless</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-mysql-parallel-query.html#aurora-mysql-parallel-query-limitations">
        /// Limitations of Parallel Query</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database.html#aurora-global-database.limitations">
        /// Limitations of Aurora Global Databases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-multi-master.html#aurora-multi-master-limitations">
        /// Limitations of Multi-Master Clusters</a> 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to use.
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for <code>aurora</code> (for MySQL 5.6-compatible
        /// Aurora), use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws rds describe-db-engine-versions --engine aurora --query "DBEngineVersions[].EngineVersion"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for <code>aurora-mysql</code> (for MySQL
        /// 5.7-compatible Aurora), use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws rds describe-db-engine-versions --engine aurora-mysql --query "DBEngineVersions[].EngineVersion"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for <code>aurora-postgresql</code>, use
        /// the following command:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws rds describe-db-engine-versions --engine aurora-postgresql --query "DBEngineVersions[].EngineVersion"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>5.6.10a</code>, <code>5.6.mysql_aurora.1.19.2</code>, <code>5.7.12</code>,
        /// <code>5.7.mysql_aurora.2.04.5</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>9.6.3</code>, <code>10.7</code> 
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
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        ///  The global cluster ID of an Aurora cluster that becomes the primary cluster in the
        /// new global database cluster. 
        /// </para>
        /// </summary>
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier for an encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The AWS KMS key identifier is the key ARN, key ID, alias ARN, or alias name for the
        /// AWS KMS customer master key (CMK). To use a CMK in a different AWS account, specify
        /// the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// When a CMK isn't specified in <code>KmsKeyId</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>ReplicationSourceIdentifier</code> identifies an encrypted source, then Amazon
        /// RDS will use the CMK used to encrypt the source. Otherwise, Amazon RDS will use your
        /// default CMK. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>StorageEncrypted</code> parameter is enabled and <code>ReplicationSourceIdentifier</code>
        /// isn't specified, then Amazon RDS will use your default CMK.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// There is a default CMK for your AWS account. Your AWS account has a different default
        /// CMK for each AWS Region.
        /// </para>
        ///  
        /// <para>
        /// If you create a read replica of an encrypted DB cluster in another AWS Region, you
        /// must set <code>KmsKeyId</code> to a AWS KMS key identifier that is valid in the destination
        /// AWS Region. This CMK is used to encrypt the read replica in that AWS Region.
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
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The name of the master user for the DB cluster.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 16 letters or numbers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be a reserved word for the chosen database engine.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The password for the master database user. This password can contain any printable
        /// ASCII character except "/", """, or "@".
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 41 characters.
        /// </para>
        /// </summary>
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// A value that indicates that the DB cluster should be associated with the specified
        /// option group.
        /// </para>
        ///  
        /// <para>
        /// Permanent options can't be removed from an option group. The option group can't be
        /// removed from a DB cluster once it is associated with a DB cluster.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the instances in the DB cluster accept connections.
        /// </para>
        ///  
        /// <para>
        ///  Default: <code>3306</code> if engine is set as aurora or <code>5432</code> if set
        /// to aurora-postgresql. 
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
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created if automated backups
        /// are enabled using the <code>BackupRetentionPeriod</code> parameter. 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region. To see the time blocks available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow.Aurora">
        /// Adjusting the Preferred DB Cluster Maintenance Window</a> in the <i>Amazon Aurora
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the format <code>hh24:mi-hh24:mi</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be in Universal Coordinated Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
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
        /// The weekly time range during which system maintenance can occur, in Universal Coordinated
        /// Time (UTC).
        /// </para>
        ///  
        /// <para>
        /// Format: <code>ddd:hh24:mi-ddd:hh24:mi</code> 
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each AWS Region, occurring on a random day of the week. To see the time blocks
        /// available, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_UpgradeDBInstance.Maintenance.html#AdjustingTheMaintenanceWindow.Aurora">
        /// Adjusting the Preferred DB Cluster Maintenance Window</a> in the <i>Amazon Aurora
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Valid Days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum 30-minute window.
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
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// A URL that contains a Signature Version 4 signed request for the <code>CreateDBCluster</code>
        /// action to be called in the source AWS Region where the DB cluster is replicated from.
        /// You only need to specify <code>PreSignedUrl</code> when you are performing cross-region
        /// replication from an encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The pre-signed URL must be a valid request for the <code>CreateDBCluster</code> API
        /// action that can be executed in the source AWS Region that contains the encrypted DB
        /// cluster to be copied.
        /// </para>
        ///  
        /// <para>
        /// The pre-signed URL request must contain the following parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The AWS KMS key identifier for the key to use to encrypt
        /// the copy of the DB cluster in the destination AWS Region. This should refer to the
        /// same AWS KMS CMK for both the <code>CreateDBCluster</code> action that is called in
        /// the destination AWS Region, and the action contained in the pre-signed URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The name of the AWS Region that Aurora read replica
        /// will be created in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplicationSourceIdentifier</code> - The DB cluster identifier for the encrypted
        /// DB cluster to be copied. This identifier must be in the Amazon Resource Name (ARN)
        /// format for the source AWS Region. For example, if you are copying an encrypted DB
        /// cluster from the us-west-2 AWS Region, then your <code>ReplicationSourceIdentifier</code>
        /// would look like Example: <code>arn:aws:rds:us-west-2:123456789012:cluster:aurora-cluster1</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
        /// Signature Version 4 Signing Process</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
        /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
        /// manually. Specifying <code>SourceRegion</code> autogenerates a pre-signed URL that
        /// is a valid request for the operation that can be executed in the source AWS Region.
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
        /// Gets and sets the property ReplicationSourceIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source DB instance or DB cluster if this DB
        /// cluster is created as a read replica.
        /// </para>
        /// </summary>
        public string ReplicationSourceIdentifier
        {
            get { return this._replicationSourceIdentifier; }
            set { this._replicationSourceIdentifier = value; }
        }

        // Check to see if ReplicationSourceIdentifier property is set
        internal bool IsSetReplicationSourceIdentifier()
        {
            return this._replicationSourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingConfiguration. 
        /// <para>
        /// For DB clusters in <code>serverless</code> DB engine mode, the scaling properties
        /// of the DB cluster.
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
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// A value that indicates whether the DB cluster is encrypted.
        /// </para>
        /// </summary>
        public bool StorageEncrypted
        {
            get { return this._storageEncrypted.GetValueOrDefault(); }
            set { this._storageEncrypted = value; }
        }

        // Check to see if StorageEncrypted property is set
        internal bool IsSetStorageEncrypted()
        {
            return this._storageEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the DB cluster.
        /// </para>
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with this DB cluster.
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