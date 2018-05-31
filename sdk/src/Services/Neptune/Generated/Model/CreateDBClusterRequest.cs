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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBCluster operation.
    /// Creates a new Amazon Aurora DB cluster.
    /// 
    ///  
    /// <para>
    /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create the DB
    /// cluster as a Read Replica of another DB cluster or Amazon Neptune MySQL DB instance.
    /// For cross-region replication where the DB cluster identified by <code>ReplicationSourceIdentifier</code>
    /// is encrypted, you must also specify the <code>PreSignedUrl</code> parameter.
    /// </para>
    ///  
    /// <para>
    /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
    /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class CreateDBClusterRequest : AmazonNeptuneRequest
    {
        private List<string> _availabilityZones = new List<string>();
        private int? _backupRetentionPeriod;
        private string _characterSetName;
        private string _databaseName;
        private string _dbClusterIdentifier;
        private string _dbClusterParameterGroupName;
        private string _dbSubnetGroupName;
        private bool? _enableIAMDatabaseAuthentication;
        private string _engine;
        private string _engineVersion;
        private string _kmsKeyId;
        private string _masterUsername;
        private string _masterUserPassword;
        private string _optionGroupName;
        private int? _port;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private string _preSignedUrl;
        private string _replicationSourceIdentifier;
        private bool? _storageEncrypted;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _vpcSecurityGroupIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of EC2 Availability Zones that instances in the DB cluster can be created in.
        /// For information on AWS Regions and Availability Zones, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RegionsAndAvailabilityZones.html">Regions
        /// and Availability Zones</a>. 
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
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The number of days for which automated backups are retained. You must specify a minimum
        /// value of 1.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name for your database of up to 64 alpha-numeric characters. If you do not provide
        /// a name, Amazon Neptune will not create a database in the DB cluster you are creating.
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
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-cluster1</code> 
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
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        ///  The name of the DB cluster parameter group to associate with this DB cluster. If
        /// this argument is omitted, <code>default.aurora5.6</code> is used. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DBClusterParameterGroup.
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
        /// Gets and sets the property EnableIAMDatabaseAuthentication. 
        /// <para>
        /// True to enable mapping of AWS Identity and Access Management (IAM) accounts to database
        /// accounts, and otherwise false.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
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
        /// The version number of the database engine to use.
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>5.6.10a</code>, <code>5.7.12</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>9.6.3</code> 
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS KMS key identifier for an encrypted DB cluster.
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are creating a DB cluster with the same AWS account that owns the KMS encryption
        /// key used to encrypt the new DB cluster, then you can use the KMS key alias instead
        /// of the ARN for the KMS encryption key.
        /// </para>
        ///  
        /// <para>
        /// If an encryption key is not specified in <code>KmsKeyId</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>ReplicationSourceIdentifier</code> identifies an encrypted source, then Amazon
        /// Neptune will use the encryption key used to encrypt the source. Otherwise, Amazon
        /// Neptune will use your default encryption key. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>StorageEncrypted</code> parameter is true and <code>ReplicationSourceIdentifier</code>
        /// is not specified, then Amazon Neptune will use your default encryption key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS KMS creates the default encryption key for your AWS account. Your AWS account
        /// has a different default encryption key for each AWS Region.
        /// </para>
        ///  
        /// <para>
        /// If you create a Read Replica of an encrypted DB cluster in another AWS Region, you
        /// must set <code>KmsKeyId</code> to a KMS key ID that is valid in the destination AWS
        /// Region. This key is used to encrypt the Read Replica in that AWS Region.
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
        /// Cannot be a reserved word for the chosen database engine.
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
        /// for each AWS Region. To see the time blocks available, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/AdjustingTheMaintenanceWindow.html">
        /// Adjusting the Preferred Maintenance Window</a> in the <i>Amazon Neptune User Guide.</i>
        /// 
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
        /// available, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/AdjustingTheMaintenanceWindow.html">
        /// Adjusting the Preferred Maintenance Window</a> in the <i>Amazon Neptune User Guide.</i>
        /// 
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
        /// same KMS key for both the <code>CreateDBCluster</code> action that is called in the
        /// destination AWS Region, and the action contained in the pre-signed URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The name of the AWS Region that Aurora Read Replica
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
        /// To learn how to generate a Signature Version 4 signed request, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html"> Signature
        /// Version 4 Signing Process</a>.
        /// </para>
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
        /// cluster is created as a Read Replica.
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
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the DB cluster is encrypted.
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