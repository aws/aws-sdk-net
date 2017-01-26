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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBInstanceReadReplica operation.
    /// Creates a DB instance for a DB instance running MySQL, MariaDB, or PostgreSQL that
    /// acts as a Read Replica of a source DB instance.
    /// 
    ///  
    /// <para>
    /// All Read Replica DB instances are created as Single-AZ deployments with backups disabled.
    /// All other DB instance attributes (including DB security groups and DB parameter groups)
    /// are inherited from the source DB instance, except as specified below.
    /// </para>
    ///  <important> 
    /// <para>
    /// The source DB instance must have backup retention enabled.
    /// </para>
    ///  </important> 
    /// <para>
    /// You can create an encrypted Read Replica in a different AWS Region than the source
    /// DB instance. In that case, the region where you call the <code>CreateDBInstanceReadReplica</code>
    /// action is the destination region of the encrypted Read Replica. The source DB instance
    /// must be encrypted.
    /// </para>
    ///  
    /// <para>
    /// To create an encrypted Read Replica in another AWS Region, you must provide the following
    /// values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>KmsKeyId</code> - The AWS Key Management System (KMS) key identifier for the
    /// key to use to encrypt the Read Replica in the destination region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PreSignedUrl</code> - A URL that contains a Signature Version 4 signed request
    /// for the <code> CreateDBInstanceReadReplica</code> API action in the AWS region that
    /// contains the source DB instance. The <code>PreSignedUrl</code> parameter must be used
    /// when encrypting a Read Replica from another AWS region.
    /// </para>
    ///  
    /// <para>
    /// The presigned URL must be a valid request for the <code>CreateDBInstanceReadReplica</code>
    /// API action that can be executed in the source region that contains the encrypted DB
    /// instance. The presigned URL request must contain the following parameter values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>DestinationRegion</code> - The AWS Region that the Read Replica is created
    /// in. This region is the same one where the <code>CreateDBInstanceReadReplica</code>
    /// action is called that contains this presigned URL. 
    /// </para>
    ///  
    /// <para>
    ///  For example, if you create an encrypted Read Replica in the us-east-1 region, and
    /// the source DB instance is in the west-2 region, then you call the <code>CreateDBInstanceReadReplica</code>
    /// action in the us-east-1 region and provide a presigned URL that contains a call to
    /// the <code>CreateDBInstanceReadReplica</code> action in the us-west-2 region. For this
    /// example, the <code>DestinationRegion</code> in the presigned URL must be set to the
    /// us-east-1 region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KmsKeyId</code> - The KMS key identifier for the key to use to encrypt the
    /// Read Replica in the destination region. This is the same identifier for both the <code>CreateDBInstanceReadReplica</code>
    /// action that is called in the destination region, and the action contained in the presigned
    /// URL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SourceDBInstanceIdentifier</code> - The DB instance identifier for the encrypted
    /// Read Replica to be created. This identifier must be in the Amazon Resource Name (ARN)
    /// format for the source region. For example, if you create an encrypted Read Replica
    /// from a DB instance in the us-west-2 region, then your <code>SourceDBInstanceIdentifier</code>
    /// would look like this example: <code> arn:aws:rds:us-west-2:123456789012:instance:mysql-instance1-instance-20161115</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To learn how to generate a Signature Version 4 signed request, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
    /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html"> Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DBInstanceIdentifier</code> - The identifier for the encrypted Read Replica
    /// in the destination region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SourceDBInstanceIdentifier</code> - The DB instance identifier for the encrypted
    /// Read Replica. This identifier must be in the ARN format for the source region and
    /// is the same value as the <code>SourceDBInstanceIdentifier</code> in the presigned
    /// URL. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDBInstanceReadReplicaRequest : AmazonRDSRequest
    {
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private bool? _copyTagsToSnapshot;
        private string _dbInstanceClass;
        private string _dbInstanceIdentifier;
        private string _dbSubnetGroupName;
        private int? _iops;
        private string _kmsKeyId;
        private int? _monitoringInterval;
        private string _monitoringRoleArn;
        private string _optionGroupName;
        private int? _port;
        private string _preSignedUrl;
        private bool? _publiclyAccessible;
        private string _sourceDBInstanceIdentifier;
        private string _storageType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBInstanceReadReplicaRequest() { }

        /// <summary>
        /// Instantiates CreateDBInstanceReadReplicaRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier">The DB instance identifier of the Read Replica. This identifier is the unique key that identifies a DB instance. This parameter is stored as a lowercase string.</param>
        /// <param name="sourceDBInstanceIdentifier">The identifier of the DB instance that will act as the source for the Read Replica. Each DB instance can have up to five Read Replicas. Constraints: <ul> <li> Must be the identifier of an existing MySQL, MariaDB, or PostgreSQL DB instance. </li> <li> Can specify a DB instance that is a MySQL Read Replica only if the source is running MySQL 5.6. </li> <li> Can specify a DB instance that is a PostgreSQL DB instance only if the source is running PostgreSQL 9.3.5 or later. </li> <li> The specified DB instance must have automatic backups enabled, its backup retention period must be greater than 0. </li> <li> If the source DB instance is in the same region as the Read Replica, specify a valid DB instance identifier. </li> <li> If the source DB instance is in a different region than the Read Replica, specify a valid DB instance ARN. For more information, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing"> Constructing a Amazon RDS Amazon Resource Name (ARN)</a>. </li> </ul></param>
        public CreateDBInstanceReadReplicaRequest(string dbInstanceIdentifier, string sourceDBInstanceIdentifier)
        {
            _dbInstanceIdentifier = dbInstanceIdentifier;
            _sourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates that minor engine upgrades will be applied automatically to the Read Replica
        /// during the maintenance window.
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
        /// The Amazon EC2 Availability Zone that the Read Replica will be created in.
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone in the endpoint's region.
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
        /// True to copy all tags from the Read Replica to snapshots of the Read Replica; otherwise
        /// false. The default is false.
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
        /// The compute and memory capacity of the Read Replica. Note that not all instance classes
        /// are available in all regions for all DB engines.
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <code>db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge | db.m2.xlarge
        /// |db.m2.2xlarge | db.m2.4xlarge | db.m3.medium | db.m3.large | db.m3.xlarge | db.m3.2xlarge
        /// | db.m4.large | db.m4.xlarge | db.m4.2xlarge | db.m4.4xlarge | db.m4.10xlarge | db.r3.large
        /// | db.r3.xlarge | db.r3.2xlarge | db.r3.4xlarge | db.r3.8xlarge | db.t2.micro | db.t2.small
        /// | db.t2.medium | db.t2.large</code> 
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
        /// The DB instance identifier of the Read Replica. This identifier is the unique key
        /// that identifies a DB instance. This parameter is stored as a lowercase string.
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
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// Specifies a DB subnet group for the DB instance. The new DB instance will be created
        /// in the VPC associated with the DB subnet group. If no DB subnet group is specified,
        /// then the new DB instance is not created in a VPC.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can only be specified if the source DB instance identifier specifies a DB instance
        /// in another region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB subnet group must be in the same region in which the operation is
        /// running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All Read Replicas in one region that are created from the same source DB instance
        /// must either:&gt;
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify DB subnet groups from the same VPC. All these Read Replicas will be created
        /// in the same VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not specify a DB subnet group. All these Read Replicas will be created outside of
        /// any VPC.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters, periods, underscores,
        /// spaces, or hyphens. Must not be default.
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
        /// The AWS KMS key ID for an encrypted Read Replica. The KMS key ID is the Amazon Resource
        /// Name (ARN), KMS key identifier, or the KMS key alias for the KMS encryption key. 
        /// </para>
        ///  
        /// <para>
        /// If you create an unencrypted Read Replica and specify a value for the <code>KmsKeyId</code>
        /// parameter, Amazon RDS encrypts the target Read Replica using the specified KMS encryption
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// If you create an encrypted Read Replica from your AWS account, you can specify a value
        /// for <code>KmsKeyId</code> to encrypt the Read Replica with a new KMS encryption key.
        /// If you don't specify a value for <code>KmsKeyId</code>, then the Read Replica is encrypted
        /// with the same KMS key as the source DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  If you create an encrypted Read Replica in a different AWS region, then you must
        /// specify a KMS key for the destination AWS region. KMS encryption keys are specific
        /// to the region that they are created in, and you cannot use encryption keys from one
        /// region in another region.
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
        /// for the Read Replica. To disable collecting Enhanced Monitoring metrics, specify 0.
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
        /// The ARN for the IAM role that permits RDS to send enhanced monitoring metrics to CloudWatch
        /// Logs. For example, <code>arn:aws:iam:123456789012:role/emaccess</code>. For information
        /// on creating a monitoring role, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Monitoring.html#USER_Monitoring.OS.IAMRole">To
        /// create an IAM role for Amazon RDS Enhanced Monitoring</a>.
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
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group the DB instance will be associated with. If omitted, the default
        /// option group for the engine specified will be used.
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
        /// The URL that contains a Signature Version 4 signed request for the <code> CreateDBInstanceReadReplica</code>
        /// API action in the AWS region that contains the source DB instance. The <code>PreSignedUrl</code>
        /// parameter must be used when encrypting a Read Replica from another AWS region.
        /// </para>
        ///  
        /// <para>
        /// The presigned URL must be a valid request for the <code>CreateDBInstanceReadReplica</code>
        /// API action that can be executed in the source region that contains the encrypted DB
        /// instance. The presigned URL request must contain the following parameter values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DestinationRegion</code> - The AWS Region that the Read Replica is created
        /// in. This region is the same one where the <code>CreateDBInstanceReadReplica</code>
        /// action is called that contains this presigned URL. 
        /// </para>
        ///  
        /// <para>
        ///  For example, if you create an encrypted Read Replica in the us-east-1 region, and
        /// the source DB instance is in the west-2 region, then you call the <code>CreateDBInstanceReadReplica</code>
        /// action in the us-east-1 region and provide a presigned URL that contains a call to
        /// the <code>CreateDBInstanceReadReplica</code> action in the us-west-2 region. For this
        /// example, the <code>DestinationRegion</code> in the presigned URL must be set to the
        /// us-east-1 region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The KMS key identifier for the key to use to encrypt the
        /// Read Replica in the destination region. This is the same identifier for both the <code>CreateDBInstanceReadReplica</code>
        /// action that is called in the destination region, and the action contained in the presigned
        /// URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBInstanceIdentifier</code> - The DB instance identifier for the encrypted
        /// Read Replica to be created. This identifier must be in the Amazon Resource Name (ARN)
        /// format for the source region. For example, if you create an encrypted Read Replica
        /// from a DB instance in the us-west-2 region, then your <code>SourceDBInstanceIdentifier</code>
        /// would look like this example: <code> arn:aws:rds:us-west-2:123456789012:instance:mysql-instance1-instance-20161115</code>.
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies the accessibility options for the DB instance. A value of true specifies
        /// an Internet-facing instance with a publicly resolvable DNS name, which resolves to
        /// a public IP address. A value of false specifies an internal instance with a DNS name
        /// that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// Default: The default behavior varies depending on whether a VPC has been requested
        /// or not. The following list shows the default behavior in each case.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Default VPC:</b>true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VPC:</b>false
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If no DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance will be publicly accessible. If a specific
        /// DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance will be private.
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
        /// Gets and sets the property SourceDBInstanceIdentifier. 
        /// <para>
        /// The identifier of the DB instance that will act as the source for the Read Replica.
        /// Each DB instance can have up to five Read Replicas.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the identifier of an existing MySQL, MariaDB, or PostgreSQL DB instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can specify a DB instance that is a MySQL Read Replica only if the source is running
        /// MySQL 5.6.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can specify a DB instance that is a PostgreSQL DB instance only if the source is running
        /// PostgreSQL 9.3.5 or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The specified DB instance must have automatic backups enabled, its backup retention
        /// period must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in the same region as the Read Replica, specify a valid
        /// DB instance identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source DB instance is in a different region than the Read Replica, specify
        /// a valid DB instance ARN. For more information, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing a Amazon RDS Amazon Resource Name (ARN)</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Specifies the storage type to be associated with the Read Replica.
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
        ///  Default: <code>io1</code> if the <code>Iops</code> parameter is specified; otherwise
        /// <code>standard</code> 
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

    }
}